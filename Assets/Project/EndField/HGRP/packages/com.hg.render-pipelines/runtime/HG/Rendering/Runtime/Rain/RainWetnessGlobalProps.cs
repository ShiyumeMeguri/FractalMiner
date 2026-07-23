using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime.Rain
{
	internal class RainWetnessGlobalProps // TypeDefIndex: 38847
	{
		// Fields
		public Vector4[] rainWetnessGlobalParams; // 0x10
		public bool enableWetness; // 0x18
		public bool enableWetnessHighQuality; // 0x19
	
		// Constructors
		public RainWetnessGlobalProps() {} // 0x0000000182EDEDE0-0x0000000182EDEE10
		// RainWetnessGlobalProps()
		void HG::Rendering::Runtime::Rain::RainWetnessGlobalProps::RainWetnessGlobalProps(
		        RainWetnessGlobalProps *this,
		        MethodInfo *method)
		{
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v3; // rdx
		  VolumetricRenderer_VolumetricBounds *v4; // r8
		  Int32__Array **v5; // r9
		  MethodInfo *v6; // [rsp+50h] [rbp+28h]
		  MethodInfo *v7; // [rsp+58h] [rbp+30h]
		  int32_t v8; // [rsp+60h] [rbp+38h]
		  int32_t v9; // [rsp+68h] [rbp+40h]
		  float v10; // [rsp+70h] [rbp+48h]
		  int32_t v11; // [rsp+78h] [rbp+50h]
		  bool v12; // [rsp+80h] [rbp+58h]
		  bool v13; // [rsp+88h] [rbp+60h]
		  MethodInfo *v14; // [rsp+90h] [rbp+68h]
		
		  this->fields.rainWetnessGlobalParams = (Vector4__Array *)il2cpp_array_new_specific_1(
		                                                             TypeInfo::UnityEngine::Vector4,
		                                                             11LL);
		  sub_18002D1B0(
		    (VolumetricRenderer_VolumetricRenderItem *)&this->fields,
		    v3,
		    v4,
		    v5,
		    v6,
		    v7,
		    v8,
		    v9,
		    v10,
		    v11,
		    v12,
		    v13,
		    v14);
		}
		
	}
}
