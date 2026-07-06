using System;
using System.Runtime.CompilerServices;

namespace IniParser.Exceptions
{
	public class ParsingException : Exception
	{
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x000025D2 File Offset: 0x000007D2
		public Version LibVersion
		{
			[CompilerGenerated]
			get
			{
				// // WaterVolumePtr get_value()
				// WaterVolumePtr Beyond::Gameplay::ParamVariable<Beyond::Gameplay::Core::WaterVolumePtr>::get_value(
				//         ParamVariable_1_Beyond_Gameplay_Core_WaterVolumePtr_ *this,
				//         MethodInfo *method)
				// {
				//   return (WaterVolumePtr)this.fields.m_value.id;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x060000BA RID: 186 RVA: 0x00002650 File Offset: 0x00000850
		public uint LineNumber
		{
			[CompilerGenerated]
			get
			{
				// // Int32 get_pressedButtons()
				// int32_t UnityEngine::UIElements::PointerEventBase<System::Object>::get_pressedButtons(
				//         PointerEventBase_1_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._pressedButtons_k__BackingField;
				// }
				// 
				return 0U;
			}
		}

		// (get) Token: 0x060000BB RID: 187 RVA: 0x000025D2 File Offset: 0x000007D2
		public string LineContents
		{
			[CompilerGenerated]
			get
			{
				// // List`1[NodeCanvas.Framework.Internal.BBMappingParameter] get_variablesMap()
				// List_1_NodeCanvas_Framework_Internal_BBMappingParameter_ *NodeCanvas::StateMachines::FSMStateNested<System::Object>::get_variablesMap(
				//         FSMStateNested_1_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._variablesMap;
				// }
				// 
				return null;
			}
		}

		public ParsingException(string msg, uint lineNumber)
		{
			// // ParsingException(String, UInt32)
			// void IniParser::Exceptions::ParsingException::ParsingException(
			//         ParsingException *this,
			//         String *msg,
			//         uint32_t lineNumber,
			//         MethodInfo *method)
			// {
			//   if ( !byte_18D9192F3 )
			//   {
			//     sub_18003C530(&TypeInfo::System::String);
			//     byte_18D9192F3 = 1;
			//   }
			//   IniParser::Exceptions::ParsingException::ParsingException(
			//     this,
			//     msg,
			//     lineNumber,
			//     TypeInfo::System::String.static_fields.Empty,
			//     0LL,
			//     0LL);
			// }
			// 
		}

		public ParsingException(string msg, Exception innerException)
		{
			// // ParsingException(String, Exception)
			// void IniParser::Exceptions::ParsingException::ParsingException(
			//         ParsingException *this,
			//         String *msg,
			//         Exception *innerException,
			//         MethodInfo *method)
			// {
			//   if ( !byte_18D9192F4 )
			//   {
			//     sub_18003C530(&TypeInfo::System::String);
			//     byte_18D9192F4 = 1;
			//   }
			//   IniParser::Exceptions::ParsingException::ParsingException(
			//     this,
			//     msg,
			//     0,
			//     TypeInfo::System::String.static_fields.Empty,
			//     innerException,
			//     0LL);
			// }
			// 
		}

		public ParsingException(string msg, uint lineNumber, string lineContents)
		{
			// // ParsingException(String, UInt32, String)
			// void IniParser::Exceptions::ParsingException::ParsingException(
			//         ParsingException *this,
			//         String *msg,
			//         uint32_t lineNumber,
			//         String *lineContents,
			//         MethodInfo *method)
			// {
			//   IniParser::Exceptions::ParsingException::ParsingException(this, msg, lineNumber, lineContents, 0LL, 0LL);
			// }
			// 
		}

		public ParsingException(string msg, uint lineNumber, string lineContents, Exception innerException)
		{
		}

		private Version GetAssemblyVersion()
		{
			// // Version GetAssemblyVersion()
			// Version *IniParser::Exceptions::ParsingException::GetAssemblyVersion(ParsingException *this, MethodInfo *method)
			// {
			//   Assembly *v2; // rax
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   AssemblyName *Name; // rax
			// 
			//   if ( !byte_18D9192F6 )
			//   {
			//     sub_18003C530(&MethodInfo::IniParser::Exceptions::ParsingException::GetAssemblyVersion);
			//     byte_18D9192F6 = 1;
			//   }
			//   v2 = (Assembly *)sub_180315644(MethodInfo::IniParser::Exceptions::ParsingException::GetAssemblyVersion, method);
			//   if ( !v2 || (Name = System::Reflection::Assembly::GetName(v2, 0LL)) == 0LL )
			//     sub_180B536AC(v4, v3);
			//   return Name.fields.version;
			// }
			// 
			return null;
		}
	}
}
