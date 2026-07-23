using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[CreateAssetMenu(fileName = "HGWaterSectorData", menuName = "\u2605 Beyond/HGWater/HGWaterSectorData")]
	public class HGWaterSectorData : ScriptableObject // TypeDefIndex: 38791
	{
		// Fields
		[Header("Flowmap")]
		public Texture2D waterSectorTexture0; // 0x18
		public Vector4[] rippleLayerBuffer; // 0x20
	
		// Constructors
		public HGWaterSectorData() {} // 0x000000018468BD30-0x000000018468BD70
		// HGWaterSectorData()
		void HG::Rendering::Runtime::HGWaterSectorData::HGWaterSectorData(HGWaterSectorData *this, MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v3; // rdx
		  HGRuntimeGrassQuery_Node *v4; // r8
		  Int32__Array **v5; // r9
		  MethodInfo *v6; // [rsp+20h] [rbp-8h]
		
		  this->fields.rippleLayerBuffer = (Vector4__Array *)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector4, 64LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.rippleLayerBuffer, v3, v4, v5, v6);
		  UnityEngine::ScriptableObject::ScriptableObject((ScriptableObject *)this, 0LL);
		}
		
	
		// Methods
		public static Texture2D GetWaterSectorTextureFromScriptableObject(ScriptableObject scriptableObject) => default; // 0x0000000189C7A1E8-0x0000000189C7A274
		// Texture2D GetWaterSectorTextureFromScriptableObject(ScriptableObject)
		Texture2D *HG::Rendering::Runtime::HGWaterSectorData::GetWaterSectorTextureFromScriptableObject(
		        ScriptableObject *scriptableObject,
		        MethodInfo *method)
		{
		  __int64 v3; // rbx
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2277, 0LL) )
		  {
		    v3 = sub_180005130(scriptableObject, TypeInfo::HG::Rendering::Runtime::HGWaterSectorData);
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( !UnityEngine::Object::op_Inequality(0LL, (Object_1 *)v3, 0LL) )
		      return 0LL;
		    if ( v3 )
		      return *(Texture2D **)(v3 + 24);
		LABEL_7:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2277, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_402(Patch, (Object *)scriptableObject, 0LL);
		}
		
		private void OnEnable() {} // 0x000000018447F6B0-0x000000018447F770
		// Void OnEnable()
		void HG::Rendering::Runtime::HGWaterSectorData::OnEnable(HGWaterSectorData *this, MethodInfo *method)
		{
		  int32_t InstanceID; // eax
		  __int64 v4; // rdx
		  struct Object_1__Class *v5; // rcx
		  int32_t v6; // ebx
		  Texture2D *waterSectorTexture0; // rsi
		  Object_1 *v8; // rcx
		  int32_t v9; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5397, 0LL) )
		  {
		    InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)this, 0LL);
		    v5 = TypeInfo::UnityEngine::Object;
		    v6 = InstanceID;
		    waterSectorTexture0 = this->fields.waterSectorTexture0;
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
		    if ( !waterSectorTexture0 )
		      goto LABEL_10;
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v5);
		    if ( !waterSectorTexture0->fields._._.m_CachedPtr )
		    {
		LABEL_10:
		      v9 = 0;
		      goto LABEL_9;
		    }
		    v8 = (Object_1 *)this->fields.waterSectorTexture0;
		    if ( v8 )
		    {
		      v9 = UnityEngine::Object::GetInstanceID(v8, 0LL);
		LABEL_9:
		      UnityEngine::HyperGryph::HGWaterRender::AddSectorTexture(v6, v9, 0LL);
		      return;
		    }
		LABEL_13:
		    sub_1800D8260(v8, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5397, 0LL);
		  if ( !Patch )
		    goto LABEL_13;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		private void OnDisable() {} // 0x0000000189C7A274-0x0000000189C7A2D0
		// Void OnDisable()
		void HG::Rendering::Runtime::HGWaterSectorData::OnDisable(HGWaterSectorData *this, MethodInfo *method)
		{
		  int32_t InstanceID; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5398, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5398, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)this, 0LL);
		    UnityEngine::HyperGryph::HGWaterRender::RemoveSectorTexture(InstanceID, 0LL);
		  }
		}
		
	}
}
