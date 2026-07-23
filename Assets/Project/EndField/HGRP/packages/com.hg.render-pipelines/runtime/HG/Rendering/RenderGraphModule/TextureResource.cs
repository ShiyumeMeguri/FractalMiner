using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.RenderGraphModule
{
	[DebuggerDisplay("TextureResource ({desc.name})")]
	internal class TextureResource : HGRenderGraphResource<HG.Rendering.RenderGraphModule.TextureDesc, RTHandle> // TypeDefIndex: 37472
	{
		// Fields
		private static int m_TextureCreationIndex; // 0x00
	
		// Properties
		public bool needsClear { get; set; } // 0x0000000184D88020-0x0000000184D88030 0x0000000184D88040-0x0000000184D88050
		// Boolean get_isInBlackScreen()
		bool Beyond::Gameplay::Core::EncounterBase<System::Object>::get_isInBlackScreen(
		        EncounterBase_1_System_Object_ *this,
		        MethodInfo *method)
		{
		  return this->fields._isInBlackScreen_k__BackingField;
		}
		

		// Void set_isInBlackScreen(Boolean)
		void Beyond::Gameplay::Core::EncounterBase<System::Object>::set_isInBlackScreen(
		        EncounterBase_1_System_Object_ *this,
		        bool value,
		        MethodInfo *method)
		{
		  this->fields._isInBlackScreen_k__BackingField = value;
		}
		
	
		// Constructors
		public TextureResource() {} // 0x00000001841E1670-0x00000001841E1680
		// Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
		void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
		        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
		        HGWindConfig *cSrc,
		        HGWindConfig *cDst,
		        float t,
		        MethodInfo *method)
		{
		  ;
		}
		
	
		// Methods
		public override string GetName() => default; // 0x0000000189B42328-0x0000000189B423A8
		// String GetName()
		String *HG::Rendering::RenderGraphModule::TextureResource::GetName(TextureResource *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(327, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(327, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		  }
		  else if ( !this->fields._._.imported || this->fields._._.preserved )
		  {
		    return this->fields._.desc.name;
		  }
		  else if ( this->fields._.graphicsResource )
		  {
		    return this->fields._.graphicsResource->fields.m_Name;
		  }
		  else
		  {
		    return (String *)"null resource";
		  }
		}
		
		public void CopyFrom(TextureResource other) {} // 0x0000000189B41F84-0x0000000189B41FFC
		// Void CopyFrom(TextureResource)
		void HG::Rendering::RenderGraphModule::TextureResource::CopyFrom(
		        TextureResource *this,
		        TextureResource *other,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(161, 0LL) )
		  {
		    HG::Rendering::RenderGraphModule::HGRenderGraphResource<HG::Rendering::RenderGraphModule::TextureDesc,System::Object>::CopyFrom(
		      (HGRenderGraphResource_2_TextureDesc_System_Object_ *)this,
		      (HGRenderGraphResource_2_TextureDesc_System_Object_ *)other,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResource<HG::Rendering::RenderGraphModule::TextureDesc,UnityEngine::Rendering::RTHandle>::CopyFrom);
		    if ( other )
		    {
		      this->fields._needsClear_k__BackingField = other->fields._needsClear_k__BackingField;
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(161, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)other,
		    0LL);
		}
		
		public override void CreatePooledGraphicsResource(bool frameRegister = true /* Metadata: 0x02302D96 */, string name = "" /* Metadata: 0x02302D97 */) {} // 0x0000000189B421B4-0x0000000189B42328
		// Void CreatePooledGraphicsResource(Boolean, String)
		void HG::Rendering::RenderGraphModule::TextureResource::CreatePooledGraphicsResource(
		        TextureResource *this,
		        bool frameRegister,
		        String *name,
		        MethodInfo *method)
		{
		  int32_t HashCode; // esi
		  RenderGraphResourcePool_1_System_Object_ *v8; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  RenderGraphResourcePool_1_System_Object_ *v11; // rdi
		  bool Resource; // al
		  Object *v13; // rbx
		  String *v14; // rax
		  String *v15; // rdi
		  __int64 v16; // rax
		  ProtocolViolationException *v17; // rax
		  ProtocolViolationException *v18; // rbx
		  __int64 v19; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(328, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(328, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_206(
		        (ILFixDynamicMethodWrapper_6 *)Patch,
		        (Object *)this,
		        frameRegister,
		        (Object *)name,
		        0LL);
		      return;
		    }
		LABEL_9:
		    sub_1800D8260(v10, v9);
		  }
		  HashCode = HG::Rendering::RenderGraphModule::TextureDesc::GetHashCode(&this->fields._.desc, 0LL);
		  if ( this->fields._.graphicsResource )
		  {
		    v13 = (Object *)sub_180032CB0(5LL, this);
		    v14 = (String *)sub_18007E180(&off_18E25BED0);
		    v15 = System::String::Format(v14, v13, 0LL);
		    v16 = sub_18007E180(&TypeInfo::System::InvalidOperationException);
		    v17 = (ProtocolViolationException *)sub_18002C620(v16);
		    v18 = v17;
		    if ( v17 )
		    {
		      System::Net::ProtocolViolationException::ProtocolViolationException(v17, v15, 0LL);
		      v19 = sub_18007E180(&MethodInfo::HG::Rendering::RenderGraphModule::TextureResource::CreatePooledGraphicsResource);
		      sub_18007E190(v18, v19);
		    }
		    goto LABEL_9;
		  }
		  v8 = (RenderGraphResourcePool_1_System_Object_ *)sub_180005050(
		                                                     this->fields._._.m_Pool,
		                                                     TypeInfo::HG::Rendering::RenderGraphModule::TexturePool);
		  v11 = v8;
		  if ( !v8 )
		    goto LABEL_9;
		  Resource = UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraphResourcePool<System::Object>::TryGetResource(
		               v8,
		               HashCode,
		               (Object **)&this->fields._.graphicsResource,
		               MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<UnityEngine::Rendering::RTHandle>::TryGetResource);
		  sub_180052100((unsigned __int16)(Resource + 10), this, name);
		  this->fields._._.cachedHash = HashCode;
		  if ( frameRegister )
		    UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraphResourcePool<System::Object>::RegisterFrameAllocation(
		      v11,
		      HashCode,
		      (Object *)this->fields._.graphicsResource,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<UnityEngine::Rendering::RTHandle>::RegisterFrameAllocation);
		}
		
		public override void ReleasePooledGraphicsResource(int frameIndex, bool reset = true /* Metadata: 0x02302D98 */) {} // 0x0000000189B425F8-0x0000000189B42760
		// Void ReleasePooledGraphicsResource(Int32, Boolean)
		void HG::Rendering::RenderGraphModule::TextureResource::ReleasePooledGraphicsResource(
		        TextureResource *this,
		        int32_t frameIndex,
		        bool reset,
		        MethodInfo *method)
		{
		  RenderGraphResourcePool_1_System_Object_ *v7; // rax
		  __int64 v8; // rcx
		  RenderGraphResourcePool_1_System_Object_ *v9; // rdi
		  String *v10; // rdi
		  String *v11; // rbx
		  String *v12; // rax
		  String *v13; // rdi
		  __int64 v14; // rax
		  ProtocolViolationException *v15; // rax
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  ProtocolViolationException *v18; // rbx
		  __int64 v19; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(329, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(329, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_28(
		        (ILFixDynamicMethodWrapper_8 *)Patch,
		        (Object *)this,
		        (EnergyShardType__Enum)frameIndex,
		        reset,
		        0LL);
		      return;
		    }
		LABEL_10:
		    sub_1800D8260(v17, v16);
		  }
		  if ( !this->fields._.graphicsResource )
		  {
		    v10 = (String *)sub_180032CB0(5LL, this);
		    v11 = (String *)sub_18007E180(&off_18E25BE48);
		    v12 = (String *)sub_18007E180(&off_18E25BE58);
		    v13 = System::String::Concat(v12, v10, v11, 0LL);
		    v14 = sub_18007E180(&TypeInfo::System::InvalidOperationException);
		    v15 = (ProtocolViolationException *)sub_18002C620(v14);
		    v18 = v15;
		    if ( v15 )
		    {
		      System::Net::ProtocolViolationException::ProtocolViolationException(v15, v13, 0LL);
		      v19 = sub_18007E180(&MethodInfo::HG::Rendering::RenderGraphModule::TextureResource::ReleasePooledGraphicsResource);
		      sub_18007E190(v18, v19);
		    }
		    goto LABEL_10;
		  }
		  v7 = (RenderGraphResourcePool_1_System_Object_ *)sub_180005050(
		                                                     this->fields._._.m_Pool,
		                                                     TypeInfo::HG::Rendering::RenderGraphModule::TexturePool);
		  v9 = v7;
		  if ( v7 )
		  {
		    UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraphResourcePool<System::Object>::ReleaseResource(
		      v7,
		      this->fields._._.cachedHash,
		      (Object *)this->fields._.graphicsResource,
		      frameIndex,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<UnityEngine::Rendering::RTHandle>::ReleaseResource);
		    UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraphResourcePool<System::Object>::UnregisterFrameAllocation(
		      v9,
		      this->fields._._.cachedHash,
		      (Object *)this->fields._.graphicsResource,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<UnityEngine::Rendering::RTHandle>::UnregisterFrameAllocation);
		  }
		  if ( reset )
		    sub_180082E60(v8, this, 0LL);
		}
		
		public override void Preserve(int currentExecutorID, int currentExecutorFrameIndex, int frameCount) {} // 0x0000000189B424F0-0x0000000189B4258C
		// Void Preserve(Int32, Int32, Int32)
		void HG::Rendering::RenderGraphModule::TextureResource::Preserve(
		        TextureResource *this,
		        int32_t currentExecutorID,
		        int32_t currentExecutorFrameIndex,
		        int32_t frameCount,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(330, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(330, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_247(
		      (ILFixDynamicMethodWrapper_6 *)Patch,
		      (Object *)this,
		      currentExecutorID,
		      currentExecutorFrameIndex,
		      frameCount,
		      0LL);
		  }
		  else if ( sub_180005050(this->fields._._.m_Pool, TypeInfo::HG::Rendering::RenderGraphModule::TexturePool) )
		  {
		    this->fields._._.preserved = 1;
		    this->fields._._.preservedExecutorID = currentExecutorID;
		    this->fields._._.preservedExecutorFrameIndex = currentExecutorFrameIndex;
		    this->fields._._.preservedResourceLifeSpan = frameCount;
		  }
		}
		
		public override void CreateGraphicsResource(string name = "" /* Metadata: 0x02302D99 */) {} // 0x0000000189B41FFC-0x0000000189B421B4
		// Void CreateGraphicsResource(String)
		void HG::Rendering::RenderGraphModule::TextureResource::CreateGraphicsResource(
		        TextureResource *this,
		        String *name,
		        MethodInfo *method)
		{
		  bool enableRandomWrite; // r13
		  bool useMipMap; // r12
		  bool autoGenerateMips; // r15
		  bool isShadowMap; // r14
		  int32_t anisoLevel; // ebp
		  float mipMapBias; // xmm6_4
		  unsigned int msaaSamples; // esi
		  bool bindTextureMS; // di
		  int32_t v13; // eax
		  unsigned int memoryless; // ebx
		  Type *v15; // rdx
		  PropertyInfo_1 *v16; // r8
		  Int32__Array **v17; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v19; // rdx
		  __int64 v20; // rcx
		  MethodInfo *colorFormat; // [rsp+20h] [rbp-E8h]
		  TextureWrapMode__Enum wrapMode; // [rsp+A0h] [rbp-68h]
		  FilterMode__Enum filterMode; // [rsp+A4h] [rbp-64h]
		  GraphicsFormat__Enum v24; // [rsp+A8h] [rbp-60h]
		  DepthBits__Enum depthBufferBits; // [rsp+ACh] [rbp-5Ch]
		  int32_t slices; // [rsp+B0h] [rbp-58h]
		  int32_t height; // [rsp+B4h] [rbp-54h]
		  int32_t width; // [rsp+B8h] [rbp-50h]
		  TextureDimension__Enum dimension; // [rsp+128h] [rbp+20h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(331, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(331, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v20, v19);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)name,
		      0LL);
		  }
		  else
		  {
		    enableRandomWrite = this->fields._.desc.enableRandomWrite;
		    useMipMap = this->fields._.desc.useMipMap;
		    autoGenerateMips = this->fields._.desc.autoGenerateMips;
		    isShadowMap = this->fields._.desc.isShadowMap;
		    anisoLevel = this->fields._.desc.anisoLevel;
		    mipMapBias = this->fields._.desc.mipMapBias;
		    msaaSamples = this->fields._.desc.msaaSamples;
		    bindTextureMS = this->fields._.desc.bindTextureMS;
		    width = this->fields._.desc.width;
		    height = this->fields._.desc.height;
		    slices = this->fields._.desc.slices;
		    depthBufferBits = this->fields._.desc.depthBufferBits;
		    v24 = this->fields._.desc.colorFormat;
		    filterMode = this->fields._.desc.filterMode;
		    wrapMode = this->fields._.desc.wrapMode;
		    v13 = this->fields._.desc.dimension;
		    memoryless = this->fields._.desc.memoryless;
		    dimension = v13;
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::RTHandles);
		    this->fields._.graphicsResource = UnityEngine::Rendering::RTHandles::Alloc(
		                                        width,
		                                        height,
		                                        slices,
		                                        depthBufferBits,
		                                        v24,
		                                        filterMode,
		                                        wrapMode,
		                                        dimension,
		                                        enableRandomWrite,
		                                        useMipMap,
		                                        autoGenerateMips,
		                                        isShadowMap,
		                                        anisoLevel,
		                                        mipMapBias,
		                                        (MSAASamples__Enum)msaaSamples,
		                                        bindTextureMS,
		                                        (RenderTextureMemoryless__Enum)memoryless,
		                                        name,
		                                        0LL);
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields._.graphicsResource, v15, v16, v17, colorFormat);
		  }
		}
		
		public override void RenameGraphicsResource(string name = "" /* Metadata: 0x02302D9A */) {} // 0x0000000189B42760-0x0000000189B427B4
		// Void RenameGraphicsResource(String)
		void HG::Rendering::RenderGraphModule::TextureResource::RenameGraphicsResource(
		        TextureResource *this,
		        String *name,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(332, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(332, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)name,
		      0LL);
		  }
		}
		
		public override void ReleaseGraphicsResource() {} // 0x0000000189B4258C-0x0000000189B425F8
		// Void ReleaseGraphicsResource()
		void HG::Rendering::RenderGraphModule::TextureResource::ReleaseGraphicsResource(
		        TextureResource *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(333, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(333, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    if ( this->fields._.graphicsResource )
		      UnityEngine::Rendering::RTHandle::Release(this->fields._.graphicsResource, 0LL);
		    this->fields._.graphicsResource = 0LL;
		  }
		}
		
		public override void LogCreation(HGRenderGraphLogger logger) {} // 0x0000000189B423A8-0x0000000189B42460
		// Void LogCreation(HGRenderGraphLogger)
		void HG::Rendering::RenderGraphModule::TextureResource::LogCreation(
		        TextureResource *this,
		        HGRenderGraphLogger *logger,
		        MethodInfo *method)
		{
		  Object *name; // rbx
		  Object *v6; // rax
		  String *v7; // rbx
		  Object__Array *v8; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  bool clearBuffer; // [rsp+48h] [rbp+20h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(334, 0LL) )
		  {
		    name = (Object *)this->fields._.desc.name;
		    clearBuffer = this->fields._.desc.clearBuffer;
		    v6 = (Object *)il2cpp_value_box_0(TypeInfo::System::Boolean, &clearBuffer);
		    v7 = System::String::Format((String *)"Created Texture: {0} (Cleared: {1})", name, v6, 0LL);
		    v8 = (Object__Array *)sub_183AD6530(MethodInfo::System::Array::Empty<System::Object>);
		    if ( logger )
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphLogger::LogLine(logger, v7, v8, 0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v10, v9);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(334, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)logger,
		    0LL);
		}
		
		public override void LogRelease(HGRenderGraphLogger logger) {} // 0x0000000189B42460-0x0000000189B424F0
		// Void LogRelease(HGRenderGraphLogger)
		void HG::Rendering::RenderGraphModule::TextureResource::LogRelease(
		        TextureResource *this,
		        HGRenderGraphLogger *logger,
		        MethodInfo *method)
		{
		  String *v5; // rdi
		  Object__Array *v6; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(335, 0LL) )
		  {
		    v5 = System::String::Concat((String *)"Released Texture: ", this->fields._.desc.name, 0LL);
		    v6 = (Object__Array *)sub_183AD6530(MethodInfo::System::Array::Empty<System::Object>);
		    if ( logger )
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphLogger::LogLine(logger, v5, v6, 0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v8, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(335, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)logger,
		    0LL);
		}
		
		public string __iFixBaseProxy_GetName() => default; // 0x0000000189B356A0-0x0000000189B356A8
		// String <>iFixBaseProxy_GetName()
		String *HG::Rendering::RenderGraphModule::TextureResource::__iFixBaseProxy_GetName(
		        TextureResource *this,
		        MethodInfo *method)
		{
		  return HG::Rendering::RenderGraphModule::IHGRenderGraphResource::GetName((IHGRenderGraphResource *)this, 0LL);
		}
		
		public void __iFixBaseProxy_CreatePooledGraphicsResource(bool P0, string P1) {} // 0x0000000189B35698-0x0000000189B356A0
		// Void <>iFixBaseProxy_CreatePooledGraphicsResource(Boolean, String)
		void HG::Rendering::RenderGraphModule::TextureResource::__iFixBaseProxy_CreatePooledGraphicsResource(
		        TextureResource *this,
		        bool P0,
		        String *P1,
		        MethodInfo *method)
		{
		  HG::Rendering::RenderGraphModule::IHGRenderGraphResource::CreatePooledGraphicsResource(
		    (IHGRenderGraphResource *)this,
		    P0,
		    P1,
		    0LL);
		}
		
		public void __iFixBaseProxy_ReleasePooledGraphicsResource(int P0, bool P1) {} // 0x0000000189B356C0-0x0000000189B356C8
		// Void <>iFixBaseProxy_ReleasePooledGraphicsResource(Int32, Boolean)
		void HG::Rendering::RenderGraphModule::TextureResource::__iFixBaseProxy_ReleasePooledGraphicsResource(
		        TextureResource *this,
		        int32_t P0,
		        bool P1,
		        MethodInfo *method)
		{
		  HG::Rendering::RenderGraphModule::IHGRenderGraphResource::ReleasePooledGraphicsResource(
		    (IHGRenderGraphResource *)this,
		    P0,
		    P1,
		    0LL);
		}
		
		public void __iFixBaseProxy_Preserve(int P0, int P1, int P2) {} // 0x0000000189B427B4-0x0000000189B427C4
		// Void <>iFixBaseProxy_Preserve(Int32, Int32, Int32)
		void HG::Rendering::RenderGraphModule::TextureResource::__iFixBaseProxy_Preserve(
		        TextureResource *this,
		        int32_t P0,
		        int32_t P1,
		        int32_t P2,
		        MethodInfo *method)
		{
		  HG::Rendering::RenderGraphModule::IHGRenderGraphResource::Preserve((IHGRenderGraphResource *)this, P0, P1, P2, 0LL);
		}
		
		public void __iFixBaseProxy_CreateGraphicsResource(string P0) {} // 0x0000000189B35690-0x0000000189B35698
		// Void <>iFixBaseProxy_CreateGraphicsResource(String)
		void HG::Rendering::RenderGraphModule::TextureResource::__iFixBaseProxy_CreateGraphicsResource(
		        TextureResource *this,
		        String *P0,
		        MethodInfo *method)
		{
		  HG::Rendering::RenderGraphModule::IHGRenderGraphResource::CreateGraphicsResource(
		    (IHGRenderGraphResource *)this,
		    P0,
		    0LL);
		}
		
		public void __iFixBaseProxy_RenameGraphicsResource(string P0) {} // 0x0000000189B427CC-0x0000000189B427D4
		// Void <>iFixBaseProxy_RenameGraphicsResource(String)
		void HG::Rendering::RenderGraphModule::TextureResource::__iFixBaseProxy_RenameGraphicsResource(
		        TextureResource *this,
		        String *P0,
		        MethodInfo *method)
		{
		  HG::Rendering::RenderGraphModule::IHGRenderGraphResource::RenameGraphicsResource(
		    (IHGRenderGraphResource *)this,
		    P0,
		    0LL);
		}
		
		public void __iFixBaseProxy_ReleaseGraphicsResource() {} // 0x0000000189B427C4-0x0000000189B427CC
		// Void <>iFixBaseProxy_ReleaseGraphicsResource()
		void HG::Rendering::RenderGraphModule::TextureResource::__iFixBaseProxy_ReleaseGraphicsResource(
		        TextureResource *this,
		        MethodInfo *method)
		{
		  HG::Rendering::RenderGraphModule::TextureResource::ReleaseGraphicsResource(this, 0LL);
		}
		
		public void __iFixBaseProxy_LogCreation(HGRenderGraphLogger P0) {} // 0x0000000189B356A8-0x0000000189B356B0
		// Void <>iFixBaseProxy_LogCreation(HGRenderGraphLogger)
		void HG::Rendering::RenderGraphModule::TextureResource::__iFixBaseProxy_LogCreation(
		        TextureResource *this,
		        HGRenderGraphLogger *P0,
		        MethodInfo *method)
		{
		  HG::Rendering::RenderGraphModule::IHGRenderGraphResource::LogCreation((IHGRenderGraphResource *)this, P0, 0LL);
		}
		
		public void __iFixBaseProxy_LogRelease(HGRenderGraphLogger P0) {} // 0x0000000189B356B0-0x0000000189B356B8
		// Void <>iFixBaseProxy_LogRelease(HGRenderGraphLogger)
		void HG::Rendering::RenderGraphModule::TextureResource::__iFixBaseProxy_LogRelease(
		        TextureResource *this,
		        HGRenderGraphLogger *P0,
		        MethodInfo *method)
		{
		  HG::Rendering::RenderGraphModule::IHGRenderGraphResource::LogRelease((IHGRenderGraphResource *)this, P0, 0LL);
		}
		
	}
}
