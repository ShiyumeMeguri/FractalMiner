using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Beyond;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGWaterInteractiveSetting : ScriptableObject // TypeDefIndex: 38783
	{
		// Fields
		[Header("\u6C34\u4F53\u6269\u6563\u6536\u655B\u901F\u5EA6")]
		[Range(0.95f, 1f)]
		public float interactiveDamp; // 0x18
		[Header("\u6C34\u4F53\u6269\u6563Alpha")]
		[Range(0f, 1f)]
		public float interactiveAlpha; // 0x1C
		[Header("\u6C34\u4F53\u6269\u6563Beta")]
		[Range(0f, 1f)]
		public float interactiveBeta; // 0x20
		[Header("\u6C34\u4F53\u6269\u6563\u901F\u5EA6")]
		[Range(0f, 1f)]
		public float interactiveSpeed; // 0x24
		[Header("\u89D2\u8272\u5468\u56F4Ripple\u6A21\u62DF\u5927\u5C0F")]
		[Range(0f, 1f)]
		public float interactiveRippleSize; // 0x28
		[Header("\u89D2\u8272\u5468\u56F4Ripple\u5411\u524D\u504F\u79FB\u8DDD\u79BB")]
		[Range(0f, 1f)]
		public float interactiveRippleForwardOffset; // 0x2C
		[Header("\u9759\u6B62\u6D9F\u6F2A\u4EA7\u751F\u9891\u7387")]
		[Range(0f, 0.2f)]
		public float stillRippleFrequency; // 0x30
		[Header("\u8FD0\u52A8\u6D9F\u6F2A\u4EA7\u751F\u9891\u7387")]
		[Range(0f, 1f)]
		public float moveRippleFrequency; // 0x34
		[Header("PC\u4EA4\u4E92\u6C34\u6CE2\u6CD5\u7EBF\u5F3A\u5EA6(\u5305\u62ECps5\u5E73\u53F0)")]
		[Range(0f, 5f)]
		public float rippleNormalStrengthMultiplierPC; // 0x38
		[Header("Mobile\u4EA4\u4E92\u6C34\u6CE2\u6CD5\u7EBF\u5F3A\u5EA6")]
		[Range(0f, 5f)]
		public float rippleNormalStrengthMultiplierMobile; // 0x3C
		[Header("\u89D2\u8272\u901F\u5EA6\u5BF9Ripple\u9891\u7387\u5F71\u54CD")]
		[Range(0f, 1f)]
		public float characterSpeedRippleFrequencyInfluence; // 0x40
		[Header("\u89D2\u8272\u901F\u5EA6\u5BF9Ripple\u5927\u5C0F\u5F71\u54CD")]
		[Range(0f, 1f)]
		public float characterSpeedRippleSizeInfluence; // 0x44
		[Header("\u5730\u5F62\u6C34\u6CE2\u5F3A\u5EA6\u914D\u7F6E")]
		public float rippleStrengthLerpTime; // 0x48
		public SerializeFieldDictionary<ColliderSurfaceType, float> terrainRippleStrengthConfig; // 0x50
	
		// Constructors
		public HGWaterInteractiveSetting() {} // 0x0000000184D81410-0x0000000184D81440
		// HGWaterInteractiveSetting()
		void HG::Rendering::Runtime::HGWaterInteractiveSetting::HGWaterInteractiveSetting(
		        HGWaterInteractiveSetting *this,
		        MethodInfo *method)
		{
		  this->fields.rippleNormalStrengthMultiplierPC = 1.0;
		  this->fields.rippleNormalStrengthMultiplierMobile = 1.0;
		  this->fields.characterSpeedRippleFrequencyInfluence = 0.1;
		  this->fields.characterSpeedRippleSizeInfluence = 0.1;
		  UnityEngine::ScriptableObject::ScriptableObject((ScriptableObject *)this, 0LL);
		}
		
	}
}
