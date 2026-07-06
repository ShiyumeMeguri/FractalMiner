using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace HG.Rendering.RenderGraphModule
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 8)]
	internal struct ResourceHandle
	{
		// (get) Token: 0x060002EB RID: 747 RVA: 0x00002608 File Offset: 0x00000808
		public int index
		{
			get
			{
				// // UInt16 ReadUnaligned[UInt16](Byte ByRef)
				// uint16_t System::Runtime::CompilerServices::Unsafe::ReadUnaligned<unsigned short>(uint8_t *source, MethodInfo *method)
				// {
				//   return *(_WORD *)source;
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x060002EC RID: 748 RVA: 0x00002728 File Offset: 0x00000928
		// (set) Token: 0x060002ED RID: 749 RVA: 0x000025D0 File Offset: 0x000007D0
		public HGRenderGraphResourceType type
		{
			[CompilerGenerated]
			readonly get
			{
				// // Int32 get_endIndex()
				// int32_t Beyond::Gameplay::Factory::WireRendererInfoCollection<Beyond::Gameplay::Factory::WireRendererInfo>::get_endIndex(
				//         WireRendererInfoCollection_1_WireRendererInfo_ *this,
				//         MethodInfo *method)
				// {
				//   return this.m_endIndex;
				// }
				// 
				return (HGRenderGraphResourceType)HGRenderGraphResourceType.Texture;
			}
			[CompilerGenerated]
			private set
			{
				// // Void set_area(Int32)
				// void UnityEngine::AI::NavMeshBuildMarkup::set_area(NavMeshBuildMarkup *this, int32_t value, MethodInfo *method)
				// {
				//   this.m_Area = value;
				// }
				// 
			}
		}

		// (get) Token: 0x060002EE RID: 750 RVA: 0x00002608 File Offset: 0x00000808
		public int iType
		{
			get
			{
				// // Int32 get_iType()
				// int32_t HG::Rendering::RenderGraphModule::ResourceHandle::get_iType(ResourceHandle *this, MethodInfo *method)
				// {
				//   if ( !byte_18D9193A6 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
				//     byte_18D9193A6 = 1;
				//   }
				//   if ( !TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle, method);
				//   return this._type_k__BackingField;
				// }
				// 
				return 0;
			}
		}

		internal ResourceHandle(int value, HGRenderGraphResourceType type, bool preserved)
		{
			// // ResourceHandle(Int32, HGRenderGraphResourceType, Boolean)
			// void HG::Rendering::RenderGraphModule::ResourceHandle::ResourceHandle(
			//         ResourceHandle *this,
			//         int32_t value,
			//         HGRenderGraphResourceType__Enum type,
			//         bool preserved,
			//         MethodInfo *method)
			// {
			//   unsigned __int16 v7; // bp
			//   ResourceHandle__StaticFields *static_fields; // rcx
			// 
			//   v7 = value;
			//   if ( !byte_18D9193A7 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     byte_18D9193A7 = 1;
			//   }
			//   sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//   static_fields = TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle.static_fields;
			//   if ( preserved )
			//     static_fields = (ResourceHandle__StaticFields *)((char *)static_fields + 4);
			//   this.m_Value = static_fields.s_CurrentValidBit | v7;
			//   sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//   this._type_k__BackingField = type;
			// }
			// 
		}

		public static implicit operator int(ResourceHandle handle)
		{
			// // Int32 op_Implicit(ResourceHandle)
			// int32_t HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit(ResourceHandle handle, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !byte_18D9193A8 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     byte_18D9193A8 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(44, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(44, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_24(Patch, handle, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     return LOWORD(handle.m_Value);
			//   }
			// }
			// 
			return 0;
		}

		public readonly bool IsValid()
		{
			// // Boolean IsValid()
			// bool HG::Rendering::RenderGraphModule::ResourceHandle::IsValid(ResourceHandle *this, MethodInfo *method)
			// {
			//   bool result; // al
			//   uint32_t v4; // ebx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( !byte_18D9193A9 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     byte_18D9193A9 = 1;
			//   }
			//   result = IFix::WrappersManagerImpl::IsPatched(151, 0LL);
			//   if ( result )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(151, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_71(Patch, this, 0LL);
			//   }
			//   else
			//   {
			//     v4 = this.m_Value & 0xFFFF0000;
			//     if ( v4 )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//       if ( v4 == TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle.static_fields.s_CurrentValidBit )
			//       {
			//         return 1;
			//       }
			//       else
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//         return v4 == TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle.static_fields.s_PreservedResourceValidBit;
			//       }
			//     }
			//   }
			//   return result;
			// }
			// 
			return default(bool);
		}

		public readonly bool IsPreserved()
		{
			// // Boolean IsPreserved()
			// bool HG::Rendering::RenderGraphModule::ResourceHandle::IsPreserved(ResourceHandle *this, MethodInfo *method)
			// {
			//   uint32_t m_Value; // ebx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( !byte_18D9193AA )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     byte_18D9193AA = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(158, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(158, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_71(Patch, this, 0LL);
			//   }
			//   else
			//   {
			//     m_Value = this.m_Value;
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     return (m_Value & 0xFFFF0000) == TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle.static_fields.s_PreservedResourceValidBit;
			//   }
			// }
			// 
			return default(bool);
		}

		public static void NewFrame(int executionIndex)
		{
			// // Void NewFrame(Int32)
			// void HG::Rendering::RenderGraphModule::ResourceHandle::NewFrame(int32_t executionIndex, MethodInfo *method)
			// {
			//   ResourceHandle__StaticFields *static_fields; // rax
			//   uint32_t s_CurrentValidBit; // edi
			//   struct ResourceHandle__Class *v5; // rdx
			//   int v6; // ebx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			// 
			//   if ( !byte_18D9193AB )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     byte_18D9193AB = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(182, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(182, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_28 *)Patch, executionIndex, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     static_fields = TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle.static_fields;
			//     s_CurrentValidBit = static_fields.s_CurrentValidBit;
			//     static_fields.s_CurrentValidBit = executionIndex & 0xFFFF0000 ^ (1522728960 * executionIndex);
			//     v5 = TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle;
			//     if ( !TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle.static_fields.s_CurrentValidBit
			//       || (sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle),
			//           v5 = TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle,
			//           TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle.static_fields.s_CurrentValidBit == TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle.static_fields.s_PreservedResourceValidBit) )
			//     {
			//       v6 = 1;
			//       if ( s_CurrentValidBit == 0x10000 )
			//       {
			//         do
			//           ++v6;
			//         while ( (_WORD)v6 == 1 );
			//       }
			//       sub_180002C70(v5);
			//       TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle.static_fields.s_CurrentValidBit = v6 << 16;
			//     }
			//   }
			// }
			// 
		}

		private const uint kValidityMask = 4294901760U;

		private const uint kIndexMask = 65535U;

		private uint m_Value;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static uint s_CurrentValidBit;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x04")]
		private static uint s_PreservedResourceValidBit;
	}
}
