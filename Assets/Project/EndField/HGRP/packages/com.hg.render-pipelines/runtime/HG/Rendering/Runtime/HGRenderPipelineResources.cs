using System;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	internal abstract class HGRenderPipelineResources : RenderPipelineResources
	{
		// (get) Token: 0x06000EC9 RID: 3785 RVA: 0x000025D2 File Offset: 0x000007D2
		protected override string packagePath
		{
			get
			{
				// // String get_packagePath()
				// String *HG::Rendering::Runtime::HGRenderPipelineResources::get_packagePath(
				//         HGRenderPipelineResources *this,
				//         MethodInfo *method)
				// {
				//   if ( !byte_18D9194F7 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
				//     byte_18D9194F7 = 1;
				//   }
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGUtils._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGUtils, method);
				//   return HG::Rendering::Runtime::HGUtils::GetHGRenderPipelinePath(0LL);
				// }
				// 
				return null;
			}
		}

		protected HGRenderPipelineResources()
		{
			// // SingletonScriptableObject`1[System.Object]()
			// void Beyond::SingletonScriptableObject<System::Object>::SingletonScriptableObject(
			//         SingletonScriptableObject_1_System_Object_ *this,
			//         MethodInfo *method)
			// {
			//   UnityEngine::ScriptableObject::ScriptableObject((ScriptableObject *)this, 0LL);
			// }
			// 
		}
	}
}
