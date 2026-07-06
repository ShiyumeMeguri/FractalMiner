using System;
using UnityEngine;

namespace HG.Rendering.Runtime.Rain
{
	internal class RainWetnessGlobalProps
	{
		public RainWetnessGlobalProps()
		{
			// // RainWetnessGlobalProps()
			// void HG::Rendering::Runtime::Rain::RainWetnessGlobalProps::RainWetnessGlobalProps(
			//         RainWetnessGlobalProps *this,
			//         MethodInfo *method)
			// {
			//   __int64 v2; // r8
			//   __int64 v3; // r9
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v5; // rdx
			//   Bounds *v6; // r8
			//   Object__Array *v7; // r9
			//   MethodInfo *v8; // [rsp+50h] [rbp+28h]
			//   MethodInfo *v9; // [rsp+58h] [rbp+30h]
			// 
			//   if ( !byte_18D8EDC27 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Vector4);
			//     byte_18D8EDC27 = 1;
			//   }
			//   this.fields.rainWetnessGlobalParams = (Vector4__Array *)il2cpp_array_new_specific_0(
			//                                                              TypeInfo::UnityEngine::Vector4,
			//                                                              11LL,
			//                                                              v2,
			//                                                              v3);
			//   sub_1800054D0((BSP *)&this.fields, v5, v6, v7, v8, v9);
			// }
			// 
		}

		public Vector4[] rainWetnessGlobalParams;

		public bool enableWetness;

		public bool enableWetnessHighQuality;
	}
}
