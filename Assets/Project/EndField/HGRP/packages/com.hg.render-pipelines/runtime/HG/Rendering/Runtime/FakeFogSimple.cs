using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[AddComponentMenu("Rendering/FakeSimpleFog(\u5047\u9762\u7247\u96FE)")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
	public class FakeFogSimple : MonoBehaviour // TypeDefIndex: 37930
	{
		// Fields
		public static bool previewInSceneDefault; // 0x00
		private static Material s_copyMat; // 0x08
		public const string FOG_MAT_FOLDER_PATH = "Assets/Beyond/Arts/Environment/LightingEnv/FogSimple/Material"; // Metadata: 0x0230360A
		public const string FOG_PRE_DEPTH_MAT_FOLDER_PATH = "Assets/Beyond/Arts/Environment/LightingEnv/FogSimple/PreDepth"; // Metadata: 0x02303648
		public const string FOG_MAT_CUTSCENE_FOLDER_PATH = "Assets/Beyond/Arts/Environment/LightingEnv/FogSimple/Cutscene"; // Metadata: 0x02303686
		public const string FOG_MAT_EDITOR_FOLDER_PATH = "Assets/BeyondEditor/Arts/Environment/LightingEnv/FogSimple/Material"; // Metadata: 0x023036C4
		public const string FOG_DEFAULT_MAT_NAME = "M_fog_simple_default.mat"; // Metadata: 0x02303709
		public const string FOG_DEFAULT_CS_MAT_NAME = "M_fog_simple_default_cs.mat"; // Metadata: 0x02303722
		private MeshRenderer m_meshRenderer; // 0x18
		private MeshFilter m_meshFilter; // 0x20
		internal Material m_defaultFogMat; // 0x28
		[HideInInspector]
		public bool _matIsSaved; // 0x30
		[HideInInspector]
		public bool _propertyHasChanged; // 0x31
		[HideInInspector]
		[SerializeField]
		public Material _instanceMaterial; // 0x38
		[HideInInspector]
		[SerializeField]
		public Material _depthPrePassMaterial; // 0x40
		public FogSimpleConfig _fogSimpleConfig; // 0x48
		[NonSerialized]
		public bool isLunaPlatform; // 0x50
		[NonSerialized]
		public bool isLunaTestScene; // 0x51
		public Action<FakeFogSimple> onManualMaterialChange; // 0x58
		public Func<FakeFogSimple, bool, bool> CheckMaterialValid; // 0x60
		public Func<FakeFogSimple, Material> OnDuplicateFogMat; // 0x68
		public Action<FakeFogSimple> LunaCustomInspector; // 0x70
	
		// Properties
		public Material fogRendererMat { get => default; } // 0x0000000189B5741C-0x0000000189B574A0 
		// Material get_fogRendererMat()
		Material *HG::Rendering::Runtime::FakeFogSimple::get_fogRendererMat(FakeFogSimple *this, MethodInfo *method)
		{
		  Object_1 *m_meshRenderer; // rbx
		  __int64 v4; // rdx
		  Renderer *v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2357, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2357, 0LL);
		    if ( !Patch )
		      goto LABEL_7;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_641(Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    m_meshRenderer = (Object_1 *)this->fields.m_meshRenderer;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Inequality(m_meshRenderer, 0LL, 0LL) )
		    {
		      v5 = (Renderer *)this->fields.m_meshRenderer;
		      if ( v5 )
		        return UnityEngine::Renderer::GetSharedMaterial(v5, 0LL);
		LABEL_7:
		      sub_1800D8260(v5, v4);
		    }
		    return 0LL;
		  }
		}
		
		internal Material[] fogRendererMats { get => default; } // 0x0000000189B574A0-0x0000000189B57524 
		// Material[] get_fogRendererMats()
		Material__Array *HG::Rendering::Runtime::FakeFogSimple::get_fogRendererMats(FakeFogSimple *this, MethodInfo *method)
		{
		  Object_1 *m_meshRenderer; // rbx
		  __int64 v4; // rdx
		  Renderer *v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2358, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2358, 0LL);
		    if ( !Patch )
		      goto LABEL_7;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_927(Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    m_meshRenderer = (Object_1 *)this->fields.m_meshRenderer;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Inequality(m_meshRenderer, 0LL, 0LL) )
		    {
		      v5 = (Renderer *)this->fields.m_meshRenderer;
		      if ( v5 )
		        return UnityEngine::Renderer::GetSharedMaterialArray(v5, 0LL);
		LABEL_7:
		      sub_1800D8260(v5, v4);
		    }
		    return 0LL;
		  }
		}
		
	
		// Constructors
		public FakeFogSimple() {} // 0x0000000185393520-0x0000000185393538
		// Singleton`1[System.Object]()
		void RootMotion::Singleton<System::Object>::Singleton(Singleton_1_System_Object__1 *this, MethodInfo *method)
		{
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		}
		
	}
}
