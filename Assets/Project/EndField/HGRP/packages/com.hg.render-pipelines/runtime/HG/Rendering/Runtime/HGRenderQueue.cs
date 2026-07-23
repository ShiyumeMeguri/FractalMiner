using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal static class HGRenderQueue // TypeDefIndex: 38163
	{
		// Fields
		private const int k_TransparentPriorityQueueRangeStep = 100; // Metadata: 0x02303A8A
		public const int k_TransparentAfterDistortionPriorityQueueRangeStep = 40; // Metadata: 0x02303A8C
		public static readonly RenderQueueRange k_RenderQueue_OpaqueNoAlphaTest; // 0x00
		public static readonly RenderQueueRange k_RenderQueue_OpaqueAlphaTest; // 0x08
		public static readonly RenderQueueRange k_RenderQueue_OpaqueDecalAndAlphaTest; // 0x10
		public static readonly RenderQueueRange k_RenderQueue_AllOpaque; // 0x18
		public static readonly RenderQueueRange k_RenderQueue_AfterPostProcessOpaque; // 0x20
		public static readonly RenderQueueRange k_RenderQueue_PreRefraction; // 0x28
		public static readonly RenderQueueRange k_RenderQueue_Transparent; // 0x30
		public static readonly RenderQueueRange k_RenderQueue_TransparentWithLowRes; // 0x38
		public static readonly RenderQueueRange k_RenderQueue_LowTransparent; // 0x40
		public static readonly RenderQueueRange k_RenderQueue_AllTransparent; // 0x48
		public static readonly RenderQueueRange k_RenderQueue_AllTransparentWithLowRes; // 0x50
		public static readonly RenderQueueRange k_RenderQueue_AfterDistortionBeforePostprocessTransparent; // 0x58
		public static readonly RenderQueueRange k_RenderQueue_AfterDistortionTransparent; // 0x60
		public static readonly RenderQueueRange k_RenderQueue_AfterPostProcessTransparent; // 0x68
		public static readonly RenderQueueRange k_RenderQueue_All; // 0x70
		public const int sortingPriorityRange = 50; // Metadata: 0x02303A8D
		public const int meshDecalPriorityRange = 50; // Metadata: 0x02303A8E
	
		// Nested types
		public enum Priority // TypeDefIndex: 38161
		{
			Background = 1000,
			Opaque = 2000,
			OpaqueDecal = 2225,
			OpaqueAlphaTest = 2450,
			OpaqueDecalAlphaTest = 2475,
			OpaqueLast = 2500,
			AfterPostprocessOpaque = 2501,
			AfterPostprocessOpaqueAlphaTest = 2510,
			PreRefractionFirst = 2650,
			PreRefraction = 2750,
			PreRefractionLast = 2850,
			TransparentFirst = 2900,
			Transparent = 3000,
			TransparentLast = 3100,
			LowTransparentFirst = 3200,
			LowTransparent = 3300,
			LowTransparentLast = 3400,
			AfterDistortionBeforePostprocessTransparentFirst = 3460,
			AfterDistortionBeforePostprocessTransparent = 3500,
			AfterDistortionBeforePostprocessTransparentLast = 3540,
			AfterDistortionTransparentFirst = 3560,
			AfterDistortionTransparent = 3600,
			AfterDistortionTransparentLast = 3640,
			AfterPostprocessTransparentFirst = 3660,
			AfterPostprocessTransparent = 3700,
			AfterPostprocessTransparentLast = 3740,
			Overlay = 4000
		}
	
		public enum RenderQueueType // TypeDefIndex: 38162
		{
			Background = 0,
			Opaque = 1,
			AfterPostProcessOpaque = 2,
			PreRefraction = 3,
			Transparent = 4,
			LowTransparent = 5,
			AfterDistortionBeforePostprocessTransparent = 6,
			AfterDistortionTransparent = 7,
			AfterPostprocessTransparent = 8,
			Overlay = 9,
			Unknown = 10
		}
	
		// Constructors
		static HGRenderQueue() {} // 0x0000000189B89D50-0x0000000189B89F7C
		// HGRenderQueue()
		void HG::Rendering::Runtime::HGRenderQueue::cctor(MethodInfo *method)
		{
		  sub_1800036A0(TypeInfo::UnityEngine::Rendering::RenderQueueRange);
		  TypeInfo::HG::Rendering::Runtime::HGRenderQueue->static_fields->k_RenderQueue_OpaqueNoAlphaTest = (RenderQueueRange)0x991000003E8LL;
		  TypeInfo::HG::Rendering::Runtime::HGRenderQueue->static_fields->k_RenderQueue_OpaqueAlphaTest = (RenderQueueRange)0x9C400000992LL;
		  TypeInfo::HG::Rendering::Runtime::HGRenderQueue->static_fields->k_RenderQueue_OpaqueDecalAndAlphaTest = (RenderQueueRange)0x9C4000008B1LL;
		  TypeInfo::HG::Rendering::Runtime::HGRenderQueue->static_fields->k_RenderQueue_AllOpaque = (RenderQueueRange)0x9C4000003E8LL;
		  TypeInfo::HG::Rendering::Runtime::HGRenderQueue->static_fields->k_RenderQueue_AfterPostProcessOpaque = (RenderQueueRange)0x9CE000009C5LL;
		  TypeInfo::HG::Rendering::Runtime::HGRenderQueue->static_fields->k_RenderQueue_PreRefraction = (RenderQueueRange)0xB2200000A5ALL;
		  TypeInfo::HG::Rendering::Runtime::HGRenderQueue->static_fields->k_RenderQueue_Transparent = (RenderQueueRange)0xC1C00000B54LL;
		  TypeInfo::HG::Rendering::Runtime::HGRenderQueue->static_fields->k_RenderQueue_TransparentWithLowRes = (RenderQueueRange)0xD4800000B54LL;
		  TypeInfo::HG::Rendering::Runtime::HGRenderQueue->static_fields->k_RenderQueue_LowTransparent = (RenderQueueRange)0xD4800000C80LL;
		  TypeInfo::HG::Rendering::Runtime::HGRenderQueue->static_fields->k_RenderQueue_AllTransparent = (RenderQueueRange)0xC1C00000A5ALL;
		  TypeInfo::HG::Rendering::Runtime::HGRenderQueue->static_fields->k_RenderQueue_AllTransparentWithLowRes = (RenderQueueRange)0xD4800000A5ALL;
		  TypeInfo::HG::Rendering::Runtime::HGRenderQueue->static_fields->k_RenderQueue_AfterDistortionBeforePostprocessTransparent = (RenderQueueRange)0xDD400000D84LL;
		  TypeInfo::HG::Rendering::Runtime::HGRenderQueue->static_fields->k_RenderQueue_AfterDistortionTransparent = (RenderQueueRange)0xE3800000DE8LL;
		  TypeInfo::HG::Rendering::Runtime::HGRenderQueue->static_fields->k_RenderQueue_AfterPostProcessTransparent = (RenderQueueRange)0xE9C00000E4CLL;
		  TypeInfo::HG::Rendering::Runtime::HGRenderQueue->static_fields->k_RenderQueue_All = (RenderQueueRange)0x138800000000LL;
		}
		
	
		// Methods
		public static int ClampsTransparentRangePriority(int value) => default; // 0x0000000189B8977C-0x0000000189B897E8
		// Int32 ClampsTransparentRangePriority(Int32)
		int32_t HG::Rendering::Runtime::HGRenderQueue::ClampsTransparentRangePriority(int32_t value, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2994, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2994, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_64((ILFixDynamicMethodWrapper_18 *)Patch, value, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::System::Math);
		    if ( value > 50 )
		      value = 50;
		    if ( value <= -50 )
		      return -50;
		    return value;
		  }
		}
		
		public static RenderQueueType GetTypeByRenderQueueValue(int renderQueue) => default; // 0x0000000189B89B34-0x0000000189B89D50
		// HGRenderQueue+RenderQueueType GetTypeByRenderQueueValue(Int32)
		HGRenderQueue_RenderQueueType__Enum HG::Rendering::Runtime::HGRenderQueue::GetTypeByRenderQueueValue(
		        int32_t renderQueue,
		        MethodInfo *method)
		{
		  int v3; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  v3 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(2995, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2995, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_64((ILFixDynamicMethodWrapper_18 *)Patch, renderQueue, 0LL);
		  }
		  else if ( renderQueue == 1000 )
		  {
		    return 0;
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
		    if ( HG::Rendering::Runtime::HGRenderQueue::Contains(
		           TypeInfo::HG::Rendering::Runtime::HGRenderQueue->static_fields->k_RenderQueue_AllOpaque,
		           renderQueue,
		           0LL) )
		    {
		      return 1;
		    }
		    else
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
		      if ( HG::Rendering::Runtime::HGRenderQueue::Contains(
		             TypeInfo::HG::Rendering::Runtime::HGRenderQueue->static_fields->k_RenderQueue_AfterPostProcessOpaque,
		             renderQueue,
		             0LL) )
		      {
		        return 2;
		      }
		      else
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
		        if ( HG::Rendering::Runtime::HGRenderQueue::Contains(
		               TypeInfo::HG::Rendering::Runtime::HGRenderQueue->static_fields->k_RenderQueue_PreRefraction,
		               renderQueue,
		               0LL) )
		        {
		          return 3;
		        }
		        else
		        {
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
		          if ( HG::Rendering::Runtime::HGRenderQueue::Contains(
		                 TypeInfo::HG::Rendering::Runtime::HGRenderQueue->static_fields->k_RenderQueue_Transparent,
		                 renderQueue,
		                 0LL) )
		          {
		            return 4;
		          }
		          else
		          {
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
		            if ( HG::Rendering::Runtime::HGRenderQueue::Contains(
		                   TypeInfo::HG::Rendering::Runtime::HGRenderQueue->static_fields->k_RenderQueue_LowTransparent,
		                   renderQueue,
		                   0LL) )
		            {
		              return 5;
		            }
		            else
		            {
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
		              if ( HG::Rendering::Runtime::HGRenderQueue::Contains(
		                     TypeInfo::HG::Rendering::Runtime::HGRenderQueue->static_fields->k_RenderQueue_AfterDistortionBeforePostprocessTransparent,
		                     renderQueue,
		                     0LL) )
		              {
		                return 6;
		              }
		              else
		              {
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
		                if ( HG::Rendering::Runtime::HGRenderQueue::Contains(
		                       TypeInfo::HG::Rendering::Runtime::HGRenderQueue->static_fields->k_RenderQueue_AfterDistortionTransparent,
		                       renderQueue,
		                       0LL) )
		                {
		                  return 7;
		                }
		                else
		                {
		                  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
		                  if ( HG::Rendering::Runtime::HGRenderQueue::Contains(
		                         TypeInfo::HG::Rendering::Runtime::HGRenderQueue->static_fields->k_RenderQueue_AfterPostProcessTransparent,
		                         renderQueue,
		                         0LL) )
		                  {
		                    return 8;
		                  }
		                  else
		                  {
		                    LOBYTE(v3) = renderQueue != 4000;
		                    return v3 + 9;
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		  }
		}
		
		public static int ChangeType(RenderQueueType targetType, int offset = 0 /* Metadata: 0x02303A87 */, bool alphaTest = false /* Metadata: 0x02303A88 */, bool receiveDecal = false /* Metadata: 0x02303A89 */) => default; // 0x0000000189B895A0-0x0000000189B8977C
		// Int32 ChangeType(HGRenderQueue+RenderQueueType, Int32, Boolean, Boolean)
		int32_t HG::Rendering::Runtime::HGRenderQueue::ChangeType(
		        HGRenderQueue_RenderQueueType__Enum targetType,
		        int32_t offset,
		        bool alphaTest,
		        bool receiveDecal,
		        MethodInfo *method)
		{
		  int32_t result; // eax
		  String *v10; // rbx
		  String *v11; // rax
		  String *v12; // rdi
		  __int64 v13; // rax
		  InvalidEnumArgumentException *v14; // rax
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  InvalidEnumArgumentException *v17; // rbx
		  __int64 v18; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Enum v20; // [rsp+30h] [rbp-28h] BYREF
		  HGRenderQueue_RenderQueueType__Enum v21; // [rsp+40h] [rbp-18h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2996, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2996, 0LL);
		    if ( !Patch )
		      goto LABEL_30;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1112(Patch, targetType, offset, alphaTest, receiveDecal, 0LL);
		  }
		  else if ( (int)targetType > (int)HGRenderQueue_RenderQueueType__Enum_LowTransparent )
		  {
		    switch ( targetType )
		    {
		      case HGRenderQueue_RenderQueueType__Enum_AfterDistortionBeforePostprocessTransparent:
		        return offset + 3500;
		      case HGRenderQueue_RenderQueueType__Enum_AfterDistortionTransparent:
		        return offset + 3600;
		      case HGRenderQueue_RenderQueueType__Enum_AfterPostprocessTransparent:
		        return offset + 3700;
		      case HGRenderQueue_RenderQueueType__Enum_Overlay:
		        return 4000;
		      default:
		LABEL_23:
		        v20.monitor = (MonitorData *)-1LL;
		        v20.klass = (Enum__Class *)sub_18007E180(&TypeInfo::HG::Rendering::Runtime::HGRenderQueue::RenderQueueType);
		        v21 = targetType;
		        v10 = System::Enum::ToString(&v20, 0LL);
		        v11 = (String *)sub_18007E180(&off_18E2662B0);
		        v12 = System::String::Concat(v11, v10, 0LL);
		        v13 = sub_18007E180(&TypeInfo::System::ArgumentException);
		        v14 = (InvalidEnumArgumentException *)sub_18002C620(v13);
		        v17 = v14;
		        if ( v14 )
		        {
		          System::ComponentModel::InvalidEnumArgumentException::InvalidEnumArgumentException(v14, v12, 0LL);
		          v18 = sub_18007E180(&MethodInfo::HG::Rendering::Runtime::HGRenderQueue::ChangeType);
		          sub_18007E190(v17, v18);
		        }
		LABEL_30:
		        sub_1800D8260(v16, v15);
		    }
		  }
		  else if ( targetType == HGRenderQueue_RenderQueueType__Enum_LowTransparent )
		  {
		    return offset + 3300;
		  }
		  else if ( targetType )
		  {
		    switch ( targetType )
		    {
		      case HGRenderQueue_RenderQueueType__Enum_Opaque:
		        if ( alphaTest )
		        {
		          return receiveDecal ? 2475 : 2450;
		        }
		        else
		        {
		          result = offset + 2000;
		          if ( receiveDecal )
		            return 2225;
		        }
		        break;
		      case HGRenderQueue_RenderQueueType__Enum_AfterPostProcessOpaque:
		        return alphaTest ? 2510 : 2501;
		      case HGRenderQueue_RenderQueueType__Enum_PreRefraction:
		        return offset + 2750;
		      case HGRenderQueue_RenderQueueType__Enum_Transparent:
		        return offset + 3000;
		      default:
		        goto LABEL_23;
		    }
		  }
		  else
		  {
		    return 1000;
		  }
		  return result;
		}
		
		public static RenderQueueType GetTransparentEquivalent(RenderQueueType type) => default; // 0x0000000189B89A2C-0x0000000189B89B34
		// HGRenderQueue+RenderQueueType GetTransparentEquivalent(HGRenderQueue+RenderQueueType)
		HGRenderQueue_RenderQueueType__Enum HG::Rendering::Runtime::HGRenderQueue::GetTransparentEquivalent(
		        HGRenderQueue_RenderQueueType__Enum type,
		        MethodInfo *method)
		{
		  String *v4; // rbx
		  String *v5; // rax
		  String *v6; // rdi
		  __int64 v7; // rax
		  InvalidEnumArgumentException *v8; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  InvalidEnumArgumentException *v11; // rbx
		  __int64 v12; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Enum v14; // [rsp+20h] [rbp-28h] BYREF
		  HGRenderQueue_RenderQueueType__Enum v15; // [rsp+30h] [rbp-18h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2997, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2997, 0LL);
		    if ( !Patch )
		      goto LABEL_12;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_64((ILFixDynamicMethodWrapper_18 *)Patch, type, 0LL);
		  }
		  else
		  {
		    switch ( type )
		    {
		      case HGRenderQueue_RenderQueueType__Enum_Background:
		LABEL_9:
		        v14.monitor = (MonitorData *)-1LL;
		        v14.klass = (Enum__Class *)sub_18007E180(&TypeInfo::HG::Rendering::Runtime::HGRenderQueue::RenderQueueType);
		        v15 = type;
		        v4 = System::Enum::ToString(&v14, 0LL);
		        v5 = (String *)sub_18007E180(&off_18E266268);
		        v6 = System::String::Concat(v5, v4, 0LL);
		        v7 = sub_18007E180(&TypeInfo::System::ArgumentException);
		        v8 = (InvalidEnumArgumentException *)sub_18002C620(v7);
		        v11 = v8;
		        if ( v8 )
		        {
		          System::ComponentModel::InvalidEnumArgumentException::InvalidEnumArgumentException(v8, v6, 0LL);
		          v12 = sub_18007E180(&MethodInfo::HG::Rendering::Runtime::HGRenderQueue::GetTransparentEquivalent);
		          sub_18007E190(v11, v12);
		        }
		LABEL_12:
		        sub_1800D8260(v10, v9);
		      case HGRenderQueue_RenderQueueType__Enum_Opaque:
		        return 4;
		      case HGRenderQueue_RenderQueueType__Enum_AfterPostProcessOpaque:
		        return 8;
		      case HGRenderQueue_RenderQueueType__Enum_Overlay:
		        goto LABEL_9;
		      default:
		        return type;
		    }
		  }
		}
		
		public static RenderQueueType GetOpaqueEquivalent(RenderQueueType type) => default; // 0x0000000189B898EC-0x0000000189B89A2C
		// HGRenderQueue+RenderQueueType GetOpaqueEquivalent(HGRenderQueue+RenderQueueType)
		HGRenderQueue_RenderQueueType__Enum HG::Rendering::Runtime::HGRenderQueue::GetOpaqueEquivalent(
		        HGRenderQueue_RenderQueueType__Enum type,
		        MethodInfo *method)
		{
		  String *v4; // rbx
		  String *v5; // rax
		  String *v6; // rdi
		  __int64 v7; // rax
		  InvalidEnumArgumentException *v8; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  InvalidEnumArgumentException *v11; // rbx
		  __int64 v12; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Enum v14; // [rsp+20h] [rbp-28h] BYREF
		  HGRenderQueue_RenderQueueType__Enum v15; // [rsp+30h] [rbp-18h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2998, 0LL) )
		  {
		    if ( (int)type > (int)HGRenderQueue_RenderQueueType__Enum_LowTransparent )
		    {
		      if ( type == HGRenderQueue_RenderQueueType__Enum_AfterDistortionBeforePostprocessTransparent
		        || type == HGRenderQueue_RenderQueueType__Enum_AfterDistortionTransparent )
		      {
		        return type;
		      }
		      if ( type == HGRenderQueue_RenderQueueType__Enum_AfterPostprocessTransparent )
		        return 2;
		      if ( type != HGRenderQueue_RenderQueueType__Enum_Overlay )
		        return type;
		    }
		    else
		    {
		      if ( type == HGRenderQueue_RenderQueueType__Enum_LowTransparent )
		        return 1;
		      if ( type )
		      {
		        if ( type != HGRenderQueue_RenderQueueType__Enum_Opaque
		          && type != HGRenderQueue_RenderQueueType__Enum_AfterPostProcessOpaque
		          && type - 3 <= 1 )
		        {
		          return 1;
		        }
		        return type;
		      }
		    }
		    v14.monitor = (MonitorData *)-1LL;
		    v14.klass = (Enum__Class *)sub_18007E180(&TypeInfo::HG::Rendering::Runtime::HGRenderQueue::RenderQueueType);
		    v15 = type;
		    v4 = System::Enum::ToString(&v14, 0LL);
		    v5 = (String *)sub_18007E180(&off_18E266280);
		    v6 = System::String::Concat(v5, v4, 0LL);
		    v7 = sub_18007E180(&TypeInfo::System::ArgumentException);
		    v8 = (InvalidEnumArgumentException *)sub_18002C620(v7);
		    v11 = v8;
		    if ( v8 )
		    {
		      System::ComponentModel::InvalidEnumArgumentException::InvalidEnumArgumentException(v8, v6, 0LL);
		      v12 = sub_18007E180(&MethodInfo::HG::Rendering::Runtime::HGRenderQueue::GetOpaqueEquivalent);
		      sub_18007E190(v11, v12);
		    }
		LABEL_18:
		    sub_1800D8260(v10, v9);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2998, 0LL);
		  if ( !Patch )
		    goto LABEL_18;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_64((ILFixDynamicMethodWrapper_18 *)Patch, type, 0LL);
		}
		
	
		// Extension methods
		public static bool Contains(this RenderQueueRange range, int value) => default; // 0x0000000189B8986C-0x0000000189B898EC
		// Boolean Contains(RenderQueueRange, Int32)
		bool HG::Rendering::Runtime::HGRenderQueue::Contains(RenderQueueRange range, int32_t value, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  int32_t m_UpperBound; // [rsp+34h] [rbp+Ch]
		
		  m_UpperBound = range.m_UpperBound;
		  if ( IFix::WrappersManagerImpl::IsPatched(2992, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2992, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1109(Patch, range, value, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::RenderQueueRange);
		    if ( range.m_LowerBound <= value )
		    {
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::RenderQueueRange);
		      return value <= m_UpperBound;
		    }
		    else
		    {
		      return 0;
		    }
		  }
		}
		
		public static int Clamps(this RenderQueueRange range, int value) => default; // 0x0000000189B897E8-0x0000000189B8986C
		// Int32 Clamps(RenderQueueRange, Int32)
		int32_t HG::Rendering::Runtime::HGRenderQueue::Clamps(RenderQueueRange range, int32_t value, MethodInfo *method)
		{
		  RenderQueueRange v4; // rbx
		  int32_t v5; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  int32_t m_UpperBound; // [rsp+34h] [rbp+Ch]
		
		  m_UpperBound = range.m_UpperBound;
		  v4 = range;
		  if ( IFix::WrappersManagerImpl::IsPatched(2993, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2993, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1110(Patch, v4, value, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::RenderQueueRange);
		    sub_1800036A0(TypeInfo::System::Math);
		    v5 = m_UpperBound;
		    if ( value <= m_UpperBound )
		      v5 = value;
		    if ( v4.m_LowerBound < v5 )
		      v4.m_LowerBound = v5;
		    return v4.m_LowerBound;
		  }
		}
		
	}
}
