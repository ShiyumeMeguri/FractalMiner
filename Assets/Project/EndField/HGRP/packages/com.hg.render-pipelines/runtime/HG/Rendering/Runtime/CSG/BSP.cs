using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

namespace HG.Rendering.Runtime.CSG
{
	[Serializable]
	public class BSP : ICsgProvider
	{
		// (get) Token: 0x06001C66 RID: 7270 RVA: 0x000025D2 File Offset: 0x000007D2
		public IEnumerable<object> Description
		{
			get
			{
				// // IEnumerable`1[System.Object] get_Description()
				// IEnumerable_1_System_Object_ *HG::Rendering::Runtime::CSG::BSP::get_Description(BSP *this, MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v5; // rdx
				//   __int64 v6; // rcx
				// 
				//   if ( !IFix::WrappersManagerImpl::IsPatched(4708, 0LL) )
				//     return (IEnumerable_1_System_Object_ *)this.fields.description;
				//   Patch = IFix::WrappersManagerImpl::GetPatch(4708, 0LL);
				//   if ( !Patch )
				//     sub_180B536AC(v6, v5);
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1350(Patch, (Object *)this, 0LL);
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06001C67 RID: 7271 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06001C68 RID: 7272 RVA: 0x000025D0 File Offset: 0x000007D0
		public Nullable<Bounds> Bounds
		{
			[CompilerGenerated]
			get
			{
				// // Nullable`1[UnityEngine.Bounds] get_Bounds()
				// Nullable_1_UnityEngine_Bounds_ *HG::Rendering::Runtime::CSG::BSP::get_Bounds(
				//         Nullable_1_UnityEngine_Bounds_ *__return_ptr retstr,
				//         BSP *this,
				//         MethodInfo *method)
				// {
				//   float z; // eax
				//   __int64 v4; // xmm1_8
				// 
				//   z = this.fields._Bounds_k__BackingField.value.m_Extents.z;
				//   v4 = *(_QWORD *)&this.fields._Bounds_k__BackingField.value.m_Extents.x;
				//   *(_OWORD *)&retstr.hasValue = *(_OWORD *)&this.fields._Bounds_k__BackingField.hasValue;
				//   *(_QWORD *)&retstr.value.m_Extents.x = v4;
				//   retstr.value.m_Extents.z = z;
				//   return retstr;
				// }
				// 
				return null;
			}
			[CompilerGenerated]
			private set
			{
				// // Void set_Bounds(Nullable`1[UnityEngine.Bounds])
				// void HG::Rendering::Runtime::CSG::BSP::set_Bounds(BSP *this, Nullable_1_UnityEngine_Bounds_ *value, MethodInfo *method)
				// {
				//   float z; // eax
				//   __int64 v4; // xmm1_8
				// 
				//   z = value.value.m_Extents.z;
				//   v4 = *(_QWORD *)&value.value.m_Extents.x;
				//   *(_OWORD *)&this.fields._Bounds_k__BackingField.hasValue = *(_OWORD *)&value.hasValue;
				//   *(_QWORD *)&this.fields._Bounds_k__BackingField.value.m_Extents.x = v4;
				//   this.fields._Bounds_k__BackingField.value.m_Extents.z = z;
				// }
				// 
			}
		}

		// (get) Token: 0x06001C69 RID: 7273 RVA: 0x000025D2 File Offset: 0x000007D2
		public IEnumerable<CSGPolygon> Polygons
		{
			get
			{
				// // IEnumerable`1[HG.Rendering.Runtime.CSG.CSGPolygon] get_Polygons()
				// IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *HG::Rendering::Runtime::CSG::BSP::get_Polygons(
				//         BSP *this,
				//         MethodInfo *method)
				// {
				//   __int64 v3; // rdx
				//   Node_2 *root; // rcx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !IFix::WrappersManagerImpl::IsPatched(4709, 0LL) )
				//   {
				//     root = this.fields.root;
				//     if ( root )
				//       return HG::Rendering::Runtime::CSG::Node::get_AllPolygons(root, 0LL);
				// LABEL_5:
				//     sub_180B536AC(root, v3);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(4709, 0LL);
				//   if ( !Patch )
				//     goto LABEL_5;
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1321(Patch, (Object *)this, 0LL);
				// }
				// 
				return null;
			}
		}

		// (add) Token: 0x06001C6A RID: 7274 RVA: 0x000025D0 File Offset: 0x000007D0
		// (remove) Token: 0x06001C6B RID: 7275 RVA: 0x000025D0 File Offset: 0x000007D0
		public event Action OnChange
		{
			[CompilerGenerated]
			add
			{
				// // Void add_OnChange(Action)
				// void HG::Rendering::Runtime::CSG::BSP::add_OnChange(BSP *this, Action *value, MethodInfo *method)
				// {
				//   Delegate *OnChange; // rdi
				//   Delegate *v6; // rbp
				//   Delegate *v7; // rax
				// 
				//   if ( !byte_18D91984F )
				//   {
				//     sub_18003C530(&TypeInfo::System::Action);
				//     byte_18D91984F = 1;
				//   }
				//   OnChange = (Delegate *)this.fields.OnChange;
				//   do
				//   {
				//     v6 = OnChange;
				//     v7 = System::Delegate::Combine(OnChange, (Delegate *)value, 0LL);
				//     if ( v7 )
				//     {
				//       if ( (struct Action__Class *)v7.klass != TypeInfo::System::Action )
				//         sub_1802DC21C(v7, TypeInfo::System::Action);
				//     }
				//     OnChange = (Delegate *)sub_180011DB0(&this.fields.OnChange, v7, OnChange);
				//   }
				//   while ( OnChange != v6 );
				// }
				// 
			}
			[CompilerGenerated]
			remove
			{
				// // Void remove_OnChange(Action)
				// void HG::Rendering::Runtime::CSG::BSP::remove_OnChange(BSP *this, Action *value, MethodInfo *method)
				// {
				//   Delegate *OnChange; // rdi
				//   Delegate *v6; // rbp
				//   Delegate *v7; // rax
				// 
				//   if ( !byte_18D919850 )
				//   {
				//     sub_18003C530(&TypeInfo::System::Action);
				//     byte_18D919850 = 1;
				//   }
				//   OnChange = (Delegate *)this.fields.OnChange;
				//   do
				//   {
				//     v6 = OnChange;
				//     v7 = System::Delegate::Remove(OnChange, (Delegate *)value, 0LL);
				//     if ( v7 )
				//     {
				//       if ( (struct Action__Class *)v7.klass != TypeInfo::System::Action )
				//         sub_1802DC21C(v7, TypeInfo::System::Action);
				//     }
				//     OnChange = (Delegate *)sub_180011DB0(&this.fields.OnChange, v7, OnChange);
				//   }
				//   while ( OnChange != v6 );
				// }
				// 
			}
		}

		public BSP(bool createDescription)
		{
			// // BSP(Boolean)
			// void HG::Rendering::Runtime::CSG::BSP::BSP(BSP *this, bool createDescription, MethodInfo *method)
			// {
			//   Node_2 *v5; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Node_2 *v8; // rbx
			//   __int64 v9; // r8
			//   __int64 v10; // r9
			//   __int128 v11; // xmm0
			//   Object__Array *v12; // rax
			//   Nullable_1_UnityEngine_Bounds_ v13; // [rsp+30h] [rbp-48h] BYREF
			//   __int64 v14; // [rsp+60h] [rbp-18h]
			// 
			//   if ( !byte_18D919851 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CSG::Node);
			//     sub_18003C530(&TypeInfo::System::Object);
			//     byte_18D919851 = 1;
			//   }
			//   v5 = (Node_2 *)sub_180004920(TypeInfo::HG::Rendering::Runtime::CSG::Node);
			//   v8 = v5;
			//   if ( !v5 )
			//     sub_180B536AC(v7, v6);
			//   HG::Rendering::Runtime::CSG::Node::Node(v5, 0LL);
			//   v11 = 0LL;
			//   v14 = 0LL;
			//   if ( createDescription )
			//   {
			//     v12 = (Object__Array *)il2cpp_array_new_specific_0(TypeInfo::System::Object, 0LL, v9, v10);
			//     v11 = 0LL;
			//   }
			//   else
			//   {
			//     v12 = 0LL;
			//   }
			//   *(_OWORD *)&v13.hasValue = v11;
			//   *(_QWORD *)&v13.value.m_Extents.x = v14;
			//   v13.value.m_Extents.z = 0.0;
			//   HG::Rendering::Runtime::CSG::BSP::BSP(this, v8, &v13, v12, 1, 0LL);
			//   this.fields._createDescription = createDescription;
			// }
			// 
		}

		protected BSP(IEnumerable<CSGPolygon> polygons, Bounds bounds, object[] description, bool createDescription)
		{
			// // BSP(IEnumerable`1[HG.Rendering.Runtime.CSG.CSGPolygon], Bounds, Object[], Boolean)
			// // local variable allocation has failed, the output may be wrong!
			// void HG::Rendering::Runtime::CSG::BSP::BSP(
			//         BSP *this,
			//         IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *polygons,
			//         Bounds *bounds,
			//         Object__Array *description,
			//         bool createDescription,
			//         MethodInfo *method)
			// {
			//   __int64 v10; // rdx
			//   Node_2 *root; // rcx
			//   __int64 v12; // xmm1_8
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v13; // rdx
			//   Bounds *v14; // r8
			//   Object__Array *v15; // r9
			//   _BYTE v16[24]; // [rsp+20h] [rbp-28h]
			// 
			//   if ( !byte_18D919852 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Nullable<UnityEngine::Bounds>::Nullable);
			//     byte_18D919852 = 1;
			//   }
			//   HG::Rendering::Runtime::CSG::BSP::BSP(this, 1, 0LL);
			//   root = this.fields.root;
			//   this.fields._createDescription = createDescription;
			//   if ( !root )
			//     sub_180B536AC(0LL, v10);
			//   HG::Rendering::Runtime::CSG::Node::Build(root, polygons, 0LL);
			//   v12 = *(_QWORD *)&bounds.m_Extents.y;
			//   this.fields.description = description;
			//   *(_DWORD *)v16 = 1;
			//   *(_DWORD *)&v16[20] = v12;
			//   *(_OWORD *)&v16[4] = *(_OWORD *)&bounds.m_Center.x;
			//   *(_OWORD *)&this.fields._Bounds_k__BackingField.hasValue = *(_OWORD *)v16;
			//   *(_QWORD *)&this.fields._Bounds_k__BackingField.value.m_Extents.x = *(_QWORD *)&v16[16];
			//   this.fields._Bounds_k__BackingField.value.m_Extents.z = *((float *)&v12 + 1);
			//   sub_1800054D0((BSP *)&this.fields.description, v13, v14, v15, (MethodInfo *)createDescription, method);
			// }
			// 
		}

		private BSP(Node root, Nullable<Bounds> bounds, object[] description, bool createDescription)
		{
		}

		public BSP Clone()
		{
			// // BSP Clone()
			// BSP *HG::Rendering::Runtime::CSG::BSP::Clone(BSP *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   Node_2 *root; // rcx
			//   Node_2 *v5; // rdi
			//   float z; // esi
			//   Object__Array *description; // rbp
			//   bool createDescription; // r14
			//   BSP *v9; // rax
			//   BSP *v10; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Nullable_1_UnityEngine_Bounds_ v13; // [rsp+30h] [rbp-38h] BYREF
			//   __int64 v14; // [rsp+80h] [rbp+18h]
			// 
			//   if ( !byte_18D919853 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CSG::BSP);
			//     byte_18D919853 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4710, 0LL) )
			//   {
			//     root = this.fields.root;
			//     if ( root )
			//     {
			//       v5 = HG::Rendering::Runtime::CSG::Node::Clone(root, 0LL);
			//       z = this.fields._Bounds_k__BackingField.value.m_Extents.z;
			//       description = this.fields.description;
			//       createDescription = this.fields._createDescription;
			//       *(_OWORD *)&v13.hasValue = *(_OWORD *)&this.fields._Bounds_k__BackingField.hasValue;
			//       v14 = *(_QWORD *)&this.fields._Bounds_k__BackingField.value.m_Extents.x;
			//       v9 = (BSP *)sub_180004920(TypeInfo::HG::Rendering::Runtime::CSG::BSP);
			//       v10 = v9;
			//       if ( v9 )
			//       {
			//         *(_QWORD *)&v13.value.m_Extents.x = v14;
			//         v13.value.m_Extents.z = z;
			//         HG::Rendering::Runtime::CSG::BSP::BSP(v9, v5, &v13, description, createDescription, 0LL);
			//         return v10;
			//       }
			//     }
			// LABEL_8:
			//     sub_180B536AC(root, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4710, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1351(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		private object[] CreateDescription(string operation, object[] existing, params object[] args)
		{
			// // Object[] CreateDescription(String, Object[], Object[])
			// Object__Array *HG::Rendering::Runtime::CSG::BSP::CreateDescription(
			//         BSP *this,
			//         String *operation,
			//         Object__Array *existing,
			//         Object__Array *args,
			//         MethodInfo *method)
			// {
			//   Object__Array *v5; // rbx
			//   __int64 v10; // r8
			//   __int64 v11; // r9
			//   __int64 v12; // rax
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   IEnumerable_1_System_Object_ *v15; // rdi
			//   IEnumerable_1_System_Object_ *v16; // rax
			//   IEnumerable_1_System_Object_ *v17; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   v5 = 0LL;
			//   if ( !byte_18D919854 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Linq::Enumerable::ToArray<System::Object>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::CSG::Extensions::Append<System::Object>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
			//     sub_18003C530(&TypeInfo::System::Object);
			//     byte_18D919854 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4617, 0LL) )
			//   {
			//     if ( !this.fields._createDescription )
			//       return v5;
			//     v12 = il2cpp_array_new_specific_0(TypeInfo::System::Object, 1LL, v10, v11);
			//     v15 = (IEnumerable_1_System_Object_ *)v12;
			//     if ( v12 )
			//     {
			//       sub_180036D40(v12, operation);
			//       sub_1800046C0(v15, 0LL, operation);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
			//       v16 = HG::Rendering::Runtime::CSG::Extensions::Append<System::Object>(
			//               v15,
			//               existing,
			//               MethodInfo::HG::Rendering::Runtime::CSG::Extensions::Append<System::Object>);
			//       v17 = HG::Rendering::Runtime::CSG::Extensions::Append<System::Object>(
			//               v16,
			//               args,
			//               MethodInfo::HG::Rendering::Runtime::CSG::Extensions::Append<System::Object>);
			//       return System::Linq::Enumerable::ToArray<System::Object>(
			//                v17,
			//                MethodInfo::System::Linq::Enumerable::ToArray<System::Object>);
			//     }
			// LABEL_9:
			//     sub_180B536AC(v14, v13);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4617, 0LL);
			//   if ( !Patch )
			//     goto LABEL_9;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1322(
			//            Patch,
			//            (Object *)this,
			//            (Object *)operation,
			//            (Object *)existing,
			//            (Object *)args,
			//            0LL);
			// }
			// 
			return null;
		}

		private Nullable<Bounds> MeasureBounds(BSP bsp)
		{
			// // Nullable`1[UnityEngine.Bounds] MeasureBounds(BSP)
			// // Hidden C++ exception states: #wind=1
			// Nullable_1_UnityEngine_Bounds_ *HG::Rendering::Runtime::CSG::BSP::MeasureBounds(
			//         Nullable_1_UnityEngine_Bounds_ *__return_ptr retstr,
			//         BSP *this,
			//         BSP *bsp,
			//         MethodInfo *method)
			// {
			//   Nullable_1_UnityEngine_Bounds_ *v6; // rbx
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   float z; // esi
			//   IEnumerable_1_System_Object_ *Polygons; // r15
			//   Func_2_HG_Rendering_Runtime_CSG_CSGPolygon_System_Collections_Generic_IEnumerable_1_HG_Rendering_Runtime_CSG_CSGVertex_ *_9__26_0; // rdi
			//   Object *v12; // r14
			//   Func_2_Object_Object_ *v13; // rax
			//   __int64 v14; // rdx
			//   __int64 v15; // rcx
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v16; // rdx
			//   Bounds *v17; // r8
			//   Object__Array *v18; // r9
			//   IEnumerable_1_System_Object_ *v19; // r15
			//   Func_2_HG_Rendering_Runtime_CSG_CSGVertex_UnityEngine_Vector3_ *_9__26_1; // rdi
			//   Object *v21; // r14
			//   Func_2_Object_UnityEngine_Vector3_ *v22; // rax
			//   __int64 v23; // rdx
			//   __int64 v24; // rcx
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v25; // rdx
			//   Bounds *v26; // r8
			//   Object__Array *v27; // r9
			//   IEnumerable_1_UnityEngine_Vector3_ *v28; // rax
			//   __int64 v29; // rdx
			//   __int64 v30; // rcx
			//   __int64 v31; // rdx
			//   __int64 v32; // rcx
			//   __int64 v33; // rdx
			//   __int64 v34; // rcx
			//   __int64 v35; // rax
			//   float v36; // r14d
			//   char v37; // di
			//   __int128 v38; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v40; // rdx
			//   __int64 v41; // rcx
			//   MethodInfo *v43; // [rsp+20h] [rbp-108h]
			//   MethodInfo *v44; // [rsp+28h] [rbp-100h]
			//   __int64 v45; // [rsp+30h] [rbp-F8h] BYREF
			//   _BYTE v46[28]; // [rsp+40h] [rbp-E8h] BYREF
			//   Nullable_1_UnityEngine_Bounds_ v47; // [rsp+60h] [rbp-C8h] BYREF
			//   Bounds v48; // [rsp+80h] [rbp-A8h] BYREF
			//   _QWORD v49[2]; // [rsp+98h] [rbp-90h] BYREF
			//   __int64 v50; // [rsp+A8h] [rbp-80h]
			//   Vector3 v51; // [rsp+B0h] [rbp-78h] BYREF
			//   Vector3 v52; // [rsp+C0h] [rbp-68h] BYREF
			//   Vector3 v53; // [rsp+D0h] [rbp-58h] BYREF
			//   FormationSetting_FormationSlot v54; // [rsp+E0h] [rbp-48h] BYREF
			//   Il2CppExceptionWrapper *v55; // [rsp+F8h] [rbp-30h] BYREF
			//   _BYTE v56[16]; // [rsp+100h] [rbp-28h] BYREF
			// 
			//   v6 = retstr;
			//   if ( !byte_18D919855 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Linq::Enumerable::SelectMany<HG::Rendering::Runtime::CSG::CSGPolygon,HG::Rendering::Runtime::CSG::CSGVertex>);
			//     sub_18003C530(&MethodInfo::System::Linq::Enumerable::Select<HG::Rendering::Runtime::CSG::CSGVertex,UnityEngine::Vector3>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
			//     sub_18003C530(&TypeInfo::System::Func<HG::Rendering::Runtime::CSG::CSGPolygon,System::Collections::Generic::IEnumerable<HG::Rendering::Runtime::CSG::CSGVertex>>);
			//     sub_18003C530(&TypeInfo::System::Func<HG::Rendering::Runtime::CSG::CSGVertex,UnityEngine::Vector3>);
			//     sub_18003C530(&TypeInfo::System::IDisposable);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::IEnumerable<UnityEngine::Vector3>);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::IEnumerator<UnityEngine::Vector3>);
			//     sub_18003C530(&TypeInfo::System::Collections::IEnumerator);
			//     sub_18003C530(&MethodInfo::System::Nullable<UnityEngine::Bounds>::Nullable);
			//     sub_18003C530(&MethodInfo::System::Nullable<UnityEngine::Bounds>::get_HasValue);
			//     sub_18003C530(&MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::CSG::BSP::__c::_MeasureBounds_b__26_0);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::CSG::BSP::__c::_MeasureBounds_b__26_1);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CSG::BSP::__c);
			//     byte_18D919855 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4711, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4711, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v41, v40);
			//     *v6 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1353(&v47, Patch, (Object *)this, (Object *)bsp, 0LL);
			//   }
			//   else
			//   {
			//     *(_OWORD *)&v48.m_Center.x = 0LL;
			//     z = 0.0;
			//     memset(&v47, 0, sizeof(v47));
			//     if ( !bsp )
			//       sub_180B536AC(v8, v7);
			//     Polygons = (IEnumerable_1_System_Object_ *)HG::Rendering::Runtime::CSG::BSP::get_Polygons(bsp, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::CSG::BSP::__c);
			//     _9__26_0 = TypeInfo::HG::Rendering::Runtime::CSG::BSP::__c.static_fields.__9__26_0;
			//     if ( !_9__26_0 )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::CSG::BSP::__c);
			//       v12 = (Object *)TypeInfo::HG::Rendering::Runtime::CSG::BSP::__c.static_fields.__9;
			//       v13 = (Func_2_Object_Object_ *)sub_180004920(TypeInfo::System::Func<HG::Rendering::Runtime::CSG::CSGPolygon,System::Collections::Generic::IEnumerable<HG::Rendering::Runtime::CSG::CSGVertex>>);
			//       _9__26_0 = (Func_2_HG_Rendering_Runtime_CSG_CSGPolygon_System_Collections_Generic_IEnumerable_1_HG_Rendering_Runtime_CSG_CSGVertex_ *)v13;
			//       if ( !v13 )
			//         sub_180B536AC(v15, v14);
			//       System::Func<System::Object,System::Object>::Func(
			//         v13,
			//         v12,
			//         MethodInfo::HG::Rendering::Runtime::CSG::BSP::__c::_MeasureBounds_b__26_0,
			//         0LL);
			//       TypeInfo::HG::Rendering::Runtime::CSG::BSP::__c.static_fields.__9__26_0 = _9__26_0;
			//       sub_1800054D0(
			//         (BSP *)&TypeInfo::HG::Rendering::Runtime::CSG::BSP::__c.static_fields.__9__26_0,
			//         v16,
			//         v17,
			//         v18,
			//         v43,
			//         v44);
			//     }
			//     v19 = System::Linq::Enumerable::SelectMany<System::Object,System::Object>(
			//             Polygons,
			//             (Func_2_Object_System_Collections_Generic_IEnumerable_1_System_Object_ *)_9__26_0,
			//             MethodInfo::System::Linq::Enumerable::SelectMany<HG::Rendering::Runtime::CSG::CSGPolygon,HG::Rendering::Runtime::CSG::CSGVertex>);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::CSG::BSP::__c);
			//     _9__26_1 = TypeInfo::HG::Rendering::Runtime::CSG::BSP::__c.static_fields.__9__26_1;
			//     if ( !_9__26_1 )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::CSG::BSP::__c);
			//       v21 = (Object *)TypeInfo::HG::Rendering::Runtime::CSG::BSP::__c.static_fields.__9;
			//       v22 = (Func_2_Object_UnityEngine_Vector3_ *)sub_180004920(TypeInfo::System::Func<HG::Rendering::Runtime::CSG::CSGVertex,UnityEngine::Vector3>);
			//       _9__26_1 = (Func_2_HG_Rendering_Runtime_CSG_CSGVertex_UnityEngine_Vector3_ *)v22;
			//       if ( !v22 )
			//         sub_180B536AC(v24, v23);
			//       System::Func<System::Object,UnityEngine::Vector3>::Func(
			//         v22,
			//         v21,
			//         MethodInfo::HG::Rendering::Runtime::CSG::BSP::__c::_MeasureBounds_b__26_1,
			//         0LL);
			//       TypeInfo::HG::Rendering::Runtime::CSG::BSP::__c.static_fields.__9__26_1 = _9__26_1;
			//       sub_1800054D0(
			//         (BSP *)&TypeInfo::HG::Rendering::Runtime::CSG::BSP::__c.static_fields.__9__26_1,
			//         v25,
			//         v26,
			//         v27,
			//         v43,
			//         v44);
			//     }
			//     v28 = System::Linq::Enumerable::Select<UnityEngine::Vector3,UnityEngine::Vector3>(
			//             (IEnumerable_1_UnityEngine_Vector3_ *)v19,
			//             (Func_2_UnityEngine_Vector3_UnityEngine_Vector3_ *)_9__26_1,
			//             MethodInfo::System::Linq::Enumerable::Select<HG::Rendering::Runtime::CSG::CSGVertex,UnityEngine::Vector3>);
			//     if ( !v28 )
			//       sub_180B536AC(v30, v29);
			//     v45 = sub_1800513A0(0LL, TypeInfo::System::Collections::Generic::IEnumerable<UnityEngine::Vector3>, v28);
			//     v49[0] = 0LL;
			//     v49[1] = &v45;
			//     try
			//     {
			//       v37 = _mm_cvtsi128_si32((__m128i)0LL);
			//       while ( 1 )
			//       {
			//         if ( !v45 )
			//           sub_1802DC2C8(v32, v31);
			//         if ( !(unsigned __int8)sub_1800518F0(0LL, TypeInfo::System::Collections::IEnumerator) )
			//           break;
			//         if ( !v45 )
			//           sub_1802DC2C8(v34, v33);
			//         v35 = sub_1801F9C08(v56, 0LL, TypeInfo::System::Collections::Generic::IEnumerator<UnityEngine::Vector3>, v45);
			//         v50 = *(_QWORD *)v35;
			//         v36 = *(float *)(v35 + 8);
			//         if ( v37 )
			//         {
			//           System::Nullable<Beyond::Gameplay::FormationSetting::FormationSlot>::get_Value(
			//             &v54,
			//             (Nullable_1_Beyond_Gameplay_FormationSetting_FormationSlot_ *)&v47,
			//             MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
			//           *(_QWORD *)&v53.x = v50;
			//           v53.z = v36;
			//           *(FormationSetting_FormationSlot *)v46 = v54;
			//           HG::Rendering::Runtime::CSG::Extensions::IncludePoint((Bounds *)&v54, (Bounds *)v46, &v53, 0LL);
			//         }
			//         else
			//         {
			//           memset(&v48, 0, sizeof(v48));
			//           *(_QWORD *)&v51.x = *(_QWORD *)v35;
			//           v51.z = v36;
			//           *(_QWORD *)&v52.x = *(_QWORD *)&v51.x;
			//           v52.z = v36;
			//           UnityEngine::Bounds::Bounds(&v48, &v52, &v51, 0LL);
			//           *(_WORD *)&v46[1] = 0;
			//           v46[3] = 0;
			//           *(Bounds *)&v46[4] = v48;
			//           v46[0] = 1;
			//           *(_OWORD *)&v48.m_Center.x = *(_OWORD *)v46;
			//           *(_OWORD *)&v47.hasValue = *(_OWORD *)v46;
			//           *(_QWORD *)&v47.value.m_Extents.x = *(_QWORD *)&v46[16];
			//           z = v48.m_Extents.z;
			//           v47.value.m_Extents.z = v48.m_Extents.z;
			//           v37 = _mm_cvtsi128_si32(*(__m128i *)v46);
			//         }
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v55 )
			//     {
			//       v49[0] = v55.ex;
			//       sub_1801E4D90(v49);
			//       v6 = retstr;
			//       z = v47.value.m_Extents.z;
			//       v38 = *(_OWORD *)&v47.hasValue;
			//       goto LABEL_20;
			//     }
			//     sub_1801E4D90(v49);
			//     v38 = *(_OWORD *)&v48.m_Center.x;
			// LABEL_20:
			//     *(_OWORD *)&v6.hasValue = v38;
			//     *(_QWORD *)&v6.value.m_Extents.x = *(_QWORD *)&v47.value.m_Extents.x;
			//     v6.value.m_Extents.z = z;
			//   }
			//   return v6;
			// }
			// 
			return null;
		}

		public virtual BSP Transform(Matrix4x4 transformation, Vector3[] verts, Vector3[] normals)
		{
			// // BSP Transform(Matrix4x4, Vector3[], Vector3[])
			// BSP *HG::Rendering::Runtime::CSG::BSP::Transform(
			//         BSP *this,
			//         Matrix4x4 *transformation,
			//         Vector3__Array *verts,
			//         Vector3__Array *normals,
			//         MethodInfo *method)
			// {
			//   __int64 v9; // rax
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v10; // rdx
			//   Node_2 *root; // rcx
			//   Bounds *v12; // r8
			//   Object__Array *v13; // r9
			//   __int64 v14; // rdi
			//   __int128 v15; // xmm0
			//   __int128 v16; // xmm1
			//   __int128 v17; // xmm0
			//   __int128 v18; // xmm1
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v19; // rdx
			//   Bounds *v20; // r8
			//   Object__Array *v21; // r9
			//   IEnumerable_1_System_Object_ *AllPolygons; // r14
			//   Func_2_Object_Object_ *v23; // rax
			//   Func_2_Object_Object_ *v24; // rbx
			//   IEnumerable_1_System_Object_ *v25; // rax
			//   __int128 v26; // xmm0
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v27; // r15
			//   __int64 v28; // xmm1_8
			//   __int128 v29; // xmm6
			//   __int128 v30; // xmm7
			//   __int128 v31; // xmm8
			//   __int128 v32; // xmm9
			//   Bounds *v33; // rax
			//   Object__Array *description; // r12
			//   __int128 v35; // xmm6
			//   __int64 v36; // xmm7_8
			//   __int64 v37; // r8
			//   __int64 v38; // r9
			//   Object__Array *v39; // r14
			//   __int64 v40; // r8
			//   __int64 v41; // rax
			//   __int64 v42; // rbx
			//   __int64 v43; // r8
			//   __int64 v44; // rbx
			//   __int64 v45; // r8
			//   __int64 v46; // rbx
			//   __int64 v47; // r8
			//   __int64 v48; // rbx
			//   __int64 v49; // r8
			//   __int64 v50; // rbx
			//   __int64 v51; // r8
			//   __int64 v52; // rbx
			//   __int64 v53; // r8
			//   __int64 v54; // rbx
			//   __int64 v55; // r8
			//   __int64 v56; // rbx
			//   __int64 v57; // r8
			//   __int64 v58; // rbx
			//   __int64 v59; // r8
			//   __int64 v60; // rbx
			//   __int64 v61; // r8
			//   __int64 v62; // rbx
			//   __int64 v63; // r8
			//   __int64 v64; // rbx
			//   __int64 v65; // r8
			//   __int64 v66; // rbx
			//   __int64 v67; // r8
			//   __int64 v68; // rbx
			//   __int64 v69; // r8
			//   __int64 v70; // rbx
			//   __int64 v71; // r8
			//   __int64 v72; // rbx
			//   Object__Array *v73; // rdi
			//   BSP *v74; // rax
			//   BSP *v75; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 v78; // xmm1
			//   __int128 v79; // xmm0
			//   __int128 v80; // xmm1
			//   MethodInfo *v81; // [rsp+28h] [rbp-A1h]
			//   MethodInfo *v82; // [rsp+28h] [rbp-A1h]
			//   MethodInfo *v83; // [rsp+30h] [rbp-99h]
			//   MethodInfo *v84; // [rsp+30h] [rbp-99h]
			//   int v85; // [rsp+38h] [rbp-91h] BYREF
			//   Nullable_1_Beyond_Gameplay_FormationSetting_FormationSlot_ v86; // [rsp+48h] [rbp-81h] BYREF
			//   FormationSetting_FormationSlot v87; // [rsp+68h] [rbp-61h] BYREF
			//   Matrix4x4 v88[2]; // [rsp+88h] [rbp-41h] BYREF
			// 
			//   if ( !byte_18D919856 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CSG::BSP);
			//     sub_18003C530(&MethodInfo::System::Linq::Enumerable::Select<HG::Rendering::Runtime::CSG::CSGPolygon,HG::Rendering::Runtime::CSG::CSGPolygon>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
			//     sub_18003C530(&TypeInfo::System::Func<HG::Rendering::Runtime::CSG::CSGPolygon,HG::Rendering::Runtime::CSG::CSGPolygon>);
			//     sub_18003C530(&MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
			//     sub_18003C530(&TypeInfo::System::Object);
			//     sub_18003C530(&TypeInfo::System::Single);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::CSG::BSP::__c__DisplayClass27_0::_Transform_b__0);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CSG::BSP::__c__DisplayClass27_0);
			//     sub_18003C530(&off_18C8F6FA8);
			//     byte_18D919856 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4716, 0LL) )
			//   {
			//     v9 = sub_180004920(TypeInfo::HG::Rendering::Runtime::CSG::BSP::__c__DisplayClass27_0);
			//     v14 = v9;
			//     if ( v9 )
			//     {
			//       *(_QWORD *)(v9 + 16) = verts;
			//       sub_1800054D0((BSP *)(v9 + 16), v10, v12, v13, v81, v83);
			//       v15 = *(_OWORD *)&transformation.m00;
			//       *(_QWORD *)(v14 + 88) = normals;
			//       v16 = *(_OWORD *)&transformation.m01;
			//       *(_OWORD *)(v14 + 24) = v15;
			//       v17 = *(_OWORD *)&transformation.m02;
			//       *(_OWORD *)(v14 + 40) = v16;
			//       v18 = *(_OWORD *)&transformation.m03;
			//       *(_OWORD *)(v14 + 56) = v17;
			//       *(_OWORD *)(v14 + 72) = v18;
			//       sub_1800054D0((BSP *)(v14 + 88), v19, v20, v21, v82, v84);
			//       root = this.fields.root;
			//       if ( root )
			//       {
			//         AllPolygons = (IEnumerable_1_System_Object_ *)HG::Rendering::Runtime::CSG::Node::get_AllPolygons(root, 0LL);
			//         v23 = (Func_2_Object_Object_ *)sub_180004920(TypeInfo::System::Func<HG::Rendering::Runtime::CSG::CSGPolygon,HG::Rendering::Runtime::CSG::CSGPolygon>);
			//         v24 = v23;
			//         if ( v23 )
			//         {
			//           System::Func<System::Object,System::Object>::Func(
			//             v23,
			//             (Object *)v14,
			//             MethodInfo::HG::Rendering::Runtime::CSG::BSP::__c__DisplayClass27_0::_Transform_b__0,
			//             0LL);
			//           v25 = System::Linq::Enumerable::Select<System::Object,System::Object>(
			//                   AllPolygons,
			//                   v24,
			//                   MethodInfo::System::Linq::Enumerable::Select<HG::Rendering::Runtime::CSG::CSGPolygon,HG::Rendering::Runtime::CSG::CSGPolygon>);
			//           v26 = *(_OWORD *)&this.fields._Bounds_k__BackingField.hasValue;
			//           v27 = (IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *)v25;
			//           v28 = *(_QWORD *)&this.fields._Bounds_k__BackingField.value.m_Extents.x;
			//           v86.value.m_cacheLocalRot.w = this.fields._Bounds_k__BackingField.value.m_Extents.z;
			//           *(_OWORD *)&v86.hasValue = v26;
			//           *(_QWORD *)&v86.value.m_cacheLocalRot.y = v28;
			//           System::Nullable<Beyond::Gameplay::FormationSetting::FormationSlot>::get_Value(
			//             &v87,
			//             &v86,
			//             MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
			//           v29 = *(_OWORD *)(v14 + 24);
			//           v30 = *(_OWORD *)(v14 + 40);
			//           v31 = *(_OWORD *)(v14 + 56);
			//           v32 = *(_OWORD *)(v14 + 72);
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
			//           *(_OWORD *)&v86.hasValue = *(_OWORD *)&v87.angle;
			//           *(_OWORD *)&v88[0].m00 = v29;
			//           *(_OWORD *)&v88[0].m01 = v30;
			//           *(_OWORD *)&v88[0].m02 = v31;
			//           *(_OWORD *)&v88[0].m03 = v32;
			//           *(_QWORD *)&v86.value.m_cacheLocalRot.y = *(_QWORD *)&v87.m_cacheLocalRot.z;
			//           v33 = HG::Rendering::Runtime::CSG::Extensions::Transform((Bounds *)&v87, (Bounds *)&v86, v88, 0LL);
			//           description = this.fields.description;
			//           v35 = *(_OWORD *)&v33.m_Center.x;
			//           v36 = *(_QWORD *)&v33.m_Extents.y;
			//           v39 = (Object__Array *)il2cpp_array_new_specific_0(TypeInfo::System::Object, 16LL, v37, v38);
			//           v85 = *(_DWORD *)(v14 + 24);
			//           v41 = il2cpp_value_box_0(TypeInfo::System::Single, &v85, v40);
			//           v42 = v41;
			//           if ( v39 )
			//           {
			//             sub_180036D40(v39, v41);
			//             sub_1800046C0(v39, 0LL, v42);
			//             v85 = *(_DWORD *)(v14 + 40);
			//             v44 = il2cpp_value_box_0(TypeInfo::System::Single, &v85, v43);
			//             sub_180036D40(v39, v44);
			//             sub_1800046C0(v39, 1LL, v44);
			//             v85 = *(_DWORD *)(v14 + 56);
			//             v46 = il2cpp_value_box_0(TypeInfo::System::Single, &v85, v45);
			//             sub_180036D40(v39, v46);
			//             sub_1800046C0(v39, 2LL, v46);
			//             v85 = *(_DWORD *)(v14 + 72);
			//             v48 = il2cpp_value_box_0(TypeInfo::System::Single, &v85, v47);
			//             sub_180036D40(v39, v48);
			//             sub_1800046C0(v39, 3LL, v48);
			//             v85 = *(_DWORD *)(v14 + 28);
			//             v50 = il2cpp_value_box_0(TypeInfo::System::Single, &v85, v49);
			//             sub_180036D40(v39, v50);
			//             sub_1800046C0(v39, 4LL, v50);
			//             v85 = *(_DWORD *)(v14 + 44);
			//             v52 = il2cpp_value_box_0(TypeInfo::System::Single, &v85, v51);
			//             sub_180036D40(v39, v52);
			//             sub_1800046C0(v39, 5LL, v52);
			//             v85 = *(_DWORD *)(v14 + 60);
			//             v54 = il2cpp_value_box_0(TypeInfo::System::Single, &v85, v53);
			//             sub_180036D40(v39, v54);
			//             sub_1800046C0(v39, 6LL, v54);
			//             v85 = *(_DWORD *)(v14 + 76);
			//             v56 = il2cpp_value_box_0(TypeInfo::System::Single, &v85, v55);
			//             sub_180036D40(v39, v56);
			//             sub_1800046C0(v39, 7LL, v56);
			//             v85 = *(_DWORD *)(v14 + 32);
			//             v58 = il2cpp_value_box_0(TypeInfo::System::Single, &v85, v57);
			//             sub_180036D40(v39, v58);
			//             sub_1800046C0(v39, 8LL, v58);
			//             v85 = *(_DWORD *)(v14 + 48);
			//             v60 = il2cpp_value_box_0(TypeInfo::System::Single, &v85, v59);
			//             sub_180036D40(v39, v60);
			//             sub_1800046C0(v39, 9LL, v60);
			//             v85 = *(_DWORD *)(v14 + 64);
			//             v62 = il2cpp_value_box_0(TypeInfo::System::Single, &v85, v61);
			//             sub_180036D40(v39, v62);
			//             sub_1800046C0(v39, 10LL, v62);
			//             v85 = *(_DWORD *)(v14 + 80);
			//             v64 = il2cpp_value_box_0(TypeInfo::System::Single, &v85, v63);
			//             sub_180036D40(v39, v64);
			//             sub_1800046C0(v39, 11LL, v64);
			//             v85 = *(_DWORD *)(v14 + 36);
			//             v66 = il2cpp_value_box_0(TypeInfo::System::Single, &v85, v65);
			//             sub_180036D40(v39, v66);
			//             sub_1800046C0(v39, 12LL, v66);
			//             v85 = *(_DWORD *)(v14 + 52);
			//             v68 = il2cpp_value_box_0(TypeInfo::System::Single, &v85, v67);
			//             sub_180036D40(v39, v68);
			//             sub_1800046C0(v39, 13LL, v68);
			//             v85 = *(_DWORD *)(v14 + 68);
			//             v70 = il2cpp_value_box_0(TypeInfo::System::Single, &v85, v69);
			//             sub_180036D40(v39, v70);
			//             sub_1800046C0(v39, 14LL, v70);
			//             v85 = *(_DWORD *)(v14 + 84);
			//             v72 = il2cpp_value_box_0(TypeInfo::System::Single, &v85, v71);
			//             sub_180036D40(v39, v72);
			//             sub_1800046C0(v39, 15LL, v72);
			//             v73 = HG::Rendering::Runtime::CSG::BSP::CreateDescription(
			//                     this,
			//                     (String *)"transform",
			//                     description,
			//                     v39,
			//                     0LL);
			//             v74 = (BSP *)sub_180004920(TypeInfo::HG::Rendering::Runtime::CSG::BSP);
			//             v75 = v74;
			//             if ( v74 )
			//             {
			//               *(_OWORD *)&v86.hasValue = v35;
			//               *(_QWORD *)&v86.value.m_cacheLocalRot.y = v36;
			//               HG::Rendering::Runtime::CSG::BSP::BSP(v74, v27, (Bounds *)&v86, v73, 1, 0LL);
			//               HG::Rendering::Runtime::CSG::BSP::InvokeChange(this, 0LL);
			//               return v75;
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_11:
			//     sub_180B536AC(root, v10);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4716, 0LL);
			//   if ( !Patch )
			//     goto LABEL_11;
			//   v78 = *(_OWORD *)&transformation.m01;
			//   *(_OWORD *)&v88[0].m00 = *(_OWORD *)&transformation.m00;
			//   v79 = *(_OWORD *)&transformation.m02;
			//   *(_OWORD *)&v88[0].m01 = v78;
			//   v80 = *(_OWORD *)&transformation.m03;
			//   *(_OWORD *)&v88[0].m02 = v79;
			//   *(_OWORD *)&v88[0].m03 = v80;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1357(
			//            Patch,
			//            (Object *)this,
			//            v88,
			//            (Object *)verts,
			//            (Object *)normals,
			//            0LL);
			// }
			// 
			return null;
		}

		public CSGVertex transformVertex(CSGVertex v, Matrix4x4 transformation, Vector3[] verts, Vector3[] normals)
		{
			// // CSGVertex transformVertex(CSGVertex, Matrix4x4, Vector3[], Vector3[])
			// CSGVertex *HG::Rendering::Runtime::CSG::BSP::transformVertex(
			//         BSP *this,
			//         CSGVertex *v,
			//         Matrix4x4 *transformation,
			//         Vector3__Array *verts,
			//         Vector3__Array *normals,
			//         MethodInfo *method)
			// {
			//   __int64 v10; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   Vector3 *v12; // rax
			//   float z; // ecx
			//   Vector3 *v14; // rax
			//   __int64 v15; // xmm0_8
			//   float v16; // ecx
			//   CSGVertex *result; // rax
			//   __int128 v18; // xmm1
			//   __int128 v19; // xmm0
			//   __int128 v20; // xmm1
			//   Vector3 v21; // [rsp+48h] [rbp-19h] BYREF
			//   Vector3 v22; // [rsp+58h] [rbp-9h] BYREF
			//   Matrix4x4 v23; // [rsp+68h] [rbp+7h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4726, 0LL) )
			//   {
			//     if ( v )
			//     {
			//       if ( verts )
			//       {
			//         sub_180040F70(verts, &v21, v.fields.id);
			//         v22 = v21;
			//         v12 = UnityEngine::Matrix4x4::MultiplyPoint3x4(&v21, transformation, &v22, 0LL);
			//         z = v12.z;
			//         *(_QWORD *)&v.fields.Position.x = *(_QWORD *)&v12.x;
			//         v.fields.Position.z = z;
			//         Patch = (ILFixDynamicMethodWrapper_2 *)normals;
			//         if ( normals )
			//         {
			//           sub_180040F70(normals, &v22, v.fields.id);
			//           v21 = v22;
			//           v14 = UnityEngine::Matrix4x4::MultiplyPoint3x4(&v22, transformation, &v21, 0LL);
			//           v15 = *(_QWORD *)&v14.x;
			//           v16 = v14.z;
			//           result = v;
			//           *(_QWORD *)&v.fields.Normal.x = v15;
			//           v.fields.Normal.z = v16;
			//           return result;
			//         }
			//       }
			//     }
			// LABEL_7:
			//     sub_180B536AC(Patch, v10);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4726, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   v18 = *(_OWORD *)&transformation.m01;
			//   *(_OWORD *)&v23.m00 = *(_OWORD *)&transformation.m00;
			//   v19 = *(_OWORD *)&transformation.m02;
			//   *(_OWORD *)&v23.m01 = v18;
			//   v20 = *(_OWORD *)&transformation.m03;
			//   *(_OWORD *)&v23.m02 = v19;
			//   *(_OWORD *)&v23.m03 = v20;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1358(
			//            Patch,
			//            (Object *)this,
			//            (Object *)v,
			//            &v23,
			//            (Object *)verts,
			//            (Object *)normals,
			//            0LL);
			// }
			// 
			return null;
		}

		private void InvokeChange()
		{
			// // Void InvokeChange()
			// void HG::Rendering::Runtime::CSG::BSP::InvokeChange(BSP *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4618, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4618, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else if ( this.fields.OnChange )
			//   {
			//     sub_1823EC480(this.fields.OnChange);
			//   }
			// }
			// 
		}

		public virtual void Union(BSP bInput)
		{
			// // Void Union(BSP)
			// void HG::Rendering::Runtime::CSG::BSP::Union(BSP *this, BSP *bInput, MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   Node_2 *v6; // rcx
			//   Node_2 *root; // r14
			//   Node_2 *v8; // rax
			//   Node_2 *v9; // rsi
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *AllPolygons; // rax
			//   float z; // eax
			//   __int64 v12; // xmm0_8
			//   float w; // eax
			//   __int128 v14; // xmm1
			//   __int64 v15; // xmm1_8
			//   Vector3 *min; // rax
			//   __int128 v17; // xmm0
			//   __int64 v18; // xmm1_8
			//   __m128 x_low; // xmm8
			//   float x; // xmm7_4
			//   float v21; // eax
			//   __int64 v22; // xmm1_8
			//   Vector3 *v23; // rax
			//   __int128 v24; // xmm0
			//   __int64 v25; // xmm1_8
			//   __m128 y_low; // xmm6
			//   Vector3 *v27; // rax
			//   __m128 v28; // xmm0
			//   __m128 v29; // xmm11
			//   float v30; // eax
			//   __int64 v31; // xmm1_8
			//   Vector3 *v32; // rax
			//   __int128 v33; // xmm0
			//   __int64 v34; // xmm2_8
			//   __m128 v35; // xmm0
			//   __m128 v36; // xmm10
			//   Vector3 *v37; // rax
			//   float v38; // eax
			//   __int64 v39; // xmm2_8
			//   float v40; // xmm9_4
			//   Vector3 *max; // rax
			//   __int128 v42; // xmm0
			//   __int64 v43; // xmm1_8
			//   __m128 v44; // xmm6
			//   Vector3 *v45; // rax
			//   __m128 v46; // xmm0
			//   float v47; // eax
			//   __int64 v48; // xmm2_8
			//   __m128 v49; // xmm8
			//   Vector3 *v50; // rax
			//   __int128 v51; // xmm0
			//   __int64 v52; // xmm1_8
			//   __m128 v53; // xmm6
			//   Vector3 *v54; // rax
			//   __m128 v55; // xmm0
			//   float v56; // eax
			//   __int64 v57; // xmm2_8
			//   __m128 v58; // xmm7
			//   Vector3 *v59; // rax
			//   __int128 v60; // xmm0
			//   __int64 v61; // xmm1_8
			//   Vector3 *v62; // rax
			//   __int64 v63; // xmm1_8
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v64; // rdx
			//   Bounds *v65; // r8
			//   Object__Array *v66; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *methoda; // [rsp+28h] [rbp-99h]
			//   MethodInfo *v69; // [rsp+30h] [rbp-91h]
			//   FormationSetting_FormationSlot v70; // [rsp+38h] [rbp-89h] BYREF
			//   Vector3 v71; // [rsp+58h] [rbp-69h] BYREF
			//   FormationSetting_FormationSlot v72; // [rsp+68h] [rbp-59h] BYREF
			//   Nullable_1_Beyond_Gameplay_FormationSetting_FormationSlot_ v73[4]; // [rsp+80h] [rbp-41h] BYREF
			// 
			//   if ( !byte_18D919857 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Math);
			//     sub_18003C530(&MethodInfo::System::Nullable<UnityEngine::Bounds>::Nullable);
			//     sub_18003C530(&MethodInfo::System::Nullable<UnityEngine::Bounds>::get_HasValue);
			//     sub_18003C530(&MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
			//     sub_18003C530(&off_18D5237C8);
			//     byte_18D919857 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4577, 0LL) )
			//   {
			//     root = this.fields.root;
			//     if ( bInput )
			//     {
			//       v6 = bInput.fields.root;
			//       if ( v6 )
			//       {
			//         v8 = HG::Rendering::Runtime::CSG::Node::Clone(v6, 0LL);
			//         v9 = v8;
			//         if ( root )
			//         {
			//           HG::Rendering::Runtime::CSG::Node::ClipTo(root, v8, 0LL);
			//           if ( v9 )
			//           {
			//             HG::Rendering::Runtime::CSG::Node::ClipTo(v9, root, 0LL);
			//             HG::Rendering::Runtime::CSG::Node::Invert(v9, 0LL);
			//             HG::Rendering::Runtime::CSG::Node::ClipTo(v9, root, 0LL);
			//             HG::Rendering::Runtime::CSG::Node::Invert(v9, 0LL);
			//             AllPolygons = HG::Rendering::Runtime::CSG::Node::get_AllPolygons(v9, 0LL);
			//             HG::Rendering::Runtime::CSG::Node::Build(root, AllPolygons, 0LL);
			//             z = this.fields._Bounds_k__BackingField.value.m_Extents.z;
			//             *(_QWORD *)&v73[0].value.m_cacheLocalRot.y = *(_QWORD *)&this.fields._Bounds_k__BackingField.value.m_Extents.x;
			//             v12 = *(_QWORD *)&bInput.fields._Bounds_k__BackingField.value.m_Extents.x;
			//             v73[0].value.m_cacheLocalRot.w = z;
			//             w = bInput.fields._Bounds_k__BackingField.value.m_Extents.z;
			//             if ( this.fields._Bounds_k__BackingField.hasValue )
			//             {
			//               v73[0].value.m_cacheLocalRot.w = bInput.fields._Bounds_k__BackingField.value.m_Extents.z;
			//               w = this.fields._Bounds_k__BackingField.value.m_Extents.z;
			//               *(_QWORD *)&v73[0].value.m_cacheLocalRot.y = v12;
			//               if ( bInput.fields._Bounds_k__BackingField.hasValue )
			//               {
			//                 v15 = *(_QWORD *)&this.fields._Bounds_k__BackingField.value.m_Extents.x;
			//                 *(_OWORD *)&v73[0].hasValue = *(_OWORD *)&this.fields._Bounds_k__BackingField.hasValue;
			//                 v73[0].value.m_cacheLocalRot.w = w;
			//                 *(_QWORD *)&v73[0].value.m_cacheLocalRot.y = v15;
			//                 System::Nullable<Beyond::Gameplay::FormationSetting::FormationSlot>::get_Value(
			//                   &v72,
			//                   v73,
			//                   MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
			//                 v70 = v72;
			//                 min = UnityEngine::Bounds::get_min(&v71, (Bounds *)&v70, 0LL);
			//                 v17 = *(_OWORD *)&bInput.fields._Bounds_k__BackingField.hasValue;
			//                 v18 = *(_QWORD *)&bInput.fields._Bounds_k__BackingField.value.m_Extents.x;
			//                 x_low = (__m128)LODWORD(min.x);
			//                 v73[0].value.m_cacheLocalRot.w = bInput.fields._Bounds_k__BackingField.value.m_Extents.z;
			//                 *(_OWORD *)&v73[0].hasValue = v17;
			//                 *(_QWORD *)&v73[0].value.m_cacheLocalRot.y = v18;
			//                 System::Nullable<Beyond::Gameplay::FormationSetting::FormationSlot>::get_Value(
			//                   &v72,
			//                   v73,
			//                   MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
			//                 v70 = v72;
			//                 x = UnityEngine::Bounds::get_min(&v71, (Bounds *)&v70, 0LL).x;
			//                 sub_180002C70(TypeInfo::System::Math);
			//                 v21 = this.fields._Bounds_k__BackingField.value.m_Extents.z;
			//                 v22 = *(_QWORD *)&this.fields._Bounds_k__BackingField.value.m_Extents.x;
			//                 *(_OWORD *)&v73[0].hasValue = *(_OWORD *)&this.fields._Bounds_k__BackingField.hasValue;
			//                 v73[0].value.m_cacheLocalRot.w = v21;
			//                 *(_QWORD *)&v73[0].value.m_cacheLocalRot.y = v22;
			//                 System::Nullable<Beyond::Gameplay::FormationSetting::FormationSlot>::get_Value(
			//                   &v72,
			//                   v73,
			//                   MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
			//                 v70 = v72;
			//                 v23 = UnityEngine::Bounds::get_min(&v71, (Bounds *)&v70, 0LL);
			//                 v24 = *(_OWORD *)&bInput.fields._Bounds_k__BackingField.hasValue;
			//                 v25 = *(_QWORD *)&bInput.fields._Bounds_k__BackingField.value.m_Extents.x;
			//                 y_low = (__m128)LODWORD(v23.y);
			//                 v73[0].value.m_cacheLocalRot.w = bInput.fields._Bounds_k__BackingField.value.m_Extents.z;
			//                 *(_OWORD *)&v73[0].hasValue = v24;
			//                 *(_QWORD *)&v73[0].value.m_cacheLocalRot.y = v25;
			//                 System::Nullable<Beyond::Gameplay::FormationSetting::FormationSlot>::get_Value(
			//                   &v72,
			//                   v73,
			//                   MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
			//                 v70 = v72;
			//                 v27 = UnityEngine::Bounds::get_min(&v71, (Bounds *)&v70, 0LL);
			//                 v28 = y_low;
			//                 v28.m128_f32[0] = System::Math::Min(y_low.m128_f32[0], v27.y, 0LL);
			//                 v29 = v28;
			//                 v30 = this.fields._Bounds_k__BackingField.value.m_Extents.z;
			//                 v31 = *(_QWORD *)&this.fields._Bounds_k__BackingField.value.m_Extents.x;
			//                 *(_OWORD *)&v73[0].hasValue = *(_OWORD *)&this.fields._Bounds_k__BackingField.hasValue;
			//                 v73[0].value.m_cacheLocalRot.w = v30;
			//                 *(_QWORD *)&v73[0].value.m_cacheLocalRot.y = v31;
			//                 System::Nullable<Beyond::Gameplay::FormationSetting::FormationSlot>::get_Value(
			//                   &v72,
			//                   v73,
			//                   MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
			//                 v70 = v72;
			//                 v32 = UnityEngine::Bounds::get_min(&v71, (Bounds *)&v70, 0LL);
			//                 v33 = *(_OWORD *)&bInput.fields._Bounds_k__BackingField.hasValue;
			//                 v34 = *(_QWORD *)&bInput.fields._Bounds_k__BackingField.value.m_Extents.x;
			//                 y_low.m128_i32[0] = LODWORD(v32.z);
			//                 v73[0].value.m_cacheLocalRot.w = bInput.fields._Bounds_k__BackingField.value.m_Extents.z;
			//                 *(_OWORD *)&v73[0].hasValue = v33;
			//                 *(_QWORD *)&v73[0].value.m_cacheLocalRot.y = v34;
			//                 System::Nullable<Beyond::Gameplay::FormationSetting::FormationSlot>::get_Value(
			//                   &v72,
			//                   v73,
			//                   MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
			//                 v35 = x_low;
			//                 v70 = v72;
			//                 v35.m128_f32[0] = System::Math::Min(x_low.m128_f32[0], x, 0LL);
			//                 v36 = v35;
			//                 v37 = UnityEngine::Bounds::get_min(&v71, (Bounds *)&v70, 0LL);
			//                 v35.m128_f32[0] = System::Math::Min(y_low.m128_f32[0], v37.z, 0LL);
			//                 v38 = this.fields._Bounds_k__BackingField.value.m_Extents.z;
			//                 v39 = *(_QWORD *)&this.fields._Bounds_k__BackingField.value.m_Extents.x;
			//                 v40 = v35.m128_f32[0];
			//                 *(_OWORD *)&v73[0].hasValue = *(_OWORD *)&this.fields._Bounds_k__BackingField.hasValue;
			//                 v73[0].value.m_cacheLocalRot.w = v38;
			//                 *(_QWORD *)&v73[0].value.m_cacheLocalRot.y = v39;
			//                 System::Nullable<Beyond::Gameplay::FormationSetting::FormationSlot>::get_Value(
			//                   &v72,
			//                   v73,
			//                   MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
			//                 v70 = v72;
			//                 max = UnityEngine::Bounds::get_max(&v71, (Bounds *)&v70, 0LL);
			//                 v42 = *(_OWORD *)&bInput.fields._Bounds_k__BackingField.hasValue;
			//                 v43 = *(_QWORD *)&bInput.fields._Bounds_k__BackingField.value.m_Extents.x;
			//                 v44 = (__m128)LODWORD(max.x);
			//                 v73[0].value.m_cacheLocalRot.w = bInput.fields._Bounds_k__BackingField.value.m_Extents.z;
			//                 *(_OWORD *)&v73[0].hasValue = v42;
			//                 *(_QWORD *)&v73[0].value.m_cacheLocalRot.y = v43;
			//                 System::Nullable<Beyond::Gameplay::FormationSetting::FormationSlot>::get_Value(
			//                   &v72,
			//                   v73,
			//                   MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
			//                 v70 = v72;
			//                 v45 = UnityEngine::Bounds::get_max(&v71, (Bounds *)&v70, 0LL);
			//                 v46 = v44;
			//                 v46.m128_f32[0] = System::Math::Max(v44.m128_f32[0], v45.x, 0LL);
			//                 v47 = this.fields._Bounds_k__BackingField.value.m_Extents.z;
			//                 v48 = *(_QWORD *)&this.fields._Bounds_k__BackingField.value.m_Extents.x;
			//                 v49 = v46;
			//                 *(_OWORD *)&v73[0].hasValue = *(_OWORD *)&this.fields._Bounds_k__BackingField.hasValue;
			//                 v73[0].value.m_cacheLocalRot.w = v47;
			//                 *(_QWORD *)&v73[0].value.m_cacheLocalRot.y = v48;
			//                 System::Nullable<Beyond::Gameplay::FormationSetting::FormationSlot>::get_Value(
			//                   &v72,
			//                   v73,
			//                   MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
			//                 v70 = v72;
			//                 v50 = UnityEngine::Bounds::get_max(&v71, (Bounds *)&v70, 0LL);
			//                 v51 = *(_OWORD *)&bInput.fields._Bounds_k__BackingField.hasValue;
			//                 v52 = *(_QWORD *)&bInput.fields._Bounds_k__BackingField.value.m_Extents.x;
			//                 v53 = (__m128)LODWORD(v50.y);
			//                 v73[0].value.m_cacheLocalRot.w = bInput.fields._Bounds_k__BackingField.value.m_Extents.z;
			//                 *(_OWORD *)&v73[0].hasValue = v51;
			//                 *(_QWORD *)&v73[0].value.m_cacheLocalRot.y = v52;
			//                 System::Nullable<Beyond::Gameplay::FormationSetting::FormationSlot>::get_Value(
			//                   &v72,
			//                   v73,
			//                   MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
			//                 v70 = v72;
			//                 v54 = UnityEngine::Bounds::get_max(&v71, (Bounds *)&v70, 0LL);
			//                 v55 = v53;
			//                 v55.m128_f32[0] = System::Math::Max(v53.m128_f32[0], v54.y, 0LL);
			//                 v56 = this.fields._Bounds_k__BackingField.value.m_Extents.z;
			//                 v57 = *(_QWORD *)&this.fields._Bounds_k__BackingField.value.m_Extents.x;
			//                 v58 = v55;
			//                 *(_OWORD *)&v73[0].hasValue = *(_OWORD *)&this.fields._Bounds_k__BackingField.hasValue;
			//                 v73[0].value.m_cacheLocalRot.w = v56;
			//                 *(_QWORD *)&v73[0].value.m_cacheLocalRot.y = v57;
			//                 System::Nullable<Beyond::Gameplay::FormationSetting::FormationSlot>::get_Value(
			//                   &v72,
			//                   v73,
			//                   MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
			//                 v70 = v72;
			//                 v59 = UnityEngine::Bounds::get_max(&v71, (Bounds *)&v70, 0LL);
			//                 v60 = *(_OWORD *)&bInput.fields._Bounds_k__BackingField.hasValue;
			//                 v61 = *(_QWORD *)&bInput.fields._Bounds_k__BackingField.value.m_Extents.x;
			//                 v53.m128_i32[0] = LODWORD(v59.z);
			//                 v73[0].value.m_cacheLocalRot.w = bInput.fields._Bounds_k__BackingField.value.m_Extents.z;
			//                 *(_OWORD *)&v73[0].hasValue = v60;
			//                 *(_QWORD *)&v73[0].value.m_cacheLocalRot.y = v61;
			//                 System::Nullable<Beyond::Gameplay::FormationSetting::FormationSlot>::get_Value(
			//                   &v72,
			//                   v73,
			//                   MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
			//                 v70 = v72;
			//                 v62 = UnityEngine::Bounds::get_max(&v71, (Bounds *)&v70, 0LL);
			//                 v70.m_cacheLocalRot.x = System::Math::Max(v53.m128_f32[0], v62.z, 0LL);
			//                 v71.z = v40;
			//                 *(_QWORD *)&v70.angle = _mm_unpacklo_ps(v49, v58).m128_u64[0];
			//                 memset(&v72, 0, sizeof(v72));
			//                 *(_QWORD *)&v71.x = _mm_unpacklo_ps(v36, v29).m128_u64[0];
			//                 UnityEngine::Bounds::Bounds((Bounds *)&v72, &v71, (Vector3 *)&v70, 0LL);
			//                 *(_WORD *)(&v73[0].hasValue + 1) = 0;
			//                 v73[0].value = v72;
			//                 *(&v73[0].hasValue + 3) = 0;
			//                 v63 = *(_QWORD *)&v72.m_cacheLocalRot.y;
			//                 w = v72.m_cacheLocalRot.w;
			//                 v73[0].hasValue = 1;
			//                 *(_OWORD *)&this.fields._Bounds_k__BackingField.hasValue = *(_OWORD *)&v73[0].hasValue;
			//                 *(_QWORD *)&this.fields._Bounds_k__BackingField.value.m_Extents.x = v63;
			//                 goto LABEL_14;
			//               }
			//               v14 = *(_OWORD *)&this.fields._Bounds_k__BackingField.hasValue;
			//               v12 = *(_QWORD *)&this.fields._Bounds_k__BackingField.value.m_Extents.x;
			//             }
			//             else
			//             {
			//               v14 = *(_OWORD *)&bInput.fields._Bounds_k__BackingField.hasValue;
			//             }
			//             *(_OWORD *)&this.fields._Bounds_k__BackingField.hasValue = v14;
			//             *(_QWORD *)&this.fields._Bounds_k__BackingField.value.m_Extents.x = v12;
			// LABEL_14:
			//             this.fields._Bounds_k__BackingField.value.m_Extents.z = w;
			//             this.fields.description = HG::Rendering::Runtime::CSG::BSP::CreateDescription(
			//                                          this,
			//                                          (String *)"union",
			//                                          this.fields.description,
			//                                          bInput.fields.description,
			//                                          0LL);
			//             sub_1800054D0((BSP *)&this.fields.description, v64, v65, v66, methoda, v69);
			//             HG::Rendering::Runtime::CSG::BSP::InvokeChange(this, 0LL);
			//             return;
			//           }
			//         }
			//       }
			//     }
			// LABEL_16:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4577, 0LL);
			//   if ( !Patch )
			//     goto LABEL_16;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)bInput,
			//     0LL);
			// }
			// 
		}

		[IDTag(1)]
		public static BSP fromMesh(Mesh m, int objID)
		{
			// // BSP fromMesh(Mesh, Int32)
			// BSP *HG::Rendering::Runtime::CSG::BSP::fromMesh(Mesh *m, int32_t objID, MethodInfo *method)
			// {
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v5; // rax
			//   MethodInfo *v6; // rdx
			//   __int64 v7; // rcx
			//   List_1_System_Object_ *v8; // r13
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v9; // rax
			//   List_1_System_Object_ *v10; // r15
			//   int32_t v11; // ebx
			//   Int32__Array *Triangles; // r14
			//   List_1_System_Int32_ *v13; // rax
			//   Object *v14; // rsi
			//   int32_t i; // r14d
			//   List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *v16; // rsi
			//   int32_t v17; // ebx
			//   Vector3__Array *vertices; // r12
			//   int v19; // eax
			//   Vector3__Array *normals; // r12
			//   int v21; // eax
			//   Vector2__Array *uv; // r12
			//   int v23; // eax
			//   RegexCharClass_SingleRange v24; // r12d
			//   Object *v25; // rax
			//   Vector3__Array *v26; // r12
			//   int v27; // eax
			//   Vector3__Array *v28; // r12
			//   int v29; // eax
			//   Vector2__Array *v30; // r12
			//   int v31; // eax
			//   RegexCharClass_SingleRange v32; // r12d
			//   Object *v33; // rax
			//   Vector3__Array *v34; // r12
			//   int v35; // eax
			//   Vector3__Array *v36; // r12
			//   int v37; // eax
			//   Vector2__Array *v38; // r12
			//   int v39; // eax
			//   RegexCharClass_SingleRange v40; // r12d
			//   Object *v41; // rax
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v42; // rax
			//   List_1_System_Object_ *v43; // r12
			//   Object *v44; // rax
			//   Vector3 *one; // rax
			//   __int64 v46; // xmm1_8
			//   Animator *v47; // rdx
			//   int32_t v48; // r8d
			//   MethodInfo *v49; // r9
			//   Vector3 *Vector; // rax
			//   __int64 v51; // xmm1_8
			//   __int64 v52; // r8
			//   __int64 v53; // r9
			//   __int64 v54; // rax
			//   Object__Array *v55; // rdi
			//   BSP *v56; // rax
			//   BSP *v57; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector3 m_Center; // [rsp+30h] [rbp-D0h] BYREF
			//   Object *v61; // [rsp+40h] [rbp-C0h]
			//   Bounds v62; // [rsp+50h] [rbp-B0h] BYREF
			//   Bounds v63; // [rsp+70h] [rbp-90h] BYREF
			//   Vector3 v64; // [rsp+88h] [rbp-78h] BYREF
			//   Vector2 v65; // [rsp+98h] [rbp-68h] BYREF
			//   Vector2 v66; // [rsp+A0h] [rbp-60h] BYREF
			//   Object *item; // [rsp+A8h] [rbp-58h]
			//   Object *v68; // [rsp+B0h] [rbp-50h]
			//   Vector3 v69; // [rsp+B8h] [rbp-48h] BYREF
			//   Vector3 v70; // [rsp+C8h] [rbp-38h] BYREF
			//   Vector3 v71; // [rsp+E0h] [rbp-20h] BYREF
			//   Vector3 v72; // [rsp+F0h] [rbp-10h] BYREF
			//   Vector3 v73; // [rsp+100h] [rbp+0h] BYREF
			//   Vector3 v74; // [rsp+110h] [rbp+10h] BYREF
			//   Vector3 v75; // [rsp+120h] [rbp+20h] BYREF
			//   Vector3 v76; // [rsp+130h] [rbp+30h] BYREF
			//   Vector2 v78; // [rsp+198h] [rbp+98h] BYREF
			// 
			//   if ( !byte_18D919858 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CSG::BSP);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CSG::CSGPolygon);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CSG::CSGVertex);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGVertex>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGPolygon>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::Collections::Generic::List<int>>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGPolygon>::List);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGVertex>::List);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::Collections::Generic::List<int>>::List);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::List);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::Collections::Generic::List<int>>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::Collections::Generic::List<int>>::get_Item);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<int>);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGVertex>);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<System::Collections::Generic::List<int>>);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGPolygon>);
			//     sub_18003C530(&TypeInfo::System::Object);
			//     sub_18003C530(&off_18D523958);
			//     byte_18D919858 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4727, 0LL) )
			//   {
			//     v5 = (List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGPolygon>);
			//     v8 = (List_1_System_Object_ *)v5;
			//     if ( v5 )
			//     {
			//       System::Collections::Generic::List<Beyond::Gameplay::ZhuangfySleeveSolver::BoneData>::List(
			//         v5,
			//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGPolygon>::List);
			//       v9 = (List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<System::Collections::Generic::List<int>>);
			//       v10 = (List_1_System_Object_ *)v9;
			//       if ( v9 )
			//       {
			//         System::Collections::Generic::List<Beyond::Gameplay::ZhuangfySleeveSolver::BoneData>::List(
			//           v9,
			//           MethodInfo::System::Collections::Generic::List<System::Collections::Generic::List<int>>::List);
			//         v11 = 0;
			//         if ( m )
			//         {
			//           while ( v11 < UnityEngine::Mesh::get_subMeshCount(m, 0LL) )
			//           {
			//             Triangles = UnityEngine::Mesh::GetTriangles(m, v11, 0LL);
			//             v13 = (List_1_System_Int32_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<int>);
			//             v14 = (Object *)v13;
			//             if ( !v13 )
			//               goto LABEL_34;
			//             System::Collections::Generic::List<int>::List(
			//               v13,
			//               (IEnumerable_1_System_Int32_ *)Triangles,
			//               MethodInfo::System::Collections::Generic::List<int>::List);
			//             sub_1822AD140(v10, v14);
			//             ++v11;
			//           }
			//           for ( i = 0; i < v10.fields._size; ++i )
			//           {
			//             v16 = (List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *)System::Collections::Generic::List<System::Object>::get_Item(
			//                                                                                          v10,
			//                                                                                          i,
			//                                                                                          MethodInfo::System::Collections::Generic::List<System::Collections::Generic::List<int>>::get_Item);
			//             v17 = 2;
			//             if ( !v16 )
			//               goto LABEL_34;
			//             while ( v17 - 2 < v16.fields._size )
			//             {
			//               vertices = UnityEngine::Mesh::get_vertices(m, 0LL);
			//               v19 = (int)System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::get_Item(
			//                            v16,
			//                            v17 - 2,
			//                            MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//               if ( !vertices )
			//                 goto LABEL_34;
			//               sub_180040F70(vertices, &v70, v19);
			//               normals = UnityEngine::Mesh::get_normals(m, 0LL);
			//               v21 = (int)System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::get_Item(
			//                            v16,
			//                            v17 - 2,
			//                            MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//               if ( !normals )
			//                 goto LABEL_34;
			//               sub_180040F70(normals, &v69, v21);
			//               uv = UnityEngine::Mesh::get_uv(m, 0LL);
			//               v23 = (int)System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::get_Item(
			//                            v16,
			//                            v17 - 2,
			//                            MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//               if ( !uv )
			//                 goto LABEL_34;
			//               sub_18004E290(uv, &v78, v23);
			//               v24 = System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::get_Item(
			//                       v16,
			//                       v17 - 2,
			//                       MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//               v25 = (Object *)sub_180004920(TypeInfo::HG::Rendering::Runtime::CSG::CSGVertex);
			//               item = v25;
			//               if ( !v25 )
			//                 goto LABEL_34;
			//               v71 = v69;
			//               v72 = v70;
			//               HG::Rendering::Runtime::CSG::CSGVertex::CSGVertex((CSGVertex *)v25, &v72, &v71, v78, *(_DWORD *)&v24, 0LL);
			//               v26 = UnityEngine::Mesh::get_vertices(m, 0LL);
			//               v27 = (int)System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::get_Item(
			//                            v16,
			//                            v17 - 1,
			//                            MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//               if ( !v26 )
			//                 goto LABEL_34;
			//               sub_180040F70(v26, &v74, v27);
			//               v28 = UnityEngine::Mesh::get_normals(m, 0LL);
			//               v29 = (int)System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::get_Item(
			//                            v16,
			//                            v17 - 1,
			//                            MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//               if ( !v28 )
			//                 goto LABEL_34;
			//               sub_180040F70(v28, &v73, v29);
			//               v30 = UnityEngine::Mesh::get_uv(m, 0LL);
			//               v31 = (int)System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::get_Item(
			//                            v16,
			//                            v17 - 1,
			//                            MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//               if ( !v30 )
			//                 goto LABEL_34;
			//               sub_18004E290(v30, &v65, v31);
			//               v32 = System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::get_Item(
			//                       v16,
			//                       v17 - 1,
			//                       MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//               v33 = (Object *)sub_180004920(TypeInfo::HG::Rendering::Runtime::CSG::CSGVertex);
			//               v68 = v33;
			//               if ( !v33 )
			//                 goto LABEL_34;
			//               v75 = v73;
			//               v76 = v74;
			//               HG::Rendering::Runtime::CSG::CSGVertex::CSGVertex((CSGVertex *)v33, &v76, &v75, v65, *(_DWORD *)&v32, 0LL);
			//               v34 = UnityEngine::Mesh::get_vertices(m, 0LL);
			//               v35 = (int)System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::get_Item(
			//                            v16,
			//                            v17,
			//                            MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//               if ( !v34 )
			//                 goto LABEL_34;
			//               sub_180040F70(v34, &v64, v35);
			//               v36 = UnityEngine::Mesh::get_normals(m, 0LL);
			//               v37 = (int)System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::get_Item(
			//                            v16,
			//                            v17,
			//                            MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//               if ( !v36 )
			//                 goto LABEL_34;
			//               sub_180040F70(v36, &v63, v37);
			//               v38 = UnityEngine::Mesh::get_uv(m, 0LL);
			//               v39 = (int)System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::get_Item(
			//                            v16,
			//                            v17,
			//                            MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//               if ( !v38 )
			//                 goto LABEL_34;
			//               sub_18004E290(v38, &v66, v39);
			//               v40 = System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::get_Item(
			//                       v16,
			//                       v17,
			//                       MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//               v41 = (Object *)sub_180004920(TypeInfo::HG::Rendering::Runtime::CSG::CSGVertex);
			//               v61 = v41;
			//               if ( !v41 )
			//                 goto LABEL_34;
			//               m_Center = v63.m_Center;
			//               v62.m_Center = v64;
			//               HG::Rendering::Runtime::CSG::CSGVertex::CSGVertex(
			//                 (CSGVertex *)v41,
			//                 &v62.m_Center,
			//                 &m_Center,
			//                 v66,
			//                 *(_DWORD *)&v40,
			//                 0LL);
			//               v42 = (List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGVertex>);
			//               v43 = (List_1_System_Object_ *)v42;
			//               if ( !v42 )
			//                 goto LABEL_34;
			//               System::Collections::Generic::List<Beyond::Gameplay::ZhuangfySleeveSolver::BoneData>::List(
			//                 v42,
			//                 MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGVertex>::List);
			//               sub_1822AD140(v43, item);
			//               sub_1822AD140(v43, v68);
			//               sub_1822AD140(v43, v61);
			//               v44 = (Object *)sub_180004920(TypeInfo::HG::Rendering::Runtime::CSG::CSGPolygon);
			//               v61 = v44;
			//               if ( !v44 )
			//                 goto LABEL_34;
			//               HG::Rendering::Runtime::CSG::CSGPolygon::CSGPolygon(
			//                 (CSGPolygon *)v44,
			//                 (IEnumerable_1_HG_Rendering_Runtime_CSG_CSGVertex_ *)v43,
			//                 objID,
			//                 i,
			//                 0LL);
			//               sub_1822AD140(v8, v61);
			//               v17 += 3;
			//             }
			//           }
			//           memset(&v63, 0, sizeof(v63));
			//           one = UnityEngine::Vector3::get_one(&m_Center, v6);
			//           v46 = *(_QWORD *)&one.x;
			//           *(float *)&one = one.z;
			//           *(_QWORD *)&v62.m_Center.x = v46;
			//           LODWORD(v62.m_Center.z) = (_DWORD)one;
			//           Vector = UnityEngine::Animator::GetVector(&v64, v47, v48, v49);
			//           v51 = *(_QWORD *)&Vector.x;
			//           *(float *)&Vector = Vector.z;
			//           *(_QWORD *)&m_Center.x = v51;
			//           LODWORD(m_Center.z) = (_DWORD)Vector;
			//           UnityEngine::Bounds::Bounds(&v63, &m_Center, &v62.m_Center, 0LL);
			//           v54 = il2cpp_array_new_specific_0(TypeInfo::System::Object, 1LL, v52, v53);
			//           v55 = (Object__Array *)v54;
			//           if ( v54 )
			//           {
			//             sub_180036D40(v54, "Mesh");
			//             sub_1800046C0(v55, 0LL, "Mesh");
			//             v56 = (BSP *)sub_180004920(TypeInfo::HG::Rendering::Runtime::CSG::BSP);
			//             v57 = v56;
			//             if ( v56 )
			//             {
			//               v62 = v63;
			//               HG::Rendering::Runtime::CSG::BSP::BSP(
			//                 v56,
			//                 (IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *)v8,
			//                 &v62,
			//                 v55,
			//                 1,
			//                 0LL);
			//               return v57;
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_34:
			//     sub_180B536AC(v7, v6);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4727, 0LL);
			//   if ( !Patch )
			//     goto LABEL_34;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1359(Patch, (Object *)m, objID, 0LL);
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static BSP fromMesh(Mesh m, Transform transform, Transform transform2, int objID, [MetadataOffset(Offset = "0x01F9216D")] int previous = 0)
		{
			// // BSP fromMesh(Mesh, Transform, Transform, Int32, Int32)
			// BSP *HG::Rendering::Runtime::CSG::BSP::fromMesh(
			//         Mesh *m,
			//         Transform *transform,
			//         Transform *transform2,
			//         int32_t objID,
			//         int32_t previous,
			//         MethodInfo *method)
			// {
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v10; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   Int32__Array *triangles; // r15
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v13; // rax
			//   MonitorData *v14; // r14
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *static_fields; // rdx
			//   Bounds *v16; // r8
			//   Object__Array *v17; // r9
			//   int32_t subMeshCount; // r14d
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v19; // rax
			//   List_1_System_Object_ *v20; // r15
			//   __int128 *v21; // rax
			//   __int128 v22; // xmm1
			//   BSP__StaticFields *v23; // rcx
			//   __int128 v24; // xmm0
			//   __int128 v25; // xmm1
			//   Matrix4x4 *localToWorldMatrix; // rax
			//   __int128 v27; // xmm1
			//   Matrix4x4 *worldToLocalMatrix; // rax
			//   __int128 v29; // xmm1
			//   BSP__StaticFields *v30; // rcx
			//   __int128 v31; // xmm0
			//   __int128 v32; // xmm1
			//   Vector3__Array *normals; // rbx
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v34; // rdx
			//   Bounds *v35; // r8
			//   Object__Array *v36; // r9
			//   Vector2__Array *uv; // rax
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v38; // rdx
			//   Bounds *v39; // r8
			//   Object__Array *v40; // r9
			//   Vector3__Array *vertices; // rax
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v42; // rdx
			//   Bounds *v43; // r8
			//   Object__Array *v44; // r9
			//   int32_t i; // ebx
			//   Int32__Array *v46; // r14
			//   List_1_System_Int32_ *v47; // rax
			//   Object *v48; // rsi
			//   int32_t j; // r14d
			//   Object *Item; // r15
			//   int32_t ProcessorCount; // eax
			//   __int64 v52; // r9
			//   int monitor; // ebx
			//   __int64 v54; // r8
			//   int v55; // r13d
			//   __int64 v56; // rdi
			//   int v57; // esi
			//   int v58; // r12d
			//   __int64 v59; // rax
			//   Bounds *v60; // r8
			//   Object__Array *v61; // r9
			//   __int64 v62; // rbx
			//   EventDelegateForClass_1_System_Object_ *v63; // rax
			//   ParameterizedThreadStart *v64; // r13
			//   Thread *v65; // rax
			//   __int64 v66; // rcx
			//   int v67; // r12d
			//   __int64 v68; // rax
			//   Bounds *v69; // r8
			//   Object__Array *v70; // r9
			//   __int64 v71; // rbx
			//   EventDelegateForClass_1_System_Object_ *v72; // rax
			//   ParameterizedThreadStart *v73; // r12
			//   Thread *v74; // rax
			//   Thread *v75; // r15
			//   unsigned int k; // ebx
			//   List_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *polygons; // rsi
			//   MethodInfo *v78; // rdx
			//   Vector3 *one; // rax
			//   __int64 v80; // xmm1_8
			//   Animator *v81; // rdx
			//   int32_t v82; // r8d
			//   MethodInfo *v83; // r9
			//   Vector3 *Vector; // rax
			//   __int64 v85; // xmm1_8
			//   __int64 v86; // r8
			//   __int64 v87; // r9
			//   __int64 v88; // rax
			//   Object__Array *v89; // rbx
			//   BSP *v90; // rax
			//   BSP *v91; // rdi
			//   MethodInfo *P3; // [rsp+28h] [rbp-A9h]
			//   MethodInfo *P3a; // [rsp+28h] [rbp-A9h]
			//   MethodInfo *P3c; // [rsp+28h] [rbp-A9h]
			//   MethodInfo *P3d; // [rsp+28h] [rbp-A9h]
			//   MethodInfo *P3b; // [rsp+28h] [rbp-A9h]
			//   MethodInfo *P4; // [rsp+30h] [rbp-A1h]
			//   MethodInfo *P4a; // [rsp+30h] [rbp-A1h]
			//   MethodInfo *P4c; // [rsp+30h] [rbp-A1h]
			//   MethodInfo *P4d; // [rsp+30h] [rbp-A1h]
			//   MethodInfo *P4b; // [rsp+30h] [rbp-A1h]
			//   __int128 v103; // [rsp+48h] [rbp-89h] BYREF
			//   __int128 v104; // [rsp+58h] [rbp-79h] BYREF
			//   Bounds v105; // [rsp+68h] [rbp-69h] BYREF
			//   int v106; // [rsp+80h] [rbp-51h]
			//   int v107; // [rsp+84h] [rbp-4Dh]
			//   Bounds v108; // [rsp+88h] [rbp-49h] BYREF
			//   Vector3 v109; // [rsp+A8h] [rbp-29h] BYREF
			//   Matrix4x4 v110; // [rsp+B8h] [rbp-19h] BYREF
			// 
			//   if ( !byte_18D919859 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::CSG::BSP::CreatePolygons);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CSG::BSP);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::Collections::Generic::List<int>>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::Collections::Generic::List<int>>::List);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGPolygon>::List);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::List);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::Collections::Generic::List<int>>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::Collections::Generic::List<int>>::get_Item);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<int>);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<System::Collections::Generic::List<int>>);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGPolygon>);
			//     sub_18003C530(&TypeInfo::System::Object);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::System::Threading::ParameterizedThreadStart);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CSG::ThreadData);
			//     sub_18003C530(&TypeInfo::System::Threading::Thread);
			//     sub_18003C530(&TypeInfo::System::Threading::Thread);
			//     sub_18003C530(&off_18D523958);
			//     byte_18D919859 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4575, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4575, 0LL);
			//     if ( !Patch )
			//       goto LABEL_57;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1309(
			//              Patch,
			//              (Object *)m,
			//              (Object *)transform,
			//              (Object *)transform2,
			//              objID,
			//              previous,
			//              0LL);
			//   }
			//   else
			//   {
			//     if ( !m )
			//       goto LABEL_57;
			//     triangles = UnityEngine::Mesh::get_triangles(m, 0LL);
			//     if ( !triangles )
			//       goto LABEL_57;
			//     v13 = (List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGPolygon>);
			//     v14 = (MonitorData *)v13;
			//     if ( !v13 )
			//       goto LABEL_57;
			//     System::Collections::Generic::List<Beyond::Gameplay::ZhuangfySleeveSolver::BoneData>::List(
			//       v13,
			//       triangles.max_length.size,
			//       MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGPolygon>::List);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::CSG::BSP);
			//     static_fields = (IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *)TypeInfo::HG::Rendering::Runtime::CSG::BSP.static_fields;
			//     static_fields.monitor = v14;
			//     sub_1800054D0(
			//       (BSP *)&TypeInfo::HG::Rendering::Runtime::CSG::BSP.static_fields.polygons,
			//       static_fields,
			//       v16,
			//       v17,
			//       P3,
			//       P4);
			//     subMeshCount = UnityEngine::Mesh::get_subMeshCount(m, 0LL);
			//     v19 = (List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<System::Collections::Generic::List<int>>);
			//     *(_QWORD *)&v109.x = v19;
			//     v20 = (List_1_System_Object_ *)v19;
			//     if ( !v19 )
			//       goto LABEL_57;
			//     System::Collections::Generic::List<Beyond::Gameplay::ZhuangfySleeveSolver::BoneData>::List(
			//       v19,
			//       subMeshCount,
			//       MethodInfo::System::Collections::Generic::List<System::Collections::Generic::List<int>>::List);
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Inequality((Object_1 *)transform, 0LL, 0LL) )
			//     {
			//       if ( !transform )
			//         goto LABEL_57;
			//       localToWorldMatrix = UnityEngine::Transform::get_localToWorldMatrix(&v110, transform, 0LL);
			//       *(_OWORD *)&v105.m_Center.x = *(_OWORD *)&localToWorldMatrix.m00;
			//       *(_OWORD *)&v108.m_Center.x = *(_OWORD *)&localToWorldMatrix.m01;
			//       v104 = *(_OWORD *)&localToWorldMatrix.m02;
			//       v103 = *(_OWORD *)&localToWorldMatrix.m03;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::CSG::BSP);
			//       v27 = *(_OWORD *)&v108.m_Center.x;
			//       v23 = TypeInfo::HG::Rendering::Runtime::CSG::BSP.static_fields;
			//       *(_OWORD *)&v23.matrix.m00 = *(_OWORD *)&v105.m_Center.x;
			//       v24 = v104;
			//       *(_OWORD *)&v23.matrix.m01 = v27;
			//       v25 = v103;
			//     }
			//     else
			//     {
			//       v21 = (__int128 *)sub_182805160(&v110);
			//       v104 = *v21;
			//       v103 = v21[1];
			//       *(_OWORD *)&v108.m_Center.x = v21[2];
			//       *(_OWORD *)&v105.m_Center.x = v21[3];
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::CSG::BSP);
			//       v22 = v103;
			//       v23 = TypeInfo::HG::Rendering::Runtime::CSG::BSP.static_fields;
			//       *(_OWORD *)&v23.matrix.m00 = v104;
			//       v24 = *(_OWORD *)&v108.m_Center.x;
			//       *(_OWORD *)&v23.matrix.m01 = v22;
			//       v25 = *(_OWORD *)&v105.m_Center.x;
			//     }
			//     *(_OWORD *)&v23.matrix.m02 = v24;
			//     *(_OWORD *)&v23.matrix.m03 = v25;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Inequality((Object_1 *)transform2, 0LL, 0LL) )
			//     {
			//       if ( !transform2 )
			//         goto LABEL_57;
			//       worldToLocalMatrix = UnityEngine::Transform::get_worldToLocalMatrix(&v110, transform2, 0LL);
			//     }
			//     else
			//     {
			//       worldToLocalMatrix = (Matrix4x4 *)sub_182805160(&v110);
			//     }
			//     *(_OWORD *)&v105.m_Center.x = *(_OWORD *)&worldToLocalMatrix.m00;
			//     *(_OWORD *)&v108.m_Center.x = *(_OWORD *)&worldToLocalMatrix.m01;
			//     v104 = *(_OWORD *)&worldToLocalMatrix.m02;
			//     v103 = *(_OWORD *)&worldToLocalMatrix.m03;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::CSG::BSP);
			//     v29 = *(_OWORD *)&v108.m_Center.x;
			//     v30 = TypeInfo::HG::Rendering::Runtime::CSG::BSP.static_fields;
			//     *(_OWORD *)&v30.matrix2.m00 = *(_OWORD *)&v105.m_Center.x;
			//     v31 = v104;
			//     *(_OWORD *)&v30.matrix2.m01 = v29;
			//     v32 = v103;
			//     *(_OWORD *)&v30.matrix2.m02 = v31;
			//     *(_OWORD *)&v30.matrix2.m03 = v32;
			//     normals = UnityEngine::Mesh::get_normals(m, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::CSG::BSP);
			//     v34 = (IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *)TypeInfo::HG::Rendering::Runtime::CSG::BSP.static_fields;
			//     v34[9].monitor = (MonitorData *)normals;
			//     sub_1800054D0((BSP *)&TypeInfo::HG::Rendering::Runtime::CSG::BSP.static_fields.normals, v34, v35, v36, P3a, P4a);
			//     uv = UnityEngine::Mesh::get_uv(m, 0LL);
			//     v38 = (IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *)TypeInfo::HG::Rendering::Runtime::CSG::BSP.static_fields;
			//     v38[10].klass = (IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon___Class *)uv;
			//     sub_1800054D0((BSP *)&TypeInfo::HG::Rendering::Runtime::CSG::BSP.static_fields.uv, v38, v39, v40, P3c, P4c);
			//     vertices = UnityEngine::Mesh::get_vertices(m, 0LL);
			//     v42 = (IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *)TypeInfo::HG::Rendering::Runtime::CSG::BSP.static_fields;
			//     v42[9].klass = (IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon___Class *)vertices;
			//     sub_1800054D0((BSP *)&TypeInfo::HG::Rendering::Runtime::CSG::BSP.static_fields.vertices, v42, v43, v44, P3d, P4d);
			//     for ( i = 0; i < UnityEngine::Mesh::get_subMeshCount(m, 0LL); ++i )
			//     {
			//       v46 = UnityEngine::Mesh::GetTriangles(m, i, 0LL);
			//       v47 = (List_1_System_Int32_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<int>);
			//       v48 = (Object *)v47;
			//       if ( !v47 )
			//         goto LABEL_57;
			//       System::Collections::Generic::List<int>::List(
			//         v47,
			//         (IEnumerable_1_System_Int32_ *)v46,
			//         MethodInfo::System::Collections::Generic::List<int>::List);
			//       sub_1822AD140(v20, v48);
			//     }
			//     for ( j = 0; j < v20.fields._size; ++j )
			//     {
			//       Item = System::Collections::Generic::List<System::Object>::get_Item(
			//                v20,
			//                j,
			//                MethodInfo::System::Collections::Generic::List<System::Collections::Generic::List<int>>::get_Item);
			//       ProcessorCount = UnityEngine::SystemInfo::GetProcessorCount(0LL);
			//       if ( !Item )
			//         goto LABEL_57;
			//       monitor = (int)Item[1].monitor;
			//       if ( ProcessorCount < monitor )
			//         monitor = ProcessorCount;
			//       if ( monitor <= 0 )
			//         monitor = 1;
			//       v54 = (unsigned int)(SLODWORD(Item[1].monitor) / monitor % 3);
			//       v55 = SLODWORD(Item[1].monitor) / monitor - v54;
			//       v106 = v55;
			//       v56 = il2cpp_array_new_specific_0(TypeInfo::System::Threading::Thread, (unsigned int)monitor, v54, v52);
			//       v57 = 0;
			//       v107 = monitor - 1;
			//       if ( monitor - 1 > 0 )
			//       {
			//         v58 = 0;
			//         while ( 1 )
			//         {
			//           v59 = sub_180004920(TypeInfo::HG::Rendering::Runtime::CSG::ThreadData);
			//           v62 = v59;
			//           if ( !v59 )
			//             break;
			//           *(_DWORD *)(v59 + 16) = v58;
			//           *(_DWORD *)(v59 + 20) = v58 + v55;
			//           *(_DWORD *)(v59 + 120) = objID;
			//           *(_DWORD *)(v59 + 124) = previous;
			//           *(_QWORD *)(v59 + 112) = Item;
			//           sub_1800054D0((BSP *)(v59 + 112), v10, v60, v61, P3b, P4b);
			//           *(_DWORD *)(v62 + 128) = j;
			//           v63 = (EventDelegateForClass_1_System_Object_ *)sub_180004920(TypeInfo::System::Threading::ParameterizedThreadStart);
			//           v64 = (ParameterizedThreadStart *)v63;
			//           if ( !v63 )
			//             break;
			//           Beyond::EventDelegateForClass<System::Object>::EventDelegateForClass(
			//             v63,
			//             0LL,
			//             MethodInfo::HG::Rendering::Runtime::CSG::BSP::CreatePolygons,
			//             0LL);
			//           v65 = (Thread *)sub_180004920(TypeInfo::System::Threading::Thread);
			//           *(_QWORD *)&v103 = v65;
			//           if ( !v65 )
			//             break;
			//           System::Threading::Thread::Thread(v65, v64, 0LL);
			//           if ( !v56 )
			//             break;
			//           sub_18000FDA0(v56, v57, v103);
			//           if ( (unsigned int)v57 >= *(_DWORD *)(v56 + 24) )
			//             goto LABEL_52;
			//           Patch = *(ILFixDynamicMethodWrapper_2 **)(v56 + 8LL * v57 + 32);
			//           if ( !Patch )
			//             break;
			//           System::Threading::Thread::set_Priority(Patch, 4LL);
			//           if ( (unsigned int)v57 >= *(_DWORD *)(v56 + 24) )
			//             goto LABEL_52;
			//           Patch = *(ILFixDynamicMethodWrapper_2 **)(v56 + 8LL * v57 + 32);
			//           if ( !Patch )
			//             break;
			//           System::Threading::Thread::Start((Thread *)Patch, (Object *)v62, 0LL);
			//           v55 = v106;
			//           ++v57;
			//           v58 += v106;
			//           if ( v57 >= v107 )
			//             goto LABEL_38;
			//         }
			// LABEL_57:
			//         sub_180B536AC(Patch, v10);
			//       }
			// LABEL_38:
			//       v67 = (int)Item[1].monitor;
			//       v68 = sub_180004920(TypeInfo::HG::Rendering::Runtime::CSG::ThreadData);
			//       v71 = v68;
			//       if ( !v68 )
			//         goto LABEL_57;
			//       *(_DWORD *)(v68 + 20) = v67;
			//       *(_DWORD *)(v68 + 16) = v55 * v57;
			//       *(_DWORD *)(v68 + 120) = objID;
			//       *(_DWORD *)(v68 + 124) = previous;
			//       *(_QWORD *)(v68 + 112) = Item;
			//       sub_1800054D0((BSP *)(v68 + 112), v10, v69, v70, P3b, P4b);
			//       *(_DWORD *)(v71 + 128) = j;
			//       v72 = (EventDelegateForClass_1_System_Object_ *)sub_180004920(TypeInfo::System::Threading::ParameterizedThreadStart);
			//       v73 = (ParameterizedThreadStart *)v72;
			//       if ( !v72 )
			//         goto LABEL_57;
			//       Beyond::EventDelegateForClass<System::Object>::EventDelegateForClass(
			//         v72,
			//         0LL,
			//         MethodInfo::HG::Rendering::Runtime::CSG::BSP::CreatePolygons,
			//         0LL);
			//       v74 = (Thread *)sub_180004920(TypeInfo::System::Threading::Thread);
			//       v75 = v74;
			//       if ( !v74 )
			//         goto LABEL_57;
			//       System::Threading::Thread::Thread(v74, v73, 0LL);
			//       if ( !v56 )
			//         goto LABEL_57;
			//       sub_18000FDA0(v56, v57, v75);
			//       if ( (unsigned int)v57 >= *(_DWORD *)(v56 + 24) )
			//         goto LABEL_52;
			//       Patch = *(ILFixDynamicMethodWrapper_2 **)(v56 + 8LL * v57 + 32);
			//       if ( !Patch )
			//         goto LABEL_57;
			//       System::Threading::Thread::set_Priority(Patch, 4LL);
			//       if ( (unsigned int)v57 >= *(_DWORD *)(v56 + 24) )
			// LABEL_52:
			//         sub_180070270(v66, v10);
			//       Patch = *(ILFixDynamicMethodWrapper_2 **)(v56 + 8LL * v57 + 32);
			//       if ( !Patch )
			//         goto LABEL_57;
			//       System::Threading::Thread::Start((Thread *)Patch, (Object *)v71, 0LL);
			//       for ( k = 0; (signed int)k < *(_DWORD *)(v56 + 24); ++k )
			//       {
			//         if ( k >= *(_DWORD *)(v56 + 24) )
			//           goto LABEL_52;
			//         Patch = *(ILFixDynamicMethodWrapper_2 **)(v56 + 8LL * (int)k + 32);
			//         if ( !Patch )
			//           goto LABEL_57;
			//         System::Threading::Thread::JoinInternal((System::Threading::Thread *)Patch, -1);
			//       }
			//       v20 = *(List_1_System_Object_ **)&v109.x;
			//     }
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::CSG::BSP);
			//     memset(&v105, 0, sizeof(v105));
			//     polygons = TypeInfo::HG::Rendering::Runtime::CSG::BSP.static_fields.polygons;
			//     one = UnityEngine::Vector3::get_one((Vector3 *)&v103, v78);
			//     v80 = *(_QWORD *)&one.x;
			//     *(float *)&one = one.z;
			//     *(_QWORD *)&v109.x = v80;
			//     LODWORD(v109.z) = (_DWORD)one;
			//     Vector = UnityEngine::Animator::GetVector((Vector3 *)&v104, v81, v82, v83);
			//     v85 = *(_QWORD *)&Vector.x;
			//     *(float *)&Vector = Vector.z;
			//     *(_QWORD *)&v103 = v85;
			//     DWORD2(v103) = (_DWORD)Vector;
			//     UnityEngine::Bounds::Bounds(&v105, (Vector3 *)&v103, &v109, 0LL);
			//     v88 = il2cpp_array_new_specific_0(TypeInfo::System::Object, 1LL, v86, v87);
			//     v89 = (Object__Array *)v88;
			//     if ( !v88 )
			//       goto LABEL_57;
			//     sub_180036D40(v88, "Mesh");
			//     sub_1800046C0(v89, 0LL, "Mesh");
			//     v90 = (BSP *)sub_180004920(TypeInfo::HG::Rendering::Runtime::CSG::BSP);
			//     v91 = v90;
			//     if ( !v90 )
			//       goto LABEL_57;
			//     v108 = v105;
			//     HG::Rendering::Runtime::CSG::BSP::BSP(
			//       v90,
			//       (IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *)polygons,
			//       &v108,
			//       v89,
			//       1,
			//       0LL);
			//     return v91;
			//   }
			// }
			// 
			return null;
		}

