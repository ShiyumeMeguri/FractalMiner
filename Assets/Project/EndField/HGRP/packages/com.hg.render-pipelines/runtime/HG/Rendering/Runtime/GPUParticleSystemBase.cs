using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	internal class GPUParticleSystemBase
	{
		// (get) Token: 0x06000795 RID: 1941 RVA: 0x00002608 File Offset: 0x00000808
		private int particleCapacity
		{
			get
			{
				// // Int32 get_bindingId()
				// int32_t Beyond::Input::UIEvent<System::Object,System::Object>::get_bindingId(
				//         UIEvent_2_System_Object_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._bindingId_k__BackingField;
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x06000796 RID: 1942 RVA: 0x00002608 File Offset: 0x00000808
		private int particleAttribSize
		{
			get
			{
				// // Int32 get_defaultArea()
				// int32_t UnityEngine::AI::NavMeshSurface::get_defaultArea(NavMeshSurface *this, MethodInfo *method)
				// {
				//   return this.fields.m_DefaultArea;
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x06000797 RID: 1943 RVA: 0x00002608 File Offset: 0x00000808
		private int instanceCapacity
		{
			get
			{
				// // Int32 get_bindingId()
				// int32_t Beyond::Input::UIEvent<System::Object>::get_bindingId(UIEvent_1_System_Object_ *this, MethodInfo *method)
				// {
				//   return this.fields._bindingId_k__BackingField;
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x06000798 RID: 1944 RVA: 0x00002608 File Offset: 0x00000808
		private int maxParticleCount
		{
			get
			{
				// // Int32 get_maxParticleCount()
				// int32_t HG::Rendering::Runtime::GPUParticleSystemBase::get_maxParticleCount(
				//         GPUParticleSystemBase *this,
				//         MethodInfo *method)
				// {
				//   return this.fields.m_generalSystemAttributes.particleCapacity
				//        * this.fields.m_generalSystemAttributes.instanceCapacity;
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x06000799 RID: 1945 RVA: 0x00002608 File Offset: 0x00000808
		private int fixedParticleAttribSize
		{
			get
			{
				// // UInt32 get_capacity()
				// uint32_t UnityEngine::Rendering::BitArray32::get_capacity(BitArray32 *this, MethodInfo *method)
				// {
				//   return 32;
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x0600079A RID: 1946 RVA: 0x00002608 File Offset: 0x00000808
		internal int maxAvailableParticleCount
		{
			get
			{
				// // Int32 get_maxAvailableParticleCount()
				// int32_t HG::Rendering::Runtime::GPUParticleSystemBase::get_maxAvailableParticleCount(
				//         GPUParticleSystemBase *this,
				//         MethodInfo *method)
				// {
				//   return this.fields.m_generalSystemAttributes.particleCapacity * this.fields.m_gpuInstanceCount;
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x0600079B RID: 1947 RVA: 0x00002608 File Offset: 0x00000808
		internal int gpuInstanceCount
		{
			get
			{
				// // Int32 get_pressedButtons()
				// int32_t UnityEngine::UIElements::PointerEventBase<System::Object>::get_pressedButtons(
				//         PointerEventBase_1_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._pressedButtons_k__BackingField;
				// }
				// 
				return 0;
			}
		}

		protected GPUParticleSystemBase()
		{
		}

		protected GPUParticleSystemBase(in GPUParticleShaders shaders, in GeneralSystemAttributes generalSystemAttributes, in Nullable<OptionalSystemFeatures> optionalSystemFeatures, Material material)
		{
			// // GPUParticleSystemBase(GPUParticleShaders&, GeneralSystemAttributes&, Nullable`1[HG.Rendering.Runtime.OptionalSystemFeatures]&, Material)
			// void HG::Rendering::Runtime::GPUParticleSystemBase::GPUParticleSystemBase(
			//         GPUParticleSystemBase *this,
			//         GPUParticleShaders *shaders,
			//         GeneralSystemAttributes *generalSystemAttributes,
			//         Nullable_1_HG_Rendering_Runtime_OptionalSystemFeatures_ *optionalSystemFeatures,
			//         Material *material,
			//         MethodInfo *method)
			// {
			//   GeneralSystemAttributes v10; // xmm0
			//   OneofDescriptorProto *v11; // rdx
			//   FileDescriptor *v12; // r8
			//   int32_t instanceCapacity; // esi
			//   __int128 v14; // xmm1
			//   __int128 v15; // xmm2
			//   List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *v16; // rax
			//   __int64 v17; // rdx
			//   List_1_System_Int32_ *m_perInstanceData; // rcx
			//   List_1_HG_Rendering_Runtime_PerInstanceData_ *v19; // rdi
			//   OneofDescriptorProto *v20; // rdx
			//   FileDescriptor *v21; // r8
			//   MessageDescriptor *v22; // r9
			//   int32_t v23; // esi
			//   List_1_System_Int32_ *v24; // rax
			//   List_1_System_Int32_ *v25; // rdi
			//   OneofDescriptorProto *v26; // rdx
			//   FileDescriptor *v27; // r8
			//   MessageDescriptor *v28; // r9
			//   int32_t v29; // esi
			//   List_1_System_Int32_ *v30; // rax
			//   List_1_System_Int32_ *v31; // rdi
			//   OneofDescriptorProto *v32; // rdx
			//   FileDescriptor *v33; // r8
			//   MessageDescriptor *v34; // r9
			//   int32_t v35; // edi
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v36; // rax
			//   List_1_System_Int32_ *v37; // rdi
			//   OneofDescriptorProto *v38; // rdx
			//   FileDescriptor *v39; // r8
			//   MessageDescriptor *v40; // r9
			//   int32_t v41; // esi
			//   ComputeBuffer *v42; // rax
			//   ComputeBuffer *v43; // rdi
			//   OneofDescriptorProto *v44; // rdx
			//   FileDescriptor *v45; // r8
			//   MessageDescriptor *v46; // r9
			//   ComputeBuffer *v47; // rax
			//   ComputeBuffer *v48; // rdi
			//   OneofDescriptorProto *v49; // rdx
			//   FileDescriptor *v50; // r8
			//   MessageDescriptor *v51; // r9
			//   ComputeBuffer *v52; // rax
			//   ComputeBuffer *v53; // rdi
			//   OneofDescriptorProto *v54; // rdx
			//   FileDescriptor *v55; // r8
			//   MessageDescriptor *v56; // r9
			//   int32_t particleCapacity; // r14d
			//   int32_t v58; // edi
			//   int32_t particleAttribSize; // r15d
			//   ComputeBuffer *v60; // rax
			//   ComputeBuffer *v61; // rsi
			//   OneofDescriptorProto *v62; // rdx
			//   FileDescriptor *v63; // r8
			//   MessageDescriptor *v64; // r9
			//   int32_t v65; // r14d
			//   int32_t v66; // edi
			//   ComputeBuffer *v67; // rax
			//   ComputeBuffer *v68; // rsi
			//   OneofDescriptorProto *v69; // rdx
			//   FileDescriptor *v70; // r8
			//   MessageDescriptor *v71; // r9
			//   int32_t v72; // r14d
			//   int32_t v73; // edi
			//   ComputeBuffer *v74; // rax
			//   ComputeBuffer *v75; // rsi
			//   OneofDescriptorProto *v76; // rdx
			//   FileDescriptor *v77; // r8
			//   MessageDescriptor *v78; // r9
			//   int32_t v79; // esi
			//   ComputeBuffer *v80; // rax
			//   ComputeBuffer *v81; // rdi
			//   OneofDescriptorProto *v82; // rdx
			//   FileDescriptor *v83; // r8
			//   MessageDescriptor *v84; // r9
			//   GraphicsBuffer *v85; // rax
			//   GraphicsBuffer *v86; // rdi
			//   OneofDescriptorProto *v87; // rdx
			//   FileDescriptor *v88; // r8
			//   MessageDescriptor *v89; // r9
			//   Void *m_Buffer; // rax
			//   MethodInfo *v91; // [rsp+28h] [rbp-89h]
			//   MethodInfo *v92; // [rsp+28h] [rbp-89h]
			//   MethodInfo *v93; // [rsp+28h] [rbp-89h]
			//   MethodInfo *v94; // [rsp+28h] [rbp-89h]
			//   MethodInfo *v95; // [rsp+28h] [rbp-89h]
			//   MethodInfo *v96; // [rsp+28h] [rbp-89h]
			//   MethodInfo *v97; // [rsp+28h] [rbp-89h]
			//   MethodInfo *v98; // [rsp+28h] [rbp-89h]
			//   MethodInfo *v99; // [rsp+28h] [rbp-89h]
			//   MethodInfo *v100; // [rsp+28h] [rbp-89h]
			//   MethodInfo *v101; // [rsp+28h] [rbp-89h]
			//   MethodInfo *v102; // [rsp+28h] [rbp-89h]
			//   MethodInfo *v103; // [rsp+28h] [rbp-89h]
			//   MethodInfo *v104; // [rsp+28h] [rbp-89h]
			//   String *v105; // [rsp+30h] [rbp-81h]
			//   String *v106; // [rsp+30h] [rbp-81h]
			//   String *v107; // [rsp+30h] [rbp-81h]
			//   String *v108; // [rsp+30h] [rbp-81h]
			//   String *v109; // [rsp+30h] [rbp-81h]
			//   String *v110; // [rsp+30h] [rbp-81h]
			//   String *v111; // [rsp+30h] [rbp-81h]
			//   String *v112; // [rsp+30h] [rbp-81h]
			//   String *v113; // [rsp+30h] [rbp-81h]
			//   String *v114; // [rsp+30h] [rbp-81h]
			//   String *v115; // [rsp+30h] [rbp-81h]
			//   String *v116; // [rsp+30h] [rbp-81h]
			//   String *v117; // [rsp+30h] [rbp-81h]
			//   String *v118; // [rsp+30h] [rbp-81h]
			//   NativeArray_1_UnityEngine_HyperGryph_ECS_EntityCommandBufferV2_VirtualEntityMap_ v119; // [rsp+38h] [rbp-79h] BYREF
			//   NativeArray_1_System_UInt32_ v120; // [rsp+48h] [rbp-69h] BYREF
			//   OptionalSystemFeatures v121; // [rsp+58h] [rbp-59h] BYREF
			//   Keyframe v122; // [rsp+88h] [rbp-29h] BYREF
			//   OptionalSystemFeatures v123; // [rsp+A8h] [rbp-9h] BYREF
			// 
			//   if ( !byte_18D919DE0 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::ComputeBuffer::SetData<HG::Rendering::Runtime::GeneralSystemAttributes>);
			//     sub_18003C530(&TypeInfo::UnityEngine::ComputeBuffer);
			//     sub_18003C530(&MethodInfo::UnityEngine::GraphicsBuffer::SetData<unsigned int>);
			//     sub_18003C530(&TypeInfo::UnityEngine::GraphicsBuffer);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::PerInstanceData>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::List);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::List);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::PerInstanceData>::List);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<int>);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::PerInstanceData>);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::GeneralSystemAttributes>::NativeArray);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<unsigned int>::NativeArray);
			//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::Runtime::GPUEventFeature>::get_HasValue);
			//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::Runtime::OptionalSystemFeatures>::get_HasValue);
			//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::Runtime::GPUEventSender>::get_HasValue);
			//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::Runtime::GPUEventFeature>::get_Value);
			//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::Runtime::GPUEventSender>::get_Value);
			//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::Runtime::OptionalSystemFeatures>::get_Value);
			//     byte_18D919DE0 = 1;
			//   }
			//   v119 = 0LL;
			//   v10 = *generalSystemAttributes;
			//   v120 = 0LL;
			//   this.fields.m_generalSystemAttributes = v10;
			//   this.fields.m_generalSystemAttributes.particleAttribSize += 32;
			//   if ( optionalSystemFeatures.hasValue )
			//   {
			//     System::Nullable<HG::Rendering::Runtime::OptionalSystemFeatures>::get_Value(
			//       &v121,
			//       optionalSystemFeatures,
			//       MethodInfo::System::Nullable<HG::Rendering::Runtime::OptionalSystemFeatures>::get_Value);
			//     v123 = v121;
			//     if ( _mm_srli_si128(*(__m128i *)&v121, 8).m128i_i8[4] )
			//     {
			//       System::Nullable<UnityEngine::Keyframe>::get_Value(
			//         &v122,
			//         (Nullable_1_UnityEngine_Keyframe_ *)&v123.gpuEventFeature,
			//         MethodInfo::System::Nullable<HG::Rendering::Runtime::GPUEventFeature>::get_Value);
			//       *(_OWORD *)&v121.sceneRTFeature.hasValue = *(_OWORD *)&v122.m_Time;
			//       *(float *)&v121.gpuEventFeature.value.guid._d = v122.m_OutWeight;
			//       *(_QWORD *)&v121.gpuEventFeature.value.guid._a = *(_QWORD *)&v122.m_WeightedMode;
			//       if ( LOBYTE(v122.m_WeightedMode) )
			//         this.fields.m_generalSystemAttributes.padding0 = *(_QWORD *)&System::Nullable<Beyond::Gameplay::Core::ProjectileComponent::FinishOptions>::get_Value(
			//                                                                         (Nullable_1_Beyond_Gameplay_Core_ProjectileComponent_FinishOptions_ *)&v121.gpuEventFeature.value,
			//                                                                         MethodInfo::System::Nullable<HG::Rendering::Runtime::GPUEventSender>::get_Value);
			//     }
			//   }
			//   this.fields.m_shaders = *shaders;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.m_shaders,
			//     (OneofDescriptorProto *)shaders,
			//     (FileDescriptor *)generalSystemAttributes,
			//     (MessageDescriptor *)optionalSystemFeatures,
			//     (String__Array *)v91,
			//     v105,
			//     (MethodInfo *)v119.m_Buffer);
			//   this.fields.m_material = material;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.m_material,
			//     v11,
			//     v12,
			//     (MessageDescriptor *)material,
			//     (String__Array *)v92,
			//     v106,
			//     (MethodInfo *)v119.m_Buffer);
			//   instanceCapacity = this.fields.m_generalSystemAttributes.instanceCapacity;
			//   v14 = *(_OWORD *)&optionalSystemFeatures.value.gpuEventFeature.hasValue;
			//   v15 = *(_OWORD *)&optionalSystemFeatures.value.gpuEventFeature.value.guid._h;
			//   *(_OWORD *)&this.fields.optionalSystemFeatures.hasValue = *(_OWORD *)&optionalSystemFeatures.hasValue;
			//   *(_OWORD *)&this.fields.optionalSystemFeatures.value.gpuEventFeature.hasValue = v14;
			//   *(_OWORD *)&this.fields.optionalSystemFeatures.value.gpuEventFeature.value.guid._h = v15;
			//   v16 = (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::PerInstanceData>);
			//   v19 = (List_1_HG_Rendering_Runtime_PerInstanceData_ *)v16;
			//   if ( !v16 )
			//     goto LABEL_27;
			//   System::Collections::Generic::List<Beyond::Gameplay::Core::AbilitySystem_ComboController_MappingModifier::Handle>::List(
			//     v16,
			//     instanceCapacity,
			//     MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::PerInstanceData>::List);
			//   this.fields.m_perInstanceData = v19;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.m_perInstanceData,
			//     v20,
			//     v21,
			//     v22,
			//     (String__Array *)v93,
			//     v107,
			//     (MethodInfo *)v119.m_Buffer);
			//   v23 = this.fields.m_generalSystemAttributes.instanceCapacity;
			//   v24 = (List_1_System_Int32_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<int>);
			//   v25 = v24;
			//   if ( !v24 )
			//     goto LABEL_27;
			//   System::Collections::Generic::List<int>::List(v24, v23, MethodInfo::System::Collections::Generic::List<int>::List);
			//   this.fields.m_instances = v25;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.m_instances,
			//     v26,
			//     v27,
			//     v28,
			//     (String__Array *)v94,
			//     v108,
			//     (MethodInfo *)v119.m_Buffer);
			//   v29 = this.fields.m_generalSystemAttributes.instanceCapacity;
			//   v30 = (List_1_System_Int32_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<int>);
			//   v31 = v30;
			//   if ( !v30 )
			//     goto LABEL_27;
			//   System::Collections::Generic::List<int>::List(v30, v29, MethodInfo::System::Collections::Generic::List<int>::List);
			//   this.fields.m_freePool = v31;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.m_freePool,
			//     v32,
			//     v33,
			//     v34,
			//     (String__Array *)v95,
			//     v109,
			//     (MethodInfo *)v119.m_Buffer);
			//   v35 = 0;
			//   if ( this.fields.m_generalSystemAttributes.instanceCapacity > 0 )
			//   {
			//     while ( 1 )
			//     {
			//       m_perInstanceData = (List_1_System_Int32_ *)this.fields.m_perInstanceData;
			//       if ( !m_perInstanceData )
			//         break;
			//       memset(&v121, 0, 32);
			//       sub_18043E414(
			//         m_perInstanceData,
			//         &v121,
			//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::PerInstanceData>::Add);
			//       m_perInstanceData = this.fields.m_instances;
			//       if ( !m_perInstanceData )
			//         break;
			//       sub_18231EF50(m_perInstanceData, -1);
			//       m_perInstanceData = this.fields.m_freePool;
			//       if ( !m_perInstanceData )
			//         break;
			//       sub_18231EF50(m_perInstanceData, this.fields.m_generalSystemAttributes.instanceCapacity - v35++ - 1);
			//       if ( v35 >= this.fields.m_generalSystemAttributes.instanceCapacity )
			//         goto LABEL_15;
			//     }
			// LABEL_27:
			//     sub_180B536AC(m_perInstanceData, v17);
			//   }
			// LABEL_15:
			//   v36 = (List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<int>);
			//   v37 = (List_1_System_Int32_ *)v36;
			//   if ( !v36 )
			//     goto LABEL_27;
			//   System::Collections::Generic::List<Beyond::Gameplay::ZhuangfySleeveSolver::BoneData>::List(
			//     v36,
			//     MethodInfo::System::Collections::Generic::List<int>::List);
			//   this.fields.m_instancesToClear = v37;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.m_instancesToClear,
			//     v38,
			//     v39,
			//     v40,
			//     (String__Array *)v96,
			//     v110,
			//     (MethodInfo *)v119.m_Buffer);
			//   v41 = this.fields.m_generalSystemAttributes.instanceCapacity;
			//   this.fields.m_gpuInstanceCount = 0;
			//   v42 = (ComputeBuffer *)sub_180004920(TypeInfo::UnityEngine::ComputeBuffer);
			//   v43 = v42;
			//   if ( !v42 )
			//     goto LABEL_27;
			//   UnityEngine::ComputeBuffer::ComputeBuffer(v42, v41, 32, ComputeBufferType__Enum_Constant, 0LL);
			//   this.fields.m_perInstanceBuffer = v43;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields,
			//     v44,
			//     v45,
			//     v46,
			//     (String__Array *)v97,
			//     v111,
			//     (MethodInfo *)v119.m_Buffer);
			//   v47 = (ComputeBuffer *)sub_180004920(TypeInfo::UnityEngine::ComputeBuffer);
			//   v48 = v47;
			//   if ( !v47 )
			//     goto LABEL_27;
			//   UnityEngine::ComputeBuffer::ComputeBuffer(v47, 1, 16, ComputeBufferType__Enum_Constant, 0LL);
			//   this.fields.m_generalSystemAttributeBuffer = v48;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.m_generalSystemAttributeBuffer,
			//     v49,
			//     v50,
			//     v51,
			//     (String__Array *)v98,
			//     v112,
			//     (MethodInfo *)v119.m_Buffer);
			//   v52 = (ComputeBuffer *)sub_180004920(TypeInfo::UnityEngine::ComputeBuffer);
			//   v53 = v52;
			//   if ( !v52 )
			//     goto LABEL_27;
			//   UnityEngine::ComputeBuffer::ComputeBuffer(v52, 1, 20, ComputeBufferType__Enum_DrawIndirect, 0LL);
			//   this.fields.m_drawIndirectArgsBuffer = v53;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.m_drawIndirectArgsBuffer,
			//     v54,
			//     v55,
			//     v56,
			//     (String__Array *)v99,
			//     v113,
			//     (MethodInfo *)v119.m_Buffer);
			//   particleCapacity = this.fields.m_generalSystemAttributes.particleCapacity;
			//   v58 = this.fields.m_generalSystemAttributes.instanceCapacity;
			//   particleAttribSize = this.fields.m_generalSystemAttributes.particleAttribSize;
			//   v60 = (ComputeBuffer *)sub_180004920(TypeInfo::UnityEngine::ComputeBuffer);
			//   v61 = v60;
			//   if ( !v60 )
			//     goto LABEL_27;
			//   UnityEngine::ComputeBuffer::ComputeBuffer(
			//     v60,
			//     particleAttribSize * particleCapacity * v58 / 16,
			//     16,
			//     ComputeBufferType__Enum_Structured,
			//     0LL);
			//   this.fields.m_particleAttributesBuffer = v61;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.m_particleAttributesBuffer,
			//     v62,
			//     v63,
			//     v64,
			//     (String__Array *)v100,
			//     v114,
			//     (MethodInfo *)v119.m_Buffer);
			//   v65 = this.fields.m_generalSystemAttributes.particleCapacity;
			//   v66 = this.fields.m_generalSystemAttributes.instanceCapacity;
			//   v67 = (ComputeBuffer *)sub_180004920(TypeInfo::UnityEngine::ComputeBuffer);
			//   v68 = v67;
			//   if ( !v67 )
			//     goto LABEL_27;
			//   UnityEngine::ComputeBuffer::ComputeBuffer(v67, v65 * v66, 4, ComputeBufferType__Enum_Default, 0LL);
			//   this.fields.m_liveListBuffer = v68;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.m_liveListBuffer,
			//     v69,
			//     v70,
			//     v71,
			//     (String__Array *)v101,
			//     v115,
			//     (MethodInfo *)v119.m_Buffer);
			//   v72 = this.fields.m_generalSystemAttributes.particleCapacity;
			//   v73 = this.fields.m_generalSystemAttributes.instanceCapacity;
			//   v74 = (ComputeBuffer *)sub_180004920(TypeInfo::UnityEngine::ComputeBuffer);
			//   v75 = v74;
			//   if ( !v74 )
			//     goto LABEL_27;
			//   UnityEngine::ComputeBuffer::ComputeBuffer(v74, v72 * v73, 4, ComputeBufferType__Enum_Default, 0LL);
			//   this.fields.m_deadListBuffer = v75;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.m_deadListBuffer,
			//     v76,
			//     v77,
			//     v78,
			//     (String__Array *)v102,
			//     v116,
			//     (MethodInfo *)v119.m_Buffer);
			//   v79 = this.fields.m_generalSystemAttributes.instanceCapacity;
			//   v80 = (ComputeBuffer *)sub_180004920(TypeInfo::UnityEngine::ComputeBuffer);
			//   v81 = v80;
			//   if ( !v80 )
			//     goto LABEL_27;
			//   UnityEngine::ComputeBuffer::ComputeBuffer(v80, v79, 4, ComputeBufferType__Enum_Default, 0LL);
			//   this.fields.m_deadCountBuffer = v81;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.m_deadCountBuffer,
			//     v82,
			//     v83,
			//     v84,
			//     (String__Array *)v103,
			//     v117,
			//     (MethodInfo *)v119.m_Buffer);
			//   v85 = (GraphicsBuffer *)sub_180004920(TypeInfo::UnityEngine::GraphicsBuffer);
			//   v86 = v85;
			//   if ( !v85 )
			//     goto LABEL_27;
			//   UnityEngine::GraphicsBuffer::GraphicsBuffer(v85, GraphicsBuffer_Target__Enum_Index, 6, 4, 0LL);
			//   this.fields.m_quadIndexBuffer = v86;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.m_quadIndexBuffer,
			//     v87,
			//     v88,
			//     v89,
			//     (String__Array *)v104,
			//     v118,
			//     (MethodInfo *)v119.m_Buffer);
			//   Unity::Collections::NativeArray<UnityEngine::HyperGryph::ECS::EntityCommandBufferV2::VirtualEntityMap>::NativeArray(
			//     &v119,
			//     1,
			//     Allocator__Enum_Temp,
			//     NativeArrayOptions__Enum_ClearMemory,
			//     MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::GeneralSystemAttributes>::NativeArray);
			//   *(GeneralSystemAttributes *)v119.m_Buffer = this.fields.m_generalSystemAttributes;
			//   m_perInstanceData = (List_1_System_Int32_ *)this.fields.m_generalSystemAttributeBuffer;
			//   if ( !m_perInstanceData )
			//     goto LABEL_27;
			//   sub_180835CD8(m_perInstanceData, &v119);
			//   Unity::Collections::NativeArray<unsigned int>::NativeArray(
			//     &v120,
			//     6,
			//     Allocator__Enum_Temp,
			//     NativeArrayOptions__Enum_ClearMemory,
			//     MethodInfo::Unity::Collections::NativeArray<unsigned int>::NativeArray);
			//   m_Buffer = v120.m_Buffer;
			//   *(_DWORD *)v120.m_Buffer = 0;
			//   *(_DWORD *)&m_Buffer[4] = 1;
			//   *(_DWORD *)&m_Buffer[8] = 2;
			//   *(_DWORD *)&m_Buffer[12] = 2;
			//   *(_DWORD *)&m_Buffer[16] = 1;
			//   *(_DWORD *)&m_Buffer[20] = 3;
			//   m_perInstanceData = (List_1_System_Int32_ *)this.fields.m_quadIndexBuffer;
			//   if ( !m_perInstanceData )
			//     goto LABEL_27;
			//   UnityEngine::GraphicsBuffer::SetData<unsigned int>(
			//     (GraphicsBuffer *)m_perInstanceData,
			//     &v120,
			//     MethodInfo::UnityEngine::GraphicsBuffer::SetData<unsigned int>);
			// }
			// 
		}

		internal virtual void Dispose()
		{
			// // Void Dispose()
			// void HG::Rendering::Runtime::GPUParticleSystemBase::Dispose(GPUParticleSystemBase *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   ComputeBuffer *m_perInstanceBuffer; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(533, 0LL) )
			//   {
			//     m_perInstanceBuffer = this.fields.m_perInstanceBuffer;
			//     if ( m_perInstanceBuffer )
			//     {
			//       UnityEngine::ComputeBuffer::Dispose(m_perInstanceBuffer, 0LL);
			//       m_perInstanceBuffer = this.fields.m_generalSystemAttributeBuffer;
			//       if ( m_perInstanceBuffer )
			//       {
			//         UnityEngine::ComputeBuffer::Dispose(m_perInstanceBuffer, 0LL);
			//         m_perInstanceBuffer = this.fields.m_particleAttributesBuffer;
			//         if ( m_perInstanceBuffer )
			//         {
			//           UnityEngine::ComputeBuffer::Dispose(m_perInstanceBuffer, 0LL);
			//           m_perInstanceBuffer = this.fields.m_liveListBuffer;
			//           if ( m_perInstanceBuffer )
			//           {
			//             UnityEngine::ComputeBuffer::Dispose(m_perInstanceBuffer, 0LL);
			//             m_perInstanceBuffer = this.fields.m_deadListBuffer;
			//             if ( m_perInstanceBuffer )
			//             {
			//               UnityEngine::ComputeBuffer::Dispose(m_perInstanceBuffer, 0LL);
			//               m_perInstanceBuffer = this.fields.m_deadCountBuffer;
			//               if ( m_perInstanceBuffer )
			//               {
			//                 UnityEngine::ComputeBuffer::Dispose(m_perInstanceBuffer, 0LL);
			//                 m_perInstanceBuffer = this.fields.m_drawIndirectArgsBuffer;
			//                 if ( m_perInstanceBuffer )
			//                 {
			//                   UnityEngine::ComputeBuffer::Dispose(m_perInstanceBuffer, 0LL);
			//                   m_perInstanceBuffer = (ComputeBuffer *)this.fields.m_quadIndexBuffer;
			//                   if ( m_perInstanceBuffer )
			//                   {
			//                     UnityEngine::GraphicsBuffer::Dispose((GraphicsBuffer *)m_perInstanceBuffer, 0LL);
			//                     return;
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_12:
			//     sub_180B536AC(m_perInstanceBuffer, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(533, 0LL);
			//   if ( !Patch )
			//     goto LABEL_12;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		protected int GetGPUIndex(int cpuIndex)
		{
			// // Int32 GetGPUIndex(Int32)
			// int32_t HG::Rendering::Runtime::GPUParticleSystemBase::GetGPUIndex(
			//         GPUParticleSystemBase *this,
			//         int32_t cpuIndex,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   List_1_System_Int32_ *m_instances; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919DE1 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//     byte_18D919DE1 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1459, 0LL) )
			//   {
			//     m_instances = this.fields.m_instances;
			//     if ( m_instances )
			//       return (int32_t)System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::get_Item(
			//                         (List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *)m_instances,
			//                         cpuIndex,
			//                         MethodInfo::System::Collections::Generic::List<int>::get_Item);
			// LABEL_7:
			//     sub_180B536AC(m_instances, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1459, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_47(
			//            (ILFixDynamicMethodWrapper_20 *)Patch,
			//            (Object *)this,
			//            cpuIndex,
			//            0LL);
			// }
			// 
			return 0;
		}

		protected virtual void OnInstanceCreated(int gpuIndex, in PerInstanceData perInstanceData)
		{
			// // Void OnInstanceCreated(Int32, PerInstanceData ByRef)
			// void HG::Rendering::Runtime::GPUParticleSystemBase::OnInstanceCreated(
			//         GPUParticleSystemBase *this,
			//         int32_t gpuIndex,
			//         PerInstanceData *perInstanceData,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   List_1_HG_Rendering_Runtime_VolumetricSHBake_FSHSampleData_ *m_perInstanceData; // rcx
			//   Vector4 v9; // xmm1
			//   int32_t emitRate; // edi
			//   int32_t m_maxParticleEmitRate; // ebx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   VolumetricSHBake_FSHSampleData v13; // [rsp+30h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D919DE2 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::ComputeBuffer::SetData<HG::Rendering::Runtime::PerInstanceData>);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::PerInstanceData>::set_Item);
			//     sub_18003C530(&TypeInfo::System::Math);
			//     byte_18D919DE2 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1460, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1460, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_552(Patch, (Object *)this, gpuIndex, perInstanceData, 0LL);
			//       return;
			//     }
			// LABEL_11:
			//     sub_180B536AC(m_perInstanceData, v7);
			//   }
			//   m_perInstanceData = (List_1_HG_Rendering_Runtime_VolumetricSHBake_FSHSampleData_ *)this.fields.m_perInstanceData;
			//   if ( !m_perInstanceData )
			//     goto LABEL_11;
			//   v9 = *(Vector4 *)&perInstanceData.emitRate;
			//   v13.Direction = perInstanceData.position;
			//   v13.SHValue = v9;
			//   System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricSHBake::FSHSampleData>::set_Item(
			//     m_perInstanceData,
			//     gpuIndex,
			//     &v13,
			//     MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::PerInstanceData>::set_Item);
			//   m_perInstanceData = (List_1_HG_Rendering_Runtime_VolumetricSHBake_FSHSampleData_ *)this.fields.m_perInstanceBuffer;
			//   if ( !m_perInstanceData )
			//     goto LABEL_11;
			//   UnityEngine::ComputeBuffer::SetData<HG::Rendering::Runtime::PerInstanceData>(
			//     (ComputeBuffer *)m_perInstanceData,
			//     this.fields.m_perInstanceData,
			//     MethodInfo::UnityEngine::ComputeBuffer::SetData<HG::Rendering::Runtime::PerInstanceData>);
			//   m_perInstanceData = (List_1_HG_Rendering_Runtime_VolumetricSHBake_FSHSampleData_ *)this.fields.m_instancesToClear;
			//   if ( !m_perInstanceData )
			//     goto LABEL_11;
			//   sub_18231EF50((List_1_System_Int32_ *)m_perInstanceData, gpuIndex);
			//   emitRate = perInstanceData.emitRate;
			//   m_maxParticleEmitRate = this.fields.m_maxParticleEmitRate;
			//   sub_180002C70(TypeInfo::System::Math);
			//   if ( emitRate < m_maxParticleEmitRate )
			//     emitRate = m_maxParticleEmitRate;
			//   this.fields.m_maxParticleEmitRate = emitRate;
			// }
			// 
		}

		protected virtual void OnInstanceRemoved(int gpuIndexToRemove, int gpuIndexToMove)
		{
			// // Void OnInstanceRemoved(Int32, Int32)
			// void HG::Rendering::Runtime::GPUParticleSystemBase::OnInstanceRemoved(
			//         GPUParticleSystemBase *this,
			//         int32_t gpuIndexToRemove,
			//         int32_t gpuIndexToMove,
			//         MethodInfo *method)
			// {
			//   ComputeBuffer *m_perInstanceBuffer; // rcx
			//   int32_t i; // edi
			//   List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *m_perInstanceData; // rdx
			//   int32_t m_maxParticleEmitRate; // ebx
			//   int32_t instId; // eax
			//   List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *v12; // rbx
			//   int32_t size; // edi
			//   ComputeBuffer *m_particleAttributesBuffer; // rsi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   AbilitySystem_ComboController_MappingModifier_Handle v16; // [rsp+30h] [rbp-58h] BYREF
			//   AbilitySystem_ComboController_MappingModifier_Handle v17; // [rsp+50h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D919DE3 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::ComputeBuffer::SetData<HG::Rendering::Runtime::PerInstanceData>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Graphics);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::PerInstanceData>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::PerInstanceData>::set_Item);
			//     sub_18003C530(&TypeInfo::System::Math);
			//     byte_18D919DE3 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1461, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1461, 0LL);
			//     if ( !Patch )
			//       goto LABEL_16;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_56(
			//       (ILFixDynamicMethodWrapper_20 *)Patch,
			//       (Object *)this,
			//       gpuIndexToRemove,
			//       gpuIndexToMove,
			//       0LL);
			//   }
			//   else
			//   {
			//     this.fields.m_maxParticleEmitRate = 0;
			//     for ( i = 0; i < this.fields.m_gpuInstanceCount; ++i )
			//     {
			//       if ( i != gpuIndexToRemove )
			//       {
			//         m_perInstanceData = (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)this.fields.m_perInstanceData;
			//         if ( !m_perInstanceData )
			//           goto LABEL_16;
			//         System::Collections::Generic::List<Beyond::Gameplay::Core::AbilitySystem_ComboController_MappingModifier::Handle>::get_Item(
			//           &v17,
			//           m_perInstanceData,
			//           i,
			//           MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::PerInstanceData>::get_Item);
			//         m_maxParticleEmitRate = this.fields.m_maxParticleEmitRate;
			//         sub_180002C70(TypeInfo::System::Math);
			//         instId = v17.instId;
			//         if ( SLODWORD(v17.instId) < m_maxParticleEmitRate )
			//           instId = m_maxParticleEmitRate;
			//         this.fields.m_maxParticleEmitRate = instId;
			//       }
			//     }
			//     if ( gpuIndexToMove != gpuIndexToRemove )
			//     {
			//       v12 = (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)this.fields.m_perInstanceData;
			//       m_perInstanceData = v12;
			//       if ( v12 )
			//       {
			//         System::Collections::Generic::List<Beyond::Gameplay::Core::AbilitySystem_ComboController_MappingModifier::Handle>::get_Item(
			//           &v16,
			//           v12,
			//           gpuIndexToMove,
			//           MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::PerInstanceData>::get_Item);
			//         v17 = v16;
			//         System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricSHBake::FSHSampleData>::set_Item(
			//           (List_1_HG_Rendering_Runtime_VolumetricSHBake_FSHSampleData_ *)v12,
			//           gpuIndexToRemove,
			//           (VolumetricSHBake_FSHSampleData *)&v17,
			//           MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::PerInstanceData>::set_Item);
			//         m_perInstanceBuffer = this.fields.m_perInstanceBuffer;
			//         if ( m_perInstanceBuffer )
			//         {
			//           UnityEngine::ComputeBuffer::SetData<HG::Rendering::Runtime::PerInstanceData>(
			//             m_perInstanceBuffer,
			//             this.fields.m_perInstanceData,
			//             MethodInfo::UnityEngine::ComputeBuffer::SetData<HG::Rendering::Runtime::PerInstanceData>);
			//           size = this.fields.m_generalSystemAttributes.particleCapacity
			//                * this.fields.m_generalSystemAttributes.particleAttribSize;
			//           m_particleAttributesBuffer = this.fields.m_particleAttributesBuffer;
			//           sub_180002C70(TypeInfo::UnityEngine::Graphics);
			//           UnityEngine::Graphics::CopyBuffer(
			//             m_particleAttributesBuffer,
			//             gpuIndexToMove * size,
			//             m_particleAttributesBuffer,
			//             gpuIndexToRemove * size,
			//             size,
			//             0LL);
			//           UnityEngine::Graphics::CopyBuffer(
			//             this.fields.m_deadListBuffer,
			//             gpuIndexToMove * 4 * this.fields.m_generalSystemAttributes.particleCapacity,
			//             this.fields.m_deadListBuffer,
			//             gpuIndexToRemove * 4 * this.fields.m_generalSystemAttributes.particleCapacity,
			//             4 * this.fields.m_generalSystemAttributes.particleCapacity,
			//             0LL);
			//           UnityEngine::Graphics::CopyBuffer(
			//             this.fields.m_deadCountBuffer,
			//             4 * gpuIndexToMove,
			//             this.fields.m_deadCountBuffer,
			//             4 * gpuIndexToRemove,
			//             4,
			//             0LL);
			//           return;
			//         }
			//       }
			// LABEL_16:
			//       sub_180B536AC(m_perInstanceBuffer, m_perInstanceData);
			//     }
			//   }
			// }
			// 
		}

		protected int CreateInstance(in PerInstanceData perInstanceData)
		{
			// // Int32 CreateInstance(PerInstanceData ByRef)
			// int32_t HG::Rendering::Runtime::GPUParticleSystemBase::CreateInstance(
			//         GPUParticleSystemBase *this,
			//         PerInstanceData *perInstanceData,
			//         MethodInfo *method)
			// {
			//   List_1_System_Int32_ *v5; // rdx
			//   List_1_System_Int32_ *m_instances; // rcx
			//   List_1_System_Int32_ *m_freePool; // rax
			//   int32_t Item; // eax
			//   int32_t v9; // esi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919DE4 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::RemoveAt);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::set_Item);
			//     byte_18D919DE4 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1462, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1462, 0LL);
			//     if ( !Patch )
			//       goto LABEL_11;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_553(Patch, (Object *)this, perInstanceData, 0LL);
			//   }
			//   else
			//   {
			//     m_freePool = this.fields.m_freePool;
			//     if ( !m_freePool )
			//       goto LABEL_11;
			//     if ( m_freePool.fields._size )
			//     {
			//       Item = (int32_t)System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::get_Item(
			//                         (List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *)this.fields.m_freePool,
			//                         m_freePool.fields._size - 1,
			//                         MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//       v5 = this.fields.m_freePool;
			//       v9 = Item;
			//       if ( v5 )
			//       {
			//         System::Collections::Generic::List<unsigned int>::RemoveAt(
			//           (List_1_System_UInt32_ *)this.fields.m_freePool,
			//           v5.fields._size - 1,
			//           MethodInfo::System::Collections::Generic::List<int>::RemoveAt);
			//         m_instances = this.fields.m_instances;
			//         if ( m_instances )
			//         {
			//           System::Collections::Generic::List<int>::set_Item(
			//             m_instances,
			//             v9,
			//             this.fields.m_gpuInstanceCount,
			//             MethodInfo::System::Collections::Generic::List<int>::set_Item);
			//           HG::Rendering::Runtime::GPUParticleSystemBase::OnInstanceCreated(
			//             this,
			//             this.fields.m_gpuInstanceCount,
			//             perInstanceData,
			//             0LL);
			//           ++this.fields.m_gpuInstanceCount;
			//           return v9;
			//         }
			//       }
			// LABEL_11:
			//       sub_180B536AC(m_instances, v5);
			//     }
			//     return -1;
			//   }
			// }
			// 
			return 0;
		}

		internal bool RemoveInstance(int index)
		{
			// // Boolean RemoveInstance(Int32)
			// bool HG::Rendering::Runtime::GPUParticleSystemBase::RemoveInstance(
			//         GPUParticleSystemBase *this,
			//         int32_t index,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   List_1_System_Int32_ *m_instances; // rcx
			//   List_1_System_Int32_ *v7; // rax
			//   unsigned int Item; // eax
			//   unsigned int v9; // ebp
			//   int32_t i; // esi
			//   List_1_System_Int32_ *v11; // rax
			//   RegexCharClass_SingleRange v12; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919DE5 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::set_Item);
			//     byte_18D919DE5 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1463, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1463, 0LL);
			//     if ( !Patch )
			//       goto LABEL_20;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
			//              (ILFixDynamicMethodWrapper_13 *)Patch,
			//              (Object *)this,
			//              (NaviDirection__Enum)index,
			//              0LL);
			//   }
			//   else
			//   {
			//     m_instances = this.fields.m_instances;
			//     if ( !m_instances )
			//       goto LABEL_20;
			//     if ( System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::get_Item(
			//            (List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *)m_instances,
			//            index,
			//            MethodInfo::System::Collections::Generic::List<int>::get_Item) != -1 )
			//     {
			//       v7 = this.fields.m_instances;
			//       if ( !v7 )
			//         goto LABEL_20;
			//       if ( index < v7.fields._size )
			//       {
			//         Item = (unsigned int)System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::get_Item(
			//                                (List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *)this.fields.m_instances,
			//                                index,
			//                                MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//         m_instances = this.fields.m_instances;
			//         v9 = Item;
			//         if ( m_instances )
			//         {
			//           System::Collections::Generic::List<int>::set_Item(
			//             m_instances,
			//             index,
			//             -1,
			//             MethodInfo::System::Collections::Generic::List<int>::set_Item);
			//           for ( i = 0; ; ++i )
			//           {
			//             v11 = this.fields.m_instances;
			//             if ( !v11 )
			//               goto LABEL_20;
			//             if ( i >= v11.fields._size )
			//               goto LABEL_16;
			//             v12 = System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::get_Item(
			//                     (List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *)this.fields.m_instances,
			//                     i,
			//                     MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//             m_instances = (List_1_System_Int32_ *)(unsigned int)(this.fields.m_gpuInstanceCount - 1);
			//             if ( v12 == (_DWORD)m_instances )
			//               break;
			//           }
			//           m_instances = this.fields.m_instances;
			//           if ( m_instances )
			//           {
			//             System::Collections::Generic::List<int>::set_Item(
			//               m_instances,
			//               i,
			//               v9,
			//               MethodInfo::System::Collections::Generic::List<int>::set_Item);
			// LABEL_16:
			//             sub_1800460E0(6LL, this, v9, (unsigned int)(this.fields.m_gpuInstanceCount - 1));
			//             m_instances = this.fields.m_freePool;
			//             if ( m_instances )
			//             {
			//               sub_18231EF50(m_instances, index);
			//               --this.fields.m_gpuInstanceCount;
			//               return 1;
			//             }
			//           }
			//         }
			// LABEL_20:
			//         sub_180B536AC(m_instances, v5);
			//       }
			//     }
			//     return 0;
			//   }
			// }
			// 
			return default(bool);
		}

		internal virtual GPUParticleSystemManager.SimulateContext AcquireSimulateContext()
		{
			// // GPUParticleSystemManager+SimulateContext AcquireSimulateContext()
			// GPUParticleSystemManager_SimulateContext *HG::Rendering::Runtime::GPUParticleSystemBase::AcquireSimulateContext(
			//         GPUParticleSystemManager_SimulateContext *__return_ptr retstr,
			//         GPUParticleSystemBase *this,
			//         MethodInfo *method)
			// {
			//   List_1_System_Int32_ *v5; // rdx
			//   __int64 v6; // rcx
			//   List_1_System_Int32_ *m_instancesToClear; // rax
			//   Int32__Array *v8; // rsi
			//   Int32__Array *v9; // rax
			//   OneofDescriptorProto *v10; // rdx
			//   FileDescriptor *v11; // r8
			//   MessageDescriptor *v12; // r9
			//   OneofDescriptorProto *v13; // rdx
			//   FileDescriptor *v14; // r8
			//   OneofDescriptorProto *v15; // rdx
			//   FileDescriptor *v16; // r8
			//   OneofDescriptorProto *v17; // rdx
			//   FileDescriptor *v18; // r8
			//   OneofDescriptorProto *v19; // rdx
			//   FileDescriptor *v20; // r8
			//   OneofDescriptorProto *v21; // rdx
			//   FileDescriptor *v22; // r8
			//   OneofDescriptorProto *v23; // rdx
			//   FileDescriptor *v24; // r8
			//   OneofDescriptorProto *v25; // rdx
			//   FileDescriptor *v26; // r8
			//   OneofDescriptorProto *v27; // rdx
			//   FileDescriptor *v28; // r8
			//   GeneralSystemAttributes m_generalSystemAttributes; // xmm0
			//   int32_t m_maxParticleEmitRate; // eax
			//   OneofDescriptorProto *v31; // rdx
			//   FileDescriptor *v32; // r8
			//   MessageDescriptor *v33; // r9
			//   __int128 v34; // xmm1
			//   __int128 v35; // xmm0
			//   __int128 v36; // xmm1
			//   __int128 v37; // xmm0
			//   GeneralSystemAttributes generalSystemAttributes; // xmm1
			//   __int128 v39; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   GPUParticleSystemManager_SimulateContext *v41; // rax
			//   __int128 v42; // xmm1
			//   __int128 v43; // xmm0
			//   __int128 v44; // xmm1
			//   __int128 v45; // xmm0
			//   GPUParticleSystemManager_SimulateContext *result; // rax
			//   OneofDescriptor v47; // [rsp+28h] [rbp-89h] BYREF
			//   GeneralSystemAttributes v48; // [rsp+78h] [rbp-39h]
			//   __int128 v49; // [rsp+88h] [rbp-29h] BYREF
			//   GPUParticleSystemManager_SimulateContext v50; // [rsp+98h] [rbp-19h] BYREF
			// 
			//   if ( !byte_18D919DE6 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::ToArray);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::get_Count);
			//     byte_18D919DE6 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1464, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1464, 0LL);
			//     if ( Patch )
			//     {
			//       v41 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_554(&v50, Patch, (Object *)this, 0LL);
			//       v42 = *(_OWORD *)&v41.perInstanceBuffer;
			//       *(_OWORD *)&retstr.emitShader = *(_OWORD *)&v41.emitShader;
			//       v43 = *(_OWORD *)&v41.systemAttributesBuffer;
			//       *(_OWORD *)&retstr.perInstanceBuffer = v42;
			//       v44 = *(_OWORD *)&v41.liveListBuffer;
			//       *(_OWORD *)&retstr.systemAttributesBuffer = v43;
			//       v45 = *(_OWORD *)&v41.deadCountBuffer;
			//       *(_OWORD *)&retstr.liveListBuffer = v44;
			//       generalSystemAttributes = v41.generalSystemAttributes;
			//       *(_OWORD *)&retstr.deadCountBuffer = v45;
			//       v39 = *(_OWORD *)&v41.instanceCount;
			//       goto LABEL_12;
			//     }
			//     goto LABEL_10;
			//   }
			//   m_instancesToClear = this.fields.m_instancesToClear;
			//   v8 = 0LL;
			//   if ( !m_instancesToClear )
			//     goto LABEL_10;
			//   if ( m_instancesToClear.fields._size )
			//   {
			//     v9 = System::Collections::Generic::List<int>::ToArray(
			//            this.fields.m_instancesToClear,
			//            MethodInfo::System::Collections::Generic::List<int>::ToArray);
			//     v5 = this.fields.m_instancesToClear;
			//     v8 = v9;
			//     if ( v5 )
			//     {
			//       ++v5.fields._version;
			//       v5.fields._size = 0;
			//       goto LABEL_8;
			//     }
			// LABEL_10:
			//     sub_180B536AC(v6, v5);
			//   }
			// LABEL_8:
			//   sub_1802F01E0(&v47.monitor, 0LL, 104LL);
			//   v47.klass = (OneofDescriptor__Class *)this.fields.m_shaders.emitShader;
			//   ((void (__stdcall *)(OneofDescriptor *, OneofDescriptorProto *, FileDescriptor *, MessageDescriptor *))sub_1800054D0)(
			//     &v47,
			//     v10,
			//     v11,
			//     v12);
			//   v47.monitor = (MonitorData *)this.fields.m_shaders.simulateShader;
			//   ((void (__stdcall *)(OneofDescriptor *, OneofDescriptorProto *, FileDescriptor *, MessageDescriptor *, String__Array *))sub_1800054D0)(
			//     (OneofDescriptor *)&v47.monitor,
			//     v13,
			//     v14,
			//     (MessageDescriptor *)v47.monitor,
			//     (String__Array *)v47.klass);
			//   *(_QWORD *)&v47.fields._._Index_k__BackingField = this.fields.m_perInstanceBuffer;
			//   ((void (__stdcall *)(OneofDescriptor *, OneofDescriptorProto *, FileDescriptor *, MessageDescriptor *, String__Array *, String *))sub_1800054D0)(
			//     (OneofDescriptor *)&v47.fields,
			//     v15,
			//     v16,
			//     *(MessageDescriptor **)&v47.fields._._Index_k__BackingField,
			//     (String__Array *)v47.klass,
			//     (String *)v47.monitor);
			//   v47.fields._._FullName_k__BackingField = (String *)this.fields.m_generalSystemAttributeBuffer;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&v47.fields._._FullName_k__BackingField,
			//     v17,
			//     v18,
			//     (MessageDescriptor *)v47.fields._._FullName_k__BackingField,
			//     (String__Array *)v47.klass,
			//     (String *)v47.monitor,
			//     *(MethodInfo **)&v47.fields._._Index_k__BackingField);
			//   v47.fields.containingType = (MessageDescriptor *)this.fields.m_particleAttributesBuffer;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&v47.fields.containingType,
			//     v19,
			//     v20,
			//     v47.fields.containingType,
			//     (String__Array *)v47.klass,
			//     (String *)v47.monitor,
			//     *(MethodInfo **)&v47.fields._._Index_k__BackingField);
			//   v47.fields.fields = (IList_1_Google_Protobuf_Reflection_FieldDescriptor_ *)this.fields.m_liveListBuffer;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&v47.fields.fields,
			//     v21,
			//     v22,
			//     (MessageDescriptor *)v47.fields.fields,
			//     (String__Array *)v47.klass,
			//     (String *)v47.monitor,
			//     *(MethodInfo **)&v47.fields._._Index_k__BackingField);
			//   v47.fields.accessor = (OneofAccessor *)this.fields.m_deadListBuffer;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&v47.fields.accessor,
			//     v23,
			//     v24,
			//     (MessageDescriptor *)v47.fields.accessor,
			//     (String__Array *)v47.klass,
			//     (String *)v47.monitor,
			//     *(MethodInfo **)&v47.fields._._Index_k__BackingField);
			//   v47.fields._Proto_k__BackingField = (OneofDescriptorProto *)this.fields.m_deadCountBuffer;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&v47.fields._Proto_k__BackingField,
			//     v25,
			//     v26,
			//     (MessageDescriptor *)v47.fields._Proto_k__BackingField,
			//     (String__Array *)v47.klass,
			//     (String *)v47.monitor,
			//     *(MethodInfo **)&v47.fields._._Index_k__BackingField);
			//   *(_QWORD *)&v47.fields._IsSynthetic_k__BackingField = this.fields.m_drawIndirectArgsBuffer;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&v47.fields._IsSynthetic_k__BackingField,
			//     v27,
			//     v28,
			//     *(MessageDescriptor **)&v47.fields._IsSynthetic_k__BackingField,
			//     (String__Array *)v47.klass,
			//     (String *)v47.monitor,
			//     *(MethodInfo **)&v47.fields._._Index_k__BackingField);
			//   m_generalSystemAttributes = this.fields.m_generalSystemAttributes;
			//   LODWORD(v49) = this.fields.m_gpuInstanceCount;
			//   m_maxParticleEmitRate = this.fields.m_maxParticleEmitRate;
			//   v48 = m_generalSystemAttributes;
			//   DWORD1(v49) = m_maxParticleEmitRate;
			//   *((_QWORD *)&v49 + 1) = v8;
			//   sub_1800054D0(
			//     (OneofDescriptor *)((char *)&v49 + 8),
			//     v31,
			//     v32,
			//     v33,
			//     (String__Array *)v47.klass,
			//     (String *)v47.monitor,
			//     *(MethodInfo **)&v47.fields._._Index_k__BackingField);
			//   v34 = *(_OWORD *)&v47.fields._._Index_k__BackingField;
			//   *(_OWORD *)&retstr.emitShader = *(_OWORD *)&v47.klass;
			//   v35 = *(_OWORD *)&v47.fields._._File_k__BackingField;
			//   *(_OWORD *)&retstr.perInstanceBuffer = v34;
			//   v36 = *(_OWORD *)&v47.fields.fields;
			//   *(_OWORD *)&retstr.systemAttributesBuffer = v35;
			//   v37 = *(_OWORD *)&v47.fields._Proto_k__BackingField;
			//   *(_OWORD *)&retstr.liveListBuffer = v36;
			//   generalSystemAttributes = v48;
			//   *(_OWORD *)&retstr.deadCountBuffer = v37;
			//   v39 = v49;
			// LABEL_12:
			//   result = retstr;
			//   retstr.generalSystemAttributes = generalSystemAttributes;
			//   *(_OWORD *)&retstr.instanceCount = v39;
			//   return result;
			// }
			// 
			return default(GPUParticleSystemManager.SimulateContext);
		}

		internal virtual GPUParticleSystemManager.RenderContext AcquireRenderContext()
		{
			// // GPUParticleSystemManager+RenderContext AcquireRenderContext()
			// GPUParticleSystemManager_RenderContext *HG::Rendering::Runtime::GPUParticleSystemBase::AcquireRenderContext(
			//         GPUParticleSystemManager_RenderContext *__return_ptr retstr,
			//         GPUParticleSystemBase *this,
			//         MethodInfo *method)
			// {
			//   OneofDescriptorProto *v5; // rdx
			//   FileDescriptor *v6; // r8
			//   MessageDescriptor *v7; // r9
			//   OneofDescriptorProto *v8; // rdx
			//   FileDescriptor *v9; // r8
			//   OneofDescriptorProto *v10; // rdx
			//   FileDescriptor *v11; // r8
			//   OneofDescriptorProto *v12; // rdx
			//   FileDescriptor *v13; // r8
			//   OneofDescriptorProto *v14; // rdx
			//   FileDescriptor *v15; // r8
			//   OneofDescriptorProto *v16; // rdx
			//   FileDescriptor *v17; // r8
			//   __int128 v18; // xmm1
			//   int32_t m_gpuInstanceCount; // r9d
			//   __int128 v20; // xmm0
			//   __int128 v21; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v23; // rdx
			//   __int64 v24; // rcx
			//   GPUParticleSystemManager_RenderContext *v25; // rax
			//   __int128 v26; // xmm1
			//   GPUParticleSystemManager_RenderContext *result; // rax
			//   __int128 v28; // [rsp+20h] [rbp-29h] BYREF
			//   OneofDescriptor v29; // [rsp+30h] [rbp-19h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1465, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1465, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v24, v23);
			//     v25 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_555(
			//             (GPUParticleSystemManager_RenderContext *)&v29.fields.fields,
			//             Patch,
			//             (Object *)this,
			//             0LL);
			//     v26 = *(_OWORD *)&v25.drawIndirectArgsBuffer;
			//     *(_OWORD *)&retstr.mesh = *(_OWORD *)&v25.mesh;
			//     v20 = *(_OWORD *)&v25.particleAttributesBuffer;
			//     *(_OWORD *)&retstr.drawIndirectArgsBuffer = v26;
			//     v21 = *(_OWORD *)&v25.generalSystemAttributeBuffer;
			//   }
			//   else
			//   {
			//     sub_1802F01E0(&v28, 0LL, 64LL);
			//     *(_QWORD *)&v29.fields._._Index_k__BackingField = this.fields.m_particleAttributesBuffer;
			//     sub_1800054D0(
			//       (OneofDescriptor *)&v29.fields,
			//       v5,
			//       v6,
			//       v7,
			//       (String__Array *)v28,
			//       *((String **)&v28 + 1),
			//       (MethodInfo *)v29.klass);
			//     v29.fields._._FullName_k__BackingField = (String *)this.fields.m_liveListBuffer;
			//     sub_1800054D0(
			//       (OneofDescriptor *)&v29.fields._._FullName_k__BackingField,
			//       v8,
			//       v9,
			//       (MessageDescriptor *)v29.fields._._FullName_k__BackingField,
			//       (String__Array *)v28,
			//       *((String **)&v28 + 1),
			//       (MethodInfo *)v29.klass);
			//     *((_QWORD *)&v28 + 1) = this.fields.m_quadIndexBuffer;
			//     ((void (__stdcall *)(OneofDescriptor *, OneofDescriptorProto *, FileDescriptor *, MessageDescriptor *, String__Array *))sub_1800054D0)(
			//       (OneofDescriptor *)((char *)&v28 + 8),
			//       v10,
			//       v11,
			//       *((MessageDescriptor **)&v28 + 1),
			//       (String__Array *)v28);
			//     v29.klass = (OneofDescriptor__Class *)this.fields.m_drawIndirectArgsBuffer;
			//     ((void (__stdcall *)(OneofDescriptor *, OneofDescriptorProto *, FileDescriptor *, MessageDescriptor *, String__Array *, String *))sub_1800054D0)(
			//       &v29,
			//       v12,
			//       v13,
			//       (MessageDescriptor *)v29.klass,
			//       (String__Array *)v28,
			//       *((String **)&v28 + 1));
			//     v29.fields._._File_k__BackingField = (FileDescriptor *)this.fields.m_generalSystemAttributeBuffer;
			//     sub_1800054D0(
			//       (OneofDescriptor *)&v29.fields._._File_k__BackingField,
			//       v14,
			//       v15,
			//       (MessageDescriptor *)v29.fields._._File_k__BackingField,
			//       (String__Array *)v28,
			//       *((String **)&v28 + 1),
			//       (MethodInfo *)v29.klass);
			//     v29.monitor = (MonitorData *)this.fields.m_material;
			//     sub_1800054D0(
			//       (OneofDescriptor *)&v29.monitor,
			//       v16,
			//       v17,
			//       (MessageDescriptor *)v29.monitor,
			//       (String__Array *)v28,
			//       *((String **)&v28 + 1),
			//       (MethodInfo *)v29.klass);
			//     v18 = *(_OWORD *)&v29.klass;
			//     m_gpuInstanceCount = this.fields.m_gpuInstanceCount;
			//     *(_OWORD *)&retstr.mesh = v28;
			//     LODWORD(v29.fields.containingType) = m_gpuInstanceCount;
			//     v20 = *(_OWORD *)&v29.fields._._Index_k__BackingField;
			//     *(_OWORD *)&retstr.drawIndirectArgsBuffer = v18;
			//     v21 = *(_OWORD *)&v29.fields._._File_k__BackingField;
			//   }
			//   *(_OWORD *)&retstr.particleAttributesBuffer = v20;
			//   result = retstr;
			//   *(_OWORD *)&retstr.generalSystemAttributeBuffer = v21;
			//   return result;
			// }
			// 
			return default(GPUParticleSystemManager.RenderContext);
		}

		internal void Modify(in GeneralSystemAttributes generalSystemAttributes)
		{
			// // Void Modify(GeneralSystemAttributes ByRef)
			// void HG::Rendering::Runtime::GPUParticleSystemBase::Modify(
			//         GPUParticleSystemBase *this,
			//         GeneralSystemAttributes *generalSystemAttributes,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   ComputeBuffer *m_generalSystemAttributeBuffer; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   NativeArray_1_UnityEngine_HyperGryph_ECS_EntityCommandBufferV2_VirtualEntityMap_ v8; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919DE7 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::ComputeBuffer::SetData<HG::Rendering::Runtime::GeneralSystemAttributes>);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::GeneralSystemAttributes>::NativeArray);
			//     byte_18D919DE7 = 1;
			//   }
			//   v8 = 0LL;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1466, 0LL) )
			//   {
			//     this.fields.m_generalSystemAttributes = *generalSystemAttributes;
			//     Unity::Collections::NativeArray<UnityEngine::HyperGryph::ECS::EntityCommandBufferV2::VirtualEntityMap>::NativeArray(
			//       &v8,
			//       1,
			//       Allocator__Enum_Temp,
			//       NativeArrayOptions__Enum_ClearMemory,
			//       MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::GeneralSystemAttributes>::NativeArray);
			//     *(GeneralSystemAttributes *)v8.m_Buffer = *generalSystemAttributes;
			//     m_generalSystemAttributeBuffer = this.fields.m_generalSystemAttributeBuffer;
			//     if ( m_generalSystemAttributeBuffer )
			//     {
			//       sub_180835CD8(m_generalSystemAttributeBuffer, &v8);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(m_generalSystemAttributeBuffer, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1466, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_556(Patch, (Object *)this, generalSystemAttributes, 0LL);
			// }
			// 
		}

		protected const int MAX_INSTANCE_COUNT = 64;

		private ComputeBuffer m_perInstanceBuffer;

		private ComputeBuffer m_generalSystemAttributeBuffer;

		private ComputeBuffer m_particleAttributesBuffer;

		private ComputeBuffer m_liveListBuffer;

		private ComputeBuffer m_deadListBuffer;

		private ComputeBuffer m_deadCountBuffer;

		private ComputeBuffer m_drawIndirectArgsBuffer;

		private GraphicsBuffer m_quadIndexBuffer;

		private GeneralSystemAttributes m_generalSystemAttributes;

		private GPUParticleShaders m_shaders;

		private List<PerInstanceData> m_perInstanceData;

		private List<int> m_instancesToClear;

		private Material m_material;

		private List<int> m_instances;

		private List<int> m_freePool;

		private int m_gpuInstanceCount;

		private int m_maxParticleEmitRate;

		internal Nullable<OptionalSystemFeatures> optionalSystemFeatures;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 32)]
		private struct FixedParticleAttrib
		{
			internal Vector4 var0;

			internal Vector4 var1;
		}
	}
}
