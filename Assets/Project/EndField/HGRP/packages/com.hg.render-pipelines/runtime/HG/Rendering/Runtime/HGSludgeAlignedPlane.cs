using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
	public struct HGSludgeAlignedPlane
	{
		public Vector3 ApplyCoeff(Vector3 pos)
		{
			// // Vector3 ApplyCoeff(Vector3)
			// Vector3 *HG::Rendering::Runtime::HGSludgeAlignedPlane::ApplyCoeff(
			//         Vector3 *__return_ptr retstr,
			//         HGSludgeAlignedPlane *this,
			//         Vector3 *pos,
			//         MethodInfo *method)
			// {
			//   int32_t type; // r8d
			//   int v8; // r8d
			//   int v9; // r8d
			//   int v10; // r8d
			//   __int64 v11; // xmm0_8
			//   float v12; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v14; // rcx
			//   float z; // eax
			//   Vector3 *v16; // rax
			//   Vector3 v18; // [rsp+30h] [rbp-28h] BYREF
			//   Vector3 v19[2]; // [rsp+40h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1375, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1375, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v14, 0LL);
			//     z = pos.z;
			//     *(_QWORD *)&v18.x = *(_QWORD *)&pos.x;
			//     v18.z = z;
			//     v16 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_521(v19, Patch, this, &v18, 0LL);
			//     v11 = *(_QWORD *)&v16.x;
			//     v12 = v16.z;
			//   }
			//   else
			//   {
			//     type = this.type;
			//     if ( type && (v8 = type - 1) != 0 )
			//     {
			//       v9 = v8 - 1;
			//       if ( v9 && (v10 = v9 - 1) != 0 )
			//       {
			//         if ( (unsigned int)(v10 - 1) <= 1 )
			//           pos.z = this.coeff;
			//       }
			//       else
			//       {
			//         pos.y = this.coeff;
			//       }
			//     }
			//     else
			//     {
			//       pos.x = this.coeff;
			//     }
			//     v11 = *(_QWORD *)&pos.x;
			//     v12 = pos.z;
			//   }
			//   *(_QWORD *)&retstr.x = v11;
			//   retstr.z = v12;
			//   return retstr;
			// }
			// 
			return null;
		}

		public void SetCoeff(Vector3 pos)
		{
			// // Void SetCoeff(Vector3)
			// void HG::Rendering::Runtime::HGSludgeAlignedPlane::SetCoeff(
			//         HGSludgeAlignedPlane *this,
			//         Vector3 *pos,
			//         MethodInfo *method)
			// {
			//   int32_t type; // r8d
			//   int v6; // r8d
			//   int v7; // r8d
			//   int v8; // r8d
			//   float y; // eax
			//   __int64 v10; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   float z; // eax
			//   Vector3 v13; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1376, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1376, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v10);
			//     z = pos.z;
			//     *(_QWORD *)&v13.x = *(_QWORD *)&pos.x;
			//     v13.z = z;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_522(Patch, this, &v13, 0LL);
			//   }
			//   else
			//   {
			//     type = this.type;
			//     if ( type && (v6 = type - 1) != 0 )
			//     {
			//       v7 = v6 - 1;
			//       if ( v7 && (v8 = v7 - 1) != 0 )
			//       {
			//         if ( (unsigned int)(v8 - 1) > 1 )
			//           return;
			//         y = pos.z;
			//       }
			//       else
			//       {
			//         y = pos.y;
			//       }
			//     }
			//     else
			//     {
			//       y = pos.x;
			//     }
			//     this.coeff = y;
			//   }
			// }
			// 
		}

		public Vector3 GetPlaneNormal()
		{
			// // Vector3 GetPlaneNormal()
			// Vector3 *HG::Rendering::Runtime::HGSludgeAlignedPlane::GetPlaneNormal(
			//         Vector3 *__return_ptr retstr,
			//         HGSludgeAlignedPlane *this,
			//         MethodInfo *method)
			// {
			//   unsigned __int64 type; // rdx
			//   MethodInfo *v6; // rdx
			//   MethodInfo *v7; // rdx
			//   MethodInfo *v8; // rdx
			//   Vector3 *v9; // rcx
			//   Vector3 *up; // rax
			//   Vector3 *fwd; // rax
			//   MethodInfo *v12; // r8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v14; // rdx
			//   __int64 v15; // rcx
			//   __int64 v16; // xmm0_8
			//   float z; // eax
			//   Vector3 v19; // [rsp+20h] [rbp-20h] BYREF
			//   Vector3 v20; // [rsp+30h] [rbp-10h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1377, 0LL) )
			//   {
			//     type = (unsigned int)this.type;
			//     if ( (_DWORD)type )
			//     {
			//       v6 = (MethodInfo *)(unsigned int)(type - 1);
			//       if ( (_DWORD)v6 )
			//       {
			//         v7 = (MethodInfo *)(unsigned int)((_DWORD)v6 - 1);
			//         if ( !(_DWORD)v7 )
			//         {
			//           up = UnityEngine::Vector3::get_up(&v20, v7);
			//           goto LABEL_21;
			//         }
			//         v8 = (MethodInfo *)(unsigned int)((_DWORD)v7 - 1);
			//         if ( (_DWORD)v8 )
			//         {
			//           type = (unsigned int)((_DWORD)v8 - 1);
			//           if ( !(_DWORD)type )
			//           {
			//             up = UnityEngine::Vector3::get_fwd(&v20, (MethodInfo *)type);
			//             goto LABEL_21;
			//           }
			//           if ( (_DWORD)type != 1 )
			//           {
			//             v9 = &v19;
			// LABEL_9:
			//             up = UnityEngine::Vector3::get_right(v9, (MethodInfo *)type);
			//             goto LABEL_21;
			//           }
			//           fwd = UnityEngine::Vector3::get_fwd(&v20, (MethodInfo *)type);
			//         }
			//         else
			//         {
			//           fwd = UnityEngine::Vector3::get_up(&v20, v8);
			//         }
			//         *(_QWORD *)&v19.x = *(_QWORD *)&fwd.x;
			//       }
			//       else
			//       {
			//         fwd = UnityEngine::Vector3::get_right(&v20, v6);
			//         *(_QWORD *)&v19.x = *(_QWORD *)&fwd.x;
			//       }
			//       v19.z = fwd.z;
			//       up = UnityEngine::Vector3::op_UnaryNegation(&v20, &v19, v12);
			//       goto LABEL_21;
			//     }
			//     v9 = &v20;
			//     goto LABEL_9;
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1377, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v15, v14);
			//   up = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_523(&v20, Patch, this, 0LL);
			// LABEL_21:
			//   v16 = *(_QWORD *)&up.x;
			//   z = up.z;
			//   *(_QWORD *)&retstr.x = v16;
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public Vector2 GetPlaneSize(Vector3 size)
		{
			// // Vector2 GetPlaneSize(Vector3)
			// Vector2 HG::Rendering::Runtime::HGSludgeAlignedPlane::GetPlaneSize(
			//         HGSludgeAlignedPlane *this,
			//         Vector3 *size,
			//         MethodInfo *method)
			// {
			//   int32_t type; // ecx
			//   int v6; // ecx
			//   int v7; // ecx
			//   int v8; // ecx
			//   float v10; // eax
			//   float v11; // eax
			//   float v12; // eax
			//   __int64 v13; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   float z; // eax
			//   Vector3 v16; // [rsp+20h] [rbp-10h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1378, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1378, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v13);
			//     z = size.z;
			//     *(_QWORD *)&v16.x = *(_QWORD *)&size.x;
			//     v16.z = z;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_524(Patch, this, &v16, 0LL);
			//   }
			//   else
			//   {
			//     type = this.type;
			//     if ( type && (v6 = type - 1) != 0 )
			//     {
			//       v7 = v6 - 1;
			//       if ( v7 && (v8 = v7 - 1) != 0 )
			//       {
			//         if ( (unsigned int)(v8 - 1) < 2 )
			//         {
			//           v10 = size.z;
			//           *(_QWORD *)&v16.x = *(_QWORD *)&size.x;
			//           v16.z = v10;
			//           return HG::Rendering::Runtime::VectorSwizzleUtils::xy(&v16, 0LL);
			//         }
			//         else
			//         {
			//           return (Vector2)_mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//         }
			//       }
			//       else
			//       {
			//         v11 = size.z;
			//         *(_QWORD *)&v16.x = *(_QWORD *)&size.x;
			//         v16.z = v11;
			//         return HG::Rendering::Runtime::VectorSwizzleUtils::xz(&v16, 0LL);
			//       }
			//     }
			//     else
			//     {
			//       v12 = size.z;
			//       *(_QWORD *)&v16.x = *(_QWORD *)&size.x;
			//       v16.z = v12;
			//       return HG::Rendering::Runtime::VectorSwizzleUtils::zy(&v16, 0LL);
			//     }
			//   }
			// }
			// 
			return null;
		}

		public uint EncodeToUInt(Vector3 origin)
		{
			// // UInt32 EncodeToUInt(Vector3)
			// uint32_t HG::Rendering::Runtime::HGSludgeAlignedPlane::EncodeToUInt(
			//         HGSludgeAlignedPlane *this,
			//         Vector3 *origin,
			//         MethodInfo *method)
			// {
			//   float v3; // xmm1_4
			//   unsigned __int64 type; // rcx
			//   float v8; // eax
			//   HGSludgeAlignedPlane__StaticFields *static_fields; // rcx
			//   __int64 v10; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   float z; // eax
			//   Vector3 v13[2]; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919DBF )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGSludgeAlignedPlane);
			//     byte_18D919DBF = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1381, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1381, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v10);
			//     z = origin.z;
			//     *(_QWORD *)&v13[0].x = *(_QWORD *)&origin.x;
			//     v13[0].z = z;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_525(Patch, this, v13, 0LL);
			//   }
			//   else if ( this.enabled )
			//   {
			//     type = (unsigned int)this.type;
			//     if ( (_DWORD)type )
			//     {
			//       type = (unsigned int)(type - 1);
			//       if ( (_DWORD)type )
			//       {
			//         type = (unsigned int)(type - 1);
			//         if ( (_DWORD)type )
			//         {
			//           type = (unsigned int)(type - 1);
			//           if ( (_DWORD)type )
			//             type = (unsigned int)(type - 1);
			//         }
			//       }
			//     }
			//     return ((((unsigned int)this.type >> 1) | (4 * (this.type & 1 | (2 * this.clipMode)))) << 16) | (unsigned __int16)Unity::Mathematics::math::half((Unity::Mathematics::math *)type, v3);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGSludgeAlignedPlane);
			//     v8 = origin.z;
			//     *(_QWORD *)&v13[0].x = *(_QWORD *)&origin.x;
			//     static_fields = TypeInfo::HG::Rendering::Runtime::HGSludgeAlignedPlane.static_fields;
			//     v13[0].z = v8;
			//     return HG::Rendering::Runtime::HGSludgeAlignedPlane::EncodeToUInt(&static_fields.s_defaultPlane, v13, 0LL);
			//   }
			// }
			// 
			return 0U;
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static HGSludgeAlignedPlane s_defaultPlane;

		public bool enabled;

		public HGSludgeAlignedPlaneType type;

		public HGSludgePlaneClipMode clipMode;

		public float coeff;
	}
}
