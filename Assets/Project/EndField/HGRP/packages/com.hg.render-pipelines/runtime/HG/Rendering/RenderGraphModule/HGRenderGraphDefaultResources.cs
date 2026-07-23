using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.RenderGraphModule
{
	public class HGRenderGraphDefaultResources // TypeDefIndex: 37435
	{
		// Fields
		private bool m_IsValid; // 0x10
		private RTHandle m_BlackTexture2D; // 0x18
		private RTHandle m_WhiteTexture2D; // 0x20
		private RTHandle m_ShadowTexture2D; // 0x28
		private RTHandle m_RedTexture2D; // 0x30
		private Texture2DArray m_BlackTextureArray; // 0x38
		private RTHandle m_BlackTextureArrayRTH; // 0x40
		private RTHandle m_DefaultShadowTextureArrayRTH; // 0x48
	
		// Properties
		public TextureHandle blackTexture { get; private set; } // 0x0000000184D8CE10-0x0000000184D8CE20 0x0000000184D906B0-0x0000000184D906C0
		// ValueTuple`2[Boolean,Object] get_ResultOnSuccess()
		ValueTuple_2_Boolean_Object_ *System::Threading::Tasks::Task<System::ValueTuple<bool,System::Object>>::get_ResultOnSuccess(
		        ValueTuple_2_Boolean_Object_ *__return_ptr retstr,
		        Task_1_System_ValueTuple_2_Boolean_Object_ *this,
		        MethodInfo *method)
		{
		  ValueTuple_2_Boolean_Object_ *result; // rax
		
		  result = retstr;
		  *retstr = this->fields.m_result;
		  return result;
		}
		

		// Void SetEmptyElement(RestoreRotationConstraint+RotationData)
		void MagicaCloth::FixedChunkNativeArray<MagicaCloth::RestoreRotationConstraint::RotationData>::SetEmptyElement(
		        FixedChunkNativeArray_1_RestoreRotationConstraint_RotationData_ *this,
		        RestoreRotationConstraint_RotationData *empty,
		        MethodInfo *method)
		{
		  this->fields.emptyElement = *empty;
		}
		
		public TextureHandle whiteTexture { get; private set; } // 0x0000000184DA1280-0x0000000184DA1290 0x0000000184DA1330-0x0000000184DA1340
		// Vector4 get_ChannelB()
		Vector4 *PaintIn3D::P3dPaintReplaceChannels::get_ChannelB(
		        Vector4 *__return_ptr retstr,
		        P3dPaintReplaceChannels *this,
		        MethodInfo *method)
		{
		  Vector4 *result; // rax
		
		  result = retstr;
		  *retstr = this->fields.channelB;
		  return result;
		}
		

		// Void set_Color(Color)
		void PaintIn3D::P3dPaintFill::set_Color(P3dPaintFill *this, Color *value, MethodInfo *method)
		{
		  this->fields.color = *value;
		}
		
		public TextureHandle redTexture { get; private set; } // 0x0000000184D8FD40-0x0000000184D8FD50 0x0000000184DA1310-0x0000000184DA1320
		// Playable get_playable()
		Playable *UnityEngine::Timeline::RuntimeClip::get_playable(
		        Playable *__return_ptr retstr,
		        RuntimeClip *this,
		        MethodInfo *method)
		{
		  Playable *result; // rax
		
		  result = retstr;
		  *retstr = this->fields.m_Playable;
		  return result;
		}
		

		// Void set_BlendColor(Color)
		void PaintIn3D::P3dGraduallyFade::set_BlendColor(P3dGraduallyFade *this, Color *value, MethodInfo *method)
		{
		  this->fields.blendColor = *value;
		}
		
		public TextureHandle blackTextureArray { get; private set; } // 0x0000000184D90620-0x0000000184D90630 0x0000000184D9DEE0-0x0000000184D9DEF0
		// AnimationClipPlayable get_playable()
		AnimationClipPlayable *Beyond::Playables::SingleMixerAssetPlayer_4_TAsset_TAssetPlayable_TMixer_TOutput_::PlayableNode<System::Object,UnityEngine::Animations::AnimationClipPlayable,UnityEngine::Animations::AnimationMixerPlayable,UnityEngine::Animations::AnimationPlayableOutput>::get_playable(
		        AnimationClipPlayable *__return_ptr retstr,
		        SingleMixerAssetPlayer_4_TAsset_TAssetPlayable_TMixer_TOutput_PlayableNode_System_Object_UnityEngine_Animations_AnimationClipPlayable_UnityEngine_Animations_AnimationMixerPlayable_UnityEngine_Animations_AnimationPlayableOutput_ *this,
		        MethodInfo *method)
		{
		  AnimationClipPlayable *result; // rax
		
		  result = retstr;
		  *retstr = this->fields._playable_k__BackingField;
		  return result;
		}
		

		// Void set_playable(AnimationClipPlayable)
		void Beyond::Playables::SingleMixerAssetPlayer_4_TAsset_TAssetPlayable_TMixer_TOutput_::PlayableNode<System::Object,UnityEngine::Animations::AnimationClipPlayable,UnityEngine::Animations::AnimationMixerPlayable,UnityEngine::Animations::AnimationPlayableOutput>::set_playable(
		        SingleMixerAssetPlayer_4_TAsset_TAssetPlayable_TMixer_TOutput_PlayableNode_System_Object_UnityEngine_Animations_AnimationClipPlayable_UnityEngine_Animations_AnimationMixerPlayable_UnityEngine_Animations_AnimationPlayableOutput_ *this,
		        AnimationClipPlayable *value,
		        MethodInfo *method)
		{
		  this->fields._playable_k__BackingField = *value;
		}
		
		public TextureHandle clearTextureXR { get; private set; } // 0x0000000184D9DC90-0x0000000184D9DCA0 0x0000000184DA12D0-0x0000000184DA12E0
		// NpcProxyOverrideEnvTalk+EnvTalkStruct get_value()
		NpcProxyOverrideEnvTalk_EnvTalkStruct *Beyond::Gameplay::ParamVariable<Beyond::Gameplay::Actions::NpcProxyOverrideEnvTalk::EnvTalkStruct>::get_value(
		        NpcProxyOverrideEnvTalk_EnvTalkStruct *__return_ptr retstr,
		        ParamVariable_1_Beyond_Gameplay_Actions_NpcProxyOverrideEnvTalk_EnvTalkStruct_ *this,
		        MethodInfo *method)
		{
		  NpcProxyOverrideEnvTalk_EnvTalkStruct *result; // rax
		
		  result = retstr;
		  *retstr = this->fields.m_value;
		  return result;
		}
		

		// Void set_blackUIntTextureXR(TextureHandle)
		void UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraphDefaultResources::set_blackUIntTextureXR(
		        RenderGraphDefaultResources *this,
		        TextureHandle_1 *value,
		        MethodInfo *method)
		{
		  this->fields._blackUIntTextureXR_k__BackingField = *value;
		}
		
		public TextureHandle magentaTextureXR { get; private set; } // 0x0000000184DA1260-0x0000000184DA1270 0x0000000184DA1300-0x0000000184DA1310
		// FloatProperty get_jobWeight()
		FloatProperty *UnityEngine::Animations::Rigging::TwoBoneIKConstraintJob::get_jobWeight(
		        FloatProperty *__return_ptr retstr,
		        TwoBoneIKConstraintJob *this,
		        MethodInfo *method)
		{
		  FloatProperty *result; // rax
		
		  result = retstr;
		  *retstr = this->_jobWeight_k__BackingField;
		  return result;
		}
		

		// Void set_jobWeight(FloatProperty)
		void UnityEngine::Animations::Rigging::TwoBoneIKConstraintJob::set_jobWeight(
		        TwoBoneIKConstraintJob *this,
		        FloatProperty *value,
		        MethodInfo *method)
		{
		  this->_jobWeight_k__BackingField = *value;
		}
		
		public TextureHandle blackTextureXR { get; private set; } // 0x0000000184DA1230-0x0000000184DA1240 0x0000000184DA12B0-0x0000000184DA12C0
		// Color get_Color()
		Color *PaintIn3D::P3dChangeCounter::get_Color(Color *__return_ptr retstr, P3dChangeCounter *this, MethodInfo *method)
		{
		  Color *result; // rax
		
		  result = retstr;
		  *retstr = this->fields.color;
		  return result;
		}
		

		// Void set_whiteTextureXR(TextureHandle)
		void UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraphDefaultResources::set_whiteTextureXR(
		        RenderGraphDefaultResources *this,
		        TextureHandle_1 *value,
		        MethodInfo *method)
		{
		  this->fields._whiteTextureXR_k__BackingField = *value;
		}
		
		public TextureHandle blackTextureArrayXR { get; private set; } // 0x0000000184DA1220-0x0000000184DA1230 0x0000000184DA12A0-0x0000000184DA12B0
		// TextureHandle get_defaultShadowTexture()
		TextureHandle_1 *UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraphDefaultResources::get_defaultShadowTexture(
		        TextureHandle_1 *__return_ptr retstr,
		        RenderGraphDefaultResources *this,
		        MethodInfo *method)
		{
		  TextureHandle_1 *result; // rax
		
		  result = retstr;
		  *retstr = this->fields._defaultShadowTexture_k__BackingField;
		  return result;
		}
		

		// Void set_defaultShadowTexture(TextureHandle)
		void UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraphDefaultResources::set_defaultShadowTexture(
		        RenderGraphDefaultResources *this,
		        TextureHandle_1 *value,
		        MethodInfo *method)
		{
		  this->fields._defaultShadowTexture_k__BackingField = *value;
		}
		
		public TextureHandle blackUIntTextureXR { get; private set; } // 0x0000000184D9E7C0-0x0000000184D9E7D0 0x0000000184DA12C0-0x0000000184DA12D0
		// Vector4 <RegisterPorts>b__6_0()
		Vector4 *FlowCanvas::Nodes::StaticCodeEvent<UnityEngine::Vector4>::_RegisterPorts_b__6_0(
		        Vector4 *__return_ptr retstr,
		        StaticCodeEvent_1_UnityEngine_Vector4_ *this,
		        MethodInfo *method)
		{
		  Vector4 *result; // rax
		
		  result = retstr;
		  *retstr = this->fields.eventValue;
		  return result;
		}
		

		// Void set_rotation(Quaternion)
		void RootMotion::FinalIK::IKSolverVR::Leg::set_rotation(IKSolverVR_Leg *this, Quaternion *value, MethodInfo *method)
		{
		  this->fields._rotation_k__BackingField = *value;
		}
		
		public TextureHandle blackTexture3DXR { get; private set; } // 0x0000000184DA02D0-0x0000000184DA02E0 0x0000000184DA1290-0x0000000184DA12A0
		// Vector4 <RegisterPorts>b__6_0()
		Vector4 *FlowCanvas::Nodes::CodeEvent<UnityEngine::Vector4>::_RegisterPorts_b__6_0(
		        Vector4 *__return_ptr retstr,
		        CodeEvent_1_UnityEngine_Vector4_ *this,
		        MethodInfo *method)
		{
		  Vector4 *result; // rax
		
		  result = retstr;
		  *retstr = this->fields.eventValue;
		  return result;
		}
		

		// Void set_blackTexture3DXR(TextureHandle)
		void HG::Rendering::RenderGraphModule::HGRenderGraphDefaultResources::set_blackTexture3DXR(
		        HGRenderGraphDefaultResources *this,
		        TextureHandle *value,
		        MethodInfo *method)
		{
		  this->fields._blackTexture3DXR_k__BackingField = *value;
		}
		
		public TextureHandle whiteTextureXR { get; private set; } // 0x0000000184DA1270-0x0000000184DA1280 0x0000000184DA1320-0x0000000184DA1330
		// Rect get_uvRect()
		Rect *UnityEngine::UI::RawImage::get_uvRect(Rect *__return_ptr retstr, RawImage *this, MethodInfo *method)
		{
		  Rect *result; // rax
		
		  result = retstr;
		  *retstr = this->fields.m_UVRect;
		  return result;
		}
		

		// Void set_runtimeAtlasRect(Rect)
		void UnityEngine::UI::Image::set_runtimeAtlasRect(Image *this, Rect *value, MethodInfo *method)
		{
		  this->fields.m_RuntimeAtlasRect = *value;
		}
		
		public TextureHandle defaultShadowTexture { get; private set; } // 0x0000000184DA1250-0x0000000184DA1260 0x0000000184DA12F0-0x0000000184DA1300
		// Rect get_runtimeAtlasTextureRect()
		Rect *UnityEngine::UI::Image::get_runtimeAtlasTextureRect(Rect *__return_ptr retstr, Image *this, MethodInfo *method)
		{
		  Rect *result; // rax
		
		  result = retstr;
		  *retstr = this->fields.m_RuntimeAtlasTextureRect;
		  return result;
		}
		

		// Void set_runtimeAtlasTextureRect(Rect)
		void UnityEngine::UI::Image::set_runtimeAtlasTextureRect(Image *this, Rect *value, MethodInfo *method)
		{
		  this->fields.m_RuntimeAtlasTextureRect = *value;
		}
		
		public TextureHandle defaultShadowTextureArray { get; private set; } // 0x0000000184DA1240-0x0000000184DA1250 0x0000000184DA12E0-0x0000000184DA12F0
		// Vector4 get_runtimeAtlasBorder()
		Vector4 *UnityEngine::UI::Image::get_runtimeAtlasBorder(Vector4 *__return_ptr retstr, Image *this, MethodInfo *method)
		{
		  Vector4 *result; // rax
		
		  result = retstr;
		  *retstr = this->fields.m_RuntimeAtlasBorder;
		  return result;
		}
		

		// Void set_runtimeAtlasBorder(Vector4)
		void UnityEngine::UI::Image::set_runtimeAtlasBorder(Image *this, Vector4 *value, MethodInfo *method)
		{
		  this->fields.m_RuntimeAtlasBorder = *value;
		}
		
		public RTHandle defaultShadowTextureRTHandle { get => default; } // 0x0000000189B36C80-0x0000000189B36CD0 
		// RTHandle get_defaultShadowTextureRTHandle()
		RTHandle *HG::Rendering::RenderGraphModule::HGRenderGraphDefaultResources::get_defaultShadowTextureRTHandle(
		        HGRenderGraphDefaultResources *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(267, 0LL) )
		    return this->fields.m_ShadowTexture2D;
		  Patch = IFix::WrappersManagerImpl::GetPatch(267, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_128(Patch, (Object *)this, 0LL);
		}
		
		public RTHandle defaultShadowTextureArrayRTHandle { get => default; } // 0x0000000189B36C30-0x0000000189B36C80 
		// RTHandle get_defaultShadowTextureArrayRTHandle()
		RTHandle *HG::Rendering::RenderGraphModule::HGRenderGraphDefaultResources::get_defaultShadowTextureArrayRTHandle(
		        HGRenderGraphDefaultResources *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(268, 0LL) )
		    return this->fields.m_DefaultShadowTextureArrayRTH;
		  Patch = IFix::WrappersManagerImpl::GetPatch(268, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_128(Patch, (Object *)this, 0LL);
		}
		
	
		// Constructors
		internal HGRenderGraphDefaultResources() {} // 0x0000000182EDC6E0-0x0000000182EDC8F0
		// HGRenderGraphDefaultResources()
		void HG::Rendering::RenderGraphModule::HGRenderGraphDefaultResources::HGRenderGraphDefaultResources(
		        HGRenderGraphDefaultResources *this,
		        MethodInfo *method)
		{
		  Texture *blackTexture; // rdi
		  Type *v4; // rdx
		  PropertyInfo_1 *v5; // r8
		  Int32__Array **v6; // r9
		  Texture *whiteTexture; // rax
		  Type *v8; // rdx
		  PropertyInfo_1 *v9; // r8
		  Int32__Array **v10; // r9
		  Texture *redTexture; // rax
		  Type *v12; // rdx
		  PropertyInfo_1 *v13; // r8
		  Int32__Array **v14; // r9
		  Type *v15; // rdx
		  PropertyInfo_1 *v16; // r8
		  Int32__Array **v17; // r9
		  Texture2D *v18; // rax
		  Type *v19; // rdx
		  PropertyInfo_1 *v20; // r8
		  Int32__Array **v21; // r9
		  Type *v22; // rdx
		  PropertyInfo_1 *v23; // r8
		  Int32__Array **v24; // r9
		  Type *v25; // rdx
		  PropertyInfo_1 *v26; // r8
		  Int32__Array **v27; // r9
		  MethodInfo *colorFormat; // [rsp+20h] [rbp-98h]
		  MethodInfo *colorFormata; // [rsp+20h] [rbp-98h]
		  MethodInfo *colorFormatb; // [rsp+20h] [rbp-98h]
		  MethodInfo *colorFormatc; // [rsp+20h] [rbp-98h]
		  MethodInfo *colorFormatd; // [rsp+20h] [rbp-98h]
		  MethodInfo *colorFormate; // [rsp+20h] [rbp-98h]
		  MethodInfo *v34; // [rsp+E0h] [rbp+28h]
		
		  blackTexture = (Texture *)UnityEngine::Texture2D::get_blackTexture(0LL);
		  if ( !TypeInfo::UnityEngine::Rendering::RTHandles->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::RTHandles);
		  this->fields.m_BlackTexture2D = UnityEngine::Rendering::RTHandleSystem::Alloc(blackTexture, 0LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_BlackTexture2D, v4, v5, v6, colorFormat);
		  whiteTexture = (Texture *)UnityEngine::Texture2D::get_whiteTexture(0LL);
		  this->fields.m_WhiteTexture2D = UnityEngine::Rendering::RTHandleSystem::Alloc(whiteTexture, 0LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_WhiteTexture2D, v8, v9, v10, colorFormata);
		  redTexture = (Texture *)UnityEngine::Texture2D::get_redTexture(0LL);
		  this->fields.m_RedTexture2D = UnityEngine::Rendering::RTHandleSystem::Alloc(redTexture, 0LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_RedTexture2D, v12, v13, v14, colorFormatb);
		  this->fields.m_ShadowTexture2D = UnityEngine::Rendering::RTHandleSystem::Alloc(
		                                     1,
		                                     1,
		                                     1,
		                                     DepthBits__Enum_Depth32,
		                                     GraphicsFormat__Enum_R8G8B8A8_SRGB,
		                                     FilterMode__Enum_Point,
		                                     TextureWrapMode__Enum_Repeat,
		                                     TextureDimension__Enum_Tex2D,
		                                     0,
		                                     0,
		                                     1,
		                                     1,
		                                     1,
		                                     0.0,
		                                     MSAASamples__Enum_None,
		                                     0,
		                                     RenderTextureMemoryless__Enum_None,
		                                     (String *)"HGRenderGraphDefaultResources.ShadowTexture2D",
		                                     0LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_ShadowTexture2D, v15, v16, v17, colorFormatc);
		  v18 = UnityEngine::Texture2D::get_blackTexture(0LL);
		  this->fields.m_BlackTextureArray = HG::Rendering::RenderGraphModule::HGRenderGraphDefaultResources::CreateTexture2DArrayFromTexture2D(
		                                       v18,
		                                       (String *)"BlackTexture2DArray",
		                                       16,
		                                       0LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_BlackTextureArray, v19, v20, v21, colorFormatd);
		  this->fields.m_BlackTextureArrayRTH = UnityEngine::Rendering::RTHandleSystem::Alloc(
		                                          (Texture *)this->fields.m_BlackTextureArray,
		                                          0LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_BlackTextureArrayRTH, v22, v23, v24, colorFormate);
		  this->fields.m_DefaultShadowTextureArrayRTH = UnityEngine::Rendering::RTHandleSystem::Alloc(
		                                                  1,
		                                                  1,
		                                                  4,
		                                                  DepthBits__Enum_Depth16,
		                                                  GraphicsFormat__Enum_R8G8B8A8_SRGB,
		                                                  FilterMode__Enum_Point,
		                                                  TextureWrapMode__Enum_Clamp,
		                                                  TextureDimension__Enum_Tex2DArray,
		                                                  0,
		                                                  0,
		                                                  0,
		                                                  1,
		                                                  1,
		                                                  0.0,
		                                                  MSAASamples__Enum_None,
		                                                  0,
		                                                  RenderTextureMemoryless__Enum_None,
		                                                  (String *)"Default Shadow Texture Array",
		                                                  0LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_DefaultShadowTextureArrayRTH, v25, v26, v27, v34);
		}
		
	
		// Methods
		private static Texture2DArray CreateTexture2DArrayFromTexture2D(Texture2D source, string name, int slices) => default; // 0x0000000182EDDD70-0x0000000182EDDEB0
		// Texture2DArray CreateTexture2DArrayFromTexture2D(Texture2D, String, Int32)
		Texture2DArray *HG::Rendering::RenderGraphModule::HGRenderGraphDefaultResources::CreateTexture2DArrayFromTexture2D(
		        Texture2D *source,
		        String *name,
		        int32_t slices,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  int32_t v9; // r15d
		  int32_t v10; // r12d
		  TextureFormat__Enum textureFormat; // r13d
		  Texture2DArray *v12; // rax
		  Object_1 *v13; // rsi
		  int32_t i; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(269, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(269, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_129(Patch, (Object *)source, (Object *)name, slices, 0LL);
		LABEL_9:
		    sub_1800D8260(v8, v7);
		  }
		  if ( !source )
		    goto LABEL_9;
		  v9 = sub_180002F70(5LL, source);
		  v10 = sub_180002F70(7LL, source);
		  textureFormat = UnityEngine::Texture2D::get_format(source, 0LL);
		  v12 = (Texture2DArray *)sub_1800368D0(TypeInfo::UnityEngine::Texture2DArray);
		  v13 = (Object_1 *)v12;
		  if ( !v12 )
		    goto LABEL_9;
		  UnityEngine::Texture2DArray::Texture2DArray(v12, v9, v10, slices, textureFormat, 1, 0, 0LL);
		  UnityEngine::Object::set_name(v13, name, 0LL);
		  for ( i = 0; i < slices; ++i )
		  {
		    if ( !TypeInfo::UnityEngine::Graphics->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Graphics);
		    UnityEngine::Graphics::CopyTexture((Texture *)source, 0, 0, (Texture *)v13, i, 0, 0LL);
		  }
		  return (Texture2DArray *)v13;
		}
		
		internal void Cleanup() {} // 0x00000001837DC2B0-0x00000001837DC340
		// Void Cleanup()
		void HG::Rendering::RenderGraphModule::HGRenderGraphDefaultResources::Cleanup(
		        HGRenderGraphDefaultResources *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  RTHandle *m_BlackTexture2D; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(126, 0LL) )
		  {
		    m_BlackTexture2D = this->fields.m_BlackTexture2D;
		    if ( m_BlackTexture2D )
		    {
		      UnityEngine::Rendering::RTHandle::Release(m_BlackTexture2D, 0LL);
		      m_BlackTexture2D = this->fields.m_WhiteTexture2D;
		      if ( m_BlackTexture2D )
		      {
		        UnityEngine::Rendering::RTHandle::Release(m_BlackTexture2D, 0LL);
		        m_BlackTexture2D = this->fields.m_RedTexture2D;
		        if ( m_BlackTexture2D )
		        {
		          UnityEngine::Rendering::RTHandle::Release(m_BlackTexture2D, 0LL);
		          m_BlackTexture2D = this->fields.m_ShadowTexture2D;
		          if ( m_BlackTexture2D )
		          {
		            UnityEngine::Rendering::RTHandle::Release(m_BlackTexture2D, 0LL);
		            m_BlackTexture2D = this->fields.m_BlackTextureArrayRTH;
		            if ( m_BlackTexture2D )
		            {
		              UnityEngine::Rendering::RTHandle::Release(m_BlackTexture2D, 0LL);
		              m_BlackTexture2D = this->fields.m_DefaultShadowTextureArrayRTH;
		              if ( m_BlackTexture2D )
		              {
		                UnityEngine::Rendering::RTHandle::Release(m_BlackTexture2D, 0LL);
		                return;
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_3:
		    sub_1800D8260(m_BlackTexture2D, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(126, 0LL);
		  if ( !Patch )
		    goto LABEL_3;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		internal void InitializeForRendering(HGRenderGraph renderGraph) {} // 0x0000000189B36A10-0x0000000189B36C30
		// Void InitializeForRendering(HGRenderGraph)
		void HG::Rendering::RenderGraphModule::HGRenderGraphDefaultResources::InitializeForRendering(
		        HGRenderGraphDefaultResources *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  TextureHandle *v7; // rax
		  RTHandle *m_WhiteTexture2D; // r8
		  TextureHandle *v9; // rax
		  RTHandle *m_RedTexture2D; // r8
		  TextureHandle *v11; // rax
		  RTHandle *m_ShadowTexture2D; // r8
		  TextureHandle *v13; // rax
		  RTHandle *m_BlackTextureArrayRTH; // r8
		  TextureHandle *v15; // rax
		  RTHandle *m_DefaultShadowTextureArrayRTH; // r8
		  RTHandle *ClearTexture; // rax
		  RTHandle *MagentaTexture; // rax
		  RTHandle *BlackTexture; // rax
		  RTHandle *v20; // rax
		  RTHandle *BlackUIntTexture; // rax
		  RTHandle *v22; // rax
		  RTHandle *WhiteTexture; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  TextureHandle v25; // [rsp+20h] [rbp-10h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(186, 0LL) )
		  {
		    if ( renderGraph )
		    {
		      v7 = HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		             &v25,
		             renderGraph,
		             this->fields.m_BlackTexture2D,
		             0LL);
		      m_WhiteTexture2D = this->fields.m_WhiteTexture2D;
		      this->fields._blackTexture_k__BackingField = *v7;
		      v9 = HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(&v25, renderGraph, m_WhiteTexture2D, 0LL);
		      m_RedTexture2D = this->fields.m_RedTexture2D;
		      this->fields._whiteTexture_k__BackingField = *v9;
		      v11 = HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(&v25, renderGraph, m_RedTexture2D, 0LL);
		      m_ShadowTexture2D = this->fields.m_ShadowTexture2D;
		      this->fields._redTexture_k__BackingField = *v11;
		      v13 = HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(&v25, renderGraph, m_ShadowTexture2D, 0LL);
		      m_BlackTextureArrayRTH = this->fields.m_BlackTextureArrayRTH;
		      this->fields._defaultShadowTexture_k__BackingField = *v13;
		      v15 = HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		              &v25,
		              renderGraph,
		              m_BlackTextureArrayRTH,
		              0LL);
		      m_DefaultShadowTextureArrayRTH = this->fields.m_DefaultShadowTextureArrayRTH;
		      this->fields._blackTextureArray_k__BackingField = *v15;
		      this->fields._defaultShadowTextureArray_k__BackingField = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		                                                                   &v25,
		                                                                   renderGraph,
		                                                                   m_DefaultShadowTextureArrayRTH,
		                                                                   0LL);
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::TextureXR);
		      ClearTexture = UnityEngine::Rendering::TextureXR::GetClearTexture(0LL);
		      this->fields._clearTextureXR_k__BackingField = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		                                                        &v25,
		                                                        renderGraph,
		                                                        ClearTexture,
		                                                        0LL);
		      MagentaTexture = UnityEngine::Rendering::TextureXR::GetMagentaTexture(0LL);
		      this->fields._magentaTextureXR_k__BackingField = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		                                                          &v25,
		                                                          renderGraph,
		                                                          MagentaTexture,
		                                                          0LL);
		      BlackTexture = UnityEngine::Rendering::TextureXR::GetBlackTexture(0LL);
		      this->fields._blackTextureXR_k__BackingField = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		                                                        &v25,
		                                                        renderGraph,
		                                                        BlackTexture,
		                                                        0LL);
		      v20 = (RTHandle *)sub_189B33FD8();
		      this->fields._blackTextureArrayXR_k__BackingField = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		                                                             &v25,
		                                                             renderGraph,
		                                                             v20,
		                                                             0LL);
		      BlackUIntTexture = UnityEngine::Rendering::TextureXR::GetBlackUIntTexture(0LL);
		      this->fields._blackUIntTextureXR_k__BackingField = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		                                                            &v25,
		                                                            renderGraph,
		                                                            BlackUIntTexture,
		                                                            0LL);
		      v22 = (RTHandle *)sub_189B33F84();
		      this->fields._blackTexture3DXR_k__BackingField = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		                                                          &v25,
		                                                          renderGraph,
		                                                          v22,
		                                                          0LL);
		      WhiteTexture = UnityEngine::Rendering::TextureXR::GetWhiteTexture(0LL);
		      this->fields._whiteTextureXR_k__BackingField = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		                                                        &v25,
		                                                        renderGraph,
		                                                        WhiteTexture,
		                                                        0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(186, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)renderGraph,
		    0LL);
		}
		
	}
}
