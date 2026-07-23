using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGSMAA // TypeDefIndex: 38052
	{
		// Fields
		private static Lazy<HGSMAA> s_instance; // 0x00
		private HGSMAAMode m_smaaMode; // 0x10
		private HGSMAAMode m_edgeMode; // 0x14
		private HGSMAAMode m_blendMode; // 0x18
	
		// Properties
		public static HGSMAA instance { get => default; } // 0x0000000189B6D794-0x0000000189B6D800 
		// HGSMAA get_instance()
		HGSMAA *HG::Rendering::Runtime::HGSMAA::get_instance(MethodInfo *method)
		{
		  __int64 v1; // rdx
		  Lazy_1_HG_Rendering_Runtime_HGSMAA_ *s_instance; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2693, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGSMAA);
		    s_instance = TypeInfo::HG::Rendering::Runtime::HGSMAA->static_fields->s_instance;
		    if ( s_instance )
		      return (HGSMAA *)System::Lazy<System::Object>::get_Value(
		                         (Lazy_1_Object_ *)s_instance,
		                         MethodInfo::System::Lazy<HG::Rendering::Runtime::HGSMAA>::get_Value);
		LABEL_5:
		    sub_1800D8260(s_instance, v1);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2693, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_990(Patch, 0LL);
		}
		
	
		// Constructors
		public HGSMAA() {} // 0x0000000184DA15D0-0x0000000184DA15E0
		// HGSMAA()
		void HG::Rendering::Runtime::HGSMAA::HGSMAA(HGSMAA *this, MethodInfo *method)
		{
		  this->fields.m_edgeMode = 1;
		  this->fields.m_blendMode = 1;
		}
		
		static HGSMAA() {} // 0x0000000189B6D6E8-0x0000000189B6D794
		// HGSMAA()
		void HG::Rendering::Runtime::HGSMAA::cctor(MethodInfo *method)
		{
		  Object *v1; // rdi
		  Func_1_Object_ *v2; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  Func_1_Object_ *v5; // rbx
		  Lazy_1_Object_ *v6; // rax
		  HGRuntimeGrassQuery_Node__Class *v7; // rdi
		  HGRuntimeGrassQuery_Node *static_fields; // rdx
		  HGRuntimeGrassQuery_Node *v9; // r8
		  Int32__Array **v10; // r9
		  MethodInfo *v11; // [rsp+50h] [rbp+28h]
		
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGSMAA::__c);
		  v1 = (Object *)TypeInfo::HG::Rendering::Runtime::HGSMAA::__c->static_fields->__9;
		  v2 = (Func_1_Object_ *)sub_18002C620(TypeInfo::System::Func<HG::Rendering::Runtime::HGSMAA>);
		  v5 = v2;
		  if ( !v2
		    || (System::Func<System::Object>::Func(
		          v2,
		          v1,
		          MethodInfo::HG::Rendering::Runtime::HGSMAA::__c::__cctor_b__15_0,
		          0LL),
		        v6 = (Lazy_1_Object_ *)sub_18002C620(TypeInfo::System::Lazy<HG::Rendering::Runtime::HGSMAA>),
		        (v7 = (HGRuntimeGrassQuery_Node__Class *)v6) == 0LL) )
		  {
		    sub_1800D8260(v4, v3);
		  }
		  System::Lazy<System::Object>::Lazy(v6, v5, MethodInfo::System::Lazy<HG::Rendering::Runtime::HGSMAA>::Lazy);
		  static_fields = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HGSMAA->static_fields;
		  static_fields->klass = v7;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HGSMAA->static_fields,
		    static_fields,
		    v9,
		    v10,
		    v11);
		}
		
	
		// Methods
		public bool DoSMAA() => default; // 0x0000000189B6D450-0x0000000189B6D4A0
		// Boolean DoSMAA()
		bool HG::Rendering::Runtime::HGSMAA::DoSMAA(HGSMAA *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2694, 0LL) )
		    return this->fields.m_smaaMode != 0;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2694, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		public void SetSMAAMode(HGSMAAMode mode) {} // 0x0000000189B6D688-0x0000000189B6D6E8
		// Void SetSMAAMode(HGSMAAMode)
		void HG::Rendering::Runtime::HGSMAA::SetSMAAMode(HGSMAA *this, HGSMAAMode__Enum mode, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2695, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2695, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_2((ILFixDynamicMethodWrapper_30 *)Patch, (Object *)this, mode, 0LL);
		  }
		  else
		  {
		    this->fields.m_smaaMode = mode;
		    this->fields.m_edgeMode = mode;
		    this->fields.m_blendMode = mode;
		  }
		}
		
		public int GetEdgeClearPass() => default; // 0x0000000189B6D4F0-0x0000000189B6D53C
		// Int32 GetEdgeClearPass()
		int32_t HG::Rendering::Runtime::HGSMAA::GetEdgeClearPass(HGSMAA *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2696, 0LL) )
		    return 0;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2696, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
		public int GetEdgePass() => default; // 0x0000000189B6D53C-0x0000000189B6D588
		// Int32 GetEdgePass()
		int32_t HG::Rendering::Runtime::HGSMAA::GetEdgePass(HGSMAA *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2697, 0LL) )
		    return this->fields.m_edgeMode;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2697, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
		public int GetBlendWeightsPass() => default; // 0x0000000189B6D4A0-0x0000000189B6D4F0
		// Int32 GetBlendWeightsPass()
		int32_t HG::Rendering::Runtime::HGSMAA::GetBlendWeightsPass(HGSMAA *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2698, 0LL) )
		    return this->fields.m_blendMode + 4;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2698, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
		public int GetNeighborBlendPass() => default; // 0x0000000189B6D588-0x0000000189B6D5D8
		// Int32 GetNeighborBlendPass()
		int32_t HG::Rendering::Runtime::HGSMAA::GetNeighborBlendPass(HGSMAA *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2699, 0LL) )
		    return 9;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2699, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
		public void SetEdgeMode(HGSMAAMode mode) {} // 0x0000000189B6D630-0x0000000189B6D688
		// Void SetEdgeMode(HGSMAAMode)
		void HG::Rendering::Runtime::HGSMAA::SetEdgeMode(HGSMAA *this, HGSMAAMode__Enum mode, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2700, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2700, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_2((ILFixDynamicMethodWrapper_30 *)Patch, (Object *)this, mode, 0LL);
		  }
		  else
		  {
		    this->fields.m_edgeMode = mode;
		  }
		}
		
		public void SetBlendWeightsMode(HGSMAAMode mode) {} // 0x0000000189B6D5D8-0x0000000189B6D630
		// Void SetBlendWeightsMode(HGSMAAMode)
		void HG::Rendering::Runtime::HGSMAA::SetBlendWeightsMode(HGSMAA *this, HGSMAAMode__Enum mode, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2701, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2701, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_2((ILFixDynamicMethodWrapper_30 *)Patch, (Object *)this, mode, 0LL);
		  }
		  else
		  {
		    this->fields.m_blendMode = mode;
		  }
		}
		
	}
}
