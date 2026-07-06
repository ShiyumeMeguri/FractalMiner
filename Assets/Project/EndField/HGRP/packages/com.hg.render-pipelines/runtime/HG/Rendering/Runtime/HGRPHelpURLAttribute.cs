using System;
using System.Diagnostics;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[Conditional("UNITY_EDITOR")]
	internal class HGRPHelpURLAttribute : CoreRPHelpURLAttribute
	{
		public HGRPHelpURLAttribute(string pageName)
		{
			// // HGRPHelpURLAttribute(String)
			// void HG::Rendering::Runtime::HGRPHelpURLAttribute::HGRPHelpURLAttribute(
			//         HGRPHelpURLAttribute *this,
			//         String *pageName,
			//         MethodInfo *method)
			// {
			//   if ( !byte_18D919CD7 )
			//   {
			//     sub_18003C530(&off_18D532390);
			//     byte_18D919CD7 = 1;
			//   }
			//   UnityEngine::Rendering::CoreRPHelpURLAttribute::CoreRPHelpURLAttribute(
			//     (CoreRPHelpURLAttribute *)this,
			//     pageName,
			//     (String *)"com.hg.render-pipelines",
			//     0LL);
			// }
			// 
		}
	}
}
