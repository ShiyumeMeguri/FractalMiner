using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public struct Circle // TypeDefIndex: 37990
	{
		// Fields
		public static readonly Circle INVALID; // 0x00
		private const float MULTIPLICATIVE_EPSILON = 1f; // Metadata: 0x02303820
		public Vector2 center; // 0x00
		public float radius; // 0x08
	
		// Constructors
		public Circle(Vector2 center, float radius) {
			this.center = default;
			this.radius = default;
		} // 0x0000000184D8BEC0-0x0000000184D8BED0
		// ValueTuple`2[UnityEngine.Vector2Int,Single](Vector2Int, Single)
		void System::ValueTuple<UnityEngine::Vector2Int,float>::ValueTuple(
		        ValueTuple_2_UnityEngine_Vector2Int_Single_ *this,
		        Vector2Int item1,
		        float item2,
		        MethodInfo *method)
		{
		  this->Item2 = item2;
		  this->Item1 = item1;
		}
		
		static Circle() {
			INVALID = default;
		} // 0x0000000184DA14C0-0x0000000184DA14F0
		// Circle()
		void HG::Rendering::Runtime::Circle::cctor(MethodInfo *method)
		{
		  Circle_1__StaticFields *static_fields; // rcx
		
		  static_fields = TypeInfo::HG::Rendering::Runtime::Circle->static_fields;
		  static_fields->INVALID.center = (Vector2)_mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  static_fields->INVALID.radius = -1.0;
		}
		
	
		// Methods
		[IDTag(0)]
		public bool Contains(Vector2 p) => default; // 0x0000000189B68C54-0x0000000189B68CC8
		// Boolean Contains(Vector2)
		bool HG::Rendering::Runtime::Circle::Contains(Circle_1 *this, Vector2 p, MethodInfo *method)
		{
		  double v5; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2629, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2629, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_969(Patch, this, p, 0LL);
		  }
		  else
		  {
		    v5 = ((double (__fastcall *)(_QWORD, _QWORD))sub_183913BE0)(*(_QWORD *)&this->center, p);
		    return this->radius >= *(float *)&v5;
		  }
		}
		
		[IDTag(1)]
		public bool Contains(ICollection<Vector2> ps) => default; // 0x0000000189B68CC8-0x0000000189B68E34
		// Boolean Contains(ICollection`1[UnityEngine.Vector2])
		// Hidden C++ exception states: #wind=1 #try_helpers=1
		bool HG::Rendering::Runtime::Circle::Contains(
		        Circle_1 *this,
		        ICollection_1_UnityEngine_Vector2_ *ps,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  Vector2 v11; // xmm6_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  _QWORD v16[3]; // [rsp+28h] [rbp-30h] BYREF
		  __int64 v17; // [rsp+78h] [rbp+20h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2630, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2630, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v15, v14);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_970(Patch, this, (Object *)ps, 0LL);
		  }
		  else
		  {
		    if ( !ps )
		      sub_1800D8260(v6, v5);
		    v17 = sub_1800428A0(0LL, TypeInfo::System::Collections::Generic::IEnumerable<UnityEngine::Vector2>, ps);
		    v16[0] = 0LL;
		    v16[1] = &v17;
		    while ( 1 )
		    {
		      if ( !v17 )
		        sub_1800D8250(v8, v7);
		      if ( !(unsigned __int8)sub_180042E60(0LL, TypeInfo::System::Collections::IEnumerator) )
		        break;
		      if ( !v17 )
		        sub_1800D8250(v10, v9);
		      v11 = (Vector2)sub_180469DBC(0LL, TypeInfo::System::Collections::Generic::IEnumerator<UnityEngine::Vector2>, v17);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::Circle);
		      if ( !HG::Rendering::Runtime::Circle::Contains(this, v11, 0LL) )
		      {
		        sub_1801F6A10(v16);
		        return 0;
		      }
		    }
		    sub_1801F6A10(v16);
		    return 1;
		  }
		}
		
	}
}
