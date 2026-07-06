using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using IFix.Core;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 12)]
	public struct Circle
	{
		public Circle(Vector2 center, float radius)
		{
			// // ValueTuple`2[UnityEngine.Vector2Int,Single](Vector2Int, Single)
			// void System::ValueTuple<UnityEngine::Vector2Int,float>::ValueTuple(
			//         ValueTuple_2_UnityEngine_Vector2Int_Single_ *this,
			//         Vector2Int item1,
			//         float item2,
			//         MethodInfo *method)
			// {
			//   this.Item2 = item2;
			//   this.Item1 = item1;
			// }
			// 
		}

		[IDTag(0)]
		public bool Contains(Vector2 p)
		{
			// // Boolean Contains(Vector2)
			// bool HG::Rendering::Runtime::Circle::Contains(Circle_1 *this, Vector2 p, MethodInfo *method)
			// {
			//   double v5; // xmm0_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2179, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2179, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_793(Patch, this, p, 0LL);
			//   }
			//   else
			//   {
			//     v5 = sub_1829FB920(*(_QWORD *)&this.center, p);
			//     return this.radius >= *(float *)&v5;
			//   }
			// }
			// 
			return default(bool);
		}

		[IDTag(1)]
		public bool Contains(ICollection<Vector2> ps)
		{
			// // Boolean Contains(ICollection`1[UnityEngine.Vector2])
			// // Hidden C++ exception states: #wind=1 #try_helpers=1
			// bool HG::Rendering::Runtime::Circle::Contains(
			//         Circle_1 *this,
			//         ICollection_1_UnityEngine_Vector2_ *ps,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   Vector2 v11; // xmm6_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v14; // rdx
			//   __int64 v15; // rcx
			//   _QWORD v16[3]; // [rsp+28h] [rbp-30h] BYREF
			//   __int64 v17; // [rsp+78h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D919442 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::Circle);
			//     sub_18003C530(&TypeInfo::System::IDisposable);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::IEnumerable<UnityEngine::Vector2>);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::IEnumerator<UnityEngine::Vector2>);
			//     sub_18003C530(&TypeInfo::System::Collections::IEnumerator);
			//     byte_18D919442 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2180, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2180, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v15, v14);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_794(Patch, this, (Object *)ps, 0LL);
			//   }
			//   else
			//   {
			//     if ( !ps )
			//       sub_180B536AC(v6, v5);
			//     v17 = sub_1800513A0(0LL, TypeInfo::System::Collections::Generic::IEnumerable<UnityEngine::Vector2>, ps);
			//     v16[0] = 0LL;
			//     v16[1] = &v17;
			//     while ( 1 )
			//     {
			//       if ( !v17 )
			//         sub_1802DC2C8(v8, v7);
			//       if ( !(unsigned __int8)sub_1800518F0(0LL, TypeInfo::System::Collections::IEnumerator) )
			//         break;
			//       if ( !v17 )
			//         sub_1802DC2C8(v10, v9);
			//       v11 = (Vector2)sub_180410F48(0LL, TypeInfo::System::Collections::Generic::IEnumerator<UnityEngine::Vector2>, v17);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::Circle);
			//       if ( !HG::Rendering::Runtime::Circle::Contains(this, v11, 0LL) )
			//       {
			//         sub_1801E4D90(v16);
			//         return 0;
			//       }
			//     }
			//     sub_1801E4D90(v16);
			//     return 1;
			//   }
			// }
			// 
			return default(bool);
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static readonly Circle INVALID;

		private const float MULTIPLICATIVE_EPSILON = 1f;

		public Vector2 center;

		public float radius;
	}
}
