using System;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[VolumeComponentMenuForRenderPipeline("Post-processing/Bloom", new Type[] { typeof(HGRenderPipeline) })]
	[Serializable]
	public sealed class Bloom : VolumeComponent, IPostProcessComponent
	{
		// (get) Token: 0x06000C43 RID: 3139 RVA: 0x000029C8 File Offset: 0x00000BC8
		public BloomResolution resolution
		{
			get
			{
				// // BloomResolution get_resolution()
				// BloomResolution__Enum HG::Rendering::Runtime::Bloom::get_resolution(Bloom *this, MethodInfo *method)
				// {
				//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
				//   int *wrapperArray; // rdx
				//   int v5; // eax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D8EDC37 )
				//   {
				//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     byte_18D8EDC37 = 1;
				//   }
				//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
				//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   wrapperArray = (int *)v3.static_fields.wrapperArray;
				//   if ( !wrapperArray )
				//     goto LABEL_12;
				//   if ( wrapperArray[6] <= 2210 )
				//     goto LABEL_7;
				//   if ( !v3._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(v3, wrapperArray);
				//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
				//   if ( !v3 )
				//     goto LABEL_12;
				//   if ( LODWORD(v3._0.namespaze) <= 0x8A2 )
				//     sub_180070270(v3, wrapperArray);
				//   if ( !*((_QWORD *)&v3[47]._0.byval_arg + 1) )
				//   {
				// LABEL_7:
				//     wrapperArray = (int *)this.fields.quality;
				//     if ( !wrapperArray )
				//       goto LABEL_12;
				//     v5 = sub_18003ED00(10LL);
				//     if ( v5 == 2 )
				//     {
				//       wrapperArray = (int *)this.fields.resolutionHighQuality;
				//     }
				//     else if ( v5 )
				//     {
				//       if ( v5 != 1 )
				//         return 2;
				//       wrapperArray = (int *)this.fields.resolutionMedQuality;
				//     }
				//     else
				//     {
				//       wrapperArray = (int *)this.fields.resolutionLowQuality;
				//     }
				//     if ( wrapperArray )
				//       return (unsigned int)sub_18003ED00(10LL);
				// LABEL_12:
				//     sub_180B536AC(v3, wrapperArray);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(2210, 0LL);
				//   if ( !Patch )
				//     goto LABEL_12;
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_65((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
				// }
				// 
				return (BloomResolution)((BloomResolution)0);
			}
		}

		// (get) Token: 0x06000C44 RID: 3140 RVA: 0x000025F0 File Offset: 0x000007F0
		public float threshold
		{
			get
			{
				// // Single get_threshold()
				// float HG::Rendering::Runtime::Bloom::get_threshold(Bloom *this, MethodInfo *method)
				// {
				//   Object *thresholdHighQuality; // rbx
				//   double v3; // xmm0_8
				//   float (*typeMetadataHandle)(AbilitySystem *, MethodInfo *); // r8
				//   Object__Class *klass; // rax
				//   ILFixDynamicMethodWrapper *Patch; // rax
				// 
				//   thresholdHighQuality = (Object *)this.fields.thresholdHighQuality;
				//   if ( !thresholdHighQuality )
				//     goto LABEL_19;
				//   v3 = sub_180003EE0(thresholdHighQuality.klass);
				//   typeMetadataHandle = (float (*)(AbilitySystem *, MethodInfo *))thresholdHighQuality.klass[1]._0.typeMetadataHandle;
				//   method = (MethodInfo *)thresholdHighQuality.klass[1]._0.interopData;
				//   if ( typeMetadataHandle == Beyond::Gameplay::Core::AbilitySystem::get_detectedRadius )
				//   {
				//     klass = thresholdHighQuality[33].klass;
				//     if ( klass )
				//     {
				//       this = (Bloom *)klass._0.name;
				//       if ( this )
				//       {
				//         LODWORD(v3) = this.fields._._._.m_CachedPtr;
				//         return *(float *)&v3;
				//       }
				//     }
				//     goto LABEL_19;
				//   }
				//   if ( (char *)typeMetadataHandle != (char *)Beyond::NPC::Animation::AnimatorClothCalculator::AnimatorLookAtControllerHolder::get_weightBase )
				//   {
				//     if ( (char *)typeMetadataHandle != (char *)Beyond::Gameplay::Core::MovePipelineGroundBase::get_stepDownOffset )
				//     {
				//       ((void (__fastcall *)(Object *, MethodInfo *))typeMetadataHandle)(thresholdHighQuality, method);
				//       return *(float *)&v3;
				//     }
				//     this = (Bloom *)thresholdHighQuality[1].klass;
				//     if ( this )
				//     {
				//       *(float *)&v3 = Beyond::Gameplay::Core::MovementComponent::get_stepDownOffset((MovementComponent *)this, 0LL);
				//       return *(float *)&v3;
				//     }
				// LABEL_19:
				//     sub_180B536AC(this, method);
				//   }
				//   if ( !byte_18D8EB3CE )
				//   {
				//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     byte_18D8EB3CE = 1;
				//   }
				//   this = (Bloom *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
				//     this = (Bloom *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   method = (MethodInfo *)this.fields.characterSoftness.klass;
				//   if ( !method )
				//     goto LABEL_19;
				//   if ( SLODWORD(method.name) > 1833 )
				//   {
				//     if ( !LODWORD(this[1].klass) )
				//     {
				//       il2cpp_runtime_class_init_0(this, method);
				//       this = (Bloom *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//     }
				//     this = (Bloom *)this.fields.characterSoftness.klass;
				//     if ( !this )
				//       goto LABEL_19;
				//     if ( *(_DWORD *)&this.fields._.active <= 0x729u )
				//       sub_180070270(this, method);
				//     if ( this[65].fields.scatterMedQuality )
				//     {
				//       Patch = IFix::WrappersManagerImpl::GetPatch(1833, 0LL);
				//       if ( Patch )
				//       {
				//         *(float *)&v3 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_43(
				//                           (ILFixDynamicMethodWrapper_16 *)Patch,
				//                           thresholdHighQuality,
				//                           0LL);
				//         return *(float *)&v3;
				//       }
				//       goto LABEL_19;
				//     }
				//   }
				//   if ( thresholdHighQuality[2].klass )
				//     LODWORD(v3) = HIDWORD(thresholdHighQuality[2].klass._1.typeHierarchy);
				//   else
				//     LODWORD(v3) = 0;
				//   return *(float *)&v3;
				// }
				// 
				return 0f;
			}
		}

		// (get) Token: 0x06000C45 RID: 3141 RVA: 0x000025F0 File Offset: 0x000007F0
		public float intensity
		{
			get
			{
				// // Single get_intensity()
				// float HG::Rendering::Runtime::Bloom::get_intensity(Bloom *this, MethodInfo *method)
				// {
				//   Object *intensityHighQuality; // rbx
				//   double v3; // xmm0_8
				//   float (*typeMetadataHandle)(AbilitySystem *, MethodInfo *); // r8
				//   Object__Class *klass; // rax
				//   ILFixDynamicMethodWrapper *Patch; // rax
				// 
				//   intensityHighQuality = (Object *)this.fields.intensityHighQuality;
				//   if ( !intensityHighQuality )
				//     goto LABEL_19;
				//   v3 = sub_180003EE0(intensityHighQuality.klass);
				//   typeMetadataHandle = (float (*)(AbilitySystem *, MethodInfo *))intensityHighQuality.klass[1]._0.typeMetadataHandle;
				//   method = (MethodInfo *)intensityHighQuality.klass[1]._0.interopData;
				//   if ( typeMetadataHandle == Beyond::Gameplay::Core::AbilitySystem::get_detectedRadius )
				//   {
				//     klass = intensityHighQuality[33].klass;
				//     if ( klass )
				//     {
				//       this = (Bloom *)klass._0.name;
				//       if ( this )
				//       {
				//         LODWORD(v3) = this.fields._._._.m_CachedPtr;
				//         return *(float *)&v3;
				//       }
				//     }
				//     goto LABEL_19;
				//   }
				//   if ( (char *)typeMetadataHandle != (char *)Beyond::NPC::Animation::AnimatorClothCalculator::AnimatorLookAtControllerHolder::get_weightBase )
				//   {
				//     if ( (char *)typeMetadataHandle != (char *)Beyond::Gameplay::Core::MovePipelineGroundBase::get_stepDownOffset )
				//     {
				//       ((void (__fastcall *)(Object *, MethodInfo *))typeMetadataHandle)(intensityHighQuality, method);
				//       return *(float *)&v3;
				//     }
				//     this = (Bloom *)intensityHighQuality[1].klass;
				//     if ( this )
				//     {
				//       *(float *)&v3 = Beyond::Gameplay::Core::MovementComponent::get_stepDownOffset((MovementComponent *)this, 0LL);
				//       return *(float *)&v3;
				//     }
				// LABEL_19:
				//     sub_180B536AC(this, method);
				//   }
				//   if ( !byte_18D8EB3CE )
				//   {
				//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     byte_18D8EB3CE = 1;
				//   }
				//   this = (Bloom *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
				//     this = (Bloom *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   method = (MethodInfo *)this.fields.characterSoftness.klass;
				//   if ( !method )
				//     goto LABEL_19;
				//   if ( SLODWORD(method.name) > 1833 )
				//   {
				//     if ( !LODWORD(this[1].klass) )
				//     {
				//       il2cpp_runtime_class_init_0(this, method);
				//       this = (Bloom *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//     }
				//     this = (Bloom *)this.fields.characterSoftness.klass;
				//     if ( !this )
				//       goto LABEL_19;
				//     if ( *(_DWORD *)&this.fields._.active <= 0x729u )
				//       sub_180070270(this, method);
				//     if ( this[65].fields.scatterMedQuality )
				//     {
				//       Patch = IFix::WrappersManagerImpl::GetPatch(1833, 0LL);
				//       if ( Patch )
				//       {
				//         *(float *)&v3 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_43(
				//                           (ILFixDynamicMethodWrapper_16 *)Patch,
				//                           intensityHighQuality,
				//                           0LL);
				//         return *(float *)&v3;
				//       }
				//       goto LABEL_19;
				//     }
				//   }
				//   if ( intensityHighQuality[2].klass )
				//     LODWORD(v3) = HIDWORD(intensityHighQuality[2].klass._1.typeHierarchy);
				//   else
				//     LODWORD(v3) = 0;
				//   return *(float *)&v3;
				// }
				// 
				return 0f;
			}
		}

		// (get) Token: 0x06000C46 RID: 3142 RVA: 0x000025F0 File Offset: 0x000007F0
		public float scatter
		{
			get
			{
				// // Single get_scatter()
				// float HG::Rendering::Runtime::Bloom::get_scatter(Bloom *this, MethodInfo *method)
				// {
				//   Object *scatterHighQuality; // rbx
				//   double v3; // xmm0_8
				//   float (*typeMetadataHandle)(AbilitySystem *, MethodInfo *); // r8
				//   Object__Class *klass; // rax
				//   ILFixDynamicMethodWrapper *Patch; // rax
				// 
				//   scatterHighQuality = (Object *)this.fields.scatterHighQuality;
				//   if ( !scatterHighQuality )
				//     goto LABEL_19;
				//   v3 = sub_180003EE0(scatterHighQuality.klass);
				//   typeMetadataHandle = (float (*)(AbilitySystem *, MethodInfo *))scatterHighQuality.klass[1]._0.typeMetadataHandle;
				//   method = (MethodInfo *)scatterHighQuality.klass[1]._0.interopData;
				//   if ( typeMetadataHandle == Beyond::Gameplay::Core::AbilitySystem::get_detectedRadius )
				//   {
				//     klass = scatterHighQuality[33].klass;
				//     if ( klass )
				//     {
				//       this = (Bloom *)klass._0.name;
				//       if ( this )
				//       {
				//         LODWORD(v3) = this.fields._._._.m_CachedPtr;
				//         return *(float *)&v3;
				//       }
				//     }
				//     goto LABEL_19;
				//   }
				//   if ( (char *)typeMetadataHandle != (char *)Beyond::NPC::Animation::AnimatorClothCalculator::AnimatorLookAtControllerHolder::get_weightBase )
				//   {
				//     if ( (char *)typeMetadataHandle != (char *)Beyond::Gameplay::Core::MovePipelineGroundBase::get_stepDownOffset )
				//     {
				//       ((void (__fastcall *)(Object *, MethodInfo *))typeMetadataHandle)(scatterHighQuality, method);
				//       return *(float *)&v3;
				//     }
				//     this = (Bloom *)scatterHighQuality[1].klass;
				//     if ( this )
				//     {
				//       *(float *)&v3 = Beyond::Gameplay::Core::MovementComponent::get_stepDownOffset((MovementComponent *)this, 0LL);
				//       return *(float *)&v3;
				//     }
				// LABEL_19:
				//     sub_180B536AC(this, method);
				//   }
				//   if ( !byte_18D8EB3CE )
				//   {
				//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     byte_18D8EB3CE = 1;
				//   }
				//   this = (Bloom *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
				//     this = (Bloom *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   method = (MethodInfo *)this.fields.characterSoftness.klass;
				//   if ( !method )
				//     goto LABEL_19;
				//   if ( SLODWORD(method.name) > 1833 )
				//   {
				//     if ( !LODWORD(this[1].klass) )
				//     {
				//       il2cpp_runtime_class_init_0(this, method);
				//       this = (Bloom *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//     }
				//     this = (Bloom *)this.fields.characterSoftness.klass;
				//     if ( !this )
				//       goto LABEL_19;
				//     if ( *(_DWORD *)&this.fields._.active <= 0x729u )
				//       sub_180070270(this, method);
				//     if ( this[65].fields.scatterMedQuality )
				//     {
				//       Patch = IFix::WrappersManagerImpl::GetPatch(1833, 0LL);
				//       if ( Patch )
				//       {
				//         *(float *)&v3 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_43(
				//                           (ILFixDynamicMethodWrapper_16 *)Patch,
				//                           scatterHighQuality,
				//                           0LL);
				//         return *(float *)&v3;
				//       }
				//       goto LABEL_19;
				//     }
				//   }
				//   if ( scatterHighQuality[2].klass )
				//     LODWORD(v3) = HIDWORD(scatterHighQuality[2].klass._1.typeHierarchy);
				//   else
				//     LODWORD(v3) = 0;
				//   return *(float *)&v3;
				// }
				// 
				return 0f;
			}
		}

		// (get) Token: 0x06000C47 RID: 3143 RVA: 0x000025D8 File Offset: 0x000007D8
		public bool dirtEnabled
		{
			get
			{
				// // Boolean get_dirtEnabled()
				// bool HG::Rendering::Runtime::Bloom::get_dirtEnabled(Bloom *this, MethodInfo *method)
				// {
				//   _QWORD **v3; // rcx
				//   int *dirtTexture; // rdx
				//   __int64 v5; // rdx
				//   __int64 v6; // rbx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D8ED9BD )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D8ED9BD = 1;
				//   }
				//   if ( !byte_18D8EDC37 )
				//   {
				//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     byte_18D8EDC37 = 1;
				//   }
				//   v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
				//     v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   dirtTexture = (int *)*v3[23];
				//   if ( !dirtTexture )
				//     goto LABEL_23;
				//   if ( dirtTexture[6] > 2211 )
				//   {
				//     if ( !*((_DWORD *)v3 + 56) )
				//     {
				//       il2cpp_runtime_class_init_0(v3, dirtTexture);
				//       v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//     }
				//     v3 = (_QWORD **)*v3[23];
				//     if ( !v3 )
				//       goto LABEL_23;
				//     if ( *((_DWORD *)v3 + 6) <= 0x8A3u )
				//       sub_180070270(v3, dirtTexture);
				//     if ( v3[2215] )
				//     {
				//       Patch = IFix::WrappersManagerImpl::GetPatch(2211, 0LL);
				//       if ( Patch )
				//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
				// LABEL_23:
				//       sub_180B536AC(v3, dirtTexture);
				//     }
				//   }
				//   dirtTexture = (int *)this.fields.dirtTexture;
				//   if ( !dirtTexture )
				//     goto LABEL_23;
				//   v6 = sub_18004EF00(10LL, dirtTexture);
				//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v5);
				//   if ( !byte_18D8F4EFB )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D8F4EFB = 1;
				//   }
				//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v5);
				//   if ( !byte_18D8F4EAF )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D8F4EAF = 1;
				//   }
				//   if ( !v6 )
				//     return 0;
				//   v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
				//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v5);
				//   if ( !*(_QWORD *)(v6 + 16) )
				//     return 0;
				//   dirtTexture = (int *)this.fields.dirtIntensity;
				//   if ( !dirtTexture )
				//     goto LABEL_23;
				//   return sub_18003F9B0(10LL, dirtTexture) > 0.0;
				// }
				// 
				return default(bool);
			}
		}

		public Bloom()
		{
			// // Bloom()
			// void HG::Rendering::Runtime::Bloom::Bloom(Bloom *this, MethodInfo *method)
			// {
			//   BloomQualityParameter *v3; // rax
			//   OneofDescriptorProto *v4; // rdx
			//   __int64 v5; // rcx
			//   BloomQualityParameter *v6; // rdi
			//   OneofDescriptorProto *v7; // rdx
			//   FileDescriptor *v8; // r8
			//   MessageDescriptor *v9; // r9
			//   BloomResolutionParameter *v10; // rax
			//   BloomResolutionParameter *v11; // rdi
			//   OneofDescriptorProto *v12; // rdx
			//   FileDescriptor *v13; // r8
			//   MessageDescriptor *v14; // r9
			//   BloomResolutionParameter *v15; // rax
			//   BloomResolutionParameter *v16; // rdi
			//   OneofDescriptorProto *v17; // rdx
			//   FileDescriptor *v18; // r8
			//   MessageDescriptor *v19; // r9
			//   BloomResolutionParameter *v20; // rax
			//   BloomResolutionParameter *v21; // rdi
			//   OneofDescriptorProto *v22; // rdx
			//   FileDescriptor *v23; // r8
			//   MessageDescriptor *v24; // r9
			//   FloatParameter *v25; // rax
			//   FloatParameter *v26; // rdi
			//   OneofDescriptorProto *v27; // rdx
			//   FileDescriptor *v28; // r8
			//   MessageDescriptor *v29; // r9
			//   FloatParameter *v30; // rax
			//   FloatParameter *v31; // rdi
			//   OneofDescriptorProto *v32; // rdx
			//   FileDescriptor *v33; // r8
			//   MessageDescriptor *v34; // r9
			//   FloatParameter *v35; // rax
			//   FloatParameter *v36; // rdi
			//   OneofDescriptorProto *v37; // rdx
			//   FileDescriptor *v38; // r8
			//   MessageDescriptor *v39; // r9
			//   ClampedFloatParameter *v40; // rax
			//   ClampedFloatParameter *v41; // rdi
			//   OneofDescriptorProto *v42; // rdx
			//   FileDescriptor *v43; // r8
			//   MessageDescriptor *v44; // r9
			//   ClampedFloatParameter *v45; // rax
			//   ClampedFloatParameter *v46; // rdi
			//   OneofDescriptorProto *v47; // rdx
			//   FileDescriptor *v48; // r8
			//   MessageDescriptor *v49; // r9
			//   ClampedFloatParameter *v50; // rax
			//   ClampedFloatParameter *v51; // rdi
			//   OneofDescriptorProto *v52; // rdx
			//   FileDescriptor *v53; // r8
			//   MessageDescriptor *v54; // r9
			//   ClampedFloatParameter *v55; // rax
			//   ClampedFloatParameter *v56; // rdi
			//   OneofDescriptorProto *v57; // rdx
			//   FileDescriptor *v58; // r8
			//   MessageDescriptor *v59; // r9
			//   ClampedFloatParameter *v60; // rax
			//   ClampedFloatParameter *v61; // rdi
			//   OneofDescriptorProto *v62; // rdx
			//   FileDescriptor *v63; // r8
			//   MessageDescriptor *v64; // r9
			//   ClampedFloatParameter *v65; // rax
			//   ClampedFloatParameter *v66; // rdi
			//   OneofDescriptorProto *v67; // rdx
			//   FileDescriptor *v68; // r8
			//   MessageDescriptor *v69; // r9
			//   MethodInfo *v70; // rdx
			//   Vector4 v71; // xmm7
			//   __int64 v72; // rdi
			//   FileDescriptor *v73; // r8
			//   MessageDescriptor *v74; // r9
			//   BloomBlendModeParameter *v75; // rax
			//   BloomBlendModeParameter *v76; // rdi
			//   OneofDescriptorProto *v77; // rdx
			//   FileDescriptor *v78; // r8
			//   MessageDescriptor *v79; // r9
			//   BoolParameter *v80; // rax
			//   BoolParameter *v81; // rdi
			//   OneofDescriptorProto *v82; // rdx
			//   FileDescriptor *v83; // r8
			//   MessageDescriptor *v84; // r9
			//   FloatParameter *v85; // rax
			//   FloatParameter *v86; // rdi
			//   OneofDescriptorProto *v87; // rdx
			//   FileDescriptor *v88; // r8
			//   MessageDescriptor *v89; // r9
			//   ClampedFloatParameter *v90; // rax
			//   ClampedFloatParameter *v91; // rdi
			//   OneofDescriptorProto *v92; // rdx
			//   FileDescriptor *v93; // r8
			//   MessageDescriptor *v94; // r9
			//   ClampedFloatParameter *v95; // rax
			//   ClampedFloatParameter *v96; // rdi
			//   OneofDescriptorProto *v97; // rdx
			//   FileDescriptor *v98; // r8
			//   MessageDescriptor *v99; // r9
			//   Texture2DParameter *v100; // rax
			//   Texture2DParameter *v101; // rdi
			//   OneofDescriptorProto *v102; // rdx
			//   FileDescriptor *v103; // r8
			//   MessageDescriptor *v104; // r9
			//   FloatParameter *v105; // rax
			//   FloatParameter *v106; // rdi
			//   OneofDescriptorProto *v107; // rdx
			//   FileDescriptor *v108; // r8
			//   MessageDescriptor *v109; // r9
			//   BoolParameter *v110; // rax
			//   BoolParameter *v111; // rdi
			//   OneofDescriptorProto *v112; // rdx
			//   FileDescriptor *v113; // r8
			//   MessageDescriptor *v114; // r9
			//   String__Array *overrideState; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStatea; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStateb; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStatec; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStated; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStatee; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStatef; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStaten; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStateo; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStatep; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStateq; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStater; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStates; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStateg; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStateh; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStatei; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStatej; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStatet; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStateu; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStatek; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStatel; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStatem; // [rsp+20h] [rbp-48h]
			//   MethodInfo *methoda; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodb; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodc; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodd; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methode; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodf; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodg; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodo; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodp; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodq; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodr; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methods; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodt; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodh; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodi; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodj; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodk; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodu; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodv; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodl; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodm; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodn; // [rsp+28h] [rbp-40h]
			//   Vector4 v159; // [rsp+30h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D8ED9BE )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::BloomBlendModeParameter);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::BloomQualityParameter);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::BloomResolutionParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::BoolParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ColorParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::MinFloatParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::Texture2DParameter);
			//     byte_18D8ED9BE = 1;
			//   }
			//   v3 = (BloomQualityParameter *)sub_180004920(TypeInfo::HG::Rendering::Runtime::BloomQualityParameter);
			//   v6 = v3;
			//   if ( !v3 )
			//     goto LABEL_28;
			//   HG::Rendering::Runtime::BloomQualityParameter::BloomQualityParameter(v3, BloomQuality__Enum_High, 0, 0LL);
			//   this.fields.quality = v6;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.quality,
			//     v7,
			//     v8,
			//     v9,
			//     overrideState,
			//     (String *)methoda,
			//     *(MethodInfo **)&v159.x);
			//   v10 = (BloomResolutionParameter *)sub_180004920(TypeInfo::HG::Rendering::Runtime::BloomResolutionParameter);
			//   v11 = v10;
			//   if ( !v10 )
			//     goto LABEL_28;
			//   HG::Rendering::Runtime::BloomResolutionParameter::BloomResolutionParameter(v10, BloomResolution__Enum_Half, 1, 0LL);
			//   this.fields.resolutionHighQuality = v11;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.resolutionHighQuality,
			//     v12,
			//     v13,
			//     v14,
			//     overrideStatea,
			//     (String *)methodb,
			//     *(MethodInfo **)&v159.x);
			//   v15 = (BloomResolutionParameter *)sub_180004920(TypeInfo::HG::Rendering::Runtime::BloomResolutionParameter);
			//   v16 = v15;
			//   if ( !v15 )
			//     goto LABEL_28;
			//   HG::Rendering::Runtime::BloomResolutionParameter::BloomResolutionParameter(v15, BloomResolution__Enum_Quarter, 1, 0LL);
			//   this.fields.resolutionMedQuality = v16;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.resolutionMedQuality,
			//     v17,
			//     v18,
			//     v19,
			//     overrideStateb,
			//     (String *)methodc,
			//     *(MethodInfo **)&v159.x);
			//   v20 = (BloomResolutionParameter *)sub_180004920(TypeInfo::HG::Rendering::Runtime::BloomResolutionParameter);
			//   v21 = v20;
			//   if ( !v20 )
			//     goto LABEL_28;
			//   HG::Rendering::Runtime::BloomResolutionParameter::BloomResolutionParameter(v20, BloomResolution__Enum_Quarter, 1, 0LL);
			//   this.fields.resolutionLowQuality = v21;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.resolutionLowQuality,
			//     v22,
			//     v23,
			//     v24,
			//     overrideStatec,
			//     (String *)methodd,
			//     *(MethodInfo **)&v159.x);
			//   v25 = (FloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::MinFloatParameter);
			//   v26 = v25;
			//   if ( !v25 )
			//     goto LABEL_28;
			//   UnityEngine::Rendering::FloatParameter::FloatParameter(v25, 0.0, 1, 0LL);
			//   LODWORD(v26[1].klass) = 0;
			//   this.fields.thresholdHighQuality = (MinFloatParameter *)v26;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.thresholdHighQuality,
			//     v27,
			//     v28,
			//     v29,
			//     overrideStated,
			//     (String *)methode,
			//     *(MethodInfo **)&v159.x);
			//   v30 = (FloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::MinFloatParameter);
			//   v31 = v30;
			//   if ( !v30 )
			//     goto LABEL_28;
			//   UnityEngine::Rendering::FloatParameter::FloatParameter(v30, 0.0, 1, 0LL);
			//   LODWORD(v31[1].klass) = 0;
			//   this.fields.thresholdMedQuality = (MinFloatParameter *)v31;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.thresholdMedQuality,
			//     v32,
			//     v33,
			//     v34,
			//     overrideStatee,
			//     (String *)methodf,
			//     *(MethodInfo **)&v159.x);
			//   v35 = (FloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::MinFloatParameter);
			//   v36 = v35;
			//   if ( !v35 )
			//     goto LABEL_28;
			//   UnityEngine::Rendering::FloatParameter::FloatParameter(v35, 0.0, 1, 0LL);
			//   LODWORD(v36[1].klass) = 0;
			//   this.fields.thresholdLowQuality = (MinFloatParameter *)v36;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.thresholdLowQuality,
			//     v37,
			//     v38,
			//     v39,
			//     overrideStatef,
			//     (String *)methodg,
			//     *(MethodInfo **)&v159.x);
			//   v40 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v41 = v40;
			//   if ( !v40 )
			//     goto LABEL_28;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v40, 0.0, 0.0, 1.0, 1, 0LL);
			//   this.fields.intensityHighQuality = v41;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.intensityHighQuality,
			//     v42,
			//     v43,
			//     v44,
			//     overrideStaten,
			//     (String *)methodo,
			//     *(MethodInfo **)&v159.x);
			//   v45 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v46 = v45;
			//   if ( !v45 )
			//     goto LABEL_28;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v45, 0.0, 0.0, 1.0, 1, 0LL);
			//   this.fields.intensityMedQuality = v46;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.intensityMedQuality,
			//     v47,
			//     v48,
			//     v49,
			//     overrideStateo,
			//     (String *)methodp,
			//     *(MethodInfo **)&v159.x);
			//   v50 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v51 = v50;
			//   if ( !v50 )
			//     goto LABEL_28;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v50, 0.0, 0.0, 1.0, 1, 0LL);
			//   this.fields.intensityLowQuality = v51;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.intensityLowQuality,
			//     v52,
			//     v53,
			//     v54,
			//     overrideStatep,
			//     (String *)methodq,
			//     *(MethodInfo **)&v159.x);
			//   v55 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v56 = v55;
			//   if ( !v55 )
			//     goto LABEL_28;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v55, 0.69999999, 0.0, 1.0, 1, 0LL);
			//   this.fields.scatterHighQuality = v56;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.scatterHighQuality,
			//     v57,
			//     v58,
			//     v59,
			//     overrideStateq,
			//     (String *)methodr,
			//     *(MethodInfo **)&v159.x);
			//   v60 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v61 = v60;
			//   if ( !v60 )
			//     goto LABEL_28;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v60, 0.69999999, 0.0, 1.0, 1, 0LL);
			//   this.fields.scatterMedQuality = v61;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.scatterMedQuality,
			//     v62,
			//     v63,
			//     v64,
			//     overrideStater,
			//     (String *)methods,
			//     *(MethodInfo **)&v159.x);
			//   v65 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v66 = v65;
			//   if ( !v65 )
			//     goto LABEL_28;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v65, 0.69999999, 0.0, 1.0, 1, 0LL);
			//   this.fields.scatterLowQuality = v66;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.scatterLowQuality,
			//     v67,
			//     v68,
			//     v69,
			//     overrideStates,
			//     (String *)methodt,
			//     *(MethodInfo **)&v159.x);
			//   v71 = *UnityEngine::Vector4::get_one(&v159, v70);
			//   v72 = sub_180004920(TypeInfo::UnityEngine::Rendering::ColorParameter);
			//   if ( !v72 )
			//     goto LABEL_28;
			//   if ( !byte_18D8F3661 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Color>::VolumeParameter);
			//     byte_18D8F3661 = 1;
			//   }
			//   *(Vector4 *)(v72 + 24) = v71;
			//   *(_WORD *)(v72 + 40) = 0;
			//   *(_BYTE *)(v72 + 42) = 1;
			//   *(_BYTE *)(v72 + 16) = 0;
			//   this.fields.tint = (ColorParameter *)v72;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.tint,
			//     v4,
			//     v73,
			//     v74,
			//     overrideStateg,
			//     (String *)methodh,
			//     *(MethodInfo **)&v159.x);
			//   v75 = (BloomBlendModeParameter *)sub_180004920(TypeInfo::HG::Rendering::Runtime::BloomBlendModeParameter);
			//   v76 = v75;
			//   if ( !v75 )
			//     goto LABEL_28;
			//   HG::Rendering::Runtime::BloomBlendModeParameter::BloomBlendModeParameter(v75, BloomBlendMode__Enum_Add, 0, 0LL);
			//   this.fields.blendMode = v76;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.blendMode,
			//     v77,
			//     v78,
			//     v79,
			//     overrideStateh,
			//     (String *)methodi,
			//     *(MethodInfo **)&v159.x);
			//   v80 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v81 = v80;
			//   if ( !v80 )
			//     goto LABEL_28;
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v80, 0, 0, 0LL);
			//   this.fields.characterBloomControl = v81;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.characterBloomControl,
			//     v82,
			//     v83,
			//     v84,
			//     overrideStatei,
			//     (String *)methodj,
			//     *(MethodInfo **)&v159.x);
			//   v85 = (FloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::MinFloatParameter);
			//   v86 = v85;
			//   if ( !v85 )
			//     goto LABEL_28;
			//   UnityEngine::Rendering::FloatParameter::FloatParameter(v85, 0.5, 1, 0LL);
			//   LODWORD(v86[1].klass) = 0;
			//   this.fields.characterThreshold = (MinFloatParameter *)v86;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.characterThreshold,
			//     v87,
			//     v88,
			//     v89,
			//     overrideStatej,
			//     (String *)methodk,
			//     *(MethodInfo **)&v159.x);
			//   v90 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v91 = v90;
			//   if ( !v90 )
			//     goto LABEL_28;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v90, 0.5, 0.0, 1.0, 1, 0LL);
			//   this.fields.characterSoftness = v91;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.characterSoftness,
			//     v92,
			//     v93,
			//     v94,
			//     overrideStatet,
			//     (String *)methodu,
			//     *(MethodInfo **)&v159.x);
			//   v95 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v96 = v95;
			//   if ( !v95 )
			//     goto LABEL_28;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v95, 1.0, 0.0, 5.0, 1, 0LL);
			//   this.fields.characterIntensity = v96;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.characterIntensity,
			//     v97,
			//     v98,
			//     v99,
			//     overrideStateu,
			//     (String *)methodv,
			//     *(MethodInfo **)&v159.x);
			//   v100 = (Texture2DParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::Texture2DParameter);
			//   v101 = v100;
			//   if ( !v100 )
			//     goto LABEL_28;
			//   UnityEngine::Rendering::Texture2DParameter::Texture2DParameter(v100, 0LL, 0, 0LL);
			//   this.fields.dirtTexture = v101;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.dirtTexture,
			//     v102,
			//     v103,
			//     v104,
			//     overrideStatek,
			//     (String *)methodl,
			//     *(MethodInfo **)&v159.x);
			//   v105 = (FloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::MinFloatParameter);
			//   v106 = v105;
			//   if ( !v105
			//     || (UnityEngine::Rendering::FloatParameter::FloatParameter(v105, 0.0, 0, 0LL),
			//         LODWORD(v106[1].klass) = 0,
			//         this.fields.dirtIntensity = (MinFloatParameter *)v106,
			//         sub_1800054D0(
			//           (OneofDescriptor *)&this.fields.dirtIntensity,
			//           v107,
			//           v108,
			//           v109,
			//           overrideStatel,
			//           (String *)methodm,
			//           *(MethodInfo **)&v159.x),
			//         v110 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter),
			//         (v111 = v110) == 0LL) )
			//   {
			// LABEL_28:
			//     sub_180B536AC(v5, v4);
			//   }
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v110, 1, 0, 0LL);
			//   this.fields.anamorphic = v111;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.anamorphic,
			//     v112,
			//     v113,
			//     v114,
			//     overrideStatem,
			//     (String *)methodn,
			//     *(MethodInfo **)&v159.x);
			//   UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
			// }
			// 
		}

		public bool IsActive()
		{
			// // Boolean IsActive()
			// bool HG::Rendering::Runtime::Bloom::IsActive(Bloom *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2212, 0LL) )
			//     return HG::Rendering::Runtime::Bloom::get_intensity(this, 0LL) > 0.0;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2212, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		[Header("Bloom")]
		public BloomQualityParameter quality;

		public BloomResolutionParameter resolutionHighQuality;

		public BloomResolutionParameter resolutionMedQuality;

		public BloomResolutionParameter resolutionLowQuality;

		[Tooltip("Set the level of brightness to filter out pixels under this level. This value is expressed in gamma-space. A value above 0 will disregard energy conservation rules.")]
		public MinFloatParameter thresholdHighQuality;

		public MinFloatParameter thresholdMedQuality;

		public MinFloatParameter thresholdLowQuality;

		[Tooltip("Controls the strength of the bloom filter.")]
		public ClampedFloatParameter intensityHighQuality;

		public ClampedFloatParameter intensityMedQuality;

		public ClampedFloatParameter intensityLowQuality;

		[Tooltip("Set the radius of the bloom effect")]
		public ClampedFloatParameter scatterHighQuality;

		public ClampedFloatParameter scatterMedQuality;

		public ClampedFloatParameter scatterLowQuality;

		[Tooltip("Use the color picker to select a color for the Bloom effect to tint to.")]
		public ColorParameter tint;

		[Tooltip("Determine the blend mode of scene color and bloom color.(Default is Add mode)")]
		public BloomBlendModeParameter blendMode;

		[Tooltip("When enabled, use character mask to control different params with env and character.")]
		[Header("Character Bloom Control")]
		public BoolParameter characterBloomControl;

		[Tooltip("Threshold of the character bloom")]
		public MinFloatParameter characterThreshold;

		[Tooltip("Softness of the character bloom")]
		[HideInInspector]
		public ClampedFloatParameter characterSoftness;

		[Tooltip("Intensity multiplier of the character bloom")]
		public ClampedFloatParameter characterIntensity;

		[Header("Lens Dirt")]
		[Tooltip("Specifies a Texture to add smudges or dust to the bloom effect.")]
		public Texture2DParameter dirtTexture;

		[Tooltip("Controls the strength of the lens dirt.")]
		public MinFloatParameter dirtIntensity;

		[AdditionalProperty]
		[Tooltip("When enabled, bloom stretches horizontally depending on the current physical Camera's Anamorphism property value.")]
		public BoolParameter anamorphic;
	}
}
