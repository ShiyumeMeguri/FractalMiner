using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public struct HGCloudShadowConfig : IEnvConfig // TypeDefIndex: 37598
	{
		// Fields
		[Header("\u4E91\u5F71\u8D34\u56FE")]
		public Texture2D cloudShadowTexture; // 0x00
		[Header("\u573A\u666F\u4E2D\u5FC3\u70B9")]
		public Vector3 cloudShadowEnvCenter; // 0x08
		[Header("\u4E91\u5F71\u8D34\u56FE\u8986\u76D6\u8303\u56F4\uFF08km\uFF09")]
		[Range(0.1f, 10f)]
		public float cloudShadowCoverage; // 0x14
		[Header("\u4E91\u5F71\u79FB\u52A8\u901F\u5EA6\uFF08m/s\uFF09")]
		[RangeExponential(0f, 1000f, 2f)]
		public float cloudShadowFlowSpeed; // 0x18
		[Header("\u4E91\u5F71\u79FB\u52A8\u65B9\u5411")]
		public Vector2 cloudShadowFlowDirection; // 0x1C
		[Header("\u4E91\u5F71\u6574\u4F53\u4E0D\u900F\u660E\u5EA6")]
		[Range(0f, 1f)]
		public float cloudShadowAlpha; // 0x24
		[Header("\u4E91\u5F71\u8DDD\u79BBUV\u7F29\u653E")]
		public float cloudShadowDistanceScale; // 0x28
		[Header("\u4E91\u5F71\u8DDD\u79BBUV\u7F29\u653E\u8D77\u59CB\u8DDD\u79BB")]
		[Range(1f, 4096f)]
		public float cloudShadowScaleStartDistance; // 0x2C
		[Header("\u4E91\u5F71\u8DDD\u79BBUV\u7F29\u653E\u7ED3\u675F\u8303\u56F4")]
		[UnclampedRange(1f, 10000f)]
		public float cloudShadowScaleEndDistance; // 0x30
	
		// Properties
		public bool active { get => default; set {} } // 0x0000000189C6E3DC-0x0000000189C6E428 0x0000000189C6E428-0x0000000189C6E47C
		// Boolean get_active()
		bool HG::Rendering::Runtime::HGCloudShadowConfig::get_active(HGCloudShadowConfig *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1349, 0LL) )
		    return 1;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1349, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_536(Patch, this, 0LL);
		}
		

		// Void set_active(Boolean)
		void HG::Rendering::Runtime::HGCloudShadowConfig::set_active(HGCloudShadowConfig *this, bool value, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1350, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1350, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_537(Patch, this, value, 0LL);
		  }
		}
		
	
		// Constructors
		public HGCloudShadowConfig(bool active) : this() {
			cloudShadowTexture = default;
			cloudShadowEnvCenter = default;
			cloudShadowCoverage = default;
			cloudShadowFlowSpeed = default;
			cloudShadowFlowDirection = default;
			cloudShadowAlpha = default;
			cloudShadowDistanceScale = default;
			cloudShadowScaleStartDistance = default;
			cloudShadowScaleEndDistance = default;
		} // 0x0000000189C6E37C-0x0000000189C6E3DC
		// HGCloudShadowConfig(Boolean)
		// local variable allocation has failed, the output may be wrong!
		void HG::Rendering::Runtime::HGCloudShadowConfig::HGCloudShadowConfig(
		        HGCloudShadowConfig *this,
		        bool active,
		        MethodInfo *method)
		{
		  __int64 v3; // r9
		  MethodInfo *v4; // [rsp+20h] [rbp-8h]
		
		  this->cloudShadowTexture = 0LL;
		  sub_18002D1B0((SingleFieldAccessor *)this, (Type *)active, (PropertyInfo_1 *)method, (Int32__Array **)this, v4);
		  *(_DWORD *)(v3 + 24) = 0;
		  *(_DWORD *)(v3 + 28) = 1060439283;
		  *(_DWORD *)(v3 + 32) = 1060439283;
		  *(_DWORD *)(v3 + 20) = 1092616192;
		  *(_DWORD *)(v3 + 44) = 1140850688;
		  *(_QWORD *)(v3 + 8) = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  *(_DWORD *)(v3 + 48) = 1140850688;
		  *(_DWORD *)(v3 + 16) = 0;
		  *(_DWORD *)(v3 + 36) = 1065353216;
		  *(_DWORD *)(v3 + 40) = 1092616192;
		}
		
	
		// Methods
		public void Lerp<T>(ref ref T cSrc, ref ref T cDst, float t)
			where T : struct, IEnvConfig {}
	}
}
