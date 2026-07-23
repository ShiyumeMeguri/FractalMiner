using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[BurstCompile]
	public struct ZBinCullingJob : IJobParallelFor // TypeDefIndex: 37798
	{
		// Fields
		public float sliceSize; // 0x00
		public float3 cameraDirection; // 0x04
		public float nearClipPlane; // 0x10
		[ReadOnly]
		public NativeArray<float4> lightSphereData; // 0x18
		[NativeDisableUnsafePtrRestriction]
		public unsafe int* zBin; // 0x28
	
		// Methods
		public void Execute(int lightIndex) {} // 0x0000000189D154F4-0x0000000189D15644
		// Void Execute(Int32)
		void HG::Rendering::Runtime::ZBinCullingJob::Execute(ZBinCullingJob *this, int32_t lightIndex, MethodInfo *method)
		{
		  __int64 v3; // rdi
		  Void *m_Buffer; // rax
		  __m128 v6; // xmm3
		  float v7; // xmm0_4
		  int v8; // ebp
		  int NUM_Z_SLICES; // esi
		  LightCulling__StaticFields *static_fields; // rcx
		  __int64 v11; // rcx
		  __int64 v12; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  Vector3 value; // [rsp+20h] [rbp-28h] BYREF
		  Vector3 vector; // [rsp+30h] [rbp-18h] BYREF
		
		  v3 = lightIndex;
		  if ( IFix::WrappersManagerImpl::IsPatched(1978, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1978, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v15, v14);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_797(Patch, this, v3, 0LL);
		  }
		  else
		  {
		    m_Buffer = this->lightSphereData.m_Buffer;
		    *(_QWORD *)&value.x = *(_QWORD *)&this->cameraDirection.x;
		    v6 = (__m128)_mm_loadu_si128((const __m128i *)&m_Buffer[16 * v3]);
		    value.z = this->cameraDirection.z;
		    *(_QWORD *)&vector.x = _mm_unpacklo_ps(v6, _mm_shuffle_ps(v6, v6, 85)).m128_u64[0];
		    LODWORD(vector.z) = _mm_shuffle_ps(v6, v6, 170).m128_u32[0];
		    v7 = Dest::Math::Vector3ex::Dot(&vector, &value, (MethodInfo *)(2 * v3)) - this->nearClipPlane;
		    v6.m128_f32[0] = _mm_shuffle_ps(v6, v6, 255).m128_f32[0];
		    v8 = (int)(float)((float)(v7 - v6.m128_f32[0]) / this->sliceSize);
		    NUM_Z_SLICES = (int)(float)((float)(v6.m128_f32[0] + v7) / this->sliceSize) + 1;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::LightCulling);
		    static_fields = TypeInfo::HG::Rendering::Runtime::LightCulling->static_fields;
		    if ( NUM_Z_SLICES >= static_fields->NUM_Z_SLICES )
		      NUM_Z_SLICES = static_fields->NUM_Z_SLICES;
		    if ( v8 <= 0 )
		      v8 = 0;
		    if ( v8 < NUM_Z_SLICES )
		    {
		      v11 = v8;
		      v12 = (unsigned int)(NUM_Z_SLICES - v8);
		      do
		      {
		        _InterlockedAdd(&this->zBin[v11++], 1 << (((int)v3 % 32) & 0x1F));
		        --v12;
		      }
		      while ( v12 );
		    }
		  }
		}
		
	}
}
