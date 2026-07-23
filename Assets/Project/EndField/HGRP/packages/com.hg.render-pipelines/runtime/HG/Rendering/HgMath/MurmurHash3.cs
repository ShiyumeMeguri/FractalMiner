using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.HgMath
{
	public static class MurmurHash3 // TypeDefIndex: 37480
	{
		// Methods
		[IDTag(0)]
		public static uint MurmurHash3_32(byte[] bytes, uint seed = 0 /* Metadata: 0x02302DA3 */) => default; // 0x0000000189B3F324-0x0000000189B3F558
		// UInt32 MurmurHash3_32(Byte[], UInt32)
		uint32_t HG::Rendering::HgMath::MurmurHash3::MurmurHash3_32(Byte__Array *bytes, uint32_t seed, MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  int32_t size; // edi
		  int v8; // r15d
		  __int64 v9; // rdx
		  int v10; // ebp
		  int32_t v11; // r14d
		  __int64 v12; // rax
		  uint32_t v13; // eax
		  int v14; // edi
		  int v15; // edi
		  int v16; // edi
		  int v17; // r9d
		  int v18; // r9d
		  unsigned int v19; // ebp
		  int v20; // ecx
		  unsigned int v21; // ebp
		  unsigned int v22; // ebp
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(354, 0LL) )
		  {
		    if ( bytes )
		    {
		      size = bytes->max_length.size;
		      v8 = 0;
		      v9 = (unsigned int)(size >> 31);
		      LODWORD(v9) = size % 4;
		      v10 = size / 4;
		      if ( size / 4 > 0 )
		      {
		        v11 = 0;
		        while ( (unsigned int)v11 < bytes->max_length.size )
		        {
		          v6 = v11 + 1LL;
		          if ( (unsigned int)v6 >= bytes->max_length.size )
		            break;
		          v12 = v11 + 2LL;
		          if ( (unsigned int)v12 >= bytes->max_length.size )
		            break;
		          v9 = v11 + 3LL;
		          if ( (unsigned int)v9 >= bytes->max_length.size )
		            break;
		          v13 = HG::Rendering::HgMath::MurmurHash3::rotl32(
		                  -862048943
		                * (bytes->vector[v11] | ((bytes->vector[v6] | ((bytes->vector[v12] | (bytes->vector[v9] << 8)) << 8)) << 8)),
		                  0xFu,
		                  0LL);
		          ++v8;
		          v11 += 4;
		          seed = 5 * (HG::Rendering::HgMath::MurmurHash3::rotl32(seed ^ (461845907 * v13), 0xDu, 0LL) - 86135020);
		          if ( v8 >= v10 )
		            goto LABEL_10;
		        }
		LABEL_23:
		        sub_1800D2AB0(v6, v9);
		      }
		LABEL_10:
		      v14 = size & 3;
		      if ( !v14 )
		        return HG::Rendering::HgMath::MurmurHash3::fmix(bytes->max_length.size ^ seed, 0LL);
		      v15 = v14 - 1;
		      if ( !v15 )
		      {
		        v22 = 4 * v10;
		        if ( v22 >= bytes->max_length.size )
		          goto LABEL_23;
		        seed ^= 461845907 * HG::Rendering::HgMath::MurmurHash3::rotl32(-862048943 * bytes->vector[v22], 0xFu, 0LL);
		        return HG::Rendering::HgMath::MurmurHash3::fmix(bytes->max_length.size ^ seed, 0LL);
		      }
		      v16 = v15 - 1;
		      if ( v16 )
		      {
		        if ( v16 != 1 )
		          return HG::Rendering::HgMath::MurmurHash3::fmix(bytes->max_length.size ^ seed, 0LL);
		        v6 = 4 * v10 + 2LL;
		        if ( (unsigned int)v6 >= bytes->max_length.size )
		          goto LABEL_23;
		        v17 = bytes->vector[v6];
		        v6 = 4 * v10 + 1LL;
		        v18 = v17 << 16;
		        if ( (unsigned int)v6 >= bytes->max_length.size )
		          goto LABEL_23;
		        v19 = 4 * v10;
		        if ( v19 >= bytes->max_length.size )
		          goto LABEL_23;
		        v20 = v18 ^ (bytes->vector[v6] << 8) ^ bytes->vector[v19];
		      }
		      else
		      {
		        v6 = 4 * v10 + 1LL;
		        if ( (unsigned int)v6 >= bytes->max_length.size )
		          goto LABEL_23;
		        v9 = bytes->vector[v6] << 8;
		        v21 = 4 * v10;
		        if ( v21 >= bytes->max_length.size )
		          goto LABEL_23;
		        v20 = v9 ^ bytes->vector[v21];
		      }
		      seed ^= 461845907 * HG::Rendering::HgMath::MurmurHash3::rotl32(-862048943 * v20, 0xFu, 0LL);
		      return HG::Rendering::HgMath::MurmurHash3::fmix(bytes->max_length.size ^ seed, 0LL);
		    }
		LABEL_27:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(354, 0LL);
		  if ( !Patch )
		    goto LABEL_27;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_235(
		           (ILFixDynamicMethodWrapper_6 *)Patch,
		           (Object *)bytes,
		           (NaviDirection__Enum)seed,
		           0LL);
		}
		
		[IDTag(1)]
		public static uint MurmurHash3_32(string s, uint seed = 0 /* Metadata: 0x02302DA4 */) => default; // 0x0000000189B3F558-0x0000000189B3F5D8
		// UInt32 MurmurHash3_32(String, UInt32)
		uint32_t HG::Rendering::HgMath::MurmurHash3::MurmurHash3_32(String *s, uint32_t seed, MethodInfo *method)
		{
		  Encoding *UTF8; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Byte__Array *v8; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(357, 0LL) )
		  {
		    UTF8 = System::Text::Encoding::get_UTF8(0LL);
		    if ( UTF8 )
		    {
		      v8 = (Byte__Array *)sub_18006CE70(19LL, UTF8, s);
		      return HG::Rendering::HgMath::MurmurHash3::MurmurHash3_32(v8, seed, 0LL);
		    }
		LABEL_5:
		    sub_1800D8260(v7, v6);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(357, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_235(
		           (ILFixDynamicMethodWrapper_6 *)Patch,
		           (Object *)s,
		           (NaviDirection__Enum)seed,
		           0LL);
		}
		
		public static float MurmurHash3_32_Float(string name) => default; // 0x0000000189B3F2B4-0x0000000189B3F324
		// Single MurmurHash3_32_Float(String)
		float HG::Rendering::HgMath::MurmurHash3::MurmurHash3_32_Float(String *name, MethodInfo *method)
		{
		  float v3; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(358, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(358, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)name, 0LL);
		  }
		  else
		  {
		    v3 = COERCE_FLOAT(HG::Rendering::HgMath::MurmurHash3::MurmurHash3_32(name, 0, 0LL));
		    if ( (LODWORD(v3) & 0x7F800000) == 0 || (LODWORD(v3) & 0x7F800000) == 0x7F800000 )
		      LODWORD(v3) ^= 0x800000u;
		    return v3;
		  }
		}
		
		private static uint rotl32(uint x, byte r) => default; // 0x0000000189B3F640-0x0000000189B3F6AC
		// UInt32 rotl32(UInt32, Byte)
		uint32_t HG::Rendering::HgMath::MurmurHash3::rotl32(uint32_t x, uint8_t r, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(355, 0LL) )
		    return (x << (r & 0x1F)) | (x >> (-r & 0x1F));
		  Patch = IFix::WrappersManagerImpl::GetPatch(355, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v8, v7);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_166(Patch, x, r, 0LL);
		}
		
		private static uint fmix(uint h) => default; // 0x0000000189B3F5D8-0x0000000189B3F640
		// UInt32 fmix(UInt32)
		uint32_t HG::Rendering::HgMath::MurmurHash3::fmix(uint32_t h, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(356, 0LL) )
		    return (-1028477387 * ((-2048144789 * (h ^ HIWORD(h))) ^ ((-2048144789 * (h ^ HIWORD(h))) >> 13))) ^ ((-1028477387 * ((-2048144789 * (h ^ HIWORD(h))) ^ ((-2048144789 * (h ^ HIWORD(h))) >> 13))) >> 16);
		  Patch = IFix::WrappersManagerImpl::GetPatch(356, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_64((ILFixDynamicMethodWrapper_18 *)Patch, h, 0LL);
		}
		
	}
}
