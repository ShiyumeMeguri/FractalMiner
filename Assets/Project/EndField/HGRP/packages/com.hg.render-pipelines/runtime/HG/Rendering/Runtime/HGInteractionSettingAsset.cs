using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[CreateAssetMenu(fileName = "HGInteractionSettingAsset", menuName = "\u2605 Beyond/HGInteraction/HGInteractionSettingAsset")]
	public class HGInteractionSettingAsset : ScriptableObject // TypeDefIndex: 37753
	{
		// Fields
		public Material decalInteractionMaterial; // 0x18
		public float decalNodeWidth; // 0x20
		public float decalNodeLength; // 0x24
		public float decalNodeHeadLength; // 0x28
		[Range(-1f, 1f)]
		public float decalNodeOffset; // 0x2C
		[Range(0f, 0.5f)]
		public float nodeDistanceThreshold; // 0x30
		[Range(0f, 1f)]
		public float edgeFadeDistance; // 0x34
		[Range(0f, 1f)]
		public float heightFadeDistanceMin; // 0x38
		[Range(0f, 1f)]
		public float heightFadeDistanceMax; // 0x3C
		[Range(-1f, 1f)]
		public float rotationThreshold; // 0x40
		[Range(-1f, 1f)]
		public float backwardDistanceThreshold; // 0x44
		[Range(0f, 1f)]
		public float timeFadeSpeed; // 0x48
	
		// Constructors
		public HGInteractionSettingAsset() {} // 0x0000000184D5DDC0-0x0000000184D5DE10
		// HGInteractionSettingAsset()
		void HG::Rendering::Runtime::HGInteractionSettingAsset::HGInteractionSettingAsset(
		        HGInteractionSettingAsset *this,
		        MethodInfo *method)
		{
		  this->fields.decalNodeWidth = 0.15000001;
		  this->fields.decalNodeLength = 0.25;
		  this->fields.decalNodeHeadLength = 0.25;
		  this->fields.decalNodeOffset = 0.15000001;
		  this->fields.nodeDistanceThreshold = 0.2;
		  this->fields.edgeFadeDistance = 0.2;
		  this->fields.heightFadeDistanceMin = 0.1;
		  this->fields.heightFadeDistanceMax = 0.15000001;
		  this->fields.rotationThreshold = 0.89999998;
		  this->fields.timeFadeSpeed = 0.15000001;
		  UnityEngine::ScriptableObject::ScriptableObject((ScriptableObject *)this, 0LL);
		}
		
	}
}
