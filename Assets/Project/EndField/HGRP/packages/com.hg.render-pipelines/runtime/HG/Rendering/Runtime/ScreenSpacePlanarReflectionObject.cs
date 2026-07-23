using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class ScreenSpacePlanarReflectionObject : MonoBehaviour // TypeDefIndex: 38702
	{
		// Fields
		public bool enable; // 0x18
		[Range(0f, 0.5f)]
		public float planeOffset; // 0x1C
		[Range(0f, 0.25f)]
		public float fadenessLeft; // 0x20
		[Range(0.3f, 0.6f)]
		public float fadenessRight; // 0x24
		[Range(0f, 0.1f)]
		public float fadenessThreshold; // 0x28
		[Range(0f, 0.5f)]
		public float fadenessUV; // 0x2C
		public UnityEngine.Color tintColor; // 0x30
		public bool noiseEnable; // 0x40
		public Texture2D noiseTexture; // 0x48
		[Min(0f)]
		public float noiseIntensity; // 0x50
		[Range(0.25f, 1f)]
		public float rtScale; // 0x54
		public ReflectionProbe reflectionProbe; // 0x58
	
		// Constructors
		public ScreenSpacePlanarReflectionObject() {} // 0x0000000189C46638-0x0000000189C46684
		// ScreenSpacePlanarReflectionObject()
		void HG::Rendering::Runtime::ScreenSpacePlanarReflectionObject::ScreenSpacePlanarReflectionObject(
		        ScreenSpacePlanarReflectionObject *this,
		        MethodInfo *method)
		{
		  Vector4 v2; // xmm1
		  __int64 v3; // rdx
		  Vector4 v4; // [rsp+20h] [rbp-18h] BYREF
		
		  this->fields.planeOffset = 0.1;
		  this->fields.fadenessRight = 0.30000001;
		  v2 = *UnityEngine::Vector4::get_one(&v4, (MethodInfo *)this);
		  *(_DWORD *)(v3 + 84) = 1065353216;
		  *(Vector4 *)(v3 + 48) = v2;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		}
		
	}
}
