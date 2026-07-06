using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[AddComponentMenu("")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(Light))]
	[ExecuteAlways]
	public class HGAdditionalLightData : MonoBehaviour, ISerializationCallbackReceiver, IAdditionalData
	{
		// (get) Token: 0x06000833 RID: 2099 RVA: 0x000028A8 File Offset: 0x00000AA8
		// (set) Token: 0x06000834 RID: 2100 RVA: 0x000025D0 File Offset: 0x000007D0
		public HGLightNPRType LightNPRType
		{
			get
			{
				// // Int32 get_count()
				// int32_t Beyond::SparkBuffer::Runtime::Map::get_count(Map *this, MethodInfo *method)
				// {
				//   return this.m_count;
				// }
				// 
				return (HGLightNPRType)HGLightNPRType.Default;
			}
			set
			{
				// // Void set_LightNPRType(HGLightNPRType)
				// void HG::Rendering::Runtime::HGAdditionalLightData::set_LightNPRType(
				//         HGAdditionalLightData *this,
				//         HGLightNPRType__Enum value,
				//         MethodInfo *method)
				// {
				//   this.fields.m_lightNPRType = value;
				//   HG::Rendering::Runtime::HGAdditionalLightData::SetDataDirty(this, 0LL);
				// }
				// 
			}
		}

		// (get) Token: 0x06000835 RID: 2101 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x06000836 RID: 2102 RVA: 0x000025D0 File Offset: 0x000007D0
		public float LightNPRRimWidth
		{
			get
			{
				// // Single get_voxelSize()
				// float UnityEngine::AI::NavMeshSurface::get_voxelSize(NavMeshSurface *this, MethodInfo *method)
				// {
				//   return this.fields.m_VoxelSize;
				// }
				// 
				return 0f;
			}
			set
			{
				// // Void set_LightNPRRimWidth(Single)
				// void HG::Rendering::Runtime::HGAdditionalLightData::set_LightNPRRimWidth(
				//         HGAdditionalLightData *this,
				//         float value,
				//         MethodInfo *method)
				// {
				//   this.fields.m_lightNPRRimWidth = value;
				//   HG::Rendering::Runtime::HGAdditionalLightData::SetDataDirty(this, 0LL);
				// }
				// 
			}
		}

		// (get) Token: 0x06000837 RID: 2103 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x06000838 RID: 2104 RVA: 0x000025D0 File Offset: 0x000007D0
		public float LightNPRRimAlbedoAlpha
		{
			get
			{
				// // Single get_verticalScrollbarSpacing()
				// float UnityEngine::UI::ScrollRect::get_verticalScrollbarSpacing(ScrollRect *this, MethodInfo *method)
				// {
				//   return this.fields.m_VerticalScrollbarSpacing;
				// }
				// 
				return 0f;
			}
			set
			{
				// // Void set_LightNPRRimAlbedoAlpha(Single)
				// void HG::Rendering::Runtime::HGAdditionalLightData::set_LightNPRRimAlbedoAlpha(
				//         HGAdditionalLightData *this,
				//         float value,
				//         MethodInfo *method)
				// {
				//   this.fields.m_lightNPRRimAlbedoAlpha = value;
				//   HG::Rendering::Runtime::HGAdditionalLightData::SetDataDirty(this, 0LL);
				// }
				// 
			}
		}

		// (get) Token: 0x06000839 RID: 2105 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x0600083A RID: 2106 RVA: 0x000025D0 File Offset: 0x000007D0
		public float LightNPRFogAlpha
		{
			get
			{
				// // Single get_Opacity()
				// float PaintIn3D::P3dPaintFill::get_Opacity(P3dPaintFill *this, MethodInfo *method)
				// {
				//   return this.fields.opacity;
				// }
				// 
				return 0f;
			}
			set
			{
				// // Void set_LightNPRFogAlpha(Single)
				// void HG::Rendering::Runtime::HGAdditionalLightData::set_LightNPRFogAlpha(
				//         HGAdditionalLightData *this,
				//         float value,
				//         MethodInfo *method)
				// {
				//   this.fields.m_lightNPRFogAlpha = value;
				//   HG::Rendering::Runtime::HGAdditionalLightData::SetDataDirty(this, 0LL);
				// }
				// 
			}
		}

		// (get) Token: 0x0600083B RID: 2107 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x0600083C RID: 2108 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool LightCharacterOnly
		{
			get
			{
				// // Boolean get_PackGeometryBeforeMerging()
				// bool HoudiniEngineUnity::HEU_InputNode::get_PackGeometryBeforeMerging(HEU_InputNode *this, MethodInfo *method)
				// {
				//   return this.fields._packGeometryBeforeMerging;
				// }
				// 
				return default(bool);
			}
			set
			{
				// // Void set_LightCharacterOnly(Boolean)
				// void HG::Rendering::Runtime::HGAdditionalLightData::set_LightCharacterOnly(
				//         HGAdditionalLightData *this,
				//         bool value,
				//         MethodInfo *method)
				// {
				//   this.fields.m_LightCharacterOnly = value;
				//   HG::Rendering::Runtime::HGAdditionalLightData::SetDataDirty(this, 0LL);
				// }
				// 
			}
		}

		// (get) Token: 0x0600083D RID: 2109 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x0600083E RID: 2110 RVA: 0x000025D0 File Offset: 0x000007D0
		public float VolumetricScatteringIntensity
		{
			get
			{
				// // Single get_previousValue()
				// float UnityEngine::UIElements::ChangeEvent<float>::get_previousValue(
				//         ChangeEvent_1_System_Single_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._previousValue_k__BackingField;
				// }
				// 
				return 0f;
			}
			set
			{
				// // Void set_VolumetricScatteringIntensity(Single)
				// void HG::Rendering::Runtime::HGAdditionalLightData::set_VolumetricScatteringIntensity(
				//         HGAdditionalLightData *this,
				//         float value,
				//         MethodInfo *method)
				// {
				//   this.fields.m_volumetricScatteringIntensity = value;
				//   HG::Rendering::Runtime::HGAdditionalLightData::SetDataDirty(this, 0LL);
				// }
				// 
			}
		}

		// (get) Token: 0x0600083F RID: 2111 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x06000840 RID: 2112 RVA: 0x000025D0 File Offset: 0x000007D0
		public float FalloffExponent
		{
			get
			{
				// // Single get_newValue()
				// float UnityEngine::UIElements::ChangeEvent<float>::get_newValue(ChangeEvent_1_System_Single_ *this, MethodInfo *method)
				// {
				//   return this.fields._newValue_k__BackingField;
				// }
				// 
				return 0f;
			}
			set
			{
				// // Void set_FalloffExponent(Single)
				// void HG::Rendering::Runtime::HGAdditionalLightData::set_FalloffExponent(
				//         HGAdditionalLightData *this,
				//         float value,
				//         MethodInfo *method)
				// {
				//   this.fields.m_falloffExponent = value;
				//   HG::Rendering::Runtime::HGAdditionalLightData::SetDataDirty(this, 0LL);
				// }
				// 
			}
		}

		public HGAdditionalLightData()
		{
			// // HGAdditionalLightData()
			// void HG::Rendering::Runtime::HGAdditionalLightData::HGAdditionalLightData(
			//         HGAdditionalLightData *this,
			//         MethodInfo *method)
			// {
			//   ITilemap *v2; // r9
			//   TileAnimationData v3; // xmm1
			//   __int64 v4; // r8
			//   TileAnimationData v5; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   this.fields.sphericalLightRadius = 0.1;
			//   v3 = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
			//           &v5,
			//           (TileBase *)method,
			//           (Vector3Int *)this,
			//           v2,
			//           (MethodInfo *)v5.m_AnimatedSprites);
			//   *(_DWORD *)(v4 + 68) = 1065353216;
			//   *(_BYTE *)(v4 + 72) = 1;
			//   *(TileAnimationData *)(v4 + 44) = v3;
			//   *(_DWORD *)(v4 + 92) = 1058642330;
			//   *(_DWORD *)(v4 + 96) = 1061997773;
			//   *(_BYTE *)(v4 + 100) = 1;
			//   *(_DWORD *)(v4 + 104) = 1053609165;
			//   *(_DWORD *)(v4 + 108) = 1065353216;
			//   *(_DWORD *)(v4 + 112) = 1065353216;
			//   *(_DWORD *)(v4 + 116) = 1065353216;
			//   *(_DWORD *)(v4 + 128) = 1065353216;
			//   *(_DWORD *)(v4 + 132) = -1082130432;
			//   UnityEngine::Component::Component((Component *)v4, 0LL);
			// }
			// 
		}

		public void OnBeforeSerialize()
		{
			// // Void OnBeforeSerialize()
			// void HG::Rendering::Runtime::HGAdditionalLightData::OnBeforeSerialize(HGAdditionalLightData *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1547, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1547, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			// }
			// 
		}

		public void OnAfterDeserialize()
		{
			// // Void OnAfterDeserialize()
			// void HG::Rendering::Runtime::HGAdditionalLightData::OnAfterDeserialize(HGAdditionalLightData *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1548, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1548, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			// }
			// 
		}

		public Vector4 GetLightNPRData()
		{
			// // Vector4 GetLightNPRData()
			// Vector4 *HG::Rendering::Runtime::HGAdditionalLightData::GetLightNPRData(
			//         Vector4 *__return_ptr retstr,
			//         HGAdditionalLightData *this,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   int32_t m_lightNPRType; // ecx
			//   float m_lightNPRRimAlbedoAlpha; // xmm0_4
			//   float m_lightNPRDefaultContrast; // eax
			//   Vector4 m_lightNPRData; // xmm0
			//   Vector4 *result; // rax
			//   float m_lightNPRRampSDFBias; // xmm1_4
			//   float m_lightNPRRampSDFDramatic; // xmm2_4
			//   float m_lightNPRRampBias; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   float v16; // xmm2_4
			//   float m_lightNPRFogRampBias; // xmm1_4
			//   float m_lightNPRFogAlpha; // eax
			//   float v19; // xmm1_4
			//   float m_lightNPRSpecRoughnessBias; // xmm0_4
			//   Vector4 v21; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, this);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v5.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_23;
			//   if ( wrapperArray.max_length.size <= 970 )
			//     goto LABEL_7;
			//   if ( !v5._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v5, wrapperArray);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5.static_fields.wrapperArray;
			//   if ( !v5 )
			// LABEL_23:
			//     sub_180B536AC(v5, wrapperArray);
			//   if ( LODWORD(v5._0.namespaze) <= 0x3CA )
			//     sub_180070270(v5, wrapperArray);
			//   if ( *(_QWORD *)&v5[20]._1.thread_static_fields_offset )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(970, 0LL);
			//     if ( Patch )
			//     {
			//       m_lightNPRData = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_312(&v21, Patch, (Object *)this, 0LL);
			//       goto LABEL_14;
			//     }
			//     goto LABEL_23;
			//   }
			// LABEL_7:
			//   m_lightNPRType = this.fields.m_lightNPRType;
			//   switch ( m_lightNPRType )
			//   {
			//     case 0:
			//       if ( this.fields.m_lightNPRDefaultAutoLimit )
			//         m_lightNPRRimAlbedoAlpha = 1.0;
			//       else
			//         m_lightNPRRimAlbedoAlpha = 0.0;
			//       m_lightNPRDefaultContrast = this.fields.m_lightNPRDefaultContrast;
			//       goto LABEL_11;
			//     case 1:
			//       m_lightNPRRampSDFBias = this.fields.m_lightNPRRampSDFBias;
			//       m_lightNPRRampSDFDramatic = this.fields.m_lightNPRRampSDFDramatic;
			//       m_lightNPRRampBias = this.fields.m_lightNPRRampBias;
			//       this.fields.m_lightNPRData.y = this.fields.m_lightNPRRampShadowDimmer;
			//       this.fields.m_lightNPRData.z = m_lightNPRRampSDFBias;
			//       this.fields.m_lightNPRData.w = m_lightNPRRampSDFDramatic;
			//       this.fields.m_lightNPRData.x = m_lightNPRRampBias;
			//       break;
			//     case 2:
			//       if ( this.fields.m_lightNPRSpecMetalOnly )
			//         v19 = 1.0;
			//       else
			//         v19 = 0.0;
			//       m_lightNPRSpecRoughnessBias = this.fields.m_lightNPRSpecRoughnessBias;
			//       this.fields.m_lightNPRData.x = this.fields.m_lightNPRSpecMaxRoughness;
			//       this.fields.m_lightNPRData.w = 0.0;
			//       this.fields.m_lightNPRData.y = m_lightNPRSpecRoughnessBias;
			//       this.fields.m_lightNPRData.z = v19;
			//       break;
			//     case 3:
			//       m_lightNPRRimAlbedoAlpha = this.fields.m_lightNPRRimAlbedoAlpha;
			//       m_lightNPRDefaultContrast = this.fields.m_lightNPRRimWidth;
			// LABEL_11:
			//       this.fields.m_lightNPRData.x = m_lightNPRDefaultContrast;
			//       this.fields.m_lightNPRData.y = m_lightNPRRimAlbedoAlpha;
			// LABEL_12:
			//       *(_QWORD *)&this.fields.m_lightNPRData.z = 0LL;
			//       break;
			//     case 4:
			//       if ( this.fields.m_lightNPRFogDirectionalFalloff )
			//         v16 = 1.0;
			//       else
			//         v16 = 0.0;
			//       m_lightNPRFogRampBias = this.fields.m_lightNPRFogRampBias;
			//       m_lightNPRFogAlpha = this.fields.m_lightNPRFogAlpha;
			//       this.fields.m_lightNPRData.y = this.fields.m_lightNPRFogFalloffFactor;
			//       this.fields.m_lightNPRData.w = m_lightNPRFogRampBias;
			//       this.fields.m_lightNPRData.z = v16;
			//       this.fields.m_lightNPRData.x = m_lightNPRFogAlpha;
			//       break;
			//     case 16:
			//       *(_QWORD *)&this.fields.m_lightNPRData.x = 0LL;
			//       goto LABEL_12;
			//   }
			//   m_lightNPRData = this.fields.m_lightNPRData;
			// LABEL_14:
			//   result = retstr;
			//   *retstr = m_lightNPRData;
			//   return result;
			// }
			// 
			return null;
		}

		public HGLightAdditionalData GetlightAdditionalData()
		{
			// // HGLightAdditionalData GetlightAdditionalData()
			// HGLightAdditionalData *HG::Rendering::Runtime::HGAdditionalLightData::GetlightAdditionalData(
			//         HGLightAdditionalData *__return_ptr retstr,
			//         HGAdditionalLightData *this,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   Vector4 *LightNPRData; // rax
			//   float m_falloffExponent; // xmm0_4
			//   float m_volumetricScatteringIntensity; // xmm2_4
			//   Vector4 v10; // xmm1
			//   __m128 v11; // xmm3
			//   __m128 v12; // xmm3
			//   __m128 v13; // xmm3
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   HGLightAdditionalData *v16; // rax
			//   __int128 v17; // xmm1
			//   Vector4 v18; // [rsp+20h] [rbp-38h] BYREF
			//   HGLightAdditionalData v19; // [rsp+30h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, this);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v5.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_9;
			//   if ( wrapperArray.max_length.size > 969 )
			//   {
			//     if ( !v5._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v5, wrapperArray);
			//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5.static_fields.wrapperArray;
			//     if ( v5 )
			//     {
			//       if ( LODWORD(v5._0.namespaze) <= 0x3C9 )
			//         sub_180070270(v5, wrapperArray);
			//       if ( !*(_QWORD *)&v5[20]._1.static_fields_size )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(969, 0LL);
			//       if ( Patch )
			//       {
			//         v16 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_358(&v19, Patch, (Object *)this, 0LL);
			//         v17 = *(_OWORD *)&v16.lightNPRType;
			//         retstr.lightNPRData = v16.lightNPRData;
			//         *(_OWORD *)&retstr.lightNPRType = v17;
			//         return retstr;
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(v5, wrapperArray);
			//   }
			// LABEL_7:
			//   *(_OWORD *)&v19.lightNPRType = 0LL;
			//   LightNPRData = HG::Rendering::Runtime::HGAdditionalLightData::GetLightNPRData(&v18, this, 0LL);
			//   m_falloffExponent = this.fields.m_falloffExponent;
			//   m_volumetricScatteringIntensity = this.fields.m_volumetricScatteringIntensity;
			//   v10 = *LightNPRData;
			//   v19.lightNPRType = this.fields.m_lightNPRType;
			//   v19.LightCharacterOnly = this.fields.m_LightCharacterOnly;
			//   v11 = *(__m128 *)&v19.lightNPRType;
			//   retstr.lightNPRData = v10;
			//   v12 = _mm_shuffle_ps(v11, v11, 147);
			//   v12.m128_f32[0] = m_falloffExponent;
			//   v13 = _mm_shuffle_ps(v12, v12, 39);
			//   v13.m128_f32[0] = m_volumetricScatteringIntensity;
			//   *(__m128 *)&retstr.lightNPRType = _mm_shuffle_ps(v13, v13, 201);
			//   return retstr;
			// }
			// 
			return null;
		}

		public void UpdateLightAdditionalData()
		{
			// // Void UpdateLightAdditionalData()
			// void HG::Rendering::Runtime::HGAdditionalLightData::UpdateLightAdditionalData(
			//         HGAdditionalLightData *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   Object_1 *m_light; // rdi
			//   Light *v5; // rdi
			//   HGLightAdditionalData *v6; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 lightNPRData; // xmm0
			//   __int128 v10; // xmm1
			//   void (__fastcall *v11)(Light *, _OWORD *); // rax
			//   __int64 v12; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v14; // rdx
			//   __int64 v15; // rcx
			//   _OWORD v16[2]; // [rsp+20h] [rbp-48h] BYREF
			//   HGLightAdditionalData v17; // [rsp+40h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D8EDCD7 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDCD7 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1549, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1549, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v15, v14);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     m_light = (Object_1 *)this.fields.m_light;
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v3);
			//     if ( UnityEngine::Object::op_Inequality(m_light, 0LL, 0LL) )
			//     {
			//       v5 = this.fields.m_light;
			//       v6 = HG::Rendering::Runtime::HGAdditionalLightData::GetlightAdditionalData(&v17, this, 0LL);
			//       if ( !v5 )
			//         sub_180B536AC(v8, v7);
			//       lightNPRData = v6.lightNPRData;
			//       v10 = *(_OWORD *)&v6.lightNPRType;
			//       v11 = (void (__fastcall *)(Light *, _OWORD *))qword_18D8F47F8;
			//       v16[0] = lightNPRData;
			//       v16[1] = v10;
			//       if ( !qword_18D8F47F8 )
			//       {
			//         v11 = (void (__fastcall *)(Light *, _OWORD *))il2cpp_resolve_icall_0(
			//                                                         "UnityEngine.Light::set_lightAdditionalData_Injected(UnityEngine."
			//                                                         "HGLightAdditionalData&)");
			//         if ( !v11 )
			//         {
			//           v12 = sub_1802DBBE8("UnityEngine.Light::set_lightAdditionalData_Injected(UnityEngine.HGLightAdditionalData&)");
			//           sub_18000F750(v12, 0LL);
			//         }
			//         qword_18D8F47F8 = (__int64)v11;
			//       }
			//       v11(v5, v16);
			//     }
			//   }
			// }
			// 
		}

		private void Awake()
		{
			// // Void Awake()
			// void HG::Rendering::Runtime::HGAdditionalLightData::Awake(HGAdditionalLightData *this, MethodInfo *method)
			// {
			//   OneofDescriptorProto *v3; // rdx
			//   FileDescriptor *v4; // r8
			//   MessageDescriptor *v5; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   String__Array *v9; // [rsp+50h] [rbp+28h]
			//   String *v10; // [rsp+58h] [rbp+30h]
			//   MethodInfo *v11; // [rsp+60h] [rbp+38h]
			// 
			//   if ( !byte_18D8EDCD8 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Component::GetComponent<UnityEngine::Light>);
			//     byte_18D8EDCD8 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1550, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1550, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     this.fields.m_light = (Light *)UnityEngine::Component::GetComponent<System::Object>(
			//                                       (Component *)this,
			//                                       MethodInfo::UnityEngine::Component::GetComponent<UnityEngine::Light>);
			//     sub_1800054D0((OneofDescriptor *)&this.fields.m_light, v3, v4, v5, v9, v10, v11);
			//   }
			// }
			// 
		}

		private void OnEnable()
		{
			// // Void OnEnable()
			// void HG::Rendering::Runtime::HGAdditionalLightData::OnEnable(HGAdditionalLightData *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1551, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1551, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::HGAdditionalLightData::UpdateLightAdditionalData(this, 0LL);
			//   }
			// }
			// 
		}

		private void SetDataDirty()
		{
			// // Void SetDataDirty()
			// void HG::Rendering::Runtime::HGAdditionalLightData::SetDataDirty(HGAdditionalLightData *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1552, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1552, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::HGAdditionalLightData::UpdateLightAdditionalData(this, 0LL);
			//   }
			// }
			// 
		}

		public void InitFromStreamingData(ref HGAdditionalLightData.HGAdditionalLightStreamingData streamingData)
		{
			// // Void InitFromStreamingData(HGAdditionalLightData+HGAdditionalLightStreamingData ByRef)
			// void HG::Rendering::Runtime::HGAdditionalLightData::InitFromStreamingData(
			//         HGAdditionalLightData *this,
			//         HGAdditionalLightData_HGAdditionalLightStreamingData *streamingData,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1553, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1553, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_595(Patch, (Object *)this, streamingData, 0LL);
			//   }
			//   else
			//   {
			//     this.fields.m_lightNPRData = streamingData.lightNPRData;
			//     this.fields.m_lightNPRType = streamingData.lightNPRType;
			//     this.fields.m_lightNPRAdvancedParamMode = streamingData.lightNPRAdvancedParamMode;
			//     this.fields.m_lightNPRDefaultContrast = streamingData.lightNPRDefaultContrast;
			//     this.fields.m_lightNPRDefaultAutoLimit = streamingData.lightNPRDefaultAutoLimit;
			//     this.fields.m_lightNPRRampBias = streamingData.lightNPRRampBias;
			//     this.fields.m_lightNPRRampShadowDimmer = streamingData.lightNPRRampShadowDimmer;
			//     this.fields.m_lightNPRRampSDFBias = streamingData.lightNPRRampSDFBias;
			//     this.fields.m_lightNPRRampSDFDramatic = streamingData.lightNPRRampSDFDramatic;
			//     this.fields.m_lightNPRSpecMaxRoughness = streamingData.lightNPRSpecMaxRoughness;
			//     this.fields.m_lightNPRSpecRoughnessBias = streamingData.lightNPRSpecRoughnessBias;
			//     this.fields.m_lightNPRSpecMetalOnly = streamingData.lightNPRSpecMetalOnly;
			//     this.fields.m_lightNPRRimWidth = streamingData.lightNPRRimWidth;
			//     this.fields.m_lightNPRRimAlbedoAlpha = streamingData.lightNPRRimAlbedoAlpha;
			//     this.fields.m_lightNPRFogAlpha = streamingData.lightNPRFogAlpha;
			//     this.fields.m_lightNPRFogFalloffFactor = streamingData.lightNPRFogFalloffFactor;
			//     this.fields.m_lightNPRFogRampBias = streamingData.lightNPRFogRampBias;
			//     this.fields.m_lightNPRFogDirectionalFalloff = streamingData.lightNPRFogDirectionalFalloff;
			//     this.fields.m_LightCharacterOnly = streamingData.LightCharacterOnly;
			//     this.fields.m_volumetricScatteringIntensity = streamingData.volumetricScatteringIntensity;
			//     this.fields.m_falloffExponent = streamingData.falloffExponent;
			//     HG::Rendering::Runtime::HGAdditionalLightData::UpdateLightAdditionalData(this, 0LL);
			//   }
			// }
			// 
		}

		public HGAdditionalLightData.HGAdditionalLightStreamingData GetLightStreamingData()
		{
			// // HGAdditionalLightData+HGAdditionalLightStreamingData GetLightStreamingData()
			// HGAdditionalLightData_HGAdditionalLightStreamingData *HG::Rendering::Runtime::HGAdditionalLightData::GetLightStreamingData(
			//         HGAdditionalLightData_HGAdditionalLightStreamingData *__return_ptr retstr,
			//         HGAdditionalLightData *this,
			//         MethodInfo *method)
			// {
			//   float m_lightNPRDefaultContrast; // xmm0_4
			//   float m_lightNPRSpecRoughnessBias; // xmm1_4
			//   Vector4 v7; // xmm3
			//   bool m_lightNPRAdvancedParamMode; // al
			//   float m_falloffExponent; // xmm2_4
			//   __int128 v10; // xmm0
			//   bool m_lightNPRDefaultAutoLimit; // al
			//   __int128 v12; // xmm0
			//   bool m_lightNPRSpecMetalOnly; // al
			//   bool m_lightNPRFogDirectionalFalloff; // al
			//   bool m_LightCharacterOnly; // al
			//   __int128 v16; // xmm0
			//   __int128 v17; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v19; // rdx
			//   __int64 v20; // rcx
			//   HGAdditionalLightData_HGAdditionalLightStreamingData *v21; // rax
			//   __int128 v22; // xmm1
			//   __int128 v23; // xmm0
			//   __int128 v24; // xmm1
			//   __int128 v25; // xmm0
			//   HGAdditionalLightData_HGAdditionalLightStreamingData v27; // [rsp+20h] [rbp-60h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1554, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1554, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v20, v19);
			//     v21 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_596(&v27, Patch, (Object *)this, 0LL);
			//     v22 = *(_OWORD *)&v21.lightNPRType;
			//     retstr.lightNPRData = v21.lightNPRData;
			//     v23 = *(_OWORD *)&v21.lightNPRRampBias;
			//     *(_OWORD *)&retstr.lightNPRType = v22;
			//     v24 = *(_OWORD *)&v21.lightNPRSpecMaxRoughness;
			//     *(_OWORD *)&retstr.lightNPRRampBias = v23;
			//     v25 = *(_OWORD *)&v21.lightNPRRimAlbedoAlpha;
			//     *(_OWORD *)&retstr.lightNPRSpecMaxRoughness = v24;
			//     *(_QWORD *)&v24 = *(_QWORD *)&v21.lightNPRFogDirectionalFalloff;
			//     *(float *)&v21 = v21.falloffExponent;
			//     *(_OWORD *)&retstr.lightNPRRimAlbedoAlpha = v25;
			//     *(_QWORD *)&retstr.lightNPRFogDirectionalFalloff = v24;
			//     LODWORD(retstr.falloffExponent) = (_DWORD)v21;
			//   }
			//   else
			//   {
			//     sub_1802F01E0(&v27, 0LL, 92LL);
			//     m_lightNPRDefaultContrast = this.fields.m_lightNPRDefaultContrast;
			//     m_lightNPRSpecRoughnessBias = this.fields.m_lightNPRSpecRoughnessBias;
			//     v7 = (Vector4)_mm_loadu_si128((const __m128i *)&this.fields.m_lightNPRData);
			//     v27.lightNPRType = this.fields.m_lightNPRType;
			//     m_lightNPRAdvancedParamMode = this.fields.m_lightNPRAdvancedParamMode;
			//     m_falloffExponent = this.fields.m_falloffExponent;
			//     v27.lightNPRDefaultContrast = m_lightNPRDefaultContrast;
			//     v10 = *(_OWORD *)&this.fields.m_lightNPRRampBias;
			//     v27.lightNPRAdvancedParamMode = m_lightNPRAdvancedParamMode;
			//     m_lightNPRDefaultAutoLimit = this.fields.m_lightNPRDefaultAutoLimit;
			//     *(_OWORD *)&v27.lightNPRRampBias = v10;
			//     v27.lightNPRSpecMaxRoughness = this.fields.m_lightNPRSpecMaxRoughness;
			//     v12 = *(_OWORD *)&this.fields.m_lightNPRRimWidth;
			//     v27.lightNPRDefaultAutoLimit = m_lightNPRDefaultAutoLimit;
			//     m_lightNPRSpecMetalOnly = this.fields.m_lightNPRSpecMetalOnly;
			//     *(_OWORD *)&v27.lightNPRRimWidth = v12;
			//     v27.lightNPRSpecMetalOnly = m_lightNPRSpecMetalOnly;
			//     *(float *)&v12 = this.fields.m_lightNPRFogRampBias;
			//     m_lightNPRFogDirectionalFalloff = this.fields.m_lightNPRFogDirectionalFalloff;
			//     retstr.lightNPRData = v7;
			//     v27.lightNPRFogDirectionalFalloff = m_lightNPRFogDirectionalFalloff;
			//     m_LightCharacterOnly = this.fields.m_LightCharacterOnly;
			//     LODWORD(v27.lightNPRFogRampBias) = v12;
			//     v27.volumetricScatteringIntensity = this.fields.m_volumetricScatteringIntensity;
			//     *(_OWORD *)&retstr.lightNPRType = *(_OWORD *)&v27.lightNPRType;
			//     v27.LightCharacterOnly = m_LightCharacterOnly;
			//     v27.lightNPRSpecRoughnessBias = m_lightNPRSpecRoughnessBias;
			//     v16 = *(_OWORD *)&v27.lightNPRSpecMaxRoughness;
			//     *(_OWORD *)&retstr.lightNPRRampBias = *(_OWORD *)&v27.lightNPRRampBias;
			//     v17 = *(_OWORD *)&v27.lightNPRRimAlbedoAlpha;
			//     *(_OWORD *)&retstr.lightNPRSpecMaxRoughness = v16;
			//     *(_QWORD *)&v16 = *(_QWORD *)&v27.lightNPRFogDirectionalFalloff;
			//     *(_OWORD *)&retstr.lightNPRRimAlbedoAlpha = v17;
			//     *(_QWORD *)&retstr.lightNPRFogDirectionalFalloff = v16;
			//     retstr.falloffExponent = m_falloffExponent;
			//   }
			//   return retstr;
			// }
			// 
			return default(HGAdditionalLightData.HGAdditionalLightStreamingData);
		}

		[HideInInspector]
		public bool enableLightMeshForReflectionProbe;

		[HideInInspector]
		public float sphericalLightRadius;

		[HideInInspector]
		public Texture2D areaLightCookie;

		[HideInInspector]
		public bool debugLightMesh;

		[SerializeField]
		[HideInInspector]
		private Vector4 m_lightNPRData;

		[HideInInspector]
		[SerializeField]
		private HGLightNPRType m_lightNPRType;

		[HideInInspector]
		[SerializeField]
		private bool m_lightNPRAdvancedParamMode;

		[HideInInspector]
		[SerializeField]
		[Range(0f, 2f)]
		private float m_lightNPRDefaultContrast;

		[HideInInspector]
		[SerializeField]
		private bool m_lightNPRDefaultAutoLimit;

		[HideInInspector]
		[SerializeField]
		[Range(-2f, 2f)]
		private float m_lightNPRRampBias;

		[SerializeField]
		[HideInInspector]
		[Range(0f, 1f)]
		private float m_lightNPRRampShadowDimmer;

		[HideInInspector]
		[Range(-1f, 1f)]
		[SerializeField]
		private float m_lightNPRRampSDFBias;

		[HideInInspector]
		[SerializeField]
		[Range(0f, 1f)]
		private float m_lightNPRRampSDFDramatic;

		[HideInInspector]
		[SerializeField]
		[Range(0f, 1f)]
		private float m_lightNPRSpecMaxRoughness;

		[SerializeField]
		[Range(0f, 1f)]
		[HideInInspector]
		private float m_lightNPRSpecRoughnessBias;

		[SerializeField]
		[HideInInspector]
		private bool m_lightNPRSpecMetalOnly;

		[SerializeField]
		[Range(0f, 1f)]
		[HideInInspector]
		private float m_lightNPRRimWidth;

		[HideInInspector]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_lightNPRRimAlbedoAlpha;

		[SerializeField]
		[HideInInspector]
		[Range(0f, 1f)]
		private float m_lightNPRFogAlpha;

		[Range(0f, 1f)]
		[HideInInspector]
		[SerializeField]
		private float m_lightNPRFogFalloffFactor;

		[Range(0f, 1f)]
		[HideInInspector]
		[SerializeField]
		private float m_lightNPRFogRampBias;

		[SerializeField]
		[HideInInspector]
		private bool m_lightNPRFogDirectionalFalloff;

		[HideInInspector]
		[SerializeField]
		private bool m_LightCharacterOnly;

		[SerializeField]
		[HideInInspector]
		private float m_volumetricScatteringIntensity;

		[SerializeField]
		[HideInInspector]
		private float m_falloffExponent;

		private Light m_light;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 96)]
		public struct HGAdditionalLightStreamingData
		{
			public Vector4 lightNPRData;

			public HGLightNPRType lightNPRType;

			public bool lightNPRAdvancedParamMode;

			public float lightNPRDefaultContrast;

			public bool lightNPRDefaultAutoLimit;

			public float lightNPRRampBias;

			public float lightNPRRampShadowDimmer;

			public float lightNPRRampSDFBias;

			public float lightNPRRampSDFDramatic;

			public float lightNPRSpecMaxRoughness;

			public float lightNPRSpecRoughnessBias;

			public bool lightNPRSpecMetalOnly;

			public float lightNPRRimWidth;

			public float lightNPRRimAlbedoAlpha;

			public float lightNPRFogAlpha;

			public float lightNPRFogFalloffFactor;

			public float lightNPRFogRampBias;

			public bool lightNPRFogDirectionalFalloff;

			public bool LightCharacterOnly;

			public float volumetricScatteringIntensity;

			public float falloffExponent;
		}
	}
}
