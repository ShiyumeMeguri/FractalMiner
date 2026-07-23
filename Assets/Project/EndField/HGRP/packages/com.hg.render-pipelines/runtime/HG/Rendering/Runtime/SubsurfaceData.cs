using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public struct SubsurfaceData // TypeDefIndex: 38606
	{
		// Fields
		public int RefCount; // 0x00
		public UnityEngine.Color SubsurfaceColor; // 0x04
		public float SubsurfaceIndirect; // 0x14
	
		// Methods
		public bool Equals(ref SubsurfaceData other) => default; // 0x0000000189C1B048-0x0000000189C1B19C
		// Boolean Equals(SubsurfaceData ByRef)
		bool HG::Rendering::Runtime::SubsurfaceData::Equals(SubsurfaceData *this, SubsurfaceData *other, MethodInfo *method)
		{
		  __int32 v5; // xmm3_4
		  Mathf__StaticFields *static_fields; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3910, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3910, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1377(Patch, this, other, 0LL);
		  }
		  else
		  {
		    COERCE_FLOAT(v5 = _mm_load_si128((const __m128i *)&xmmword_18B9592D0).m128i_i32[0]);
		    static_fields = TypeInfo::UnityEngine::Mathf->static_fields;
		    return fmaxf(
		             fmaxf(
		               COERCE_FLOAT(LODWORD(this->SubsurfaceColor.r) & v5),
		               COERCE_FLOAT(LODWORD(other->SubsurfaceColor.r) & v5))
		           * 0.000001,
		             static_fields->Epsilon * 8.0) > COERCE_FLOAT(COERCE_UNSIGNED_INT(other->SubsurfaceColor.r - this->SubsurfaceColor.r) & v5)
		        && fmaxf(
		             fmaxf(
		               COERCE_FLOAT(LODWORD(this->SubsurfaceColor.g) & v5),
		               COERCE_FLOAT(LODWORD(other->SubsurfaceColor.g) & v5))
		           * 0.000001,
		             static_fields->Epsilon * 8.0) > COERCE_FLOAT(COERCE_UNSIGNED_INT(other->SubsurfaceColor.g - this->SubsurfaceColor.g) & v5)
		        && fmaxf(
		             fmaxf(
		               COERCE_FLOAT(LODWORD(this->SubsurfaceColor.b) & v5),
		               COERCE_FLOAT(LODWORD(other->SubsurfaceColor.b) & v5))
		           * 0.000001,
		             static_fields->Epsilon * 8.0) > COERCE_FLOAT(COERCE_UNSIGNED_INT(other->SubsurfaceColor.b - this->SubsurfaceColor.b) & v5)
		        && fmaxf(
		             fmaxf(
		               COERCE_FLOAT(LODWORD(this->SubsurfaceIndirect) & v5),
		               COERCE_FLOAT(LODWORD(other->SubsurfaceIndirect) & v5))
		           * 0.000001,
		             static_fields->Epsilon * 8.0) > COERCE_FLOAT(COERCE_UNSIGNED_INT(other->SubsurfaceIndirect - this->SubsurfaceIndirect) & v5);
		  }
		}
		
	}
}
