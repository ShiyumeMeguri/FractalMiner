using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal static class WaterQualityHelper // TypeDefIndex: 38495
	{
		// Fields
		private const int MOBILE_RIPPLE_MIN_QUALITY_TIER = 5000; // Metadata: 0x02303D6A
	
		// Methods
		internal static bool ShouldUseWaterQualityLow() => default; // 0x0000000183A63770-0x0000000183A63890
		// Boolean ShouldUseWaterQualityLow()
		bool HG::Rendering::Runtime::WaterQualityHelper::ShouldUseWaterQualityLow(MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *static_fields; // rdx
		  struct ILFixDynamicMethodWrapper_2__Class *wrapperArray; // rcx
		  Object *instance; // rbx
		  Object__Class *klass; // rax
		  int32_t namespaze; // eax
		  Object__Class *v6; // rax
		  int32_t namespaze_high; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2 *v10; // rax
		  ILFixDynamicMethodWrapper_2 *v11; // rax
		
		  static_fields = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    static_fields = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (struct ILFixDynamicMethodWrapper_2__Class *)static_fields->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_21;
		  if ( SLODWORD(wrapperArray->_0.namespaze) > 1051 )
		  {
		    if ( !static_fields->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(static_fields);
		      static_fields = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    static_fields = (struct ILFixDynamicMethodWrapper_2__Class *)static_fields->static_fields->wrapperArray;
		    if ( !static_fields )
		      goto LABEL_21;
		    if ( LODWORD(static_fields->_0.namespaze) <= 0x41B )
		      goto LABEL_44;
		    if ( static_fields[22]._0.implementedInterfaces )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(1051, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_4((ILFixDynamicMethodWrapper_23 *)Patch, 0LL);
		      goto LABEL_21;
		    }
		  }
		  instance = (Object *)HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_instance(0LL);
		  if ( !instance )
		    goto LABEL_21;
		  wrapperArray = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    wrapperArray = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (struct ILFixDynamicMethodWrapper_2__Class *)wrapperArray->static_fields;
		  if ( !static_fields->_0.image )
		    goto LABEL_21;
		  if ( (int)static_fields->_0.image->typeCount <= 672 )
		    goto LABEL_10;
		  if ( !wrapperArray->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(wrapperArray);
		    wrapperArray = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (struct ILFixDynamicMethodWrapper_2__Class *)wrapperArray->static_fields->wrapperArray;
		  if ( !static_fields )
		    goto LABEL_21;
		  if ( LODWORD(static_fields->_0.namespaze) <= 0x2A0 )
		    goto LABEL_44;
		  if ( static_fields[14]._0.properties )
		  {
		    v10 = IFix::WrappersManagerImpl::GetPatch(672, 0LL);
		    if ( !v10 )
		      goto LABEL_21;
		    namespaze = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)v10, instance, 0LL);
		    wrapperArray = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  else
		  {
		LABEL_10:
		    klass = instance[1].klass;
		    if ( !klass )
		      goto LABEL_21;
		    namespaze = (int32_t)klass->_0.namespaze;
		  }
		  if ( namespaze != 3 )
		    return 0;
		  if ( !wrapperArray->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(wrapperArray);
		    wrapperArray = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (struct ILFixDynamicMethodWrapper_2__Class *)wrapperArray->static_fields->wrapperArray;
		  if ( !static_fields )
		    goto LABEL_21;
		  if ( SLODWORD(static_fields->_0.namespaze) <= 856 )
		    goto LABEL_17;
		  if ( !wrapperArray->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(wrapperArray);
		    wrapperArray = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (struct ILFixDynamicMethodWrapper_2__Class *)wrapperArray->static_fields->wrapperArray;
		  if ( !wrapperArray )
		LABEL_21:
		    sub_1800D8260(wrapperArray, static_fields);
		  if ( LODWORD(wrapperArray->_0.namespaze) <= 0x358 )
		LABEL_44:
		    sub_1800D2AB0(wrapperArray, static_fields);
		  if ( wrapperArray[18]._0.interopData )
		  {
		    v11 = IFix::WrappersManagerImpl::GetPatch(856, 0LL);
		    if ( v11 )
		    {
		      namespaze_high = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)v11, instance, 0LL);
		      return namespaze_high <= 2000;
		    }
		    goto LABEL_21;
		  }
		LABEL_17:
		  v6 = instance[1].klass;
		  if ( !v6 )
		    goto LABEL_21;
		  namespaze_high = HIDWORD(v6->_0.namespaze);
		  return namespaze_high <= 2000;
		}
		
		internal static bool ShouldDisableMobileRipple() => default; // 0x0000000183C04E40-0x0000000183C04F00
		// Boolean ShouldDisableMobileRipple()
		bool HG::Rendering::Runtime::WaterQualityHelper::ShouldDisableMobileRipple(MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *static_fields; // rdx
		  int *wrapperArray; // rcx
		  Object *instance; // rbx
		  struct ILFixDynamicMethodWrapper_2__Class *v4; // rax
		  Object__Class *klass; // rax
		  int32_t namespaze; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2 *v9; // rax
		
		  static_fields = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    static_fields = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (int *)static_fields->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_14;
		  if ( wrapperArray[6] > 964 )
		  {
		    if ( !static_fields->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(static_fields);
		      static_fields = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    static_fields = (struct ILFixDynamicMethodWrapper_2__Class *)static_fields->static_fields->wrapperArray;
		    if ( !static_fields )
		      goto LABEL_14;
		    if ( LODWORD(static_fields->_0.namespaze) <= 0x3C4 )
		      goto LABEL_29;
		    if ( *(_QWORD *)&static_fields[20]._1.cctor_finished_or_no_cctor )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(964, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_4((ILFixDynamicMethodWrapper_23 *)Patch, 0LL);
		      goto LABEL_14;
		    }
		  }
		  instance = (Object *)HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_instance(0LL);
		  if ( !instance )
		    goto LABEL_14;
		  v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (struct ILFixDynamicMethodWrapper_2__Class *)v4->static_fields;
		  wrapperArray = (int *)static_fields->_0.image;
		  if ( !static_fields->_0.image )
		    goto LABEL_14;
		  if ( wrapperArray[6] <= 672 )
		    goto LABEL_10;
		  if ( !v4->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v4);
		    v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (int *)v4->static_fields->wrapperArray;
		  if ( !wrapperArray )
		LABEL_14:
		    sub_1800D8260(wrapperArray, static_fields);
		  if ( (unsigned int)wrapperArray[6] <= 0x2A0 )
		LABEL_29:
		    sub_1800D2AB0(wrapperArray, static_fields);
		  if ( *((_QWORD *)wrapperArray + 676) )
		  {
		    v9 = IFix::WrappersManagerImpl::GetPatch(672, 0LL);
		    if ( v9 )
		    {
		      namespaze = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)v9, instance, 0LL);
		      return namespaze == 1
		          && HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_currentDeviceTier(
		               (HGRenderPipelineSettingHub *)instance,
		               0LL) >= 0
		          && HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_currentDeviceTier(
		               (HGRenderPipelineSettingHub *)instance,
		               0LL) < 5000;
		    }
		    goto LABEL_14;
		  }
		LABEL_10:
		  klass = instance[1].klass;
		  if ( !klass )
		    goto LABEL_14;
		  namespaze = (int32_t)klass->_0.namespaze;
		  return namespaze == 1
		      && HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_currentDeviceTier(
		           (HGRenderPipelineSettingHub *)instance,
		           0LL) >= 0
		      && HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_currentDeviceTier(
		           (HGRenderPipelineSettingHub *)instance,
		           0LL) < 5000;
		}
		
	}
}
