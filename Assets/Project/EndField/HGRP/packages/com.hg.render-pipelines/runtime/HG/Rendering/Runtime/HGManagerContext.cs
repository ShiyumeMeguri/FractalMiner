using System;
using System.Runtime.CompilerServices;
using UnityEngine.HyperGryph;

namespace HG.Rendering.Runtime
{
	public class HGManagerContext : HGManagerContextBase
	{
		// (get) Token: 0x06000A35 RID: 2613 RVA: 0x000025D2 File Offset: 0x000007D2
		public static HGManagerContext currentManagerContext
		{
			get
			{
				// // HGManagerContext get_currentManagerContext()
				// HGManagerContext *HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(MethodInfo *method)
				// {
				//   __int64 v1; // rdx
				//   struct HGGlobalGameManager__Class *v2; // rax
				//   HGManagerContextBase__Array *currentManagerContexts; // rax
				//   HGManagerContext *v4; // rbx
				//   char has_parent; // al
				//   HGManagerContext *v6; // rcx
				// 
				//   if ( !byte_18D8ED95C )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::HyperGryph::HGGlobalGameManager);
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGManagerContext);
				//     byte_18D8ED95C = 1;
				//   }
				//   v2 = TypeInfo::UnityEngine::HyperGryph::HGGlobalGameManager;
				//   if ( !TypeInfo::UnityEngine::HyperGryph::HGGlobalGameManager._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::HyperGryph::HGGlobalGameManager, v1);
				//     v2 = TypeInfo::UnityEngine::HyperGryph::HGGlobalGameManager;
				//   }
				//   currentManagerContexts = v2.static_fields.currentManagerContexts;
				//   if ( !currentManagerContexts )
				//     sub_180B536AC(method, v1);
				//   if ( !currentManagerContexts.max_length.size )
				//     sub_180070270(method, v1);
				//   v4 = (HGManagerContext *)currentManagerContexts.vector[0];
				//   if ( !v4 )
				//     return 0LL;
				//   has_parent = il2cpp_class_has_parent(v4.klass, TypeInfo::HG::Rendering::Runtime::HGManagerContext);
				//   v6 = 0LL;
				//   if ( has_parent )
				//     return v4;
				//   return v6;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000A36 RID: 2614 RVA: 0x000025D2 File Offset: 0x000007D2
		public HGResourceManagerScript resourceManagerScript
		{
			[CompilerGenerated]
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
		}

		// (get) Token: 0x06000A37 RID: 2615 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06000A38 RID: 2616 RVA: 0x000025D0 File Offset: 0x000007D0
		public HGWaterManager waterManager
		{
			[CompilerGenerated]
			get
			{
				// // Func`1[Single] get_getValueDelegate()
				// Func_1_Single_ *Rewired::Utils::Classes::Utility::ValueWatcher<float>::get_getValueDelegate(
				//         ValueWatcher_1_System_Single_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA;
				// }
				// 
				return null;
			}
			[CompilerGenerated]
			private set
			{
				// // Void set_getValueDelegate(Func`1[Single])
				// void Rewired::Utils::Classes::Utility::ValueWatcher<float>::set_getValueDelegate(
				//         ValueWatcher_1_System_Single_ *this,
				//         Func_1_Single_ *value,
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

		// (get) Token: 0x06000A39 RID: 2617 RVA: 0x000025D2 File Offset: 0x000007D2
		public HGReflectionProbeTextureManager reflectionProbeTextureManager
		{
			[CompilerGenerated]
			get
			{
				// // Func`1[Object] get_getValueDelegate()
				// Func_1_Object_ *Rewired::Utils::Classes::Utility::ValueWatcher<System::Object>::get_getValueDelegate(
				//         ValueWatcher_1_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000A3A RID: 2618 RVA: 0x000025D2 File Offset: 0x000007D2
		public HGTerrainStreamingManager terrainStreamingManager
		{
			[CompilerGenerated]
			get
			{
				// // IList`1[System.Object] HkgvubNsiKaMGZpZDhgJNXzxwNEY()
				// IList_1_System_Object_ *aDnpaQcaHrbMtqQtSgzqebcYvhXN<System::Object>::HkgvubNsiKaMGZpZDhgJNXzxwNEY(
				//         aDnpaQcaHrbMtqQtSgzqebcYvhXN_1_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields.YbVoRkZMMUxLLJcbAdHsvRhntcjw;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000A3B RID: 2619 RVA: 0x000025D2 File Offset: 0x000007D2
		public HGEntityRenderHelperECSManager entityRenderHelperECSManager
		{
			[CompilerGenerated]
			get
			{
				// // IUnit get_destinationUnit()
				// IUnit *Unity::VisualScripting::UnitConnection<System::Object,System::Object>::get_destinationUnit(
				//         UnitConnection_2_System_Object_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._destinationUnit_k__BackingField;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000A3C RID: 2620 RVA: 0x000025D2 File Offset: 0x000007D2
		public HGFoliageInteractiveManager foliageInteractiveManager
		{
			[CompilerGenerated]
			get
			{
				// // ValueHandler`1[UnityEngine.Vector4] get_getter()
				// ValueHandler_1_UnityEngine_Vector4_ *FlowCanvas::ValueOutput<UnityEngine::Vector4>::get_getter(
				//         ValueOutput_1_UnityEngine_Vector4_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._getter_k__BackingField;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000A3D RID: 2621 RVA: 0x000025D2 File Offset: 0x000007D2
		public HGSludgeManager sludgeManager
		{
			[CompilerGenerated]
			get
			{
				// // String get_propertyPath()
				// String *NodeCanvas::Framework::Variable<UnityEngine::Vector2>::get_propertyPath(
				//         Variable_1_UnityEngine_Vector2_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._propertyPath;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000A3E RID: 2622 RVA: 0x000025D2 File Offset: 0x000007D2
		public HGWindManager windManager
		{
			[CompilerGenerated]
			get
			{
				// // String get_propertyPath()
				// String *NodeCanvas::Framework::Variable<UnityEngine::Vector4>::get_propertyPath(
				//         Variable_1_UnityEngine_Vector4_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._propertyPath;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x000025D2 File Offset: 0x000007D2
		public GpuClothManager gpuClothManager
		{
			[CompilerGenerated]
			get
			{
				// // String get_propertyPath()
				// String *NodeCanvas::Framework::Variable<UnityEngine::RaycastHit2D>::get_propertyPath(
				//         Variable_1_UnityEngine_RaycastHit2D_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._propertyPath;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000A40 RID: 2624 RVA: 0x000025D2 File Offset: 0x000007D2
		public HGVFXManager vfxManager
		{
			[CompilerGenerated]
			get
			{
				// // StyleValues get_to()
				// StyleValues UnityEngine::UIElements::Experimental::ValueAnimation<UnityEngine::UIElements::Experimental::StyleValues>::get_to(
				//         ValueAnimation_1_StyleValues_ *this,
				//         MethodInfo *method)
				// {
				//   return (StyleValues)this.fields._to_k__BackingField.m_StyleValues;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x000025D2 File Offset: 0x000007D2
		public HGTerrainDeformManager terrainDeformManager
		{
			[CompilerGenerated]
			get
			{
				// // String get_propertyPath()
				// String *NodeCanvas::Framework::Variable<UnityEngine::ContactPoint2D>::get_propertyPath(
				//         Variable_1_UnityEngine_ContactPoint2D_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._propertyPath;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000A42 RID: 2626 RVA: 0x000025D2 File Offset: 0x000007D2
		public SkinnedMeshCaptureManager skinnedMeshCaptureManager
		{
			[CompilerGenerated]
			get
			{
				// // String get_propertyPath()
				// String *NodeCanvas::Framework::Variable<UnityEngine::RaycastHit>::get_propertyPath(
				//         Variable_1_UnityEngine_RaycastHit_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._propertyPath;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000A43 RID: 2627 RVA: 0x000025D2 File Offset: 0x000007D2
		public HGFoliageOccluderManager foliageOccluderManager
		{
			[CompilerGenerated]
			get
			{
				// // String get_propertyPath()
				// String *NodeCanvas::Framework::Variable<Beyond::Gameplay::AI::Config::EnemyAISkillData>::get_propertyPath(
				//         Variable_1_Beyond_Gameplay_AI_Config_EnemyAISkillData_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._propertyPath;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000A44 RID: 2628 RVA: 0x000025D2 File Offset: 0x000007D2
		public HGRuntimeGrassQuery runtimeGrassQuery
		{
			[CompilerGenerated]
			get
			{
				// // WaterVolumePtr get_value()
				// WaterVolumePtr Beyond::Gameplay::ParamVariable<Beyond::Gameplay::Core::WaterVolumePtr>::get_value(
				//         ParamVariable_1_Beyond_Gameplay_Core_WaterVolumePtr_ *this,
				//         MethodInfo *method)
				// {
				//   return (WaterVolumePtr)this.fields.m_value.id;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000A45 RID: 2629 RVA: 0x000025D2 File Offset: 0x000007D2
		public HGPlanarReflectionManager planarReflectionManager
		{
			[CompilerGenerated]
			get
			{
				// // List`1[NodeCanvas.Framework.Internal.BBMappingParameter] get_variablesMap()
				// List_1_NodeCanvas_Framework_Internal_BBMappingParameter_ *NodeCanvas::StateMachines::FSMNodeNested<System::Object>::get_variablesMap(
				//         FSMNodeNested_1_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._variablesMap;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000A46 RID: 2630 RVA: 0x000025D2 File Offset: 0x000007D2
		public HGInterationManager interactionManager
		{
			[CompilerGenerated]
			get
			{
				// // List`1[NodeCanvas.Framework.Internal.BBMappingParameter] get_variablesMap()
				// List_1_NodeCanvas_Framework_Internal_BBMappingParameter_ *NodeCanvas::StateMachines::FSMStateNested<System::Object>::get_variablesMap(
				//         FSMStateNested_1_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._variablesMap;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000A47 RID: 2631 RVA: 0x000025D2 File Offset: 0x000007D2
		public SubsurfaceManager subsurfaceManager
		{
			[CompilerGenerated]
			get
			{
				// // Object get_currentInstance()
				// Object *NodeCanvas::StateMachines::FSMStateNested<System::Object>::get_currentInstance(
				//         FSMStateNested_1_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._currentInstance_k__BackingField;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000A48 RID: 2632 RVA: 0x000025D2 File Offset: 0x000007D2
		public SubsurfaceProfileManager subsurfaceProfileManager
		{
			[CompilerGenerated]
			get
			{
				// // BBParameter get_parameter()
				// BBParameter *FlowCanvas::Nodes::SetVariable<UnityEngine::Vector4>::get_parameter(
				//         SetVariable_1_UnityEngine_Vector4_ *this,
				//         MethodInfo *method)
				// {
				//   return (BBParameter *)this.fields.targetVariable;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000A49 RID: 2633 RVA: 0x000025D2 File Offset: 0x000007D2
		public VolumetricManager volumetricManager
		{
			[CompilerGenerated]
			get
			{
				// // ValueInput`1[UnityEngine.Vector4] get_port()
				// ValueInput_1_UnityEngine_Vector4_ *FlowCanvas::Nodes::RelayValueInput<UnityEngine::Vector4>::get_port(
				//         RelayValueInput_1_UnityEngine_Vector4_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._port_k__BackingField;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000A4A RID: 2634 RVA: 0x000025D2 File Offset: 0x000007D2
		public VolumetricCloudVolumeManager volumetricCloudVolumeManager
		{
			[CompilerGenerated]
			get
			{
				// // Dictionary`2[NodeCanvas.Framework.Graph,NodeCanvas.Framework.Graph] get_instances()
				// Dictionary_2_NodeCanvas_Framework_Graph_NodeCanvas_Framework_Graph_ *FlowCanvas::FlowNodeNested<System::Object>::get_instances(
				//         FlowNodeNested_1_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._instances_k__BackingField;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000A4B RID: 2635 RVA: 0x000025D2 File Offset: 0x000007D2
		public HGInkManager inkManager
		{
			[CompilerGenerated]
			get
			{
				// // Object get_cachedValue()
				// Object *FlowCanvas::Nodes::RelayValueInput<System::Object>::get_cachedValue(
				//         RelayValueInput_1_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._cachedValue_k__BackingField;
				// }
				// 
				return null;
			}
		}

		public HGManagerContext()
		{
		}

		public static HGManagerContext GetOrCreateManagerContext()
		{
			// // HGManagerContext GetOrCreateManagerContext()
			// HGManagerContext *HG::Rendering::Runtime::HGManagerContext::GetOrCreateManagerContext(MethodInfo *method)
			// {
			//   __int64 v1; // rdx
			//   HGGlobalGameManagerAssetBase *ManagerAsset; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !byte_18D8ED95D )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::HyperGryph::HGGlobalGameManager);
			//     byte_18D8ED95D = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1908, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1908, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_751(Patch, 0LL);
			//   }
			//   else
			//   {
			//     if ( !TypeInfo::UnityEngine::HyperGryph::HGGlobalGameManager._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::HyperGryph::HGGlobalGameManager, v1);
			//     ManagerAsset = UnityEngine::HyperGryph::HGGlobalGameManager::GetManagerAsset(
			//                      ManagerContextType__Enum_HGManagerContext,
			//                      0LL);
			//     UnityEngine::HyperGryph::HGGlobalGameManager::InitializeManagerContext(
			//       ManagerContextType__Enum_HGManagerContext,
			//       ManagerAsset,
			//       0LL);
			//     return HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//   }
			// }
			// 
			return null;
		}

		protected override void Dispose(bool disposing)
		{
			// // Void Dispose(Boolean)
			// void HG::Rendering::Runtime::HGManagerContext::Dispose(HGManagerContext *this, bool disposing, MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HGWaterManager *waterManager_k__BackingField; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1909, 0LL) )
			//   {
			//     waterManager_k__BackingField = this.fields._waterManager_k__BackingField;
			//     if ( waterManager_k__BackingField )
			//     {
			//       HG::Rendering::Runtime::HGWaterManager::Release(waterManager_k__BackingField, 0LL);
			//       waterManager_k__BackingField = (HGWaterManager *)this.fields._terrainStreamingManager_k__BackingField;
			//       if ( waterManager_k__BackingField )
			//       {
			//         HG::Rendering::Runtime::HGTerrainStreamingManager::Dispose(
			//           (HGTerrainStreamingManager *)waterManager_k__BackingField,
			//           0LL);
			//         waterManager_k__BackingField = (HGWaterManager *)this.fields._foliageInteractiveManager_k__BackingField;
			//         if ( waterManager_k__BackingField )
			//         {
			//           HG::Rendering::Runtime::HGFoliageInteractiveManager::Dispose(
			//             (HGFoliageInteractiveManager *)waterManager_k__BackingField,
			//             0LL);
			//           waterManager_k__BackingField = (HGWaterManager *)this.fields._sludgeManager_k__BackingField;
			//           if ( waterManager_k__BackingField )
			//           {
			//             HG::Rendering::Runtime::HGSludgeManager::Dispose((HGSludgeManager *)waterManager_k__BackingField, 0LL);
			//             waterManager_k__BackingField = (HGWaterManager *)this.fields.ivManager;
			//             if ( waterManager_k__BackingField )
			//             {
			//               HG::Rendering::Runtime::HGIrradianceVolumeManager::ReleaseV2(
			//                 (HGIrradianceVolumeManager *)waterManager_k__BackingField,
			//                 0LL);
			//               waterManager_k__BackingField = (HGWaterManager *)this.fields.ivManagerV2;
			//               if ( waterManager_k__BackingField )
			//               {
			//                 HG::Rendering::Runtime::HGIrradianceVolumeManagerV2::ReleaseV2(
			//                   (HGIrradianceVolumeManagerV2 *)waterManager_k__BackingField,
			//                   0LL);
			//                 waterManager_k__BackingField = (HGWaterManager *)this.fields._entityRenderHelperECSManager_k__BackingField;
			//                 if ( waterManager_k__BackingField )
			//                 {
			//                   HG::Rendering::Runtime::HGEntityRenderHelperECSManager::Dispose(
			//                     (HGEntityRenderHelperECSManager *)waterManager_k__BackingField,
			//                     0LL);
			//                   waterManager_k__BackingField = (HGWaterManager *)this.fields._gpuClothManager_k__BackingField;
			//                   if ( waterManager_k__BackingField )
			//                   {
			//                     HG::Rendering::Runtime::GpuClothManager::Dispose(
			//                       (GpuClothManager *)waterManager_k__BackingField,
			//                       0LL);
			//                     waterManager_k__BackingField = (HGWaterManager *)this.fields._vfxManager_k__BackingField;
			//                     if ( waterManager_k__BackingField )
			//                     {
			//                       HG::Rendering::Runtime::HGVFXManager::Dispose((HGVFXManager *)waterManager_k__BackingField, 0LL);
			//                       waterManager_k__BackingField = (HGWaterManager *)this.fields._resourceManagerScript_k__BackingField;
			//                       if ( waterManager_k__BackingField )
			//                       {
			//                         HG::Rendering::Runtime::HGResourceManagerScript::Dispose(
			//                           (HGResourceManagerScript *)waterManager_k__BackingField,
			//                           0LL);
			//                         waterManager_k__BackingField = (HGWaterManager *)this.fields._planarReflectionManager_k__BackingField;
			//                         if ( waterManager_k__BackingField )
			//                         {
			//                           HG::Rendering::Runtime::HGPlanarReflectionManager::Release(
			//                             (HGPlanarReflectionManager *)waterManager_k__BackingField,
			//                             0LL);
			//                           waterManager_k__BackingField = (HGWaterManager *)this.fields._terrainDeformManager_k__BackingField;
			//                           if ( waterManager_k__BackingField )
			//                           {
			//                             HG::Rendering::Runtime::HGTerrainDeformManager::Dispose(
			//                               (HGTerrainDeformManager *)waterManager_k__BackingField,
			//                               0LL);
			//                             waterManager_k__BackingField = (HGWaterManager *)this.fields._interactionManager_k__BackingField;
			//                             if ( waterManager_k__BackingField )
			//                             {
			//                               HG::Rendering::Runtime::HGInterationManager::Release(
			//                                 (HGInterationManager *)waterManager_k__BackingField,
			//                                 0LL);
			//                               waterManager_k__BackingField = (HGWaterManager *)this.fields._windManager_k__BackingField;
			//                               if ( waterManager_k__BackingField )
			//                               {
			//                                 HG::Rendering::Runtime::HGWindManager::Dispose(
			//                                   (HGWindManager *)waterManager_k__BackingField,
			//                                   0LL);
			//                                 if ( this.fields.windFoliageSyncSystemInstanceCPP )
			//                                 {
			//                                   UnityEngine::HGWindFoliageSyncSystemCPP::HGWindFoliageSyncSystemCPP_Destroy(
			//                                     this.fields.windFoliageSyncSystemInstanceCPP,
			//                                     0LL);
			//                                   this.fields.windFoliageSyncSystemInstanceCPP = 0LL;
			//                                 }
			//                                 waterManager_k__BackingField = (HGWaterManager *)this.fields._volumetricManager_k__BackingField;
			//                                 if ( waterManager_k__BackingField )
			//                                 {
			//                                   HG::Rendering::Runtime::VolumetricManager::Release(
			//                                     (VolumetricManager *)waterManager_k__BackingField,
			//                                     0LL);
			//                                   return;
			//                                 }
			//                               }
			//                             }
			//                           }
			//                         }
			//                       }
			//                     }
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_21:
			//     sub_180B536AC(waterManager_k__BackingField, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1909, 0LL);
			//   if ( !Patch )
			//     goto LABEL_21;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_13((ILFixDynamicMethodWrapper_28 *)Patch, (Object *)this, disposing, 0LL);
			// }
			// 
		}

		protected override void EarlyUpdate()
		{
			// // Void EarlyUpdate()
			// void HG::Rendering::Runtime::HGManagerContext::EarlyUpdate(HGManagerContext *this, MethodInfo *method)
			// {
			//   HGTerrainStreamingManager *terrainStreamingManager_k__BackingField; // rcx
			//   Queue_1_HG_Rendering_Runtime_HGTerrainStreamingManager_TerrainLoadingNode___Class *klass; // rdx
			//   struct HGGraphicsFeatureManager__Class *v5; // rax
			//   void (__fastcall *v6)(_QWORD); // rax
			//   unsigned __int8 m_nodeAtlasPendingToLoad; // di
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rax
			// 
			//   if ( !byte_18D8ED95F )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//     byte_18D8ED95F = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   terrainStreamingManager_k__BackingField = (HGTerrainStreamingManager *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     terrainStreamingManager_k__BackingField = (HGTerrainStreamingManager *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   klass = terrainStreamingManager_k__BackingField[2].fields.m_nodeAtlasPendingLoaded.klass;
			//   if ( !klass )
			//     goto LABEL_16;
			//   if ( SLODWORD(klass._0.namespaze) <= 1931 )
			//     goto LABEL_9;
			//   if ( !LODWORD(terrainStreamingManager_k__BackingField[2].fields.m_splatLut) )
			//   {
			//     il2cpp_runtime_class_init_0(terrainStreamingManager_k__BackingField, klass);
			//     terrainStreamingManager_k__BackingField = (HGTerrainStreamingManager *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   terrainStreamingManager_k__BackingField = (HGTerrainStreamingManager *)terrainStreamingManager_k__BackingField[2].fields.m_nodeAtlasPendingLoaded.klass;
			//   if ( !terrainStreamingManager_k__BackingField )
			//     goto LABEL_16;
			//   if ( LODWORD(terrainStreamingManager_k__BackingField.fields.m_nodeAtlasPendingLoaded) <= 0x78B )
			//     sub_180070270(terrainStreamingManager_k__BackingField, klass);
			//   if ( !terrainStreamingManager_k__BackingField[193].fields.m_splatsPendingLoaded )
			//   {
			// LABEL_9:
			//     terrainStreamingManager_k__BackingField = this.fields._terrainStreamingManager_k__BackingField;
			//     if ( terrainStreamingManager_k__BackingField )
			//     {
			//       HG::Rendering::Runtime::HGTerrainStreamingManager::EarlyUpdate(terrainStreamingManager_k__BackingField, 0LL);
			//       v5 = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager;
			//       if ( !TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager._1.cctor_finished_or_no_cctor )
			//       {
			//         il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager, klass);
			//         v5 = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager;
			//       }
			//       terrainStreamingManager_k__BackingField = (HGTerrainStreamingManager *)v5.static_fields.terrainNewEditorRendering;
			//       if ( terrainStreamingManager_k__BackingField )
			//       {
			//         v6 = (void (__fastcall *)(_QWORD))qword_18D8F5C98;
			//         m_nodeAtlasPendingToLoad = (unsigned __int8)terrainStreamingManager_k__BackingField.fields.m_nodeAtlasPendingToLoad;
			//         if ( !qword_18D8F5C98 )
			//         {
			//           v6 = (void (__fastcall *)(_QWORD))il2cpp_resolve_icall_0(
			//                                               "UnityEngine.HyperGryph.HGEditorTerrainManager::SetUseNewEditorTerrainRende"
			//                                               "ring(System.Boolean)");
			//           if ( !v6 )
			//           {
			//             v9 = sub_1802DBBE8("UnityEngine.HyperGryph.HGEditorTerrainManager::SetUseNewEditorTerrainRendering(System.Boolean)");
			//             sub_18000F750(v9, 0LL);
			//           }
			//           qword_18D8F5C98 = (__int64)v6;
			//         }
			//         v6(m_nodeAtlasPendingToLoad);
			//         terrainStreamingManager_k__BackingField = (HGTerrainStreamingManager *)this.fields._waterManager_k__BackingField;
			//         if ( terrainStreamingManager_k__BackingField )
			//         {
			//           HG::Rendering::Runtime::HGWaterManager::EarlyUpdate(
			//             (HGWaterManager *)terrainStreamingManager_k__BackingField,
			//             0LL);
			//           return;
			//         }
			//       }
			//     }
			// LABEL_16:
			//     sub_180B536AC(terrainStreamingManager_k__BackingField, klass);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1931, 0LL);
			//   if ( !Patch )
			//     goto LABEL_16;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		internal void ForceGameplayUpdate()
		{
			// // Void ForceGameplayUpdate()
			// void HG::Rendering::Runtime::HGManagerContext::ForceGameplayUpdate(HGManagerContext *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1936, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1936, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else if ( !this.fields._._disposed_k__BackingField )
			//   {
			//     sub_180040B30(5LL, this);
			//   }
			// }
			// 
		}

		private void UpdateWindParam()
		{
			// // Void UpdateWindParam()
			// void HG::Rendering::Runtime::HGManagerContext::UpdateWindParam(HGManagerContext *this, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *klass; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   Object *windManager_k__BackingField; // rbx
			//   __int64 v6; // r8
			//   _OWORD *v7; // rdx
			//   __int64 v8; // rax
			//   Il2CppClass **p_castClass; // rcx
			//   __int128 v10; // xmm0
			//   __int128 v11; // xmm1
			//   __int128 v12; // xmm0
			//   __int128 v13; // xmm1
			//   __int128 v14; // xmm0
			//   __int128 v15; // xmm1
			//   __int128 v16; // xmm0
			//   __int128 v17; // xmm1
			//   Il2CppClass *v18; // rax
			//   __int128 v19; // xmm1
			//   char *v20; // rcx
			//   _OWORD *v21; // rdx
			//   __int128 v22; // xmm0
			//   __int128 v23; // xmm1
			//   __int128 v24; // xmm0
			//   __int128 v25; // xmm1
			//   __int128 v26; // xmm0
			//   __int128 v27; // xmm1
			//   __int128 v28; // xmm0
			//   __int128 v29; // xmm1
			//   __int64 v30; // rax
			//   int64_t windFoliageSyncSystemInstanceCPP; // rbx
			//   __int128 v32; // xmm1
			//   float gameplayTime; // xmm6_4
			//   float lastGameplayTime; // xmm0_4
			//   void (__fastcall *v35)(int64_t, __int128 *, char *, char *, char *, char *, __int128 *, _DWORD, _DWORD); // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ILFixDynamicMethodWrapper_2 *v37; // rax
			//   HGWindParamDataCache *v38; // rax
			//   __int64 v39; // rax
			//   __int128 v40; // xmm0
			//   __int128 v41; // xmm1
			//   __int128 v42; // xmm0
			//   __int128 v43; // xmm1
			//   __int128 v44; // xmm0
			//   __int128 v45; // xmm1
			//   __int128 v46; // xmm0
			//   __int128 v47; // xmm1
			//   __int64 v48; // rax
			//   __int128 v49; // [rsp+50h] [rbp-3D8h] BYREF
			//   __int128 v50; // [rsp+60h] [rbp-3C8h] BYREF
			//   _OWORD v51[19]; // [rsp+70h] [rbp-3B8h] BYREF
			//   char v52; // [rsp+1A0h] [rbp-288h] BYREF
			//   char v53[64]; // [rsp+1B0h] [rbp-278h] BYREF
			//   char v54[64]; // [rsp+1F0h] [rbp-238h] BYREF
			//   char v55[64]; // [rsp+230h] [rbp-1F8h] BYREF
			//   char v56[96]; // [rsp+270h] [rbp-1B8h] BYREF
			//   HGWindParamDataCache v57[5]; // [rsp+2D0h] [rbp-158h] BYREF
			// 
			//   if ( !byte_18D8ED960 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRPTimeManager);
			//     byte_18D8ED960 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   klass = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     klass = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = klass.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_25;
			//   if ( wrapperArray.max_length.size > 1937 )
			//   {
			//     if ( !klass._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(klass, wrapperArray);
			//       klass = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     wrapperArray = klass.static_fields.wrapperArray;
			//     if ( !wrapperArray )
			//       goto LABEL_25;
			//     if ( wrapperArray.max_length.size <= 0x791u )
			//       goto LABEL_44;
			//     if ( wrapperArray[53].vector[29] )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(1937, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//         return;
			//       }
			//       goto LABEL_25;
			//     }
			//   }
			//   windManager_k__BackingField = (Object *)this.fields._windManager_k__BackingField;
			//   if ( !windManager_k__BackingField )
			//     goto LABEL_25;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     klass = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     byte_18D8EDC37 = 1;
			//   }
			//   if ( !klass._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(klass, wrapperArray);
			//     klass = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = klass.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_25;
			//   if ( wrapperArray.max_length.size <= 1437 )
			//     goto LABEL_16;
			//   if ( !klass._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(klass, wrapperArray);
			//     klass = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   klass = (struct ILFixDynamicMethodWrapper_2__Class *)klass.static_fields.wrapperArray;
			//   if ( !klass )
			// LABEL_25:
			//     sub_180B536AC(klass, wrapperArray);
			//   if ( LODWORD(klass._0.namespaze) <= 0x59D )
			// LABEL_44:
			//     sub_180070270(klass, wrapperArray);
			//   if ( *(_QWORD *)&klass[30]._1.instance_size )
			//   {
			//     v37 = IFix::WrappersManagerImpl::GetPatch(1437, 0LL);
			//     if ( v37 )
			//     {
			//       v38 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_540(v57, v37, windManager_k__BackingField, 0LL);
			//       v6 = 2LL;
			//       v7 = v51;
			//       p_castClass = (Il2CppClass **)v38;
			//       v39 = 2LL;
			//       do
			//       {
			//         v7 += 8;
			//         v40 = *(_OWORD *)p_castClass;
			//         v41 = *((_OWORD *)p_castClass + 1);
			//         p_castClass += 16;
			//         *(v7 - 8) = v40;
			//         v42 = *((_OWORD *)p_castClass - 6);
			//         *(v7 - 7) = v41;
			//         v43 = *((_OWORD *)p_castClass - 5);
			//         *(v7 - 6) = v42;
			//         v44 = *((_OWORD *)p_castClass - 4);
			//         *(v7 - 5) = v43;
			//         v45 = *((_OWORD *)p_castClass - 3);
			//         *(v7 - 4) = v44;
			//         v46 = *((_OWORD *)p_castClass - 2);
			//         *(v7 - 3) = v45;
			//         v47 = *((_OWORD *)p_castClass - 1);
			//         *(v7 - 2) = v46;
			//         *(v7 - 1) = v47;
			//         --v39;
			//       }
			//       while ( v39 );
			//       goto LABEL_19;
			//     }
			//     goto LABEL_25;
			//   }
			// LABEL_16:
			//   klass = (struct ILFixDynamicMethodWrapper_2__Class *)windManager_k__BackingField[1].klass;
			//   if ( !klass )
			//     goto LABEL_25;
			//   v6 = 2LL;
			//   v7 = v51;
			//   v8 = 2LL;
			//   p_castClass = &klass._0.castClass;
			//   do
			//   {
			//     v7 += 8;
			//     v10 = *(_OWORD *)p_castClass;
			//     v11 = *((_OWORD *)p_castClass + 1);
			//     p_castClass += 16;
			//     *(v7 - 8) = v10;
			//     v12 = *((_OWORD *)p_castClass - 6);
			//     *(v7 - 7) = v11;
			//     v13 = *((_OWORD *)p_castClass - 5);
			//     *(v7 - 6) = v12;
			//     v14 = *((_OWORD *)p_castClass - 4);
			//     *(v7 - 5) = v13;
			//     v15 = *((_OWORD *)p_castClass - 3);
			//     *(v7 - 4) = v14;
			//     v16 = *((_OWORD *)p_castClass - 2);
			//     *(v7 - 3) = v15;
			//     v17 = *((_OWORD *)p_castClass - 1);
			//     *(v7 - 2) = v16;
			//     *(v7 - 1) = v17;
			//     --v8;
			//   }
			//   while ( v8 );
			// LABEL_19:
			//   v18 = p_castClass[4];
			//   v19 = *((_OWORD *)p_castClass + 1);
			//   *v7 = *(_OWORD *)p_castClass;
			//   v7[1] = v19;
			//   *((_QWORD *)v7 + 4) = v18;
			//   LODWORD(v18) = *((_DWORD *)p_castClass + 10);
			//   v20 = &v52;
			//   *((_DWORD *)v7 + 10) = (_DWORD)v18;
			//   v21 = v51;
			//   do
			//   {
			//     v20 += 128;
			//     v22 = *v21;
			//     v23 = v21[1];
			//     v21 += 8;
			//     *((_OWORD *)v20 - 8) = v22;
			//     v24 = *(v21 - 6);
			//     *((_OWORD *)v20 - 7) = v23;
			//     v25 = *(v21 - 5);
			//     *((_OWORD *)v20 - 6) = v24;
			//     v26 = *(v21 - 4);
			//     *((_OWORD *)v20 - 5) = v25;
			//     v27 = *(v21 - 3);
			//     *((_OWORD *)v20 - 4) = v26;
			//     v28 = *(v21 - 2);
			//     *((_OWORD *)v20 - 3) = v27;
			//     v29 = *(v21 - 1);
			//     *((_OWORD *)v20 - 2) = v28;
			//     *((_OWORD *)v20 - 1) = v29;
			//     --v6;
			//   }
			//   while ( v6 );
			//   v30 = *((_QWORD *)v21 + 4);
			//   windFoliageSyncSystemInstanceCPP = this.fields.windFoliageSyncSystemInstanceCPP;
			//   v32 = v21[1];
			//   *(_OWORD *)v20 = *v21;
			//   *((_OWORD *)v20 + 1) = v32;
			//   *((_QWORD *)v20 + 4) = v30;
			//   *((_DWORD *)v20 + 10) = *((_DWORD *)v21 + 10);
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGRPTimeManager._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRPTimeManager, v21);
			//   gameplayTime = HG::Rendering::Runtime::HGRPTimeManager::get_gameplayTime(0LL);
			//   lastGameplayTime = HG::Rendering::Runtime::HGRPTimeManager::get_lastGameplayTime(0LL);
			//   v35 = (void (__fastcall *)(int64_t, __int128 *, char *, char *, char *, char *, __int128 *, _DWORD, _DWORD))qword_18D8F58E8;
			//   v49 = v51[17];
			//   v50 = v51[0];
			//   if ( !qword_18D8F58E8 )
			//   {
			//     v35 = (void (__fastcall *)(int64_t, __int128 *, char *, char *, char *, char *, __int128 *, _DWORD, _DWORD))il2cpp_resolve_icall_0("UnityEngine.HGWindFoliageSyncSystemCPP::HGWindFoliageSyncSystemCPP_UpdateWindParam_Injected(System.Int64,UnityEngine.Vector4&,System.Single*,System.Single*,System.Single*,System.Single*,UnityEngine.Vector4&,System.Single,System.Single)");
			//     if ( !v35 )
			//     {
			//       v48 = sub_1802DBBE8(
			//               "UnityEngine.HGWindFoliageSyncSystemCPP::HGWindFoliageSyncSystemCPP_UpdateWindParam_Injected(System.Int64,U"
			//               "nityEngine.Vector4&,System.Single*,System.Single*,System.Single*,System.Single*,UnityEngine.Vector4&,Syste"
			//               "m.Single,System.Single)");
			//       sub_18000F750(v48, 0LL);
			//     }
			//     qword_18D8F58E8 = (__int64)v35;
			//   }
			//   v35(
			//     windFoliageSyncSystemInstanceCPP,
			//     &v50,
			//     v53,
			//     v54,
			//     v55,
			//     v56,
			//     &v49,
			//     LODWORD(gameplayTime),
			//     LODWORD(lastGameplayTime));
			// }
			// 
		}

		protected override void GameplayUpdate()
		{
			// // Void GameplayUpdate()
			// void HG::Rendering::Runtime::HGManagerContext::GameplayUpdate(HGManagerContext *this, MethodInfo *method)
			// {
			//   HGTerrainStreamingManager *terrainStreamingManager_k__BackingField; // rcx
			//   Queue_1_HG_Rendering_Runtime_HGTerrainStreamingManager_TerrainLoadingNode___Class *klass; // rdx
			//   float deltaTime; // xmm0_4
			//   float v6; // xmm6_4
			//   HGEntityRenderHelperECSManager *entityRenderHelperECSManager_k__BackingField; // rdi
			//   int32_t i; // esi
			//   List_1_HG_Rendering_Runtime_IEntityRenderHelperECS_ *m_activeHelpers; // rax
			//   Object *windManager_k__BackingField; // rdi
			//   GpuClothManager *gpuClothManager_k__BackingField; // rdi
			//   HGTerrainDeformManager *terrainDeformManager_k__BackingField; // rdi
			//   float v13; // xmm6_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ILFixDynamicMethodWrapper_2 *v15; // rax
			//   Object *Item; // rax
			//   __int64 v17; // r9
			//   ILFixDynamicMethodWrapper_2 *v18; // rax
			//   ILFixDynamicMethodWrapper_2 *v19; // rax
			//   ILFixDynamicMethodWrapper_2 *v20; // rax
			// 
			//   if ( !byte_18D8ED961 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRPTimeManager);
			//     byte_18D8ED961 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   terrainStreamingManager_k__BackingField = (HGTerrainStreamingManager *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     terrainStreamingManager_k__BackingField = (HGTerrainStreamingManager *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   klass = terrainStreamingManager_k__BackingField[2].fields.m_nodeAtlasPendingLoaded.klass;
			//   if ( !klass )
			//     goto LABEL_58;
			//   if ( SLODWORD(klass._0.namespaze) > 1938 )
			//   {
			//     if ( !LODWORD(terrainStreamingManager_k__BackingField[2].fields.m_splatLut) )
			//     {
			//       il2cpp_runtime_class_init_0(terrainStreamingManager_k__BackingField, klass);
			//       terrainStreamingManager_k__BackingField = (HGTerrainStreamingManager *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     klass = terrainStreamingManager_k__BackingField[2].fields.m_nodeAtlasPendingLoaded.klass;
			//     if ( !klass )
			//       goto LABEL_58;
			//     if ( LODWORD(klass._0.namespaze) <= 0x792 )
			//       goto LABEL_96;
			//     if ( klass[31].vtable.System_Collections_ICollection_CopyTo.methodPtr )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(1938, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//         return;
			//       }
			//       goto LABEL_58;
			//     }
			//   }
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGRPTimeManager._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRPTimeManager, klass);
			//   HG::Rendering::Runtime::HGRPTimeManager::Update(0LL);
			//   deltaTime = HG::Rendering::Runtime::HGRPTimeManager::get_deltaTime(0LL);
			//   terrainStreamingManager_k__BackingField = this.fields._terrainStreamingManager_k__BackingField;
			//   v6 = deltaTime;
			//   if ( !terrainStreamingManager_k__BackingField )
			//     goto LABEL_58;
			//   HG::Rendering::Runtime::HGTerrainStreamingManager::GameplayUpdate(terrainStreamingManager_k__BackingField, 0LL);
			//   terrainStreamingManager_k__BackingField = (HGTerrainStreamingManager *)this.fields._resourceManagerScript_k__BackingField;
			//   if ( !terrainStreamingManager_k__BackingField )
			//     goto LABEL_58;
			//   HG::Rendering::Runtime::HGResourceManagerScript::GameplayUpdate(
			//     (HGResourceManagerScript *)terrainStreamingManager_k__BackingField,
			//     0LL);
			//   entityRenderHelperECSManager_k__BackingField = this.fields._entityRenderHelperECSManager_k__BackingField;
			//   if ( !entityRenderHelperECSManager_k__BackingField )
			//     goto LABEL_58;
			//   if ( !byte_18D8EDCCA )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::IEntityRenderHelperECS);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IEntityRenderHelperECS>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IEntityRenderHelperECS>::get_Item);
			//     byte_18D8EDCCA = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   terrainStreamingManager_k__BackingField = (HGTerrainStreamingManager *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, klass);
			//     terrainStreamingManager_k__BackingField = (HGTerrainStreamingManager *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   klass = terrainStreamingManager_k__BackingField[2].fields.m_nodeAtlasPendingLoaded.klass;
			//   if ( !klass )
			//     goto LABEL_58;
			//   if ( SLODWORD(klass._0.namespaze) <= 1456 )
			//     goto LABEL_22;
			//   if ( !LODWORD(terrainStreamingManager_k__BackingField[2].fields.m_splatLut) )
			//   {
			//     il2cpp_runtime_class_init_0(terrainStreamingManager_k__BackingField, klass);
			//     terrainStreamingManager_k__BackingField = (HGTerrainStreamingManager *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   klass = terrainStreamingManager_k__BackingField[2].fields.m_nodeAtlasPendingLoaded.klass;
			//   if ( !klass )
			//     goto LABEL_58;
			//   if ( LODWORD(klass._0.namespaze) <= 0x5B0 )
			//     goto LABEL_96;
			//   if ( klass[23].vtable.System_Collections_ICollection_get_IsSynchronized.methodPtr )
			//   {
			//     v15 = IFix::WrappersManagerImpl::GetPatch(1456, 0LL);
			//     if ( !v15 )
			//       goto LABEL_58;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_27(
			//       (ILFixDynamicMethodWrapper_20 *)v15,
			//       (Object *)entityRenderHelperECSManager_k__BackingField,
			//       v6,
			//       0LL);
			//   }
			//   else
			//   {
			// LABEL_22:
			//     for ( i = 0; ; ++i )
			//     {
			//       m_activeHelpers = entityRenderHelperECSManager_k__BackingField.fields.m_activeHelpers;
			//       if ( !m_activeHelpers )
			//         goto LABEL_58;
			//       if ( i >= m_activeHelpers.fields._size )
			//         break;
			//       Item = System::Collections::Generic::List<System::Object>::get_Item(
			//                (List_1_System_Object_ *)entityRenderHelperECSManager_k__BackingField.fields.m_activeHelpers,
			//                i,
			//                MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IEntityRenderHelperECS>::get_Item);
			//       if ( !Item )
			//         goto LABEL_58;
			//       sub_1801E4BE8(1LL, TypeInfo::HG::Rendering::Runtime::IEntityRenderHelperECS, Item, v17);
			//     }
			//     HG::Rendering::Runtime::HGEntityRenderHelperECSManager::_RemoveInActive(
			//       entityRenderHelperECSManager_k__BackingField,
			//       0LL);
			//   }
			//   terrainStreamingManager_k__BackingField = (HGTerrainStreamingManager *)this.fields._foliageInteractiveManager_k__BackingField;
			//   if ( !terrainStreamingManager_k__BackingField )
			//     goto LABEL_58;
			//   HG::Rendering::Runtime::HGFoliageInteractiveManager::GameplayUpdate(
			//     (HGFoliageInteractiveManager *)terrainStreamingManager_k__BackingField,
			//     0LL);
			//   terrainStreamingManager_k__BackingField = (HGTerrainStreamingManager *)this.fields._sludgeManager_k__BackingField;
			//   if ( !terrainStreamingManager_k__BackingField )
			//     goto LABEL_58;
			//   HG::Rendering::Runtime::HGSludgeManager::GameplayUpdate(
			//     (HGSludgeManager *)terrainStreamingManager_k__BackingField,
			//     0LL);
			//   windManager_k__BackingField = (Object *)this.fields._windManager_k__BackingField;
			//   if ( !windManager_k__BackingField )
			//     goto LABEL_58;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   terrainStreamingManager_k__BackingField = (HGTerrainStreamingManager *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, klass);
			//     terrainStreamingManager_k__BackingField = (HGTerrainStreamingManager *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   klass = terrainStreamingManager_k__BackingField[2].fields.m_nodeAtlasPendingLoaded.klass;
			//   if ( !klass )
			//     goto LABEL_58;
			//   if ( SLODWORD(klass._0.namespaze) <= 1434 )
			//     goto LABEL_35;
			//   if ( !LODWORD(terrainStreamingManager_k__BackingField[2].fields.m_splatLut) )
			//   {
			//     il2cpp_runtime_class_init_0(terrainStreamingManager_k__BackingField, klass);
			//     terrainStreamingManager_k__BackingField = (HGTerrainStreamingManager *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   klass = terrainStreamingManager_k__BackingField[2].fields.m_nodeAtlasPendingLoaded.klass;
			//   if ( !klass )
			//     goto LABEL_58;
			//   if ( LODWORD(klass._0.namespaze) <= 0x59A )
			//     goto LABEL_96;
			//   if ( *(_QWORD *)&klass[23]._1.token )
			//   {
			//     v18 = IFix::WrappersManagerImpl::GetPatch(1434, 0LL);
			//     if ( !v18 )
			//       goto LABEL_58;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_27(
			//       (ILFixDynamicMethodWrapper_20 *)v18,
			//       windManager_k__BackingField,
			//       v6,
			//       0LL);
			//   }
			//   else
			//   {
			// LABEL_35:
			//     terrainStreamingManager_k__BackingField = (HGTerrainStreamingManager *)windManager_k__BackingField[1].klass;
			//     if ( !terrainStreamingManager_k__BackingField )
			//       goto LABEL_58;
			//     HG::Rendering::Runtime::HGWindSimpleManager::GamePlayUpdate(
			//       (HGWindSimpleManager *)terrainStreamingManager_k__BackingField,
			//       v6,
			//       0LL);
			//   }
			//   gpuClothManager_k__BackingField = this.fields._gpuClothManager_k__BackingField;
			//   if ( !gpuClothManager_k__BackingField )
			//     goto LABEL_58;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   terrainStreamingManager_k__BackingField = (HGTerrainStreamingManager *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, klass);
			//     terrainStreamingManager_k__BackingField = (HGTerrainStreamingManager *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   klass = terrainStreamingManager_k__BackingField[2].fields.m_nodeAtlasPendingLoaded.klass;
			//   if ( !klass )
			//     goto LABEL_58;
			//   if ( SLODWORD(klass._0.namespaze) <= 1142 )
			//     goto LABEL_44;
			//   if ( !LODWORD(terrainStreamingManager_k__BackingField[2].fields.m_splatLut) )
			//   {
			//     il2cpp_runtime_class_init_0(terrainStreamingManager_k__BackingField, klass);
			//     terrainStreamingManager_k__BackingField = (HGTerrainStreamingManager *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   klass = terrainStreamingManager_k__BackingField[2].fields.m_nodeAtlasPendingLoaded.klass;
			//   if ( !klass )
			//     goto LABEL_58;
			//   if ( LODWORD(klass._0.namespaze) <= 0x476 )
			//     goto LABEL_96;
			//   if ( klass[18].vtable.System_Collections_Generic_IEnumerable_T__GetEnumerator.method )
			//   {
			//     v19 = IFix::WrappersManagerImpl::GetPatch(1142, 0LL);
			//     if ( !v19 )
			//       goto LABEL_58;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_27(
			//       (ILFixDynamicMethodWrapper_20 *)v19,
			//       (Object *)gpuClothManager_k__BackingField,
			//       v6,
			//       0LL);
			//   }
			//   else
			//   {
			// LABEL_44:
			//     gpuClothManager_k__BackingField[1].fields.CHARACTER_POSITION_OFFSET.x = v6;
			//     HG::Rendering::Runtime::GpuClothManager::_UpdateWindParams(gpuClothManager_k__BackingField, 0LL);
			//     if ( LOBYTE(gpuClothManager_k__BackingField[1].monitor) )
			//     {
			//       HG::Rendering::Runtime::GpuClothManager::_ProcessPendingQueue(gpuClothManager_k__BackingField, 0LL);
			//       HG::Rendering::Runtime::GpuClothManager::_SetPerDrawData(gpuClothManager_k__BackingField, 0LL);
			//       HG::Rendering::Runtime::GpuClothManager::_UpdateStreamingMode(gpuClothManager_k__BackingField, 0LL);
			//     }
			//   }
			//   terrainDeformManager_k__BackingField = this.fields._terrainDeformManager_k__BackingField;
			//   if ( !terrainDeformManager_k__BackingField )
			//     goto LABEL_58;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   terrainStreamingManager_k__BackingField = (HGTerrainStreamingManager *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, klass);
			//     terrainStreamingManager_k__BackingField = (HGTerrainStreamingManager *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   klass = terrainStreamingManager_k__BackingField[2].fields.m_nodeAtlasPendingLoaded.klass;
			//   if ( !klass )
			//     goto LABEL_58;
			//   if ( SLODWORD(klass._0.namespaze) <= 1946 )
			//     goto LABEL_53;
			//   if ( !LODWORD(terrainStreamingManager_k__BackingField[2].fields.m_splatLut) )
			//   {
			//     il2cpp_runtime_class_init_0(terrainStreamingManager_k__BackingField, klass);
			//     terrainStreamingManager_k__BackingField = (HGTerrainStreamingManager *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   klass = terrainStreamingManager_k__BackingField[2].fields.m_nodeAtlasPendingLoaded.klass;
			//   if ( !klass )
			//     goto LABEL_58;
			//   if ( LODWORD(klass._0.namespaze) <= 0x79A )
			// LABEL_96:
			//     sub_180070270(terrainStreamingManager_k__BackingField, klass);
			//   if ( !klass[31].vtable.get_Count_1.methodPtr )
			//   {
			// LABEL_53:
			//     v13 = v6 + terrainDeformManager_k__BackingField.fields.m_remainDeltaTime;
			//     terrainDeformManager_k__BackingField.fields.deltaTime = 0.0;
			//     terrainDeformManager_k__BackingField.fields.m_remainDeltaTime = v13;
			//     if ( v13 >= 0.15000001 )
			//     {
			//       terrainDeformManager_k__BackingField.fields.deltaTime = 0.15000001;
			//       terrainDeformManager_k__BackingField.fields.m_remainDeltaTime = v13 - 0.15000001;
			//     }
			//     goto LABEL_55;
			//   }
			//   v20 = IFix::WrappersManagerImpl::GetPatch(1946, 0LL);
			//   if ( !v20 )
			// LABEL_58:
			//     sub_180B536AC(terrainStreamingManager_k__BackingField, klass);
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_27(
			//     (ILFixDynamicMethodWrapper_20 *)v20,
			//     (Object *)terrainDeformManager_k__BackingField,
			//     v6,
			//     0LL);
			// LABEL_55:
			//   if ( this.fields.windFoliageSyncSystemInstanceCPP )
			//     HG::Rendering::Runtime::HGManagerContext::UpdateWindParam(this, 0LL);
			// }
			// 
		}

		protected override void PipelineUpdate()
		{
			// // Void PipelineUpdate()
			// void HG::Rendering::Runtime::HGManagerContext::PipelineUpdate(HGManagerContext *this, MethodInfo *method)
			// {
			//   HGWaterManager *waterManager_k__BackingField; // rcx
			//   __int64 v4; // rdx
			//   Object *vfxManager_k__BackingField; // rdi
			//   ILFixDynamicMethodWrapper_2 *v6; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   waterManager_k__BackingField = (HGWaterManager *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     waterManager_k__BackingField = (HGWaterManager *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v4 = **(_QWORD **)&waterManager_k__BackingField.fields.m_lerpStartTimeTime;
			//   if ( !v4 )
			//     goto LABEL_21;
			//   if ( *(int *)(v4 + 24) <= 1947 )
			//     goto LABEL_7;
			//   if ( !LODWORD(waterManager_k__BackingField[1].fields.m_globalConfigs) )
			//   {
			//     il2cpp_runtime_class_init_0(waterManager_k__BackingField, v4);
			//     waterManager_k__BackingField = (HGWaterManager *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v4 = **(_QWORD **)&waterManager_k__BackingField.fields.m_lerpStartTimeTime;
			//   if ( !v4 )
			//     goto LABEL_21;
			//   if ( *(_DWORD *)(v4 + 24) <= 0x79Bu )
			//     goto LABEL_36;
			//   if ( !*(_QWORD *)(v4 + 15608) )
			//   {
			// LABEL_7:
			//     waterManager_k__BackingField = this.fields._waterManager_k__BackingField;
			//     if ( !waterManager_k__BackingField )
			//       goto LABEL_21;
			//     HG::Rendering::Runtime::HGWaterManager::PipelineUpdate(waterManager_k__BackingField, 0LL);
			//     waterManager_k__BackingField = (HGWaterManager *)this.fields._skinnedMeshCaptureManager_k__BackingField;
			//     if ( !waterManager_k__BackingField )
			//       goto LABEL_21;
			//     HG::Rendering::Runtime::SkinnedMeshCaptureManager::PipelineUpdate(
			//       (SkinnedMeshCaptureManager *)waterManager_k__BackingField,
			//       0LL);
			//     waterManager_k__BackingField = (HGWaterManager *)this.fields._foliageOccluderManager_k__BackingField;
			//     if ( !waterManager_k__BackingField )
			//       goto LABEL_21;
			//     HG::Rendering::Runtime::HGFoliageOccluderManager::PipelineUpdate(
			//       (HGFoliageOccluderManager *)waterManager_k__BackingField,
			//       0LL);
			//     waterManager_k__BackingField = (HGWaterManager *)this.fields._interactionManager_k__BackingField;
			//     if ( !waterManager_k__BackingField )
			//       goto LABEL_21;
			//     HG::Rendering::Runtime::HGInterationManager::PipelineUpdate(
			//       (HGInterationManager *)waterManager_k__BackingField,
			//       0LL);
			//     vfxManager_k__BackingField = (Object *)this.fields._vfxManager_k__BackingField;
			//     if ( !vfxManager_k__BackingField )
			//       goto LABEL_21;
			//     if ( !byte_18D8EDC37 )
			//     {
			//       sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//       byte_18D8EDC37 = 1;
			//     }
			//     waterManager_k__BackingField = (HGWaterManager *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v4);
			//       waterManager_k__BackingField = (HGWaterManager *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v4 = **(_QWORD **)&waterManager_k__BackingField.fields.m_lerpStartTimeTime;
			//     if ( !v4 )
			//       goto LABEL_21;
			//     if ( *(int *)(v4 + 24) <= 1971 )
			//       goto LABEL_18;
			//     if ( !LODWORD(waterManager_k__BackingField[1].fields.m_globalConfigs) )
			//     {
			//       il2cpp_runtime_class_init_0(waterManager_k__BackingField, v4);
			//       waterManager_k__BackingField = (HGWaterManager *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     waterManager_k__BackingField = **(HGWaterManager ***)&waterManager_k__BackingField.fields.m_lerpStartTimeTime;
			//     if ( !waterManager_k__BackingField )
			//       goto LABEL_21;
			//     if ( LODWORD(waterManager_k__BackingField.fields.m_globalConfigs) > 0x7B3 )
			//     {
			//       if ( waterManager_k__BackingField[79].klass )
			//       {
			//         Patch = IFix::WrappersManagerImpl::GetPatch(1971, 0LL);
			//         if ( !Patch )
			//           goto LABEL_21;
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
			//           (ILFixDynamicMethodWrapper_37 *)Patch,
			//           vfxManager_k__BackingField,
			//           0LL);
			//         goto LABEL_19;
			//       }
			// LABEL_18:
			//       HG::Rendering::Runtime::HGVFXManager::_UpdateSceneDarkValue((HGVFXManager *)vfxManager_k__BackingField, 0LL);
			// LABEL_19:
			//       waterManager_k__BackingField = (HGWaterManager *)this.fields._volumetricManager_k__BackingField;
			//       if ( waterManager_k__BackingField )
			//       {
			//         HG::Rendering::Runtime::VolumetricManager::PipelineUpdate(
			//           (VolumetricManager *)waterManager_k__BackingField,
			//           0LL);
			//         return;
			//       }
			// LABEL_21:
			//       sub_180B536AC(waterManager_k__BackingField, v4);
			//     }
			// LABEL_36:
			//     sub_180070270(waterManager_k__BackingField, v4);
			//   }
			//   v6 = IFix::WrappersManagerImpl::GetPatch(1947, 0LL);
			//   if ( !v6 )
			//     goto LABEL_21;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)v6, (Object *)this, 0LL);
			// }
			// 
		}

		public void <>iFixBaseProxy_Dispose(bool P0)
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

		private const string PROFILE_MARK_MANAGERCONTEXT_GAMEPLAYUPDATE = "HGManagerContext: GameplayUpdate";

		private const string PROFILE_MARK_TERRAINSTREAMINGMANAGER = "HGManagerContext: HGTerrainStreamingManager Update";

		private const string PROFILE_MARK_RESOURCEMANAGERSCRIPT = "HGManagerContext: HGResourceManagerScript Update";

		private const string PROFILE_MARK_ENTITYRENDERHELPERECSMANAGER = "HGManagerContext: HGEntityRenderHelperECSManager Update";

		private const string PROFILE_MARK_REFLECTIONPROBETEXTUREMANAGER = "HGManagerContext: HGReflectionProbeTextureManager Update";

		private const string PROFILE_MARK_FOLIAGEINTERACTIVEMANAGER = "HGManagerContext: HGFoliageInteractiveManager Update";

		private const string PROFILE_MARK_SLUDGEMANAGER = "HGManagerContext: HGSludgeManager Update";

		private const string PROFILE_MARK_WINDMANAGER = "HGManagerContext: HGWindManager Update";

		private const string PROFILE_MARK_GPUCLOTHMANAGER = "HGManagerContext: GpuClothManager Update";

		private const string PROFILE_MARK_TERRAINDEFORMMANAGER = "HGManagerContext: HGTerrainDeformManager Update";

		private const string PROFILE_MARK_VFXMANAGER = "HGManagerContext: HGVFXManager Update";

		private const string PROFILE_MARK_MANAGERCONTEXT_EARLYUPDATE = "HGManagerContext: EarlyUpdate";

		private const string PROFILE_MARK_TERRAINSTREAMINGMANAGER_EARLYUPDATE = "HGManagerContext: HGTerrainStreamingManager EarlyUpdate";

		private const string PROFILE_MARK_MANAGERCONTEXT_PIPELINEUPDATE = "HGManagerContext: PipelineUpdate";

		private const string PROFILE_MARK_REFLECTIONPROBETEXTUREMANAGER_PIPELINEUPDATE = "HGManagerContext: HGReflectionProbeTextureManager PipelineUpdate";

		private const string PROFILE_MARK_WATERMANAGER_PIPELINEUPDATE = "HGManagerContext: HGWaterManager PipelineUpdate";

		private const string PROFILE_MARK_WATERMANAGER_PIPELINE_EARLYUPDATE = "HGManagerContext: HGWaterManager Pipeline Early Update";

		private const string PROFILE_MARK_SKINNEDMESHCAPTUREMANAGER_PIPELINEUPDATE = "HGManagerContext: SkinnedMeshCaptureManager PipelineUpdate";

		private const string PROFILE_MARK_FOLIAGEOCCLUDERMANAGER_PIPELINEUPDATE = "HGManagerContext: HGFoliageOccluderManager PipelineUpdate";

		private const string PROFILE_MARK_INTERATIONMANAGER_PIPELINEUPDATE = "HGManagerContext: HGInterationManager PipelineUpdate";

		public HGIrradianceVolumeManager ivManager;

		public HGIrradianceVolumeManagerV2 ivManagerV2;

		private long windFoliageSyncSystemInstanceCPP;
	}
}
