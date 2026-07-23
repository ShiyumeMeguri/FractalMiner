using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public struct HGInkWashConfig : IEnvConfig // TypeDefIndex: 37608
	{
		// Fields
		[Header("\u542F\u7528\u6C34\u58A8\u540E\u5904\u7406")]
		public bool enable; // 0x00
		[Header("\u6C34\u58A8\u6548\u679C\u5F3A\u5EA6")]
		[Range(0f, 1f)]
		public float intensity; // 0x04
		[Header("\u5F00\u59CB\u6CFC\u58A8\uFF08\u4E34\u65F6\u5F00\u5173\uFF0C\u7528\u4E8E\u770B\u6548\u679C\uFF09")]
		[HideInInspector]
		public bool isDrawing; // 0x08
		public HGInkWashBaseConfig baseConfig; // 0x10
		public HGInkWashOverlayConfig overlayConfig; // 0x30
		public HGInkWashMaskConfig maskConfig; // 0x50
		[HideInInspector]
		[SerializeField]
		private bool m_active; // 0x98
		public static HGInkWashConfig defaultConfig; // 0x00
	
		// Properties
		public bool active { get => default; set {} } // 0x0000000183B4FA00-0x0000000183B4FA60 0x00000001831D5070-0x00000001831D50B0
		// Boolean get_active()
		bool HG::Rendering::Runtime::HGInkWashConfig::get_active(HGInkWashConfig *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 1374 )
		    return this->m_active;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x55E )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[29]._0.klass )
		    return this->m_active;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1374, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_548(Patch, this, 0LL);
		}
		

		// Void set_active(Boolean)
		void HG::Rendering::Runtime::HGInkWashConfig::set_active(HGInkWashConfig *this, bool value, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1375, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1375, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_549(Patch, this, value, 0LL);
		  }
		  else
		  {
		    this->m_active = value;
		  }
		}
		
	
		// Nested types
		[Serializable]
		public struct HGInkWashBaseConfig : IEnvConfig // TypeDefIndex: 37605
		{
			// Fields
			[Header("\u6CFC\u58A8\u524D\u6750\u8D28")]
			public Material baseMat; // 0x00
			[Header("\u5782\u76F4\u6E10\u53D8 / \u57FA\u51C6\u9AD8\u5EA6")]
			public float verticalFadeStart; // 0x08
			[Header("\u5782\u76F4\u6E10\u53D8 / \u5E95\u9762\u9AD8\u5EA6")]
			public float verticalFadeEnd; // 0x0C
			[Header("\u5782\u76F4\u6E10\u53D8 / \u5F71\u54CD\u8DDD\u79BB")]
			public float verticalFadeAffectDist; // 0x10
			[Header("\u5782\u76F4\u6E10\u53D8 / \u8FC7\u6E21\u8DDD\u79BB")]
			public float verticalFadeFadeDist; // 0x14
			[Header("\u6E10\u53D8\u5E95\u90E8\u989C\u8272\u5BF9\u6BD4")]
			public float groundColorAdj; // 0x18
			public static HGInkWashBaseConfig defaultConfig; // 0x00
	
			// Properties
			public bool active { get => default; set {} } // 0x0000000189CE3F94-0x0000000189CE3FE0 0x0000000189CE3FE0-0x0000000189CE4034
			// Boolean get_active()
			bool HG::Rendering::Runtime::HGInkWashConfig::HGInkWashBaseConfig::get_active(
			        HGInkWashConfig_HGInkWashBaseConfig *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(1376, 0LL) )
			    return 1;
			  Patch = IFix::WrappersManagerImpl::GetPatch(1376, 0LL);
			  if ( !Patch )
			    sub_1800D8260(v6, v5);
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_550(Patch, this, 0LL);
			}
			

			// Void set_active(Boolean)
			void HG::Rendering::Runtime::HGInkWashConfig::HGInkWashBaseConfig::set_active(
			        HGInkWashConfig_HGInkWashBaseConfig *this,
			        bool value,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v6; // rdx
			  __int64 v7; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(1377, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(1377, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v7, v6);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_551(Patch, this, value, 0LL);
			  }
			}
			
	
			// Constructors
			public HGInkWashBaseConfig(bool active) : this() {
				baseMat = default;
				verticalFadeStart = default;
				verticalFadeEnd = default;
				verticalFadeAffectDist = default;
				verticalFadeFadeDist = default;
				groundColorAdj = default;
			} // 0x00000001853980F8-0x0000000185398124
			// HGInkWashConfig+HGInkWashOverlayConfig(Boolean)
			// local variable allocation has failed, the output may be wrong!
			void HG::Rendering::Runtime::HGInkWashConfig::HGInkWashOverlayConfig::HGInkWashOverlayConfig(
			        HGInkWashConfig_HGInkWashOverlayConfig *this,
			        bool active,
			        MethodInfo *method)
			{
			  __int64 v3; // r9
			  __int64 v4; // r10
			  MethodInfo *v5; // [rsp+20h] [rbp-8h]
			
			  this->overlayMat = 0LL;
			  sub_18002D1B0((SingleFieldAccessor *)this, (Type *)active, (PropertyInfo_1 *)method, (Int32__Array **)this, v5);
			  *(_QWORD *)(v3 + 8) = v4;
			  *(_DWORD *)(v3 + 16) = 1109393408;
			  *(_QWORD *)(v3 + 20) = 1092616192LL;
			}
			
			static HGInkWashBaseConfig() {
				defaultConfig = default;
			} // 0x0000000184CCAD80-0x0000000184CCADF0
			// HGInkWashConfig+HGInkWashBaseConfig()
			void HG::Rendering::Runtime::HGInkWashConfig::HGInkWashBaseConfig::cctor(MethodInfo *method)
			{
			  Type *v1; // rdx
			  PropertyInfo_1 *v2; // r8
			  Int32__Array **v3; // r9
			  HGInkWashConfig_HGInkWashBaseConfig__StaticFields *static_fields; // rcx
			  __int128 v5; // xmm0
			  Type *v6; // rdx
			  PropertyInfo_1 *v7; // r8
			  Int32__Array **v8; // r9
			  _BYTE v9[40]; // [rsp+20h] [rbp-28h] BYREF
			
			  memset(v9, 0, 32);
			  ((void (__stdcall *)(SingleFieldAccessor *, Type *, PropertyInfo_1 *, Int32__Array **))sub_18002D1B0)(
			    (SingleFieldAccessor *)v9,
			    v1,
			    v2,
			    v3);
			  *(__m128i *)&v9[8] = _mm_load_si128((const __m128i *)&xmmword_18B959D30);
			  *(_DWORD *)&v9[24] = 0;
			  static_fields = TypeInfo::HG::Rendering::Runtime::HGInkWashConfig::HGInkWashBaseConfig->static_fields;
			  v5 = *(_OWORD *)&v9[16];
			  *(_OWORD *)&static_fields->defaultConfig.baseMat = *(_OWORD *)v9;
			  *(_OWORD *)&static_fields->defaultConfig.verticalFadeAffectDist = v5;
			  sub_18002D1B0(
			    (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::HGInkWashConfig::HGInkWashBaseConfig->static_fields,
			    v6,
			    v7,
			    v8,
			    *(MethodInfo **)v9);
			}
			
	
			// Methods
			public void Lerp<T>(ref ref T cSrc, ref ref T cDst, float t)
				where T : struct, IEnvConfig {}
		}
	
		[Serializable]
		public struct HGInkWashOverlayConfig : IEnvConfig // TypeDefIndex: 37606
		{
			// Fields
			[Header("\u6CFC\u58A8\u540E\u6750\u8D28")]
			public Material overlayMat; // 0x00
			[Header("\u5782\u76F4\u6E10\u53D8 / \u57FA\u51C6\u9AD8\u5EA6")]
			public float verticalFadeStart; // 0x08
			[Header("\u5782\u76F4\u6E10\u53D8 / \u5E95\u9762\u9AD8\u5EA6")]
			public float verticalFadeEnd; // 0x0C
			[Header("\u5782\u76F4\u6E10\u53D8 / \u5F71\u54CD\u8DDD\u79BB")]
			public float verticalFadeAffectDist; // 0x10
			[Header("\u5782\u76F4\u6E10\u53D8 / \u8FC7\u6E21\u8DDD\u79BB")]
			public float verticalFadeFadeDist; // 0x14
			[Header("\u6E10\u53D8\u5E95\u90E8\u989C\u8272\u5BF9\u6BD4")]
			public float groundColorAdj; // 0x18
			public static HGInkWashOverlayConfig defaultConfig; // 0x00
	
			// Properties
			public bool active { get => default; set {} } // 0x0000000189CE40D4-0x0000000189CE4120 0x0000000189CE4120-0x0000000189CE4174
			// Boolean get_active()
			bool HG::Rendering::Runtime::HGInkWashConfig::HGInkWashOverlayConfig::get_active(
			        HGInkWashConfig_HGInkWashOverlayConfig *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(1378, 0LL) )
			    return 1;
			  Patch = IFix::WrappersManagerImpl::GetPatch(1378, 0LL);
			  if ( !Patch )
			    sub_1800D8260(v6, v5);
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_552(Patch, this, 0LL);
			}
			

			// Void set_active(Boolean)
			void HG::Rendering::Runtime::HGInkWashConfig::HGInkWashOverlayConfig::set_active(
			        HGInkWashConfig_HGInkWashOverlayConfig *this,
			        bool value,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v6; // rdx
			  __int64 v7; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(1379, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(1379, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v7, v6);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_553(Patch, this, value, 0LL);
			  }
			}
			
	
			// Constructors
			public HGInkWashOverlayConfig(bool active) : this() {
				overlayMat = default;
				verticalFadeStart = default;
				verticalFadeEnd = default;
				verticalFadeAffectDist = default;
				verticalFadeFadeDist = default;
				groundColorAdj = default;
			} // 0x00000001853980F8-0x0000000185398124
			// HGInkWashConfig+HGInkWashOverlayConfig(Boolean)
			// local variable allocation has failed, the output may be wrong!
			void HG::Rendering::Runtime::HGInkWashConfig::HGInkWashOverlayConfig::HGInkWashOverlayConfig(
			        HGInkWashConfig_HGInkWashOverlayConfig *this,
			        bool active,
			        MethodInfo *method)
			{
			  __int64 v3; // r9
			  __int64 v4; // r10
			  MethodInfo *v5; // [rsp+20h] [rbp-8h]
			
			  this->overlayMat = 0LL;
			  sub_18002D1B0((SingleFieldAccessor *)this, (Type *)active, (PropertyInfo_1 *)method, (Int32__Array **)this, v5);
			  *(_QWORD *)(v3 + 8) = v4;
			  *(_DWORD *)(v3 + 16) = 1109393408;
			  *(_QWORD *)(v3 + 20) = 1092616192LL;
			}
			
			static HGInkWashOverlayConfig() {
				defaultConfig = default;
			} // 0x0000000184CCADF0-0x0000000184CCAE60
			// HGInkWashConfig+HGInkWashOverlayConfig()
			void HG::Rendering::Runtime::HGInkWashConfig::HGInkWashOverlayConfig::cctor(MethodInfo *method)
			{
			  Type *v1; // rdx
			  PropertyInfo_1 *v2; // r8
			  Int32__Array **v3; // r9
			  HGInkWashConfig_HGInkWashOverlayConfig__StaticFields *static_fields; // rcx
			  __int128 v5; // xmm0
			  Type *v6; // rdx
			  PropertyInfo_1 *v7; // r8
			  Int32__Array **v8; // r9
			  _BYTE v9[40]; // [rsp+20h] [rbp-28h] BYREF
			
			  memset(v9, 0, 32);
			  ((void (__stdcall *)(SingleFieldAccessor *, Type *, PropertyInfo_1 *, Int32__Array **))sub_18002D1B0)(
			    (SingleFieldAccessor *)v9,
			    v1,
			    v2,
			    v3);
			  *(__m128i *)&v9[8] = _mm_load_si128((const __m128i *)&xmmword_18B959D30);
			  *(_DWORD *)&v9[24] = 0;
			  static_fields = TypeInfo::HG::Rendering::Runtime::HGInkWashConfig::HGInkWashOverlayConfig->static_fields;
			  v5 = *(_OWORD *)&v9[16];
			  *(_OWORD *)&static_fields->defaultConfig.overlayMat = *(_OWORD *)v9;
			  *(_OWORD *)&static_fields->defaultConfig.verticalFadeAffectDist = v5;
			  sub_18002D1B0(
			    (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::HGInkWashConfig::HGInkWashOverlayConfig->static_fields,
			    v6,
			    v7,
			    v8,
			    *(MethodInfo **)v9);
			}
			
	
			// Methods
			public void Lerp<T>(ref ref T cSrc, ref ref T cDst, float t)
				where T : struct, IEnvConfig {}
		}
	
		[Serializable]
		public struct HGInkWashMaskConfig : IEnvConfig // TypeDefIndex: 37607
		{
			// Fields
			public bool addNewInkDrop; // 0x00
			[Header("\u6CFC\u58A8\u906E\u7F69\u6750\u8D28")]
			public Material maskMat; // 0x08
			[Header("\u6CFC\u58A8\u70B9\u5927\u5C0F")]
			[Range(0.1f, 5f)]
			public float inkDropSize; // 0x10
			[Header("\u6CFC\u58A8\u70B9\u6655\u67D3\u901F\u5EA6")]
			[Range(0.1f, 10f)]
			public float inkBleedingSpeed; // 0x14
			[Header("\u6CFC\u58A8\u70B9\u5927\u5C0F\u968F\u673A\u5316")]
			public bool randomSize; // 0x18
			[Header("\u5F53\u524D\u6CFC\u58A8\u70B9\u4F4D\u7F6E")]
			public Vector3 currInkPointPos; // 0x1C
			[Header("\u6CFC\u58A8\u70B9\u65B9\u5411")]
			[HideInInspector]
			public Vector3 currInkPointDir; // 0x28
			[HideInInspector]
			public float inkBleedingDeltaTime; // 0x34
			[HideInInspector]
			public float inkStrokeSeed; // 0x38
			[HideInInspector]
			public float atlasSize; // 0x3C
			[HideInInspector]
			public float edgeFade; // 0x40
			public static HGInkWashMaskConfig defaultConfig; // 0x00
	
			// Properties
			public bool active { get => default; set {} } // 0x0000000189CE4034-0x0000000189CE4080 0x0000000189CE4080-0x0000000189CE40D4
			// Boolean get_active()
			bool HG::Rendering::Runtime::HGInkWashConfig::HGInkWashMaskConfig::get_active(
			        HGInkWashConfig_HGInkWashMaskConfig *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(1380, 0LL) )
			    return 1;
			  Patch = IFix::WrappersManagerImpl::GetPatch(1380, 0LL);
			  if ( !Patch )
			    sub_1800D8260(v6, v5);
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_554(Patch, this, 0LL);
			}
			

			// Void set_active(Boolean)
			void HG::Rendering::Runtime::HGInkWashConfig::HGInkWashMaskConfig::set_active(
			        HGInkWashConfig_HGInkWashMaskConfig *this,
			        bool value,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v6; // rdx
			  __int64 v7; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(1381, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(1381, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v7, v6);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_555(Patch, this, value, 0LL);
			  }
			}
			
	
			// Constructors
			public HGInkWashMaskConfig(bool active) : this() {
				addNewInkDrop = default;
				maskMat = default;
				inkDropSize = default;
				inkBleedingSpeed = default;
				randomSize = default;
				currInkPointPos = default;
				currInkPointDir = default;
				inkBleedingDeltaTime = default;
				inkStrokeSeed = default;
				atlasSize = default;
				edgeFade = default;
			} // 0x0000000184CA1A70-0x0000000184CA1AE0
			// HGInkWashConfig+HGInkWashMaskConfig(Boolean)
			// local variable allocation has failed, the output may be wrong!
			void HG::Rendering::Runtime::HGInkWashConfig::HGInkWashMaskConfig::HGInkWashMaskConfig(
			        HGInkWashConfig_HGInkWashMaskConfig *this,
			        bool active,
			        MethodInfo *method)
			{
			  __int64 v3; // r9
			  __int64 v4; // r10
			  MethodInfo *v5; // [rsp+20h] [rbp-8h]
			
			  this->addNewInkDrop = 0;
			  this->maskMat = 0LL;
			  sub_18002D1B0(
			    (SingleFieldAccessor *)&this->maskMat,
			    (Type *)active,
			    (PropertyInfo_1 *)method,
			    (Int32__Array **)this,
			    v5);
			  *(_DWORD *)(v3 + 16) = 0x40000000;
			  *(_DWORD *)(v3 + 20) = 1065353216;
			  *(_QWORD *)(v3 + 28) = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			  *(_QWORD *)(v3 + 40) = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			  *(_DWORD *)(v3 + 48) = 0;
			  *(_DWORD *)(v3 + 36) = 0;
			  *(_BYTE *)(v3 + 24) = v4;
			  *(_QWORD *)(v3 + 52) = v4;
			  *(_DWORD *)(v3 + 60) = 0x40000000;
			  *(_DWORD *)(v3 + 64) = 1036831949;
			}
			
			static HGInkWashMaskConfig() {
				defaultConfig = default;
			} // 0x0000000184CA19E0-0x0000000184CA1A70
			// HGInkWashConfig+HGInkWashMaskConfig()
			void HG::Rendering::Runtime::HGInkWashConfig::HGInkWashMaskConfig::cctor(MethodInfo *method)
			{
			  __int128 v1; // xmm2
			  __int128 v2; // xmm3
			  HGInkWashConfig_HGInkWashMaskConfig__StaticFields *static_fields; // rcx
			  __int128 v4; // xmm4
			  __int64 v5; // xmm0_8
			  Type *v6; // rdx
			  PropertyInfo_1 *v7; // r8
			  Int32__Array **v8; // r9
			  HGInkWashConfig_HGInkWashMaskConfig v9; // [rsp+20h] [rbp-58h] BYREF
			
			  memset(&v9, 0, sizeof(v9));
			  HG::Rendering::Runtime::HGInkWashConfig::HGInkWashMaskConfig::HGInkWashMaskConfig(&v9, 0, 0LL);
			  v1 = *(_OWORD *)&v9.inkDropSize;
			  v2 = *(_OWORD *)&v9.currInkPointPos.y;
			  static_fields = TypeInfo::HG::Rendering::Runtime::HGInkWashConfig::HGInkWashMaskConfig->static_fields;
			  v4 = *(_OWORD *)&v9.currInkPointDir.z;
			  v5 = *(_QWORD *)&v9.edgeFade;
			  *(_OWORD *)&static_fields->defaultConfig.addNewInkDrop = *(_OWORD *)&v9.addNewInkDrop;
			  *(_OWORD *)&static_fields->defaultConfig.inkDropSize = v1;
			  *(_OWORD *)&static_fields->defaultConfig.currInkPointPos.y = v2;
			  *(_OWORD *)&static_fields->defaultConfig.currInkPointDir.z = v4;
			  *(_QWORD *)&static_fields->defaultConfig.edgeFade = v5;
			  sub_18002D1B0(
			    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGInkWashConfig::HGInkWashMaskConfig->static_fields->defaultConfig.maskMat,
			    v6,
			    v7,
			    v8,
			    *(MethodInfo **)&v9.addNewInkDrop);
			}
			
	
			// Methods
			public void Lerp<T>(ref ref T cSrc, ref ref T cDst, float t)
				where T : struct, IEnvConfig {}
		}
	
		// Constructors
		public HGInkWashConfig(bool active) : this() {
			enable = default;
			intensity = default;
			isDrawing = default;
			baseConfig = default;
			overlayConfig = default;
			maskConfig = default;
			m_active = default;
		} // 0x00000001849E3590-0x00000001849E3690
		// HGInkWashConfig(Boolean)
		// local variable allocation has failed, the output may be wrong!
		void HG::Rendering::Runtime::HGInkWashConfig::HGInkWashConfig(HGInkWashConfig *this, bool active, MethodInfo *method)
		{
		  Int32__Array **v3; // r9
		  struct HGInkWashConfig_HGInkWashBaseConfig__Class *v5; // rax
		  HGInkWashConfig_HGInkWashBaseConfig__StaticFields *static_fields; // rax
		  __int128 v7; // xmm1
		  Type *v8; // rdx
		  PropertyInfo_1 *v9; // r8
		  Int32__Array **v10; // r9
		  struct HGInkWashConfig_HGInkWashOverlayConfig__Class *v11; // rax
		  HGInkWashConfig_HGInkWashOverlayConfig__StaticFields *v12; // rax
		  __int128 v13; // xmm1
		  Type *v14; // rdx
		  PropertyInfo_1 *v15; // r8
		  Int32__Array **v16; // r9
		  struct HGInkWashConfig_HGInkWashMaskConfig__Class *v17; // rax
		  HGInkWashConfig_HGInkWashMaskConfig__StaticFields *v18; // rax
		  __int128 v19; // xmm2
		  __int128 v20; // xmm3
		  __int128 v21; // xmm4
		  __int64 v22; // xmm0_8
		  MethodInfo *v23; // [rsp+20h] [rbp-8h]
		  MethodInfo *v24; // [rsp+20h] [rbp-8h]
		  MethodInfo *v25; // [rsp+50h] [rbp+28h]
		
		  this->m_active = 0;
		  this->enable = 0;
		  this->intensity = 0.0;
		  this->isDrawing = 0;
		  v5 = TypeInfo::HG::Rendering::Runtime::HGInkWashConfig::HGInkWashBaseConfig;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGInkWashConfig::HGInkWashBaseConfig->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGInkWashConfig::HGInkWashBaseConfig);
		    v5 = TypeInfo::HG::Rendering::Runtime::HGInkWashConfig::HGInkWashBaseConfig;
		  }
		  static_fields = v5->static_fields;
		  v7 = *(_OWORD *)&static_fields->defaultConfig.verticalFadeAffectDist;
		  *(_OWORD *)&this->baseConfig.baseMat = *(_OWORD *)&static_fields->defaultConfig.baseMat;
		  *(_OWORD *)&this->baseConfig.verticalFadeAffectDist = v7;
		  sub_18002D1B0((SingleFieldAccessor *)&this->baseConfig, (Type *)active, (PropertyInfo_1 *)method, v3, v23);
		  v11 = TypeInfo::HG::Rendering::Runtime::HGInkWashConfig::HGInkWashOverlayConfig;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGInkWashConfig::HGInkWashOverlayConfig->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGInkWashConfig::HGInkWashOverlayConfig);
		    v11 = TypeInfo::HG::Rendering::Runtime::HGInkWashConfig::HGInkWashOverlayConfig;
		  }
		  v12 = v11->static_fields;
		  v13 = *(_OWORD *)&v12->defaultConfig.verticalFadeAffectDist;
		  *(_OWORD *)&this->overlayConfig.overlayMat = *(_OWORD *)&v12->defaultConfig.overlayMat;
		  *(_OWORD *)&this->overlayConfig.verticalFadeAffectDist = v13;
		  sub_18002D1B0((SingleFieldAccessor *)&this->overlayConfig, v8, v9, v10, v24);
		  v17 = TypeInfo::HG::Rendering::Runtime::HGInkWashConfig::HGInkWashMaskConfig;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGInkWashConfig::HGInkWashMaskConfig->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGInkWashConfig::HGInkWashMaskConfig);
		    v17 = TypeInfo::HG::Rendering::Runtime::HGInkWashConfig::HGInkWashMaskConfig;
		  }
		  v18 = v17->static_fields;
		  v19 = *(_OWORD *)&v18->defaultConfig.inkDropSize;
		  v20 = *(_OWORD *)&v18->defaultConfig.currInkPointPos.y;
		  v21 = *(_OWORD *)&v18->defaultConfig.currInkPointDir.z;
		  v22 = *(_QWORD *)&v18->defaultConfig.edgeFade;
		  *(_OWORD *)&this->maskConfig.addNewInkDrop = *(_OWORD *)&v18->defaultConfig.addNewInkDrop;
		  *(_OWORD *)&this->maskConfig.inkDropSize = v19;
		  *(_OWORD *)&this->maskConfig.currInkPointPos.y = v20;
		  *(_OWORD *)&this->maskConfig.currInkPointDir.z = v21;
		  *(_QWORD *)&this->maskConfig.edgeFade = v22;
		  sub_18002D1B0((SingleFieldAccessor *)&this->maskConfig.maskMat, v14, v15, v16, v25);
		}
		
		static HGInkWashConfig() {
			defaultConfig = default;
		} // 0x00000001849E3470-0x00000001849E3590
		// HGInkWashConfig()
		void HG::Rendering::Runtime::HGInkWashConfig::cctor(MethodInfo *method)
		{
		  HGInkWashConfig__StaticFields *static_fields; // rcx
		  __int128 v2; // xmm1
		  __int128 v3; // xmm0
		  __int128 v4; // xmm1
		  __int128 v5; // xmm0
		  __int128 v6; // xmm1
		  __int128 v7; // xmm0
		  __int128 v8; // xmm1
		  __int128 v9; // xmm0
		  __int128 v10; // xmm1
		  Type *v11; // rdx
		  PropertyInfo_1 *v12; // r8
		  Int32__Array **v13; // r9
		  HGInkWashConfig v14; // [rsp+20h] [rbp-148h] BYREF
		  HGInkWashConfig v15; // [rsp+C0h] [rbp-A8h]
		
		  sub_18033B9D0(&v14, 0LL, 160LL);
		  HG::Rendering::Runtime::HGInkWashConfig::HGInkWashConfig(&v14, 0, 0LL);
		  v15 = v14;
		  static_fields = TypeInfo::HG::Rendering::Runtime::HGInkWashConfig->static_fields;
		  v2 = *(_OWORD *)&v14.baseConfig.baseMat;
		  *(_OWORD *)&static_fields->defaultConfig.enable = *(_OWORD *)&v14.enable;
		  v3 = *(_OWORD *)&v15.baseConfig.verticalFadeAffectDist;
		  *(_OWORD *)&static_fields->defaultConfig.baseConfig.baseMat = v2;
		  v4 = *(_OWORD *)&v15.overlayConfig.overlayMat;
		  *(_OWORD *)&static_fields->defaultConfig.baseConfig.verticalFadeAffectDist = v3;
		  v5 = *(_OWORD *)&v15.overlayConfig.verticalFadeAffectDist;
		  *(_OWORD *)&static_fields->defaultConfig.overlayConfig.overlayMat = v4;
		  v6 = *(_OWORD *)&v15.maskConfig.addNewInkDrop;
		  *(_OWORD *)&static_fields->defaultConfig.overlayConfig.verticalFadeAffectDist = v5;
		  v7 = *(_OWORD *)&v15.maskConfig.inkDropSize;
		  *(_OWORD *)&static_fields->defaultConfig.maskConfig.addNewInkDrop = v6;
		  v8 = *(_OWORD *)&v15.maskConfig.currInkPointPos.y;
		  *(_OWORD *)&static_fields->defaultConfig.maskConfig.inkDropSize = v7;
		  v9 = *(_OWORD *)&v15.maskConfig.currInkPointDir.z;
		  *(_OWORD *)&static_fields->defaultConfig.maskConfig.currInkPointPos.y = v8;
		  v10 = *(_OWORD *)&v15.maskConfig.edgeFade;
		  *(_OWORD *)&static_fields->defaultConfig.maskConfig.currInkPointDir.z = v9;
		  *(_OWORD *)&static_fields->defaultConfig.maskConfig.edgeFade = v10;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGInkWashConfig->static_fields->defaultConfig.baseConfig,
		    v11,
		    v12,
		    v13,
		    *(MethodInfo **)&v14.enable);
		}
		
	
		// Methods
		public void Lerp<T>(ref ref T cSrc, ref ref T cDst, float t)
			where T : struct, IEnvConfig {}
	}
}
