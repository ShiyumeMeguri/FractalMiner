using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public struct HGSludgeAlignedPlane // TypeDefIndex: 37683
	{
		// Fields
		public static HGSludgeAlignedPlane s_defaultPlane; // 0x00
		public bool enabled; // 0x00
		public HGSludgeAlignedPlaneType type; // 0x04
		public HGSludgePlaneClipMode clipMode; // 0x08
		public float coeff; // 0x0C
	
		// Constructors
		static HGSludgeAlignedPlane() {
			s_defaultPlane = default;
		} // 0x0000000184DA2140-0x0000000184DA2180
		// HGSludgeAlignedPlane()
		void HG::Rendering::Runtime::HGSludgeAlignedPlane::cctor(MethodInfo *method)
		{
		  HGSludgeAlignedPlane__StaticFields v1; // [rsp+0h] [rbp-18h]
		
		  *(_DWORD *)&v1.s_defaultPlane.enabled = 1;
		  *(_QWORD *)&v1.s_defaultPlane.type = 2LL;
		  v1.s_defaultPlane.coeff = -10000.0;
		  *TypeInfo::HG::Rendering::Runtime::HGSludgeAlignedPlane->static_fields = v1;
		}
		
	
		// Methods
		public Vector3 ApplyCoeff(Vector3 pos) => default; // 0x0000000189CF41D8-0x0000000189CF42AC
		// Vector3 ApplyCoeff(Vector3)
		Vector3 *HG::Rendering::Runtime::HGSludgeAlignedPlane::ApplyCoeff(
		        Vector3 *__return_ptr retstr,
		        HGSludgeAlignedPlane *this,
		        Vector3 *pos,
		        MethodInfo *method)
		{
		  int32_t type; // r8d
		  int v8; // r8d
		  int v9; // r8d
		  int v10; // r8d
		  __int64 v11; // xmm0_8
		  float v12; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v14; // rcx
		  float z; // eax
		  Vector3 *v16; // rax
		  Vector3 v18; // [rsp+30h] [rbp-28h] BYREF
		  Vector3 v19[2]; // [rsp+40h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1640, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1640, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v14, 0LL);
		    z = pos->z;
		    *(_QWORD *)&v18.x = *(_QWORD *)&pos->x;
		    v18.z = z;
		    v16 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_663(v19, Patch, this, &v18, 0LL);
		    v11 = *(_QWORD *)&v16->x;
		    v12 = v16->z;
		  }
		  else
		  {
		    type = this->type;
		    if ( type && (v8 = type - 1) != 0 )
		    {
		      v9 = v8 - 1;
		      if ( v9 && (v10 = v9 - 1) != 0 )
		      {
		        if ( (unsigned int)(v10 - 1) <= 1 )
		          pos->z = this->coeff;
		      }
		      else
		      {
		        pos->y = this->coeff;
		      }
		    }
		    else
		    {
		      pos->x = this->coeff;
		    }
		    v11 = *(_QWORD *)&pos->x;
		    v12 = pos->z;
		  }
		  *(_QWORD *)&retstr->x = v11;
		  retstr->z = v12;
		  return retstr;
		}
		
		public void SetCoeff(Vector3 pos) {} // 0x0000000189CF45C0-0x0000000189CF4660
		// Void SetCoeff(Vector3)
		void HG::Rendering::Runtime::HGSludgeAlignedPlane::SetCoeff(
		        HGSludgeAlignedPlane *this,
		        Vector3 *pos,
		        MethodInfo *method)
		{
		  int32_t type; // r8d
		  int v6; // r8d
		  int v7; // r8d
		  int v8; // r8d
		  float y; // eax
		  __int64 v10; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  float z; // eax
		  Vector3 v13; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1641, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1641, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v10);
		    z = pos->z;
		    *(_QWORD *)&v13.x = *(_QWORD *)&pos->x;
		    v13.z = z;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_664(Patch, this, &v13, 0LL);
		  }
		  else
		  {
		    type = this->type;
		    if ( type && (v6 = type - 1) != 0 )
		    {
		      v7 = v6 - 1;
		      if ( v7 && (v8 = v7 - 1) != 0 )
		      {
		        if ( (unsigned int)(v8 - 1) > 1 )
		          return;
		        y = pos->z;
		      }
		      else
		      {
		        y = pos->y;
		      }
		    }
		    else
		    {
		      y = pos->x;
		    }
		    this->coeff = y;
		  }
		}
		
		public Vector3 GetPlaneNormal() => default; // 0x0000000189CF43B8-0x0000000189CF44C4
		// Vector3 GetPlaneNormal()
		Vector3 *HG::Rendering::Runtime::HGSludgeAlignedPlane::GetPlaneNormal(
		        Vector3 *__return_ptr retstr,
		        HGSludgeAlignedPlane *this,
		        MethodInfo *method)
		{
		  unsigned __int64 type; // rdx
		  MethodInfo *v6; // rdx
		  MethodInfo *v7; // rdx
		  MethodInfo *v8; // rdx
		  Vector3 *v9; // rcx
		  Vector3 *up; // rax
		  Vector3 *fwd; // rax
		  MethodInfo *v12; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  __int64 v16; // xmm0_8
		  float z; // eax
		  Vector3 v19; // [rsp+20h] [rbp-20h] BYREF
		  Vector3 v20; // [rsp+30h] [rbp-10h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1642, 0LL) )
		  {
		    type = (unsigned int)this->type;
		    if ( (_DWORD)type )
		    {
		      v6 = (MethodInfo *)(unsigned int)(type - 1);
		      if ( (_DWORD)v6 )
		      {
		        v7 = (MethodInfo *)(unsigned int)((_DWORD)v6 - 1);
		        if ( !(_DWORD)v7 )
		        {
		          up = UnityEngine::Vector3::get_up(&v20, v7);
		          goto LABEL_21;
		        }
		        v8 = (MethodInfo *)(unsigned int)((_DWORD)v7 - 1);
		        if ( (_DWORD)v8 )
		        {
		          type = (unsigned int)((_DWORD)v8 - 1);
		          if ( !(_DWORD)type )
		          {
		            up = UnityEngine::Vector3::get_fwd(&v20, (MethodInfo *)type);
		            goto LABEL_21;
		          }
		          if ( (_DWORD)type != 1 )
		          {
		            v9 = &v19;
		LABEL_9:
		            up = UnityEngine::Vector3::get_right(v9, (MethodInfo *)type);
		            goto LABEL_21;
		          }
		          fwd = UnityEngine::Vector3::get_fwd(&v20, (MethodInfo *)type);
		        }
		        else
		        {
		          fwd = UnityEngine::Vector3::get_up(&v20, v8);
		        }
		        *(_QWORD *)&v19.x = *(_QWORD *)&fwd->x;
		      }
		      else
		      {
		        fwd = UnityEngine::Vector3::get_right(&v20, v6);
		        *(_QWORD *)&v19.x = *(_QWORD *)&fwd->x;
		      }
		      v19.z = fwd->z;
		      up = UnityEngine::Vector3::op_UnaryNegation(&v20, &v19, v12);
		      goto LABEL_21;
		    }
		    v9 = &v20;
		    goto LABEL_9;
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1642, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v15, v14);
		  up = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_665(&v20, Patch, this, 0LL);
		LABEL_21:
		  v16 = *(_QWORD *)&up->x;
		  z = up->z;
		  *(_QWORD *)&retstr->x = v16;
		  retstr->z = z;
		  return retstr;
		}
		
		public Vector2 GetPlaneSize(Vector3 size) => default; // 0x0000000189CF44C4-0x0000000189CF45C0
		// Vector2 GetPlaneSize(Vector3)
		Vector2 HG::Rendering::Runtime::HGSludgeAlignedPlane::GetPlaneSize(
		        HGSludgeAlignedPlane *this,
		        Vector3 *size,
		        MethodInfo *method)
		{
		  int32_t type; // ecx
		  int v6; // ecx
		  int v7; // ecx
		  int v8; // ecx
		  float v10; // eax
		  float v11; // eax
		  float v12; // eax
		  __int64 v13; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  float z; // eax
		  Vector3 v16; // [rsp+20h] [rbp-10h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1643, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1643, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v13);
		    z = size->z;
		    *(_QWORD *)&v16.x = *(_QWORD *)&size->x;
		    v16.z = z;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_666(Patch, this, &v16, 0LL);
		  }
		  else
		  {
		    type = this->type;
		    if ( type && (v6 = type - 1) != 0 )
		    {
		      v7 = v6 - 1;
		      if ( v7 && (v8 = v7 - 1) != 0 )
		      {
		        if ( (unsigned int)(v8 - 1) < 2 )
		        {
		          v10 = size->z;
		          *(_QWORD *)&v16.x = *(_QWORD *)&size->x;
		          v16.z = v10;
		          return HG::Rendering::Runtime::VectorSwizzleUtils::xy(&v16, 0LL);
		        }
		        else
		        {
		          return (Vector2)_mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		        }
		      }
		      else
		      {
		        v11 = size->z;
		        *(_QWORD *)&v16.x = *(_QWORD *)&size->x;
		        v16.z = v11;
		        return HG::Rendering::Runtime::VectorSwizzleUtils::xz(&v16, 0LL);
		      }
		    }
		    else
		    {
		      v12 = size->z;
		      *(_QWORD *)&v16.x = *(_QWORD *)&size->x;
		      v16.z = v12;
		      return HG::Rendering::Runtime::VectorSwizzleUtils::zy(&v16, 0LL);
		    }
		  }
		}
		
		public uint EncodeToUInt(Vector3 origin) => default; // 0x0000000189CF42AC-0x0000000189CF43B8
		// UInt32 EncodeToUInt(Vector3)
		uint32_t HG::Rendering::Runtime::HGSludgeAlignedPlane::EncodeToUInt(
		        HGSludgeAlignedPlane *this,
		        Vector3 *origin,
		        MethodInfo *method)
		{
		  MethodInfo *v5; // rdx
		  int32_t type; // ecx
		  float coeff; // xmm0_4
		  int v8; // ecx
		  int v9; // ecx
		  int v10; // ecx
		  float v12; // eax
		  HGSludgeAlignedPlane__StaticFields *static_fields; // rcx
		  __int64 v14; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  float z; // eax
		  Vector3 v17[2]; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1646, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1646, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v14);
		    z = origin->z;
		    *(_QWORD *)&v17[0].x = *(_QWORD *)&origin->x;
		    v17[0].z = z;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_667(Patch, this, v17, 0LL);
		  }
		  else if ( this->enabled )
		  {
		    type = this->type;
		    coeff = this->coeff;
		    if ( type && (v8 = type - 1) != 0 )
		    {
		      v9 = v8 - 1;
		      if ( v9 && (v10 = v9 - 1) != 0 )
		      {
		        if ( (unsigned int)(v10 - 1) <= 1 )
		          coeff = coeff - origin->z;
		      }
		      else
		      {
		        coeff = coeff - origin->y;
		      }
		    }
		    else
		    {
		      coeff = coeff - origin->x;
		    }
		    return ((((unsigned int)this->type >> 1) | (4 * (this->type & 1 | (2 * this->clipMode)))) << 16) | (unsigned __int16)Unity::Mathematics::math::f32tof16(-coeff, v5);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGSludgeAlignedPlane);
		    v12 = origin->z;
		    *(_QWORD *)&v17[0].x = *(_QWORD *)&origin->x;
		    static_fields = TypeInfo::HG::Rendering::Runtime::HGSludgeAlignedPlane->static_fields;
		    v17[0].z = v12;
		    return HG::Rendering::Runtime::HGSludgeAlignedPlane::EncodeToUInt(&static_fields->s_defaultPlane, v17, 0LL);
		  }
		}
		
	}
}
