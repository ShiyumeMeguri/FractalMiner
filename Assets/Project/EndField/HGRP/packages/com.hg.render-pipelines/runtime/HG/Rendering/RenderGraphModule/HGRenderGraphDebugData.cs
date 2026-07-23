using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.RenderGraphModule
{
	internal class HGRenderGraphDebugData // TypeDefIndex: 37423
	{
		// Fields
		public List<PassDebugData> passList; // 0x10
		public List<ResourceDebugData>[] resourceLists; // 0x18
	
		// Nested types
		[DebuggerDisplay("PassDebug: {name}")]
		public struct PassDebugData // TypeDefIndex: 37421
		{
			// Fields
			public string name; // 0x00
			public List<int>[] resourceReadLists; // 0x08
			public List<int>[] resourceWriteLists; // 0x10
			public bool culled; // 0x18
			public bool generateDebugData; // 0x19
		}
	
		[DebuggerDisplay("ResourceDebug: {name} [{creationPassIndex}:{releasePassIndex}]")]
		public struct ResourceDebugData // TypeDefIndex: 37422
		{
			// Fields
			public string name; // 0x00
			public bool imported; // 0x08
			public int creationPassIndex; // 0x0C
			public int releasePassIndex; // 0x10
			public List<int> consumerList; // 0x18
			public List<int> producerList; // 0x20
		}
	
		// Constructors
		public HGRenderGraphDebugData() {} // 0x0000000189B288D4-0x0000000189B28940
		// HGRenderGraphDebugData()
		void HG::Rendering::RenderGraphModule::HGRenderGraphDebugData::HGRenderGraphDebugData(
		        HGRenderGraphDebugData *this,
		        MethodInfo *method)
		{
		  List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  List_1_HG_Rendering_RenderGraphModule_HGRenderGraphDebugData_PassDebugData_ *v6; // rbx
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  Type *v10; // rdx
		  PropertyInfo_1 *v11; // r8
		  Int32__Array **v12; // r9
		  MethodInfo *v13; // [rsp+20h] [rbp-8h]
		  MethodInfo *v14; // [rsp+50h] [rbp+28h]
		
		  v3 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraphDebugData::PassDebugData>);
		  v6 = (List_1_HG_Rendering_RenderGraphModule_HGRenderGraphDebugData_PassDebugData_ *)v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  System::Collections::Generic::List<Beyond::Gameplay::XiraniteNexusBrain_SplineScanElement::SplineProgressInterval>::List(
		    v3,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraphDebugData::PassDebugData>::List);
		  this->fields.passList = v6;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields, v7, v8, v9, v13);
		  this->fields.resourceLists = (List_1_HG_Rendering_RenderGraphModule_HGRenderGraphDebugData_ResourceDebugData___Array *)il2cpp_array_new_specific_1(TypeInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraphDebugData::ResourceDebugData>, 2LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.resourceLists, v10, v11, v12, v14);
		}
		
	
		// Methods
		public void Clear() {} // 0x0000000189B287A4-0x0000000189B288D4
		// Void Clear()
		void HG::Rendering::RenderGraphModule::HGRenderGraphDebugData::Clear(HGRenderGraphDebugData *this, MethodInfo *method)
		{
		  Type *v3; // rdx
		  List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *passList; // rcx
		  List_1_HG_Rendering_RenderGraphModule_HGRenderGraphDebugData_ResourceDebugData___Array *resourceLists; // rax
		  int v6; // ebx
		  List_1_HG_Rendering_RenderGraphModule_HGRenderGraphDebugData_ResourceDebugData___Array *v7; // rsi
		  List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *v8; // rax
		  List_1_HG_Rendering_RenderGraphModule_HGRenderGraphDebugData_ResourceDebugData_ *v9; // rbp
		  PropertyInfo_1 *v10; // r8
		  Int32__Array **v11; // r9
		  int32_t v12; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v14; // [rsp+20h] [rbp-8h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(93, 0LL) )
		  {
		    passList = (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)this->fields.passList;
		    if ( passList )
		    {
		      System::Collections::Generic::List<Beyond::Gameplay::Core::AbilitySystem_ComboController_MappingModifier::Handle>::Clear(
		        passList,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraphDebugData::PassDebugData>::Clear);
		      resourceLists = this->fields.resourceLists;
		      if ( resourceLists )
		      {
		        if ( !resourceLists->max_length.size )
		LABEL_17:
		          sub_1800D2AB0(passList, v3);
		        if ( resourceLists->vector[0] )
		        {
		LABEL_11:
		          v12 = 0;
		          while ( 1 )
		          {
		            passList = (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)this->fields.resourceLists;
		            if ( !passList )
		              break;
		            if ( (unsigned int)v12 >= passList->fields._size )
		              goto LABEL_17;
		            passList = (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)*((_QWORD *)&passList->fields._syncRoot + v12);
		            if ( !passList )
		              break;
		            System::Collections::Generic::List<Beyond::Gameplay::Core::AbilitySystem_ComboController_MappingModifier::Handle>::Clear(
		              passList,
		              MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraphDebugData::ResourceDebugData>::Clear);
		            if ( ++v12 >= 2 )
		              return;
		          }
		        }
		        else
		        {
		          v6 = 0;
		          while ( 1 )
		          {
		            v7 = this->fields.resourceLists;
		            v8 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraphDebugData::ResourceDebugData>);
		            v9 = (List_1_HG_Rendering_RenderGraphModule_HGRenderGraphDebugData_ResourceDebugData_ *)v8;
		            if ( !v8 )
		              break;
		            System::Collections::Generic::List<Beyond::Gameplay::XiraniteNexusBrain_SplineScanElement::SplineProgressInterval>::List(
		              v8,
		              MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraphDebugData::ResourceDebugData>::List);
		            if ( !v7 )
		              break;
		            sub_180031B10(v7, v9);
		            if ( (unsigned int)v6 >= v7->max_length.size )
		              goto LABEL_17;
		            v7->vector[v6] = v9;
		            sub_18002D1B0((SingleFieldAccessor *)&v7->vector[v6++], v3, v10, v11, v14);
		            if ( v6 >= 2 )
		              goto LABEL_11;
		          }
		        }
		      }
		    }
		LABEL_19:
		    sub_1800D8260(passList, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(93, 0LL);
		  if ( !Patch )
		    goto LABEL_19;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
	}
}