		public static void CreatePolygons(object obj)
		{
			// // Void CreatePolygons(Object)
			// // Hidden C++ exception states: #wind=3
			// void HG::Rendering::Runtime::CSG::BSP::CreatePolygons(Object *obj, MethodInfo *method)
			// {
			//   __int64 v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   __int64 v6; // r14
			//   int32_t v7; // r13d
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   __int64 Item; // rsi
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   __int64 v13; // r15
			//   BSP__StaticFields *static_fields; // rdx
			//   Vector3__Array *vertices; // rbx
			//   struct BSP__Class *v16; // rbx
			//   Matrix4x4 *p_matrix; // rdx
			//   Vector3 *v18; // rax
			//   __int64 v19; // rdx
			//   __int64 v20; // rcx
			//   __int64 v21; // xmm6_8
			//   BSP__StaticFields *v22; // rax
			//   __int64 v23; // rdx
			//   BSP__StaticFields *v24; // rcx
			//   __int64 v25; // rdx
			//   __int64 v26; // rcx
			//   CSGVertex *v27; // r12
			//   __int64 v28; // rdx
			//   BSP__StaticFields *v29; // rcx
			//   struct BSP__Class *v30; // rbx
			//   Matrix4x4 *v31; // rdx
			//   Vector3 *v32; // rax
			//   __int64 v33; // rdx
			//   __int64 v34; // rcx
			//   __int64 v35; // xmm6_8
			//   BSP__StaticFields *v36; // rax
			//   __int64 v37; // rdx
			//   BSP__StaticFields *v38; // rcx
			//   __int64 v39; // rdx
			//   __int64 v40; // rcx
			//   CSGVertex *v41; // rsi
			//   __int64 v42; // rdx
			//   BSP__StaticFields *v43; // rcx
			//   __int64 v44; // r15
			//   struct BSP__Class *v45; // rbx
			//   Matrix4x4 *v46; // rdx
			//   Vector3 *v47; // rax
			//   __int64 v48; // rdx
			//   __int64 v49; // rcx
			//   __int64 v50; // xmm6_8
			//   BSP__StaticFields *v51; // rax
			//   __int64 v52; // rdx
			//   BSP__StaticFields *v53; // rcx
			//   __int64 v54; // rdx
			//   __int64 v55; // rcx
			//   CSGVertex *v56; // rbx
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v57; // rax
			//   __int64 v58; // rdx
			//   __int64 v59; // rcx
			//   List_1_System_Object_ *v60; // r15
			//   List_1_System_Object_ *polygons; // r12
			//   struct CSGPolygon__Class *element_class; // rbx
			//   __int64 instance_size; // rcx
			//   __int64 v64; // rdx
			//   CSGPolygon *v65; // rax
			//   __int64 v66; // rdx
			//   CSGPolygon *v67; // rsi
			//   char *p_fields; // rcx
			//   __int64 v69; // r8
			//   char *v70; // rax
			//   unsigned __int64 v71; // r8
			//   __int64 v72; // rdx
			//   __int64 v73; // rcx
			//   __int64 v74; // rdx
			//   __int64 v75; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v77; // rdx
			//   __int64 v78; // rcx
			//   float z; // [rsp+30h] [rbp-238h]
			//   float v80; // [rsp+30h] [rbp-238h]
			//   int v81; // [rsp+30h] [rbp-238h]
			//   int v82; // [rsp+34h] [rbp-234h]
			//   float v83; // [rsp+34h] [rbp-234h]
			//   int v84; // [rsp+34h] [rbp-234h]
			//   int32_t objID; // [rsp+38h] [rbp-230h]
			//   Object *obja; // [rsp+40h] [rbp-228h] BYREF
			//   __int64 *v87; // [rsp+48h] [rbp-220h] BYREF
			//   Vector2 v88; // [rsp+50h] [rbp-218h] BYREF
			//   Vector2 v89; // [rsp+58h] [rbp-210h] BYREF
			//   Vector2 v90; // [rsp+60h] [rbp-208h] BYREF
			//   __int64 v91; // [rsp+68h] [rbp-200h]
			//   Vector3 v92; // [rsp+70h] [rbp-1F8h] BYREF
			//   Vector3 v93; // [rsp+80h] [rbp-1E8h] BYREF
			//   Vector3 v94; // [rsp+90h] [rbp-1D8h] BYREF
			//   Vector3 v95; // [rsp+A0h] [rbp-1C8h] BYREF
			//   Vector3 v96; // [rsp+B0h] [rbp-1B8h] BYREF
			//   Vector3 v97; // [rsp+C0h] [rbp-1A8h] BYREF
			//   Vector3 v98; // [rsp+D0h] [rbp-198h] BYREF
			//   Vector3 v99; // [rsp+E0h] [rbp-188h] BYREF
			//   Vector3 v100; // [rsp+F0h] [rbp-178h] BYREF
			//   Vector3 v101; // [rsp+100h] [rbp-168h] BYREF
			//   Vector3 v102; // [rsp+110h] [rbp-158h] BYREF
			//   Vector3 v103; // [rsp+120h] [rbp-148h] BYREF
			//   Vector3 v104; // [rsp+130h] [rbp-138h] BYREF
			//   Vector3 v105; // [rsp+140h] [rbp-128h] BYREF
			//   Vector3 v106; // [rsp+150h] [rbp-118h] BYREF
			//   Vector3 v107; // [rsp+160h] [rbp-108h] BYREF
			//   Vector3 v108; // [rsp+170h] [rbp-F8h] BYREF
			//   Vector3 v109; // [rsp+180h] [rbp-E8h] BYREF
			//   Il2CppException *ex; // [rsp+190h] [rbp-D8h] BYREF
			//   __int128 v111; // [rsp+198h] [rbp-D0h]
			//   __int128 v112; // [rsp+1A8h] [rbp-C0h]
			//   char v113[8]; // [rsp+1B8h] [rbp-B0h] BYREF
			//   char v114; // [rsp+1C0h] [rbp-A8h] BYREF
			//   Il2CppExceptionWrapper *v115; // [rsp+1C8h] [rbp-A0h] BYREF
			//   Vector3 v116; // [rsp+1D0h] [rbp-98h] BYREF
			//   Vector3 v117; // [rsp+1E0h] [rbp-88h] BYREF
			//   Vector3 v118; // [rsp+1F0h] [rbp-78h] BYREF
			//   Vector3 v119; // [rsp+200h] [rbp-68h] BYREF
			//   Vector3 v120; // [rsp+210h] [rbp-58h] BYREF
			//   Vector3 v121[2]; // [rsp+220h] [rbp-48h] BYREF
			//   bool lockTaken; // [rsp+280h] [rbp+18h] BYREF
			//   int32_t v123; // [rsp+288h] [rbp+20h]
			// 
			//   if ( !byte_18D91985A )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CSG::BSP);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CSG::CSGPolygon);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CSG::CSGVertex);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGVertex>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGPolygon>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGVertex>::List);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGVertex>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CSG::ThreadData);
			//     byte_18D91985A = 1;
			//   }
			//   obja = 0LL;
			//   lockTaken = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(4576, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4576, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v78, v77);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, obj, 0LL);
			//   }
			//   else
			//   {
			//     v3 = sub_18003F5A0(obj, TypeInfo::HG::Rendering::Runtime::CSG::ThreadData);
			//     v6 = v3;
			//     v91 = v3;
			//     if ( !v3 )
			//       sub_180B536AC(v5, v4);
			//     v7 = *(_DWORD *)(v3 + 16);
			//     v123 = v7;
			//     while ( v7 < *(_DWORD *)(v6 + 20) )
			//     {
			//       if ( !*(_QWORD *)(v6 + 112) )
			//         sub_180B536AC(v5, v4);
			//       Item = (int)System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::get_Item(
			//                     *(List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ **)(v6 + 112),
			//                     v7,
			//                     MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//       if ( !*(_QWORD *)(v6 + 112) )
			//         sub_180B536AC(v9, v8);
			//       v13 = (int)System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::get_Item(
			//                    *(List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ **)(v6 + 112),
			//                    v7 + 1,
			//                    MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//       if ( !*(_QWORD *)(v6 + 112) )
			//         sub_180B536AC(v12, v11);
			//       v82 = (int)System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::get_Item(
			//                    *(List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ **)(v6 + 112),
			//                    v7 + 2,
			//                    MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::CSG::BSP);
			//       static_fields = TypeInfo::HG::Rendering::Runtime::CSG::BSP.static_fields;
			//       vertices = static_fields.vertices;
			//       if ( !vertices )
			//         sub_180B536AC(TypeInfo::HG::Rendering::Runtime::CSG::BSP, static_fields);
			//       sub_180040F70(vertices, &v95, Item);
			//       v16 = TypeInfo::HG::Rendering::Runtime::CSG::BSP;
			//       p_matrix = &TypeInfo::HG::Rendering::Runtime::CSG::BSP.static_fields.matrix;
			//       v96 = v95;
			//       v97 = *UnityEngine::Matrix4x4::MultiplyPoint3x4(&v116, p_matrix, &v96, 0LL);
			//       v18 = UnityEngine::Matrix4x4::MultiplyPoint3x4(&v117, &v16.static_fields.matrix2, &v97, 0LL);
			//       v21 = *(_QWORD *)&v18.x;
			//       z = v18.z;
			//       v22 = v16.static_fields;
			//       if ( !v22.normals )
			//         sub_180B536AC(v20, v19);
			//       sub_180040F70(v22.normals, &v98, Item);
			//       v24 = TypeInfo::HG::Rendering::Runtime::CSG::BSP.static_fields;
			//       if ( !v24.uv )
			//         sub_180B536AC(v24, v23);
			//       sub_18004E290(v24.uv, &v88, Item);
			//       v27 = (CSGVertex *)sub_180004920(TypeInfo::HG::Rendering::Runtime::CSG::CSGVertex);
			//       if ( !v27 )
			//         sub_180B536AC(v26, v25);
			//       v99 = v98;
			//       *(_QWORD *)&v100.x = v21;
			//       v100.z = z;
			//       HG::Rendering::Runtime::CSG::CSGVertex::CSGVertex(v27, &v100, &v99, v88, Item, 0LL);
			//       v29 = TypeInfo::HG::Rendering::Runtime::CSG::BSP.static_fields;
			//       if ( !v29.vertices )
			//         sub_180B536AC(v29, v28);
			//       sub_180040F70(v29.vertices, &v101, v13);
			//       v30 = TypeInfo::HG::Rendering::Runtime::CSG::BSP;
			//       v31 = &TypeInfo::HG::Rendering::Runtime::CSG::BSP.static_fields.matrix;
			//       v102 = v101;
			//       v103 = *UnityEngine::Matrix4x4::MultiplyPoint3x4(&v118, v31, &v102, 0LL);
			//       v32 = UnityEngine::Matrix4x4::MultiplyPoint3x4(&v119, &v30.static_fields.matrix2, &v103, 0LL);
			//       v35 = *(_QWORD *)&v32.x;
			//       v80 = v32.z;
			//       v36 = v30.static_fields;
			//       if ( !v36.normals )
			//         sub_180B536AC(v34, v33);
			//       sub_180040F70(v36.normals, &v104, v13);
			//       v38 = TypeInfo::HG::Rendering::Runtime::CSG::BSP.static_fields;
			//       if ( !v38.uv )
			//         sub_180B536AC(v38, v37);
			//       sub_18004E290(v38.uv, &v89, v13);
			//       v41 = (CSGVertex *)sub_180004920(TypeInfo::HG::Rendering::Runtime::CSG::CSGVertex);
			//       if ( !v41 )
			//         sub_180B536AC(v40, v39);
			//       v105 = v104;
			//       *(_QWORD *)&v106.x = v35;
			//       v106.z = v80;
			//       HG::Rendering::Runtime::CSG::CSGVertex::CSGVertex(v41, &v106, &v105, v89, v13, 0LL);
			//       v43 = TypeInfo::HG::Rendering::Runtime::CSG::BSP.static_fields;
			//       if ( !v43.vertices )
			//         sub_180B536AC(v43, v42);
			//       v44 = v82;
			//       sub_180040F70(v43.vertices, &v107, v82);
			//       v45 = TypeInfo::HG::Rendering::Runtime::CSG::BSP;
			//       v46 = &TypeInfo::HG::Rendering::Runtime::CSG::BSP.static_fields.matrix;
			//       v108 = v107;
			//       v109 = *UnityEngine::Matrix4x4::MultiplyPoint3x4(&v120, v46, &v108, 0LL);
			//       v47 = UnityEngine::Matrix4x4::MultiplyPoint3x4(v121, &v45.static_fields.matrix2, &v109, 0LL);
			//       v50 = *(_QWORD *)&v47.x;
			//       v83 = v47.z;
			//       v51 = v45.static_fields;
			//       if ( !v51.normals )
			//         sub_180B536AC(v49, v48);
			//       sub_180040F70(v51.normals, &v92, v44);
			//       v53 = TypeInfo::HG::Rendering::Runtime::CSG::BSP.static_fields;
			//       if ( !v53.uv )
			//         sub_180B536AC(v53, v52);
			//       sub_18004E290(v53.uv, &v90, v44);
			//       v56 = (CSGVertex *)sub_180004920(TypeInfo::HG::Rendering::Runtime::CSG::CSGVertex);
			//       if ( !v56 )
			//         sub_180B536AC(v55, v54);
			//       v93 = v92;
			//       *(_QWORD *)&v94.x = v50;
			//       v94.z = v83;
			//       HG::Rendering::Runtime::CSG::CSGVertex::CSGVertex(v56, &v94, &v93, v90, v44, 0LL);
			//       v57 = (List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGVertex>);
			//       v60 = (List_1_System_Object_ *)v57;
			//       if ( !v57 )
			//         sub_180B536AC(v59, v58);
			//       System::Collections::Generic::List<Beyond::Gameplay::ZhuangfySleeveSolver::BoneData>::List(
			//         v57,
			//         3,
			//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::CSG::CSGVertex>::List);
			//       sub_1822AD140(v60, (Object *)v27);
			//       sub_1822AD140(v60, (Object *)v41);
			//       sub_1822AD140(v60, (Object *)v56);
			//       obja = TypeInfo::HG::Rendering::Runtime::CSG::BSP.static_fields.locker;
			//       lockTaken = 0;
			//       *(_QWORD *)&v112 = &lockTaken;
			//       *((_QWORD *)&v112 + 1) = &obja;
			//       ex = 0LL;
			//       v111 = v112;
			//       try
			//       {
			//         System::Threading::Monitor::Enter(obja, &lockTaken, 0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::CSG::BSP);
			//         polygons = (List_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::CSG::BSP.static_fields.polygons;
			//         objID = *(_DWORD *)(v6 + 120);
			//         v84 = *(_DWORD *)(v6 + 124);
			//         v81 = *(_DWORD *)(v6 + 128);
			//         element_class = TypeInfo::HG::Rendering::Runtime::CSG::CSGPolygon;
			//         if ( ((__int64)TypeInfo::HG::Rendering::Runtime::CSG::CSGPolygon.vtable.Equals.methodPtr & 2) == 0 )
			//         {
			//           v87 = &qword_18CDB0B30;
			//           sub_1802924D0(&qword_18CDB0B30);
			//           sub_180060090(element_class, &v87);
			//           sub_180292530(v87);
			//         }
			//         if ( element_class._0.generic_class && ((__int64)element_class.vtable.Equals.methodPtr & 8) != 0 )
			//           element_class = (struct CSGPolygon__Class *)element_class._0.element_class;
			//         instance_size = element_class._1.instance_size;
			//         if ( ((__int64)element_class.vtable.Equals.methodPtr & 0x20) != 0 )
			//         {
			//           if ( element_class._0.gc_desc )
			//             v67 = (CSGPolygon *)sub_180004F80(instance_size, element_class);
			//           else
			//             v67 = (CSGPolygon *)sub_180005D40(instance_size, element_class);
			//         }
			//         else
			//         {
			//           v64 = 0LL;
			//           if ( dword_18D8E43FC == 1 )
			//             v64 = 3LL;
			//           v65 = (CSGPolygon *)sub_18002D3D0(instance_size, v64);
			//           v67 = v65;
			//           v65.klass = element_class;
			//           v65.monitor = 0LL;
			//           p_fields = (char *)&v65.fields;
			//           v69 = element_class._1.instance_size;
			//           if ( element_class._1.instance_size >= 0x80 )
			//           {
			//             sub_1802F01E0(p_fields, 0LL, v69 - 16);
			//           }
			//           else
			//           {
			//             v70 = (char *)v65 + v69;
			//             v71 = (unsigned __int64)(v70 - p_fields + 7) >> 3;
			//             if ( p_fields > v70 )
			//               v71 = 0LL;
			//             if ( v71 )
			//               sub_1802F01E0(p_fields, 0LL, 8 * v71);
			//           }
			//           _InterlockedIncrement64(&qword_18D8E51F8);
			//         }
			//         if ( (BYTE1(element_class.vtable.Equals.methodPtr) & 2) != 0 )
			//           sub_18002E8C0((_DWORD)v67, (unsigned int)sub_18007DC30, 0, (unsigned int)&v114, (__int64)v113);
			//         if ( (dword_18D8F6F50 & 0x80u) != 0 )
			//           sub_1802DAEC4(v67, element_class);
			//         il2cpp_runtime_class_init_0(element_class, v66);
			//         if ( !v67 )
			//           sub_1802DC2C8(v73, v72);
			//         HG::Rendering::Runtime::CSG::CSGPolygon::CSGPolygon(
			//           v67,
			//           (IEnumerable_1_HG_Rendering_Runtime_CSG_CSGVertex_ *)v60,
			//           objID,
			//           v84 + v81,
			//           0LL);
			//         if ( !polygons )
			//           sub_1802DC2C8(v75, v74);
			//         sub_1822AD140(polygons, (Object *)v67);
			//       }
			//       catch ( Il2CppExceptionWrapper *v115 )
			//       {
			//         ex = v115.ex;
			//         sub_1801E36E0(&ex);
			//         v6 = v91;
			//         v7 = v123;
			//         goto LABEL_50;
			//       }
			//       sub_1801E36E0(&ex);
			// LABEL_50:
			//       v7 += 3;
			//       v123 = v7;
			//     }
			//   }
			// }
			// 
		}

