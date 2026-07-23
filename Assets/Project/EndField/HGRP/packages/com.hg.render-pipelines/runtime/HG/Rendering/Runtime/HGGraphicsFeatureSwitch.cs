using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGGraphicsFeatureSwitch : IHGGraphicsFeatureSwitch // TypeDefIndex: 37531
	{
		// Fields
		private bool m_defaultValue; // 0x10
	
		// Properties
		public bool enabled { get => default; } // 0x0000000183335D90-0x0000000183335DF0 
		// Boolean get_enabled()
		bool HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabled(HGGraphicsFeatureSwitch *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 412 )
		    return this->fields.m_defaultValue;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x19C )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[8].vtable.Equals.method )
		    return this->fields.m_defaultValue;
		  Patch = IFix::WrappersManagerImpl::GetPatch(412, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		public bool enabledForCPUCommands { get => default; } // 0x0000000189C6EBB0-0x0000000189C6EBFC 
		// Boolean get_enabledForCPUCommands()
		bool HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(
		        HGGraphicsFeatureSwitch *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(413, 0LL) )
		    return this->fields.m_defaultValue;
		  Patch = IFix::WrappersManagerImpl::GetPatch(413, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
	
		// Constructors
		public HGGraphicsFeatureSwitch() {} // Dummy constructor
		public HGGraphicsFeatureSwitch(bool defaultValue = true /* Metadata: 0x02302EFF */) {} // 0x0000000184D86130-0x0000000184D86140
		// Void set_override(Boolean)
		void HG::Rendering::Runtime::ScalableSettingValue<bool>::set_override(
		        ScalableSettingValue_1_System_Boolean_ *this,
		        bool value,
		        MethodInfo *method)
		{
		  this->fields.m_Override = value;
		}
		
	}
}
