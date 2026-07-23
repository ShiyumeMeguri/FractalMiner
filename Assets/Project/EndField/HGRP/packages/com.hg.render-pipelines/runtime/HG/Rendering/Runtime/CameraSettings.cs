using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public struct CameraSettings // TypeDefIndex: 38667
	{
		// Fields
		[Obsolete("Since 2019.3, use CameraSettings.defaultCameraSettingsNonAlloc instead.")]
		public static readonly CameraSettings @default; // 0x00
		public static readonly CameraSettings defaultCameraSettingsNonAlloc; // 0xE0
		public bool customRenderingSettings; // 0x00
		public FrameSettings renderingPathCustomFrameSettings; // 0x08
		public FrameSettingsOverrideMask renderingPathCustomFrameSettingsOverrideMask; // 0x20
		public BufferClearing bufferClearing; // 0x30
		public Volumes volumes; // 0x48
		public Frustum frustum; // 0x58
		public Culling culling; // 0xB0
		public bool invertFaceCulling; // 0xC0
		public HGAdditionalCameraData.FlipYMode flipYMode; // 0xC4
		public LayerMask probeLayerMask; // 0xC8
		public FrameSettingsRenderType defaultFrameSettings; // 0xCC
		internal float probeRangeCompressionFactor; // 0xD0
		[FormerlySerializedAs("renderingPath")]
		[Obsolete("For data migration")]
		[SerializeField]
		internal int m_ObsoleteRenderingPath; // 0xD4
		[FormerlySerializedAs("frameSettings")]
		[Obsolete("For data migration")]
		[SerializeField]
		internal ObsoleteFrameSettings m_ObsoleteFrameSettings; // 0xD8
	
		// Nested types
		[Serializable]
		public struct BufferClearing // TypeDefIndex: 38662
		{
			// Fields
			[Obsolete("Since 2019.3, use BufferClearing.NewDefault() instead.")]
			public static readonly BufferClearing @default; // 0x00
			public HGAdditionalCameraData.ClearColorMode clearColorMode; // 0x00
			[ColorUsage(true, true)]
			public UnityEngine.Color backgroundColorHDR; // 0x04
			public bool clearDepth; // 0x14
	
			// Constructors
			static BufferClearing() {
				default = default;
			} // 0x00000001841E1670-0x00000001841E1680
			// Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
			void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			        HGWindConfig *cSrc,
			        HGWindConfig *cDst,
			        float t,
			        MethodInfo *method)
			{
			  ;
			}
			
	
			// Methods
			public static BufferClearing NewDefault() => default; // 0x00000001837D8700-0x00000001837D8770
			// CameraSettings+BufferClearing NewDefault()
			CameraSettings_BufferClearing *HG::Rendering::Runtime::CameraSettings::BufferClearing::NewDefault(
			        CameraSettings_BufferClearing *__return_ptr retstr,
			        MethodInfo *method)
			{
			  Color *v3; // rax
			  __int128 v4; // xmm0
			  __int64 v5; // xmm1_8
			  CameraSettings_BufferClearing *result; // rax
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v8; // rdx
			  __int64 v9; // rcx
			  CameraSettings_BufferClearing *v10; // rax
			  _BYTE v11[16]; // [rsp+20h] [rbp-38h] BYREF
			  CameraSettings_BufferClearing v12; // [rsp+30h] [rbp-28h] BYREF
			
			  if ( IFix::WrappersManagerImpl::IsPatched(4069, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(4069, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v9, v8);
			    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1437(&v12, Patch, 0LL);
			    v4 = *(_OWORD *)&v10->clearColorMode;
			    v5 = *(_QWORD *)&v10->backgroundColorHDR.a;
			  }
			  else
			  {
			    memset(&v12, 0, sizeof(v12));
			    v3 = (Color *)sub_183523A50(v11, 3150342LL);
			    v12.clearDepth = 1;
			    v12.backgroundColorHDR = *v3;
			    v4 = *(_OWORD *)&v12.clearColorMode;
			    v5 = *(_QWORD *)&v12.backgroundColorHDR.a;
			  }
			  *(_OWORD *)&retstr->clearColorMode = v4;
			  result = retstr;
			  *(_QWORD *)&retstr->backgroundColorHDR.a = v5;
			  return result;
			}
			
		}
	
		[Serializable]
		public struct Volumes // TypeDefIndex: 38663
		{
			// Fields
			[Obsolete("Since 2019.3, use Volumes.NewDefault() instead.")]
			public static readonly Volumes @default; // 0x00
			public LayerMask layerMask; // 0x00
			public Transform anchorOverride; // 0x08
	
			// Constructors
			static Volumes() {
				default = default;
			} // 0x00000001841E1670-0x00000001841E1680
			// Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
			void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			        HGWindConfig *cSrc,
			        HGWindConfig *cDst,
			        float t,
			        MethodInfo *method)
			{
			  ;
			}
			
	
			// Methods
			public static Volumes NewDefault() => default; // 0x00000001837D9200-0x00000001837D9250
			// CameraSettings+Volumes NewDefault()
			CameraSettings_Volumes *HG::Rendering::Runtime::CameraSettings::Volumes::NewDefault(
			        CameraSettings_Volumes *__return_ptr retstr,
			        MethodInfo *method)
			{
			  Type *v3; // rdx
			  PropertyInfo_1 *v4; // r8
			  Int32__Array **v5; // r9
			  CameraSettings_Volumes v6; // xmm0
			  CameraSettings_Volumes *result; // rax
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v9; // rdx
			  __int64 v10; // rcx
			  CameraSettings_Volumes v11; // [rsp+20h] [rbp-28h] BYREF
			  CameraSettings_Volumes v12; // [rsp+30h] [rbp-18h] BYREF
			
			  if ( IFix::WrappersManagerImpl::IsPatched(4072, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(4072, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v10, v9);
			    v6 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1440(&v12, Patch, 0LL);
			  }
			  else
			  {
			    v11 = (CameraSettings_Volumes)0xFFFFFFFFuLL;
			    sub_18002D1B0((SingleFieldAccessor *)&v11.anchorOverride, v3, v4, v5, *(MethodInfo **)&v11.layerMask.m_Mask);
			    v6 = v11;
			  }
			  result = retstr;
			  *retstr = v6;
			  return result;
			}
			
		}
	
		[Serializable]
		public struct Frustum // TypeDefIndex: 38665
		{
			// Fields
			public const float MinNearClipPlane = 1E-05f; // Metadata: 0x02304079
			public const float MinFarClipPlane = 0.0001f; // Metadata: 0x0230407D
			[Obsolete("Since 2019.3, use Frustum.NewDefault() instead.")]
			public static readonly Frustum @default; // 0x00
			public Mode mode; // 0x00
			public float aspect; // 0x04
			[FormerlySerializedAs("farClipPlane")]
			public float farClipPlaneRaw; // 0x08
			[FormerlySerializedAs("nearClipPlane")]
			public float nearClipPlaneRaw; // 0x0C
			[Range(1f, 179f)]
			public float fieldOfView; // 0x10
			public Matrix4x4 projectionMatrix; // 0x14
	
			// Properties
			public float farClipPlane { get => default; } // 0x0000000189C1D380-0x0000000189C1D3DC 
			// Single get_farClipPlane()
			float HG::Rendering::Runtime::CameraSettings::Frustum::get_farClipPlane(
			        CameraSettings_Frustum *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(4074, 0LL) )
			    return fmaxf(this->nearClipPlaneRaw + 0.000099999997, this->farClipPlaneRaw);
			  Patch = IFix::WrappersManagerImpl::GetPatch(4074, 0LL);
			  if ( !Patch )
			    sub_1800D8260(v6, v5);
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1443(Patch, this, 0LL);
			}
			
			public float nearClipPlane { get => default; } // 0x0000000189C1D3DC-0x0000000189C1D434 
			// Single get_nearClipPlane()
			float HG::Rendering::Runtime::CameraSettings::Frustum::get_nearClipPlane(
			        CameraSettings_Frustum *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(4075, 0LL) )
			    return fmaxf(0.0000099999997, this->nearClipPlaneRaw);
			  Patch = IFix::WrappersManagerImpl::GetPatch(4075, 0LL);
			  if ( !Patch )
			    sub_1800D8260(v6, v5);
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1443(Patch, this, 0LL);
			}
			
	
			// Nested types
			public enum Mode // TypeDefIndex: 38664
			{
				ComputeProjectionMatrix = 0,
				UseProjectionMatrixField = 1
			}
	
			// Constructors
			static Frustum() {
				default = default;
			} // 0x00000001841E1670-0x00000001841E1680
			// Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
			void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			        HGWindConfig *cSrc,
			        HGWindConfig *cDst,
			        float t,
			        MethodInfo *method)
			{
			  ;
			}
			
	
			// Methods
			public static Frustum NewDefault() => default; // 0x00000001837D8640-0x00000001837D8700
			// CameraSettings+Frustum NewDefault()
			CameraSettings_Frustum *HG::Rendering::Runtime::CameraSettings::Frustum::NewDefault(
			        CameraSettings_Frustum *__return_ptr retstr,
			        MethodInfo *method)
			{
			  Matrix4x4__StaticFields *static_fields; // rcx
			  __int128 v4; // xmm1
			  __m128i v5; // xmm2
			  __int128 v6; // xmm0
			  __int128 v7; // xmm1
			  __int128 v8; // xmm0
			  __int128 v9; // xmm1
			  __int128 v10; // xmm0
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v13; // rdx
			  __int64 v14; // rcx
			  CameraSettings_Frustum *v15; // rax
			  __int128 v16; // xmm1
			  __int128 v17; // xmm0
			  __int128 v18; // xmm1
			  __int128 v19; // xmm0
			  CameraSettings_Frustum v20; // [rsp+20h] [rbp-68h] BYREF
			
			  if ( IFix::WrappersManagerImpl::IsPatched(4071, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(4071, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v14, v13);
			    v15 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1439(&v20, Patch, 0LL);
			    v16 = *(_OWORD *)&v15->fieldOfView;
			    *(_OWORD *)&retstr->mode = *(_OWORD *)&v15->mode;
			    v17 = *(_OWORD *)&v15->projectionMatrix.m30;
			    *(_OWORD *)&retstr->fieldOfView = v16;
			    v18 = *(_OWORD *)&v15->projectionMatrix.m31;
			    *(_OWORD *)&retstr->projectionMatrix.m30 = v17;
			    v19 = *(_OWORD *)&v15->projectionMatrix.m32;
			    *(float *)&v15 = v15->projectionMatrix.m33;
			    *(_OWORD *)&retstr->projectionMatrix.m31 = v18;
			    *(_OWORD *)&retstr->projectionMatrix.m32 = v19;
			    LODWORD(retstr->projectionMatrix.m33) = (_DWORD)v15;
			  }
			  else
			  {
			    *(_QWORD *)&v20.mode = 0x3F80000000000000LL;
			    *(_QWORD *)&v20.farClipPlaneRaw = 0x3DCCCCCD447A0000LL;
			    v20.fieldOfView = 90.0;
			    static_fields = TypeInfo::UnityEngine::Matrix4x4->static_fields;
			    v4 = *(_OWORD *)&static_fields->identityMatrix.m01;
			    v5 = *(__m128i *)&static_fields->identityMatrix.m03;
			    *(_OWORD *)&v20.projectionMatrix.m00 = *(_OWORD *)&static_fields->identityMatrix.m00;
			    v6 = *(_OWORD *)&static_fields->identityMatrix.m02;
			    *(_OWORD *)&v20.projectionMatrix.m01 = v4;
			    v7 = *(_OWORD *)&v20.fieldOfView;
			    *(_OWORD *)&v20.projectionMatrix.m02 = v6;
			    *(_OWORD *)&retstr->mode = *(_OWORD *)&v20.mode;
			    v8 = *(_OWORD *)&v20.projectionMatrix.m30;
			    *(_OWORD *)&retstr->fieldOfView = v7;
			    v9 = *(_OWORD *)&v20.projectionMatrix.m31;
			    *(_OWORD *)&retstr->projectionMatrix.m30 = v8;
			    *(__m128i *)&v20.projectionMatrix.m03 = v5;
			    v10 = *(_OWORD *)&v20.projectionMatrix.m32;
			    *(_OWORD *)&retstr->projectionMatrix.m31 = v9;
			    *(_OWORD *)&retstr->projectionMatrix.m32 = v10;
			    LODWORD(retstr->projectionMatrix.m33) = _mm_cvtsi128_si32(_mm_srli_si128(v5, 12));
			  }
			  return retstr;
			}
			
			public Matrix4x4 ComputeProjectionMatrix() => default; // 0x0000000189C1D17C-0x0000000189C1D284
			// Matrix4x4 ComputeProjectionMatrix()
			Matrix4x4 *HG::Rendering::Runtime::CameraSettings::Frustum::ComputeProjectionMatrix(
			        Matrix4x4 *__return_ptr retstr,
			        CameraSettings_Frustum *this,
			        MethodInfo *method)
			{
			  float fieldOfView; // xmm6_4
			  float v6; // xmm8_4
			  float aspect; // xmm7_4
			  float v8; // xmm6_4
			  float farClipPlane; // xmm0_4
			  Matrix4x4 *v10; // rax
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v12; // rdx
			  __int64 v13; // rcx
			  __int128 v14; // xmm1
			  __int128 v15; // xmm0
			  __int128 v16; // xmm1
			  Matrix4x4 *result; // rax
			  Matrix4x4 v18; // [rsp+30h] [rbp-78h] BYREF
			
			  if ( IFix::WrappersManagerImpl::IsPatched(4076, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(4076, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v13, v12);
			    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1444(&v18, Patch, this, 0LL);
			  }
			  else
			  {
			    fieldOfView = this->fieldOfView;
			    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
			    v6 = HG::Rendering::Runtime::HGUtils::ClampFOV(fieldOfView, 0LL);
			    aspect = this->aspect;
			    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CameraSettings::Frustum);
			    v8 = HG::Rendering::Runtime::CameraSettings::Frustum::get_nearClipPlane(this, 0LL);
			    farClipPlane = HG::Rendering::Runtime::CameraSettings::Frustum::get_farClipPlane(this, 0LL);
			    v10 = UnityEngine::Matrix4x4::Perspective(&v18, v6, aspect, v8, farClipPlane, 0LL);
			  }
			  v14 = *(_OWORD *)&v10->m01;
			  *(_OWORD *)&retstr->m00 = *(_OWORD *)&v10->m00;
			  v15 = *(_OWORD *)&v10->m02;
			  *(_OWORD *)&retstr->m01 = v14;
			  v16 = *(_OWORD *)&v10->m03;
			  result = retstr;
			  *(_OWORD *)&retstr->m02 = v15;
			  *(_OWORD *)&retstr->m03 = v16;
			  return result;
			}
			
			public Matrix4x4 GetUsedProjectionMatrix() => default; // 0x0000000189C1D284-0x0000000189C1D380
			// Matrix4x4 GetUsedProjectionMatrix()
			Matrix4x4 *HG::Rendering::Runtime::CameraSettings::Frustum::GetUsedProjectionMatrix(
			        Matrix4x4 *__return_ptr retstr,
			        CameraSettings_Frustum *this,
			        MethodInfo *method)
			{
			  Matrix4x4 *v5; // rax
			  __int128 v6; // xmm1
			  __int128 v7; // xmm0
			  __int128 v8; // xmm1
			  __int64 v9; // rax
			  ArgumentException *v10; // rax
			  __int64 v11; // rdx
			  __int64 v12; // rcx
			  ArgumentException *v13; // rbx
			  __int64 v14; // rax
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int128 v16; // xmm1
			  Matrix4x4 *result; // rax
			  Matrix4x4 v18; // [rsp+20h] [rbp-48h] BYREF
			
			  if ( IFix::WrappersManagerImpl::IsPatched(4077, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(4077, 0LL);
			    if ( Patch )
			    {
			      v5 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1444(&v18, Patch, this, 0LL);
			      goto LABEL_11;
			    }
			LABEL_9:
			    sub_1800D8260(v12, v11);
			  }
			  if ( !this->mode )
			  {
			    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CameraSettings::Frustum);
			    v5 = HG::Rendering::Runtime::CameraSettings::Frustum::ComputeProjectionMatrix(&v18, this, 0LL);
			LABEL_11:
			    v16 = *(_OWORD *)&v5->m01;
			    *(_OWORD *)&retstr->m00 = *(_OWORD *)&v5->m00;
			    v7 = *(_OWORD *)&v5->m02;
			    *(_OWORD *)&retstr->m01 = v16;
			    v8 = *(_OWORD *)&v5->m03;
			    goto LABEL_12;
			  }
			  if ( this->mode != 1 )
			  {
			    v9 = sub_18007E180(&TypeInfo::System::ArgumentException);
			    v10 = (ArgumentException *)sub_18002C620(v9);
			    v13 = v10;
			    if ( v10 )
			    {
			      System::ArgumentException::ArgumentException(v10, 0LL);
			      v14 = sub_18007E180(&MethodInfo::HG::Rendering::Runtime::CameraSettings::Frustum::GetUsedProjectionMatrix);
			      sub_18007E190(v13, v14);
			    }
			    goto LABEL_9;
			  }
			  v6 = *(_OWORD *)&this->projectionMatrix.m01;
			  *(_OWORD *)&retstr->m00 = *(_OWORD *)&this->projectionMatrix.m00;
			  v7 = *(_OWORD *)&this->projectionMatrix.m02;
			  *(_OWORD *)&retstr->m01 = v6;
			  v8 = *(_OWORD *)&this->projectionMatrix.m03;
			LABEL_12:
			  *(_OWORD *)&retstr->m02 = v7;
			  result = retstr;
			  *(_OWORD *)&retstr->m03 = v8;
			  return result;
			}
			
		}
	
		[Serializable]
		public struct Culling // TypeDefIndex: 38666
		{
			// Fields
			[Obsolete("Since 2019.3, use Culling.NewDefault() instead.")]
			public static readonly Culling @default; // 0x00
			public bool useOcclusionCulling; // 0x00
			public LayerMask cullingMask; // 0x04
			public ulong sceneCullingMaskOverride; // 0x08
	
			// Constructors
			static Culling() {
				default = default;
			} // 0x00000001841E1670-0x00000001841E1680
			// Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
			void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			        HGWindConfig *cSrc,
			        HGWindConfig *cDst,
			        float t,
			        MethodInfo *method)
			{
			  ;
			}
			
	
			// Methods
			public static Culling NewDefault() => default; // 0x00000001837D91B0-0x00000001837D9200
			// CameraSettings+Culling NewDefault()
			CameraSettings_Culling *HG::Rendering::Runtime::CameraSettings::Culling::NewDefault(
			        CameraSettings_Culling *__return_ptr retstr,
			        MethodInfo *method)
			{
			  CameraSettings_Culling v3; // xmm0
			  CameraSettings_Culling *result; // rax
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v6; // rdx
			  __int64 v7; // rcx
			  CameraSettings_Culling v8; // [rsp+20h] [rbp-18h] BYREF
			
			  if ( IFix::WrappersManagerImpl::IsPatched(4070, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(4070, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v7, v6);
			    v3 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1438(&v8, Patch, 0LL);
			  }
			  else
			  {
			    v8 = (CameraSettings_Culling)0xFFFFFFFF00000001uLL;
			    v3 = (CameraSettings_Culling)0xFFFFFFFF00000001uLL;
			  }
			  result = retstr;
			  *retstr = v3;
			  return result;
			}
			
		}
	
		// Constructors
		static CameraSettings() {
			default = default;
			defaultCameraSettingsNonAlloc = default;
		} // 0x00000001837D8770-0x00000001837D88D0
		// CameraSettings()
		void HG::Rendering::Runtime::CameraSettings::cctor(MethodInfo *method)
		{
		  CameraSettings *v1; // rax
		  __int128 v2; // xmm0
		  CameraSettings *p_defaultCameraSettingsNonAlloc; // rcx
		  Type *v4; // rdx
		  PropertyInfo_1 *v5; // r8
		  Int32__Array **v6; // r9
		  __int128 v7; // [rsp+20h] [rbp-1C8h]
		  __int128 v8; // [rsp+30h] [rbp-1B8h]
		  FrameSettingsOverrideMask renderingPathCustomFrameSettingsOverrideMask; // [rsp+40h] [rbp-1A8h]
		  __int128 v10; // [rsp+50h] [rbp-198h]
		  __int128 v11; // [rsp+60h] [rbp-188h]
		  __int128 v12; // [rsp+70h] [rbp-178h]
		  __int128 v13; // [rsp+80h] [rbp-168h]
		  __int128 v14; // [rsp+A0h] [rbp-148h]
		  __int128 v15; // [rsp+B0h] [rbp-138h]
		  FrameSettingsOverrideMask v16; // [rsp+C0h] [rbp-128h]
		  __int128 v17; // [rsp+D0h] [rbp-118h]
		  __int128 v18; // [rsp+E0h] [rbp-108h]
		  __int128 v19; // [rsp+F0h] [rbp-F8h]
		  CameraSettings v20; // [rsp+100h] [rbp-E8h] BYREF
		  MethodInfo *v21; // [rsp+210h] [rbp+28h]
		
		  sub_18033B9D0(TypeInfo::HG::Rendering::Runtime::CameraSettings->static_fields, 0LL, 224LL);
		  v1 = HG::Rendering::Runtime::CameraSettings::NewDefault(&v20, 0LL);
		  v7 = *(_OWORD *)&v1->customRenderingSettings;
		  v8 = *(_OWORD *)&v1->renderingPathCustomFrameSettings.bitDatas.data2;
		  renderingPathCustomFrameSettingsOverrideMask = v1->renderingPathCustomFrameSettingsOverrideMask;
		  v10 = *(_OWORD *)&v1->bufferClearing.clearColorMode;
		  v11 = *(_OWORD *)&v1->bufferClearing.backgroundColorHDR.a;
		  v12 = *(_OWORD *)&v1->volumes.anchorOverride;
		  v13 = *(_OWORD *)&v1->frustum.farClipPlaneRaw;
		  v2 = *(_OWORD *)&v1->frustum.projectionMatrix.m10;
		  v1 = (CameraSettings *)((char *)v1 + 128);
		  v14 = *(_OWORD *)&v1->customRenderingSettings;
		  v15 = *(_OWORD *)&v1->renderingPathCustomFrameSettings.bitDatas.data2;
		  v16 = v1->renderingPathCustomFrameSettingsOverrideMask;
		  v17 = *(_OWORD *)&v1->bufferClearing.clearColorMode;
		  v18 = *(_OWORD *)&v1->bufferClearing.backgroundColorHDR.a;
		  v19 = *(_OWORD *)&v1->volumes.anchorOverride;
		  p_defaultCameraSettingsNonAlloc = &TypeInfo::HG::Rendering::Runtime::CameraSettings->static_fields->defaultCameraSettingsNonAlloc;
		  *(_OWORD *)&p_defaultCameraSettingsNonAlloc->customRenderingSettings = v7;
		  *(_OWORD *)&p_defaultCameraSettingsNonAlloc->renderingPathCustomFrameSettings.bitDatas.data2 = v8;
		  p_defaultCameraSettingsNonAlloc->renderingPathCustomFrameSettingsOverrideMask = renderingPathCustomFrameSettingsOverrideMask;
		  *(_OWORD *)&p_defaultCameraSettingsNonAlloc->bufferClearing.clearColorMode = v10;
		  *(_OWORD *)&p_defaultCameraSettingsNonAlloc->bufferClearing.backgroundColorHDR.a = v11;
		  *(_OWORD *)&p_defaultCameraSettingsNonAlloc->volumes.anchorOverride = v12;
		  *(_OWORD *)&p_defaultCameraSettingsNonAlloc->frustum.farClipPlaneRaw = v13;
		  p_defaultCameraSettingsNonAlloc = (CameraSettings *)((char *)p_defaultCameraSettingsNonAlloc + 128);
		  *(_OWORD *)&p_defaultCameraSettingsNonAlloc[-1].probeRangeCompressionFactor = v2;
		  *(_OWORD *)&p_defaultCameraSettingsNonAlloc->customRenderingSettings = v14;
		  *(_OWORD *)&p_defaultCameraSettingsNonAlloc->renderingPathCustomFrameSettings.bitDatas.data2 = v15;
		  p_defaultCameraSettingsNonAlloc->renderingPathCustomFrameSettingsOverrideMask = v16;
		  *(_OWORD *)&p_defaultCameraSettingsNonAlloc->bufferClearing.clearColorMode = v17;
		  *(_OWORD *)&p_defaultCameraSettingsNonAlloc->bufferClearing.backgroundColorHDR.a = v18;
		  *(_OWORD *)&p_defaultCameraSettingsNonAlloc->volumes.anchorOverride = v19;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::CameraSettings->static_fields->defaultCameraSettingsNonAlloc.volumes.anchorOverride,
		    v4,
		    v5,
		    v6,
		    v21);
		}
		
	
		// Methods
		public static CameraSettings NewDefault() => default; // 0x00000001837D8F70-0x00000001837D91B0
		// CameraSettings NewDefault()
		CameraSettings *HG::Rendering::Runtime::CameraSettings::NewDefault(
		        CameraSettings *__return_ptr retstr,
		        MethodInfo *method)
		{
		  CameraSettings_BufferClearing *v3; // rax
		  CameraSettings_Culling v4; // xmm0
		  Type *v5; // rdx
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  Type *v8; // rdx
		  PropertyInfo_1 *v9; // r8
		  Int32__Array **v10; // r9
		  CameraSettings_Volumes v11; // xmm0
		  __int128 v12; // xmm1
		  __int128 *p_m11; // rax
		  FrameSettingsOverrideMask v14; // xmm0
		  __int128 v15; // xmm1
		  __int128 v16; // xmm0
		  __int128 v17; // xmm1
		  __int128 v18; // xmm0
		  __int128 v19; // xmm0
		  __int128 v20; // xmm1
		  __int128 v21; // xmm0
		  __int128 v22; // xmm1
		  CameraSettings_Culling v23; // xmm0
		  __int128 v24; // xmm1
		  __int128 v25; // xmm0
		  CameraSettings *result; // rax
		  ILFixDynamicMethodWrapper_2 *v27; // rax
		  __int64 v28; // rdx
		  __int64 v29; // rcx
		  ILFixDynamicMethodWrapper_2 *v30; // rax
		  __int64 v31; // rdx
		  __int64 v32; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  CameraSettings *v34; // rax
		  __int128 v35; // xmm1
		  FrameSettingsOverrideMask renderingPathCustomFrameSettingsOverrideMask; // xmm0
		  __int128 v37; // xmm1
		  __int128 v38; // xmm0
		  __int128 v39; // xmm1
		  __int128 v40; // xmm0
		  unsigned __int128 v41; // [rsp+20h] [rbp-E0h] BYREF
		  CameraSettings_BufferClearing v42; // [rsp+30h] [rbp-D0h] BYREF
		  __m256i v43; // [rsp+50h] [rbp-B0h] BYREF
		  FrameSettingsOverrideMask v44; // [rsp+70h] [rbp-90h]
		  __int128 v45; // [rsp+80h] [rbp-80h]
		  _BYTE v46[108]; // [rsp+90h] [rbp-70h] BYREF
		  CameraSettings_Culling v47; // [rsp+100h] [rbp+0h]
		  char v48; // [rsp+110h] [rbp+10h]
		  int v49; // [rsp+114h] [rbp+14h]
		  int v50; // [rsp+118h] [rbp+18h]
		  int v51; // [rsp+120h] [rbp+20h]
		  CameraSettings_Frustum v52; // [rsp+130h] [rbp+30h] BYREF
		  CameraSettings v53; // [rsp+188h] [rbp+88h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4068, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4068, 0LL);
		    if ( Patch )
		    {
		      v34 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1441(&v53, Patch, 0LL);
		      v35 = *(_OWORD *)&v34->renderingPathCustomFrameSettings.bitDatas.data2;
		      *(_OWORD *)&retstr->customRenderingSettings = *(_OWORD *)&v34->customRenderingSettings;
		      renderingPathCustomFrameSettingsOverrideMask = v34->renderingPathCustomFrameSettingsOverrideMask;
		      *(_OWORD *)&retstr->renderingPathCustomFrameSettings.bitDatas.data2 = v35;
		      v37 = *(_OWORD *)&v34->bufferClearing.clearColorMode;
		      retstr->renderingPathCustomFrameSettingsOverrideMask = renderingPathCustomFrameSettingsOverrideMask;
		      v38 = *(_OWORD *)&v34->bufferClearing.backgroundColorHDR.a;
		      *(_OWORD *)&retstr->bufferClearing.clearColorMode = v37;
		      v39 = *(_OWORD *)&v34->volumes.anchorOverride;
		      *(_OWORD *)&retstr->bufferClearing.backgroundColorHDR.a = v38;
		      v40 = *(_OWORD *)&v34->frustum.farClipPlaneRaw;
		      *(_OWORD *)&retstr->volumes.anchorOverride = v39;
		      *(_OWORD *)&retstr->frustum.farClipPlaneRaw = v40;
		      v19 = *(_OWORD *)&v34->frustum.projectionMatrix.m10;
		      p_m11 = (__int128 *)&v34->frustum.projectionMatrix.m11;
		      goto LABEL_15;
		    }
		    goto LABEL_23;
		  }
		  sub_18033B9D0(&v43, 0LL, 224LL);
		  if ( !TypeInfo::HG::Rendering::Runtime::CameraSettings::BufferClearing->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::CameraSettings::BufferClearing);
		  v3 = HG::Rendering::Runtime::CameraSettings::BufferClearing::NewDefault(&v42, 0LL);
		  v45 = *(_OWORD *)&v3->clearColorMode;
		  *(_QWORD *)v46 = *(_QWORD *)&v3->backgroundColorHDR.a;
		  if ( !TypeInfo::HG::Rendering::Runtime::CameraSettings::Culling->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::CameraSettings::Culling);
		  if ( IFix::WrappersManagerImpl::IsPatched(4070, 0LL) )
		  {
		    v27 = IFix::WrappersManagerImpl::GetPatch(4070, 0LL);
		    if ( v27 )
		    {
		      v4 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1438((CameraSettings_Culling *)&v41, v27, 0LL);
		      goto LABEL_8;
		    }
		LABEL_23:
		    sub_1800D8260(v29, v28);
		  }
		  v41 = 0xFFFFFFFF00000001uLL;
		  v4 = (CameraSettings_Culling)0xFFFFFFFF00000001uLL;
		LABEL_8:
		  v47 = v4;
		  *(FrameSettings *)&v43.m256i_u64[1] = *HG::Rendering::Runtime::FrameSettings::NewDefaultCamera(
		                                           (FrameSettings *)&v42,
		                                           0LL);
		  if ( !TypeInfo::HG::Rendering::Runtime::CameraSettings::Frustum->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::CameraSettings::Frustum);
		  *(CameraSettings_Frustum *)&v46[24] = *HG::Rendering::Runtime::CameraSettings::Frustum::NewDefault(&v52, 0LL);
		  v43.m256i_i8[0] = 0;
		  if ( !TypeInfo::HG::Rendering::Runtime::CameraSettings::Volumes->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::CameraSettings::Volumes);
		  if ( IFix::WrappersManagerImpl::IsPatched(4072, 0LL) )
		  {
		    v30 = IFix::WrappersManagerImpl::GetPatch(4072, 0LL);
		    if ( !v30 )
		      sub_1800D8260(v32, v31);
		    v11 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1440((CameraSettings_Volumes *)&v42, v30, 0LL);
		  }
		  else
		  {
		    v41 = 0xFFFFFFFFuLL;
		    sub_18002D1B0((SingleFieldAccessor *)((char *)&v41 + 8), v5, v6, v7, (MethodInfo *)0xFFFFFFFFLL);
		    v11 = (CameraSettings_Volumes)v41;
		  }
		  *(CameraSettings_Volumes *)&v46[8] = v11;
		  sub_18002D1B0((SingleFieldAccessor *)&v46[16], v8, v9, v10, (MethodInfo *)v41);
		  v49 = 0;
		  v48 = 0;
		  v50 = -1;
		  v51 = 1065353216;
		  v12 = *(_OWORD *)&v43.m256i_u64[2];
		  p_m11 = (__int128 *)&v46[64];
		  *(_OWORD *)&retstr->customRenderingSettings = *(_OWORD *)v43.m256i_i8;
		  v14 = v44;
		  *(_OWORD *)&retstr->renderingPathCustomFrameSettings.bitDatas.data2 = v12;
		  v15 = v45;
		  retstr->renderingPathCustomFrameSettingsOverrideMask = v14;
		  v16 = *(_OWORD *)v46;
		  *(_OWORD *)&retstr->bufferClearing.clearColorMode = v15;
		  v17 = *(_OWORD *)&v46[16];
		  *(_OWORD *)&retstr->bufferClearing.backgroundColorHDR.a = v16;
		  v18 = *(_OWORD *)&v46[32];
		  *(_OWORD *)&retstr->volumes.anchorOverride = v17;
		  *(_OWORD *)&retstr->frustum.farClipPlaneRaw = v18;
		  v19 = *(_OWORD *)&v46[48];
		LABEL_15:
		  v20 = *p_m11;
		  *(_OWORD *)&retstr->frustum.projectionMatrix.m10 = v19;
		  v21 = p_m11[1];
		  *(_OWORD *)&retstr->frustum.projectionMatrix.m11 = v20;
		  v22 = p_m11[2];
		  *(_OWORD *)&retstr->frustum.projectionMatrix.m12 = v21;
		  v23 = (CameraSettings_Culling)p_m11[3];
		  *(_OWORD *)&retstr->frustum.projectionMatrix.m13 = v22;
		  v24 = p_m11[4];
		  retstr->culling = v23;
		  v25 = p_m11[5];
		  result = retstr;
		  *(_OWORD *)&retstr->invertFaceCulling = v24;
		  *(_OWORD *)&retstr->probeRangeCompressionFactor = v25;
		  return result;
		}
		
		public static CameraSettings From(HGCamera hgCamera) => default; // 0x000000018324DDE0-0x000000018324EC00
		// CameraSettings From(HGCamera)
		CameraSettings *HG::Rendering::Runtime::CameraSettings::From(
		        CameraSettings *__return_ptr retstr,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
		  ILFixDynamicMethodWrapper_2__Array *v8; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  CameraSettings *v12; // rax
		  __int128 v13; // xmm1
		  FrameSettingsOverrideMask renderingPathCustomFrameSettingsOverrideMask; // xmm0
		  __int128 v15; // xmm1
		  __int128 v16; // xmm0
		  __int128 v17; // xmm1
		  __int128 v18; // xmm0
		  __int128 v19; // xmm0
		  __int128 v20; // xmm0
		  FrameSettingsOverrideMask v21; // xmm1
		  CameraSettings_Culling v22; // xmm0
		  __int128 v23; // xmm1
		  __int128 v24; // xmm0
		  CameraSettings *result; // rax
		  struct CameraSettings__Class *v26; // rax
		  __int64 p_defaultCameraSettingsNonAlloc; // rax
		  __int128 v28; // xmm0
		  Camera *camera; // rbx
		  __int64 (__fastcall *v30)(Camera *); // rax
		  int32_t v31; // eax
		  __int64 v32; // rdx
		  __int64 v33; // rcx
		  Camera *v34; // rbx
		  __int64 (__fastcall *v35)(Camera *); // rax
		  char v36; // al
		  __int64 v37; // rdx
		  Object *v38; // rsi
		  struct ILFixDynamicMethodWrapper_2__Class *v39; // rcx
		  ILFixDynamicMethodWrapper_2__Array *v40; // rbx
		  ILFixDynamicMethodWrapper_2__Array *v41; // rbx
		  ILFixDynamicMethodWrapper_2 *v42; // rax
		  __int64 v43; // rdx
		  __int64 v44; // rcx
		  void *v45; // rax
		  Camera *v46; // rbx
		  float (__fastcall *v47)(Camera *); // rax
		  __int64 v48; // rdx
		  __int64 v49; // rcx
		  float v50; // xmm0_4
		  Camera *v51; // rbx
		  float (__fastcall *v52)(Camera *); // rax
		  __int64 v53; // rdx
		  __int64 v54; // rcx
		  float v55; // xmm0_4
		  Camera *v56; // rbx
		  float (__fastcall *v57)(Camera *); // rax
		  __int64 v58; // rdx
		  __int64 v59; // rcx
		  float v60; // xmm0_4
		  Camera *v61; // rbx
		  float (__fastcall *v62)(Camera *); // rax
		  __int64 v63; // rdx
		  __int64 v64; // rcx
		  float v65; // xmm0_4
		  Camera *v66; // rbx
		  void (__fastcall *v67)(Camera *, Matrix4x4 *); // rax
		  __int64 v68; // rdx
		  __int64 v69; // rcx
		  Camera *v70; // rsi
		  struct MethodInfo *v71; // rbx
		  __int64 (__fastcall *v72)(Camera *); // rax
		  __int64 v73; // rdx
		  __int64 v74; // rcx
		  __int64 v75; // rsi
		  void (***rgctx_data)(void); // rcx
		  void (**v77)(void); // rdx
		  const Il2CppRGCTXData *v78; // rax
		  void *rgctxDataDummy; // rbx
		  struct Type__Class *v80; // rcx
		  System::Type **v81; // rbx
		  System::Type *v82; // rbx
		  __int64 v83; // rbx
		  void (__fastcall *v84)(__int64, __int64, _QWORD, char *); // rax
		  Type *v85; // rdx
		  PropertyInfo_1 *v86; // r8
		  Int32__Array **v87; // r9
		  unsigned __int64 v88; // rdx
		  char *static_fields; // rcx
		  Object *v90; // rsi
		  struct ILFixDynamicMethodWrapper_2__Class *v91; // rdx
		  ILFixDynamicMethodWrapper_2__Array *v92; // rbx
		  ILFixDynamicMethodWrapper_2__Array *v93; // rbx
		  ILFixDynamicMethodWrapper_2 *v94; // rax
		  __int64 v95; // rdx
		  __int64 v96; // rcx
		  FrameSettings *v97; // rax
		  FrameSettingsOverrideMask v98; // xmm0
		  unsigned __int64 v99; // rdx
		  signed __int64 v100; // rtt
		  signed __int64 v101; // rtt
		  Camera *v102; // rbx
		  void (__fastcall *v103)(Camera *, Matrix4x4 *); // rax
		  double (__fastcall *v104)(Matrix4x4 *); // rax
		  double v105; // xmm0_8
		  Camera *v106; // rbx
		  float v107; // xmm12_4
		  void (__fastcall *v108)(Camera *, Matrix4x4 *); // rax
		  __int32 v109; // xmm7_4
		  unsigned int v110; // xmm6_4
		  float v111; // xmm11_4
		  float v112; // xmm6_4
		  Camera *v113; // rbx
		  void (__fastcall *v114)(Camera *, _OWORD *); // rax
		  int v115; // xmm0_4
		  float v116; // xmm0_4
		  int v117; // ebx
		  int v118; // eax
		  Matrix4x4 *projectionMatrix; // rax
		  float v120; // xmm2_4
		  float v121; // xmm3_4
		  int v122; // xmm2_4
		  int v123; // xmm3_4
		  float v124; // xmm2_4
		  bool v125; // zf
		  char v126; // al
		  __int128 v127; // xmm1
		  FrameSettingsOverrideMask v128; // xmm0
		  __int128 v129; // xmm1
		  __int128 v130; // xmm0
		  __int128 v131; // xmm1
		  __int128 v132; // xmm0
		  __int128 v133; // xmm1
		  __int128 v134; // xmm0
		  __int128 v135; // xmm1
		  __int128 v136; // xmm0
		  CameraSettings_Culling v137; // xmm1
		  __int128 v138; // xmm0
		  __int128 v139; // xmm1
		  __int64 v140; // rax
		  __int64 v141; // rax
		  __int64 v142; // rax
		  __int64 v143; // rax
		  __int64 v144; // rax
		  __int64 v145; // rax
		  __int64 v146; // rax
		  __int64 v147; // rax
		  __int64 v148; // rax
		  __int64 v149; // rax
		  __int64 v150; // rax
		  __int64 v151; // rax
		  __int64 v152; // rax
		  Matrix4x4 v153; // [rsp+20h] [rbp-E0h] BYREF
		  __int128 v154; // [rsp+60h] [rbp-A0h] BYREF
		  __int128 v155; // [rsp+70h] [rbp-90h] BYREF
		  Matrix4x4 v156; // [rsp+80h] [rbp-80h] BYREF
		  _OWORD v157[4]; // [rsp+C0h] [rbp-40h] BYREF
		  __m256i v158; // [rsp+100h] [rbp+0h] BYREF
		  FrameSettingsOverrideMask v159; // [rsp+120h] [rbp+20h]
		  _BYTE v160[48]; // [rsp+130h] [rbp+30h] BYREF
		  _BYTE v161[80]; // [rsp+160h] [rbp+60h] BYREF
		  CameraSettings_Culling v162; // [rsp+1B0h] [rbp+B0h]
		  __int128 v163; // [rsp+1C0h] [rbp+C0h]
		  __int128 v164; // [rsp+1D0h] [rbp+D0h]
		  CameraSettings v165; // [rsp+1E0h] [rbp+E0h] BYREF
		  Object *P0; // [rsp+340h] [rbp+240h] BYREF
		
		  sub_18033B9D0(&v158, 0LL, 224LL);
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v154 = 0LL;
		  memset(&v156, 0, sizeof(v156));
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    sub_1800D8260(v6, v5);
		  if ( wrapperArray->max_length.size > 871 )
		  {
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v8 = v6->static_fields->wrapperArray;
		    if ( !v8 )
		      sub_1800D8260(v6, v5);
		    if ( v8->max_length.size <= 0x367u )
		      sub_1800D2AB0(v6, v5);
		    if ( v8[24].vector[7] )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(871, 0LL);
		      if ( !Patch )
		        sub_1800D8260(v11, v10);
		      v12 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_344(&v165, Patch, (Object *)hgCamera, 0LL);
		      v13 = *(_OWORD *)&v12->renderingPathCustomFrameSettings.bitDatas.data2;
		      *(_OWORD *)&retstr->customRenderingSettings = *(_OWORD *)&v12->customRenderingSettings;
		      renderingPathCustomFrameSettingsOverrideMask = v12->renderingPathCustomFrameSettingsOverrideMask;
		      *(_OWORD *)&retstr->renderingPathCustomFrameSettings.bitDatas.data2 = v13;
		      v15 = *(_OWORD *)&v12->bufferClearing.clearColorMode;
		      retstr->renderingPathCustomFrameSettingsOverrideMask = renderingPathCustomFrameSettingsOverrideMask;
		      v16 = *(_OWORD *)&v12->bufferClearing.backgroundColorHDR.a;
		      *(_OWORD *)&retstr->bufferClearing.clearColorMode = v15;
		      v17 = *(_OWORD *)&v12->volumes.anchorOverride;
		      *(_OWORD *)&retstr->bufferClearing.backgroundColorHDR.a = v16;
		      v18 = *(_OWORD *)&v12->frustum.farClipPlaneRaw;
		      *(_OWORD *)&retstr->volumes.anchorOverride = v17;
		      *(_OWORD *)&retstr->frustum.farClipPlaneRaw = v18;
		      v19 = *(_OWORD *)&v12->frustum.projectionMatrix.m10;
		      v12 = (CameraSettings *)((char *)v12 + 128);
		      *(_OWORD *)&retstr->frustum.projectionMatrix.m10 = v19;
		      v20 = *(_OWORD *)&v12->renderingPathCustomFrameSettings.bitDatas.data2;
		      *(_OWORD *)&retstr->frustum.projectionMatrix.m11 = *(_OWORD *)&v12->customRenderingSettings;
		      v21 = v12->renderingPathCustomFrameSettingsOverrideMask;
		      *(_OWORD *)&retstr->frustum.projectionMatrix.m12 = v20;
		      v22 = *(CameraSettings_Culling *)&v12->bufferClearing.clearColorMode;
		      *(FrameSettingsOverrideMask *)&retstr->frustum.projectionMatrix.m13 = v21;
		      v23 = *(_OWORD *)&v12->bufferClearing.backgroundColorHDR.a;
		      retstr->culling = v22;
		      v24 = *(_OWORD *)&v12->volumes.anchorOverride;
		      result = retstr;
		      *(_OWORD *)&retstr->invertFaceCulling = v23;
		      *(_OWORD *)&retstr->probeRangeCompressionFactor = v24;
		      return result;
		    }
		  }
		  v26 = TypeInfo::HG::Rendering::Runtime::CameraSettings;
		  if ( !TypeInfo::HG::Rendering::Runtime::CameraSettings->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::CameraSettings);
		    v26 = TypeInfo::HG::Rendering::Runtime::CameraSettings;
		  }
		  p_defaultCameraSettingsNonAlloc = (__int64)&v26->static_fields->defaultCameraSettingsNonAlloc;
		  v158 = *(__m256i *)p_defaultCameraSettingsNonAlloc;
		  v159 = *(FrameSettingsOverrideMask *)(p_defaultCameraSettingsNonAlloc + 32);
		  *(_OWORD *)v160 = *(_OWORD *)(p_defaultCameraSettingsNonAlloc + 48);
		  *(_OWORD *)&v160[16] = *(_OWORD *)(p_defaultCameraSettingsNonAlloc + 64);
		  *(_OWORD *)&v160[32] = *(_OWORD *)(p_defaultCameraSettingsNonAlloc + 80);
		  *(_OWORD *)v161 = *(_OWORD *)(p_defaultCameraSettingsNonAlloc + 96);
		  v28 = *(_OWORD *)(p_defaultCameraSettingsNonAlloc + 112);
		  p_defaultCameraSettingsNonAlloc += 128LL;
		  *(_OWORD *)&v161[16] = v28;
		  *(_OWORD *)&v161[32] = *(_OWORD *)p_defaultCameraSettingsNonAlloc;
		  *(_OWORD *)&v161[48] = *(_OWORD *)(p_defaultCameraSettingsNonAlloc + 16);
		  *(_OWORD *)&v161[64] = *(_OWORD *)(p_defaultCameraSettingsNonAlloc + 32);
		  v162 = *(CameraSettings_Culling *)(p_defaultCameraSettingsNonAlloc + 48);
		  v163 = *(_OWORD *)(p_defaultCameraSettingsNonAlloc + 64);
		  v164 = *(_OWORD *)(p_defaultCameraSettingsNonAlloc + 80);
		  if ( !hgCamera )
		    sub_1800D8260(&v161[32], v5);
		  camera = hgCamera->fields.camera;
		  if ( !camera )
		    sub_1800D8260(&v161[32], v5);
		  v30 = (__int64 (__fastcall *)(Camera *))qword_18F36F120;
		  if ( !qword_18F36F120 )
		  {
		    v30 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_cullingMask()");
		    if ( !v30 )
		    {
		      v140 = sub_1802EE1B8("UnityEngine.Camera::get_cullingMask()");
		      sub_18007E1B0(v140, 0LL);
		    }
		    qword_18F36F120 = (__int64)v30;
		  }
		  v31 = v30(camera);
		  v34 = hgCamera->fields.camera;
		  v162.cullingMask.m_Mask = v31;
		  if ( !v34 )
		    sub_1800D8260(v33, v32);
		  v35 = (__int64 (__fastcall *)(Camera *))qword_18F36F140;
		  if ( !qword_18F36F140 )
		  {
		    v35 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_useOcclusionCulling()");
		    if ( !v35 )
		    {
		      v141 = sub_1802EE1B8("UnityEngine.Camera::get_useOcclusionCulling()");
		      sub_18007E1B0(v141, 0LL);
		    }
		    qword_18F36F140 = (__int64)v35;
		  }
		  v36 = v35(v34);
		  v38 = (Object *)hgCamera->fields.camera;
		  v162.useOcclusionCulling = v36;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGUtils->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGUtils);
		  v39 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v39 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v40 = v39->static_fields->wrapperArray;
		  if ( !v40 )
		    sub_1800D8260(v39, v37);
		  if ( v40->max_length.size <= 859 )
		    goto LABEL_36;
		  if ( !v39->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v39);
		    v39 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v41 = v39->static_fields->wrapperArray;
		  if ( !v41 )
		    sub_1800D8260(v39, v37);
		  if ( v41->max_length.size <= 0x35Bu )
		    sub_1800D2AB0(v39, v37);
		  if ( v41[23].vector[31] )
		  {
		    v42 = IFix::WrappersManagerImpl::GetPatch(859, 0LL);
		    if ( !v42 )
		      sub_1800D8260(v44, v43);
		    v45 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_739((ILFixDynamicMethodWrapper_3 *)v42, v38, 0LL);
		  }
		  else
		  {
		LABEL_36:
		    v45 = 0LL;
		  }
		  v46 = hgCamera->fields.camera;
		  v162.sceneCullingMaskOverride = (uint64_t)v45;
		  if ( !v46 )
		    sub_1800D8260(v39, v37);
		  v47 = (float (__fastcall *)(Camera *))qword_18F36F118;
		  if ( !qword_18F36F118 )
		  {
		    v47 = (float (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_aspect()");
		    if ( !v47 )
		    {
		      v142 = sub_1802EE1B8("UnityEngine.Camera::get_aspect()");
		      sub_18007E1B0(v142, 0LL);
		    }
		    qword_18F36F118 = (__int64)v47;
		  }
		  v50 = v47(v46);
		  v51 = hgCamera->fields.camera;
		  *(float *)&v160[44] = v50;
		  if ( !v51 )
		    sub_1800D8260(v49, v48);
		  v52 = (float (__fastcall *)(Camera *))qword_18F36F0C0;
		  if ( !qword_18F36F0C0 )
		  {
		    v52 = (float (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_farClipPlane()");
		    if ( !v52 )
		    {
		      v143 = sub_1802EE1B8("UnityEngine.Camera::get_farClipPlane()");
		      sub_18007E1B0(v143, 0LL);
		    }
		    qword_18F36F0C0 = (__int64)v52;
		  }
		  v55 = v52(v51);
		  v56 = hgCamera->fields.camera;
		  *(float *)v161 = v55;
		  if ( !v56 )
		    sub_1800D8260(v54, v53);
		  v57 = (float (__fastcall *)(Camera *))qword_18F36F0B0;
		  if ( !qword_18F36F0B0 )
		  {
		    v57 = (float (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_nearClipPlane()");
		    if ( !v57 )
		    {
		      v144 = sub_1802EE1B8("UnityEngine.Camera::get_nearClipPlane()");
		      sub_18007E1B0(v144, 0LL);
		    }
		    qword_18F36F0B0 = (__int64)v57;
		  }
		  v60 = v57(v56);
		  v61 = hgCamera->fields.camera;
		  *(float *)&v161[4] = v60;
		  if ( !v61 )
		    sub_1800D8260(v59, v58);
		  v62 = (float (__fastcall *)(Camera *))qword_18F36F0D0;
		  if ( !qword_18F36F0D0 )
		  {
		    v62 = (float (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_fieldOfView()");
		    if ( !v62 )
		    {
		      v145 = sub_1802EE1B8("UnityEngine.Camera::get_fieldOfView()");
		      sub_18007E1B0(v145, 0LL);
		    }
		    qword_18F36F0D0 = (__int64)v62;
		  }
		  v65 = v62(v61);
		  v66 = hgCamera->fields.camera;
		  *(float *)&v161[8] = v65;
		  *(_DWORD *)&v160[40] = 1;
		  if ( !v66 )
		    sub_1800D8260(v64, v63);
		  v67 = (void (__fastcall *)(Camera *, Matrix4x4 *))qword_18F36F228;
		  memset(&v153, 0, sizeof(v153));
		  if ( !qword_18F36F228 )
		  {
		    v67 = (void (__fastcall *)(Camera *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                        "UnityEngine.Camera::get_projectionMatrix_Injected(UnityEngine.Matrix4x4&)");
		    if ( !v67 )
		    {
		      v146 = sub_1802EE1B8("UnityEngine.Camera::get_projectionMatrix_Injected(UnityEngine.Matrix4x4&)");
		      sub_18007E1B0(v146, 0LL);
		    }
		    qword_18F36F228 = (__int64)v67;
		  }
		  v67(v66, &v153);
		  v70 = hgCamera->fields.camera;
		  LOBYTE(v163) = 0;
		  *(Matrix4x4 *)&v161[12] = v153;
		  if ( !v70 )
		    sub_1800D8260(v69, v68);
		  v71 = MethodInfo::UnityEngine::Component::TryGetComponent<HG::Rendering::Runtime::HGAdditionalCameraData>;
		  if ( !MethodInfo::UnityEngine::Component::TryGetComponent<HG::Rendering::Runtime::HGAdditionalCameraData>->rgctx_data )
		    sub_1800430B0(MethodInfo::UnityEngine::Component::TryGetComponent<HG::Rendering::Runtime::HGAdditionalCameraData>);
		  v72 = (__int64 (__fastcall *)(Camera *))qword_18F36FBC8;
		  if ( !qword_18F36FBC8 )
		  {
		    v72 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Component::get_gameObject()");
		    if ( !v72 )
		    {
		      v147 = sub_1802EE1B8("UnityEngine.Component::get_gameObject()");
		      sub_18007E1B0(v147, 0LL);
		    }
		    qword_18F36FBC8 = (__int64)v72;
		  }
		  v75 = v72(v70);
		  if ( !v75 )
		    sub_1800D8260(v74, v73);
		  rgctx_data = (void (***)(void))v71->rgctx_data;
		  v77 = *rgctx_data;
		  if ( !(*rgctx_data)[4] )
		    (*v77)();
		  v78 = v71->rgctx_data;
		  rgctxDataDummy = v78->rgctxDataDummy;
		  if ( !*((_QWORD *)v78->rgctxDataDummy + 7) )
		    sub_1800430B0(v78->rgctxDataDummy);
		  v80 = TypeInfo::System::Type;
		  v81 = (System::Type **)*((_QWORD *)rgctxDataDummy + 7);
		  v155 = 0LL;
		  v82 = *v81;
		  if ( !TypeInfo::System::Type->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::System::Type);
		    v80 = TypeInfo::System::Type;
		  }
		  if ( v82 )
		  {
		    if ( !v80->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v80);
		    v83 = System::Type::internal_from_handle(v82, v77);
		  }
		  else
		  {
		    v83 = 0LL;
		  }
		  v84 = (void (__fastcall *)(__int64, __int64, _QWORD, char *))qword_18F36FC20;
		  if ( !qword_18F36FC20 )
		  {
		    v84 = (void (__fastcall *)(__int64, __int64, _QWORD, char *))il2cpp_resolve_icall_1(
		                                                                   "UnityEngine.GameObject::TryGetComponentFastPath(Syste"
		                                                                   "m.Type,System.Int32,System.IntPtr)");
		    if ( !v84 )
		    {
		      v148 = sub_1802EE1B8("UnityEngine.GameObject::TryGetComponentFastPath(System.Type,System.Int32,System.IntPtr)");
		      sub_18007E1B0(v148, 0LL);
		    }
		    qword_18F36FC20 = (__int64)v84;
		  }
		  v84(v75, v83, 0LL, (char *)&v155 + 8);
		  P0 = (Object *)v155;
		  sub_18002D1B0((SingleFieldAccessor *)&P0, v85, v86, v87, *(MethodInfo **)&v153.m00);
		  if ( (_QWORD)v155 )
		  {
		    static_fields = (char *)P0;
		    if ( !P0 )
		      sub_1800D8260(0LL, v88);
		    v158.m256i_i8[0] = BYTE2(P0[8].klass);
		    *(Object *)&v160[4] = *(Object *)((char *)P0 + 36);
		    *(_DWORD *)v160 = P0[2].klass;
		    v160[20] = BYTE4(P0[3].klass);
		    v90 = P0;
		    DWORD1(v163) = HIDWORD(P0[7].klass);
		    v91 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      static_fields = (char *)P0;
		      v91 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v92 = v91->static_fields->wrapperArray;
		    if ( !v92 )
		      sub_1800D8260(static_fields, v91);
		    if ( v92->max_length.size <= 695 )
		      goto LABEL_91;
		    if ( !v91->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v91);
		      static_fields = (char *)P0;
		      v91 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v93 = v91->static_fields->wrapperArray;
		    if ( !v93 )
		      sub_1800D8260(static_fields, v91);
		    if ( v93->max_length.size <= 0x2B7u )
		      sub_1800D2AB0(static_fields, v91);
		    if ( v93[19].vector[11] )
		    {
		      v94 = IFix::WrappersManagerImpl::GetPatch(695, 0LL);
		      if ( !v94 )
		        sub_1800D8260(v96, v95);
		      v97 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_274(v94, v90, 0LL);
		      static_fields = (char *)P0;
		    }
		    else
		    {
		LABEL_91:
		      v97 = (FrameSettings *)&v90[11];
		    }
		    *(BitArray128 *)&v158.m256i_u64[1] = v97->bitDatas;
		    v158.m256i_i64[3] = *(_QWORD *)&v97->materialQuality;
		    if ( !static_fields )
		      sub_1800D8260(0LL, v91);
		    v98 = *(FrameSettingsOverrideMask *)(static_fields + 200);
		    *(_QWORD *)&v154 = 0LL;
		    v159 = v98;
		    v88 = (unsigned int)dword_18F35FD08;
		    *((_QWORD *)&v154 + 1) = *((_QWORD *)static_fields + 8);
		    if ( dword_18F35FD08 )
		    {
		      v99 = ((((unsigned __int64)&v154 + 8) >> 12) & 0x1FFFFF) >> 6;
		      _m_prefetchw(&qword_18F0BCBA0[v99 + 36190]);
		      do
		        v100 = qword_18F0BCBA0[v99 + 36190];
		      while ( v100 != _InterlockedCompareExchange64(
		                        &qword_18F0BCBA0[v99 + 36190],
		                        v100 | (1LL << ((((unsigned __int64)&v154 + 8) >> 12) & 0x3F)),
		                        v100) );
		      static_fields = (char *)P0;
		      v88 = (unsigned int)dword_18F35FD08;
		    }
		    if ( !static_fields )
		      goto LABEL_140;
		    LODWORD(v154) = *((_DWORD *)static_fields + 14);
		    *(_OWORD *)&v160[24] = v154;
		    if ( (_DWORD)v88 )
		    {
		      v88 = (((unsigned __int64)&v160[32] >> 12) & 0x1FFFFF) >> 6;
		      _m_prefetchw(&qword_18F0BCBA0[v88 + 36190]);
		      do
		        v101 = qword_18F0BCBA0[v88 + 36190];
		      while ( v101 != _InterlockedCompareExchange64(
		                        &qword_18F0BCBA0[v88 + 36190],
		                        v101 | (1LL << (((unsigned __int64)&v160[32] >> 12) & 0x3F)),
		                        v101) );
		      static_fields = (char *)P0;
		    }
		    if ( !static_fields )
		      goto LABEL_140;
		    DWORD2(v163) = *((_DWORD *)static_fields + 33);
		    LOBYTE(v163) = static_fields[131];
		  }
		  v102 = hgCamera->fields.camera;
		  if ( !v102 )
		    goto LABEL_140;
		  v103 = (void (__fastcall *)(Camera *, Matrix4x4 *))qword_18F36F220;
		  memset(&v153, 0, sizeof(v153));
		  if ( !qword_18F36F220 )
		  {
		    v103 = (void (__fastcall *)(Camera *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                         "UnityEngine.Camera::get_worldToCameraMatrix_Injected(UnityEngine.Matrix4x4&)");
		    if ( !v103 )
		    {
		      v149 = sub_1802EE1B8("UnityEngine.Camera::get_worldToCameraMatrix_Injected(UnityEngine.Matrix4x4&)");
		      sub_18007E1B0(v149, 0LL);
		    }
		    qword_18F36F220 = (__int64)v103;
		  }
		  v103(v102, &v153);
		  v104 = (double (__fastcall *)(Matrix4x4 *))qword_18F36FA40;
		  v156 = v153;
		  if ( !qword_18F36FA40 )
		  {
		    v104 = (double (__fastcall *)(Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                 "UnityEngine.Matrix4x4::GetDeterminant_Injected(UnityEngine.Matrix4x4&)");
		    if ( !v104 )
		    {
		      v150 = sub_1802EE1B8("UnityEngine.Matrix4x4::GetDeterminant_Injected(UnityEngine.Matrix4x4&)");
		      sub_18007E1B0(v150, 0LL);
		    }
		    qword_18F36FA40 = (__int64)v104;
		  }
		  v105 = v104(&v156);
		  v106 = hgCamera->fields.camera;
		  v107 = *(float *)&v105;
		  if ( !v106 )
		    goto LABEL_140;
		  v108 = (void (__fastcall *)(Camera *, Matrix4x4 *))qword_18F36F228;
		  memset(&v153, 0, sizeof(v153));
		  if ( !qword_18F36F228 )
		  {
		    v108 = (void (__fastcall *)(Camera *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                         "UnityEngine.Camera::get_projectionMatrix_Injected(UnityEngine.Matrix4x4&)");
		    if ( !v108 )
		    {
		      v151 = sub_1802EE1B8("UnityEngine.Camera::get_projectionMatrix_Injected(UnityEngine.Matrix4x4&)");
		      sub_18007E1B0(v151, 0LL);
		    }
		    qword_18F36F228 = (__int64)v108;
		  }
		  v108(v106, &v153);
		  COERCE_FLOAT(v109 = _mm_load_si128((const __m128i *)&xmmword_18B9592D0).m128i_i32[0]);
		  v110 = LODWORD(v153.m32) & v109;
		  LODWORD(v111) = COERCE_UNSIGNED_INT(-1.0 - v153.m32) & v109;
		  if ( COERCE_FLOAT(LODWORD(v153.m32) & v109) <= COERCE_FLOAT(v109 & 0xBF800000) )
		    v110 = v109 & 0xBF800000;
		  v112 = *(float *)&v110 * 0.000001;
		  static_fields = (char *)TypeInfo::UnityEngine::Mathf->static_fields;
		  if ( v112 <= (float)(*(float *)static_fields * 8.0) )
		    v112 = *(float *)static_fields * 8.0;
		  v113 = hgCamera->fields.camera;
		  if ( !v113 )
		    goto LABEL_140;
		  v114 = (void (__fastcall *)(Camera *, _OWORD *))qword_18F36F228;
		  memset(v157, 0, sizeof(v157));
		  if ( !qword_18F36F228 )
		  {
		    v114 = (void (__fastcall *)(Camera *, _OWORD *))il2cpp_resolve_icall_1(
		                                                      "UnityEngine.Camera::get_projectionMatrix_Injected(UnityEngine.Matrix4x4&)");
		    if ( !v114 )
		    {
		      v152 = sub_1802EE1B8("UnityEngine.Camera::get_projectionMatrix_Injected(UnityEngine.Matrix4x4&)");
		      sub_18007E1B0(v152, 0LL);
		    }
		    qword_18F36F228 = (__int64)v114;
		  }
		  v114(v113, v157);
		  v115 = v157[0] & v109;
		  if ( COERCE_FLOAT(v157[0] & v109) <= COERCE_FLOAT(v109 & 0x3F800000) )
		    v115 = v109 & 0x3F800000;
		  v116 = *(float *)&v115 * 0.000001;
		  static_fields = (char *)TypeInfo::UnityEngine::Mathf->static_fields;
		  if ( v116 <= (float)(*(float *)static_fields * 8.0) )
		    v116 = *(float *)static_fields * 8.0;
		  v117 = 0;
		  if ( v116 > COERCE_FLOAT(COERCE_UNSIGNED_INT(1.0 - *(float *)v157) & v109) )
		  {
		    v88 = (unsigned __int64)hgCamera->fields.camera;
		    LOBYTE(v117) = v107 > 0.0;
		    if ( v88 )
		    {
		      projectionMatrix = UnityEngine::Camera::get_projectionMatrix(&v153, (Camera *)v88, 0LL);
		      v120 = _mm_shuffle_ps(*(__m128 *)&projectionMatrix->m01, *(__m128 *)&projectionMatrix->m01, 85).m128_f32[0];
		      v121 = 1.0 - v120;
		      v122 = LODWORD(v120) & v109;
		      v123 = LODWORD(v121) & v109;
		      if ( *(float *)&v122 <= COERCE_FLOAT(v109 & 0x3F800000) )
		        v122 = v109 & 0x3F800000;
		      v124 = *(float *)&v122 * 0.000001;
		      if ( v124 <= (float)(TypeInfo::UnityEngine::Mathf->static_fields->Epsilon * 8.0) )
		        v124 = TypeInfo::UnityEngine::Mathf->static_fields->Epsilon * 8.0;
		      v118 = 0;
		      LOBYTE(v118) = v124 > *(float *)&v123;
		      goto LABEL_135;
		    }
		LABEL_140:
		    sub_1800D8250(static_fields, v88);
		  }
		  LOBYTE(v117) = v107 > 0.0;
		  v118 = 0;
		LABEL_135:
		  if ( v112 <= v111 )
		    v118 = 0;
		  v125 = (v118 & v117) == 0;
		  v126 = v163;
		  if ( !v125 )
		    v126 = 1;
		  LOBYTE(v163) = v126;
		  v127 = *(_OWORD *)&v158.m256i_u64[2];
		  *(_OWORD *)&retstr->customRenderingSettings = *(_OWORD *)v158.m256i_i8;
		  v128 = v159;
		  *(_OWORD *)&retstr->renderingPathCustomFrameSettings.bitDatas.data2 = v127;
		  v129 = *(_OWORD *)v160;
		  retstr->renderingPathCustomFrameSettingsOverrideMask = v128;
		  v130 = *(_OWORD *)&v160[16];
		  *(_OWORD *)&retstr->bufferClearing.clearColorMode = v129;
		  v131 = *(_OWORD *)&v160[32];
		  *(_OWORD *)&retstr->bufferClearing.backgroundColorHDR.a = v130;
		  v132 = *(_OWORD *)v161;
		  *(_OWORD *)&retstr->volumes.anchorOverride = v131;
		  v133 = *(_OWORD *)&v161[16];
		  *(_OWORD *)&retstr->frustum.farClipPlaneRaw = v132;
		  v134 = *(_OWORD *)&v161[32];
		  *(_OWORD *)&retstr->frustum.projectionMatrix.m10 = v133;
		  v135 = *(_OWORD *)&v161[48];
		  *(_OWORD *)&retstr->frustum.projectionMatrix.m11 = v134;
		  v136 = *(_OWORD *)&v161[64];
		  *(_OWORD *)&retstr->frustum.projectionMatrix.m12 = v135;
		  v137 = v162;
		  *(_OWORD *)&retstr->frustum.projectionMatrix.m13 = v136;
		  v138 = v163;
		  retstr->culling = v137;
		  v139 = v164;
		  result = retstr;
		  *(_OWORD *)&retstr->invertFaceCulling = v138;
		  *(_OWORD *)&retstr->probeRangeCompressionFactor = v139;
		  return result;
		}
		
		internal Hash128 GetHash() => default; // 0x0000000189C1CBE0-0x0000000189C1CE30
		// Hash128 GetHash()
		Hash128 *HG::Rendering::Runtime::CameraSettings::GetHash(
		        Hash128 *__return_ptr retstr,
		        CameraSettings *this,
		        MethodInfo *method)
		{
		  CameraSettings_Volumes volumes; // xmm0
		  int32_t HashCode; // eax
		  Hash128 v7; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  Hash128 *result; // rax
		  Hash128 inHash; // [rsp+20h] [rbp-40h] BYREF
		  Hash128 hash; // [rsp+30h] [rbp-30h] BYREF
		  ValueType v14; // [rsp+40h] [rbp-20h] BYREF
		  CameraSettings_Volumes v15; // [rsp+50h] [rbp-10h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4073, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4073, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    v7 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1442(&hash, Patch, this, 0LL);
		  }
		  else
		  {
		    hash = 0LL;
		    inHash = 0LL;
		    UnityEngine::HashUtilities::ComputeHash128<HG::Rendering::Runtime::CameraSettings::BufferClearing>(
		      &this->bufferClearing,
		      &hash,
		      MethodInfo::UnityEngine::HashUtilities::ComputeHash128<HG::Rendering::Runtime::CameraSettings::BufferClearing>);
		    UnityEngine::HashUtilities::ComputeHash128<HG::Rendering::Runtime::CameraSettings::Culling>(
		      &this->culling,
		      &inHash,
		      MethodInfo::UnityEngine::HashUtilities::ComputeHash128<HG::Rendering::Runtime::CameraSettings::Culling>);
		    UnityEngine::HashUtilities::AppendHash(&inHash, &hash, 0LL);
		    UnityEngine::HashUtilities::ComputeHash128<bool>(
		      &this->customRenderingSettings,
		      &inHash,
		      MethodInfo::UnityEngine::HashUtilities::ComputeHash128<bool>);
		    UnityEngine::HashUtilities::AppendHash(&inHash, &hash, 0LL);
		    UnityEngine::HashUtilities::ComputeHash128<float>(
		      (float *)&this->defaultFrameSettings,
		      &inHash,
		      MethodInfo::UnityEngine::HashUtilities::ComputeHash128<HG::Rendering::Runtime::FrameSettingsRenderType>);
		    UnityEngine::HashUtilities::AppendHash(&inHash, &hash, 0LL);
		    UnityEngine::HashUtilities::ComputeHash128<float>(
		      (float *)&this->flipYMode,
		      &inHash,
		      MethodInfo::UnityEngine::HashUtilities::ComputeHash128<HG::Rendering::Runtime::HGAdditionalCameraData::FlipYMode>);
		    UnityEngine::HashUtilities::AppendHash(&inHash, &hash, 0LL);
		    UnityEngine::HashUtilities::ComputeHash128<HG::Rendering::Runtime::CameraSettings::Frustum>(
		      &this->frustum,
		      &inHash,
		      MethodInfo::UnityEngine::HashUtilities::ComputeHash128<HG::Rendering::Runtime::CameraSettings::Frustum>);
		    UnityEngine::HashUtilities::AppendHash(&inHash, &hash, 0LL);
		    UnityEngine::HashUtilities::ComputeHash128<bool>(
		      &this->invertFaceCulling,
		      &inHash,
		      MethodInfo::UnityEngine::HashUtilities::ComputeHash128<bool>);
		    UnityEngine::HashUtilities::AppendHash(&inHash, &hash, 0LL);
		    UnityEngine::HashUtilities::ComputeHash128<float>(
		      (float *)&this->probeLayerMask.m_Mask,
		      &inHash,
		      MethodInfo::UnityEngine::HashUtilities::ComputeHash128<UnityEngine::LayerMask>);
		    UnityEngine::HashUtilities::AppendHash(&inHash, &hash, 0LL);
		    UnityEngine::HashUtilities::ComputeHash128<float>(
		      &this->probeRangeCompressionFactor,
		      &inHash,
		      MethodInfo::UnityEngine::HashUtilities::ComputeHash128<float>);
		    UnityEngine::HashUtilities::AppendHash(&inHash, &hash, 0LL);
		    UnityEngine::HashUtilities::ComputeHash128<HG::Rendering::Runtime::CameraSettings::BufferClearing>(
		      (CameraSettings_BufferClearing *)&this->renderingPathCustomFrameSettings,
		      &inHash,
		      MethodInfo::UnityEngine::HashUtilities::ComputeHash128<HG::Rendering::Runtime::FrameSettings>);
		    UnityEngine::HashUtilities::AppendHash(&inHash, &hash, 0LL);
		    UnityEngine::HashUtilities::ComputeHash128<HG::Rendering::Runtime::CameraSettings::Culling>(
		      (CameraSettings_Culling *)&this->renderingPathCustomFrameSettingsOverrideMask,
		      &inHash,
		      MethodInfo::UnityEngine::HashUtilities::ComputeHash128<HG::Rendering::Runtime::FrameSettingsOverrideMask>);
		    UnityEngine::HashUtilities::AppendHash(&inHash, &hash, 0LL);
		    volumes = this->volumes;
		    v14.monitor = (MonitorData *)-1LL;
		    v15 = volumes;
		    v14.klass = (ValueType__Class *)TypeInfo::HG::Rendering::Runtime::CameraSettings::Volumes;
		    HashCode = System::ValueType::GetHashCode(&v14, 0LL);
		    inHash.u64_1 = 0LL;
		    inHash.u64_0 = HashCode;
		    UnityEngine::HashUtilities::AppendHash(&inHash, &hash, 0LL);
		    v7 = hash;
		  }
		  result = retstr;
		  *retstr = v7;
		  return result;
		}
		
	}
}