		public virtual void Subtract(BSP bInput)
		{
			// // Void Subtract(BSP)
			// void HG::Rendering::Runtime::CSG::BSP::Subtract(BSP *this, BSP *bInput, MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   Node_2 *v6; // rcx
			//   Node_2 *root; // rbx
			//   Node_2 *v8; // rbp
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *AllPolygons; // rax
			//   Nullable_1_UnityEngine_Bounds_ *v10; // rax
			//   Object__Array *description; // r8
			//   float z; // ecx
			//   __int64 v13; // xmm0_8
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v14; // rdx
			//   Bounds *v15; // r8
			//   Object__Array *v16; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *v18; // [rsp+20h] [rbp-38h]
			//   MethodInfo *v19; // [rsp+28h] [rbp-30h]
			//   Nullable_1_UnityEngine_Bounds_ v20; // [rsp+30h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D91985B )
			//   {
			//     sub_18003C530(&off_18D5239E8);
			//     byte_18D91985B = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4728, 0LL) )
			//   {
			//     root = this.fields.root;
			//     if ( bInput )
			//     {
			//       v6 = bInput.fields.root;
			//       if ( v6 )
			//       {
			//         v8 = HG::Rendering::Runtime::CSG::Node::Clone(v6, 0LL);
			//         if ( root )
			//         {
			//           HG::Rendering::Runtime::CSG::Node::Invert(root, 0LL);
			//           HG::Rendering::Runtime::CSG::Node::ClipTo(root, v8, 0LL);
			//           if ( v8 )
			//           {
			//             HG::Rendering::Runtime::CSG::Node::ClipTo(v8, root, 0LL);
			//             HG::Rendering::Runtime::CSG::Node::Invert(v8, 0LL);
			//             HG::Rendering::Runtime::CSG::Node::ClipTo(v8, root, 0LL);
			//             HG::Rendering::Runtime::CSG::Node::Invert(v8, 0LL);
			//             AllPolygons = HG::Rendering::Runtime::CSG::Node::get_AllPolygons(v8, 0LL);
			//             HG::Rendering::Runtime::CSG::Node::Build(root, AllPolygons, 0LL);
			//             HG::Rendering::Runtime::CSG::Node::Invert(root, 0LL);
			//             v10 = HG::Rendering::Runtime::CSG::BSP::MeasureBounds(&v20, this, this, 0LL);
			//             description = this.fields.description;
			//             z = v10.value.m_Extents.z;
			//             v13 = *(_QWORD *)&v10.value.m_Extents.x;
			//             *(_OWORD *)&this.fields._Bounds_k__BackingField.hasValue = *(_OWORD *)&v10.hasValue;
			//             *(_QWORD *)&this.fields._Bounds_k__BackingField.value.m_Extents.x = v13;
			//             this.fields._Bounds_k__BackingField.value.m_Extents.z = z;
			//             this.fields.description = HG::Rendering::Runtime::CSG::BSP::CreateDescription(
			//                                          this,
			//                                          (String *)"subtract",
			//                                          description,
			//                                          bInput.fields.description,
			//                                          0LL);
			//             sub_1800054D0((BSP *)&this.fields.description, v14, v15, v16, v18, v19);
			//             HG::Rendering::Runtime::CSG::BSP::InvokeChange(this, 0LL);
			//             return;
			//           }
			//         }
			//       }
			//     }
			// LABEL_10:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4728, 0LL);
			//   if ( !Patch )
			//     goto LABEL_10;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)bInput,
			//     0LL);
			// }
			// 
		}

