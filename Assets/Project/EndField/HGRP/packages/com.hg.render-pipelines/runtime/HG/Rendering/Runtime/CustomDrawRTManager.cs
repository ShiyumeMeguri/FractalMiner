using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class CustomDrawRTManager // TypeDefIndex: 37898
	{
		// Fields
		private static CustomDrawRTManager s_instance; // 0x00
		private CommandBuffer m_CommandBuffer; // 0x10
		private MaterialPropertyBlock m_Props; // 0x18
		private long m_CppImpl; // 0x20
	
		// Properties
		public static CustomDrawRTManager Instance { get => default; } // 0x00000001844EA970-0x00000001844EA9A0 
		// CustomDrawRTManager get_Instance()
		CustomDrawRTManager *HG::Rendering::Runtime::CustomDrawRTManager::get_Instance(MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2248, 0LL) )
		    return TypeInfo::HG::Rendering::Runtime::CustomDrawRTManager->static_fields->s_instance;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2248, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v4, v3);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_906(Patch, 0LL);
		}
		
		public static bool EnableCppCustomDraw { get; set; } // 0x0000000184DA1390-0x0000000184DA13B0 0x0000000184DA13B0-0x0000000184DA13D0
		// Boolean get_EnableCppCustomDraw()
		bool HG::Rendering::Runtime::CustomDrawRTManager::get_EnableCppCustomDraw(MethodInfo *method)
		{
		  return TypeInfo::HG::Rendering::Runtime::CustomDrawRTManager->static_fields->_EnableCppCustomDraw_k__BackingField;
		}
		

		// Void set_EnableCppCustomDraw(Boolean)
		void HG::Rendering::Runtime::CustomDrawRTManager::set_EnableCppCustomDraw(bool value, MethodInfo *method)
		{
		  TypeInfo::HG::Rendering::Runtime::CustomDrawRTManager->static_fields->_EnableCppCustomDraw_k__BackingField = value;
		}
		
	
		// Nested types
		private struct AutoRestRT : IDisposable // TypeDefIndex: 37897
		{
			// Fields
			private RenderTexture rt; // 0x00
	
			// Constructors
			public AutoRestRT(RenderTexture _rt) {
				rt = default;
			} // 0x0000000189B429D0-0x0000000189B42A08
			// CustomDrawRTManager+AutoRestRT(RenderTexture)
			void HG::Rendering::Runtime::CustomDrawRTManager::AutoRestRT::AutoRestRT(
			        CustomDrawRTManager_AutoRestRT *this,
			        RenderTexture *_rt,
			        MethodInfo *method)
			{
			  Type *v5; // rdx
			  PropertyInfo_1 *v6; // r8
			  Int32__Array **v7; // r9
			  MethodInfo *v8; // [rsp+20h] [rbp-8h]
			
			  this->rt = UnityEngine::RenderTexture::GetActive(0LL);
			  sub_18002D1B0((SingleFieldAccessor *)this, v5, v6, v7, v8);
			  UnityEngine::RenderTexture::SetActive(_rt, 0LL);
			}
			
	
			// Methods
			public void Dispose() {} // 0x0000000189B42980-0x0000000189B429D0
			// Void Dispose()
			void HG::Rendering::Runtime::CustomDrawRTManager::AutoRestRT::Dispose(
			        CustomDrawRTManager_AutoRestRT *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v4; // rdx
			  __int64 v5; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(2256, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(2256, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v5, v4);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_910(Patch, this, 0LL);
			  }
			  else
			  {
			    UnityEngine::RenderTexture::SetActive(this->rt, 0LL);
			  }
			}
			
		}
	
		// Constructors
		public CustomDrawRTManager() {} // Dummy constructor
		private CustomDrawRTManager(long cppImpl) {} // 0x00000001849B0FA0-0x00000001849B1020
		// CustomDrawRTManager(Int64)
		void HG::Rendering::Runtime::CustomDrawRTManager::CustomDrawRTManager(
		        CustomDrawRTManager *this,
		        int64_t cppImpl,
		        MethodInfo *method)
		{
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  CommandBuffer *v6; // rdi
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  MaterialPropertyBlock *v10; // rdi
		  Type *v11; // rdx
		  PropertyInfo_1 *v12; // r8
		  Int32__Array **v13; // r9
		  MethodInfo *v14; // [rsp+20h] [rbp-8h]
		  MethodInfo *v15; // [rsp+50h] [rbp+28h]
		
		  this->fields.m_CppImpl = cppImpl;
		  v6 = (CommandBuffer *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::CommandBuffer);
		  if ( !v6
		    || (v6->fields.m_Ptr = UnityEngine::Rendering::CommandBuffer::InitBuffer(0LL),
		        this->fields.m_CommandBuffer = v6,
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields, v7, v8, v9, v14),
		        (v10 = (MaterialPropertyBlock *)sub_1800368D0(TypeInfo::UnityEngine::MaterialPropertyBlock)) == 0LL) )
		  {
		    sub_1800D8260(v5, v4);
		  }
		  v10->fields.m_Ptr = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL);
		  this->fields.m_Props = v10;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_Props, v11, v12, v13, v15);
		}
		
	
		// Methods
		public static void Init(long customDrawRTManager) {} // 0x00000001849B0F20-0x00000001849B0FA0
		// Void Init(Int64)
		void HG::Rendering::Runtime::CustomDrawRTManager::Init(int64_t customDrawRTManager, MethodInfo *method)
		{
		  CustomDrawRTManager *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  CustomDrawRTManager *v6; // rbx
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v11; // [rsp+20h] [rbp-8h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2249, 0LL) )
		  {
		    v3 = (CustomDrawRTManager *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::CustomDrawRTManager);
		    v6 = v3;
		    if ( v3 )
		    {
		      HG::Rendering::Runtime::CustomDrawRTManager::CustomDrawRTManager(v3, customDrawRTManager, 0LL);
		      TypeInfo::HG::Rendering::Runtime::CustomDrawRTManager->static_fields->s_instance = v6;
		      sub_18002D1B0(
		        (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::CustomDrawRTManager->static_fields,
		        v7,
		        v8,
		        v9,
		        v11);
		      return;
		    }
		LABEL_4:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2249, 0LL);
		  if ( !Patch )
		    goto LABEL_4;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_141((ILFixDynamicMethodWrapper_18 *)Patch, customDrawRTManager, 0LL);
		}
		
		public static void Reset() {} // 0x0000000183949D30-0x0000000183949D80
		// Void Reset()
		void HG::Rendering::Runtime::CustomDrawRTManager::Reset(MethodInfo *method)
		{
		  Type *v1; // rdx
		  PropertyInfo_1 *v2; // r8
		  Int32__Array **v3; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  MethodInfo *v7; // [rsp+50h] [rbp+28h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(526, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(526, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_9((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		  }
		  else
		  {
		    TypeInfo::HG::Rendering::Runtime::CustomDrawRTManager->static_fields->s_instance = 0LL;
		    sub_18002D1B0(
		      (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::CustomDrawRTManager->static_fields,
		      v1,
		      v2,
		      v3,
		      v7);
		  }
		}
		
		public RenderTexture AllocateRenderTexture(int width, int height, int mipCount = 1 /* Metadata: 0x023031D4 */, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB /* Metadata: 0x023031D5 */, GraphicsFormat depthStencilFormat = GraphicsFormat.None /* Metadata: 0x023031D6 */) => default; // 0x0000000183DB9B10-0x0000000183DB9BB0
		// RenderTexture AllocateRenderTexture(Int32, Int32, Int32, GraphicsFormat, GraphicsFormat)
		RenderTexture *HG::Rendering::Runtime::CustomDrawRTManager::AllocateRenderTexture(
		        CustomDrawRTManager *this,
		        int32_t width,
		        int32_t height,
		        int32_t mipCount,
		        GraphicsFormat__Enum colorFormat,
		        GraphicsFormat__Enum depthStencilFormat,
		        MethodInfo *method)
		{
		  __int64 v12; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2250, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2250, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v12);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_909(
		             Patch,
		             (Object *)this,
		             width,
		             height,
		             mipCount,
		             colorFormat,
		             depthStencilFormat,
		             0LL);
		  }
		  else if ( TypeInfo::HG::Rendering::Runtime::CustomDrawRTManager->static_fields->_EnableCppCustomDraw_k__BackingField )
		  {
		    return UnityEngine::HyperGryphEngineCode::HGRenderGraphCPP::CustomDrawRTManager_AllocateRenderTexture(
		             this->fields.m_CppImpl,
		             width,
		             height,
		             1,
		             mipCount,
		             colorFormat,
		             depthStencilFormat,
		             0LL);
		  }
		  else
		  {
		    if ( !TypeInfo::HG::Rendering::Runtime::RenderTextureManager->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::RenderTextureManager);
		    return HG::Rendering::Runtime::RenderTextureManager::GetRenderTexture(
		             (String *)"",
		             width,
		             height,
		             0,
		             1,
		             1,
		             1,
		             0,
		             0,
		             1,
		             GraphicsFormat__Enum_None,
		             0LL);
		  }
		}
		
		public void ReleaseRenderTexture(RenderTexture rt) {} // 0x000000018485E9A0-0x000000018485EA00
		// Void ReleaseRenderTexture(RenderTexture)
		void HG::Rendering::Runtime::CustomDrawRTManager::ReleaseRenderTexture(
		        CustomDrawRTManager *this,
		        RenderTexture *rt,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2253, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2253, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)rt,
		      0LL);
		  }
		  else if ( TypeInfo::HG::Rendering::Runtime::CustomDrawRTManager->static_fields->_EnableCppCustomDraw_k__BackingField )
		  {
		    UnityEngine::HyperGryphEngineCode::HGRenderGraphCPP::CustomDrawRTManager_ReleaseRenderTexture(
		      this->fields.m_CppImpl,
		      rt,
		      0LL);
		  }
		  else
		  {
		    if ( !TypeInfo::HG::Rendering::Runtime::RenderTextureManager->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::RenderTextureManager);
		    HG::Rendering::Runtime::RenderTextureManager::ReleaseRenderTexture(rt, 0LL);
		  }
		}
		
		public void ClearTexture(RenderTexture rt, UnityEngine.Color color) {} // 0x00000001845540D0-0x0000000184554240
		// Void ClearTexture(RenderTexture, Color)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::CustomDrawRTManager::ClearTexture(
		        CustomDrawRTManager *this,
		        RenderTexture *rt,
		        Color *color,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  CustomDrawRTManager__StaticFields *static_fields; // rcx
		  int64_t m_CppImpl; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  CustomDrawRTManager_AutoRestRT v13; // [rsp+30h] [rbp-48h] BYREF
		  Il2CppExceptionWrapper *v14; // [rsp+38h] [rbp-40h] BYREF
		  _QWORD v15[2]; // [rsp+40h] [rbp-38h] BYREF
		  Color backgroundColor; // [rsp+50h] [rbp-28h] BYREF
		
		  v13.rt = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2255, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2255, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v12, v11);
		    backgroundColor = *color;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_911(Patch, (Object *)this, (Object *)rt, &backgroundColor, 0LL);
		  }
		  else
		  {
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    }
		    if ( !UnityEngine::Object::CompareBaseObjects((Object_1 *)rt, 0LL, 0LL) )
		    {
		      static_fields = TypeInfo::HG::Rendering::Runtime::CustomDrawRTManager->static_fields;
		      if ( static_fields->_EnableCppCustomDraw_k__BackingField )
		      {
		        m_CppImpl = this->fields.m_CppImpl;
		        if ( !rt )
		          sub_1800D8260(static_fields, v7);
		        UnityEngine::HyperGryphEngineCode::HGRenderGraphCPP::CustomDrawRTManager_ClearTextureImpl(
		          m_CppImpl,
		          rt->fields._._.m_CachedPtr,
		          color,
		          0LL);
		      }
		      else
		      {
		        HG::Rendering::Runtime::CustomDrawRTManager::AutoRestRT::AutoRestRT(&v13, rt, 0LL);
		        v15[0] = 0LL;
		        v15[1] = &v13;
		        try
		        {
		          backgroundColor = *color;
		          UnityEngine::GL::GLClear_Injected(1, 1, &backgroundColor, 1.0, 0LL);
		        }
		        catch ( Il2CppExceptionWrapper *v14 )
		        {
		          v15[0] = v14->ex;
		        }
		        sub_18026A270(v15);
		      }
		    }
		  }
		}
		
		public void DrawTexture(RenderTexture rt, [IsReadOnly] in Rect rect, Texture texture, Material mat) {} // 0x00000001841D14A0-0x00000001841D1800
		// Void DrawTexture(RenderTexture, Rect ByRef, Texture, Material)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::CustomDrawRTManager::DrawTexture(
		        CustomDrawRTManager *this,
		        RenderTexture *rt,
		        Rect *rect,
		        Texture *texture,
		        Material *mat,
		        MethodInfo *method)
		{
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  CommandBuffer *m_CommandBuffer; // r15
		  Rect v13; // xmm6
		  int v14; // eax
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  float m_Width; // xmm4_4
		  float v18; // xmm3_4
		  void (__fastcall *v19)(CommandBuffer *, _DWORD *); // rax
		  __int64 v20; // rdx
		  MaterialPropertyBlock *m_Props; // rcx
		  __int64 v22; // rdx
		  MaterialPropertyBlock *v23; // rcx
		  CommandBuffer *v24; // rcx
		  Matrix4x4__StaticFields *static_fields; // rdx
		  MaterialPropertyBlock *v26; // rax
		  CommandBuffer *v27; // rdi
		  __int64 v28; // rdx
		  CommandBuffer *v29; // rcx
		  __int64 v30; // rdx
		  MaterialPropertyBlock *v31; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v33; // rdx
		  __int64 v34; // rcx
		  __int64 v35; // rax
		  CustomDrawRTManager_AutoRestRT v36; // [rsp+50h] [rbp-B8h] BYREF
		  _DWORD v37[4]; // [rsp+60h] [rbp-A8h] BYREF
		  _QWORD v38[2]; // [rsp+70h] [rbp-98h] BYREF
		  Il2CppExceptionWrapper *v39; // [rsp+80h] [rbp-88h] BYREF
		  __m128i si128; // [rsp+90h] [rbp-78h] BYREF
		  Matrix4x4 identityMatrix; // [rsp+A0h] [rbp-68h] BYREF
		
		  v36.rt = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2257, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2257, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v34, v33);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_912(
		      Patch,
		      (Object *)this,
		      (Object *)rt,
		      rect,
		      (Object *)texture,
		      (Object *)mat,
		      0LL);
		  }
		  else
		  {
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    }
		    if ( !UnityEngine::Object::CompareBaseObjects((Object_1 *)rt, 0LL, 0LL) )
		    {
		      if ( TypeInfo::HG::Rendering::Runtime::CustomDrawRTManager->static_fields->_EnableCppCustomDraw_k__BackingField )
		      {
		        UnityEngine::HyperGryphEngineCode::HGRenderGraphCPP::CustomDrawRTManager_DrawTexture(
		          this->fields.m_CppImpl,
		          rt,
		          rect,
		          texture,
		          mat,
		          0,
		          0LL);
		      }
		      else
		      {
		        HG::Rendering::Runtime::CustomDrawRTManager::AutoRestRT::AutoRestRT(&v36, rt, 0LL);
		        v38[0] = 0LL;
		        v38[1] = &v36;
		        try
		        {
		          m_CommandBuffer = this->fields.m_CommandBuffer;
		          v13 = *rect;
		          if ( !rt )
		            sub_1800D8250(v11, v10);
		          v14 = sub_180002F70(7LL, rt);
		          m_Width = rect->m_Width;
		          v18 = (float)((float)v14 - rect->m_YMin) - rect->m_Height;
		          if ( !m_CommandBuffer )
		            sub_1800D8250(v16, v15);
		          v37[0] = LODWORD(v13.m_XMin);
		          *(float *)&v37[1] = v18;
		          *(float *)&v37[2] = m_Width;
		          v37[3] = LODWORD(rect->m_Height);
		          v19 = (void (__fastcall *)(CommandBuffer *, _DWORD *))qword_18F3AB4F8;
		          if ( !qword_18F3AB4F8 )
		          {
		            v19 = (void (__fastcall *)(CommandBuffer *, _DWORD *))il2cpp_resolve_icall_1(
		                                                                    "UnityEngine.Rendering.CommandBuffer::SetViewport_Inj"
		                                                                    "ected(UnityEngine.Rect&)");
		            if ( !v19 )
		            {
		              v35 = sub_1802EE1B8("UnityEngine.Rendering.CommandBuffer::SetViewport_Injected(UnityEngine.Rect&)");
		              sub_18007E1B0(v35, 0LL);
		            }
		            qword_18F3AB4F8 = (__int64)v19;
		          }
		          v19(m_CommandBuffer, v37);
		          m_Props = this->fields.m_Props;
		          if ( !m_Props )
		            sub_1800D8250(0LL, v20);
		          UnityEngine::MaterialPropertyBlock::HGSetTexture(m_Props, (String *)"_MainTex", texture, 0LL);
		          v23 = this->fields.m_Props;
		          if ( !v23 )
		            sub_1800D8250(0LL, v22);
		          si128 = _mm_load_si128((const __m128i *)&xmmword_18B959740);
		          UnityEngine::MaterialPropertyBlock::SetVector(v23, (String *)"_MainTex_ST", (Vector4 *)&si128, 0LL);
		          v24 = this->fields.m_CommandBuffer;
		          static_fields = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		          v26 = this->fields.m_Props;
		          if ( !v24 )
		            sub_1800D8250(0LL, static_fields);
		          identityMatrix = static_fields->identityMatrix;
		          UnityEngine::Rendering::CommandBuffer::DrawProcedural(
		            v24,
		            &identityMatrix,
		            mat,
		            0,
		            MeshTopology__Enum_Triangles,
		            3,
		            1,
		            v26,
		            0LL);
		          v27 = this->fields.m_CommandBuffer;
		          if ( !TypeInfo::UnityEngine::Graphics->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Graphics);
		          UnityEngine::Graphics::ExecuteCommandBuffer(v27, 0LL);
		          v29 = this->fields.m_CommandBuffer;
		          if ( !v29 )
		            sub_1800D8250(0LL, v28);
		          UnityEngine::Rendering::CommandBuffer::Clear(v29, 0LL);
		          v31 = this->fields.m_Props;
		          if ( !v31 )
		            sub_1800D8250(0LL, v30);
		          UnityEngine::MaterialPropertyBlock::Clear(v31, 1, 0LL);
		        }
		        catch ( Il2CppExceptionWrapper *v39 )
		        {
		          v38[0] = v39->ex;
		        }
		        sub_18026A270(v38);
		      }
		    }
		  }
		}
		
	}
}
