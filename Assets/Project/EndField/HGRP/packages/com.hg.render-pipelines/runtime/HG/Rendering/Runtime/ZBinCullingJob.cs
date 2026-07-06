using System;
using System.Runtime.InteropServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;

namespace HG.Rendering.Runtime
{
	[BurstCompile]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 48)]
	public struct ZBinCullingJob : IJobParallelFor
	{
		public void Execute(int lightIndex)
		{
			// // Void Execute(Int32)
			// void HG::Rendering::Runtime::ZBinCullingJob::Execute(ZBinCullingJob *this, int32_t lightIndex, MethodInfo *method)
			// {
			//   __int64 v3; // rdi
			//   MethodInfo *v5; // r8
			//   Void *m_Buffer; // rax
			//   __m128 v7; // xmm3
			//   float v8; // xmm0_4
			//   int v9; // ebp
			//   int NUM_Z_SLICES; // esi
			//   LightCulling__StaticFields *static_fields; // rcx
			//   __int64 v12; // rcx
			//   __int64 v13; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			//   Vector3 value; // [rsp+20h] [rbp-28h] BYREF
			//   Vector3 vector; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   v3 = lightIndex;
			//   if ( !byte_18D919E35 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::LightCulling);
			//     byte_18D919E35 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1666, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1666, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v16, v15);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_643(Patch, this, v3, 0LL);
			//   }
			//   else
			//   {
			//     m_Buffer = this.lightSphereData.m_Buffer;
			//     *(_QWORD *)&value.x = *(_QWORD *)&this.cameraDirection.x;
			//     v7 = (__m128)_mm_loadu_si128((const __m128i *)&m_Buffer[16 * v3]);
			//     value.z = this.cameraDirection.z;
			//     *(_QWORD *)&vector.x = _mm_unpacklo_ps(v7, _mm_shuffle_ps(v7, v7, 85)).m128_u64[0];
			//     LODWORD(vector.z) = _mm_shuffle_ps(v7, v7, 170).m128_u32[0];
			//     v8 = Dest::Math::Vector3ex::Dot(&vector, &value, v5) - this.nearClipPlane;
			//     v7.m128_f32[0] = _mm_shuffle_ps(v7, v7, 255).m128_f32[0];
			//     v9 = (int)(float)((float)(v8 - v7.m128_f32[0]) / this.sliceSize);
			//     NUM_Z_SLICES = (int)(float)((float)(v7.m128_f32[0] + v8) / this.sliceSize) + 1;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::LightCulling);
			//     static_fields = TypeInfo::HG::Rendering::Runtime::LightCulling.static_fields;
			//     if ( NUM_Z_SLICES >= static_fields.NUM_Z_SLICES )
			//       NUM_Z_SLICES = static_fields.NUM_Z_SLICES;
			//     if ( v9 <= 0 )
			//       v9 = 0;
			//     if ( v9 < NUM_Z_SLICES )
			//     {
			//       v12 = v9;
			//       v13 = (unsigned int)(NUM_Z_SLICES - v9);
			//       do
			//       {
			//         _InterlockedAdd(&this.zBin[v12++], 1 << (((int)v3 % 32) & 0x1F));
			//         --v13;
			//       }
			//       while ( v13 );
			//     }
			//   }
			// }
			// 
		}

		public float sliceSize;

		public float3 cameraDirection;

		public float nearClipPlane;

		[ReadOnly]
		public NativeArray<float4> lightSphereData;

		[NativeDisableUnsafePtrRestriction]
		public unsafe int* zBin;
	}
}
