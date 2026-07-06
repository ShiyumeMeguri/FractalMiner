using System;
using System.Runtime.InteropServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public class VolumetricMSBake
	{
		// (get) Token: 0x06001AB4 RID: 6836 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06001AB5 RID: 6837 RVA: 0x000025D0 File Offset: 0x000007D0
		public RenderTexture MSTexture
		{
			get
			{
				// // Object System.Collections.IEnumerator.get_Current()
				// Object *Rewired::Platforms::Custom::HardwareJoystickMapCustomPlatformMap_1_TMatchingCriteria_::vFJqwhcHvHdpsRAHqwODiJDbwkcr<System::Object>::System_Collections_IEnumerator_get_Current(
				//         HardwareJoystickMapCustomPlatformMap_1_TMatchingCriteria_vFJqwhcHvHdpsRAHqwODiJDbwkcr_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return (Object *)this.fields.YcoKziTgrGqKCwJTNRuXadHqwkUP;
				// }
				// 
				return null;
			}
			private set
			{
				// // Void set_getValueDelegate(Func`1[Boolean])
				// void Rewired::Utils::Classes::Utility::ValueWatcher<bool>::set_getValueDelegate(
				//         ValueWatcher_1_System_Boolean_ *this,
				//         Func_1_Boolean_ *value,
				//         MethodInfo *method)
				// {
				//   MessageDescriptor *v3; // r9
				//   String__Array *v4; // [rsp+28h] [rbp+28h]
				//   String *v5; // [rsp+30h] [rbp+30h]
				//   MethodInfo *v6; // [rsp+38h] [rbp+38h]
				// 
				//   this.fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA = value;
				//   sub_1800054D0(
				//     (OneofDescriptor *)&this.fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA,
				//     (OneofDescriptorProto *)value,
				//     (FileDescriptor *)method,
				//     v3,
				//     v4,
				//     v5,
				//     v6);
				// }
				// 
			}
		}

		public VolumetricMSBake()
		{
			// // Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
			// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			//         HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			//         HGWindConfig *cSrc,
			//         HGWindConfig *cDst,
			//         float t,
			//         MethodInfo *method)
			// {
			//   ;
			// }
			// 
		}

		public void Release()
		{
			// // Void Release()
			// void HG::Rendering::Runtime::VolumetricMSBake::Release(VolumetricMSBake *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( !byte_18D9197AF )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     byte_18D9197AF = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4399, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4399, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     HG::Rendering::Runtime::VolumetricSDFUtils::ReleaseRenderTexture(&this.fields._msTexture, 0LL);
			//   }
			// }
			// 
		}

		public void BakeMSTexture(CommandBuffer cmd, int sizeX, int sizeY, VolumetricMSBake.FMSArgs msArgs, Material cloudMat, [MetadataOffset(Offset = "0x01F91D6C")] bool force = false)
		{
			// // Void BakeMSTexture(CommandBuffer, Int32, Int32, VolumetricMSBake+FMSArgs, Material, Boolean)
			// void HG::Rendering::Runtime::VolumetricMSBake::BakeMSTexture(
			//         VolumetricMSBake *this,
			//         CommandBuffer *cmd,
			//         int32_t sizeX,
			//         int32_t sizeY,
			//         VolumetricMSBake_FMSArgs *msArgs,
			//         Material *cloudMat,
			//         bool force,
			//         MethodInfo *method)
			// {
			//   VolumetricShaderIDs__StaticFields *static_fields; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   MaterialPropertyBlock *v14; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v15; // rdx
			//   PassConstructorID__Enum__Array *v16; // r8
			//   HGCamera *v17; // r9
			//   BOOL v18; // ecx
			//   __int128 v19; // xmm1
			//   Vector4 v20; // xmm0
			//   __int128 v21; // xmm1
			//   __int128 v22; // xmm0
			//   Vector4 v23; // xmm1
			//   __int128 v24; // xmm1
			//   Vector4 v25; // xmm0
			//   MaterialPropertyBlock *propertyBlock; // rdi
			//   RenderTargetIdentifier *v27; // rax
			//   __int128 v28; // xmm7
			//   __int128 v29; // xmm8
			//   __int64 v30; // xmm6_8
			//   _OWORD *v31; // rax
			//   __int128 v32; // xmm1
			//   __int128 v33; // xmm0
			//   __int128 v34; // xmm1
			//   __int128 v35; // xmm1
			//   Vector4 m_EncodeParams; // xmm0
			//   MethodInfo *v37; // [rsp+28h] [rbp-B9h]
			//   MethodInfo *v38; // [rsp+30h] [rbp-B1h]
			//   Matrix4x4 v39; // [rsp+58h] [rbp-89h] BYREF
			//   RenderTextureDescriptor v40[2]; // [rsp+98h] [rbp-49h] BYREF
			// 
			//   if ( !byte_18D9197B0 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     sub_18003C530(&TypeInfo::UnityEngine::MaterialPropertyBlock);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//     byte_18D9197B0 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4419, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4419, 0LL);
			//     if ( !Patch )
			//       goto LABEL_16;
			//     v35 = *(_OWORD *)&msArgs.m_MssFactor;
			//     *(_OWORD *)&v39.m00 = *(_OWORD *)&msArgs.m_Phase;
			//     m_EncodeParams = msArgs.m_EncodeParams;
			//     *(_OWORD *)&v39.m01 = v35;
			//     *(Vector4 *)&v39.m02 = m_EncodeParams;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1268(
			//       Patch,
			//       (Object *)this,
			//       (Object *)cmd,
			//       sizeX,
			//       sizeY,
			//       (VolumetricMSBake_FMSArgs *)&v39,
			//       (Object *)cloudMat,
			//       force,
			//       0LL);
			//   }
			//   else
			//   {
			//     if ( !this.fields._propertyBlock )
			//     {
			//       v14 = (MaterialPropertyBlock *)sub_180004920(TypeInfo::UnityEngine::MaterialPropertyBlock);
			//       if ( !v14 )
			//         goto LABEL_16;
			//       v14.fields.m_Ptr = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL);
			//       this.fields._propertyBlock = v14;
			//       sub_1800054D0((HGRenderPathScene *)&this.fields, v15, v16, v17, v37, v38);
			//     }
			//     memset(&v39, 0, 52);
			//     UnityEngine::RenderTextureDescriptor::RenderTextureDescriptor(
			//       (RenderTextureDescriptor *)&v39,
			//       sizeX,
			//       sizeY,
			//       RenderTextureFormat__Enum_RHalf,
			//       0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     *(_OWORD *)&v40[0]._width_k__BackingField = *(_OWORD *)&v39.m00;
			//     v40[0]._memoryless_k__BackingField = LODWORD(v39.m03);
			//     *(_OWORD *)&v40[0]._mipCount_k__BackingField = *(_OWORD *)&v39.m01;
			//     *(_OWORD *)&v40[0]._dimension_k__BackingField = *(_OWORD *)&v39.m02;
			//     if ( HG::Rendering::Runtime::VolumetricSDFUtils::CreateRenderTextureIfNeeded(&this.fields._msTexture, v40, 0LL) )
			//     {
			//       v18 = 1;
			//     }
			//     else
			//     {
			//       v19 = *(_OWORD *)&msArgs.m_MssFactor;
			//       *(_OWORD *)&v40[0]._width_k__BackingField = *(_OWORD *)&msArgs.m_Phase;
			//       v20 = msArgs.m_EncodeParams;
			//       *(_OWORD *)&v40[0]._mipCount_k__BackingField = v19;
			//       v21 = *(_OWORD *)&this.fields.m_MsArgs.m_Phase;
			//       *(Vector4 *)&v40[0]._dimension_k__BackingField = v20;
			//       v22 = *(_OWORD *)&this.fields.m_MsArgs.m_MssFactor;
			//       *(_OWORD *)&v39.m00 = v21;
			//       v23 = this.fields.m_MsArgs.m_EncodeParams;
			//       *(_OWORD *)&v39.m01 = v22;
			//       *(Vector4 *)&v39.m02 = v23;
			//       v18 = HG::Rendering::Runtime::VolumetricMSBake::FMSArgs::op_Inequality(
			//               (VolumetricMSBake_FMSArgs *)&v39,
			//               (VolumetricMSBake_FMSArgs *)v40,
			//               0LL);
			//     }
			//     if ( v18 || force )
			//     {
			//       v24 = *(_OWORD *)&msArgs.m_MssFactor;
			//       *(_OWORD *)&this.fields.m_MsArgs.m_Phase = *(_OWORD *)&msArgs.m_Phase;
			//       v25 = msArgs.m_EncodeParams;
			//       propertyBlock = this.fields._propertyBlock;
			//       *(_OWORD *)&this.fields.m_MsArgs.m_MssFactor = v24;
			//       this.fields.m_MsArgs.m_EncodeParams = v25;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//       static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//       if ( propertyBlock )
			//       {
			//         UnityEngine::MaterialPropertyBlock::SetFloatImpl(
			//           propertyBlock,
			//           static_fields._OpticalDepthScale,
			//           this.fields.m_MsArgs.m_OpticalDepthScale,
			//           0LL);
			//         Patch = (ILFixDynamicMethodWrapper_2 *)this.fields._propertyBlock;
			//         static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//         if ( Patch )
			//         {
			//           UnityEngine::MaterialPropertyBlock::SetFloatImpl(
			//             (MaterialPropertyBlock *)Patch,
			//             static_fields._InvOpticalDepthScale,
			//             1.0 / this.fields.m_MsArgs.m_OpticalDepthScale,
			//             0LL);
			//           v27 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
			//                   (RenderTargetIdentifier *)v40,
			//                   (Texture *)this.fields._msTexture,
			//                   0LL);
			//           v28 = *(_OWORD *)&v27.m_Type;
			//           v29 = *(_OWORD *)&v27.m_BufferPointer;
			//           v30 = *(_QWORD *)&v27.m_DepthSlice;
			//           sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//           *(_OWORD *)&v40[0]._width_k__BackingField = v28;
			//           *(_OWORD *)&v40[0]._mipCount_k__BackingField = v29;
			//           *(_QWORD *)&v40[0]._dimension_k__BackingField = v30;
			//           UnityEngine::Rendering::CoreUtils::SetRenderTarget(
			//             cmd,
			//             (RenderTargetIdentifier *)v40,
			//             ClearFlag__Enum_None,
			//             0,
			//             CubemapFace__Enum_Unknown,
			//             -1,
			//             0LL);
			//           v31 = (_OWORD *)sub_182805160(v40);
			//           Patch = (ILFixDynamicMethodWrapper_2 *)this.fields._propertyBlock;
			//           if ( cmd )
			//           {
			//             v32 = v31[1];
			//             *(_OWORD *)&v39.m00 = *v31;
			//             v33 = v31[2];
			//             *(_OWORD *)&v39.m01 = v32;
			//             v34 = v31[3];
			//             *(_OWORD *)&v39.m02 = v33;
			//             *(_OWORD *)&v39.m03 = v34;
			//             UnityEngine::Rendering::CommandBuffer::DrawProcedural(
			//               cmd,
			//               &v39,
			//               cloudMat,
			//               12,
			//               MeshTopology__Enum_Triangles,
			//               3,
			//               1,
			//               (MaterialPropertyBlock *)Patch,
			//               0LL);
			//             return;
			//           }
			//         }
			//       }
			// LABEL_16:
			//       sub_180B536AC(Patch, static_fields);
			//     }
			//   }
			// }
			// 
		}

		private MaterialPropertyBlock _propertyBlock;

		private RenderTexture _msTexture;

		private VolumetricMSBake.FMSArgs m_MsArgs;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 48)]
		public struct FMSArgs : IEquatable<VolumetricMSBake.FMSArgs>
		{
			[IDTag(0)]
			public bool Equals(VolumetricMSBake.FMSArgs other)
			{
				// // Boolean Equals(VolumetricMSBake+FMSArgs)
				// bool HG::Rendering::Runtime::VolumetricMSBake::FMSArgs::Equals(
				//         VolumetricMSBake_FMSArgs *this,
				//         VolumetricMSBake_FMSArgs *other,
				//         MethodInfo *method)
				// {
				//   MethodInfo *v5; // r8
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v8; // rdx
				//   __int64 v9; // rcx
				//   __int128 v10; // xmm1
				//   Vector4 m_EncodeParams; // xmm0
				//   Vector4 v12; // [rsp+20h] [rbp-40h] BYREF
				//   VolumetricMSBake_FMSArgs v13; // [rsp+30h] [rbp-30h] BYREF
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(4471, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(4471, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v9, v8);
				//     v10 = *(_OWORD *)&other.m_MssFactor;
				//     *(_OWORD *)&v13.m_Phase = *(_OWORD *)&other.m_Phase;
				//     m_EncodeParams = other.m_EncodeParams;
				//     *(_OWORD *)&v13.m_MssFactor = v10;
				//     v13.m_EncodeParams = m_EncodeParams;
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1283(Patch, this, &v13, 0LL);
				//   }
				//   else if ( System::Single::Equals((Single *)this, COERCE_FLOAT(*(_OWORD *)&other.m_Phase), 0LL)
				//          && System::Single::Equals((Single *)&this.m_Phase2, other.m_Phase2, 0LL)
				//          && System::Single::Equals((Single *)&this.m_PhaseBlend, other.m_PhaseBlend, 0LL)
				//          && this.m_MsOctaveCount == HIDWORD(*(_QWORD *)&other.m_PhaseBlend)
				//          && System::Single::Equals((Single *)&this.m_MssFactor, COERCE_FLOAT(*(_OWORD *)&other.m_MssFactor), 0LL)
				//          && System::Single::Equals((Single *)&this.m_MseFactor, other.m_MseFactor, 0LL)
				//          && System::Single::Equals((Single *)&this.m_MspFactor, other.m_MspFactor, 0LL)
				//          && System::Single::Equals((Single *)&this.m_OpticalDepthScale, other.m_OpticalDepthScale, 0LL) )
				//   {
				//     v12 = other.m_EncodeParams;
				//     return Sirenix::Utilities::TypeExtensions::QuaternionEqualityComparer(
				//              (Quaternion *)&this.m_EncodeParams,
				//              (Quaternion *)&v12,
				//              v5);
				//   }
				//   else
				//   {
				//     return 0;
				//   }
				// }
				// 
				return default(bool);
			}

			[IDTag(1)]
			public override bool Equals(object obj)
			{
				// // Boolean Equals(Object)
				// bool HG::Rendering::Runtime::VolumetricMSBake::FMSArgs::Equals(
				//         VolumetricMSBake_FMSArgs *this,
				//         Object *obj,
				//         MethodInfo *method)
				// {
				//   _OWORD *v5; // rax
				//   __int128 v6; // xmm1
				//   Vector4 v7; // xmm0
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v10; // rdx
				//   __int64 v11; // rcx
				//   VolumetricMSBake_FMSArgs v12; // [rsp+20h] [rbp-38h] BYREF
				// 
				//   if ( !byte_18D9197B1 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricMSBake::FMSArgs);
				//     byte_18D9197B1 = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(4472, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(4472, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v11, v10);
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1284(Patch, this, obj, 0LL);
				//   }
				//   else if ( obj
				//          && (struct VolumetricMSBake_FMSArgs__Class *)obj.klass == TypeInfo::HG::Rendering::Runtime::VolumetricMSBake::FMSArgs )
				//   {
				//     v5 = (_OWORD *)sub_18004A160(obj);
				//     v6 = v5[1];
				//     *(_OWORD *)&v12.m_Phase = *v5;
				//     v7 = (Vector4)v5[2];
				//     *(_OWORD *)&v12.m_MssFactor = v6;
				//     v12.m_EncodeParams = v7;
				//     return HG::Rendering::Runtime::VolumetricMSBake::FMSArgs::Equals(this, &v12, 0LL);
				//   }
				//   else
				//   {
				//     return 0;
				//   }
				// }
				// 
				return default(bool);
			}

			public override int GetHashCode()
			{
				// // Int32 GetHashCode()
				// int32_t HG::Rendering::Runtime::VolumetricMSBake::FMSArgs::GetHashCode(
				//         VolumetricMSBake_FMSArgs *this,
				//         MethodInfo *method)
				// {
				//   float m_Phase; // xmm6_4
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v6; // rdx
				//   __int64 v7; // rcx
				//   Vector4 m_EncodeParams; // [rsp+20h] [rbp-40h] BYREF
				//   HashCode v9; // [rsp+30h] [rbp-30h] BYREF
				// 
				//   if ( !byte_18D9197B2 )
				//   {
				//     sub_18003C530(&MethodInfo::System::HashCode::Add<int>);
				//     sub_18003C530(&MethodInfo::System::HashCode::Add<float>);
				//     sub_18003C530(&MethodInfo::System::HashCode::Add<UnityEngine::Vector4>);
				//     sub_18003C530(&TypeInfo::System::HashCode);
				//     byte_18D9197B2 = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(4473, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(4473, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v7, v6);
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1285(Patch, this, 0LL);
				//   }
				//   else
				//   {
				//     m_Phase = this.m_Phase;
				//     memset(&v9, 0, sizeof(v9));
				//     sub_180002C70(TypeInfo::System::HashCode);
				//     System::HashCode::Add<float>(&v9, m_Phase, MethodInfo::System::HashCode::Add<float>);
				//     System::HashCode::Add<float>(&v9, this.m_Phase2, MethodInfo::System::HashCode::Add<float>);
				//     System::HashCode::Add<float>(&v9, this.m_PhaseBlend, MethodInfo::System::HashCode::Add<float>);
				//     System::HashCode::Add<unsigned int>(&v9, this.m_MsOctaveCount, MethodInfo::System::HashCode::Add<int>);
				//     System::HashCode::Add<float>(&v9, this.m_MssFactor, MethodInfo::System::HashCode::Add<float>);
				//     System::HashCode::Add<float>(&v9, this.m_MseFactor, MethodInfo::System::HashCode::Add<float>);
				//     System::HashCode::Add<float>(&v9, this.m_MspFactor, MethodInfo::System::HashCode::Add<float>);
				//     System::HashCode::Add<float>(&v9, this.m_OpticalDepthScale, MethodInfo::System::HashCode::Add<float>);
				//     m_EncodeParams = this.m_EncodeParams;
				//     System::HashCode::Add<UnityEngine::Vector4>(
				//       &v9,
				//       &m_EncodeParams,
				//       MethodInfo::System::HashCode::Add<UnityEngine::Vector4>);
				//     return System::HashCode::ToHashCode(&v9, 0LL);
				//   }
				// }
				// 
				return 0;
			}

			public static bool operator ==(VolumetricMSBake.FMSArgs a, VolumetricMSBake.FMSArgs b)
			{
				// // Boolean op_Equality(VolumetricMSBake+FMSArgs, VolumetricMSBake+FMSArgs)
				// bool HG::Rendering::Runtime::VolumetricMSBake::FMSArgs::op_Equality(
				//         VolumetricMSBake_FMSArgs *a,
				//         VolumetricMSBake_FMSArgs *b,
				//         MethodInfo *method)
				// {
				//   float v3; // xmm2_4
				//   UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat *v6; // rcx
				//   UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat *v7; // rcx
				//   UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat *v8; // rcx
				//   UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat *v9; // rcx
				//   UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat *v10; // rcx
				//   UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat *v11; // rcx
				//   UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat *v12; // rcx
				//   Vector4 v13; // xmm5
				//   Vector4 v14; // xmm2
				//   float v15; // xmm4_4
				//   float v16; // xmm1_4
				//   float v17; // xmm1_4
				//   float v18; // xmm3_4
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v21; // rdx
				//   __int64 v22; // rcx
				//   __int128 v23; // xmm1
				//   Vector4 m_EncodeParams; // xmm0
				//   __int128 v25; // xmm1
				//   __int128 v26; // xmm0
				//   Vector4 v27; // xmm1
				//   VolumetricMSBake_FMSArgs v28; // [rsp+20h] [rbp-60h] BYREF
				//   VolumetricMSBake_FMSArgs v29; // [rsp+50h] [rbp-30h] BYREF
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(4423, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(4423, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v22, v21);
				//     v23 = *(_OWORD *)&b.m_MssFactor;
				//     *(_OWORD *)&v28.m_Phase = *(_OWORD *)&b.m_Phase;
				//     m_EncodeParams = b.m_EncodeParams;
				//     *(_OWORD *)&v28.m_MssFactor = v23;
				//     v25 = *(_OWORD *)&a.m_Phase;
				//     v28.m_EncodeParams = m_EncodeParams;
				//     v26 = *(_OWORD *)&a.m_MssFactor;
				//     *(_OWORD *)&v29.m_Phase = v25;
				//     v27 = a.m_EncodeParams;
				//     *(_OWORD *)&v29.m_MssFactor = v26;
				//     v29.m_EncodeParams = v27;
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1267(Patch, &v29, &v28, 0LL);
				//   }
				//   else if ( (unsigned __int8)UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat::IsSame(
				//                                v6,
				//                                COERCE_FLOAT(*(_OWORD *)&b.m_Phase),
				//                                v3)
				//          && (unsigned __int8)UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat::IsSame(
				//                                v7,
				//                                b.m_Phase2,
				//                                v3)
				//          && (unsigned __int8)UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat::IsSame(
				//                                v8,
				//                                b.m_PhaseBlend,
				//                                v3)
				//          && (v9 = (UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat *)HIDWORD(*(_QWORD *)&b.m_PhaseBlend),
				//              HIDWORD(*(_QWORD *)&a.m_PhaseBlend) == (_DWORD)v9)
				//          && (unsigned __int8)UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat::IsSame(
				//                                v9,
				//                                COERCE_FLOAT(*(_OWORD *)&b.m_MssFactor),
				//                                v3)
				//          && (unsigned __int8)UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat::IsSame(
				//                                v10,
				//                                b.m_MseFactor,
				//                                v3)
				//          && (unsigned __int8)UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat::IsSame(
				//                                v11,
				//                                b.m_MspFactor,
				//                                v3)
				//          && (unsigned __int8)UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat::IsSame(
				//                                v12,
				//                                b.m_OpticalDepthScale,
				//                                v3) )
				//   {
				//     v13 = a.m_EncodeParams;
				//     v14 = b.m_EncodeParams;
				//     v15 = _mm_shuffle_ps((__m128)v13, (__m128)v13, 85).m128_f32[0]
				//         - _mm_shuffle_ps((__m128)v14, (__m128)v14, 85).m128_f32[0];
				//     v16 = _mm_shuffle_ps((__m128)v13, (__m128)v13, 170).m128_f32[0];
				//     v13.x = _mm_shuffle_ps((__m128)v13, (__m128)v13, 255).m128_f32[0];
				//     v17 = v16 - _mm_shuffle_ps((__m128)v14, (__m128)v14, 170).m128_f32[0];
				//     v18 = (float)(COERCE_FLOAT(*(_OWORD *)&a.m_EncodeParams) - v14.x)
				//         * (float)(COERCE_FLOAT(*(_OWORD *)&a.m_EncodeParams) - v14.x);
				//     v14.x = _mm_shuffle_ps((__m128)v14, (__m128)v14, 255).m128_f32[0];
				//     return (float)((float)((float)((float)(v15 * v15) + v18) + (float)(v17 * v17))
				//                  + (float)((float)(v13.x - v14.x) * (float)(v13.x - v14.x))) < 9.9999994e-11;
				//   }
				//   else
				//   {
				//     return 0;
				//   }
				// }
				// 
				return default(bool);
			}

			public static bool operator !=(VolumetricMSBake.FMSArgs a, VolumetricMSBake.FMSArgs b)
			{
				// // Boolean op_Inequality(VolumetricMSBake+FMSArgs, VolumetricMSBake+FMSArgs)
				// bool HG::Rendering::Runtime::VolumetricMSBake::FMSArgs::op_Inequality(
				//         VolumetricMSBake_FMSArgs *a,
				//         VolumetricMSBake_FMSArgs *b,
				//         MethodInfo *method)
				// {
				//   __int128 v5; // xmm1
				//   Vector4 v6; // xmm0
				//   __int128 v7; // xmm1
				//   __int128 v8; // xmm0
				//   Vector4 v9; // xmm1
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v12; // rdx
				//   __int64 v13; // rcx
				//   __int128 v14; // xmm1
				//   Vector4 m_EncodeParams; // xmm0
				//   __int128 v16; // xmm1
				//   __int128 v17; // xmm0
				//   Vector4 v18; // xmm1
				//   VolumetricMSBake_FMSArgs v19; // [rsp+20h] [rbp-60h] BYREF
				//   VolumetricMSBake_FMSArgs v20; // [rsp+50h] [rbp-30h] BYREF
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(4422, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(4422, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v13, v12);
				//     v14 = *(_OWORD *)&b.m_MssFactor;
				//     *(_OWORD *)&v20.m_Phase = *(_OWORD *)&b.m_Phase;
				//     m_EncodeParams = b.m_EncodeParams;
				//     *(_OWORD *)&v20.m_MssFactor = v14;
				//     v16 = *(_OWORD *)&a.m_Phase;
				//     v20.m_EncodeParams = m_EncodeParams;
				//     v17 = *(_OWORD *)&a.m_MssFactor;
				//     *(_OWORD *)&v19.m_Phase = v16;
				//     v18 = a.m_EncodeParams;
				//     *(_OWORD *)&v19.m_MssFactor = v17;
				//     v19.m_EncodeParams = v18;
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1267(Patch, &v19, &v20, 0LL);
				//   }
				//   else
				//   {
				//     v5 = *(_OWORD *)&b.m_MssFactor;
				//     *(_OWORD *)&v19.m_Phase = *(_OWORD *)&b.m_Phase;
				//     v6 = b.m_EncodeParams;
				//     *(_OWORD *)&v19.m_MssFactor = v5;
				//     v7 = *(_OWORD *)&a.m_Phase;
				//     v19.m_EncodeParams = v6;
				//     v8 = *(_OWORD *)&a.m_MssFactor;
				//     *(_OWORD *)&v20.m_Phase = v7;
				//     v9 = a.m_EncodeParams;
				//     *(_OWORD *)&v20.m_MssFactor = v8;
				//     v20.m_EncodeParams = v9;
				//     return !HG::Rendering::Runtime::VolumetricMSBake::FMSArgs::op_Equality(&v20, &v19, 0LL);
				//   }
				// }
				// 
				return default(bool);
			}

			public bool <>iFixBaseProxy_Equals(object P0)
			{
				// // Boolean <>iFixBaseProxy_Equals(Object)
				// bool HG::Rendering::Runtime::VolumetricMSBake::FMSArgs::__iFixBaseProxy_Equals(
				//         VolumetricMSBake_FMSArgs *this,
				//         Object *P0,
				//         MethodInfo *method)
				// {
				//   __int128 v5; // xmm1
				//   Vector4 m_EncodeParams; // xmm0
				//   Object *v7; // rax
				//   _OWORD v9[3]; // [rsp+20h] [rbp-38h] BYREF
				// 
				//   if ( !byte_18D9197B3 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricMSBake::FMSArgs);
				//     byte_18D9197B3 = 1;
				//   }
				//   v5 = *(_OWORD *)&this.m_MssFactor;
				//   v9[0] = *(_OWORD *)&this.m_Phase;
				//   m_EncodeParams = this.m_EncodeParams;
				//   v9[1] = v5;
				//   v9[2] = m_EncodeParams;
				//   v7 = (Object *)il2cpp_value_box_0(TypeInfo::HG::Rendering::Runtime::VolumetricMSBake::FMSArgs, v9, method);
				//   return System::ValueType::DefaultEquals(v7, P0, 0LL);
				// }
				// 
				return default(bool);
			}

			public int <>iFixBaseProxy_GetHashCode()
			{
				// // Int32 <>iFixBaseProxy_GetHashCode()
				// int32_t HG::Rendering::Runtime::VolumetricMSBake::FMSArgs::__iFixBaseProxy_GetHashCode(
				//         VolumetricMSBake_FMSArgs *this,
				//         MethodInfo *method)
				// {
				//   __int64 v2; // r8
				//   __int128 v4; // xmm1
				//   Vector4 m_EncodeParams; // xmm0
				//   ValueType *v6; // rax
				//   _OWORD v8[3]; // [rsp+20h] [rbp-38h] BYREF
				// 
				//   if ( !byte_18D9197B4 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricMSBake::FMSArgs);
				//     byte_18D9197B4 = 1;
				//   }
				//   v4 = *(_OWORD *)&this.m_MssFactor;
				//   v8[0] = *(_OWORD *)&this.m_Phase;
				//   m_EncodeParams = this.m_EncodeParams;
				//   v8[1] = v4;
				//   v8[2] = m_EncodeParams;
				//   v6 = (ValueType *)il2cpp_value_box_0(TypeInfo::HG::Rendering::Runtime::VolumetricMSBake::FMSArgs, v8, v2);
				//   return System::ValueType::GetHashCode(v6, 0LL);
				// }
				// 
				return 0;
			}

			public float m_Phase;

			public float m_Phase2;

			public float m_PhaseBlend;

			public int m_MsOctaveCount;

			public float m_MssFactor;

			public float m_MseFactor;

			public float m_MspFactor;

			public float m_OpticalDepthScale;

			public Vector4 m_EncodeParams;
		}
	}
}