		public virtual void Intersect(BSP bInput)
		{
			// // Void Intersect(BSP)
			// void HG::Rendering::Runtime::CSG::BSP::Intersect(BSP *this, BSP *bInput, MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   Node_2 *v6; // rcx
			//   Node_2 *root; // rsi
			//   Node_2 *v8; // r14
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *AllPolygons; // rax
			//   float z; // eax
			//   float w; // eax
			//   float v12; // eax
			//   float v13; // eax
			//   __int64 v14; // xmm1_8
			//   Vector3 *min; // rax
			//   __int128 v16; // xmm0
			//   __int64 v17; // xmm1_8
			//   __m128 x_low; // xmm8
			//   float x; // xmm7_4
			//   float v20; // eax
			//   __int64 v21; // xmm1_8
			//   Vector3 *v22; // rax
			//   __int128 v23; // xmm0
			//   __int64 v24; // xmm1_8
			//   __m128 y_low; // xmm6
			//   Vector3 *v26; // rax
			//   __m128 v27; // xmm0
			//   __int64 v28; // xmm1_8
			//   __m128 v29; // xmm11
			//   __int128 v30; // xmm0
			//   Vector3 *v31; // rax
			//   __int128 v32; // xmm0
			//   __int64 v33; // xmm2_8
			//   __m128 v34; // xmm0
			//   __m128 v35; // xmm10
			//   Vector3 *v36; // rax
			//   float v37; // eax
			//   __int64 v38; // xmm2_8
			//   float v39; // xmm9_4
			//   Vector3 *max; // rax
			//   __int128 v41; // xmm0
			//   __int64 v42; // xmm1_8
			//   __m128 v43; // xmm6
			//   Vector3 *v44; // rax
			//   __m128 v45; // xmm0
			//   float v46; // eax
			//   __int64 v47; // xmm2_8
			//   __m128 v48; // xmm8
			//   Vector3 *v49; // rax
			//   __int128 v50; // xmm0
			//   __int64 v51; // xmm1_8
			//   __m128 v52; // xmm6
			//   Vector3 *v53; // rax
			//   __m128 v54; // xmm0
			//   float v55; // eax
			//   __int64 v56; // xmm2_8
			//   __m128 v57; // xmm7
			//   Vector3 *v58; // rax
			//   __int128 v59; // xmm0
			//   __int64 v60; // xmm1_8
			//   Vector3 *v61; // rax
			//   __int64 v62; // xmm1_8
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v63; // rdx
			//   Bounds *v64; // r8
			//   Object__Array *v65; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *methoda; // [rsp+28h] [rbp-99h]
			//   MethodInfo *v68; // [rsp+30h] [rbp-91h]
			//   FormationSetting_FormationSlot v69; // [rsp+38h] [rbp-89h] BYREF
			//   Vector3 v70; // [rsp+58h] [rbp-69h] BYREF
			//   FormationSetting_FormationSlot v71; // [rsp+68h] [rbp-59h] BYREF
			//   Nullable_1_Beyond_Gameplay_FormationSetting_FormationSlot_ v72[4]; // [rsp+80h] [rbp-41h] BYREF
			// 
			//   if ( !byte_18D91985C )
			//   {
			//     sub_18003C530(&TypeInfo::System::Math);
			//     sub_18003C530(&MethodInfo::System::Nullable<UnityEngine::Bounds>::Nullable);
			//     sub_18003C530(&MethodInfo::System::Nullable<UnityEngine::Bounds>::get_HasValue);
			//     sub_18003C530(&MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
			//     sub_18003C530(&off_18D5239C8);
			//     byte_18D91985C = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4729, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4729, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//         (ILFixDynamicMethodWrapper_37 *)Patch,
			//         (Object *)this,
			//         (Object *)bInput,
			//         0LL);
			//       return;
			//     }
			// LABEL_14:
			//     sub_180B536AC(v6, v5);
			//   }
			//   root = this.fields.root;
			//   if ( !bInput )
			//     goto LABEL_14;
			//   v6 = bInput.fields.root;
			//   if ( !v6 )
			//     goto LABEL_14;
			//   v8 = HG::Rendering::Runtime::CSG::Node::Clone(v6, 0LL);
			//   if ( !root )
			//     goto LABEL_14;
			//   HG::Rendering::Runtime::CSG::Node::Invert(root, 0LL);
			//   if ( !v8 )
			//     goto LABEL_14;
			//   HG::Rendering::Runtime::CSG::Node::ClipTo(v8, root, 0LL);
			//   HG::Rendering::Runtime::CSG::Node::Invert(v8, 0LL);
			//   HG::Rendering::Runtime::CSG::Node::ClipTo(root, v8, 0LL);
			//   HG::Rendering::Runtime::CSG::Node::ClipTo(v8, root, 0LL);
			//   AllPolygons = HG::Rendering::Runtime::CSG::Node::get_AllPolygons(v8, 0LL);
			//   HG::Rendering::Runtime::CSG::Node::Build(root, AllPolygons, 0LL);
			//   HG::Rendering::Runtime::CSG::Node::Invert(root, 0LL);
			//   z = this.fields._Bounds_k__BackingField.value.m_Extents.z;
			//   *(_QWORD *)&v72[0].value.m_cacheLocalRot.y = *(_QWORD *)&this.fields._Bounds_k__BackingField.value.m_Extents.x;
			//   v72[0].value.m_cacheLocalRot.w = z;
			//   if ( this.fields._Bounds_k__BackingField.hasValue
			//     && (v12 = bInput.fields._Bounds_k__BackingField.value.m_Extents.z,
			//         *(_QWORD *)&v72[0].value.m_cacheLocalRot.y = *(_QWORD *)&bInput.fields._Bounds_k__BackingField.value.m_Extents.x,
			//         v72[0].value.m_cacheLocalRot.w = v12,
			//         bInput.fields._Bounds_k__BackingField.hasValue) )
			//   {
			//     v13 = this.fields._Bounds_k__BackingField.value.m_Extents.z;
			//     v14 = *(_QWORD *)&this.fields._Bounds_k__BackingField.value.m_Extents.x;
			//     *(_OWORD *)&v72[0].hasValue = *(_OWORD *)&this.fields._Bounds_k__BackingField.hasValue;
			//     v72[0].value.m_cacheLocalRot.w = v13;
			//     *(_QWORD *)&v72[0].value.m_cacheLocalRot.y = v14;
			//     System::Nullable<Beyond::Gameplay::FormationSetting::FormationSlot>::get_Value(
			//       &v71,
			//       v72,
			//       MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
			//     v69 = v71;
			//     min = UnityEngine::Bounds::get_min(&v70, (Bounds *)&v69, 0LL);
			//     v16 = *(_OWORD *)&bInput.fields._Bounds_k__BackingField.hasValue;
			//     v17 = *(_QWORD *)&bInput.fields._Bounds_k__BackingField.value.m_Extents.x;
			//     x_low = (__m128)LODWORD(min.x);
			//     v72[0].value.m_cacheLocalRot.w = bInput.fields._Bounds_k__BackingField.value.m_Extents.z;
			//     *(_OWORD *)&v72[0].hasValue = v16;
			//     *(_QWORD *)&v72[0].value.m_cacheLocalRot.y = v17;
			//     System::Nullable<Beyond::Gameplay::FormationSetting::FormationSlot>::get_Value(
			//       &v71,
			//       v72,
			//       MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
			//     v69 = v71;
			//     x = UnityEngine::Bounds::get_min(&v70, (Bounds *)&v69, 0LL).x;
			//     sub_180002C70(TypeInfo::System::Math);
			//     v20 = this.fields._Bounds_k__BackingField.value.m_Extents.z;
			//     v21 = *(_QWORD *)&this.fields._Bounds_k__BackingField.value.m_Extents.x;
			//     *(_OWORD *)&v72[0].hasValue = *(_OWORD *)&this.fields._Bounds_k__BackingField.hasValue;
			//     v72[0].value.m_cacheLocalRot.w = v20;
			//     *(_QWORD *)&v72[0].value.m_cacheLocalRot.y = v21;
			//     System::Nullable<Beyond::Gameplay::FormationSetting::FormationSlot>::get_Value(
			//       &v71,
			//       v72,
			//       MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
			//     v69 = v71;
			//     v22 = UnityEngine::Bounds::get_min(&v70, (Bounds *)&v69, 0LL);
			//     v23 = *(_OWORD *)&bInput.fields._Bounds_k__BackingField.hasValue;
			//     v24 = *(_QWORD *)&bInput.fields._Bounds_k__BackingField.value.m_Extents.x;
			//     y_low = (__m128)LODWORD(v22.y);
			//     v72[0].value.m_cacheLocalRot.w = bInput.fields._Bounds_k__BackingField.value.m_Extents.z;
			//     *(_OWORD *)&v72[0].hasValue = v23;
			//     *(_QWORD *)&v72[0].value.m_cacheLocalRot.y = v24;
			//     System::Nullable<Beyond::Gameplay::FormationSetting::FormationSlot>::get_Value(
			//       &v71,
			//       v72,
			//       MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
			//     v69 = v71;
			//     v26 = UnityEngine::Bounds::get_min(&v70, (Bounds *)&v69, 0LL);
			//     v27 = y_low;
			//     v27.m128_f32[0] = System::Math::Max(y_low.m128_f32[0], v26.y, 0LL);
			//     v28 = *(_QWORD *)&this.fields._Bounds_k__BackingField.value.m_Extents.x;
			//     v29 = v27;
			//     v30 = *(_OWORD *)&this.fields._Bounds_k__BackingField.hasValue;
			//     v72[0].value.m_cacheLocalRot.w = this.fields._Bounds_k__BackingField.value.m_Extents.z;
			//     *(_QWORD *)&v72[0].value.m_cacheLocalRot.y = v28;
			//     *(_OWORD *)&v72[0].hasValue = v30;
			//     System::Nullable<Beyond::Gameplay::FormationSetting::FormationSlot>::get_Value(
			//       &v71,
			//       v72,
			//       MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
			//     v69 = v71;
			//     v31 = UnityEngine::Bounds::get_min(&v70, (Bounds *)&v69, 0LL);
			//     v32 = *(_OWORD *)&bInput.fields._Bounds_k__BackingField.hasValue;
			//     v33 = *(_QWORD *)&bInput.fields._Bounds_k__BackingField.value.m_Extents.x;
			//     y_low.m128_i32[0] = LODWORD(v31.z);
			//     v72[0].value.m_cacheLocalRot.w = bInput.fields._Bounds_k__BackingField.value.m_Extents.z;
			//     *(_OWORD *)&v72[0].hasValue = v32;
			//     *(_QWORD *)&v72[0].value.m_cacheLocalRot.y = v33;
			//     System::Nullable<Beyond::Gameplay::FormationSetting::FormationSlot>::get_Value(
			//       &v71,
			//       v72,
			//       MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
			//     v34 = x_low;
			//     v69 = v71;
			//     v34.m128_f32[0] = System::Math::Max(x_low.m128_f32[0], x, 0LL);
			//     v35 = v34;
			//     v36 = UnityEngine::Bounds::get_min(&v70, (Bounds *)&v69, 0LL);
			//     v34.m128_f32[0] = System::Math::Max(y_low.m128_f32[0], v36.z, 0LL);
			//     v37 = this.fields._Bounds_k__BackingField.value.m_Extents.z;
			//     v38 = *(_QWORD *)&this.fields._Bounds_k__BackingField.value.m_Extents.x;
			//     v39 = v34.m128_f32[0];
			//     *(_OWORD *)&v72[0].hasValue = *(_OWORD *)&this.fields._Bounds_k__BackingField.hasValue;
			//     v72[0].value.m_cacheLocalRot.w = v37;
			//     *(_QWORD *)&v72[0].value.m_cacheLocalRot.y = v38;
			//     System::Nullable<Beyond::Gameplay::FormationSetting::FormationSlot>::get_Value(
			//       &v71,
			//       v72,
			//       MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
			//     v69 = v71;
			//     max = UnityEngine::Bounds::get_max(&v70, (Bounds *)&v69, 0LL);
			//     v41 = *(_OWORD *)&bInput.fields._Bounds_k__BackingField.hasValue;
			//     v42 = *(_QWORD *)&bInput.fields._Bounds_k__BackingField.value.m_Extents.x;
			//     v43 = (__m128)LODWORD(max.x);
			//     v72[0].value.m_cacheLocalRot.w = bInput.fields._Bounds_k__BackingField.value.m_Extents.z;
			//     *(_OWORD *)&v72[0].hasValue = v41;
			//     *(_QWORD *)&v72[0].value.m_cacheLocalRot.y = v42;
			//     System::Nullable<Beyond::Gameplay::FormationSetting::FormationSlot>::get_Value(
			//       &v71,
			//       v72,
			//       MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
			//     v69 = v71;
			//     v44 = UnityEngine::Bounds::get_max(&v70, (Bounds *)&v69, 0LL);
			//     v45 = v43;
			//     v45.m128_f32[0] = System::Math::Min(v43.m128_f32[0], v44.x, 0LL);
			//     v46 = this.fields._Bounds_k__BackingField.value.m_Extents.z;
			//     v47 = *(_QWORD *)&this.fields._Bounds_k__BackingField.value.m_Extents.x;
			//     v48 = v45;
			//     *(_OWORD *)&v72[0].hasValue = *(_OWORD *)&this.fields._Bounds_k__BackingField.hasValue;
			//     v72[0].value.m_cacheLocalRot.w = v46;
			//     *(_QWORD *)&v72[0].value.m_cacheLocalRot.y = v47;
			//     System::Nullable<Beyond::Gameplay::FormationSetting::FormationSlot>::get_Value(
			//       &v71,
			//       v72,
			//       MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
			//     v69 = v71;
			//     v49 = UnityEngine::Bounds::get_max(&v70, (Bounds *)&v69, 0LL);
			//     v50 = *(_OWORD *)&bInput.fields._Bounds_k__BackingField.hasValue;
			//     v51 = *(_QWORD *)&bInput.fields._Bounds_k__BackingField.value.m_Extents.x;
			//     v52 = (__m128)LODWORD(v49.y);
			//     v72[0].value.m_cacheLocalRot.w = bInput.fields._Bounds_k__BackingField.value.m_Extents.z;
			//     *(_OWORD *)&v72[0].hasValue = v50;
			//     *(_QWORD *)&v72[0].value.m_cacheLocalRot.y = v51;
			//     System::Nullable<Beyond::Gameplay::FormationSetting::FormationSlot>::get_Value(
			//       &v71,
			//       v72,
			//       MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
			//     v69 = v71;
			//     v53 = UnityEngine::Bounds::get_max(&v70, (Bounds *)&v69, 0LL);
			//     v54 = v52;
			//     v54.m128_f32[0] = System::Math::Min(v52.m128_f32[0], v53.y, 0LL);
			//     v55 = this.fields._Bounds_k__BackingField.value.m_Extents.z;
			//     v56 = *(_QWORD *)&this.fields._Bounds_k__BackingField.value.m_Extents.x;
			//     v57 = v54;
			//     *(_OWORD *)&v72[0].hasValue = *(_OWORD *)&this.fields._Bounds_k__BackingField.hasValue;
			//     v72[0].value.m_cacheLocalRot.w = v55;
			//     *(_QWORD *)&v72[0].value.m_cacheLocalRot.y = v56;
			//     System::Nullable<Beyond::Gameplay::FormationSetting::FormationSlot>::get_Value(
			//       &v71,
			//       v72,
			//       MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
			//     v69 = v71;
			//     v58 = UnityEngine::Bounds::get_max(&v70, (Bounds *)&v69, 0LL);
			//     v59 = *(_OWORD *)&bInput.fields._Bounds_k__BackingField.hasValue;
			//     v60 = *(_QWORD *)&bInput.fields._Bounds_k__BackingField.value.m_Extents.x;
			//     v52.m128_i32[0] = LODWORD(v58.z);
			//     v72[0].value.m_cacheLocalRot.w = bInput.fields._Bounds_k__BackingField.value.m_Extents.z;
			//     *(_OWORD *)&v72[0].hasValue = v59;
			//     *(_QWORD *)&v72[0].value.m_cacheLocalRot.y = v60;
			//     System::Nullable<Beyond::Gameplay::FormationSetting::FormationSlot>::get_Value(
			//       &v71,
			//       v72,
			//       MethodInfo::System::Nullable<UnityEngine::Bounds>::get_Value);
			//     v69 = v71;
			//     v61 = UnityEngine::Bounds::get_max(&v70, (Bounds *)&v69, 0LL);
			//     v69.m_cacheLocalRot.x = System::Math::Min(v52.m128_f32[0], v61.z, 0LL);
			//     v70.z = v39;
			//     *(_QWORD *)&v69.angle = _mm_unpacklo_ps(v48, v57).m128_u64[0];
			//     memset(&v71, 0, sizeof(v71));
			//     *(_QWORD *)&v70.x = _mm_unpacklo_ps(v35, v29).m128_u64[0];
			//     UnityEngine::Bounds::Bounds((Bounds *)&v71, &v70, (Vector3 *)&v69, 0LL);
			//     *(_WORD *)(&v72[0].hasValue + 1) = 0;
			//     v72[0].value = v71;
			//     *(&v72[0].hasValue + 3) = 0;
			//     v62 = *(_QWORD *)&v71.m_cacheLocalRot.y;
			//     w = v71.m_cacheLocalRot.w;
			//     v72[0].hasValue = 1;
			//     *(_OWORD *)&this.fields._Bounds_k__BackingField.hasValue = *(_OWORD *)&v72[0].hasValue;
			//     *(_QWORD *)&this.fields._Bounds_k__BackingField.value.m_Extents.x = v62;
			//   }
			//   else
			//   {
			//     w = 0.0;
			//     *(_OWORD *)&this.fields._Bounds_k__BackingField.hasValue = 0LL;
			//     *(_QWORD *)&v72[0].value.m_cacheLocalRot.y = 0LL;
			//     *(_QWORD *)&this.fields._Bounds_k__BackingField.value.m_Extents.x = 0LL;
			//   }
			//   this.fields._Bounds_k__BackingField.value.m_Extents.z = w;
			//   this.fields.description = HG::Rendering::Runtime::CSG::BSP::CreateDescription(
			//                                this,
			//                                (String *)"intersect",
			//                                this.fields.description,
			//                                bInput.fields.description,
			//                                0LL);
			//   sub_1800054D0((BSP *)&this.fields.description, v63, v64, v65, methoda, v68);
			//   HG::Rendering::Runtime::CSG::BSP::InvokeChange(this, 0LL);
			// }
			// 
		}

