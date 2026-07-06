using System;

namespace HG.Rendering.Runtime
{
	public class LRUCache
	{
		public LRUCache()
		{
			// // Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
			// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			//         HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			//         HGWindConfig *cSrc,
			//         HGWindConfig *cDst,
			//         float t,
			//         MethodInfo *method)
			// {
			//   ;
			// }
			// 
		}

		public void Reset(int size)
		{
		}

		public void Lock(int idx)
		{
			// // Void Lock(Int32)
			// void HG::Rendering::Runtime::LRUCache::Lock(LRUCache *this, int32_t idx, MethodInfo *method)
			// {
			//   __int64 v3; // rdi
			//   __int64 v5; // rdx
			//   LRUNode__Array *m_nodes; // rcx
			//   __int64 v7; // rax
			//   __int64 v8; // rsi
			//   __int64 v9; // rbp
			//   LRUNode__Array *v10; // rsi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   v3 = idx;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3374, 0LL) )
			//   {
			//     m_nodes = this.fields.m_nodes;
			//     if ( m_nodes )
			//     {
			//       v7 = sub_18037A31C(m_nodes, v3);
			//       m_nodes = this.fields.m_nodes;
			//       v8 = *(int *)(v7 + 4);
			//       if ( m_nodes )
			//       {
			//         v9 = *(int *)(sub_18037A31C(m_nodes, v3) + 8);
			//         if ( (_DWORD)v8 == -1 )
			//           return;
			//         m_nodes = this.fields.m_nodes;
			//         if ( m_nodes )
			//         {
			//           *(_DWORD *)(sub_18037A31C(m_nodes, v8) + 8) = v9;
			//           m_nodes = this.fields.m_nodes;
			//           if ( m_nodes )
			//           {
			//             *(_DWORD *)(sub_18037A31C(m_nodes, v9) + 4) = v8;
			//             v10 = this.fields.m_nodes;
			//             if ( v10 )
			//             {
			//               *(_DWORD *)(sub_18037A31C(this.fields.m_nodes, v3) + 8) = -1;
			//               *(_DWORD *)(sub_18037A31C(v10, v3) + 4) = -1;
			//               return;
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_10:
			//     sub_180B536AC(m_nodes, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3374, 0LL);
			//   if ( !Patch )
			//     goto LABEL_10;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, v3, 0LL);
			// }
			// 
		}

		public void Unlock(int idx)
		{
			// // Void Unlock(Int32)
			// void HG::Rendering::Runtime::LRUCache::Unlock(LRUCache *this, int32_t idx, MethodInfo *method)
			// {
			//   __int64 v3; // rdi
			//   __int64 v5; // rdx
			//   LRUNode__Array *m_nodes; // rcx
			//   __int64 v7; // rax
			//   __int64 v8; // rsi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   v3 = idx;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3380, 0LL) )
			//   {
			//     m_nodes = this.fields.m_nodes;
			//     if ( m_nodes )
			//     {
			//       v7 = sub_18037A31C(m_nodes, 0LL);
			//       m_nodes = this.fields.m_nodes;
			//       v8 = *(int *)(v7 + 8);
			//       if ( m_nodes )
			//       {
			//         *(_DWORD *)(sub_18037A31C(m_nodes, 0LL) + 8) = v3;
			//         m_nodes = this.fields.m_nodes;
			//         if ( m_nodes )
			//         {
			//           *(_DWORD *)(sub_18037A31C(m_nodes, v3) + 4) = 0;
			//           m_nodes = this.fields.m_nodes;
			//           if ( m_nodes )
			//           {
			//             *(_DWORD *)(sub_18037A31C(m_nodes, v3) + 8) = v8;
			//             m_nodes = this.fields.m_nodes;
			//             if ( m_nodes )
			//             {
			//               *(_DWORD *)(sub_18037A31C(m_nodes, v8) + 4) = v3;
			//               return;
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(m_nodes, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3380, 0LL);
			//   if ( !Patch )
			//     goto LABEL_9;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, v3, 0LL);
			// }
			// 
		}

