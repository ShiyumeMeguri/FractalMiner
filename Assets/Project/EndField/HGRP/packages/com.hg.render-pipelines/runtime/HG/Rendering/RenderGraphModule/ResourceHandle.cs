using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.RenderGraphModule
{
	internal struct ResourceHandle // TypeDefIndex: 37465
	{
		// Fields
		private const uint kValidityMask = 4294901760; // Metadata: 0x02302D84
		private const uint kIndexMask = 65535; // Metadata: 0x02302D89
		private uint m_Value; // 0x00
		private static uint s_CurrentValidBit; // 0x00
		private static uint s_PreservedResourceValidBit; // 0x04
	
		// Properties
		public int index { get => default; } // 0x0000000189B3FD38-0x0000000189B3FD80 
		// Int32 get_index()
		int32_t HG::Rendering::RenderGraphModule::ResourceHandle::get_index(ResourceHandle *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(40, 0LL) )
		    return LOWORD(this->m_Value);
		  Patch = IFix::WrappersManagerImpl::GetPatch(40, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_20(Patch, this, 0LL);
		}
		
		public HGRenderGraphResourceType type { [IsReadOnly] get; private set; } // 0x0000000184D88B20-0x0000000184D88B30 0x0000000184D88B50-0x0000000184D88B60
		// Int32 get_endIndex()
		int32_t Beyond::Gameplay::Factory::WireRendererInfoCollection<Beyond::Gameplay::Factory::WireRendererInfo>::get_endIndex(
		        WireRendererInfoCollection_1_WireRendererInfo_ *this,
		        MethodInfo *method)
		{
		  return this->m_endIndex;
		}
		

		// Void set_area(Int32)
		void UnityEngine::AI::NavMeshBuildMarkup::set_area(NavMeshBuildMarkup *this, int32_t value, MethodInfo *method)
		{
		  this->m_Area = value;
		}
		
		public int iType { get => default; } // 0x0000000189B3FCE4-0x0000000189B3FD38 
		// Int32 get_iType()
		int32_t HG::Rendering::RenderGraphModule::ResourceHandle::get_iType(ResourceHandle *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(45, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(45, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_20(Patch, this, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		    return this->_type_k__BackingField;
		  }
		}
		
	
		// Constructors
		internal ResourceHandle(int value, HGRenderGraphResourceType type, bool preserved) : this() {
			m_Value = default;
		} // 0x0000000189B3FC6C-0x0000000189B3FCE4
		// ResourceHandle(Int32, HGRenderGraphResourceType, Boolean)
		void HG::Rendering::RenderGraphModule::ResourceHandle::ResourceHandle(
		        ResourceHandle *this,
		        int32_t value,
		        HGRenderGraphResourceType__Enum type,
		        bool preserved,
		        MethodInfo *method)
		{
		  unsigned __int16 v6; // si
		  ResourceHandle__StaticFields *p_s_PreservedResourceValidBit; // r9
		
		  v6 = value;
		  if ( preserved )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		    p_s_PreservedResourceValidBit = (ResourceHandle__StaticFields *)&TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle->static_fields->s_PreservedResourceValidBit;
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		    p_s_PreservedResourceValidBit = TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle->static_fields;
		  }
		  this->m_Value = p_s_PreservedResourceValidBit->s_CurrentValidBit | v6;
		  sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		  this->_type_k__BackingField = type;
		}
		
		static ResourceHandle() {
			s_CurrentValidBit = default;
			s_PreservedResourceValidBit = default;
		} // 0x0000000184DA1340-0x0000000184DA1370
		// ResourceHandle()
		void HG::Rendering::RenderGraphModule::ResourceHandle::cctor(MethodInfo *method)
		{
		  TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle->static_fields->s_CurrentValidBit = 0x10000;
		  TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle->static_fields->s_PreservedResourceValidBit = 2147418112;
		}
		
	
		// Methods
		public static implicit operator int(ResourceHandle handle) => default; // 0x0000000189B3FD80-0x0000000189B3FDE4
		// Int32 op_Implicit(ResourceHandle)
		int32_t HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit(ResourceHandle handle, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  ResourceHandle v7; // [rsp+30h] [rbp+8h] BYREF
		
		  v7 = handle;
		  if ( IFix::WrappersManagerImpl::IsPatched(39, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(39, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_21(Patch, handle, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		    return HG::Rendering::RenderGraphModule::ResourceHandle::get_index(&v7, 0LL);
		  }
		}
		
		[IsReadOnly]
		public bool IsValid() => default; // 0x0000000189B3FAF4-0x0000000189B3FB8C
		// Boolean IsValid()
		bool HG::Rendering::RenderGraphModule::ResourceHandle::IsValid(ResourceHandle *this, MethodInfo *method)
		{
		  bool result; // al
		  uint32_t v4; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  result = IFix::WrappersManagerImpl::IsPatched(153, 0LL);
		  if ( result )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(153, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_72(Patch, this, 0LL);
		  }
		  else
		  {
		    v4 = this->m_Value & 0xFFFF0000;
		    if ( v4 )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		      if ( v4 == TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle->static_fields->s_CurrentValidBit )
		      {
		        return 1;
		      }
		      else
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		        return v4 == TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle->static_fields->s_PreservedResourceValidBit;
		      }
		    }
		  }
		  return result;
		}
		
		[IsReadOnly]
		public bool IsPreserved() => default; // 0x0000000189B3FA80-0x0000000189B3FAF4
		// Boolean IsPreserved()
		bool HG::Rendering::RenderGraphModule::ResourceHandle::IsPreserved(ResourceHandle *this, MethodInfo *method)
		{
		  uint32_t m_Value; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(160, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(160, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_72(Patch, this, 0LL);
		  }
		  else
		  {
		    m_Value = this->m_Value;
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		    return (m_Value & 0xFFFF0000) == TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle->static_fields->s_PreservedResourceValidBit;
		  }
		}
		
		public static void NewFrame(int executionIndex) {} // 0x0000000189B3FB8C-0x0000000189B3FC6C
		// Void NewFrame(Int32)
		void HG::Rendering::RenderGraphModule::ResourceHandle::NewFrame(int32_t executionIndex, MethodInfo *method)
		{
		  ResourceHandle__StaticFields *static_fields; // rax
		  uint32_t s_CurrentValidBit; // edi
		  struct ResourceHandle__Class *v5; // rdx
		  int v6; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(184, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(184, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15((ILFixDynamicMethodWrapper_30 *)Patch, executionIndex, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		    static_fields = TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle->static_fields;
		    s_CurrentValidBit = static_fields->s_CurrentValidBit;
		    static_fields->s_CurrentValidBit = executionIndex & 0xFFFF0000 ^ (1522728960 * executionIndex);
		    v5 = TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle;
		    if ( !TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle->static_fields->s_CurrentValidBit
		      || (sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle),
		          v5 = TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle,
		          TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle->static_fields->s_CurrentValidBit == TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle->static_fields->s_PreservedResourceValidBit) )
		    {
		      v6 = 1;
		      if ( s_CurrentValidBit == 0x10000 )
		      {
		        do
		          ++v6;
		        while ( (_WORD)v6 == 1 );
		      }
		      sub_1800036A0(v5);
		      TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle->static_fields->s_CurrentValidBit = v6 << 16;
		    }
		  }
		}
		
	}
}
