using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
	[AddComponentMenu("Rendering/FakeSimpleFog(假面片雾)")]
	[ExecuteInEditMode]
	public class FakeFogSimple : MonoBehaviour
	{
		// (get) Token: 0x06000A8B RID: 2699 RVA: 0x000025D2 File Offset: 0x000007D2
		internal Material fogRendererMat
		{
			get
			{
				// // Material get_fogRendererMat()
				// Material *HG::Rendering::Runtime::FakeFogSimple::get_fogRendererMat(FakeFogSimple *this, MethodInfo *method)
				// {
				//   Object_1 *m_meshRenderer; // rbx
				//   __int64 v4; // rdx
				//   Renderer *v5; // rcx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D9193F2 )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D9193F2 = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(1985, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(1985, 0LL);
				//     if ( !Patch )
				//       goto LABEL_9;
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_685(Patch, (Object *)this, 0LL);
				//   }
				//   else
				//   {
				//     m_meshRenderer = (Object_1 *)this.fields.m_meshRenderer;
				//     sub_180002C70(TypeInfo::UnityEngine::Object);
				//     if ( UnityEngine::Object::op_Inequality(m_meshRenderer, 0LL, 0LL) )
				//     {
				//       v5 = (Renderer *)this.fields.m_meshRenderer;
				//       if ( v5 )
				//         return UnityEngine::Renderer::GetSharedMaterial(v5, 0LL);
				// LABEL_9:
				//       sub_180B536AC(v5, v4);
				//     }
				//     return 0LL;
				//   }
				// }
				// 
				return null;
			}
		}

		public FakeFogSimple()
		{
			// // Singleton`1[System.Object]()
			// void RootMotion::Singleton<System::Object>::Singleton(Singleton_1_System_Object__1 *this, MethodInfo *method)
			// {
			//   UnityEngine::Component::Component((Component *)this, 0LL);
			// }
			// 
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static bool previewInSceneDefault;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static Material s_copyMat;

		public const string FOG_MAT_FOLDER_PATH = "Assets/Beyond/Arts/Environment/LightingEnv/FogSimple/Material";

		public const string FOG_MAT_CUTSCENE_FOLDER_PATH = "Assets/Beyond/Arts/Environment/LightingEnv/FogSimple/Cutscene";

		public const string FOG_MAT_EDITOR_FOLDER_PATH = "Assets/BeyondEditor/Arts/Environment/LightingEnv/FogSimple/Material";

		public const string FOG_DEFAULT_MAT_NAME = "M_fog_simple_default.mat";

		private MeshRenderer m_meshRenderer;

		private MeshFilter m_meshFilter;

		internal Material m_defaultFogMat;

		[HideInInspector]
		public bool _matIsSaved;

		[HideInInspector]
		public bool _propertyHasChanged;

		[HideInInspector]
		[SerializeField]
		public Material _instanceMaterial;

		public FogSimpleConfig _fogSimpleConfig;

		[NonSerialized]
		public bool isLunaPlatform;

		[NonSerialized]
		public bool isLunaTestScene;

		public Action<FakeFogSimple> onManualMaterialChange;
	}
}