		public void Visit(int idx)
		{
			// // Void Visit(Int32)
			// void HG::Rendering::Runtime::LRUCache::Visit(LRUCache *this, int32_t idx, MethodInfo *method)
			// {
			//   __int64 v3; // rdi
			//   __int64 v5; // rdx
			//   LRUNode__Array *m_nodes; // rcx
			//   __int64 v7; // rax
			//   __int64 v8; // rsi
			//   __int64 v9; // rbp
			//   __int64 v10; // rax
			//   __int64 v11; // rsi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   v3 = idx;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1736, 0LL) )
			//   {
			//     m_nodes = this.fields.m_nodes;
			//     if ( m_nodes )
			//     {
			//       v7 = sub_18037A31C(m_nodes, v3);
			//       m_nodes = this.fields.m_nodes;
			//       v8 = *(int *)(v7 + 4);
			//       if ( m_nodes )
			//       {
			//         v9 = *(int *)(sub_18037A31C(m_nodes, v3) + 8);
			//         if ( (_DWORD)v8 == -1 )
			//           return;
			//         m_nodes = this.fields.m_nodes;
			//         if ( m_nodes )
			//         {
			//           *(_DWORD *)(sub_18037A31C(m_nodes, v8) + 8) = v9;
			//           m_nodes = this.fields.m_nodes;
			//           if ( m_nodes )
			//           {
			//             *(_DWORD *)(sub_18037A31C(m_nodes, v9) + 4) = v8;
			//             m_nodes = this.fields.m_nodes;
			//             if ( m_nodes )
			//             {
			//               v10 = sub_18037A31C(m_nodes, 0LL);
			//               m_nodes = this.fields.m_nodes;
			//               v11 = *(int *)(v10 + 8);
			//               if ( m_nodes )
			//               {
			//                 *(_DWORD *)(sub_18037A31C(m_nodes, 0LL) + 8) = v3;
			//                 m_nodes = this.fields.m_nodes;
			//                 if ( m_nodes )
			//                 {
			//                   *(_DWORD *)(sub_18037A31C(m_nodes, v11) + 4) = v3;
			//                   m_nodes = this.fields.m_nodes;
			//                   if ( m_nodes )
			//                   {
			//                     *(_DWORD *)(sub_18037A31C(m_nodes, v3) + 4) = 0;
			//                     m_nodes = this.fields.m_nodes;
			//                     if ( m_nodes )
			//                     {
			//                       *(_DWORD *)(sub_18037A31C(m_nodes, v3) + 8) = v11;
			//                       return;
			//                     }
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_14:
			//     sub_180B536AC(m_nodes, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1736, 0LL);
			//   if ( !Patch )
			//     goto LABEL_14;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, v3, 0LL);
			// }
			// 
		}

		public ValueTuple<int, int> Allocate(int newKey)
		{
			// // ValueTuple`2[Int32,Int32] Allocate(Int32)
			// ValueTuple_2_Int32_Int32_ HG::Rendering::Runtime::LRUCache::Allocate(
			//         LRUCache *this,
			//         int32_t newKey,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   LRUNode__Array *m_nodes; // rcx
			//   __int64 v7; // rax
			//   __int64 v8; // rdi
			//   __int64 v9; // rax
			//   __int64 v10; // rbp
			//   __int64 v11; // rax
			//   __int64 v12; // rsi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ValueTuple_2_Int32_Int32_ v15; // [rsp+58h] [rbp+20h]
			// 
			//   if ( !byte_18D91972E )
			//   {
			//     sub_18003C530(&MethodInfo::System::ValueTuple<int,int>::ValueTuple);
			//     byte_18D91972E = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1737, 0LL) )
			//   {
			//     m_nodes = this.fields.m_nodes;
			//     if ( m_nodes )
			//     {
			//       v7 = sub_18037A31C(m_nodes, 0LL);
			//       m_nodes = this.fields.m_nodes;
			//       v8 = *(int *)(v7 + 4);
			//       if ( m_nodes )
			//       {
			//         v15.Item1 = *(_DWORD *)(v7 + 4);
			//         v15.Item2 = *(_DWORD *)sub_18037A31C(m_nodes, v15.Item1);
			//         m_nodes = this.fields.m_nodes;
			//         if ( m_nodes )
			//         {
			//           v9 = sub_18037A31C(m_nodes, v8);
			//           m_nodes = this.fields.m_nodes;
			//           v10 = *(int *)(v9 + 4);
			//           if ( m_nodes )
			//           {
			//             v11 = sub_18037A31C(m_nodes, 0LL);
			//             m_nodes = this.fields.m_nodes;
			//             v12 = *(int *)(v11 + 8);
			//             if ( m_nodes )
			//             {
			//               *(_DWORD *)(sub_18037A31C(m_nodes, 0LL) + 4) = v10;
			//               m_nodes = this.fields.m_nodes;
			//               if ( m_nodes )
			//               {
			//                 *(_DWORD *)(sub_18037A31C(m_nodes, 0LL) + 8) = v8;
			//                 m_nodes = this.fields.m_nodes;
			//                 if ( m_nodes )
			//                 {
			//                   *(_DWORD *)(sub_18037A31C(m_nodes, v10) + 8) = 0;
			//                   m_nodes = this.fields.m_nodes;
			//                   if ( m_nodes )
			//                   {
			//                     *(_DWORD *)(sub_18037A31C(m_nodes, v12) + 4) = v8;
			//                     m_nodes = this.fields.m_nodes;
			//                     if ( m_nodes )
			//                     {
			//                       *(_DWORD *)sub_18037A31C(m_nodes, v8) = newKey;
			//                       m_nodes = this.fields.m_nodes;
			//                       if ( m_nodes )
			//                       {
			//                         *(_DWORD *)(sub_18037A31C(m_nodes, v8) + 4) = 0;
			//                         m_nodes = this.fields.m_nodes;
			//                         if ( m_nodes )
			//                         {
			//                           *(_DWORD *)(sub_18037A31C(m_nodes, v8) + 8) = v12;
			//                           return v15;
			//                         }
			//                       }
			//                     }
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_17:
			//     sub_180B536AC(m_nodes, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1737, 0LL);
			//   if ( !Patch )
			//     goto LABEL_17;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_667(Patch, (Object *)this, newKey, 0LL);
			// }
			// 
			return null;
		}

		private LRUNode[] m_nodes;
	}
}
