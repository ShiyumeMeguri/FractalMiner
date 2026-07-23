using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public static class HGShadowConstantBufferUtils // TypeDefIndex: 37883
	{
		// Fields
		private const int MAX_CASCADE_COUNT = 4; // Metadata: 0x02303196
		private const int MAX_PUNCTUAL_LIGHT_SHADOW_CASTER_COUNT = 56; // Metadata: 0x02303197
		private const int MAX_CHARACTER_SHADOWMAP_COUNT = 15; // Metadata: 0x02303198
		private const int ASM_TILE_COUNT = 256; // Metadata: 0x02303199
		private const int FLOAT_COUNT_IN_MATRIX = 16; // Metadata: 0x0230319B
		private const int FLOAT_COUNT_IN_VECTOR = 4; // Metadata: 0x0230319C
		public static HGShadowConstantBufferData shadowData; // 0x00
		private static CBHandle s_shadowBufferHandle; // 0x2CB0
		private static int _CSMSectionOffset; // 0x2CC8
		private static int _PunctualLightShadowSectionOffset; // 0x2CCC
		private static int _CharacterShadowSectionOffset; // 0x2CD0
		private static int _ASMSectionOffset; // 0x2CD4
	
		// Properties
		public static CBHandle ShadowBufferHandle { get; } // 0x0000000189B4FF88-0x0000000189B5000C 
		// CBHandle get_ShadowBufferHandle()
		CBHandle *HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_ShadowBufferHandle(
		        CBHandle *__return_ptr retstr,
		        MethodInfo *method)
		{
		  HGShadowConstantBufferUtils__StaticFields *static_fields; // rcx
		  Vector4 CSMShadowTexelSize; // xmm0
		  void *ptr; // xmm1_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  CBHandle *v9; // rax
		  CBHandle *result; // rax
		  CBHandle v11; // [rsp+20h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2199, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2199, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_886(&v11, Patch, 0LL);
		    CSMShadowTexelSize = *(Vector4 *)&v9->bufferId;
		    ptr = v9->ptr;
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
		    static_fields = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields;
		    CSMShadowTexelSize = static_fields[28].shadowData._CSMShadowTexelSize;
		    ptr = *(void **)&static_fields[28].shadowData._CSMPenumbraSizes.x;
		  }
		  *(Vector4 *)&retstr->bufferId = CSMShadowTexelSize;
		  result = retstr;
		  retstr->ptr = ptr;
		  return result;
		}
		
		public static uint shadowBufferID { get; } // 0x0000000189B5053C-0x0000000189B5059C 
		// UInt32 get_shadowBufferID()
		uint32_t HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_shadowBufferID(MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2202, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2202, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v4, v3);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
		    return LODWORD(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields[28].shadowData._CSMShadowTexelSize.x);
		  }
		}
		
		public static int shadowBufferOffset { get; } // 0x0000000189B5059C-0x0000000189B505FC 
		// Int32 get_shadowBufferOffset()
		int32_t HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_shadowBufferOffset(MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2203, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2203, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v4, v3);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
		    return LODWORD(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields[28].shadowData._CSMShadowTexelSize.y);
		  }
		}
		
		public static int csmSectionOffset { get; } // 0x0000000189B502A4-0x0000000189B5038C 
		// Int32 get_csmSectionOffset()
		int32_t HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_csmSectionOffset(MethodInfo *method)
		{
		  struct HGShadowConstantBufferUtils__Class *v1; // rcx
		  struct Il2CppType *v2; // rbx
		  Type *TypeFromHandle; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2204, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2204, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
		    v1 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils;
		    if ( LODWORD(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields[28].shadowData._CSMPenumbraSizes.z) == -1 )
		    {
		      v2 = TypeRef::HG::Rendering::Runtime::HGShadowConstantBufferUtils::HGShadowConstantBufferData;
		      sub_1800036A0(TypeInfo::System::Type);
		      TypeFromHandle = System::Type::GetTypeFromHandle((RuntimeTypeHandle)v2, 0LL);
		      sub_1800036A0(TypeInfo::System::Runtime::InteropServices::Marshal);
		      LODWORD(TypeFromHandle) = System::Runtime::InteropServices::Marshal::OffsetOf(TypeFromHandle, "_CSMWorldToShadow");
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
		      LODWORD(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields[28].shadowData._CSMPenumbraSizes.z) = (_DWORD)TypeFromHandle;
		      v1 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils;
		    }
		    sub_1800036A0(v1);
		    return LODWORD(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields[28].shadowData._CSMPenumbraSizes.z);
		  }
		}
		
		public static int punctualLightShadowSectionOffset { get; } // 0x0000000189B503F0-0x0000000189B504D8 
		// Int32 get_punctualLightShadowSectionOffset()
		int32_t HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_punctualLightShadowSectionOffset(MethodInfo *method)
		{
		  struct HGShadowConstantBufferUtils__Class *v1; // rcx
		  struct Il2CppType *v2; // rbx
		  Type *TypeFromHandle; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2205, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2205, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
		    v1 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils;
		    if ( LODWORD(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields[28].shadowData._CSMPenumbraSizes.w) == -1 )
		    {
		      v2 = TypeRef::HG::Rendering::Runtime::HGShadowConstantBufferUtils::HGShadowConstantBufferData;
		      sub_1800036A0(TypeInfo::System::Type);
		      TypeFromHandle = System::Type::GetTypeFromHandle((RuntimeTypeHandle)v2, 0LL);
		      sub_1800036A0(TypeInfo::System::Runtime::InteropServices::Marshal);
		      LODWORD(TypeFromHandle) = System::Runtime::InteropServices::Marshal::OffsetOf(
		                                  TypeFromHandle,
		                                  "_PunctualLightWorldToShadow");
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
		      LODWORD(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields[28].shadowData._CSMPenumbraSizes.w) = (_DWORD)TypeFromHandle;
		      v1 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils;
		    }
		    sub_1800036A0(v1);
		    return LODWORD(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields[28].shadowData._CSMPenumbraSizes.w);
		  }
		}
		
		public static int characterShadowSectionOffset { get; } // 0x0000000189B50158-0x0000000189B50240 
		// Int32 get_characterShadowSectionOffset()
		int32_t HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_characterShadowSectionOffset(MethodInfo *method)
		{
		  struct HGShadowConstantBufferUtils__Class *v1; // rcx
		  struct Il2CppType *v2; // rbx
		  Type *TypeFromHandle; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2206, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2206, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
		    v1 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils;
		    if ( LODWORD(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields[28].shadowData._DirectionalShadowParams.x) == -1 )
		    {
		      v2 = TypeRef::HG::Rendering::Runtime::HGShadowConstantBufferUtils::HGShadowConstantBufferData;
		      sub_1800036A0(TypeInfo::System::Type);
		      TypeFromHandle = System::Type::GetTypeFromHandle((RuntimeTypeHandle)v2, 0LL);
		      sub_1800036A0(TypeInfo::System::Runtime::InteropServices::Marshal);
		      LODWORD(TypeFromHandle) = System::Runtime::InteropServices::Marshal::OffsetOf(
		                                  TypeFromHandle,
		                                  "_CharacterWorldToShadow");
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
		      LODWORD(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields[28].shadowData._DirectionalShadowParams.x) = (_DWORD)TypeFromHandle;
		      v1 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils;
		    }
		    sub_1800036A0(v1);
		    return LODWORD(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields[28].shadowData._DirectionalShadowParams.x);
		  }
		}
		
		public static int asmShadowSectionOffset { get; } // 0x0000000189B50070-0x0000000189B50158 
		// Int32 get_asmShadowSectionOffset()
		int32_t HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_asmShadowSectionOffset(MethodInfo *method)
		{
		  struct HGShadowConstantBufferUtils__Class *v1; // rcx
		  struct Il2CppType *v2; // rbx
		  Type *TypeFromHandle; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2207, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2207, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
		    v1 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils;
		    if ( LODWORD(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields[28].shadowData._DirectionalShadowParams.y) == -1 )
		    {
		      v2 = TypeRef::HG::Rendering::Runtime::HGShadowConstantBufferUtils::HGShadowConstantBufferData;
		      sub_1800036A0(TypeInfo::System::Type);
		      TypeFromHandle = System::Type::GetTypeFromHandle((RuntimeTypeHandle)v2, 0LL);
		      sub_1800036A0(TypeInfo::System::Runtime::InteropServices::Marshal);
		      LODWORD(TypeFromHandle) = System::Runtime::InteropServices::Marshal::OffsetOf(
		                                  TypeFromHandle,
		                                  "_ASMWorldToShadowBaseMatrix");
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
		      LODWORD(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields[28].shadowData._DirectionalShadowParams.y) = (_DWORD)TypeFromHandle;
		      v1 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils;
		    }
		    sub_1800036A0(v1);
		    return LODWORD(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields[28].shadowData._DirectionalShadowParams.y);
		  }
		}
		
		public static int shadowDataSize { get; } // 0x0000000189B505FC-0x0000000189B50670 
		// Int32 get_shadowDataSize()
		int32_t HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_shadowDataSize(MethodInfo *method)
		{
		  struct Il2CppType *v1; // rbx
		  Type *TypeFromHandle; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2201, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2201, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		  }
		  else
		  {
		    v1 = TypeRef::HG::Rendering::Runtime::HGShadowConstantBufferUtils::HGShadowConstantBufferData;
		    sub_1800036A0(TypeInfo::System::Type);
		    TypeFromHandle = System::Type::GetTypeFromHandle((RuntimeTypeHandle)v1, 0LL);
		    sub_1800036A0(TypeInfo::System::Runtime::InteropServices::Marshal);
		    return System::Runtime::InteropServices::Marshal::SizeOf(TypeFromHandle);
		  }
		}
		
		public static int csmSectionSize { get; } // 0x0000000189B5038C-0x0000000189B503F0 
		// Int32 get_csmSectionSize()
		int32_t HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_csmSectionSize(MethodInfo *method)
		{
		  int32_t punctualLightShadowSectionOffset; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2208, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2208, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
		    punctualLightShadowSectionOffset = HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_punctualLightShadowSectionOffset(0LL);
		    return punctualLightShadowSectionOffset
		         - HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_csmSectionOffset(0LL);
		  }
		}
		
		public static int punctualLightShadowSectionSize { get; } // 0x0000000189B504D8-0x0000000189B5053C 
		// Int32 get_punctualLightShadowSectionSize()
		int32_t HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_punctualLightShadowSectionSize(MethodInfo *method)
		{
		  int32_t characterShadowSectionOffset; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2209, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2209, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
		    characterShadowSectionOffset = HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_characterShadowSectionOffset(0LL);
		    return characterShadowSectionOffset
		         - HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_punctualLightShadowSectionOffset(0LL);
		  }
		}
		
		public static int characterShadowSectionSize { get; } // 0x0000000189B50240-0x0000000189B502A4 
		// Int32 get_characterShadowSectionSize()
		int32_t HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_characterShadowSectionSize(MethodInfo *method)
		{
		  int32_t asmShadowSectionOffset; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2210, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2210, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
		    asmShadowSectionOffset = HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_asmShadowSectionOffset(0LL);
		    return asmShadowSectionOffset
		         - HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_characterShadowSectionOffset(0LL);
		  }
		}
		
		public static int asmSectionSize { get; } // 0x0000000189B5000C-0x0000000189B50070 
		// Int32 get_asmSectionSize()
		int32_t HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_asmSectionSize(MethodInfo *method)
		{
		  int32_t shadowDataSize; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2211, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2211, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
		    shadowDataSize = HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_shadowDataSize(0LL);
		    return shadowDataSize - HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_asmShadowSectionOffset(0LL);
		  }
		}
		
	
		// Nested types
		public enum ShadowConstantBufferSection // TypeDefIndex: 37866
		{
			CSM = 0,
			PunctualLight = 1,
			Character = 2,
			ASM = 3
		}
	
		public struct HGShadowConstantBufferData // TypeDefIndex: 37882
		{
			// Fields
			public unsafe fixed /* 0x00000000-0x00000000 */ float _CSMWorldToShadow[0]; // 0x00
			public unsafe fixed /* 0x00000000-0x00000000 */ float _CSMShadowSplitSpheres[0]; // 0x140
			public unsafe fixed /* 0x00000000-0x00000000 */ float _CSMShadowBiases[0]; // 0x180
			public unsafe fixed /* 0x00000000-0x00000000 */ float _CSMShadowAtlasParams[0]; // 0x1C0
			public Vector4 _CSMShadowTexelSize; // 0x200
			public Vector4 _CSMPenumbraSizes; // 0x210
			public Vector4 _DirectionalShadowParams; // 0x220
			public Vector4 _DirectionalShadowParams2; // 0x230
			public Vector4 _CSMRhodesParams; // 0x240
			public unsafe fixed /* 0x00000000-0x00000000 */ float _Paddings0[0]; // 0x250
			public unsafe fixed /* 0x00000000-0x00000000 */ float _PunctualLightWorldToShadow[0]; // 0x400
			public unsafe fixed /* 0x00000000-0x00000000 */ float _PunctualLightShadowParams[0]; // 0x1200
			public unsafe fixed /* 0x00000000-0x00000000 */ float _PunctualLightShadowParams2[0]; // 0x1580
			public Vector4 _PunctualLightShadowTexelSize; // 0x1900
			public unsafe fixed /* 0x00000000-0x00000000 */ float _Paddings1[0]; // 0x1910
			public unsafe fixed /* 0x00000000-0x00000000 */ float _CharacterWorldToShadow[0]; // 0x1C00
			public unsafe fixed /* 0x00000000-0x00000000 */ float _CharacterShadowBiases[0]; // 0x1FC0
			public unsafe fixed /* 0x00000000-0x00000000 */ float _CharacterShadowLightDir[0]; // 0x20B0
			public unsafe fixed /* 0x00000000-0x00000000 */ float _CharacterShadowAtlasParams[0]; // 0x21A0
			public Vector4 _CharacterShadowTexelSize; // 0x2290
			public Vector4 _CharacterShadowParams; // 0x22A0
			public unsafe fixed /* 0x00000000-0x00000000 */ float _Paddings2[0]; // 0x22B0
			public Matrix4x4 _ASMWorldToShadowBaseMatrix; // 0x2400
			public Matrix4x4 _ASMIndirectWorldToShadow; // 0x2440
			public Vector4 _ASMParams; // 0x2480
			public Vector4 _ASMParams2; // 0x2490
			public Vector4 _ASMShadowTexelSize; // 0x24A0
			public unsafe fixed /* 0x00000000-0x00000000 */ float _ASMIndirectParams[0]; // 0x24B0
		}
	
		// Constructors
		static HGShadowConstantBufferUtils() {} // 0x0000000184DA13D0-0x0000000184DA1460
		// HGShadowConstantBufferUtils()
		void HG::Rendering::Runtime::HGShadowConstantBufferUtils::cctor(MethodInfo *method)
		{
		  sub_18033B9D0(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields, 0LL, 11440LL);
		  TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields[28].shadowData._CSMPenumbraSizes.z = NAN;
		  TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields[28].shadowData._CSMPenumbraSizes.w = NAN;
		  TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields[28].shadowData._DirectionalShadowParams.x = NAN;
		  TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields[28].shadowData._DirectionalShadowParams.y = NAN;
		}
		
	
		// Methods
		public static void AllocateShadowBuffer(ScriptableRenderContext srpContext) {} // 0x0000000189B4FC04-0x0000000189B4FCA8
		// Void AllocateShadowBuffer(ScriptableRenderContext)
		void HG::Rendering::Runtime::HGShadowConstantBufferUtils::AllocateShadowBuffer(
		        ScriptableRenderContext srpContext,
		        MethodInfo *method)
		{
		  int32_t shadowDataSize; // ebx
		  CBHandle *v3; // rax
		  void *ptr; // xmm0_8
		  HGShadowConstantBufferUtils__StaticFields *static_fields; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  CBHandle v9; // [rsp+20h] [rbp-28h] BYREF
		  ScriptableRenderContext P0; // [rsp+50h] [rbp+8h] BYREF
		
		  P0.m_Ptr = srpContext.m_Ptr;
		  if ( IFix::WrappersManagerImpl::IsPatched(2200, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2200, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_887(Patch, P0, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
		    shadowDataSize = HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_shadowDataSize(0LL);
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		    v3 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(&v9, &P0, shadowDataSize, 0LL);
		    ptr = v3->ptr;
		    static_fields = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields;
		    static_fields[28].shadowData._CSMShadowTexelSize = *(Vector4 *)&v3->bufferId;
		    *(_QWORD *)&static_fields[28].shadowData._CSMPenumbraSizes.x = ptr;
		  }
		}
		
		public static void SetGlobalConstantBuffer(ShadowConstantBufferSection section, CommandBuffer cmd) {} // 0x0000000189B4FCA8-0x0000000189B4FDE0
		// Void SetGlobalConstantBuffer(HGShadowConstantBufferUtils+ShadowConstantBufferSection, CommandBuffer)
		void HG::Rendering::Runtime::HGShadowConstantBufferUtils::SetGlobalConstantBuffer(
		        HGShadowConstantBufferUtils_ShadowConstantBufferSection__Enum section,
		        CommandBuffer *cmd,
		        MethodInfo *method)
		{
		  int32_t asmShadowSectionOffset; // edi
		  unsigned __int32 v6; // ebx
		  unsigned __int32 v7; // ebx
		  int32_t v8; // ebx
		  int32_t asmSectionSize; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		
		  asmShadowSectionOffset = 0;
		  if ( !IFix::WrappersManagerImpl::IsPatched(2212, 0LL) )
		  {
		    if ( section )
		    {
		      v6 = section - 1;
		      if ( v6 )
		      {
		        v7 = v6 - 1;
		        if ( v7 )
		        {
		          if ( v7 != 1 )
		          {
		            v8 = 0;
		LABEL_12:
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
		            Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(
		              (Void *)(*(_QWORD *)&TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields[28].shadowData._CSMPenumbraSizes.x
		                     + asmShadowSectionOffset),
		              (Void *)TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields
		            + asmShadowSectionOffset,
		              v8,
		              0LL);
		            HG::Rendering::Runtime::HGShadowConstantBufferUtils::SetGlobalShadowCB(cmd, 0LL);
		            return;
		          }
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
		          asmShadowSectionOffset = HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_asmShadowSectionOffset(0LL);
		          asmSectionSize = HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_asmSectionSize(0LL);
		        }
		        else
		        {
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
		          asmShadowSectionOffset = HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_characterShadowSectionOffset(0LL);
		          asmSectionSize = HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_characterShadowSectionSize(0LL);
		        }
		      }
		      else
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
		        asmShadowSectionOffset = HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_punctualLightShadowSectionOffset(0LL);
		        asmSectionSize = HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_punctualLightShadowSectionSize(0LL);
		      }
		    }
		    else
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
		      asmShadowSectionOffset = HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_csmSectionOffset(0LL);
		      asmSectionSize = HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_csmSectionSize(0LL);
		    }
		    v8 = asmSectionSize;
		    goto LABEL_12;
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2212, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v12, v11);
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_37(
		    (ILFixDynamicMethodWrapper_18 *)Patch,
		    section,
		    (UIMultiSelectDropdown *)cmd,
		    0LL);
		}
		
		public static void SetGlobalShadowCB(CommandBuffer cmd) {} // 0x0000000189B4FEC0-0x0000000189B4FF88
		// Void SetGlobalShadowCB(CommandBuffer)
		void HG::Rendering::Runtime::HGShadowConstantBufferUtils::SetGlobalShadowCB(CommandBuffer *cmd, MethodInfo *method)
		{
		  uint32_t shadowBufferID; // edi
		  int32_t ShadowData; // esi
		  int32_t shadowBufferOffset; // ebp
		  int32_t size; // eax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2213, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
		    shadowBufferID = HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_shadowBufferID(0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		    ShadowData = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->ShadowData;
		    shadowBufferOffset = HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_shadowBufferOffset(0LL);
		    size = HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_shadowDataSize(0LL);
		    if ( cmd )
		    {
		      UnityEngine::Rendering::CommandBuffer::SetGlobalConstantBufferInternal0(
		        cmd,
		        shadowBufferID,
		        ShadowData,
		        shadowBufferOffset,
		        size,
		        0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v8, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2213, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)cmd, 0LL);
		}
		
		public static void SetGlobalShadowCBForComputeShader(CommandBuffer cmd, ComputeShader cs) {} // 0x0000000189B4FDE0-0x0000000189B4FEC0
		// Void SetGlobalShadowCBForComputeShader(CommandBuffer, ComputeShader)
		void HG::Rendering::Runtime::HGShadowConstantBufferUtils::SetGlobalShadowCBForComputeShader(
		        CommandBuffer *cmd,
		        ComputeShader *cs,
		        MethodInfo *method)
		{
		  int32_t ShadowData; // esi
		  uint32_t shadowBufferID; // ebp
		  int32_t offset; // r14d
		  int32_t size; // eax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2214, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		    ShadowData = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->ShadowData;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
		    shadowBufferID = HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_shadowBufferID(0LL);
		    offset = HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_shadowBufferOffset(0LL);
		    size = HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_shadowDataSize(0LL);
		    if ( cmd )
		    {
		      UnityEngine::Rendering::CommandBuffer::Internal_SetComputeConstantBufferParam(
		        cmd,
		        cs,
		        ShadowData,
		        shadowBufferID,
		        offset,
		        size,
		        0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v10, v9);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2214, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)cmd, (Object *)cs, 0LL);
		}
		
	}
}