		public virtual void Clear()
		{
			// // Void Clear()
			// void HG::Rendering::Runtime::CSG::BSP::Clear(BSP *this, MethodInfo *method)
			// {
			//   Node_2 *v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   Node_2 *v6; // rdi
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v7; // rdx
			//   Bounds *v8; // r8
			//   Object__Array *v9; // r9
			//   __int64 v10; // r8
			//   __int64 v11; // r9
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v12; // rdx
			//   Bounds *v13; // r8
			//   Object__Array *v14; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *v16; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v17; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v18; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v19; // [rsp+28h] [rbp-20h]
			// 
			//   if ( !byte_18D91985D )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CSG::Node);
			//     sub_18003C530(&TypeInfo::System::Object);
			//     byte_18D91985D = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4730, 0LL) )
			//   {
			//     v3 = (Node_2 *)sub_180004920(TypeInfo::HG::Rendering::Runtime::CSG::Node);
			//     v6 = v3;
			//     if ( v3 )
			//     {
			//       HG::Rendering::Runtime::CSG::Node::Node(v3, 0LL);
			//       this.fields.root = v6;
			//       sub_1800054D0((BSP *)&this.fields.root, v7, v8, v9, v16, v18);
			//       *(_OWORD *)&this.fields._Bounds_k__BackingField.hasValue = 0LL;
			//       *(_QWORD *)&this.fields._Bounds_k__BackingField.value.m_Extents.x = 0LL;
			//       this.fields._Bounds_k__BackingField.value.m_Extents.z = 0.0;
			//       this.fields.description = (Object__Array *)il2cpp_array_new_specific_0(TypeInfo::System::Object, 0LL, v10, v11);
			//       sub_1800054D0((BSP *)&this.fields.description, v12, v13, v14, v17, v19);
			//       HG::Rendering::Runtime::CSG::BSP::InvokeChange(this, 0LL);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v5, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4730, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		public virtual Nullable<float> RayCast(Ray ray)
		{
			// // Nullable`1[Single] RayCast(Ray)
			// Nullable_1_Single_ HG::Rendering::Runtime::CSG::BSP::RayCast(BSP *this, Ray *ray, MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   bool v6; // zf
			//   float z; // eax
			//   Node_2 *root; // rcx
			//   __int64 v10; // xmm1_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v12; // xmm1_8
			//   Ray v13; // [rsp+20h] [rbp-28h] BYREF
			//   float v14; // [rsp+38h] [rbp-10h]
			// 
			//   if ( !byte_18D91985E )
			//   {
			//     sub_18003C530(&MethodInfo::System::Nullable<float>::Nullable);
			//     sub_18003C530(&MethodInfo::System::Nullable<UnityEngine::Bounds>::get_HasValue);
			//     sub_18003C530(&MethodInfo::System::Nullable<float>::get_HasValue);
			//     byte_18D91985E = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4731, 0LL) )
			//   {
			//     v6 = !this.fields._Bounds_k__BackingField.hasValue;
			//     z = this.fields._Bounds_k__BackingField.value.m_Extents.z;
			//     *(_QWORD *)&v13.m_Direction.y = *(_QWORD *)&this.fields._Bounds_k__BackingField.value.m_Extents.x;
			//     v14 = z;
			//     if ( v6 )
			//       return 0LL;
			//     root = this.fields.root;
			//     if ( root )
			//     {
			//       v10 = *(_QWORD *)&ray.m_Direction.y;
			//       *(_OWORD *)&v13.m_Origin.x = *(_OWORD *)&ray.m_Origin.x;
			//       *(_QWORD *)&v13.m_Direction.y = v10;
			//       return HG::Rendering::Runtime::CSG::Node::RayCast(root, &v13, 0LL);
			//     }
			// LABEL_9:
			//     sub_180B536AC(root, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4731, 0LL);
			//   if ( !Patch )
			//     goto LABEL_9;
			//   v12 = *(_QWORD *)&ray.m_Direction.y;
			//   *(_OWORD *)&v13.m_Origin.x = *(_OWORD *)&ray.m_Origin.x;
			//   *(_QWORD *)&v13.m_Direction.y = v12;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1362(Patch, (Object *)this, &v13, 0LL);
			// }
			// 
			return null;
		}

		public bool _createDescription;

		public object[] description;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static object locker;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		public static List<CSGPolygon> polygons;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		public static Matrix4x4 matrix;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x50")]
		public static Matrix4x4 matrix2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x90")]
		public static Vector3[] vertices;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x98")]
		public static Vector3[] normals;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA0")]
		public static Vector2[] uv;

		public Node root;
	}
}
