using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace IniParser.Exceptions
{
	public class ParsingException : Exception // TypeDefIndex: 37385
	{
		// Properties
		public System.Version LibVersion { get; } // 0x0000000184D86220-0x0000000184D86230 
		// WaterVolumePtr get_value()
		WaterVolumePtr Beyond::Gameplay::ParamVariable<Beyond::Gameplay::Core::WaterVolumePtr>::get_value(
		        ParamVariable_1_Beyond_Gameplay_Core_WaterVolumePtr_ *this,
		        MethodInfo *method)
		{
		  return (WaterVolumePtr)this->fields.m_value.id;
		}
		
		public uint LineNumber { get; } // 0x0000000184D862D0-0x0000000184D862E0 
		// Int32 get_pressedButtons()
		int32_t UnityEngine::UIElements::PointerEventBase<System::Object>::get_pressedButtons(
		        PointerEventBase_1_System_Object_ *this,
		        MethodInfo *method)
		{
		  return this->fields._pressedButtons_k__BackingField;
		}
		
		public string LineContents { get; } // 0x0000000184D86210-0x0000000184D86220 
		// List`1[NodeCanvas.Framework.Internal.BBMappingParameter] get_variablesMap()
		List_1_NodeCanvas_Framework_Internal_BBMappingParameter_ *NodeCanvas::StateMachines::FSMStateNested<System::Object>::get_variablesMap(
		        FSMStateNested_1_System_Object_ *this,
		        MethodInfo *method)
		{
		  return this->fields._variablesMap;
		}
		
	
		// Constructors
		public ParsingException() {} // Dummy constructor
		public ParsingException(string msg, uint lineNumber) {} // 0x0000000189B3192C-0x0000000189B31958
		// ParsingException(String, UInt32)
		void IniParser::Exceptions::ParsingException::ParsingException(
		        ParsingException *this,
		        String *msg,
		        uint32_t lineNumber,
		        MethodInfo *method)
		{
		  IniParser::Exceptions::ParsingException::ParsingException(
		    this,
		    msg,
		    lineNumber,
		    TypeInfo::System::String->static_fields->Empty,
		    0LL,
		    0LL);
		}
		
		public ParsingException(string msg, Exception innerException) {} // 0x0000000189B318FC-0x0000000189B3192C
		// ParsingException(String, Exception)
		void IniParser::Exceptions::ParsingException::ParsingException(
		        ParsingException *this,
		        String *msg,
		        Exception *innerException,
		        MethodInfo *method)
		{
		  IniParser::Exceptions::ParsingException::ParsingException(
		    this,
		    msg,
		    0,
		    TypeInfo::System::String->static_fields->Empty,
		    innerException,
		    0LL);
		}
		
		public ParsingException(string msg, uint lineNumber, string lineContents) {} // 0x0000000189B31A14-0x0000000189B31A30
		// ParsingException(String, UInt32, String)
		void IniParser::Exceptions::ParsingException::ParsingException(
		        ParsingException *this,
		        String *msg,
		        uint32_t lineNumber,
		        String *lineContents,
		        MethodInfo *method)
		{
		  IniParser::Exceptions::ParsingException::ParsingException(this, msg, lineNumber, lineContents, 0LL, 0LL);
		}
		
		public ParsingException(string msg, uint lineNumber, string lineContents, Exception innerException) {} // 0x0000000189B31958-0x0000000189B31A14
		// ParsingException(String, UInt32, String, Exception)
		void IniParser::Exceptions::ParsingException::ParsingException(
		        ParsingException *this,
		        String *msg,
		        uint32_t lineNumber,
		        String *lineContents,
		        Exception *innerException,
		        MethodInfo *method)
		{
		  Object *v10; // rax
		  String *v11; // rbx
		  UberPostPassUtils_ColorGradingData **v12; // rdx
		  VolumetricPipelineRT **v13; // r8
		  VolumetricPipelineRT **v14; // r9
		  UberPostPassUtils_ColorGradingData **v15; // rdx
		  VolumetricPipelineRT **v16; // r8
		  VolumetricPipelineRT **v17; // r9
		  VolumetricPipelineRT **v18; // [rsp+20h] [rbp-18h]
		  MethodInfo *v19; // [rsp+28h] [rbp-10h]
		  uint32_t v20; // [rsp+50h] [rbp+18h] BYREF
		
		  v20 = lineNumber;
		  v10 = (Object *)il2cpp_value_box_0(TypeInfo::System::UInt32, &v20);
		  v11 = System::String::Format(
		          (String *)"{0} while parsing line number {1} with value '{2}'",
		          (Object *)msg,
		          v10,
		          (Object *)lineContents,
		          0LL);
		  sub_1800036A0(TypeInfo::System::Exception);
		  System::Exception::Exception((Exception *)this, v11, innerException, 0LL);
		  this->fields._LibVersion_k__BackingField = IniParser::Exceptions::ParsingException::GetAssemblyVersion(this, 0LL);
		  sub_18002D1B0((ParsingException *)&this->fields._LibVersion_k__BackingField, v12, v13, v14, v18, v19);
		  this->fields._LineNumber_k__BackingField = lineNumber;
		  this->fields._LineContents_k__BackingField = lineContents;
		  sub_18002D1B0(
		    (ParsingException *)&this->fields._LineContents_k__BackingField,
		    v15,
		    v16,
		    v17,
		    (VolumetricPipelineRT **)innerException,
		    method);
		}
		
	
		// Methods
		private System.Version GetAssemblyVersion() => default; // 0x0000000189B318C8-0x0000000189B318FC
		// Version GetAssemblyVersion()
		Version *IniParser::Exceptions::ParsingException::GetAssemblyVersion(ParsingException *this, MethodInfo *method)
		{
		  Assembly *v2; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  AssemblyName *Name; // rax
		
		  v2 = (Assembly *)sub_180369898(MethodInfo::IniParser::Exceptions::ParsingException::GetAssemblyVersion, method);
		  if ( !v2 || (Name = System::Reflection::Assembly::GetName(v2, 0LL)) == 0LL )
		    sub_1800D8260(v4, v3);
		  return Name->fields.version;
		}
		
	}
}
