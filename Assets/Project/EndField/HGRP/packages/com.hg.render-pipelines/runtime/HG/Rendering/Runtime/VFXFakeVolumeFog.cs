using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Beyond;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[AddComponentMenu("Rendering/Fake Volume Fog(\u5047\u96FE)")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
	public class VFXFakeVolumeFog : TickableMono, IBeyondTrigger, IBeyondTriggerTransform, IBeyondTriggerShape, IBeyondTriggerProxy // TypeDefIndex: 37931
	{
		// Fields
		public bool LightArtUSE; // 0x68
		public bool enableDistanceCullTick; // 0x69
		private MeshRenderer m_meshRenderer; // 0x70
		private MeshFilter m_meshFilter; // 0x78
		[NonSerialized]
		public Material instanceMaterial; // 0x80
		private MaterialPropertyBlock m_mpb; // 0x88
		private Material m_keywordMaterial; // 0x90
		private bool m_runtimeInitialized; // 0x98
		private static readonly int s_NearFadeDistance; // 0x00
		private static readonly int s_FogColor; // 0x04
		private static readonly int s_FogExponent; // 0x08
		private static readonly int s_FogDensity; // 0x0C
		private static readonly int s_CubEdgeFade; // 0x10
		private static readonly int s_NoiseTex3D; // 0x14
		private static readonly int s_NoiseIntensity; // 0x18
		private static readonly int s_NoiseTexTilling1; // 0x1C
		private static readonly int s_NoiseFar; // 0x20
		private static readonly int s_NoiseFarIntensity; // 0x24
		private static readonly int s_NoiseUVWDir1; // 0x28
		private static readonly int s_NoiseUVWSpeed1; // 0x2C
		private static readonly int s_HeightOffset; // 0x30
		private static readonly int s_HeightFalloff; // 0x34
		private static readonly int s_VerticalFalloffMin; // 0x38
		private static readonly int s_VerticalFalloffMax; // 0x3C
		private static readonly int s_FogDepthStart; // 0x40
		private static readonly int s_FogDepthEnd; // 0x44
		private static readonly int s_UseFog; // 0x48
		private static readonly int s_FogIntensity; // 0x4C
		private static readonly int s_FogIntensityFadeOutDistance; // 0x50
		private static readonly int s_FogIntensityFadeDistance; // 0x54
		private static readonly int s_FogIntensityFadeUseCenter; // 0x58
		private static readonly int s_NearDisplayDistance; // 0x5C
		private static readonly int s_StencilWriteMask; // 0x60
		private static readonly int s_StencilReadMask; // 0x64
		private static readonly int s_StencilRef; // 0x68
		private static readonly int s_StencilComp; // 0x6C
		private static readonly int s_StencilOp; // 0x70
		private static readonly int s_CanWalkIn; // 0x74
		private static readonly int s_NearDisplay; // 0x78
		public bool canWalkIn; // 0x99
		[Min(0.01f)]
		public float nearFadeDisatance; // 0x9C
		public bool nearDisplay; // 0xA0
		[Min(0.01f)]
		public float nearDisplayDisatance; // 0xA4
		public bool excludeCharacter; // 0xA8
		[ColorUsage(true, true)]
		public UnityEngine.Color fogColor; // 0xAC
		[Range(0.005f, 0.2f)]
		public float fogExponent; // 0xBC
		[Range(0.1f, 10f)]
		public float fogDensity; // 0xC0
		[Range(0f, 200f)]
		public float fogDepthStart; // 0xC4
		[Range(0f, 1f)]
		public float fogDepthEnd; // 0xC8
		public bool fogIntensityFadeUseCenter; // 0xCC
		[Range(10f, 10000f)]
		public float fogIntensityFadeDistance; // 0xD0
		[Range(-0.5f, 0.5f)]
		public float heightOffset; // 0xD4
		[Range(1f, 10f)]
		public float heightFalloff; // 0xD8
		public Vector2 verticalFalloffRange; // 0xDC
		[Range(0.5f, 1f)]
		public float cubeEdge; // 0xE4
		public bool useNoise3D; // 0xE8
		[Range(1f, 100f)]
		public float noiseFar; // 0xEC
		public float noiseIntensity; // 0xF0
		public float noiseFarIntensity; // 0xF4
		public Vector3 noiseTilling; // 0xF8
		[Range(0f, 0.05f)]
		public float noiseTillingLightArtUSE; // 0x104
		public Vector3 noiseDir; // 0x108
		public float noiseSpeed; // 0x114
		[Range(0f, 2f)]
		public float noiseSpeedLightArtUSE; // 0x118
		public bool useFog; // 0x11C
		[Range(0f, 1f)]
		public float fogIntensity; // 0x120
		[Range(10f, 10000f)]
		public float fogIntensityFadeOutDistance; // 0x124
		private static Camera s_cachedMainCamera; // 0x80
		private static int s_cameraCheckFrame; // 0x88
	
		// Properties
		public MeshRenderer meshRender { get => default; } // 0x0000000183521830-0x0000000183521860 
		// MeshRenderer get_meshRender()
		MeshRenderer *HG::Rendering::Runtime::VFXFakeVolumeFog::get_meshRender(VFXFakeVolumeFog *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2359, 0LL) )
		    return this->fields.m_meshRenderer;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2359, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_928(Patch, (Object *)this, 0LL);
		}
		
		public MeshFilter meshFilter { get => default; } // 0x00000001835237C0-0x00000001835237F0 
		// MeshFilter get_meshFilter()
		MeshFilter *HG::Rendering::Runtime::VFXFakeVolumeFog::get_meshFilter(VFXFakeVolumeFog *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2360, 0LL) )
		    return this->fields.m_meshFilter;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2360, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_929(Patch, (Object *)this, 0LL);
		}
		
		protected override float tickInterval { get => default; } // 0x000000018495AF50-0x000000018495AF80 
		// Single get_tickInterval()
		float HG::Rendering::Runtime::VFXFakeVolumeFog::get_tickInterval(VFXFakeVolumeFog *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2361, 0LL) )
		    return 1.0;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2361, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		}
		
		protected override TickType tickOption { get => default; } // 0x000000018444B7F0-0x000000018444B830 
		// TickType get_tickOption()
		TickType__Enum HG::Rendering::Runtime::VFXFakeVolumeFog::get_tickOption(VFXFakeVolumeFog *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2362, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2362, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		  }
		  else if ( this->fields.LightArtUSE )
		  {
		    return this->fields.enableDistanceCullTick ? 8 : 0;
		  }
		  else
		  {
		    return 0;
		  }
		}
		
		public ulong uniqueTriggerId { get; set; } // 0x0000000184D8D910-0x0000000184D8D920 0x0000000184DA14B0-0x0000000184DA14C0
		// HashSet`1[PaintIn3D.P3dPaintableTexture] get_PaintableTextures()
		HashSet_1_PaintIn3D_P3dPaintableTexture_ *PaintIn3D::P3dPaintable::get_PaintableTextures(
		        P3dPaintable *this,
		        MethodInfo *method)
		{
		  return this->fields.paintableTextures;
		}
		

		// Void set_scrollDelta(Vector2)
		void UnityEngine::EventSystems::PointerEventData::set_scrollDelta(
		        PointerEventData *this,
		        Vector2 value,
		        MethodInfo *method)
		{
		  this->fields._scrollDelta_k__BackingField = value;
		}
		
		public ETriggerLogicType triggerLogicType { get => default; } // 0x0000000189B5C744-0x0000000189B5C794 
		// ETriggerLogicType get_triggerLogicType()
		ETriggerLogicType__Enum HG::Rendering::Runtime::VFXFakeVolumeFog::get_triggerLogicType(
		        VFXFakeVolumeFog *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2388, 0LL) )
		    return 3;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2388, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
		public Vector3 position { get => default; } // 0x0000000189B5C49C-0x0000000189B5C524 
		// Vector3 get_position()
		Vector3 *HG::Rendering::Runtime::VFXFakeVolumeFog::get_position(
		        Vector3 *__return_ptr retstr,
		        VFXFakeVolumeFog *this,
		        MethodInfo *method)
		{
		  Transform *transform; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector3 *position; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // xmm0_8
		  float z; // eax
		  Vector3 v13[2]; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2389, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2389, 0LL);
		    if ( Patch )
		    {
		      position = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_368(v13, Patch, (Object *)this, 0LL);
		      goto LABEL_7;
		    }
		LABEL_5:
		    sub_1800D8260(v7, v6);
		  }
		  transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
		  if ( !transform )
		    goto LABEL_5;
		  position = UnityEngine::Transform::get_position(v13, transform, 0LL);
		LABEL_7:
		  v10 = *(_QWORD *)&position->x;
		  z = position->z;
		  *(_QWORD *)&retstr->x = v10;
		  retstr->z = z;
		  return retstr;
		}
		
		public Quaternion rotation { get => default; } // 0x0000000189B5C524-0x0000000189B5C5A4 
		// Quaternion get_rotation()
		Quaternion *HG::Rendering::Runtime::VFXFakeVolumeFog::get_rotation(
		        Quaternion *__return_ptr retstr,
		        VFXFakeVolumeFog *this,
		        MethodInfo *method)
		{
		  Transform *transform; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Quaternion *rotation; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Quaternion v10; // xmm0
		  Quaternion *result; // rax
		  Quaternion v12; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2390, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2390, 0LL);
		    if ( Patch )
		    {
		      rotation = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_935(&v12, Patch, (Object *)this, 0LL);
		      goto LABEL_7;
		    }
		LABEL_5:
		    sub_1800D8260(v7, v6);
		  }
		  transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
		  if ( !transform )
		    goto LABEL_5;
		  rotation = UnityEngine::Transform::get_rotation(&v12, transform, 0LL);
		LABEL_7:
		  v10 = *rotation;
		  result = retstr;
		  *retstr = v10;
		  return result;
		}
		
		public int shapeType { get => default; } // 0x0000000189B5C6F4-0x0000000189B5C744 
		// Int32 get_shapeType()
		int32_t HG::Rendering::Runtime::VFXFakeVolumeFog::get_shapeType(VFXFakeVolumeFog *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2391, 0LL) )
		    return 2;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2391, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
		public Vector3 shapeOffset { get => default; } // 0x0000000189B5C5A4-0x0000000189B5C618 
		// Vector3 get_shapeOffset()
		Vector3 *HG::Rendering::Runtime::VFXFakeVolumeFog::get_shapeOffset(
		        Vector3 *__return_ptr retstr,
		        VFXFakeVolumeFog *this,
		        MethodInfo *method)
		{
		  Animator *v5; // rdx
		  int32_t v6; // r8d
		  MethodInfo *v7; // r9
		  Vector3 *Vector; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  __int64 v12; // xmm0_8
		  float z; // eax
		  Vector3 v15[2]; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2392, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2392, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    Vector = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_368(v15, Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    Vector = UnityEngine::Animator::GetVector(v15, v5, v6, v7);
		  }
		  v12 = *(_QWORD *)&Vector->x;
		  z = Vector->z;
		  *(_QWORD *)&retstr->x = v12;
		  retstr->z = z;
		  return retstr;
		}
		
		public Vector3 shapeSize { get => default; } // 0x0000000189B5C66C-0x0000000189B5C6F4 
		// Vector3 get_shapeSize()
		Vector3 *HG::Rendering::Runtime::VFXFakeVolumeFog::get_shapeSize(
		        Vector3 *__return_ptr retstr,
		        VFXFakeVolumeFog *this,
		        MethodInfo *method)
		{
		  Transform *transform; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector3 *lossyScale; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // xmm0_8
		  float z; // eax
		  Vector3 v13[2]; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2393, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2393, 0LL);
		    if ( Patch )
		    {
		      lossyScale = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_368(v13, Patch, (Object *)this, 0LL);
		      goto LABEL_7;
		    }
		LABEL_5:
		    sub_1800D8260(v7, v6);
		  }
		  transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
		  if ( !transform )
		    goto LABEL_5;
		  lossyScale = UnityEngine::Transform::get_lossyScale(v13, transform, 0LL);
		LABEL_7:
		  v10 = *(_QWORD *)&lossyScale->x;
		  z = lossyScale->z;
		  *(_QWORD *)&retstr->x = v10;
		  retstr->z = z;
		  return retstr;
		}
		
		public float shapeRadius { get => default; } // 0x0000000189B5C618-0x0000000189B5C66C 
		// Single get_shapeRadius()
		float HG::Rendering::Runtime::VFXFakeVolumeFog::get_shapeRadius(VFXFakeVolumeFog *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2394, 0LL) )
		    return 1.0;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2394, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		}
		
	
		// Constructors
		public VFXFakeVolumeFog() {} // 0x000000018446DC90-0x000000018446DDD0
		// VFXFakeVolumeFog()
		void HG::Rendering::Runtime::VFXFakeVolumeFog::VFXFakeVolumeFog(VFXFakeVolumeFog *this, MethodInfo *method)
		{
		  Vector4 v2; // xmm1
		  __int64 v3; // r8
		  Vector4 v4; // [rsp+20h] [rbp-18h] BYREF
		
		  this->fields.enableDistanceCullTick = 1;
		  this->fields.nearFadeDisatance = 1.0;
		  this->fields.nearDisplayDisatance = 1.0;
		  v2 = *UnityEngine::Vector4::get_one(&v4, method);
		  *(_DWORD *)(v3 + 188) = 1000593162;
		  *(_QWORD *)(v3 + 248) = _mm_unpacklo_ps((__m128)0x3E4CCCCDu, (__m128)0x3E4CCCCDu).m128_u64[0];
		  *(_DWORD *)(v3 + 256) = 1045220557;
		  *(_QWORD *)(v3 + 264) = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0LL).m128_u64[0];
		  *(_DWORD *)(v3 + 272) = 0;
		  *(Vector4 *)(v3 + 172) = v2;
		  *(_DWORD *)(v3 + 192) = 1065353216;
		  *(_DWORD *)(v3 + 208) = 1148846080;
		  *(_DWORD *)(v3 + 212) = 1056964608;
		  *(_DWORD *)(v3 + 216) = 1065353216;
		  *(_DWORD *)(v3 + 220) = 1065353216;
		  *(_DWORD *)(v3 + 224) = 1065353216;
		  *(_DWORD *)(v3 + 228) = 1056964608;
		  *(_DWORD *)(v3 + 236) = 1065353216;
		  *(_DWORD *)(v3 + 240) = 1065353216;
		  *(_DWORD *)(v3 + 244) = 1065353216;
		  *(_DWORD *)(v3 + 260) = 1008981770;
		  *(_DWORD *)(v3 + 276) = 1036831949;
		  *(_DWORD *)(v3 + 280) = 1008981770;
		  *(_DWORD *)(v3 + 288) = 1065353216;
		  *(_DWORD *)(v3 + 292) = 1157234688;
		  Beyond::TickableMono::TickableMono((TickableMono *)v3, 0LL);
		}
		
		static VFXFakeVolumeFog() {} // 0x0000000184851500-0x00000001848518F0
		// VFXFakeVolumeFog()
		void HG::Rendering::Runtime::VFXFakeVolumeFog::cctor(MethodInfo *method)
		{
		  TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_NearFadeDistance = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_NearFadeDistance",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_FogColor = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_FogColor",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_FogExponent = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_FogExponent",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_FogDensity = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_FogDensity",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_CubEdgeFade = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_CubEdgeFade",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_NoiseTex3D = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_NoiseTex3D",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_NoiseIntensity = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_NoiseIntensity",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_NoiseTexTilling1 = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_NoiseTexTilling1",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_NoiseFar = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_NoiseFar",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_NoiseFarIntensity = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_NoiseFarIntensity",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_NoiseUVWDir1 = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_NoiseUVWDir1",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_NoiseUVWSpeed1 = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_NoiseUVWSpeed1",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_HeightOffset = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_HeightOffset",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_HeightFalloff = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_HeightFalloff",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_VerticalFalloffMin = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_VerticalFalloffMin",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_VerticalFalloffMax = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_VerticalFalloffMax",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_FogDepthStart = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_FogDepthStart",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_FogDepthEnd = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_FogDepthEnd",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_UseFog = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_UseFog",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_FogIntensity = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_FogIntensity",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_FogIntensityFadeOutDistance = UnityEngine::Shader::PropertyToID((String *)"_FogIntensityFadeOutDistance", 0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_FogIntensityFadeDistance = UnityEngine::Shader::PropertyToID(
		                                                                                                    (String *)"_FogIntensityFadeDistance",
		                                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_FogIntensityFadeUseCenter = UnityEngine::Shader::PropertyToID(
		                                                                                                     (String *)"_FogIntensityFadeUseCenter",
		                                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_NearDisplayDistance = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_NearDisplayDistance",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_StencilWriteMask = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_StencilWriteMask",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_StencilReadMask = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_StencilReadMask",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_StencilRef = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_StencilRef",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_StencilComp = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_StencilComp",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_StencilOp = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_StencilOp",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_CanWalkIn = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_canWalkIn",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_NearDisplay = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_nearDisplay",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_cameraCheckFrame = -1;
		}
		
	
		// Methods
		private void OnCanWalkInChanged() {} // 0x0000000189B5C14C-0x0000000189B5C1A4
		// Void OnCanWalkInChanged()
		void HG::Rendering::Runtime::VFXFakeVolumeFog::OnCanWalkInChanged(VFXFakeVolumeFog *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2363, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2363, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else if ( this->fields.canWalkIn )
		  {
		    this->fields.nearDisplay = 0;
		  }
		}
		
		private void OnNearDisplayChanged() {} // 0x0000000189B5C1A4-0x0000000189B5C1FC
		// Void OnNearDisplayChanged()
		void HG::Rendering::Runtime::VFXFakeVolumeFog::OnNearDisplayChanged(VFXFakeVolumeFog *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2364, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2364, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else if ( this->fields.nearDisplay )
		  {
		    this->fields.canWalkIn = 0;
		  }
		}
		
		private void _InitMeshFilterAndRender() {} // 0x0000000183523D30-0x0000000183523E80
		// Void _InitMeshFilterAndRender()
		void HG::Rendering::Runtime::VFXFakeVolumeFog::_InitMeshFilterAndRender(VFXFakeVolumeFog *this, MethodInfo *method)
		{
		  MeshFilter *m_meshFilter; // rdi
		  MeshRenderer *m_meshRenderer; // rdi
		  HGRuntimeGrassQuery_Node *v5; // rdx
		  HGRuntimeGrassQuery_Node *v6; // r8
		  Int32__Array **v7; // r9
		  HGRuntimeGrassQuery_Node *v8; // rdx
		  HGRuntimeGrassQuery_Node *v9; // r8
		  Int32__Array **v10; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  MethodInfo *v14; // [rsp+20h] [rbp-8h]
		  MethodInfo *v15; // [rsp+50h] [rbp+28h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2365, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2365, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v13, v12);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    m_meshFilter = this->fields.m_meshFilter;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( !m_meshFilter )
		      goto LABEL_19;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( !m_meshFilter->fields._._.m_CachedPtr )
		    {
		LABEL_19:
		      this->fields.m_meshFilter = (MeshFilter *)UnityEngine::Component::GetComponent<System::Object>(
		                                                  (Component *)this,
		                                                  MethodInfo::UnityEngine::Component::GetComponent<UnityEngine::MeshFilter>);
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_meshFilter, v5, v6, v7, v14);
		    }
		    m_meshRenderer = this->fields.m_meshRenderer;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( !m_meshRenderer )
		      goto LABEL_20;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( !m_meshRenderer->fields._._._.m_CachedPtr )
		    {
		LABEL_20:
		      this->fields.m_meshRenderer = (MeshRenderer *)UnityEngine::Component::GetComponent<System::Object>(
		                                                      (Component *)this,
		                                                      MethodInfo::UnityEngine::Component::GetComponent<UnityEngine::MeshRenderer>);
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_meshRenderer, v8, v9, v10, v15);
		    }
		  }
		}
		
		protected override void OnAwake() {} // 0x0000000183523090-0x00000001835230D0
		// Void OnAwake()
		void HG::Rendering::Runtime::VFXFakeVolumeFog::OnAwake(VFXFakeVolumeFog *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2366, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2366, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    Beyond::TickableMono::OnAwake((TickableMono *)this, 0LL);
		    HG::Rendering::Runtime::VFXFakeVolumeFog::_InitMeshFilterAndRender(this, 0LL);
		  }
		}
		
		public override void Tick(float deltaTime) {} // 0x0000000183E4F3C0-0x0000000183E4F760
		// Void Tick(Single)
		void HG::Rendering::Runtime::VFXFakeVolumeFog::Tick(VFXFakeVolumeFog *this, float deltaTime, MethodInfo *method)
		{
		  struct Object_1__Class *v4; // rcx
		  MeshRenderer *m_meshRenderer; // rdi
		  int32_t frameCount; // edi
		  VFXFakeVolumeFog__StaticFields *static_fields; // rdx
		  Camera *s_cachedMainCamera; // rdi
		  struct Object_1__Class *v9; // rcx
		  Component *v10; // rcx
		  Transform *transform; // rdi
		  void (__fastcall *v12)(Transform *, MethodInfo **); // rax
		  Transform *v13; // rdi
		  void (__fastcall *v14)(Transform *, __int64 *); // rax
		  __int64 v15; // r8
		  float v16; // xmm7_4
		  __m128 v17; // xmm6
		  float v18; // xmm8_4
		  Renderer *v19; // rdi
		  float fogIntensityFadeDistance; // xmm9_4
		  __m128d v21; // xmm1
		  double v22; // xmm0_8
		  float v23; // xmm0_4
		  Camera *main; // rax
		  HGRuntimeGrassQuery_Node *v25; // rdx
		  HGRuntimeGrassQuery_Node *v26; // r8
		  Int32__Array **v27; // r9
		  struct VFXFakeVolumeFog__Class *v28; // rcx
		  Camera *v29; // rsi
		  __int64 v30; // rax
		  __int64 v31; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v33; // [rsp+20h] [rbp-68h] BYREF
		  float v34; // [rsp+28h] [rbp-60h]
		  __int64 v35; // [rsp+30h] [rbp-58h] BYREF
		  float v36; // [rsp+38h] [rbp-50h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2367, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2367, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15(
		        (ILFixDynamicMethodWrapper_18 *)Patch,
		        (Object *)this,
		        deltaTime,
		        0LL);
		      return;
		    }
		    goto LABEL_35;
		  }
		  if ( this->fields.LightArtUSE )
		  {
		    v4 = TypeInfo::UnityEngine::Object;
		    m_meshRenderer = this->fields.m_meshRenderer;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v4 = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v4 = TypeInfo::UnityEngine::Object;
		      }
		    }
		    if ( m_meshRenderer )
		    {
		      if ( !v4->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(v4);
		      if ( m_meshRenderer->fields._._._.m_CachedPtr )
		      {
		        frameCount = UnityEngine::Time::get_frameCount(0LL);
		        if ( !TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog);
		        static_fields = TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields;
		        if ( static_fields->s_cameraCheckFrame != frameCount )
		        {
		          main = UnityEngine::Camera::get_main(0LL);
		          v28 = TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog;
		          v29 = main;
		          if ( !TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog);
		            v28 = TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog;
		          }
		          v28->static_fields->s_cachedMainCamera = v29;
		          sub_18002D1B0(
		            (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_cachedMainCamera,
		            v25,
		            v26,
		            v27,
		            v33);
		          TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_cameraCheckFrame = frameCount;
		        }
		        if ( !TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog);
		        s_cachedMainCamera = TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_cachedMainCamera;
		        v9 = TypeInfo::UnityEngine::Object;
		        if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          v9 = TypeInfo::UnityEngine::Object;
		          if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		            v9 = TypeInfo::UnityEngine::Object;
		          }
		        }
		        if ( s_cachedMainCamera )
		        {
		          if ( !v9->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(v9);
		          if ( s_cachedMainCamera->fields._._._.m_CachedPtr )
		          {
		            if ( !TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->_1.cctor_finished_or_no_cctor )
		              il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog);
		            v10 = (Component *)TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_cachedMainCamera;
		            if ( v10 )
		            {
		              transform = UnityEngine::Component::get_transform(v10, 0LL);
		              if ( transform )
		              {
		                v33 = 0LL;
		                v34 = 0.0;
		                v12 = (void (__fastcall *)(Transform *, MethodInfo **))qword_18F3700F0;
		                if ( !qword_18F3700F0 )
		                {
		                  v12 = (void (__fastcall *)(Transform *, MethodInfo **))il2cpp_resolve_icall_1(
		                                                                           "UnityEngine.Transform::get_position_Injected("
		                                                                           "UnityEngine.Vector3&)");
		                  if ( !v12 )
		                  {
		                    v30 = sub_1802EE1B8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		                    sub_18007E1B0(v30, 0LL);
		                  }
		                  qword_18F3700F0 = (__int64)v12;
		                }
		                v12(transform, &v33);
		                v13 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		                if ( v13 )
		                {
		                  v35 = 0LL;
		                  v36 = 0.0;
		                  v14 = (void (__fastcall *)(Transform *, __int64 *))qword_18F3700F0;
		                  if ( !qword_18F3700F0 )
		                  {
		                    v14 = (void (__fastcall *)(Transform *, __int64 *))il2cpp_resolve_icall_1(
		                                                                         "UnityEngine.Transform::get_position_Injected(Un"
		                                                                         "ityEngine.Vector3&)");
		                    if ( !v14 )
		                    {
		                      v31 = sub_1802EE1B8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		                      sub_18007E1B0(v31, 0LL);
		                    }
		                    qword_18F3700F0 = (__int64)v14;
		                  }
		                  v14(v13, &v35);
		                  v10 = (Component *)TypeInfo::System::Math;
		                  v17 = (__m128)HIDWORD(v33);
		                  v16 = *(float *)&v33 - *(float *)&v35;
		                  v17.m128_f32[0] = *((float *)&v33 + 1) - *((float *)&v35 + 1);
		                  v18 = v34 - v36;
		                  if ( !TypeInfo::System::Math->_1.cctor_finished_or_no_cctor )
		                    il2cpp_runtime_class_init_1(TypeInfo::System::Math);
		                  v19 = (Renderer *)this->fields.m_meshRenderer;
		                  fogIntensityFadeDistance = this->fields.fogIntensityFadeDistance;
		                  if ( v19 )
		                  {
		                    v17.m128_f32[0] = (float)((float)(v17.m128_f32[0] * v17.m128_f32[0]) + (float)(v16 * v16))
		                                    + (float)(v18 * v18);
		                    v21 = _mm_cvtps_pd(v17);
		                    if ( v21.m128d_f64[0] < 0.0 )
		                      v22 = sub_1801D32D0(v10, static_fields, v15);
		                    else
		                      *(_QWORD *)&v22 = *(_OWORD *)&_mm_sqrt_pd(v21);
		                    v23 = v22;
		                    UnityEngine::Renderer::set_enabled(v19, fogIntensityFadeDistance > v23, 0LL);
		                    return;
		                  }
		                }
		              }
		            }
		LABEL_35:
		            sub_1800D8260(v10, static_fields);
		          }
		        }
		      }
		    }
		  }
		}
		
		private void Update() {} // 0x0000000183B92340-0x0000000183B923D0
		// Void Update()
		void HG::Rendering::Runtime::VFXFakeVolumeFog::Update(VFXFakeVolumeFog *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  unsigned __int8 (*v5)(void); // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_10;
		  if ( wrapperArray->max_length.size > 2368 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( v3 )
		    {
		      if ( LODWORD(v3->_0.namespaze) <= 0x940 )
		        sub_1800D2AB0(v3, wrapperArray);
		      if ( !v3[50].interfaceOffsets )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(2368, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		        return;
		      }
		    }
		LABEL_10:
		    sub_1800D8260(v3, wrapperArray);
		  }
		LABEL_5:
		  v5 = (unsigned __int8 (*)(void))qword_18F36EFD8;
		  if ( !qword_18F36EFD8 )
		  {
		    v5 = (unsigned __int8 (*)(void))il2cpp_resolve_icall_1("UnityEngine.Application::get_isPlaying()");
		    if ( !v5 )
		    {
		      v7 = sub_1802EE1B8("UnityEngine.Application::get_isPlaying()");
		      sub_18007E1B0(v7, 0LL);
		    }
		    qword_18F36EFD8 = (__int64)v5;
		  }
		  if ( !v5() || this->fields.nearDisplay || !this->fields.m_runtimeInitialized )
		    HG::Rendering::Runtime::VFXFakeVolumeFog::_UpdateMaterial(this, 0LL);
		}
		
		public void ForceRefresh() {} // 0x0000000189B5BFB0-0x0000000189B5C0C0
		// Void ForceRefresh()
		void HG::Rendering::Runtime::VFXFakeVolumeFog::ForceRefresh(VFXFakeVolumeFog *this, MethodInfo *method)
		{
		  Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *v6; // rdi
		  Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *v7; // rax
		  Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *v8; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2378, 0LL) )
		  {
		    HG::Rendering::Runtime::VFXFakeVolumeFog::_InitMeshFilterAndRender(this, 0LL);
		    v3 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *)sub_18002C620(TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,UnityEngine::Camera>);
		    v6 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *)v3;
		    if ( v3 )
		    {
		      System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Object>::Action(
		        v3,
		        (Object *)this,
		        MethodInfo::HG::Rendering::Runtime::VFXFakeVolumeFog::OnBeginCameraRendering,
		        0LL);
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::RenderPipelineManager);
		      UnityEngine::Rendering::RenderPipelineManager::remove_beginCameraRendering(v6, 0LL);
		      if ( UnityEngine::Application::get_isPlaying(0LL) && !this->fields.canWalkIn && !this->fields.nearDisplay )
		        goto LABEL_8;
		      v7 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *)sub_18002C620(TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,UnityEngine::Camera>);
		      v8 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *)v7;
		      if ( v7 )
		      {
		        System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Object>::Action(
		          v7,
		          (Object *)this,
		          MethodInfo::HG::Rendering::Runtime::VFXFakeVolumeFog::OnBeginCameraRendering,
		          0LL);
		        sub_1800036A0(TypeInfo::UnityEngine::Rendering::RenderPipelineManager);
		        UnityEngine::Rendering::RenderPipelineManager::add_beginCameraRendering(v8, 0LL);
		LABEL_8:
		        HG::Rendering::Runtime::VFXFakeVolumeFog::_UpdateMaterial(this, 0LL);
		        HG::Rendering::Runtime::VFXFakeVolumeFog::_UpdateMesh(this, 0LL);
		        return;
		      }
		    }
		LABEL_10:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2378, 0LL);
		  if ( !Patch )
		    goto LABEL_10;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		protected override void OnEnable() {} // 0x00000001835230D0-0x0000000183523220
		// Void OnEnable()
		void HG::Rendering::Runtime::VFXFakeVolumeFog::OnEnable(VFXFakeVolumeFog *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  Renderer *m_meshRenderer; // rcx
		  Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *v5; // rax
		  Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *v6; // rdi
		  Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *v7; // rax
		  Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *v8; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2381, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2381, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		      return;
		    }
		    goto LABEL_12;
		  }
		  Beyond::TickableMono::OnEnable((TickableMono *)this, 0LL);
		  HG::Rendering::Runtime::VFXFakeVolumeFog::_InitMeshFilterAndRender(this, 0LL);
		  m_meshRenderer = (Renderer *)this->fields.m_meshRenderer;
		  if ( !m_meshRenderer )
		    goto LABEL_12;
		  UnityEngine::Renderer::set_enabled(m_meshRenderer, !this->fields.nearDisplay, 0LL);
		  v5 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *)sub_1800368D0(TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,UnityEngine::Camera>);
		  v6 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *)v5;
		  if ( !v5 )
		    goto LABEL_12;
		  System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Object>::Action(
		    v5,
		    (Object *)this,
		    MethodInfo::HG::Rendering::Runtime::VFXFakeVolumeFog::OnBeginCameraRendering,
		    0LL);
		  if ( !TypeInfo::UnityEngine::Rendering::RenderPipelineManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::RenderPipelineManager);
		  UnityEngine::Rendering::RenderPipelineManager::remove_beginCameraRendering(v6, 0LL);
		  if ( UnityEngine::Application::get_isPlaying(0LL) && !this->fields.canWalkIn && !this->fields.nearDisplay )
		    goto LABEL_9;
		  v7 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *)sub_1800368D0(TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,UnityEngine::Camera>);
		  v8 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *)v7;
		  if ( !v7 )
		LABEL_12:
		    sub_1800D8260(m_meshRenderer, v3);
		  System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Object>::Action(
		    v7,
		    (Object *)this,
		    MethodInfo::HG::Rendering::Runtime::VFXFakeVolumeFog::OnBeginCameraRendering,
		    0LL);
		  if ( !TypeInfo::UnityEngine::Rendering::RenderPipelineManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::RenderPipelineManager);
		  UnityEngine::Rendering::RenderPipelineManager::add_beginCameraRendering(v8, 0LL);
		LABEL_9:
		  this->fields.m_runtimeInitialized = 0;
		  if ( UnityEngine::Application::get_isPlaying(0LL) )
		  {
		    HG::Rendering::Runtime::VFXFakeVolumeFog::_UpdateMaterial(this, 0LL);
		    HG::Rendering::Runtime::VFXFakeVolumeFog::_UpdateMesh(this, 0LL);
		  }
		}
		
		protected override void OnDisable() {} // 0x00000001835216F0-0x0000000183521830
		// Void OnDisable()
		void HG::Rendering::Runtime::VFXFakeVolumeFog::OnDisable(VFXFakeVolumeFog *this, MethodInfo *method)
		{
		  Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *v6; // rdi
		  MeshRenderer *meshRender; // rax
		  struct Object_1__Class *v8; // rcx
		  MeshRenderer *v9; // rdi
		  Renderer *v10; // rax
		  Renderer *v11; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2382, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2382, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		      return;
		    }
		    goto LABEL_14;
		  }
		  Beyond::TickableMono::OnDisable((TickableMono *)this, 0LL);
		  v3 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *)sub_1800368D0(TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,UnityEngine::Camera>);
		  v6 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *)v3;
		  if ( !v3 )
		    goto LABEL_14;
		  System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Object>::Action(
		    v3,
		    (Object *)this,
		    MethodInfo::HG::Rendering::Runtime::VFXFakeVolumeFog::OnBeginCameraRendering,
		    0LL);
		  if ( !TypeInfo::UnityEngine::Rendering::RenderPipelineManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::RenderPipelineManager);
		  UnityEngine::Rendering::RenderPipelineManager::remove_beginCameraRendering(v6, 0LL);
		  meshRender = HG::Rendering::Runtime::VFXFakeVolumeFog::get_meshRender(this, 0LL);
		  v8 = TypeInfo::UnityEngine::Object;
		  v9 = meshRender;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v8 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v8 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( v9 )
		  {
		    if ( !v8->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v8);
		    if ( v9->fields._._._.m_CachedPtr )
		    {
		      v10 = (Renderer *)HG::Rendering::Runtime::VFXFakeVolumeFog::get_meshRender(this, 0LL);
		      if ( v10 )
		      {
		        UnityEngine::Renderer::Internal_SetPropertyBlock(v10, 0LL, 0LL);
		        v11 = (Renderer *)HG::Rendering::Runtime::VFXFakeVolumeFog::get_meshRender(this, 0LL);
		        if ( v11 )
		        {
		          UnityEngine::Renderer::set_enabled(v11, 0, 0LL);
		          return;
		        }
		      }
		LABEL_14:
		      sub_1800D8260(v5, v4);
		    }
		  }
		}
		
		protected override void OnDestroy() {} // 0x00000001837668F0-0x0000000183766950
		// Void OnDestroy()
		void HG::Rendering::Runtime::VFXFakeVolumeFog::OnDestroy(VFXFakeVolumeFog *this, MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v3; // rdx
		  HGRuntimeGrassQuery_Node *v4; // r8
		  Int32__Array **v5; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  MethodInfo *v9; // [rsp+50h] [rbp+28h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2383, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2383, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    Beyond::TickableMono::OnDestroy((TickableMono *)this, 0LL);
		    HG::Rendering::Runtime::VFXFakeVolumeFog::_DestroyKeywordMaterial(this, 0LL);
		    this->fields.m_mpb = 0LL;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_mpb, v3, v4, v5, v9);
		  }
		}
		
		private void OnBeginCameraRendering(ScriptableRenderContext context, Camera camera) {} // 0x0000000183E024F0-0x0000000183E02760
		// Void OnBeginCameraRendering(ScriptableRenderContext, Camera)
		void HG::Rendering::Runtime::VFXFakeVolumeFog::OnBeginCameraRendering(
		        VFXFakeVolumeFog *this,
		        ScriptableRenderContext context,
		        Camera *camera,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  struct Object_1__Class *v9; // rcx
		  __int64 (__fastcall *v10)(VFXFakeVolumeFog *, ILFixDynamicMethodWrapper_2__Array *, Camera *, MethodInfo *); // rax
		  __int64 v11; // rax
		  struct Object_1__Class *v12; // rcx
		  __int64 v13; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v15; // rax
		  Transform *transform; // rax
		  Object_1 *main; // rbx
		  Transform *v18; // rax
		  Vector3 *v19; // rax
		  __int64 v20; // xmm6_8
		  float v21; // ebx
		  Transform *v22; // rax
		  Vector3 *v23; // rax
		  __int64 v24; // xmm0_8
		  __int64 v25; // r8
		  double v26; // xmm0_8
		  Renderer *meshRender; // rax
		  bool v28; // dl
		  Transform *v29; // rbx
		  Transform *v30; // rax
		  Vector3 *position; // rax
		  __int64 v32; // xmm0_8
		  float z; // eax
		  Vector3 *v34; // rax
		  float v35; // xmm1_4
		  Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *v36; // rax
		  Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *v37; // rbx
		  Vector3 v38; // [rsp+30h] [rbp-48h] BYREF
		  Vector3 v39; // [rsp+40h] [rbp-38h] BYREF
		  Vector3 v40; // [rsp+50h] [rbp-28h] BYREF
		
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_24;
		  if ( wrapperArray->max_length.size > 2379 )
		  {
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6->static_fields->wrapperArray;
		    if ( !v6 )
		      goto LABEL_24;
		    if ( LODWORD(v6->_0.namespaze) <= 0x94B )
		      sub_1800D2AB0(v6, wrapperArray);
		    if ( *(_QWORD *)&v6[50]._1.static_fields_size )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(2379, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_235(Patch, (Object *)this, context, (Object *)camera, 0LL);
		        return;
		      }
		      goto LABEL_24;
		    }
		  }
		  v9 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v9 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v9 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( !this )
		    goto LABEL_63;
		  if ( !v9->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(v9);
		  if ( !this->fields._._._._._.m_CachedPtr )
		    goto LABEL_63;
		  v10 = (__int64 (__fastcall *)(VFXFakeVolumeFog *, ILFixDynamicMethodWrapper_2__Array *, Camera *, MethodInfo *))qword_18F36FBC8;
		  if ( !qword_18F36FBC8 )
		  {
		    v10 = (__int64 (__fastcall *)(VFXFakeVolumeFog *, ILFixDynamicMethodWrapper_2__Array *, Camera *, MethodInfo *))il2cpp_resolve_icall_1("UnityEngine.Component::get_gameObject()");
		    if ( !v10 )
		    {
		      v15 = sub_1802EE1B8("UnityEngine.Component::get_gameObject()");
		      sub_18007E1B0(v15, 0LL);
		    }
		    qword_18F36FBC8 = (__int64)v10;
		  }
		  v11 = v10(this, wrapperArray, camera, method);
		  v12 = TypeInfo::UnityEngine::Object;
		  v13 = v11;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v12 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v12 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( !v13 )
		    goto LABEL_63;
		  if ( !v12->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(v12);
		  if ( *(_QWORD *)(v13 + 16) )
		  {
		    if ( !UnityEngine::Application::get_isPlaying(0LL) )
		    {
		      transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
		      if ( !transform )
		        goto LABEL_24;
		      UnityEngine::Transform::set_hasChanged(transform, 0, 0LL);
		      HG::Rendering::Runtime::VFXFakeVolumeFog::_UpdateMaterial(this, 0LL);
		    }
		    if ( !this->fields.nearDisplay || this->fields.LightArtUSE )
		    {
		      if ( !UnityEngine::Application::get_isPlaying(0LL) && this->fields.canWalkIn && !this->fields.LightArtUSE )
		      {
		        v29 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		        if ( camera )
		        {
		          v30 = UnityEngine::Component::get_transform((Component *)camera, 0LL);
		          if ( v30 )
		          {
		            position = UnityEngine::Transform::get_position(&v38, v30, 0LL);
		            if ( v29 )
		            {
		              v32 = *(_QWORD *)&position->x;
		              z = position->z;
		              *(_QWORD *)&v39.x = v32;
		              v39.z = z;
		              v34 = UnityEngine::Transform::InverseTransformPoint(&v40, v29, &v39, 0LL);
		              *(_QWORD *)&v38.x = *(_QWORD *)&v34->x;
		              if ( v38.x <= -0.5
		                || v38.x >= 0.5
		                || v38.y <= -0.5
		                || v38.y >= 0.5
		                || (v35 = v34->z, v35 <= -0.5)
		                || v35 >= 0.5 )
		              {
		                meshRender = (Renderer *)HG::Rendering::Runtime::VFXFakeVolumeFog::get_meshRender(this, 0LL);
		                if ( meshRender )
		                {
		                  v28 = 1;
		                  goto LABEL_47;
		                }
		              }
		              else
		              {
		                meshRender = (Renderer *)HG::Rendering::Runtime::VFXFakeVolumeFog::get_meshRender(this, 0LL);
		                if ( meshRender )
		                {
		                  v28 = 0;
		                  goto LABEL_47;
		                }
		              }
		            }
		          }
		        }
		LABEL_24:
		        sub_1800D8260(v6, wrapperArray);
		      }
		    }
		    else
		    {
		      main = (Object_1 *)UnityEngine::Camera::get_main(0LL);
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      if ( UnityEngine::Object::op_Equality((Object_1 *)camera, main, 0LL) )
		      {
		        if ( camera )
		        {
		          v18 = UnityEngine::Component::get_transform((Component *)camera, 0LL);
		          if ( v18 )
		          {
		            v19 = UnityEngine::Transform::get_position(&v39, v18, 0LL);
		            v20 = *(_QWORD *)&v19->x;
		            v21 = v19->z;
		            v22 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		            if ( v22 )
		            {
		              v23 = UnityEngine::Transform::get_position(&v39, v22, 0LL);
		              v24 = *(_QWORD *)&v23->x;
		              *(float *)&v23 = v23->z;
		              *(_QWORD *)&v38.x = v24;
		              LODWORD(v38.z) = (_DWORD)v23;
		              *(_QWORD *)&v39.x = v20;
		              v39.z = v21;
		              v26 = sub_1833FD010(&v39, &v38, v25);
		              meshRender = (Renderer *)HG::Rendering::Runtime::VFXFakeVolumeFog::get_meshRender(this, 0LL);
		              if ( meshRender )
		              {
		                v28 = this->fields.nearDisplayDisatance >= *(float *)&v26;
		LABEL_47:
		                UnityEngine::Renderer::set_enabled(meshRender, v28, 0LL);
		                return;
		              }
		            }
		          }
		        }
		        goto LABEL_24;
		      }
		    }
		  }
		  else
		  {
		LABEL_63:
		    v36 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *)sub_1800368D0(TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,UnityEngine::Camera>);
		    v37 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *)v36;
		    if ( !v36 )
		      goto LABEL_24;
		    System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Object>::Action(
		      v36,
		      (Object *)this,
		      MethodInfo::HG::Rendering::Runtime::VFXFakeVolumeFog::OnBeginCameraRendering,
		      0LL);
		    if ( !TypeInfo::UnityEngine::Rendering::RenderPipelineManager->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::RenderPipelineManager);
		    UnityEngine::Rendering::RenderPipelineManager::remove_beginCameraRendering(v37, 0LL);
		  }
		}
		
		private void OnValidate() {} // 0x0000000189B5C320-0x0000000189B5C414
		// Void OnValidate()
		void HG::Rendering::Runtime::VFXFakeVolumeFog::OnValidate(VFXFakeVolumeFog *this, MethodInfo *method)
		{
		  Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *v6; // rdi
		  Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *v7; // rax
		  Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *v8; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2385, 0LL) )
		  {
		    if ( UnityEngine::Application::get_isPlaying(0LL) )
		      return;
		    HG::Rendering::Runtime::VFXFakeVolumeFog::_InitMeshFilterAndRender(this, 0LL);
		    HG::Rendering::Runtime::VFXFakeVolumeFog::_UpdateMaterial(this, 0LL);
		    HG::Rendering::Runtime::VFXFakeVolumeFog::_UpdateMesh(this, 0LL);
		    v3 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *)sub_18002C620(TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,UnityEngine::Camera>);
		    v6 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *)v3;
		    if ( v3 )
		    {
		      System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Object>::Action(
		        v3,
		        (Object *)this,
		        MethodInfo::HG::Rendering::Runtime::VFXFakeVolumeFog::OnBeginCameraRendering,
		        0LL);
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::RenderPipelineManager);
		      UnityEngine::Rendering::RenderPipelineManager::remove_beginCameraRendering(v6, 0LL);
		      v7 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *)sub_18002C620(TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,UnityEngine::Camera>);
		      v8 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *)v7;
		      if ( v7 )
		      {
		        System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Object>::Action(
		          v7,
		          (Object *)this,
		          MethodInfo::HG::Rendering::Runtime::VFXFakeVolumeFog::OnBeginCameraRendering,
		          0LL);
		        UnityEngine::Rendering::RenderPipelineManager::add_beginCameraRendering(v8, 0LL);
		        return;
		      }
		    }
		LABEL_7:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2385, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		private void _UpdateMesh() {} // 0x00000001835236E0-0x00000001835237C0
		// Void _UpdateMesh()
		void HG::Rendering::Runtime::VFXFakeVolumeFog::_UpdateMesh(VFXFakeVolumeFog *this, MethodInfo *method)
		{
		  HGRenderPipeline *currentPipeline; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  HGRenderPipelineRuntimeResources *defaultResources; // rax
		  HGRenderPipelineRuntimeResources_AssetResources *assets; // rax
		  Mesh *defaultCubeMesh; // rdi
		  MeshFilter *meshFilter; // rax
		  Object_1 *sharedMesh; // rsi
		  MeshFilter *v11; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2380, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2380, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		      return;
		    }
		    goto LABEL_13;
		  }
		  if ( !HG::Rendering::Runtime::VFXFakeVolumeFog::_IsPipeLineReady(this, 0LL) )
		    return;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipeline->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		  currentPipeline = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
		  if ( !currentPipeline
		    || (defaultResources = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(currentPipeline, 0LL)) == 0LL
		    || (assets = defaultResources->fields.assets) == 0LL
		    || (defaultCubeMesh = assets->fields.defaultCubeMesh,
		        (meshFilter = HG::Rendering::Runtime::VFXFakeVolumeFog::get_meshFilter(this, 0LL)) == 0LL) )
		  {
		LABEL_13:
		    sub_1800D8260(v5, v4);
		  }
		  sharedMesh = (Object_1 *)UnityEngine::MeshFilter::get_sharedMesh(meshFilter, 0LL);
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( UnityEngine::Object::op_Inequality(sharedMesh, (Object_1 *)defaultCubeMesh, 0LL) )
		  {
		    v11 = HG::Rendering::Runtime::VFXFakeVolumeFog::get_meshFilter(this, 0LL);
		    if ( v11 )
		    {
		      UnityEngine::MeshFilter::set_sharedMesh(v11, defaultCubeMesh, 0LL);
		      return;
		    }
		    goto LABEL_13;
		  }
		}
		
		private bool _IsPipeLineReady() => default; // 0x0000000183523C60-0x0000000183523D30
		// Boolean _IsPipeLineReady()
		bool HG::Rendering::Runtime::VFXFakeVolumeFog::_IsPipeLineReady(VFXFakeVolumeFog *this, MethodInfo *method)
		{
		  HGRenderPipeline *currentPipeline; // rax
		  HGRenderPipelineRuntimeResources *defaultResources; // rbx
		  struct Object_1__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2370, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2370, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipeline->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		    currentPipeline = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
		    if ( currentPipeline )
		      defaultResources = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(currentPipeline, 0LL);
		    else
		      defaultResources = 0LL;
		    v5 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v5 = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v5 = TypeInfo::UnityEngine::Object;
		      }
		    }
		    if ( !defaultResources )
		      return 0;
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v5);
		    return defaultResources->fields._._._._.m_CachedPtr
		        && defaultResources->fields.assets
		        && defaultResources->fields.textures
		        && defaultResources->fields.shaders;
		  }
		}
		
		private void _UpdateMaterial() {} // 0x0000000183520CC0-0x00000001835214C0
		// Void _UpdateMaterial()
		void HG::Rendering::Runtime::VFXFakeVolumeFog::_UpdateMaterial(VFXFakeVolumeFog *this, MethodInfo *method)
		{
		  struct Object_1__Class *v3; // rcx
		  MeshRenderer *m_meshRenderer; // rdi
		  __int64 v5; // rdx
		  MaterialPropertyBlock *m_mpb; // rcx
		  struct VFXFakeVolumeFog__Class *v7; // rdx
		  VFXFakeVolumeFog__StaticFields *static_fields; // rdx
		  int32_t s_NoiseTex3D; // edi
		  HGRenderPipeline *currentPipeline; // rax
		  HGRenderPipelineRuntimeResources *defaultResources; // rax
		  HGRenderPipelineRuntimeResources_TextureResources *textures; // r8
		  float fogDepthEnd; // xmm6_4
		  float v14; // xmm7_4
		  float v15; // xmm2_4
		  struct VFXFakeVolumeFog__Class *v16; // rdx
		  float v17; // xmm2_4
		  struct VFXFakeVolumeFog__Class *v18; // rax
		  VFXFakeVolumeFog__StaticFields *v19; // rax
		  float v20; // xmm2_4
		  struct VFXFakeVolumeFog__Class *v21; // rdx
		  VFXFakeVolumeFog__StaticFields *v22; // rdx
		  struct VFXFakeVolumeFog__Class *v23; // rdx
		  struct VFXFakeVolumeFog__Class *v24; // rax
		  int32_t s_NoiseUVWDir1; // esi
		  Transform *transform; // rdi
		  __int64 v27; // xmm0_8
		  float v28; // ecx
		  void (__fastcall *v29)(Transform *, Vector4 *, Vector4 *); // rax
		  MethodInfo *v30; // r8
		  Renderer *meshRender; // rax
		  float z; // eax
		  MethodInfo *v33; // r8
		  __int64 v34; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 v36; // [rsp+20h] [rbp-40h] BYREF
		  Vector4 fogColor; // [rsp+30h] [rbp-30h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2369, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2369, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		      return;
		    }
		    goto LABEL_46;
		  }
		  v3 = TypeInfo::UnityEngine::Object;
		  m_meshRenderer = this->fields.m_meshRenderer;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v3 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v3 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( m_meshRenderer )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v3);
		    if ( m_meshRenderer->fields._._._.m_CachedPtr
		      && HG::Rendering::Runtime::VFXFakeVolumeFog::_IsPipeLineReady(this, 0LL) )
		    {
		      HG::Rendering::Runtime::VFXFakeVolumeFog::_ValidMaterialToRenderer(this, 0LL);
		      HG::Rendering::Runtime::VFXFakeVolumeFog::_EnsureMPB(this, 0LL);
		      m_mpb = this->fields.m_mpb;
		      if ( m_mpb )
		      {
		        UnityEngine::MaterialPropertyBlock::Clear(m_mpb, 1, 0LL);
		        v7 = TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog;
		        if ( !TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog);
		          v7 = TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog;
		        }
		        HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
		          this,
		          v7->static_fields->s_NearFadeDistance,
		          this->fields.nearFadeDisatance,
		          0LL);
		        HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
		          this,
		          TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_NearDisplayDistance,
		          this->fields.nearDisplayDisatance,
		          0LL);
		        static_fields = TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields;
		        fogColor = (Vector4)this->fields.fogColor;
		        HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
		          this,
		          static_fields->s_FogColor,
		          (Color *)&fogColor,
		          0LL);
		        HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
		          this,
		          TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_FogExponent,
		          this->fields.fogExponent,
		          0LL);
		        HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
		          this,
		          TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_FogDensity,
		          this->fields.fogDensity,
		          0LL);
		        HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
		          this,
		          TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_CubEdgeFade,
		          this->fields.cubeEdge,
		          0LL);
		        HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
		          this,
		          TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_HeightOffset,
		          this->fields.heightOffset,
		          0LL);
		        HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
		          this,
		          TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_HeightFalloff,
		          this->fields.heightFalloff,
		          0LL);
		        HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
		          this,
		          TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_VerticalFalloffMin,
		          this->fields.verticalFalloffRange.x,
		          0LL);
		        HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
		          this,
		          TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_VerticalFalloffMax,
		          this->fields.verticalFalloffRange.y,
		          0LL);
		        s_NoiseTex3D = TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_NoiseTex3D;
		        if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipeline->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		        currentPipeline = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
		        if ( currentPipeline )
		        {
		          defaultResources = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(currentPipeline, 0LL);
		          if ( defaultResources )
		          {
		            textures = defaultResources->fields.textures;
		            if ( textures )
		            {
		              HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
		                this,
		                s_NoiseTex3D,
		                (Texture *)textures->fields.HeightFogNoise3DTex,
		                0LL);
		              HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
		                this,
		                TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_NoiseIntensity,
		                this->fields.noiseIntensity,
		                0LL);
		              HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
		                this,
		                TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_NoiseFar,
		                this->fields.noiseFar,
		                0LL);
		              fogDepthEnd = 0.0;
		              v14 = 1.0;
		              if ( this->fields.LightArtUSE || !this->fields.useFog )
		                v15 = 0.0;
		              else
		                v15 = 1.0;
		              HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
		                this,
		                TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_UseFog,
		                v15,
		                0LL);
		              v16 = TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog;
		              if ( !TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->_1.cctor_finished_or_no_cctor )
		              {
		                il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog);
		                v16 = TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog;
		              }
		              HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
		                this,
		                v16->static_fields->s_FogIntensity,
		                this->fields.fogIntensity,
		                0LL);
		              HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
		                this,
		                TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_FogIntensityFadeOutDistance,
		                this->fields.fogIntensityFadeOutDistance,
		                0LL);
		              if ( !this->fields.canWalkIn || this->fields.LightArtUSE )
		                v17 = 1.0;
		              else
		                v17 = 0.0;
		              HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
		                this,
		                TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_CanWalkIn,
		                v17,
		                0LL);
		              v18 = TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog;
		              if ( !TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->_1.cctor_finished_or_no_cctor )
		              {
		                il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog);
		                v18 = TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog;
		              }
		              v19 = v18->static_fields;
		              if ( !this->fields.nearDisplay || this->fields.LightArtUSE )
		                v20 = 0.0;
		              else
		                v20 = 1.0;
		              HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(this, v19->s_NearDisplay, v20, 0LL);
		              v21 = TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog;
		              if ( this->fields.LightArtUSE )
		              {
		                if ( !TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->_1.cctor_finished_or_no_cctor )
		                {
		                  il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog);
		                  v21 = TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog;
		                }
		                HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
		                  this,
		                  v21->static_fields->s_NoiseFarIntensity,
		                  this->fields.noiseFarIntensity,
		                  0LL);
		                fogColor.x = this->fields.noiseTillingLightArtUSE;
		                fogColor.y = fogColor.x;
		                fogColor.z = fogColor.x;
		                v22 = TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields;
		                fogColor.w = 1.0;
		                HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
		                  this,
		                  v22->s_NoiseTexTilling1,
		                  &fogColor,
		                  0LL);
		                HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
		                  this,
		                  TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_FogIntensityFadeDistance,
		                  this->fields.fogIntensityFadeDistance,
		                  0LL);
		                if ( !this->fields.fogIntensityFadeUseCenter )
		                  v14 = 0.0;
		                HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
		                  this,
		                  TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_FogIntensityFadeUseCenter,
		                  v14,
		                  0LL);
		                v23 = TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog;
		                if ( !TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->_1.cctor_finished_or_no_cctor )
		                {
		                  il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog);
		                  v23 = TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog;
		                }
		                HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
		                  this,
		                  v23->static_fields->s_NoiseUVWSpeed1,
		                  this->fields.noiseSpeedLightArtUSE,
		                  0LL);
		                HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
		                  this,
		                  TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_FogDepthStart,
		                  this->fields.fogDepthStart,
		                  0LL);
		                fogDepthEnd = this->fields.fogDepthEnd;
		              }
		              else
		              {
		                if ( !TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->_1.cctor_finished_or_no_cctor )
		                {
		                  il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog);
		                  v21 = TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog;
		                }
		                HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
		                  this,
		                  v21->static_fields->s_NoiseFarIntensity,
		                  this->fields.noiseIntensity,
		                  0LL);
		                z = this->fields.noiseTilling.z;
		                *(_QWORD *)&v36.x = *(_QWORD *)&this->fields.noiseTilling.x;
		                v36.z = z;
		                fogColor = *UnityEngine::Vector4::op_Implicit(&fogColor, (Vector3 *)&v36, v33);
		                HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
		                  this,
		                  TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_NoiseTexTilling1,
		                  &fogColor,
		                  0LL);
		                HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
		                  this,
		                  TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_FogIntensityFadeDistance,
		                  10000.0,
		                  0LL);
		                HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
		                  this,
		                  TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_FogIntensityFadeUseCenter,
		                  0.0,
		                  0LL);
		                HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
		                  this,
		                  TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_NoiseUVWSpeed1,
		                  this->fields.noiseSpeed,
		                  0LL);
		                HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
		                  this,
		                  TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_FogDepthStart,
		                  0.0,
		                  0LL);
		              }
		              HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
		                this,
		                TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_FogDepthEnd,
		                fogDepthEnd,
		                0LL);
		              v24 = TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog;
		              if ( !TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->_1.cctor_finished_or_no_cctor )
		              {
		                il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog);
		                v24 = TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog;
		              }
		              s_NoiseUVWDir1 = v24->static_fields->s_NoiseUVWDir1;
		              transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
		              if ( transform )
		              {
		                v27 = *(_QWORD *)&this->fields.noiseDir.x;
		                v28 = this->fields.noiseDir.z;
		                *(_QWORD *)&v36.x = 0LL;
		                v36.z = 0.0;
		                v29 = (void (__fastcall *)(Transform *, Vector4 *, Vector4 *))qword_18F370168;
		                *(_QWORD *)&fogColor.x = v27;
		                fogColor.z = v28;
		                if ( !qword_18F370168 )
		                {
		                  v29 = (void (__fastcall *)(Transform *, Vector4 *, Vector4 *))il2cpp_resolve_icall_1(
		                                                                                  "UnityEngine.Transform::TransformDirect"
		                                                                                  "ion_Injected(UnityEngine.Vector3&,Unit"
		                                                                                  "yEngine.Vector3&)");
		                  if ( !v29 )
		                  {
		                    v34 = sub_1802EE1B8(
		                            "UnityEngine.Transform::TransformDirection_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&)");
		                    sub_18007E1B0(v34, 0LL);
		                  }
		                  qword_18F370168 = (__int64)v29;
		                }
		                v29(transform, &fogColor, &v36);
		                *(_QWORD *)&fogColor.x = *(_QWORD *)&v36.x;
		                fogColor.z = v36.z;
		                fogColor = *UnityEngine::Vector4::op_Implicit(&v36, (Vector3 *)&fogColor, v30);
		                HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(this, s_NoiseUVWDir1, &fogColor, 0LL);
		                meshRender = (Renderer *)HG::Rendering::Runtime::VFXFakeVolumeFog::get_meshRender(this, 0LL);
		                if ( meshRender )
		                {
		                  UnityEngine::Renderer::Internal_SetPropertyBlock(meshRender, this->fields.m_mpb, 0LL);
		                  this->fields.m_runtimeInitialized = 1;
		                  return;
		                }
		              }
		            }
		          }
		        }
		      }
		LABEL_46:
		      sub_1800D8260(m_mpb, v5);
		    }
		  }
		}
		
		public void ShowMeshFilterAndRenderer() {} // 0x0000000189B5C414-0x0000000189B5C49C
		// Void ShowMeshFilterAndRenderer()
		void HG::Rendering::Runtime::VFXFakeVolumeFog::ShowMeshFilterAndRenderer(VFXFakeVolumeFog *this, MethodInfo *method)
		{
		  Object_1 *meshFilter; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  Object_1 *meshRender; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2386, 0LL) )
		  {
		    HG::Rendering::Runtime::VFXFakeVolumeFog::_InitMeshFilterAndRender(this, 0LL);
		    meshFilter = (Object_1 *)HG::Rendering::Runtime::VFXFakeVolumeFog::get_meshFilter(this, 0LL);
		    if ( meshFilter )
		    {
		      UnityEngine::Object::set_hideFlags(meshFilter, HideFlags__Enum_None, 0LL);
		      meshRender = (Object_1 *)HG::Rendering::Runtime::VFXFakeVolumeFog::get_meshRender(this, 0LL);
		      if ( meshRender )
		      {
		        UnityEngine::Object::set_hideFlags(meshRender, HideFlags__Enum_None, 0LL);
		        return;
		      }
		    }
		LABEL_6:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2386, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		public void HideMeshFilterAndRenderer() {} // 0x0000000189B5C0C0-0x0000000189B5C14C
		// Void HideMeshFilterAndRenderer()
		void HG::Rendering::Runtime::VFXFakeVolumeFog::HideMeshFilterAndRenderer(VFXFakeVolumeFog *this, MethodInfo *method)
		{
		  Object_1 *meshFilter; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  Object_1 *meshRender; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2387, 0LL) )
		  {
		    HG::Rendering::Runtime::VFXFakeVolumeFog::_InitMeshFilterAndRender(this, 0LL);
		    meshFilter = (Object_1 *)HG::Rendering::Runtime::VFXFakeVolumeFog::get_meshFilter(this, 0LL);
		    if ( meshFilter )
		    {
		      UnityEngine::Object::set_hideFlags(meshFilter, HideFlags__Enum_HideInInspector, 0LL);
		      meshRender = (Object_1 *)HG::Rendering::Runtime::VFXFakeVolumeFog::get_meshRender(this, 0LL);
		      if ( meshRender )
		      {
		        UnityEngine::Object::set_hideFlags(meshRender, HideFlags__Enum_HideInInspector, 0LL);
		        return;
		      }
		    }
		LABEL_6:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2387, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		private void _EnsureMPB() {} // 0x0000000183521F50-0x0000000183521FC0
		// Void _EnsureMPB()
		void HG::Rendering::Runtime::VFXFakeVolumeFog::_EnsureMPB(VFXFakeVolumeFog *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  MaterialPropertyBlock *v5; // rbx
		  HGRuntimeGrassQuery_Node *v6; // rdx
		  HGRuntimeGrassQuery_Node *v7; // r8
		  Int32__Array **v8; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v10; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2373, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2373, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		      return;
		    }
		    goto LABEL_6;
		  }
		  if ( this->fields.m_mpb )
		    return;
		  v5 = (MaterialPropertyBlock *)sub_1800368D0(TypeInfo::UnityEngine::MaterialPropertyBlock);
		  if ( !v5 )
		LABEL_6:
		    sub_1800D8260(v4, v3);
		  v5->fields.m_Ptr = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL);
		  this->fields.m_mpb = v5;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_mpb, v6, v7, v8, v10);
		}
		
		[IDTag(0)]
		private void _SetMaterialProperty(int propertyId, float value) {} // 0x00000001835214C0-0x0000000183521520
		// Void _SetMaterialProperty(Int32, Single)
		void HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
		        VFXFakeVolumeFog *this,
		        int32_t propertyId,
		        float value,
		        MethodInfo *method)
		{
		  __int64 v6; // rdx
		  MaterialPropertyBlock *m_mpb; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2374, 0LL) )
		  {
		    m_mpb = this->fields.m_mpb;
		    if ( m_mpb )
		    {
		      UnityEngine::MaterialPropertyBlock::SetFloatImpl(m_mpb, propertyId, value, 0LL);
		      return;
		    }
		LABEL_4:
		    sub_1800D8260(m_mpb, v6);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2374, 0LL);
		  if ( !Patch )
		    goto LABEL_4;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_931(Patch, (Object *)this, propertyId, value, 0LL);
		}
		
		[IDTag(1)]
		private void _SetMaterialProperty(int propertyId, UnityEngine.Color value) {} // 0x0000000183521EE0-0x0000000183521F50
		// Void _SetMaterialProperty(Int32, Color)
		void HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
		        VFXFakeVolumeFog *this,
		        int32_t propertyId,
		        Color *value,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  MaterialPropertyBlock *m_mpb; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Color valuea; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2375, 0LL) )
		  {
		    m_mpb = this->fields.m_mpb;
		    if ( m_mpb )
		    {
		      valuea = *value;
		      UnityEngine::MaterialPropertyBlock::SetColorImpl_Injected(m_mpb, propertyId, &valuea, 0LL);
		      return;
		    }
		LABEL_4:
		    sub_1800D8260(m_mpb, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2375, 0LL);
		  if ( !Patch )
		    goto LABEL_4;
		  valuea = *value;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_932(Patch, (Object *)this, propertyId, &valuea, 0LL);
		}
		
		[IDTag(3)]
		private void _SetMaterialProperty(int propertyId, Vector4 value) {} // 0x0000000183521520-0x00000001835215A0
		// Void _SetMaterialProperty(Int32, Vector4)
		void HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
		        VFXFakeVolumeFog *this,
		        int32_t propertyId,
		        Vector4 *value,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  MaterialPropertyBlock *m_mpb; // rbx
		  void (__fastcall *v10)(MaterialPropertyBlock *, _QWORD, Vector4 *); // rax
		  __int64 v11; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2377, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2377, 0LL);
		    if ( Patch )
		    {
		      v13 = *value;
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_933(Patch, (Object *)this, propertyId, &v13, 0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v8, v7);
		  }
		  m_mpb = this->fields.m_mpb;
		  if ( !m_mpb )
		    goto LABEL_5;
		  v10 = (void (__fastcall *)(MaterialPropertyBlock *, _QWORD, Vector4 *))qword_18F36F470;
		  v13 = *value;
		  if ( !qword_18F36F470 )
		  {
		    v10 = (void (__fastcall *)(MaterialPropertyBlock *, _QWORD, Vector4 *))il2cpp_resolve_icall_1(
		                                                                             "UnityEngine.MaterialPropertyBlock::SetVecto"
		                                                                             "rImpl_Injected(System.Int32,UnityEngine.Vector4&)");
		    if ( !v10 )
		    {
		      v11 = sub_1802EE1B8("UnityEngine.MaterialPropertyBlock::SetVectorImpl_Injected(System.Int32,UnityEngine.Vector4&)");
		      sub_18007E1B0(v11, 0LL);
		    }
		    qword_18F36F470 = (__int64)v10;
		  }
		  v10(m_mpb, (unsigned int)propertyId, &v13);
		}
		
		[IDTag(2)]
		private void _SetMaterialProperty(int propertyId, Texture value) {} // 0x0000000183521930-0x0000000183521990
		// Void _SetMaterialProperty(Int32, Texture)
		void HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
		        VFXFakeVolumeFog *this,
		        int32_t propertyId,
		        Texture *value,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  MaterialPropertyBlock *m_mpb; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2376, 0LL) )
		  {
		    m_mpb = this->fields.m_mpb;
		    if ( m_mpb )
		    {
		      UnityEngine::MaterialPropertyBlock::SetTextureImpl(m_mpb, propertyId, value, 0LL);
		      return;
		    }
		LABEL_4:
		    sub_1800D8260(m_mpb, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2376, 0LL);
		  if ( !Patch )
		    goto LABEL_4;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_56(
		    (ILFixDynamicMethodWrapper_17 *)Patch,
		    (Object *)this,
		    (AkCallbackType__Enum)propertyId,
		    (Object *)value,
		    0LL);
		}
		
		private void _ValidMaterialToRenderer() {} // 0x00000001835237F0-0x0000000183523AD0
		// Void _ValidMaterialToRenderer()
		void HG::Rendering::Runtime::VFXFakeVolumeFog::_ValidMaterialToRenderer(VFXFakeVolumeFog *this, MethodInfo *method)
		{
		  unsigned __int64 s_StencilOp; // rdx
		  struct Object_1__Class *v4; // rcx
		  Material *m_keywordMaterial; // rdi
		  Material *v6; // rcx
		  Material *v7; // rdi
		  struct VFXFakeVolumeFog__Class *v8; // rax
		  VFXFakeVolumeFog__StaticFields *v9; // rax
		  Material *v10; // r8
		  VFXFakeVolumeFog__StaticFields *static_fields; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2371, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2371, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		      return;
		    }
		    goto LABEL_24;
		  }
		  if ( HG::Rendering::Runtime::VFXFakeVolumeFog::_IsPipeLineReady(this, 0LL) )
		  {
		    HG::Rendering::Runtime::VFXFakeVolumeFog::_EnsureKeywordMaterial(this, 0LL);
		    v4 = TypeInfo::UnityEngine::Object;
		    m_keywordMaterial = this->fields.m_keywordMaterial;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v4 = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v4 = TypeInfo::UnityEngine::Object;
		      }
		    }
		    if ( m_keywordMaterial )
		    {
		      if ( !v4->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(v4);
		      if ( m_keywordMaterial->fields._.m_CachedPtr )
		      {
		        v6 = this->fields.m_keywordMaterial;
		        if ( this->fields.useNoise3D == (m_keywordMaterial->fields._.m_CachedPtr == 0LL) )
		        {
		          if ( !v6 )
		            goto LABEL_24;
		          UnityEngine::Material::DisableKeyword(v6, (String *)"_USE_NOISE3D", 0LL);
		        }
		        else
		        {
		          if ( !v6 )
		            goto LABEL_24;
		          UnityEngine::Material::EnableKeyword(v6, (String *)"_USE_NOISE3D", 0LL);
		        }
		        v6 = this->fields.m_keywordMaterial;
		        if ( this->fields.LightArtUSE )
		        {
		          if ( !v6 )
		            goto LABEL_24;
		        }
		        else
		        {
		          if ( this->fields.useFog )
		          {
		            if ( !v6 )
		              goto LABEL_24;
		            UnityEngine::Material::EnableKeyword(v6, (String *)"_USE_FOG", 0LL);
		            goto LABEL_14;
		          }
		          if ( !v6 )
		            goto LABEL_24;
		        }
		        UnityEngine::Material::DisableKeyword(v6, (String *)"_USE_FOG", 0LL);
		LABEL_14:
		        v7 = this->fields.m_keywordMaterial;
		        v8 = TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog;
		        if ( this->fields.excludeCharacter )
		        {
		          if ( !TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog);
		            v8 = TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog;
		          }
		          static_fields = v8->static_fields;
		          if ( !v7 )
		            goto LABEL_24;
		          UnityEngine::Material::SetFloatImpl(v7, static_fields->s_StencilWriteMask, 7.0, 0LL);
		          v6 = this->fields.m_keywordMaterial;
		          s_StencilOp = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields;
		          if ( !v6 )
		            goto LABEL_24;
		          UnityEngine::Material::SetFloatImpl(v6, *(_DWORD *)(s_StencilOp + 100), 7.0, 0LL);
		          v6 = this->fields.m_keywordMaterial;
		          s_StencilOp = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields;
		          if ( !v6 )
		            goto LABEL_24;
		          UnityEngine::Material::SetFloatImpl(v6, *(_DWORD *)(s_StencilOp + 104), 7.0, 0LL);
		          v6 = this->fields.m_keywordMaterial;
		          s_StencilOp = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields;
		          if ( !v6 )
		            goto LABEL_24;
		          UnityEngine::Material::SetFloatImpl(v6, *(_DWORD *)(s_StencilOp + 108), 6.0, 0LL);
		          v10 = this->fields.m_keywordMaterial;
		          s_StencilOp = (unsigned int)TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields->s_StencilOp;
		          if ( !v10 )
		            goto LABEL_24;
		        }
		        else
		        {
		          if ( !TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog);
		            v8 = TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog;
		          }
		          v9 = v8->static_fields;
		          if ( !v7 )
		            goto LABEL_24;
		          UnityEngine::Material::SetFloatImpl(v7, v9->s_StencilWriteMask, 255.0, 0LL);
		          v6 = this->fields.m_keywordMaterial;
		          s_StencilOp = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields;
		          if ( !v6 )
		            goto LABEL_24;
		          UnityEngine::Material::SetFloatImpl(v6, *(_DWORD *)(s_StencilOp + 104), 0.0, 0LL);
		          v6 = this->fields.m_keywordMaterial;
		          s_StencilOp = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields;
		          if ( !v6 )
		            goto LABEL_24;
		          UnityEngine::Material::SetFloatImpl(v6, *(_DWORD *)(s_StencilOp + 108), 8.0, 0LL);
		          v10 = this->fields.m_keywordMaterial;
		          v6 = (Material *)TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog->static_fields;
		          s_StencilOp = LODWORD(v6[4].fields._.m_CachedPtr);
		          if ( !v10 )
		            goto LABEL_24;
		        }
		        UnityEngine::Material::SetFloatImpl(v10, s_StencilOp, 0.0, 0LL);
		        v6 = this->fields.m_keywordMaterial;
		        if ( v6 )
		        {
		          UnityEngine::Material::set_renderQueue(v6, 3000, 0LL);
		          return;
		        }
		LABEL_24:
		        sub_1800D8260(v6, s_StencilOp);
		      }
		    }
		  }
		}
		
		private void _EnsureKeywordMaterial() {} // 0x00000001835215A0-0x00000001835216F0
		// Void _EnsureKeywordMaterial()
		void HG::Rendering::Runtime::VFXFakeVolumeFog::_EnsureKeywordMaterial(VFXFakeVolumeFog *this, MethodInfo *method)
		{
		  struct Object_1__Class *v3; // rcx
		  Material *m_keywordMaterial; // rdi
		  HGRenderPipeline *currentPipeline; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  HGRenderPipelineRuntimeResources *defaultResources; // rax
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  Shader *fakeVolumeFogPS; // rsi
		  Material *v11; // rax
		  Material *v12; // rdi
		  HGRuntimeGrassQuery_Node *v13; // rdx
		  HGRuntimeGrassQuery_Node *v14; // r8
		  Int32__Array **v15; // r9
		  Renderer *meshRender; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v18; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2372, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2372, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		      return;
		    }
		    goto LABEL_16;
		  }
		  v3 = TypeInfo::UnityEngine::Object;
		  m_keywordMaterial = this->fields.m_keywordMaterial;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v3 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v3 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( !m_keywordMaterial )
		    goto LABEL_23;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(v3);
		  if ( !m_keywordMaterial->fields._.m_CachedPtr )
		  {
		LABEL_23:
		    if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipeline->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		    currentPipeline = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
		    if ( currentPipeline )
		    {
		      defaultResources = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(currentPipeline, 0LL);
		      if ( defaultResources )
		      {
		        shaders = defaultResources->fields.shaders;
		        if ( shaders )
		        {
		          fakeVolumeFogPS = shaders->fields.fakeVolumeFogPS;
		          v11 = (Material *)sub_1800368D0(TypeInfo::UnityEngine::Material);
		          v12 = v11;
		          if ( v11 )
		          {
		            UnityEngine::Material::Material(v11, fakeVolumeFogPS, 0LL);
		            this->fields.m_keywordMaterial = v12;
		            sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_keywordMaterial, v13, v14, v15, v18);
		            meshRender = (Renderer *)HG::Rendering::Runtime::VFXFakeVolumeFog::get_meshRender(this, 0LL);
		            if ( meshRender )
		            {
		              UnityEngine::Renderer::SetMaterial(meshRender, this->fields.m_keywordMaterial, 0LL);
		              return;
		            }
		          }
		        }
		      }
		    }
		LABEL_16:
		    sub_1800D8260(v7, v6);
		  }
		}
		
		private void _DestroyKeywordMaterial() {} // 0x0000000183766950-0x0000000183766A40
		// Void _DestroyKeywordMaterial()
		void HG::Rendering::Runtime::VFXFakeVolumeFog::_DestroyKeywordMaterial(VFXFakeVolumeFog *this, MethodInfo *method)
		{
		  struct Object_1__Class *v3; // rcx
		  Material *m_keywordMaterial; // rdi
		  bool isPlaying; // al
		  Object_1 *v6; // rdi
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  MethodInfo *v13; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2384, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2384, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v12, v11);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    v3 = TypeInfo::UnityEngine::Object;
		    m_keywordMaterial = this->fields.m_keywordMaterial;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v3 = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v3 = TypeInfo::UnityEngine::Object;
		      }
		    }
		    if ( m_keywordMaterial )
		    {
		      if ( !v3->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(v3);
		      if ( m_keywordMaterial->fields._.m_CachedPtr )
		      {
		        isPlaying = UnityEngine::Application::get_isPlaying(0LL);
		        v6 = (Object_1 *)this->fields.m_keywordMaterial;
		        if ( isPlaying )
		        {
		          if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          UnityEngine::Object::Destroy(v6, 0LL);
		        }
		        else
		        {
		          if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          UnityEngine::Object::DestroyImmediate(v6, 0LL);
		        }
		        this->fields.m_keywordMaterial = 0LL;
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_keywordMaterial, v7, v8, v9, v13);
		      }
		    }
		  }
		}
		
		public void OnSceneTriggerEnter(ulong triggerId) {} // 0x0000000189B5C1FC-0x0000000189B5C294
		// Void OnSceneTriggerEnter(UInt64)
		void HG::Rendering::Runtime::VFXFakeVolumeFog::OnSceneTriggerEnter(
		        VFXFakeVolumeFog *this,
		        uint64_t triggerId,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  Renderer *m_meshRenderer; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2395, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2395, 0LL);
		    if ( !Patch )
		      goto LABEL_11;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_86(
		      (ILFixDynamicMethodWrapper_14 *)Patch,
		      (Object *)this,
		      triggerId,
		      0LL);
		  }
		  else
		  {
		    if ( this->fields.canWalkIn && !this->fields.LightArtUSE )
		    {
		      m_meshRenderer = (Renderer *)this->fields.m_meshRenderer;
		      if ( !m_meshRenderer )
		        goto LABEL_11;
		      UnityEngine::Renderer::set_enabled(m_meshRenderer, 0, 0LL);
		    }
		    if ( this->fields.nearDisplay && !this->fields.LightArtUSE )
		    {
		      m_meshRenderer = (Renderer *)this->fields.m_meshRenderer;
		      if ( m_meshRenderer )
		      {
		        UnityEngine::Renderer::set_enabled(m_meshRenderer, 1, 0LL);
		        return;
		      }
		LABEL_11:
		      sub_1800D8260(m_meshRenderer, v5);
		    }
		  }
		}
		
		public void OnSceneTriggerLeave(ulong triggerId) {} // 0x0000000189B5C294-0x0000000189B5C320
		// Void OnSceneTriggerLeave(UInt64)
		void HG::Rendering::Runtime::VFXFakeVolumeFog::OnSceneTriggerLeave(
		        VFXFakeVolumeFog *this,
		        uint64_t triggerId,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  Renderer *m_meshRenderer; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2396, 0LL) )
		  {
		    if ( this->fields.canWalkIn )
		    {
		      m_meshRenderer = (Renderer *)this->fields.m_meshRenderer;
		      if ( !m_meshRenderer )
		        goto LABEL_9;
		      UnityEngine::Renderer::set_enabled(m_meshRenderer, 1, 0LL);
		    }
		    if ( !this->fields.nearDisplay )
		      return;
		    m_meshRenderer = (Renderer *)this->fields.m_meshRenderer;
		    if ( m_meshRenderer )
		    {
		      UnityEngine::Renderer::set_enabled(m_meshRenderer, 0, 0LL);
		      return;
		    }
		LABEL_9:
		    sub_1800D8260(m_meshRenderer, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2396, 0LL);
		  if ( !Patch )
		    goto LABEL_9;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_86((ILFixDynamicMethodWrapper_14 *)Patch, (Object *)this, triggerId, 0LL);
		}
		
		public float __iFixBaseProxy_get_tickInterval() => default; // 0x0000000186ACE284-0x0000000186ACE28C
		// Single <>iFixBaseProxy_get_tickInterval()
		float HG::Rendering::Runtime::VFXFakeVolumeFog::__iFixBaseProxy_get_tickInterval(
		        VFXFakeVolumeFog *this,
		        MethodInfo *method)
		{
		  return Beyond::TickableMono::get_tickInterval((TickableMono *)this, 0LL);
		}
		
		public TickType __iFixBaseProxy_get_tickOption() => default; // 0x00000001869AFD0C-0x00000001869AFD14
		// TickType <>iFixBaseProxy_get_tickOption()
		TickType__Enum Beyond::Login::LoginDecorateUI::__iFixBaseProxy_get_tickOption(
		        LoginDecorateUI *this,
		        MethodInfo *method)
		{
		  return Beyond::TickableMono::get_tickOption((TickableMono *)this, 0LL);
		}
		
		public void __iFixBaseProxy_OnAwake() {} // 0x0000000186881850-0x0000000186881858
		// Void <>iFixBaseProxy_OnAwake()
		void Beyond::TickableUIMono::__iFixBaseProxy_OnAwake(TickableUIMono *this, MethodInfo *method)
		{
		  Beyond::TickableMono::OnAwake((TickableMono *)this, 0LL);
		}
		
		public void __iFixBaseProxy_Tick(float P0) {} // 0x0000000181538B50-0x0000000181538B60
		// Void <>iFixBaseProxy_Tick(Single)
		void Beyond::Login::LoginDecorateUI::__iFixBaseProxy_Tick(LoginDecorateUI *this, float P0, MethodInfo *method)
		{
		  Beyond::TickableMono::Tick((TickableMono *)this, P0, 0LL);
		}
		
		public void __iFixBaseProxy_OnEnable() {} // 0x0000000181538B40-0x0000000181538B50
		// Void <>iFixBaseProxy_OnEnable()
		void Beyond::UI::UIWaterDroneBar::__iFixBaseProxy_OnEnable(UIWaterDroneBar *this, MethodInfo *method)
		{
		  Beyond::TickableMono::OnEnable((TickableMono *)this, 0LL);
		}
		
		public void __iFixBaseProxy_OnDisable() {} // 0x0000000181538B30-0x0000000181538B40
		// Void <>iFixBaseProxy_OnDisable()
		void Beyond::UI::UIMusicVolumeVisual::__iFixBaseProxy_OnDisable(UIMusicVolumeVisual *this, MethodInfo *method)
		{
		  Beyond::TickableMono::OnDisable((TickableMono *)this, 0LL);
		}
		
		public void __iFixBaseProxy_OnDestroy() {} // 0x0000000181538B20-0x0000000181538B30
		// Void <>iFixBaseProxy_OnDestroy()
		void Beyond::UI::RegionMapSetting::__iFixBaseProxy_OnDestroy(RegionMapSetting *this, MethodInfo *method)
		{
		  Beyond::TickableMono::OnDestroy((TickableMono *)this, 0LL);
		}
		
	}
}
