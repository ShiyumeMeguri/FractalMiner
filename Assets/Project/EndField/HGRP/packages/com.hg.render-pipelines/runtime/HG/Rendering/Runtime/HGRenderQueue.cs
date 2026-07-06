using System;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	internal static class HGRenderQueue
	{
		public static bool Contains(this RenderQueueRange range, int value)
		{
			// // Boolean Contains(RenderQueueRange, Int32)
			// bool HG::Rendering::Runtime::HGRenderQueue::Contains(RenderQueueRange range, int32_t value, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   int32_t m_UpperBound; // [rsp+34h] [rbp+Ch]
			// 
			//   m_UpperBound = range.m_UpperBound;
			//   if ( !byte_18D9194F8 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::RenderQueueRange);
			//     byte_18D9194F8 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2484, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2484, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_910(Patch, range, value, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::RenderQueueRange);
			//     if ( range.m_LowerBound <= value )
			//     {
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::RenderQueueRange);
			//       return value <= m_UpperBound;
			//     }
			//     else
			//     {
			//       return 0;
			//     }
			//   }
			// }
			// 
			return default(bool);
		}

		public static int Clamps(this RenderQueueRange range, int value)
		{
			// // Int32 Clamps(RenderQueueRange, Int32)
			// int32_t HG::Rendering::Runtime::HGRenderQueue::Clamps(RenderQueueRange range, int32_t value, MethodInfo *method)
			// {
			//   RenderQueueRange v4; // rbx
			//   int32_t v5; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   int32_t m_UpperBound; // [rsp+34h] [rbp+Ch]
			// 
			//   m_UpperBound = range.m_UpperBound;
			//   v4 = range;
			//   if ( !byte_18D9194F9 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Math);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::RenderQueueRange);
			//     byte_18D9194F9 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2485, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2485, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_911(Patch, v4, value, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::RenderQueueRange);
			//     sub_180002C70(TypeInfo::System::Math);
			//     v5 = m_UpperBound;
			//     if ( value <= m_UpperBound )
			//       v5 = value;
			//     if ( v4.m_LowerBound < v5 )
			//       v4.m_LowerBound = v5;
			//     return v4.m_LowerBound;
			//   }
			// }
			// 
			return 0;
		}

		public static int ClampsTransparentRangePriority(int value)
		{
			// // Int32 ClampsTransparentRangePriority(Int32)
			// int32_t HG::Rendering::Runtime::HGRenderQueue::ClampsTransparentRangePriority(int32_t value, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !byte_18D9194FA )
			//   {
			//     sub_18003C530(&TypeInfo::System::Math);
			//     byte_18D9194FA = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2486, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2486, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_71((ILFixDynamicMethodWrapper_17 *)Patch, value, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::System::Math);
			//     if ( value > 50 )
			//       value = 50;
			//     if ( value <= -50 )
			//       return -50;
			//     return value;
			//   }
			// }
			// 
			return 0;
		}

		public static HGRenderQueue.RenderQueueType GetTypeByRenderQueueValue(int renderQueue)
		{
			// // HGRenderQueue+RenderQueueType GetTypeByRenderQueueValue(Int32)
			// HGRenderQueue_RenderQueueType__Enum HG::Rendering::Runtime::HGRenderQueue::GetTypeByRenderQueueValue(
			//         int32_t renderQueue,
			//         MethodInfo *method)
			// {
			//   int v2; // ebx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   v2 = 0;
			//   if ( !byte_18D9194FB )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//     byte_18D9194FB = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2487, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2487, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_71((ILFixDynamicMethodWrapper_17 *)Patch, renderQueue, 0LL);
			//   }
			//   else if ( renderQueue == 1000 )
			//   {
			//     return 0;
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//     if ( HG::Rendering::Runtime::HGRenderQueue::Contains(
			//            TypeInfo::HG::Rendering::Runtime::HGRenderQueue.static_fields.k_RenderQueue_AllOpaque,
			//            renderQueue,
			//            0LL) )
			//     {
			//       return 1;
			//     }
			//     else
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//       if ( HG::Rendering::Runtime::HGRenderQueue::Contains(
			//              TypeInfo::HG::Rendering::Runtime::HGRenderQueue.static_fields.k_RenderQueue_AfterPostProcessOpaque,
			//              renderQueue,
			//              0LL) )
			//       {
			//         return 2;
			//       }
			//       else
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//         if ( HG::Rendering::Runtime::HGRenderQueue::Contains(
			//                TypeInfo::HG::Rendering::Runtime::HGRenderQueue.static_fields.k_RenderQueue_PreRefraction,
			//                renderQueue,
			//                0LL) )
			//         {
			//           return 3;
			//         }
			//         else
			//         {
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//           if ( HG::Rendering::Runtime::HGRenderQueue::Contains(
			//                  TypeInfo::HG::Rendering::Runtime::HGRenderQueue.static_fields.k_RenderQueue_Transparent,
			//                  renderQueue,
			//                  0LL) )
			//           {
			//             return 4;
			//           }
			//           else
			//           {
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//             if ( HG::Rendering::Runtime::HGRenderQueue::Contains(
			//                    TypeInfo::HG::Rendering::Runtime::HGRenderQueue.static_fields.k_RenderQueue_LowTransparent,
			//                    renderQueue,
			//                    0LL) )
			//             {
			//               return 5;
			//             }
			//             else
			//             {
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//               if ( HG::Rendering::Runtime::HGRenderQueue::Contains(
			//                      TypeInfo::HG::Rendering::Runtime::HGRenderQueue.static_fields.k_RenderQueue_AfterDistortionBeforePostprocessTransparent,
			//                      renderQueue,
			//                      0LL) )
			//               {
			//                 return 6;
			//               }
			//               else
			//               {
			//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//                 if ( HG::Rendering::Runtime::HGRenderQueue::Contains(
			//                        TypeInfo::HG::Rendering::Runtime::HGRenderQueue.static_fields.k_RenderQueue_AfterDistortionTransparent,
			//                        renderQueue,
			//                        0LL) )
			//                 {
			//                   return 7;
			//                 }
			//                 else
			//                 {
			//                   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//                   if ( HG::Rendering::Runtime::HGRenderQueue::Contains(
			//                          TypeInfo::HG::Rendering::Runtime::HGRenderQueue.static_fields.k_RenderQueue_AfterPostProcessTransparent,
			//                          renderQueue,
			//                          0LL) )
			//                   {
			//                     return 8;
			//                   }
			//                   else
			//                   {
			//                     LOBYTE(v2) = renderQueue != 4000;
			//                     return v2 + 9;
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			//   }
			// }
			// 
			return HGRenderQueue.RenderQueueType.Background;
		}

		public static int ChangeType(HGRenderQueue.RenderQueueType targetType, [MetadataOffset(Offset = "0x01F91653")] int offset = 0, [MetadataOffset(Offset = "0x01F91654")] bool alphaTest = false, [MetadataOffset(Offset = "0x01F91655")] bool receiveDecal = false)
		{
			// // Int32 ChangeType(HGRenderQueue+RenderQueueType, Int32, Boolean, Boolean)
			// int32_t HG::Rendering::Runtime::HGRenderQueue::ChangeType(
			//         HGRenderQueue_RenderQueueType__Enum targetType,
			//         int32_t offset,
			//         bool alphaTest,
			//         bool receiveDecal,
			//         MethodInfo *method)
			// {
			//   int32_t result; // eax
			//   String *v10; // rbx
			//   String *v11; // rax
			//   String *v12; // rdi
			//   __int64 v13; // rax
			//   InvalidEnumArgumentException *v14; // rax
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			//   InvalidEnumArgumentException *v17; // rbx
			//   __int64 v18; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Enum v20; // [rsp+30h] [rbp-28h] BYREF
			//   HGRenderQueue_RenderQueueType__Enum v21; // [rsp+40h] [rbp-18h]
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2488, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2488, 0LL);
			//     if ( !Patch )
			//       goto LABEL_30;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_913(Patch, targetType, offset, alphaTest, receiveDecal, 0LL);
			//   }
			//   else if ( (int)targetType > (int)HGRenderQueue_RenderQueueType__Enum_LowTransparent )
			//   {
			//     switch ( targetType )
			//     {
			//       case HGRenderQueue_RenderQueueType__Enum_AfterDistortionBeforePostprocessTransparent:
			//         return offset + 3500;
			//       case HGRenderQueue_RenderQueueType__Enum_AfterDistortionTransparent:
			//         return offset + 3600;
			//       case HGRenderQueue_RenderQueueType__Enum_AfterPostprocessTransparent:
			//         return offset + 3700;
			//       case HGRenderQueue_RenderQueueType__Enum_Overlay:
			//         return 4000;
			//       default:
			// LABEL_23:
			//         v20.monitor = (MonitorData *)-1LL;
			//         v20.klass = (Enum__Class *)sub_18000F7E0(&TypeInfo::HG::Rendering::Runtime::HGRenderQueue::RenderQueueType);
			//         v21 = targetType;
			//         v10 = System::Enum::ToString(&v20, 0LL);
			//         v11 = (String *)sub_18000F7E0(&off_18D4F7658);
			//         v12 = System::String::Concat(v11, v10, 0LL);
			//         v13 = sub_18000F7E0(&TypeInfo::System::ArgumentException);
			//         v14 = (InvalidEnumArgumentException *)sub_180004920(v13);
			//         v17 = v14;
			//         if ( v14 )
			//         {
			//           System::ComponentModel::InvalidEnumArgumentException::InvalidEnumArgumentException(v14, v12, 0LL);
			//           v18 = sub_18000F7E0(&MethodInfo::HG::Rendering::Runtime::HGRenderQueue::ChangeType);
			//           sub_18000F7C0(v17, v18);
			//         }
			// LABEL_30:
			//         sub_180B536AC(v16, v15);
			//     }
			//   }
			//   else if ( targetType == HGRenderQueue_RenderQueueType__Enum_LowTransparent )
			//   {
			//     return offset + 3300;
			//   }
			//   else if ( targetType )
			//   {
			//     switch ( targetType )
			//     {
			//       case HGRenderQueue_RenderQueueType__Enum_Opaque:
			//         if ( alphaTest )
			//         {
			//           return receiveDecal ? 2475 : 2450;
			//         }
			//         else
			//         {
			//           result = offset + 2000;
			//           if ( receiveDecal )
			//             return 2225;
			//         }
			//         break;
			//       case HGRenderQueue_RenderQueueType__Enum_AfterPostProcessOpaque:
			//         return alphaTest ? 2510 : 2501;
			//       case HGRenderQueue_RenderQueueType__Enum_PreRefraction:
			//         return offset + 2750;
			//       case HGRenderQueue_RenderQueueType__Enum_Transparent:
			//         return offset + 3000;
			//       default:
			//         goto LABEL_23;
			//     }
			//   }
			//   else
			//   {
			//     return 1000;
			//   }
			//   return result;
			// }
			// 
			return 0;
		}

		public static HGRenderQueue.RenderQueueType GetTransparentEquivalent(HGRenderQueue.RenderQueueType type)
		{
			// // HGRenderQueue+RenderQueueType GetTransparentEquivalent(HGRenderQueue+RenderQueueType)
			// HGRenderQueue_RenderQueueType__Enum HG::Rendering::Runtime::HGRenderQueue::GetTransparentEquivalent(
			//         HGRenderQueue_RenderQueueType__Enum type,
			//         MethodInfo *method)
			// {
			//   String *v4; // rbx
			//   String *v5; // rax
			//   String *v6; // rdi
			//   __int64 v7; // rax
			//   InvalidEnumArgumentException *v8; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   InvalidEnumArgumentException *v11; // rbx
			//   __int64 v12; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Enum v14; // [rsp+20h] [rbp-28h] BYREF
			//   HGRenderQueue_RenderQueueType__Enum v15; // [rsp+30h] [rbp-18h]
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2489, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2489, 0LL);
			//     if ( !Patch )
			//       goto LABEL_12;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_71((ILFixDynamicMethodWrapper_17 *)Patch, type, 0LL);
			//   }
			//   else
			//   {
			//     switch ( type )
			//     {
			//       case HGRenderQueue_RenderQueueType__Enum_Background:
			// LABEL_9:
			//         v14.monitor = (MonitorData *)-1LL;
			//         v14.klass = (Enum__Class *)sub_18000F7E0(&TypeInfo::HG::Rendering::Runtime::HGRenderQueue::RenderQueueType);
			//         v15 = type;
			//         v4 = System::Enum::ToString(&v14, 0LL);
			//         v5 = (String *)sub_18000F7E0(&off_18D4F7618);
			//         v6 = System::String::Concat(v5, v4, 0LL);
			//         v7 = sub_18000F7E0(&TypeInfo::System::ArgumentException);
			//         v8 = (InvalidEnumArgumentException *)sub_180004920(v7);
			//         v11 = v8;
			//         if ( v8 )
			//         {
			//           System::ComponentModel::InvalidEnumArgumentException::InvalidEnumArgumentException(v8, v6, 0LL);
			//           v12 = sub_18000F7E0(&MethodInfo::HG::Rendering::Runtime::HGRenderQueue::GetTransparentEquivalent);
			//           sub_18000F7C0(v11, v12);
			//         }
			// LABEL_12:
			//         sub_180B536AC(v10, v9);
			//       case HGRenderQueue_RenderQueueType__Enum_Opaque:
			//         return 4;
			//       case HGRenderQueue_RenderQueueType__Enum_AfterPostProcessOpaque:
			//         return 8;
			//       case HGRenderQueue_RenderQueueType__Enum_Overlay:
			//         goto LABEL_9;
			//       default:
			//         return type;
			//     }
			//   }
			// }
			// 
			return HGRenderQueue.RenderQueueType.Background;
		}

		public static HGRenderQueue.RenderQueueType GetOpaqueEquivalent(HGRenderQueue.RenderQueueType type)
		{
			// // HGRenderQueue+RenderQueueType GetOpaqueEquivalent(HGRenderQueue+RenderQueueType)
			// HGRenderQueue_RenderQueueType__Enum HG::Rendering::Runtime::HGRenderQueue::GetOpaqueEquivalent(
			//         HGRenderQueue_RenderQueueType__Enum type,
			//         MethodInfo *method)
			// {
			//   String *v4; // rbx
			//   String *v5; // rax
			//   String *v6; // rdi
			//   __int64 v7; // rax
			//   InvalidEnumArgumentException *v8; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   InvalidEnumArgumentException *v11; // rbx
			//   __int64 v12; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Enum v14; // [rsp+20h] [rbp-28h] BYREF
			//   HGRenderQueue_RenderQueueType__Enum v15; // [rsp+30h] [rbp-18h]
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2490, 0LL) )
			//   {
			//     if ( (int)type > (int)HGRenderQueue_RenderQueueType__Enum_LowTransparent )
			//     {
			//       if ( type == HGRenderQueue_RenderQueueType__Enum_AfterDistortionBeforePostprocessTransparent
			//         || type == HGRenderQueue_RenderQueueType__Enum_AfterDistortionTransparent )
			//       {
			//         return type;
			//       }
			//       if ( type == HGRenderQueue_RenderQueueType__Enum_AfterPostprocessTransparent )
			//         return 2;
			//       if ( type != HGRenderQueue_RenderQueueType__Enum_Overlay )
			//         return type;
			//     }
			//     else
			//     {
			//       if ( type == HGRenderQueue_RenderQueueType__Enum_LowTransparent )
			//         return 1;
			//       if ( type )
			//       {
			//         if ( type != HGRenderQueue_RenderQueueType__Enum_Opaque
			//           && type != HGRenderQueue_RenderQueueType__Enum_AfterPostProcessOpaque
			//           && type - 3 <= 1 )
			//         {
			//           return 1;
			//         }
			//         return type;
			//       }
			//     }
			//     v14.monitor = (MonitorData *)-1LL;
			//     v14.klass = (Enum__Class *)sub_18000F7E0(&TypeInfo::HG::Rendering::Runtime::HGRenderQueue::RenderQueueType);
			//     v15 = type;
			//     v4 = System::Enum::ToString(&v14, 0LL);
			//     v5 = (String *)sub_18000F7E0(&off_18D4F7638);
			//     v6 = System::String::Concat(v5, v4, 0LL);
			//     v7 = sub_18000F7E0(&TypeInfo::System::ArgumentException);
			//     v8 = (InvalidEnumArgumentException *)sub_180004920(v7);
			//     v11 = v8;
			//     if ( v8 )
			//     {
			//       System::ComponentModel::InvalidEnumArgumentException::InvalidEnumArgumentException(v8, v6, 0LL);
			//       v12 = sub_18000F7E0(&MethodInfo::HG::Rendering::Runtime::HGRenderQueue::GetOpaqueEquivalent);
			//       sub_18000F7C0(v11, v12);
			//     }
			// LABEL_18:
			//     sub_180B536AC(v10, v9);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2490, 0LL);
			//   if ( !Patch )
			//     goto LABEL_18;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_71((ILFixDynamicMethodWrapper_17 *)Patch, type, 0LL);
			// }
			// 
			return HGRenderQueue.RenderQueueType.Background;
		}

		private const int k_TransparentPriorityQueueRangeStep = 100;

		public const int k_TransparentAfterDistortionPriorityQueueRangeStep = 40;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static readonly RenderQueueRange k_RenderQueue_OpaqueNoAlphaTest;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		public static readonly RenderQueueRange k_RenderQueue_OpaqueAlphaTest;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		public static readonly RenderQueueRange k_RenderQueue_OpaqueDecalAndAlphaTest;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x18")]
		public static readonly RenderQueueRange k_RenderQueue_AllOpaque;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x20")]
		public static readonly RenderQueueRange k_RenderQueue_AfterPostProcessOpaque;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x28")]
		public static readonly RenderQueueRange k_RenderQueue_PreRefraction;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x30")]
		public static readonly RenderQueueRange k_RenderQueue_Transparent;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x38")]
		public static readonly RenderQueueRange k_RenderQueue_TransparentWithLowRes;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x40")]
		public static readonly RenderQueueRange k_RenderQueue_LowTransparent;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x48")]
		public static readonly RenderQueueRange k_RenderQueue_AllTransparent;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x50")]
		public static readonly RenderQueueRange k_RenderQueue_AllTransparentWithLowRes;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x58")]
		public static readonly RenderQueueRange k_RenderQueue_AfterDistortionBeforePostprocessTransparent;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x60")]
		public static readonly RenderQueueRange k_RenderQueue_AfterDistortionTransparent;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x68")]
		public static readonly RenderQueueRange k_RenderQueue_AfterPostProcessTransparent;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x70")]
		public static readonly RenderQueueRange k_RenderQueue_All;

		public const int sortingPriorityRange = 50;

		public const int meshDecalPriorityRange = 50;

		public enum Priority
		{
			Background = 1000,
			Opaque = 2000,
			OpaqueDecal = 2225,
			OpaqueAlphaTest = 2450,
			OpaqueDecalAlphaTest = 2475,
			OpaqueLast = 2500,
			AfterPostprocessOpaque,
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

		public enum RenderQueueType
		{
			Background,
			Opaque,
			AfterPostProcessOpaque,
			PreRefraction,
			Transparent,
			LowTransparent,
			AfterDistortionBeforePostprocessTransparent,
			AfterDistortionTransparent,
			AfterPostprocessTransparent,
			Overlay,
			Unknown
		}
	}
}
