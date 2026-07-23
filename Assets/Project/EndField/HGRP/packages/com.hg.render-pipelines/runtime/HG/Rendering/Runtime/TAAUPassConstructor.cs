using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class TAAUPassConstructor : IPassConstructor // TypeDefIndex: 38439
	{
		// Fields
		private float[] m_gaussianKernel; // 0x10
		private float m_gaussianKernelStdDev; // 0x18
		private Material[] m_taauPassMaterials; // 0x20
		private TAAUConstants m_constants; // 0x2C
		private TextureHandle m_historyDilatedSceneDepth; // 0xEC
		private TextureHandle m_historyDilatedSceneMV; // 0xFC
		private RTNames[] m_rtNames; // 0x110
		private static readonly RenderFunc<DilationPassData> s_dilationRenderFunc; // 0x00
		private static readonly RenderFunc<MaskDilationPassData> s_maskDilationRenderFunc; // 0x08
		private static readonly RenderFunc<ResolvePassData> s_resolveRenderFunc; // 0x10
	
		// Properties
		private float historyWeight { get => default; set {} } // 0x0000000189BD3AA0-0x0000000189BD3AF0 0x0000000189BD4240-0x0000000189BD429C
		// Single get_historyWeight()
		float HG::Rendering::Runtime::TAAUPassConstructor::get_historyWeight(TAAUPassConstructor *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3351, 0LL) )
		    return this->fields.m_constants.taauParameters0.z;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3351, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		}
		

		// Void set_historyWeight(Single)
		void HG::Rendering::Runtime::TAAUPassConstructor::set_historyWeight(
		        TAAUPassConstructor *this,
		        float value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3352, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3352, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    this->fields.m_constants.taauParameters0.z = value;
		  }
		}
		
		private float historyWeightInMotion { get => default; set {} } // 0x0000000189BD3A50-0x0000000189BD3AA0 0x0000000189BD41E4-0x0000000189BD4240
		// Single get_historyWeightInMotion()
		float HG::Rendering::Runtime::TAAUPassConstructor::get_historyWeightInMotion(
		        TAAUPassConstructor *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3353, 0LL) )
		    return this->fields.m_constants.taauParameters0.w;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3353, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		}
		

		// Void set_historyWeightInMotion(Single)
		void HG::Rendering::Runtime::TAAUPassConstructor::set_historyWeightInMotion(
		        TAAUPassConstructor *this,
		        float value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3354, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3354, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    this->fields.m_constants.taauParameters0.w = value;
		  }
		}
		
		private float forceClampHistoryWeight { get => default; set {} } // 0x0000000189BD3A00-0x0000000189BD3A50 0x0000000189BD4110-0x0000000189BD416C
		// Single get_forceClampHistoryWeight()
		float HG::Rendering::Runtime::TAAUPassConstructor::get_forceClampHistoryWeight(
		        TAAUPassConstructor *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3355, 0LL) )
		    return this->fields.m_constants.taauParameters2.y;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3355, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		}
		

		// Void set_forceClampHistoryWeight(Single)
		void HG::Rendering::Runtime::TAAUPassConstructor::set_forceClampHistoryWeight(
		        TAAUPassConstructor *this,
		        float value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3356, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3356, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    this->fields.m_constants.taauParameters2.y = value;
		  }
		}
		
		private float forceClampHistoryWeightInMotion { get => default; set {} } // 0x0000000189BD39B0-0x0000000189BD3A00 0x0000000189BD40B4-0x0000000189BD4110
		// Single get_forceClampHistoryWeightInMotion()
		float HG::Rendering::Runtime::TAAUPassConstructor::get_forceClampHistoryWeightInMotion(
		        TAAUPassConstructor *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3357, 0LL) )
		    return this->fields.m_constants.taauParameters3.x;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3357, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		}
		

		// Void set_forceClampHistoryWeightInMotion(Single)
		void HG::Rendering::Runtime::TAAUPassConstructor::set_forceClampHistoryWeightInMotion(
		        TAAUPassConstructor *this,
		        float value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3358, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3358, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    this->fields.m_constants.taauParameters3.x = value;
		  }
		}
		
		private float sharpenStrength { get => default; set {} } // 0x0000000189BD3D70-0x0000000189BD3DC0 0x0000000189BD4520-0x0000000189BD457C
		// Single get_sharpenStrength()
		float HG::Rendering::Runtime::TAAUPassConstructor::get_sharpenStrength(TAAUPassConstructor *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3359, 0LL) )
		    return this->fields.m_constants.taauParameters1.z;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3359, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		}
		

		// Void set_sharpenStrength(Single)
		void HG::Rendering::Runtime::TAAUPassConstructor::set_sharpenStrength(
		        TAAUPassConstructor *this,
		        float value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3360, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3360, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    this->fields.m_constants.taauParameters1.z = value;
		  }
		}
		
		private float firstFrame { get => default; set {} } // 0x0000000189BD3960-0x0000000189BD39B0 0x0000000189BD4058-0x0000000189BD40B4
		// Single get_firstFrame()
		float HG::Rendering::Runtime::TAAUPassConstructor::get_firstFrame(TAAUPassConstructor *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3361, 0LL) )
		    return this->fields.m_constants.taauParameters1.w;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3361, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		}
		

		// Void set_firstFrame(Single)
		void HG::Rendering::Runtime::TAAUPassConstructor::set_firstFrame(
		        TAAUPassConstructor *this,
		        float value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3362, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3362, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    this->fields.m_constants.taauParameters1.w = value;
		  }
		}
		
		private float occlusionDepthDiff { get => default; set {} } // 0x0000000189BD3CD0-0x0000000189BD3D20 0x0000000189BD4468-0x0000000189BD44C4
		// Single get_occlusionDepthDiff()
		float HG::Rendering::Runtime::TAAUPassConstructor::get_occlusionDepthDiff(
		        TAAUPassConstructor *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3363, 0LL) )
		    return this->fields.m_constants.taauParameters1.y;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3363, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		}
		

		// Void set_occlusionDepthDiff(Single)
		void HG::Rendering::Runtime::TAAUPassConstructor::set_occlusionDepthDiff(
		        TAAUPassConstructor *this,
		        float value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3364, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3364, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    this->fields.m_constants.taauParameters1.y = value;
		  }
		}
		
		private float minMVConsideredDynamic { get => default; set {} } // 0x0000000189BD3C80-0x0000000189BD3CD0 0x0000000189BD440C-0x0000000189BD4468
		// Single get_minMVConsideredDynamic()
		float HG::Rendering::Runtime::TAAUPassConstructor::get_minMVConsideredDynamic(
		        TAAUPassConstructor *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3365, 0LL) )
		    return this->fields.m_constants.taauParameters3.y;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3365, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		}
		

		// Void set_minMVConsideredDynamic(Single)
		void HG::Rendering::Runtime::TAAUPassConstructor::set_minMVConsideredDynamic(
		        TAAUPassConstructor *this,
		        float value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3366, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3366, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    this->fields.m_constants.taauParameters3.y = value;
		  }
		}
		
		private float maxMVConsideredDynamic { get => default; set {} } // 0x0000000189BD3BE0-0x0000000189BD3C30 0x0000000189BD4354-0x0000000189BD43B0
		// Single get_maxMVConsideredDynamic()
		float HG::Rendering::Runtime::TAAUPassConstructor::get_maxMVConsideredDynamic(
		        TAAUPassConstructor *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3367, 0LL) )
		    return this->fields.m_constants.taauParameters3.z;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3367, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		}
		

		// Void set_maxMVConsideredDynamic(Single)
		void HG::Rendering::Runtime::TAAUPassConstructor::set_maxMVConsideredDynamic(
		        TAAUPassConstructor *this,
		        float value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3368, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3368, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    this->fields.m_constants.taauParameters3.z = value;
		  }
		}
		
		private float characterMotionSensitivity { get => default; set {} } // 0x0000000189BD3820-0x0000000189BD3870 0x0000000189BD3EE8-0x0000000189BD3F44
		// Single get_characterMotionSensitivity()
		float HG::Rendering::Runtime::TAAUPassConstructor::get_characterMotionSensitivity(
		        TAAUPassConstructor *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3369, 0LL) )
		    return this->fields.m_constants.taauParameters3.w;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3369, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		}
		

		// Void set_characterMotionSensitivity(Single)
		void HG::Rendering::Runtime::TAAUPassConstructor::set_characterMotionSensitivity(
		        TAAUPassConstructor *this,
		        float value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3370, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3370, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    this->fields.m_constants.taauParameters3.w = value;
		  }
		}
		
		public float fastConvergeState { get => default; set {} } // 0x0000000189BD3910-0x0000000189BD3960 0x0000000189BD3FFC-0x0000000189BD4058
		// Single get_fastConvergeState()
		float HG::Rendering::Runtime::TAAUPassConstructor::get_fastConvergeState(TAAUPassConstructor *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3371, 0LL) )
		    return this->fields.m_constants.taauParameters2.w;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3371, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		}
		

		// Void set_fastConvergeState(Single)
		void HG::Rendering::Runtime::TAAUPassConstructor::set_fastConvergeState(
		        TAAUPassConstructor *this,
		        float value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3372, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3372, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    this->fields.m_constants.taauParameters2.w = value;
		  }
		}
		
		private float minMVConsideredDynamicChar { get => default; set {} } // 0x0000000189BD3C30-0x0000000189BD3C80 0x0000000189BD43B0-0x0000000189BD440C
		// Single get_minMVConsideredDynamicChar()
		float HG::Rendering::Runtime::TAAUPassConstructor::get_minMVConsideredDynamicChar(
		        TAAUPassConstructor *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3373, 0LL) )
		    return this->fields.m_constants.taauParameters4.y;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3373, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		}
		

		// Void set_minMVConsideredDynamicChar(Single)
		void HG::Rendering::Runtime::TAAUPassConstructor::set_minMVConsideredDynamicChar(
		        TAAUPassConstructor *this,
		        float value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3374, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3374, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    this->fields.m_constants.taauParameters4.y = value;
		  }
		}
		
		private float maxMVConsideredDynamicChar { get => default; set {} } // 0x0000000189BD3B90-0x0000000189BD3BE0 0x0000000189BD42F8-0x0000000189BD4354
		// Single get_maxMVConsideredDynamicChar()
		float HG::Rendering::Runtime::TAAUPassConstructor::get_maxMVConsideredDynamicChar(
		        TAAUPassConstructor *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3375, 0LL) )
		    return this->fields.m_constants.taauParameters4.z;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3375, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		}
		

		// Void set_maxMVConsideredDynamicChar(Single)
		void HG::Rendering::Runtime::TAAUPassConstructor::set_maxMVConsideredDynamicChar(
		        TAAUPassConstructor *this,
		        float value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3376, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3376, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    this->fields.m_constants.taauParameters4.z = value;
		  }
		}
		
		private float fastConvergeHistoryWeight { get => default; set {} } // 0x0000000189BD38C0-0x0000000189BD3910 0x0000000189BD3FA0-0x0000000189BD3FFC
		// Single get_fastConvergeHistoryWeight()
		float HG::Rendering::Runtime::TAAUPassConstructor::get_fastConvergeHistoryWeight(
		        TAAUPassConstructor *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3377, 0LL) )
		    return this->fields.m_constants.taauParameters4.x;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3377, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		}
		

		// Void set_fastConvergeHistoryWeight(Single)
		void HG::Rendering::Runtime::TAAUPassConstructor::set_fastConvergeHistoryWeight(
		        TAAUPassConstructor *this,
		        float value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3378, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3378, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    this->fields.m_constants.taauParameters4.x = value;
		  }
		}
		
		private float responsiveAAHistoryWeight { get => default; set {} } // 0x0000000189BD3D20-0x0000000189BD3D70 0x0000000189BD44C4-0x0000000189BD4520
		// Single get_responsiveAAHistoryWeight()
		float HG::Rendering::Runtime::TAAUPassConstructor::get_responsiveAAHistoryWeight(
		        TAAUPassConstructor *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3379, 0LL) )
		    return this->fields.m_constants.taauParameters2.z;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3379, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		}
		

		// Void set_responsiveAAHistoryWeight(Single)
		void HG::Rendering::Runtime::TAAUPassConstructor::set_responsiveAAHistoryWeight(
		        TAAUPassConstructor *this,
		        float value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3380, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3380, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    this->fields.m_constants.taauParameters2.z = value;
		  }
		}
		
		private float inputSampleLumaWeight { get => default; set {} } // 0x0000000189BD3AF0-0x0000000189BD3B40 0x0000000189BD429C-0x0000000189BD42F8
		// Single get_inputSampleLumaWeight()
		float HG::Rendering::Runtime::TAAUPassConstructor::get_inputSampleLumaWeight(
		        TAAUPassConstructor *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3381, 0LL) )
		    return this->fields.m_constants.taauParameters4.w;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3381, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		}
		

		// Void set_inputSampleLumaWeight(Single)
		void HG::Rendering::Runtime::TAAUPassConstructor::set_inputSampleLumaWeight(
		        TAAUPassConstructor *this,
		        float value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3382, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3382, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    this->fields.m_constants.taauParameters4.w = value;
		  }
		}
		
		private float taauScaleFactor { get => default; set {} } // 0x0000000189BD3DC0-0x0000000189BD3E10 0x0000000189BD457C-0x0000000189BD4618
		// Single get_taauScaleFactor()
		float HG::Rendering::Runtime::TAAUPassConstructor::get_taauScaleFactor(TAAUPassConstructor *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3383, 0LL) )
		    return this->fields.m_constants.taauParameters0.x;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3383, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		}
		

		// Void set_taauScaleFactor(Single)
		void HG::Rendering::Runtime::TAAUPassConstructor::set_taauScaleFactor(
		        TAAUPassConstructor *this,
		        float value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3384, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3384, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    this->fields.m_constants.taauParameters0.x = value;
		    this->fields.m_constants.taauParameters8.x = value;
		    this->fields.m_constants.taauParameters0.y = 1.0 / value;
		    this->fields.m_constants.taauParameters8.z = 1.0 / value;
		    this->fields.m_constants.taauParameters8.y = value;
		    this->fields.m_constants.taauParameters8.w = 1.0 / value;
		  }
		}
		
		private float invScaleFactor { get => default; } // 0x0000000189BD3B40-0x0000000189BD3B90 
		// Single get_invScaleFactor()
		float HG::Rendering::Runtime::TAAUPassConstructor::get_invScaleFactor(TAAUPassConstructor *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3385, 0LL) )
		    return this->fields.m_constants.taauParameters0.y;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3385, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		}
		
		private float enableResponsiveTransparency { get => default; set {} } // 0x0000000189BD3870-0x0000000189BD38C0 0x0000000189BD3F44-0x0000000189BD3FA0
		// Single get_enableResponsiveTransparency()
		float HG::Rendering::Runtime::TAAUPassConstructor::get_enableResponsiveTransparency(
		        TAAUPassConstructor *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3386, 0LL) )
		    return this->fields.m_constants.taauParameters5.x;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3386, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		}
		

		// Void set_enableResponsiveTransparency(Single)
		void HG::Rendering::Runtime::TAAUPassConstructor::set_enableResponsiveTransparency(
		        TAAUPassConstructor *this,
		        float value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3387, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3387, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    this->fields.m_constants.taauParameters5.x = value;
		  }
		}
		
		private Vector4 LRSize { get => default; set {} } // 0x0000000189BD37B8-0x0000000189BD3820 0x0000000189BD3E7C-0x0000000189BD3EE8
		// Vector4 get_LRSize()
		Vector4 *HG::Rendering::Runtime::TAAUPassConstructor::get_LRSize(
		        Vector4 *__return_ptr retstr,
		        TAAUPassConstructor *this,
		        MethodInfo *method)
		{
		  Vector4 taauParameters6; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 *result; // rax
		  Vector4 v10; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3388, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3388, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    taauParameters6 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_350(&v10, Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    taauParameters6 = this->fields.m_constants.taauParameters6;
		  }
		  result = retstr;
		  *retstr = taauParameters6;
		  return result;
		}
		

		// Void set_LRSize(Vector4)
		void HG::Rendering::Runtime::TAAUPassConstructor::set_LRSize(
		        TAAUPassConstructor *this,
		        Vector4 *value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v8; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3389, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3389, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v8 = *value;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_958(Patch, (Object *)this, &v8, 0LL);
		  }
		  else
		  {
		    this->fields.m_constants.taauParameters6 = *value;
		  }
		}
		
		private Vector4 HRSize { get => default; set {} } // 0x0000000189BD3750-0x0000000189BD37B8 0x0000000189BD3E10-0x0000000189BD3E7C
		// Vector4 get_HRSize()
		Vector4 *HG::Rendering::Runtime::TAAUPassConstructor::get_HRSize(
		        Vector4 *__return_ptr retstr,
		        TAAUPassConstructor *this,
		        MethodInfo *method)
		{
		  Vector4 taauParameters7; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 *result; // rax
		  Vector4 v10; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3390, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3390, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    taauParameters7 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_350(&v10, Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    taauParameters7 = this->fields.m_constants.taauParameters7;
		  }
		  result = retstr;
		  *retstr = taauParameters7;
		  return result;
		}
		

		// Void set_HRSize(Vector4)
		void HG::Rendering::Runtime::TAAUPassConstructor::set_HRSize(
		        TAAUPassConstructor *this,
		        Vector4 *value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v8; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3391, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3391, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v8 = *value;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_958(Patch, (Object *)this, &v8, 0LL);
		  }
		  else
		  {
		    this->fields.m_constants.taauParameters7 = *value;
		  }
		}
		
		private bool prevTAAUState { get; set; } // 0x00000001811F33C0-0x00000001811F33D0 0x00000001811F33D0-0x00000001811F33E0
		// Boolean get_isRunning()
		bool UnityEngine::UIElements::Experimental::ValueAnimation<UnityEngine::UIElements::Experimental::StyleValues>::get_isRunning(
		        ValueAnimation_1_StyleValues_ *this,
		        MethodInfo *method)
		{
		  return this->fields._isRunning_k__BackingField;
		}
		

		// Void set_isRunning(Boolean)
		void UnityEngine::UIElements::Experimental::ValueAnimation<UnityEngine::UIElements::Experimental::StyleValues>::set_isRunning(
		        ValueAnimation_1_StyleValues_ *this,
		        bool value,
		        MethodInfo *method)
		{
		  this->fields._isRunning_k__BackingField = value;
		}
		
		private float gaussianKernelStdDev { get => default; set {} } // 0x00000001845A8DE0-0x00000001845A8E10 0x0000000189BD416C-0x0000000189BD41E4
		// Single get_gaussianKernelStdDev()
		float HG::Rendering::Runtime::TAAUPassConstructor::get_gaussianKernelStdDev(
		        TAAUPassConstructor *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3392, 0LL) )
		    return this->fields.m_gaussianKernelStdDev;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3392, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		}
		

		// Void set_gaussianKernelStdDev(Single)
		void HG::Rendering::Runtime::TAAUPassConstructor::set_gaussianKernelStdDev(
		        TAAUPassConstructor *this,
		        float value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3393, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3393, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    this->fields.m_gaussianKernelStdDev = value;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor);
		    HG::Rendering::Runtime::TAAUPassConstructor::ComputeGaussianKernel(value, &this->fields.m_gaussianKernel, 0LL);
		  }
		}
		
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 38429
		{
			// Fields
			internal TextureHandle sceneColor; // 0x00
			internal TextureHandle sceneDepth; // 0x10
			internal TextureHandle utilityDepth; // 0x20
			internal TextureHandle sceneMV; // 0x30
			internal TextureHandle historySceneColor; // 0x40
			internal Vector2Int renderSize; // 0x50
			internal Vector2Int screenSize; // 0x58
			internal float renderingScale; // 0x60
			internal float historyWeight; // 0x64
			internal float historyWeightInMotion; // 0x68
			internal float fastConvergeHistoryWeight; // 0x6C
			internal float responsiveAAHistoryWeight; // 0x70
			internal float minMVConsideredDynamic; // 0x74
			internal float maxMVConsideredDynamic; // 0x78
			internal float characterMotionSensitivity; // 0x7C
			internal float occlusionDepthDiff; // 0x80
			internal float inputSampleLumaWeight; // 0x84
			internal float sharpenStrength1K; // 0x88
			internal float sharpenStrength2K; // 0x8C
			internal float sharpenStrength4K; // 0x90
			internal float enableResponsiveTransparency; // 0x94
			internal TAAUQuality quality; // 0x98
			internal int renderPathFrameIndex; // 0x9C
			internal bool enableTAAU; // 0xA0
			internal bool fastConvergeState; // 0xA1
		}
	
		internal struct PassOutput // TypeDefIndex: 38430
		{
			// Fields
			internal TextureHandle currentSceneColor; // 0x00
		}
	
		private struct TAAUConstants // TypeDefIndex: 38431
		{
			// Fields
			public Vector4 taauParameters0; // 0x00
			public Vector4 taauParameters1; // 0x10
			public Vector4 taauParameters2; // 0x20
			public Vector4 taauParameters3; // 0x30
			public Vector4 taauParameters4; // 0x40
			public Vector4 taauParameters5; // 0x50
			public Vector4 taauParameters6; // 0x60
			public Vector4 taauParameters7; // 0x70
			public Vector4 taauParameters8; // 0x80
			public Vector4 kernelWeights0; // 0x90
			public Vector4 kernelWeights1; // 0xA0
			public Vector4 kernelWeights2; // 0xB0
		}
	
		private class DilationPassData // TypeDefIndex: 38432
		{
			// Fields
			internal TextureHandle sceneDepth; // 0x10
			internal TextureHandle sceneMV; // 0x20
			internal TextureHandle currDilatedSceneDepth; // 0x30
			internal TextureHandle currDilatedSceneMV; // 0x40
			internal TextureHandle historyDilatedSceneDepth; // 0x50
			internal TextureHandle historyDilatedSceneMV; // 0x60
			internal Material material; // 0x70
	
			// Constructors
			public DilationPassData() {} // 0x00000001841E1670-0x00000001841E1680
			// Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
			void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			        HGWindConfig *cSrc,
			        HGWindConfig *cDst,
			        float t,
			        MethodInfo *method)
			{
			  ;
			}
			
		}
	
		private class MaskDilationPassData // TypeDefIndex: 38433
		{
			// Fields
			internal TextureHandle currDilatedMask; // 0x10
			internal Material material; // 0x20
	
			// Constructors
			public MaskDilationPassData() {} // 0x00000001841E1670-0x00000001841E1680
			// Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
			void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			        HGWindConfig *cSrc,
			        HGWindConfig *cDst,
			        float t,
			        MethodInfo *method)
			{
			  ;
			}
			
		}
	
		private class ResolvePassData // TypeDefIndex: 38434
		{
			// Fields
			internal TextureHandle sceneColor; // 0x10
			internal TextureHandle sceneDepth; // 0x20
			internal TextureHandle sceneMV; // 0x30
			internal TextureHandle historySceneColor; // 0x40
			internal TAAUQuality quality; // 0x50
			internal Material material; // 0x58
	
			// Constructors
			public ResolvePassData() {} // 0x00000001841E1670-0x00000001841E1680
			// Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
			void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			        HGWindConfig *cSrc,
			        HGWindConfig *cDst,
			        float t,
			        MethodInfo *method)
			{
			  ;
			}
			
		}
	
		private struct RTNames // TypeDefIndex: 38435
		{
			// Fields
			internal string dilatedDepthRTName; // 0x00
			internal string dilatedMVRTName; // 0x08
			internal string taauResultRTName; // 0x10
		}
	
		private enum TAAUPass // TypeDefIndex: 38436
		{
			DilationDepthReprojection = 0,
			MaskDilation = 1,
			FlickerDetection = 2,
			Resolve = 3,
			Count = 4
		}
	
		private struct SharpenStrengthParam // TypeDefIndex: 38437
		{
			// Fields
			public float sharpen1K; // 0x00
			public float sharpen2K; // 0x04
			public float sharpen4K; // 0x08
		}
	
		// Constructors
		public TAAUPassConstructor() {} // Dummy constructor
		internal TAAUPassConstructor(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources) {} // 0x00000001845A8A20-0x00000001845A8DE0
		// TAAUPassConstructor(HGRenderPipelineMaterialCollector, HGRenderPathBase+HGRenderPathResources)
		void HG::Rendering::Runtime::TAAUPassConstructor::TAAUPassConstructor(
		        TAAUPassConstructor *this,
		        HGRenderPipelineMaterialCollector *materialCollector,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  HGRuntimeGrassQuery_Node *v10; // rdx
		  HGRuntimeGrassQuery_Node *v11; // r8
		  Int32__Array **v12; // r9
		  HGRuntimeGrassQuery_Node *v13; // rdx
		  HGRuntimeGrassQuery_Node *v14; // r8
		  Int32__Array **v15; // r9
		  HGRuntimeGrassQuery_Node *v16; // rdx
		  HGRuntimeGrassQuery_Node *v17; // r8
		  HGRuntimeGrassQuery_Node *v18; // rdx
		  HGRuntimeGrassQuery_Node *v19; // r8
		  HGRuntimeGrassQuery_Node *v20; // rdx
		  Single__Array *m_gaussianKernel; // rcx
		  HGRuntimeGrassQuery_Node *v22; // r8
		  Int32__Array **v23; // r9
		  __int64 v24; // r10
		  HGRuntimeGrassQuery_Node *v25; // rdx
		  HGRuntimeGrassQuery_Node *v26; // r8
		  Int32__Array **v27; // r9
		  HGRuntimeGrassQuery_Node *v28; // rdx
		  HGRuntimeGrassQuery_Node *v29; // r8
		  HGRuntimeGrassQuery_Node *v30; // rdx
		  HGRuntimeGrassQuery_Node *v31; // r8
		  HGRuntimeGrassQuery_Node *v32; // r8
		  Int32__Array **v33; // r9
		  __int64 v34; // r10
		  TAAUPassConstructor_RTNames__Array *v35; // r10
		  HGRuntimeGrassQuery_Node *v36; // rdx
		  HGRuntimeGrassQuery_Node *v37; // r8
		  Int32__Array **v38; // r9
		  float gaussianKernelStdDev; // xmm6_4
		  float v40; // xmm2_4
		  float v41; // xmm3_4
		  float v42; // xmm1_4
		  float v43; // xmm2_4
		  float v44; // xmm3_4
		  float v45; // xmm1_4
		  Vector4 v46; // xmm1
		  Vector4 v47; // xmm0
		  Vector4 v48; // xmm1
		  Vector4 v49; // xmm0
		  Vector4 v50; // xmm1
		  Vector4 v51; // xmm0
		  Vector4 v52; // xmm1
		  Vector4 v53; // xmm0
		  Vector4 v54; // xmm1
		  Vector4 v55; // xmm0
		  _BYTE v56[24]; // [rsp+20h] [rbp-E0h] BYREF
		  Vector4 si128; // [rsp+40h] [rbp-C0h]
		  __m128i v58; // [rsp+50h] [rbp-B0h]
		  __m128i v59; // [rsp+60h] [rbp-A0h]
		  __m128i v60; // [rsp+70h] [rbp-90h]
		  __m128i v61; // [rsp+80h] [rbp-80h]
		  __m128i v62; // [rsp+90h] [rbp-70h]
		  Vector4 v63; // [rsp+A0h] [rbp-60h]
		  Vector4 v64; // [rsp+B0h] [rbp-50h]
		  __m128i v65; // [rsp+C0h] [rbp-40h]
		  Vector4 v66; // [rsp+D0h] [rbp-30h]
		  Vector4 v67; // [rsp+E0h] [rbp-20h]
		  Vector4 v68; // [rsp+F0h] [rbp-10h]
		
		  this->fields.m_gaussianKernel = (Single__Array *)il2cpp_array_new_specific_1(TypeInfo::System::Single, 9LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v7, v8, v9, *(MethodInfo **)v56);
		  this->fields.m_gaussianKernelStdDev = 1.0;
		  this->fields.m_taauPassMaterials = (Material__Array *)il2cpp_array_new_specific_1(
		                                                          TypeInfo::UnityEngine::Material,
		                                                          4LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_taauPassMaterials, v10, v11, v12, *(MethodInfo **)v56);
		  il2cpp_array_new_specific_1(TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor::RTNames, 2LL);
		  *(_QWORD *)v56 = "DilatedDepth0";
		  *(_OWORD *)&v56[8] = 0LL;
		  ((void (__stdcall *)(HGRuntimeGrassQuery_Node *, HGRuntimeGrassQuery_Node *, HGRuntimeGrassQuery_Node *, Int32__Array **))sub_18002D1B0)(
		    (HGRuntimeGrassQuery_Node *)v56,
		    v13,
		    v14,
		    v15);
		  *(_QWORD *)&v56[8] = "DilatedMV0";
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v56[8], v16, v17, (Int32__Array **)"DilatedMV0", *(MethodInfo **)v56);
		  *(_QWORD *)&v56[16] = "TAAUResult0";
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v56[16], v18, v19, (Int32__Array **)"TAAUResult0", *(MethodInfo **)v56);
		  if ( !v24 )
		    goto LABEL_2;
		  if ( !*(_DWORD *)(v24 + 24) )
		    goto LABEL_20;
		  *(_OWORD *)(v24 + 32) = *(_OWORD *)v56;
		  *(_QWORD *)(v24 + 48) = *(_QWORD *)&v56[16];
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)(v24 + 32), v20, v22, v23, *(MethodInfo **)v56);
		  *(_QWORD *)v56 = "DilatedDepth1";
		  *(_OWORD *)&v56[8] = 0LL;
		  ((void (__stdcall *)(HGRuntimeGrassQuery_Node *, HGRuntimeGrassQuery_Node *, HGRuntimeGrassQuery_Node *, Int32__Array **))sub_18002D1B0)(
		    (HGRuntimeGrassQuery_Node *)v56,
		    v25,
		    v26,
		    v27);
		  *(_QWORD *)&v56[8] = "DilatedMV1";
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v56[8], v28, v29, (Int32__Array **)"DilatedMV1", *(MethodInfo **)v56);
		  *(_QWORD *)&v56[16] = "TAAUResult1";
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v56[16], v30, v31, (Int32__Array **)"TAAUResult1", *(MethodInfo **)v56);
		  if ( *(_DWORD *)(v34 + 24) <= 1u )
		    goto LABEL_20;
		  *(_OWORD *)(v34 + 56) = *(_OWORD *)v56;
		  *(_QWORD *)(v34 + 72) = *(_QWORD *)&v56[16];
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)(v34 + 56), v20, v32, v33, *(MethodInfo **)v56);
		  this->fields.m_rtNames = v35;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_rtNames, v36, v37, v38, *(MethodInfo **)v56);
		  HG::Rendering::Runtime::TAAUPassConstructor::InitializeMaterials(
		    this,
		    materialCollector,
		    resources->defaultResources,
		    0LL);
		  gaussianKernelStdDev = HG::Rendering::Runtime::TAAUPassConstructor::get_gaussianKernelStdDev(this, 0LL);
		  if ( !TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor);
		  HG::Rendering::Runtime::TAAUPassConstructor::ComputeGaussianKernel(
		    gaussianKernelStdDev,
		    &this->fields.m_gaussianKernel,
		    0LL);
		  m_gaussianKernel = this->fields.m_gaussianKernel;
		  si128 = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18B959740);
		  v59 = _mm_load_si128((const __m128i *)&xmmword_18B959B60);
		  v58 = _mm_load_si128((const __m128i *)&xmmword_18B959B50);
		  v61 = _mm_load_si128((const __m128i *)&xmmword_18B959B30);
		  v60 = _mm_load_si128((const __m128i *)&xmmword_18B959B40);
		  v65 = _mm_load_si128((const __m128i *)&xmmword_18B959780);
		  v62 = _mm_load_si128((const __m128i *)&xmmword_18B9593A0);
		  v63 = (Vector4)v62;
		  v64 = (Vector4)v62;
		  if ( !m_gaussianKernel )
		LABEL_2:
		    sub_1800D8260(m_gaussianKernel, v20);
		  if ( !m_gaussianKernel->max_length.size )
		    goto LABEL_20;
		  v40 = m_gaussianKernel->vector[0];
		  if ( m_gaussianKernel->max_length.size <= 1u )
		    goto LABEL_20;
		  v41 = m_gaussianKernel->vector[1];
		  if ( m_gaussianKernel->max_length.size <= 2u )
		    goto LABEL_20;
		  v42 = m_gaussianKernel->vector[2];
		  if ( m_gaussianKernel->max_length.size <= 3u )
		    goto LABEL_20;
		  v66.w = m_gaussianKernel->vector[3];
		  *(_QWORD *)&v66.x = __PAIR64__(LODWORD(v41), LODWORD(v40));
		  v66.z = v42;
		  if ( m_gaussianKernel->max_length.size <= 4u
		    || (v43 = m_gaussianKernel->vector[4], m_gaussianKernel->max_length.size <= 5u)
		    || (v44 = m_gaussianKernel->vector[5], m_gaussianKernel->max_length.size <= 6u)
		    || (v45 = m_gaussianKernel->vector[6], m_gaussianKernel->max_length.size <= 7u)
		    || (v67.w = m_gaussianKernel->vector[7],
		        *(_QWORD *)&v67.x = __PAIR64__(LODWORD(v44), LODWORD(v43)),
		        v67.z = v45,
		        m_gaussianKernel->max_length.size <= 8u) )
		  {
		LABEL_20:
		    sub_1800D2AB0(m_gaussianKernel, v20);
		  }
		  v68.x = m_gaussianKernel->vector[8];
		  *(_QWORD *)&v68.y = 0LL;
		  v68.w = 0.0;
		  v46 = (Vector4)v58;
		  this->fields.m_constants.taauParameters0 = si128;
		  v47 = (Vector4)v59;
		  this->fields.m_constants.taauParameters1 = v46;
		  v48 = (Vector4)v60;
		  this->fields.m_constants.taauParameters2 = v47;
		  v49 = (Vector4)v61;
		  this->fields.m_constants.taauParameters3 = v48;
		  v50 = (Vector4)v62;
		  this->fields.m_constants.taauParameters4 = v49;
		  v51 = v63;
		  this->fields.m_constants.taauParameters5 = v50;
		  v52 = (Vector4)v65;
		  this->fields.m_constants.taauParameters6 = v51;
		  this->fields.m_constants.taauParameters7 = v64;
		  v53 = v66;
		  this->fields.m_constants.taauParameters8 = v52;
		  v54 = v67;
		  this->fields.m_constants.kernelWeights0 = v53;
		  v55 = v68;
		  this->fields.m_constants.kernelWeights1 = v54;
		  this->fields.m_constants.kernelWeights2 = v55;
		}
		
		static TAAUPassConstructor() {} // 0x0000000184B353D0-0x0000000184B35530
		// TAAUPassConstructor()
		void HG::Rendering::Runtime::TAAUPassConstructor::cctor(MethodInfo *method)
		{
		  struct TAAUPassConstructor_c__Class *v1; // rax
		  Object *v2; // rdi
		  RenderFunc_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  HGRuntimeGrassQuery_Node__Class *v6; // rbx
		  HGRuntimeGrassQuery_Node *static_fields; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  Object *v10; // rdi
		  RenderFunc_1_System_Object_ *v11; // rax
		  MonitorData *v12; // rbx
		  HGRuntimeGrassQuery_Node *v13; // rdx
		  HGRuntimeGrassQuery_Node *v14; // r8
		  Int32__Array **v15; // r9
		  Object *v16; // rdi
		  RenderFunc_1_System_Object_ *v17; // rax
		  RenderFunc_1_HG_Rendering_Runtime_TAAUPassConstructor_ResolvePassData_ *v18; // rbx
		  TAAUPassConstructor__StaticFields *v19; // rdx
		  HGRuntimeGrassQuery_Node *v20; // r8
		  Int32__Array **v21; // r9
		  MethodInfo *v22; // [rsp+20h] [rbp-8h]
		  MethodInfo *v23; // [rsp+20h] [rbp-8h]
		  MethodInfo *v24; // [rsp+50h] [rbp+28h]
		
		  v1 = TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::TAAUPassConstructor::DilationPassData>);
		  v6 = (HGRuntimeGrassQuery_Node__Class *)v3;
		  if ( !v3 )
		    goto LABEL_4;
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v3,
		    v2,
		    MethodInfo::HG::Rendering::Runtime::TAAUPassConstructor::__c::__cctor_b__102_0,
		    0LL);
		  static_fields = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor->static_fields;
		  static_fields->klass = v6;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor->static_fields,
		    static_fields,
		    v8,
		    v9,
		    v22);
		  v10 = (Object *)TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor::__c->static_fields->__9;
		  v11 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::TAAUPassConstructor::MaskDilationPassData>);
		  v12 = (MonitorData *)v11;
		  if ( !v11
		    || (HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		          v11,
		          v10,
		          MethodInfo::HG::Rendering::Runtime::TAAUPassConstructor::__c::__cctor_b__102_1,
		          0LL),
		        v13 = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor->static_fields,
		        v13->monitor = v12,
		        sub_18002D1B0(
		          (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor->static_fields->s_maskDilationRenderFunc,
		          v13,
		          v14,
		          v15,
		          v23),
		        v16 = (Object *)TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor::__c->static_fields->__9,
		        v17 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::TAAUPassConstructor::ResolvePassData>),
		        (v18 = (RenderFunc_1_HG_Rendering_Runtime_TAAUPassConstructor_ResolvePassData_ *)v17) == 0LL) )
		  {
		LABEL_4:
		    sub_1800D8260(v5, v4);
		  }
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v17,
		    v16,
		    MethodInfo::HG::Rendering::Runtime::TAAUPassConstructor::__c::__cctor_b__102_2,
		    0LL);
		  v19 = TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor->static_fields;
		  v19->s_resolveRenderFunc = v18;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor->static_fields->s_resolveRenderFunc,
		    (HGRuntimeGrassQuery_Node *)v19,
		    v20,
		    v21,
		    v24);
		}
		
	
		// Methods
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189BD32EC-0x0000000189BD3340
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::TAAUPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        TAAUPassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3395, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3395, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189BD3298-0x0000000189BD32EC
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::TAAUPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        TAAUPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3396, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3396, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189BD3180-0x0000000189BD3298
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::TAAUPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        TAAUPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  HGRenderGraph *renderGraph; // rdi
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  TextureHandle v9; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3397, 0LL) )
		  {
		    renderGraph = input->renderGraph;
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this->fields.m_historyDilatedSceneDepth, 0LL) )
		    {
		      if ( !renderGraph )
		        goto LABEL_9;
		      this->fields.m_historyDilatedSceneDepth = *HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
		                                                   &v9,
		                                                   renderGraph,
		                                                   &this->fields.m_historyDilatedSceneDepth,
		                                                   1,
		                                                   (String *)"TAAUPass",
		                                                   0LL);
		    }
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    if ( !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this->fields.m_historyDilatedSceneMV, 0LL) )
		      return;
		    if ( renderGraph )
		    {
		      this->fields.m_historyDilatedSceneMV = *HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
		                                                &v9,
		                                                renderGraph,
		                                                &this->fields.m_historyDilatedSceneMV,
		                                                1,
		                                                (String *)"TAAUPass",
		                                                0LL);
		      return;
		    }
		LABEL_9:
		    sub_1800D8260(v7, v6);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3397, 0LL);
		  if ( !Patch )
		    goto LABEL_9;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		}
		
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera camera) {} // 0x0000000189BD29EC-0x0000000189BD2AF0
		// Void ConstructPass(TAAUPassConstructor+PassInput ByRef, TAAUPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		void HG::Rendering::Runtime::TAAUPassConstructor::ConstructPass(
		        TAAUPassConstructor *this,
		        TAAUPassConstructor_PassInput *input,
		        TAAUPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  __int64 v10; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  TextureHandle v12; // [rsp+40h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3398, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3398, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v10);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1231(
		      Patch,
		      (Object *)this,
		      input,
		      output,
		      (Object *)renderGraph,
		      (Object *)camera,
		      0LL);
		  }
		  else
		  {
		    if ( input->enableTAAU )
		    {
		      HG::Rendering::Runtime::TAAUPassConstructor::PrepareParameters(this, input, renderGraph, 0LL);
		      HG::Rendering::Runtime::TAAUPassConstructor::ConstructTAAUPasses(this, input, output, renderGraph, 0LL);
		    }
		    else
		    {
		      *output = (TAAUPassConstructor_PassOutput)input->sceneColor;
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      this->fields.m_historyDilatedSceneDepth = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(
		                                                   &v12,
		                                                   0LL);
		      this->fields.m_historyDilatedSceneMV = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v12, 0LL);
		    }
		    this->fields._prevTAAUState_k__BackingField = input->enableTAAU;
		  }
		}
		
		private void InitializeMaterials(HGRenderPipelineMaterialCollector materialCollector, HGRenderPipelineRuntimeResources resource) {} // 0x00000001845A8E10-0x00000001845A90C0
		// Void InitializeMaterials(HGRenderPipelineMaterialCollector, HGRenderPipelineRuntimeResources)
		void HG::Rendering::Runtime::TAAUPassConstructor::InitializeMaterials(
		        TAAUPassConstructor *this,
		        HGRenderPipelineMaterialCollector *materialCollector,
		        HGRenderPipelineRuntimeResources *resource,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  struct Object_1__Class *v8; // rcx
		  Material__Array *m_taauPassMaterials; // rax
		  Material *v10; // rsi
		  Material__Array *v11; // rsi
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  Material *Material; // rax
		  Material *v14; // r14
		  Material__Array *v15; // rax
		  Material *v16; // rsi
		  Material__Array *v17; // rsi
		  HGRenderPipelineRuntimeResources_ShaderResources *v18; // rax
		  Material *v19; // rax
		  Material *v20; // r14
		  Material__Array *v21; // rax
		  Material *v22; // rsi
		  Material__Array *v23; // rbx
		  HGRenderPipelineRuntimeResources_ShaderResources *v24; // rax
		  Material *v25; // rax
		  Material *v26; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3407, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3407, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		        (ILFixDynamicMethodWrapper_30 *)Patch,
		        (Object *)this,
		        (Object *)materialCollector,
		        (Object *)resource,
		        0LL);
		      return;
		    }
		    goto LABEL_3;
		  }
		  m_taauPassMaterials = this->fields.m_taauPassMaterials;
		  if ( !m_taauPassMaterials )
		    goto LABEL_3;
		  if ( m_taauPassMaterials->max_length.size <= 1u )
		    goto LABEL_49;
		  v10 = m_taauPassMaterials->vector[1];
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  v8 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( !v10 )
		    goto LABEL_13;
		  v8 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( !v10->fields._.m_CachedPtr )
		  {
		LABEL_13:
		    v11 = this->fields.m_taauPassMaterials;
		    if ( !resource )
		      goto LABEL_3;
		    shaders = resource->fields.shaders;
		    if ( !shaders )
		      goto LABEL_3;
		    if ( !materialCollector )
		      goto LABEL_3;
		    Material = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                 materialCollector,
		                 shaders->fields.taauMaskDilationPS,
		                 0,
		                 0LL);
		    v14 = Material;
		    if ( !v11 )
		      goto LABEL_3;
		    sub_180031B10(v11, Material);
		    sub_1800020D0(v11, 1LL, v14);
		  }
		  v15 = this->fields.m_taauPassMaterials;
		  if ( !v15 )
		    goto LABEL_3;
		  if ( !v15->max_length.size )
		    goto LABEL_49;
		  v16 = v15->vector[0];
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  v8 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( !v16 )
		    goto LABEL_28;
		  v8 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( !v16->fields._.m_CachedPtr )
		  {
		LABEL_28:
		    v17 = this->fields.m_taauPassMaterials;
		    if ( !resource )
		      goto LABEL_3;
		    v18 = resource->fields.shaders;
		    if ( !v18 )
		      goto LABEL_3;
		    if ( !materialCollector )
		      goto LABEL_3;
		    v19 = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		            materialCollector,
		            v18->fields.taauDilationPS,
		            0,
		            0LL);
		    v20 = v19;
		    if ( !v17 )
		      goto LABEL_3;
		    sub_180031B10(v17, v19);
		    sub_1800020D0(v17, 0LL, v20);
		  }
		  v21 = this->fields.m_taauPassMaterials;
		  if ( !v21 )
		    goto LABEL_3;
		  if ( v21->max_length.size <= 3u )
		LABEL_49:
		    sub_1800D2AB0(v8, v7);
		  v22 = v21->vector[3];
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  v8 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( !v22 )
		    goto LABEL_43;
		  v8 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( !v22->fields._.m_CachedPtr )
		  {
		LABEL_43:
		    v23 = this->fields.m_taauPassMaterials;
		    if ( resource )
		    {
		      v24 = resource->fields.shaders;
		      if ( v24 )
		      {
		        if ( materialCollector )
		        {
		          v25 = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                  materialCollector,
		                  v24->fields.taauResolvePS,
		                  0,
		                  0LL);
		          v26 = v25;
		          if ( v23 )
		          {
		            sub_180031B10(v23, v25);
		            sub_1800020D0(v23, 3LL, v26);
		            return;
		          }
		        }
		      }
		    }
		LABEL_3:
		    sub_1800D8260(v8, v7);
		  }
		}
		
		private void PrepareParameters(ref PassInput input, HGRenderGraph renderGraph) {} // 0x0000000189BD3340-0x0000000189BD3750
		// Void PrepareParameters(TAAUPassConstructor+PassInput ByRef, HGRenderGraph)
		void HG::Rendering::Runtime::TAAUPassConstructor::PrepareParameters(
		        TAAUPassConstructor *this,
		        TAAUPassConstructor_PassInput *input,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  bool v7; // si
		  void *static_fields; // rdx
		  __int64 v9; // rcx
		  float historyWeight; // xmm1_4
		  float sharpenStrength4K; // xmm2_4
		  float v12; // xmm0_4
		  HGRenderGraphContext *HGContext; // rax
		  CommandBuffer *cmd; // rsi
		  HGRenderGraphContext *v15; // r14
		  CBHandle *v16; // rax
		  __m128i v17; // xmm6
		  Material__Array *m_taauPassMaterials; // rax
		  Material *v19; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v21; // [rsp+30h] [rbp-40h] BYREF
		  CBHandle v22; // [rsp+40h] [rbp-30h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3400, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    v7 = !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input->historySceneColor, 0LL)
		      || !this->fields._prevTAAUState_k__BackingField;
		    if ( !input->quality )
		    {
		      if ( v7
		        || (sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle),
		            !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this->fields.m_historyDilatedSceneDepth, 0LL))
		        || (sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle),
		            !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this->fields.m_historyDilatedSceneMV, 0LL)) )
		      {
		        v7 = 1;
		      }
		    }
		    HG::Rendering::Runtime::TAAUPassConstructor::set_taauScaleFactor(this, input->renderingScale, 0LL);
		    if ( v7 )
		      historyWeight = 0.0;
		    else
		      historyWeight = input->historyWeight;
		    if ( this )
		    {
		      HG::Rendering::Runtime::TAAUPassConstructor::set_historyWeight(this, historyWeight, 0LL);
		      HG::Rendering::Runtime::TAAUPassConstructor::set_historyWeightInMotion(this, input->historyWeightInMotion, 0LL);
		      HG::Rendering::Runtime::TAAUPassConstructor::set_fastConvergeHistoryWeight(
		        this,
		        input->fastConvergeHistoryWeight,
		        0LL);
		      HG::Rendering::Runtime::TAAUPassConstructor::set_responsiveAAHistoryWeight(
		        this,
		        input->responsiveAAHistoryWeight,
		        0LL);
		      HG::Rendering::Runtime::TAAUPassConstructor::set_minMVConsideredDynamic(this, input->minMVConsideredDynamic, 0LL);
		      HG::Rendering::Runtime::TAAUPassConstructor::set_maxMVConsideredDynamic(this, input->maxMVConsideredDynamic, 0LL);
		      HG::Rendering::Runtime::TAAUPassConstructor::set_characterMotionSensitivity(
		        this,
		        input->characterMotionSensitivity,
		        0LL);
		      HG::Rendering::Runtime::TAAUPassConstructor::set_occlusionDepthDiff(this, input->occlusionDepthDiff, 0LL);
		      HG::Rendering::Runtime::TAAUPassConstructor::set_inputSampleLumaWeight(this, input->inputSampleLumaWeight, 0LL);
		      HG::Rendering::Runtime::TAAUPassConstructor::set_fastConvergeState(this, (float)input->fastConvergeState, 0LL);
		      HG::Rendering::Runtime::TAAUPassConstructor::set_enableResponsiveTransparency(
		        this,
		        input->enableResponsiveTransparency,
		        0LL);
		      HG::Rendering::Runtime::TAAUPassConstructor::set_firstFrame(this, (float)v7, 0LL);
		      sharpenStrength4K = input->sharpenStrength4K;
		      *(_QWORD *)&v21 = _mm_unpacklo_ps(
		                          (__m128)LODWORD(input->sharpenStrength1K),
		                          (__m128)LODWORD(input->sharpenStrength2K)).m128_u64[0];
		      *((float *)&v21 + 2) = sharpenStrength4K;
		      v12 = HG::Rendering::Runtime::TAAUPassConstructor::ComputeSharpenStrength(
		              this,
		              &input->screenSize,
		              (TAAUPassConstructor_SharpenStrengthParam *)&v21,
		              0LL);
		      HG::Rendering::Runtime::TAAUPassConstructor::set_sharpenStrength(this, v12, 0LL);
		      if ( renderGraph )
		      {
		        HGContext = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(renderGraph, 0LL);
		        if ( HGContext )
		        {
		          cmd = HGContext->fields.cmd;
		          *(float *)&v21 = (float)input->screenSize.m_X;
		          *((float *)&v21 + 1) = (float)input->screenSize.m_Y;
		          *((float *)&v21 + 2) = 1.0 / (float)input->screenSize.m_X;
		          *((float *)&v21 + 3) = 1.0 / (float)input->screenSize.m_Y;
		          *(_OWORD *)&v22.bufferId = v21;
		          HG::Rendering::Runtime::TAAUPassConstructor::set_HRSize(this, (Vector4 *)&v22, 0LL);
		          *(float *)&v21 = (float)input->renderSize.m_X;
		          *((float *)&v21 + 1) = (float)input->renderSize.m_Y;
		          *((float *)&v21 + 2) = 1.0 / *(float *)&v21;
		          *((float *)&v21 + 3) = 1.0 / *((float *)&v21 + 1);
		          *(_OWORD *)&v22.bufferId = v21;
		          HG::Rendering::Runtime::TAAUPassConstructor::set_LRSize(this, (Vector4 *)&v22, 0LL);
		          v15 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(renderGraph, 0LL);
		          if ( v15 )
		          {
		            sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		            v16 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
		                    &v22,
		                    &v15->fields.renderContext,
		                    192,
		                    0LL);
		            v17 = *(__m128i *)&v16->bufferId;
		            v22.ptr = v16->ptr;
		            System::Buffer::MemoryCopy((Void *)&this->fields.m_constants, (Void *)v22.ptr, 192LL, 192LL, 0LL);
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		            static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		            if ( cmd )
		            {
		              UnityEngine::Rendering::CommandBuffer::SetGlobalConstantBufferInternal0(
		                cmd,
		                _mm_cvtsi128_si32(v17),
		                *((_DWORD *)static_fields + 617),
		                _mm_cvtsi128_si32(_mm_srli_si128(v17, 4)),
		                192,
		                0LL);
		              if ( input->quality != 1 )
		                return;
		              m_taauPassMaterials = this->fields.m_taauPassMaterials;
		              if ( m_taauPassMaterials )
		              {
		                if ( m_taauPassMaterials->max_length.size <= 3u )
		                  sub_1800D2AB0(v9, static_fields);
		                v19 = m_taauPassMaterials->vector[3];
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		                static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields;
		                if ( v19 )
		                {
		                  UnityEngine::Material::EnableKeyword(v19, *((String **)static_fields + 47), 0LL);
		                  return;
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_25:
		    sub_1800D8260(v9, static_fields);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3400, 0LL);
		  if ( !Patch )
		    goto LABEL_25;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1229(Patch, (Object *)this, input, (Object *)renderGraph, 0LL);
		}
		
		private void ConstructTAAUPasses(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph) {} // 0x0000000189BD30C4-0x0000000189BD3180
		// Void ConstructTAAUPasses(TAAUPassConstructor+PassInput ByRef, TAAUPassConstructor+PassOutput ByRef, HGRenderGraph)
		void HG::Rendering::Runtime::TAAUPassConstructor::ConstructTAAUPasses(
		        TAAUPassConstructor *this,
		        TAAUPassConstructor_PassInput *input,
		        TAAUPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3403, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3403, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1230(Patch, (Object *)this, input, output, (Object *)renderGraph, 0LL);
		  }
		  else
		  {
		    if ( !input->quality )
		    {
		      HG::Rendering::Runtime::TAAUPassConstructor::ConstructDilationPass(this, input, renderGraph, 0LL);
		      HG::Rendering::Runtime::TAAUPassConstructor::ConstructMaskDilationPass(this, input, renderGraph, 0LL);
		    }
		    HG::Rendering::Runtime::TAAUPassConstructor::ConstructResolvePass(this, input, output, renderGraph, 0LL);
		  }
		}
		
		private void ConstructDilationPass(ref PassInput input, HGRenderGraph renderGraph) {} // 0x0000000189BD1948-0x0000000189BD25A0
		// Void ConstructDilationPass(TAAUPassConstructor+PassInput ByRef, HGRenderGraph)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::TAAUPassConstructor::ConstructDilationPass(
		        TAAUPassConstructor *this,
		        TAAUPassConstructor_PassInput *input,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ProfilingSampler *v7; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  int v10; // edi
		  __int64 v11; // rdx
		  TAAUPassConstructor_RTNames__Array *m_rtNames; // rcx
		  unsigned __int64 v13; // r8
		  signed __int64 v14; // rtt
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  __int64 v17; // r8
		  __int64 v18; // rdx
		  TAAUPassConstructor_RTNames__Array *v19; // rcx
		  unsigned __int64 v20; // r8
		  signed __int64 v21; // rtt
		  Object *v22; // rdx
		  Material__Array *m_taauPassMaterials; // rax
		  Object__Class *v24; // rcx
		  unsigned __int64 v25; // rdx
		  unsigned __int64 v26; // r8
		  char v27; // dl
		  signed __int64 v28; // rtt
		  __int64 v29; // rdx
		  TAAUPassConstructor_RTNames__Array *v30; // rcx
		  unsigned __int64 v31; // r8
		  signed __int64 v32; // rtt
		  Object *v33; // r15
		  __int64 v34; // rdx
		  __int64 v35; // rcx
		  TextureHandle v36; // xmm0
		  __int64 v37; // rdx
		  TAAUPassConstructor_RTNames__Array *v38; // rcx
		  unsigned __int64 v39; // r8
		  signed __int64 v40; // rtt
		  Object *v41; // rbx
		  __int64 v42; // rdx
		  __int64 v43; // rcx
		  TextureHandle v44; // xmm0
		  __int64 v45; // rdx
		  __int64 v46; // rcx
		  __int64 v47; // rdx
		  __int64 v48; // rcx
		  __int64 v49; // rdx
		  __int64 v50; // rcx
		  __int64 v51; // rdx
		  __int64 v52; // rcx
		  __int64 v53; // rdx
		  __int64 v54; // rcx
		  __int64 v55; // rdx
		  __int64 v56; // rcx
		  __int64 v57; // rdx
		  __int64 v58; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v60; // rdx
		  __int64 v61; // rcx
		  Object *v62; // [rsp+50h] [rbp-218h] BYREF
		  __m128i si128; // [rsp+60h] [rbp-208h] BYREF
		  TextureDesc v64; // [rsp+70h] [rbp-1F8h] BYREF
		  HGRenderGraphBuilder v65; // [rsp+D0h] [rbp-198h] BYREF
		  _QWORD v66[2]; // [rsp+F0h] [rbp-178h] BYREF
		  TextureDesc v67; // [rsp+100h] [rbp-168h] BYREF
		  HGRenderGraphBuilder v68; // [rsp+160h] [rbp-108h] BYREF
		  TextureDesc v69; // [rsp+180h] [rbp-E8h] BYREF
		  Il2CppExceptionWrapper *v70; // [rsp+1E0h] [rbp-88h] BYREF
		  TextureDesc v71; // [rsp+1F0h] [rbp-78h] BYREF
		
		  v62 = 0LL;
		  sub_18033B9D0(&v67, 0LL, 96LL);
		  sub_18033B9D0(&v64, 0LL, 96LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(3404, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3404, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v61, v60);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1229(Patch, (Object *)this, input, (Object *)renderGraph, 0LL);
		  }
		  else
		  {
		    v7 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		           (Int32Enum__Enum)0x4Fu,
		           MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8260(v9, v8);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		      &v68,
		      renderGraph,
		      (String *)"TAAU Dilation Pass",
		      &v62,
		      v7,
		      1,
		      ProfilingHGPass__Enum_None,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::TAAUPassConstructor::DilationPassData>);
		    v65 = v68;
		    v66[0] = 0LL;
		    v66[1] = &v65;
		    try
		    {
		      v10 = input->renderPathFrameIndex % 2;
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      if ( !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this->fields.m_historyDilatedSceneDepth, 0LL) )
		      {
		        sub_18033B9D0(&v69, 0LL, 96LL);
		        HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v69, input->renderSize, 0LL);
		        v64 = v69;
		        v64.colorFormat = 45;
		        *(_WORD *)&v64.enableRandomWrite = 0;
		        v64.autoGenerateMips = 0;
		        m_rtNames = this->fields.m_rtNames;
		        if ( !m_rtNames )
		          sub_1800D8250(0LL, v11);
		        v64.name = *(String **)sub_1803C0734(m_rtNames, v10);
		        if ( dword_18F35FD08 )
		        {
		          v13 = (((unsigned __int64)&v64.name >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F0BCBA0[v13 + 36190]);
		          do
		            v14 = qword_18F0BCBA0[v13 + 36190];
		          while ( v14 != _InterlockedCompareExchange64(
		                           &qword_18F0BCBA0[v13 + 36190],
		                           v14 | (1LL << (((unsigned __int64)&v64.name >> 12) & 0x3F)),
		                           v14) );
		        }
		        v67 = v64;
		        this->fields.m_historyDilatedSceneDepth = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                                                     (TextureHandle *)&si128,
		                                                     renderGraph,
		                                                     &v67,
		                                                     0LL);
		      }
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      if ( !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this->fields.m_historyDilatedSceneMV, 0LL) )
		      {
		        sub_18033B9D0(&v69, 0LL, 96LL);
		        HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v69, input->renderSize, 0LL);
		        v64 = v69;
		        v64.colorFormat = HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDescRef(
		                            renderGraph,
		                            &input->sceneMV,
		                            0LL)->colorFormat;
		        *(_WORD *)&v64.enableRandomWrite = 0;
		        v64.autoGenerateMips = 0;
		        v19 = this->fields.m_rtNames;
		        if ( !v19 )
		          sub_1800D8250(0LL, v18);
		        v64.name = *(String **)(sub_1803C0734(v19, v10) + 8);
		        if ( dword_18F35FD08 )
		        {
		          v20 = (((unsigned __int64)&v64.name >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F0BCBA0[v20 + 36190]);
		          do
		            v21 = qword_18F0BCBA0[v20 + 36190];
		          while ( v21 != _InterlockedCompareExchange64(
		                           &qword_18F0BCBA0[v20 + 36190],
		                           v21 | (1LL << (((unsigned __int64)&v64.name >> 12) & 0x3F)),
		                           v21) );
		        }
		        v67 = v64;
		        this->fields.m_historyDilatedSceneMV = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                                                  (TextureHandle *)&si128,
		                                                  renderGraph,
		                                                  &v67,
		                                                  0LL);
		      }
		      if ( !v62 )
		        sub_1800D8250(v16, v15);
		      v62[1] = (Object)input->sceneDepth;
		      if ( !v62 )
		        sub_1800D8250(v16, v15);
		      v62[2] = (Object)input->sceneMV;
		      if ( !v62 )
		        sub_1800D8250(v16, v15);
		      v62[5] = (Object)this->fields.m_historyDilatedSceneDepth;
		      if ( !v62 )
		        sub_1800D8250(v16, v15);
		      v62[6] = (Object)this->fields.m_historyDilatedSceneMV;
		      v22 = v62;
		      m_taauPassMaterials = this->fields.m_taauPassMaterials;
		      if ( !m_taauPassMaterials )
		        sub_1800D8250(v16, v62);
		      if ( !m_taauPassMaterials->max_length.size )
		        sub_1800D2AA0(v16, v62, v17);
		      v24 = (Object__Class *)m_taauPassMaterials->vector[0];
		      if ( !v62 )
		        sub_1800D8250(v24, 0LL);
		      v62[7].klass = v24;
		      if ( dword_18F35FD08 )
		      {
		        v25 = ((unsigned __int64)&v22[7] >> 12) & 0x1FFFFF;
		        v26 = v25 >> 6;
		        v27 = v25 & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v26 + 36190]);
		        do
		          v28 = qword_18F0BCBA0[v26 + 36190];
		        while ( v28 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v26 + 36190], v28 | (1LL << v27), v28) );
		      }
		      sub_18033B9D0(&v69, 0LL, 96LL);
		      HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v69, input->renderSize, 0LL);
		      v64 = v69;
		      v64.colorFormat = 45;
		      *(_WORD *)&v64.enableRandomWrite = 0;
		      v64.autoGenerateMips = 0;
		      v30 = this->fields.m_rtNames;
		      if ( !v30 )
		        sub_1800D8250(0LL, v29);
		      v64.name = *(String **)sub_1803C0734(v30, v10);
		      if ( dword_18F35FD08 )
		      {
		        v31 = (((unsigned __int64)&v64.name >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v31 + 36190]);
		        do
		          v32 = qword_18F0BCBA0[v31 + 36190];
		        while ( v32 != _InterlockedCompareExchange64(
		                         &qword_18F0BCBA0[v31 + 36190],
		                         v32 | (1LL << (((unsigned __int64)&v64.name >> 12) & 0x3F)),
		                         v32) );
		      }
		      v67 = v64;
		      v33 = v62;
		      v36 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		               (TextureHandle *)&si128,
		               renderGraph,
		               &v67,
		               0LL);
		      if ( !v33 )
		        sub_1800D8250(v35, v34);
		      v33[3] = (Object)v36;
		      sub_18033B9D0(&v71, 0LL, 96LL);
		      HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v71, input->renderSize, 0LL);
		      v64 = v71;
		      v64.colorFormat = HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDescRef(
		                          renderGraph,
		                          &input->sceneMV,
		                          0LL)->colorFormat;
		      *(_WORD *)&v64.enableRandomWrite = 0;
		      v64.autoGenerateMips = 0;
		      v38 = this->fields.m_rtNames;
		      if ( !v38 )
		        sub_1800D8250(0LL, v37);
		      v64.name = *(String **)(sub_1803C0734(v38, v10) + 8);
		      if ( dword_18F35FD08 )
		      {
		        v39 = (((unsigned __int64)&v64.name >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v39 + 36190]);
		        do
		          v40 = qword_18F0BCBA0[v39 + 36190];
		        while ( v40 != _InterlockedCompareExchange64(
		                         &qword_18F0BCBA0[v39 + 36190],
		                         v40 | (1LL << (((unsigned __int64)&v64.name >> 12) & 0x3F)),
		                         v40) );
		      }
		      v67 = v64;
		      v41 = v62;
		      v44 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		               (TextureHandle *)&si128,
		               renderGraph,
		               &v67,
		               0LL);
		      if ( !v41 )
		        sub_1800D8250(v43, v42);
		      v41[4] = (Object)v44;
		      if ( !v62 )
		        sub_1800D8250(v43, v42);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		        (TextureHandle *)&si128,
		        &v65,
		        (TextureHandle *)&v62[1],
		        0LL);
		      if ( !v62 )
		        sub_1800D8250(v46, v45);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		        (TextureHandle *)&si128,
		        &v65,
		        (TextureHandle *)&v62[2],
		        0LL);
		      if ( !v62 )
		        sub_1800D8250(v48, v47);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadWriteTexture(
		        (TextureHandle *)&si128,
		        &v65,
		        (TextureHandle *)&v62[5],
		        0LL);
		      if ( !v62 )
		        sub_1800D8250(v50, v49);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadWriteTexture(
		        (TextureHandle *)&si128,
		        &v65,
		        (TextureHandle *)&v62[6],
		        0LL);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v65, 0, 0LL);
		      if ( !v62 )
		        sub_1800D8250(v52, v51);
		      si128 = _mm_load_si128((const __m128i *)&xmmword_18B959540);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		        (TextureHandle *)&v68,
		        &v65,
		        (TextureHandle *)&v62[3],
		        0,
		        RenderBufferLoadAction__Enum_DontCare,
		        RenderBufferStoreAction__Enum_Store,
		        (Color *)&si128,
		        0,
		        0LL);
		      if ( !v62 )
		        sub_1800D8250(v54, v53);
		      si128 = _mm_load_si128((const __m128i *)&xmmword_18B959540);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		        (TextureHandle *)&v68,
		        &v65,
		        (TextureHandle *)&v62[4],
		        1,
		        RenderBufferLoadAction__Enum_DontCare,
		        RenderBufferStoreAction__Enum_Store,
		        (Color *)&si128,
		        0,
		        0LL);
		      if ( HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::DepthRequiredIfMRT(&v65, 0LL) )
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		          (TextureHandle *)&v68,
		          &v65,
		          &input->utilityDepth,
		          DepthAccess__Enum_ReadWrite,
		          RenderBufferLoadAction__Enum_Load,
		          RenderBufferStoreAction__Enum_Store,
		          1.0,
		          0,
		          0,
		          0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v65,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor->static_fields->s_dilationRenderFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::TAAUPassConstructor::DilationPassData>);
		      if ( !v62 )
		        sub_1800D8250(v56, v55);
		      this->fields.m_historyDilatedSceneDepth = *HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
		                                                   (TextureHandle *)&v68,
		                                                   renderGraph,
		                                                   (TextureHandle *)&v62[3],
		                                                   1,
		                                                   (String *)"TAAUPass",
		                                                   0LL);
		      if ( !v62 )
		        sub_1800D8250(v58, v57);
		      this->fields.m_historyDilatedSceneMV = *HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
		                                                (TextureHandle *)&v68,
		                                                renderGraph,
		                                                (TextureHandle *)&v62[4],
		                                                1,
		                                                (String *)"TAAUPass",
		                                                0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v70 )
		    {
		      v66[0] = v70->ex;
		    }
		    sub_180268AE0(v66);
		  }
		}
		
		private void ConstructMaskDilationPass(ref PassInput input, HGRenderGraph renderGraph) {} // 0x0000000189BD25A0-0x0000000189BD29EC
		// Void ConstructMaskDilationPass(TAAUPassConstructor+PassInput ByRef, HGRenderGraph)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::TAAUPassConstructor::ConstructMaskDilationPass(
		        TAAUPassConstructor *this,
		        TAAUPassConstructor_PassInput *input,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ProfilingSampler *v7; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  __int64 v10; // rcx
		  __int64 v11; // r8
		  Object *v12; // rdx
		  Material__Array *m_taauPassMaterials; // rax
		  Object__Class *v14; // rcx
		  unsigned int v15; // edx
		  unsigned __int64 v16; // r8
		  signed __int64 v17; // rtt
		  int v18; // edi
		  __int64 v19; // rdx
		  __int64 v20; // rcx
		  int v21; // eax
		  int32_t v22; // ebx
		  Object *v23; // rbx
		  __int64 v24; // rdx
		  __int64 v25; // rcx
		  TextureHandle v26; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v28; // rdx
		  __int64 v29; // rcx
		  Object *v30; // [rsp+50h] [rbp-1A8h] BYREF
		  _QWORD v31[3]; // [rsp+58h] [rbp-1A0h] BYREF
		  __m128i si128; // [rsp+70h] [rbp-188h] BYREF
		  HGRenderGraphBuilder v33; // [rsp+80h] [rbp-178h] BYREF
		  Il2CppExceptionWrapper *v34; // [rsp+A0h] [rbp-158h] BYREF
		  HGRenderGraphBuilder v35; // [rsp+A8h] [rbp-150h] BYREF
		  __int128 v36; // [rsp+E0h] [rbp-118h]
		  __int128 v37; // [rsp+F0h] [rbp-108h]
		  TextureDesc v38; // [rsp+130h] [rbp-C8h] BYREF
		  TextureDesc v39; // [rsp+190h] [rbp-68h] BYREF
		
		  v30 = 0LL;
		  sub_18033B9D0(&v39, 0LL, 96LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(3405, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3405, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v29, v28);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1229(Patch, (Object *)this, input, (Object *)renderGraph, 0LL);
		  }
		  else
		  {
		    v7 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		           (Int32Enum__Enum)0x50u,
		           MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8260(v9, v8);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		      &v35,
		      renderGraph,
		      (String *)"TAAU Mask Dilation Pass",
		      &v30,
		      v7,
		      1,
		      ProfilingHGPass__Enum_None,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::TAAUPassConstructor::MaskDilationPassData>);
		    v33 = v35;
		    v31[0] = 0LL;
		    v31[1] = &v33;
		    try
		    {
		      v12 = v30;
		      m_taauPassMaterials = this->fields.m_taauPassMaterials;
		      if ( !m_taauPassMaterials )
		        sub_1800D8250(v10, v30);
		      if ( m_taauPassMaterials->max_length.size <= 1u )
		        sub_1800D2AA0(v10, v30, v11);
		      v14 = (Object__Class *)m_taauPassMaterials->vector[1];
		      if ( !v30 )
		        sub_1800D8250(v14, 0LL);
		      v30[2].klass = v14;
		      if ( dword_18F35FD08 )
		      {
		        v15 = ((unsigned __int64)&v12[2] >> 12) & 0x1FFFFF;
		        v16 = (unsigned __int64)v15 >> 6;
		        v12 = (Object *)(v15 & 0x3F);
		        _m_prefetchw(&qword_18F103690[v16]);
		        do
		        {
		          v14 = (Object__Class *)(qword_18F103690[v16] | (1LL << (char)v12));
		          v17 = qword_18F103690[v16];
		        }
		        while ( v17 != _InterlockedCompareExchange64(&qword_18F103690[v16], (signed __int64)v14, v17) );
		      }
		      v18 = sub_182F3EA70(v14, v12);
		      v21 = sub_182F3EA70(v20, v19);
		      v22 = 4 * (v21 / 4 + (int)(float)((float)((float)(v21 % 4) * 0.25) + (float)((float)(v21 % 4) * 0.25)));
		      sub_18033B9D0(&v38, 0LL, 96LL);
		      HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
		        &v38,
		        4 * (v18 / 4 + (int)(float)((float)((float)(v18 % 4) * 0.25) + (float)((float)(v18 % 4) * 0.25))),
		        v22,
		        0LL);
		      HIDWORD(v36) = v38.dimension;
		      v37 = *(_OWORD *)&v38.enableRandomWrite;
		      LODWORD(v36) = 5;
		      LOWORD(v37) = 0;
		      *(_QWORD *)((char *)&v36 + 4) = 0x100000001LL;
		      *(_OWORD *)&v39.width = *(_OWORD *)&v38.width;
		      *(_OWORD *)&v39.colorFormat = v36;
		      *(_OWORD *)&v39.enableRandomWrite = v37;
		      *(_OWORD *)&v39.bindTextureMS = *(_OWORD *)&v38.bindTextureMS;
		      *(_OWORD *)&v39.fastMemoryDesc.inFastMemory = *(_OWORD *)&v38.fastMemoryDesc.inFastMemory;
		      v39.clearColor = v38.clearColor;
		      v23 = v30;
		      v26 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		               (TextureHandle *)&si128,
		               renderGraph,
		               &v39,
		               0LL);
		      if ( !v23 )
		        sub_1800D8250(v25, v24);
		      v23[1] = (Object)v26;
		      if ( !v30 )
		        sub_1800D8250(v25, v24);
		      si128 = _mm_load_si128((const __m128i *)&xmmword_18B959540);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		        (TextureHandle *)&v35,
		        &v33,
		        (TextureHandle *)&v30[1],
		        0,
		        RenderBufferLoadAction__Enum_DontCare,
		        RenderBufferStoreAction__Enum_Store,
		        (Color *)&si128,
		        0,
		        0LL);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v33, 0, 0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v33,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor->static_fields->s_maskDilationRenderFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::TAAUPassConstructor::MaskDilationPassData>);
		    }
		    catch ( Il2CppExceptionWrapper *v34 )
		    {
		      v31[0] = v34->ex;
		    }
		    sub_180268AE0(v31);
		  }
		}
		
		private void ConstructResolvePass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph) {} // 0x0000000189BD2AF0-0x0000000189BD30C4
		// Void ConstructResolvePass(TAAUPassConstructor+PassInput ByRef, TAAUPassConstructor+PassOutput ByRef, HGRenderGraph)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::TAAUPassConstructor::ConstructResolvePass(
		        TAAUPassConstructor *this,
		        TAAUPassConstructor_PassInput *input,
		        TAAUPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  int v11; // ebx
		  int32_t colorFormat; // r12d
		  ProfilingSampler *v13; // rax
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  __int64 v16; // rdx
		  __int64 quality; // rcx
		  __int64 v18; // rdx
		  __int64 v19; // r8
		  Object *v20; // rcx
		  Material__Array *m_taauPassMaterials; // rax
		  MonitorData *v22; // rdx
		  unsigned __int64 v23; // r8
		  signed __int64 v24; // rtt
		  Object *v25; // r15
		  __int64 v26; // rdx
		  __int64 v27; // rcx
		  TextureHandle v28; // xmm0
		  Object *v29; // r15
		  __int64 v30; // rdx
		  __int64 v31; // rcx
		  TextureHandle v32; // xmm0
		  Object *v33; // r15
		  __int64 v34; // rdx
		  __int64 v35; // rcx
		  TextureHandle v36; // xmm0
		  __int64 v37; // rdx
		  TAAUPassConstructor_RTNames__Array *m_rtNames; // rcx
		  unsigned __int64 v39; // r8
		  signed __int64 v40; // rtt
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v42; // rdx
		  __int64 v43; // rcx
		  Object *v44; // [rsp+50h] [rbp-1D8h] BYREF
		  __m128i si128; // [rsp+60h] [rbp-1C8h] BYREF
		  TextureHandle v46; // [rsp+70h] [rbp-1B8h] BYREF
		  _QWORD v47[2]; // [rsp+80h] [rbp-1A8h] BYREF
		  HGRenderGraphBuilder v48; // [rsp+90h] [rbp-198h] BYREF
		  TextureDesc v49; // [rsp+B0h] [rbp-178h] BYREF
		  Il2CppExceptionWrapper *v50; // [rsp+110h] [rbp-118h] BYREF
		  HGRenderGraphBuilder v51; // [rsp+118h] [rbp-110h] BYREF
		  TextureDesc v52; // [rsp+140h] [rbp-E8h] BYREF
		  TextureDesc v53; // [rsp+1A0h] [rbp-88h] BYREF
		
		  v44 = 0LL;
		  sub_18033B9D0(&v53, 0LL, 96LL);
		  sub_18033B9D0(&v49, 0LL, 96LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(3406, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3406, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v43, v42);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1230(Patch, (Object *)this, input, output, (Object *)renderGraph, 0LL);
		  }
		  else
		  {
		    v11 = input->renderPathFrameIndex % 2;
		    if ( input->quality )
		    {
		      if ( !renderGraph )
		        sub_1800D8260(v10, v9);
		      colorFormat = HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDescRef(
		                      renderGraph,
		                      &input->sceneColor,
		                      0LL)->colorFormat;
		    }
		    else
		    {
		      colorFormat = 48;
		    }
		    v13 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		            (Int32Enum__Enum)0x52u,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8260(v15, v14);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		      &v51,
		      renderGraph,
		      (String *)"TAAU Resolve Pass",
		      &v44,
		      v13,
		      1,
		      ProfilingHGPass__Enum_None,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::TAAUPassConstructor::ResolvePassData>);
		    v48 = v51;
		    v47[0] = 0LL;
		    v47[1] = &v48;
		    try
		    {
		      quality = (unsigned int)input->quality;
		      if ( !v44 )
		        sub_1800D8250(quality, v16);
		      LODWORD(v44[5].klass) = quality;
		      if ( !v44 )
		        sub_1800D8250(quality, v16);
		      v44[4] = (Object)input->historySceneColor;
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input->historySceneColor, 0LL) )
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		          (TextureHandle *)&si128,
		          &v48,
		          &input->historySceneColor,
		          0LL);
		      v20 = v44;
		      m_taauPassMaterials = this->fields.m_taauPassMaterials;
		      if ( !m_taauPassMaterials )
		        sub_1800D8250(v44, v18);
		      if ( m_taauPassMaterials->max_length.size <= 3u )
		        sub_1800D2AA0(v44, v18, v19);
		      v22 = (MonitorData *)m_taauPassMaterials->vector[3];
		      if ( !v44 )
		        sub_1800D8250(0LL, v22);
		      v44[5].monitor = v22;
		      if ( dword_18F35FD08 )
		      {
		        v23 = (((unsigned __int64)&v20[5].monitor >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v23 + 36190]);
		        do
		          v24 = qword_18F0BCBA0[v23 + 36190];
		        while ( v24 != _InterlockedCompareExchange64(
		                         &qword_18F0BCBA0[v23 + 36190],
		                         v24 | (1LL << (((unsigned __int64)&v20[5].monitor >> 12) & 0x3F)),
		                         v24) );
		      }
		      v25 = v44;
		      v28 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		               (TextureHandle *)&si128,
		               &v48,
		               &input->sceneColor,
		               0LL);
		      if ( !v25 )
		        sub_1800D8250(v27, v26);
		      v25[1] = (Object)v28;
		      if ( input->quality == 1 )
		      {
		        v29 = v44;
		        v32 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                 (TextureHandle *)&si128,
		                 &v48,
		                 &input->sceneDepth,
		                 0LL);
		        if ( !v29 )
		          sub_1800D8250(v31, v30);
		        v29[2] = (Object)v32;
		        v33 = v44;
		        v36 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                 (TextureHandle *)&si128,
		                 &v48,
		                 &input->sceneMV,
		                 0LL);
		        if ( !v33 )
		          sub_1800D8250(v35, v34);
		        v33[3] = (Object)v36;
		      }
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v48, 0, 0LL);
		      sub_18033B9D0(&v52, 0LL, 96LL);
		      HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v52, input->screenSize, 0LL);
		      v49 = v52;
		      v49.colorFormat = colorFormat;
		      *(_WORD *)&v49.enableRandomWrite = 0;
		      v49.autoGenerateMips = 0;
		      m_rtNames = this->fields.m_rtNames;
		      if ( !m_rtNames )
		        sub_1800D8250(0LL, v37);
		      v49.name = *(String **)(sub_1803C0734(m_rtNames, v11) + 16);
		      if ( dword_18F35FD08 )
		      {
		        v39 = (((unsigned __int64)&v49.name >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v39 + 36190]);
		        do
		          v40 = qword_18F0BCBA0[v39 + 36190];
		        while ( v40 != _InterlockedCompareExchange64(
		                         &qword_18F0BCBA0[v39 + 36190],
		                         v40 | (1LL << (((unsigned __int64)&v49.name >> 12) & 0x3F)),
		                         v40) );
		      }
		      v53 = v49;
		      v46 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		               (TextureHandle *)&si128,
		               renderGraph,
		               &v53,
		               0LL);
		      si128 = _mm_load_si128((const __m128i *)&xmmword_18B959540);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		        (TextureHandle *)&v51,
		        &v48,
		        &v46,
		        0,
		        RenderBufferLoadAction__Enum_DontCare,
		        RenderBufferStoreAction__Enum_Store,
		        (Color *)&si128,
		        0,
		        0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v48,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor->static_fields->s_resolveRenderFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::TAAUPassConstructor::ResolvePassData>);
		      output->currentSceneColor = v46;
		    }
		    catch ( Il2CppExceptionWrapper *v50 )
		    {
		      v47[0] = v50->ex;
		    }
		    sub_180268AE0(v47);
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184D7FE40-0x0000000184D7FE70
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::TAAUPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        TAAUPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3408, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3408, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)renderGraph,
		      0LL);
		  }
		}
		
		private float ComputeSharpenStrength([IsReadOnly] in Vector2Int screenSize, SharpenStrengthParam param) => default; // 0x0000000189BD1860-0x0000000189BD1948
		// Single ComputeSharpenStrength(Vector2Int ByRef, TAAUPassConstructor+SharpenStrengthParam)
		float HG::Rendering::Runtime::TAAUPassConstructor::ComputeSharpenStrength(
		        TAAUPassConstructor *this,
		        Vector2Int *screenSize,
		        TAAUPassConstructor_SharpenStrengthParam *param,
		        MethodInfo *method)
		{
		  Beyond::JobMathf *v7; // rcx
		  TAAUPassConstructor_SharpenStrengthParam *p_sharpen2K; // rax
		  float v9; // xmm1_4
		  float sharpen1K; // xmm4_4
		  float v11; // xmm0_4
		  float v12; // xmm1_4
		  float v13; // xmm3_4
		  float result; // xmm0_4
		  float v15; // xmm3_4
		  __int64 v16; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  float sharpen4K; // eax
		  TAAUPassConstructor_SharpenStrengthParam v19; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3402, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3402, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v16);
		    sharpen4K = param->sharpen4K;
		    *(_QWORD *)&v19.sharpen1K = *(_QWORD *)&param->sharpen1K;
		    v19.sharpen4K = sharpen4K;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1228(Patch, (Object *)this, screenSize, &v19, 0LL);
		  }
		  else
		  {
		    p_sharpen2K = (TAAUPassConstructor_SharpenStrengthParam *)&param->sharpen2K;
		    v9 = 2560.0;
		    if ( (float)screenSize->m_X < 2560.0 )
		    {
		      sharpen1K = p_sharpen2K->sharpen1K;
		      p_sharpen2K = param;
		      v11 = 1920.0;
		    }
		    else
		    {
		      sharpen1K = param->sharpen4K;
		      v11 = 2560.0;
		      v9 = 3840.0;
		    }
		    v12 = v9 - v11;
		    v13 = (float)screenSize->m_X - v11;
		    result = p_sharpen2K->sharpen1K;
		    v15 = fmaxf(v13, 0.0) / v12;
		    Beyond::JobMathf::ClampedLerp(v7, sharpen1K, fminf(1.0, v15), v15);
		  }
		  return result;
		}
		
		private static void ComputeGaussianKernel(float stdDev, ref float[] kernel) {} // 0x0000000183C00BB0-0x0000000183C01010
		// Void ComputeGaussianKernel(Single, Single[] ByRef)
		void HG::Rendering::Runtime::TAAUPassConstructor::ComputeGaussianKernel(
		        float stdDev,
		        Single__Array **kernel,
		        MethodInfo *method)
		{
		  __int64 v4; // rdx
		  Single__Array *v5; // rcx
		  Single__Array *v6; // rdi
		  float v7; // xmm6_4
		  Single__Array *v8; // rdi
		  Single__Array *v9; // rdi
		  Single__Array *v10; // rdi
		  Single__Array *v11; // rdi
		  Single__Array *v12; // rdi
		  Single__Array *v13; // rdi
		  Single__Array *v14; // rdi
		  Single__Array *v15; // rdi
		  __int64 v16; // r8
		  __int64 v17; // r9
		  Single__Array *v18; // rax
		  float v19; // xmm6_4
		  float *v20; // rax
		  __int64 v21; // r8
		  __int64 v22; // r9
		  float *v23; // rax
		  __int64 v24; // r8
		  __int64 v25; // r9
		  float *v26; // rax
		  __int64 v27; // r8
		  __int64 v28; // r9
		  float *v29; // rax
		  __int64 v30; // r8
		  __int64 v31; // r9
		  float *v32; // rax
		  __int64 v33; // r8
		  __int64 v34; // r9
		  float *v35; // rax
		  __int64 v36; // r8
		  __int64 v37; // r9
		  float *v38; // rax
		  __int64 v39; // r8
		  __int64 v40; // r9
		  float *v41; // rax
		  __int64 v42; // r8
		  __int64 v43; // r9
		  float *v44; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3394, 0LL) )
		  {
		    v6 = *kernel;
		    v7 = stdDev * stdDev;
		    if ( !*kernel )
		      goto LABEL_3;
		    if ( !v6->max_length.size )
		      goto LABEL_34;
		    v6->vector[0] = sub_180335960() / (float)(v7 * 6.2831855);
		    v8 = *kernel;
		    if ( !*kernel )
		      goto LABEL_3;
		    if ( v8->max_length.size <= 1u )
		      goto LABEL_34;
		    v8->vector[1] = sub_180335960() / (float)(v7 * 6.2831855);
		    v9 = *kernel;
		    if ( !*kernel )
		      goto LABEL_3;
		    if ( v9->max_length.size <= 2u )
		      goto LABEL_34;
		    v9->vector[2] = sub_180335960() / (float)(v7 * 6.2831855);
		    v10 = *kernel;
		    if ( !*kernel )
		      goto LABEL_3;
		    if ( v10->max_length.size <= 3u )
		      goto LABEL_34;
		    v10->vector[3] = sub_180335960() / (float)(v7 * 6.2831855);
		    v11 = *kernel;
		    if ( !*kernel )
		      goto LABEL_3;
		    if ( v11->max_length.size <= 4u )
		      goto LABEL_34;
		    v11->vector[4] = sub_180335960() / (float)(v7 * 6.2831855);
		    v12 = *kernel;
		    if ( !*kernel )
		      goto LABEL_3;
		    if ( v12->max_length.size <= 5u )
		      goto LABEL_34;
		    v12->vector[5] = sub_180335960() / (float)(v7 * 6.2831855);
		    v13 = *kernel;
		    if ( !*kernel )
		      goto LABEL_3;
		    if ( v13->max_length.size <= 6u )
		      goto LABEL_34;
		    v13->vector[6] = sub_180335960() / (float)(v7 * 6.2831855);
		    v14 = *kernel;
		    if ( !*kernel )
		      goto LABEL_3;
		    if ( v14->max_length.size <= 7u )
		      goto LABEL_34;
		    v14->vector[7] = sub_180335960() / (float)(v7 * 6.2831855);
		    v15 = *kernel;
		    if ( !*kernel )
		      goto LABEL_3;
		    if ( v15->max_length.size <= 8u )
		      goto LABEL_34;
		    v15->vector[8] = sub_180335960() / (float)(v7 * 6.2831855);
		    v18 = *kernel;
		    if ( !*kernel )
		      goto LABEL_3;
		    if ( !v18->max_length.size || (v5 = *kernel, v18->max_length.size <= 8u) )
		LABEL_34:
		      sub_1800D2AB0(v5, v4);
		    v19 = (float)((float)((float)((float)((float)((float)((float)((float)(v18->vector[0] + 0.0) + v18->vector[1])
		                                                        + v18->vector[2])
		                                                + v18->vector[3])
		                                        + v18->vector[4])
		                                + v18->vector[5])
		                        + v18->vector[6])
		                + v18->vector[7])
		        + v18->vector[8];
		    if ( v18 )
		    {
		      v20 = (float *)sub_180002EB0(v5, 0LL, v16, v17);
		      *v20 = *v20 / v19;
		      v5 = *kernel;
		      if ( *kernel )
		      {
		        v23 = (float *)sub_180002EB0(v5, 1LL, v21, v22);
		        *v23 = *v23 / v19;
		        v5 = *kernel;
		        if ( *kernel )
		        {
		          v26 = (float *)sub_180002EB0(v5, 2LL, v24, v25);
		          *v26 = *v26 / v19;
		          v5 = *kernel;
		          if ( *kernel )
		          {
		            v29 = (float *)sub_180002EB0(v5, 3LL, v27, v28);
		            *v29 = *v29 / v19;
		            v5 = *kernel;
		            if ( *kernel )
		            {
		              v32 = (float *)sub_180002EB0(v5, 4LL, v30, v31);
		              *v32 = *v32 / v19;
		              v5 = *kernel;
		              if ( *kernel )
		              {
		                v35 = (float *)sub_180002EB0(v5, 5LL, v33, v34);
		                *v35 = *v35 / v19;
		                v5 = *kernel;
		                if ( *kernel )
		                {
		                  v38 = (float *)sub_180002EB0(v5, 6LL, v36, v37);
		                  *v38 = *v38 / v19;
		                  v5 = *kernel;
		                  if ( *kernel )
		                  {
		                    v41 = (float *)sub_180002EB0(v5, 7LL, v39, v40);
		                    *v41 = *v41 / v19;
		                    v5 = *kernel;
		                    if ( *kernel )
		                    {
		                      v44 = (float *)sub_180002EB0(v5, 8LL, v42, v43);
		                      *v44 = *v44 / v19;
		                      return;
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_3:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3394, 0LL);
		  if ( !Patch )
		    goto LABEL_3;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1227(Patch, stdDev, kernel, 0LL);
		}
		
	}
}
