using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[DisallowMultipleComponent]
	public class ClothGroupInfo : MonoBehaviour
	{
		public ClothGroupInfo()
		{
		}

		public void RecomputeBounds()
		{
			// // Void RecomputeBounds()
			// void HG::Rendering::Runtime::ClothGroupInfo::RecomputeBounds(ClothGroupInfo *this, MethodInfo *method)
			// {
			//   ClothInfo *v3; // rdx
			//   ClothInfo__Array *v4; // rcx
			//   int32_t v5; // r8d
			//   MethodInfo *v6; // r9
			//   unsigned int i; // ebx
			//   ClothInfo__Array *clothInfos; // rax
			//   Vector3 *Vector; // rax
			//   __int64 v10; // xmm1_8
			//   ClothInfo *v11; // rax
			//   __int64 v12; // xmm0_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   float v14[4]; // [rsp+20h] [rbp-68h]
			//   Vector3 v15; // [rsp+40h] [rbp-48h] BYREF
			//   Bounds v16; // [rsp+50h] [rbp-38h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1105, 0LL) )
			//   {
			//     for ( i = 0; ; ++i )
			//     {
			//       clothInfos = this.fields.clothInfos;
			//       if ( !clothInfos )
			//         break;
			//       if ( (signed int)i >= clothInfos.max_length.size )
			//         return;
			//       v4 = this.fields.clothInfos;
			//       if ( i >= clothInfos.max_length.size )
			//         goto LABEL_22;
			//       v3 = v4.vector[i];
			//       if ( !v3 )
			//         break;
			//       Vector = UnityEngine::Animator::GetVector(&v15, (Animator *)v3, v5, v6);
			//       *(_QWORD *)v14 = *(_QWORD *)&v3.fields.clothBounds.m_Extents.x;
			//       if ( (float)((float)((float)((float)(v14[1] - COERCE_FLOAT(HIDWORD(*(_QWORD *)&Vector.x)))
			//                                  * (float)(v14[1] - COERCE_FLOAT(HIDWORD(*(_QWORD *)&Vector.x))))
			//                          + (float)((float)(v14[0] - COERCE_FLOAT(*(_QWORD *)&Vector.x))
			//                                  * (float)(v14[0] - COERCE_FLOAT(*(_QWORD *)&Vector.x))))
			//                  + (float)((float)(v3.fields.clothBounds.m_Extents.z - Vector.z)
			//                          * (float)(v3.fields.clothBounds.m_Extents.z - Vector.z))) < 9.9999994e-11 )
			//       {
			//         v4 = this.fields.clothInfos;
			//         if ( !v4 )
			//           break;
			//         if ( i >= v4.max_length.size )
			//           goto LABEL_22;
			//         v4 = (ClothInfo__Array *)v4.vector[i];
			//         if ( !v4 )
			//           break;
			//         HG::Rendering::Runtime::ClothInfo::RecomputeBounds((ClothInfo *)v4, 0LL);
			//       }
			//       v4 = this.fields.clothInfos;
			//       if ( i )
			//       {
			//         if ( !v4 )
			//           break;
			//         if ( i >= v4.max_length.size )
			//           goto LABEL_22;
			//         v3 = v4.vector[i];
			//         if ( !v3 )
			//           break;
			//         v10 = *(_QWORD *)&v3.fields.clothBounds.m_Extents.y;
			//         *(_OWORD *)&v16.m_Center.x = *(_OWORD *)&v3.fields.clothBounds.m_Center.x;
			//         *(_QWORD *)&v16.m_Extents.y = v10;
			//         UnityEngine::Bounds::Encapsulate(&this.fields.groupBounds, &v16, 0LL);
			//       }
			//       else
			//       {
			//         if ( !v4 )
			//           break;
			//         if ( !v4.max_length.size )
			// LABEL_22:
			//           sub_180070270(v4, v3);
			//         v11 = v4.vector[0];
			//         if ( !v11 )
			//           break;
			//         v12 = *(_QWORD *)&v11.fields.clothBounds.m_Extents.y;
			//         *(_OWORD *)&this.fields.groupBounds.m_Center.x = *(_OWORD *)&v11.fields.clothBounds.m_Center.x;
			//         *(_QWORD *)&this.fields.groupBounds.m_Extents.y = v12;
			//       }
			//     }
			// LABEL_24:
			//     sub_180B536AC(v4, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1105, 0LL);
			//   if ( !Patch )
			//     goto LABEL_24;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		public void FillPadding()
		{
			// // Void FillPadding()
			// void HG::Rendering::Runtime::ClothGroupInfo::FillPadding(ClothGroupInfo *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   DynamicArray_1_Unity_Mathematics_int4_ *v4; // rcx
			//   __int64 v5; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   int4 value; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919CD9 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<Unity::Mathematics::int4>::Add);
			//     byte_18D919CD9 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1107, 0LL) )
			//   {
			//     v5 = *(_QWORD *)&this[1].fields.isBuilt;
			//     if ( v5 )
			//     {
			//       if ( *(_DWORD *)(v5 + 24) )
			//         return;
			//       v4 = *(DynamicArray_1_Unity_Mathematics_int4_ **)(v5 + 16);
			//       value = 0LL;
			//       if ( v4 )
			//       {
			//         UnityEngine::Rendering::DynamicArray<Unity::Mathematics::int4>::Add(
			//           v4,
			//           &value,
			//           MethodInfo::UnityEngine::Rendering::DynamicArray<Unity::Mathematics::int4>::Add);
			//         return;
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(v4, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1107, 0LL);
			//   if ( !Patch )
			//     goto LABEL_9;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		[NonSerialized]
		public int groupIdx;

		[NonSerialized]
		public ClothInfo[] clothInfos;

		[NonSerialized]
		public bool isBuilt;

		[NonSerialized]
		public Bounds groupBounds;

		[NonSerialized]
		public ClothGroupMeta groupMeta;

		[NonSerialized]
		public DynamicArray<ClothMetaData> clothMetaDataArray;

		[NonSerialized]
		public DynamicArray<ClothNodeData> clothNodeDataArray;

		[NonSerialized]
		public CompressedInt2Array clothBatchMetaArray;

		[NonSerialized]
		public CompressedInt2Array clothBatchCacheMapArray;
	}
}
