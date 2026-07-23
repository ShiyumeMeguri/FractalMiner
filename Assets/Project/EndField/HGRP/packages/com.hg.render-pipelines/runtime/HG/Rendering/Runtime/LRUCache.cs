using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class LRUCache // TypeDefIndex: 38642
	{
		// Fields
		private LRUNode[] m_nodes; // 0x10
	
		// Constructors
		public LRUCache() {} // 0x00000001841E1670-0x00000001841E1680
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
		public void Reset(int size) {} // 0x0000000189C238BC-0x0000000189C239D0
		// Void Reset(Int32)
		void HG::Rendering::Runtime::LRUCache::Reset(LRUCache *this, int32_t size, MethodInfo *method)
		{
		  __int64 v3; // rsi
		  __int64 v5; // rdx
		  HGRuntimeGrassQuery_Node *v6; // rdx
		  HGRuntimeGrassQuery_Node *v7; // r8
		  Int32__Array **v8; // r9
		  int v9; // ebp
		  LRUNode__Array *m_nodes; // rcx
		  __int64 v11; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v13; // [rsp+20h] [rbp-8h]
		
		  v3 = size;
		  if ( IFix::WrappersManagerImpl::IsPatched(442, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(442, 0LL);
		    if ( !Patch )
		      goto LABEL_14;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, v3, 0LL);
		  }
		  else
		  {
		    if ( !this->fields.m_nodes || (_DWORD)v3 != this->fields.m_nodes->max_length.size - 1 )
		    {
		      this->fields.m_nodes = (LRUNode__Array *)il2cpp_array_new_specific_1(
		                                                 TypeInfo::HG::Rendering::Runtime::LRUNode,
		                                                 (unsigned int)(v3 + 1));
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v6, v7, v8, v13);
		    }
		    v9 = 0;
		    if ( (int)v3 >= 0 )
		    {
		      while ( 1 )
		      {
		        m_nodes = this->fields.m_nodes;
		        if ( !m_nodes )
		          break;
		        *(_DWORD *)sub_1803C07B0(m_nodes, v9) = -1;
		        m_nodes = this->fields.m_nodes;
		        if ( !m_nodes )
		          break;
		        *(_DWORD *)(sub_1803C07B0(m_nodes, v9) + 4) = v9 - 1;
		        m_nodes = this->fields.m_nodes;
		        if ( !m_nodes )
		          break;
		        v11 = sub_1803C07B0(m_nodes, v9++);
		        *(_DWORD *)(v11 + 8) = v9;
		        if ( v9 > (int)v3 )
		          goto LABEL_10;
		      }
		LABEL_14:
		      sub_1800D8260(m_nodes, v5);
		    }
		LABEL_10:
		    m_nodes = this->fields.m_nodes;
		    if ( !m_nodes )
		      goto LABEL_14;
		    *(_DWORD *)(sub_1803C07B0(m_nodes, v3) + 8) = 0;
		    m_nodes = this->fields.m_nodes;
		    if ( !m_nodes )
		      goto LABEL_14;
		    *(_DWORD *)(sub_1803C07B0(m_nodes, 0LL) + 4) = v3;
		  }
		}
		
		public void Lock(int idx) {} // 0x0000000189C237CC-0x0000000189C238BC
		// Void Lock(Int32)
		void HG::Rendering::Runtime::LRUCache::Lock(LRUCache *this, int32_t idx, MethodInfo *method)
		{
		  __int64 v3; // rdi
		  __int64 v5; // rdx
		  LRUNode__Array *m_nodes; // rcx
		  __int64 v7; // rax
		  __int64 v8; // rsi
		  __int64 v9; // rbp
		  LRUNode__Array *v10; // rsi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = idx;
		  if ( !IFix::WrappersManagerImpl::IsPatched(3996, 0LL) )
		  {
		    m_nodes = this->fields.m_nodes;
		    if ( m_nodes )
		    {
		      v7 = sub_1803C07B0(m_nodes, v3);
		      m_nodes = this->fields.m_nodes;
		      v8 = *(int *)(v7 + 4);
		      if ( m_nodes )
		      {
		        v9 = *(int *)(sub_1803C07B0(m_nodes, v3) + 8);
		        if ( (_DWORD)v8 == -1 )
		          return;
		        m_nodes = this->fields.m_nodes;
		        if ( m_nodes )
		        {
		          *(_DWORD *)(sub_1803C07B0(m_nodes, v8) + 8) = v9;
		          m_nodes = this->fields.m_nodes;
		          if ( m_nodes )
		          {
		            *(_DWORD *)(sub_1803C07B0(m_nodes, v9) + 4) = v8;
		            v10 = this->fields.m_nodes;
		            if ( v10 )
		            {
		              *(_DWORD *)(sub_1803C07B0(this->fields.m_nodes, v3) + 8) = -1;
		              *(_DWORD *)(sub_1803C07B0(v10, v3) + 4) = -1;
		              return;
		            }
		          }
		        }
		      }
		    }
		LABEL_10:
		    sub_1800D8260(m_nodes, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3996, 0LL);
		  if ( !Patch )
		    goto LABEL_10;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, v3, 0LL);
		}
		
		public void Unlock(int idx) {} // 0x0000000189C239D0-0x0000000189C23A94
		// Void Unlock(Int32)
		void HG::Rendering::Runtime::LRUCache::Unlock(LRUCache *this, int32_t idx, MethodInfo *method)
		{
		  __int64 v3; // rdi
		  __int64 v5; // rdx
		  LRUNode__Array *m_nodes; // rcx
		  __int64 v7; // rax
		  __int64 v8; // rsi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = idx;
		  if ( !IFix::WrappersManagerImpl::IsPatched(4003, 0LL) )
		  {
		    m_nodes = this->fields.m_nodes;
		    if ( m_nodes )
		    {
		      v7 = sub_1803C07B0(m_nodes, 0LL);
		      m_nodes = this->fields.m_nodes;
		      v8 = *(int *)(v7 + 8);
		      if ( m_nodes )
		      {
		        *(_DWORD *)(sub_1803C07B0(m_nodes, 0LL) + 8) = v3;
		        m_nodes = this->fields.m_nodes;
		        if ( m_nodes )
		        {
		          *(_DWORD *)(sub_1803C07B0(m_nodes, v3) + 4) = 0;
		          m_nodes = this->fields.m_nodes;
		          if ( m_nodes )
		          {
		            *(_DWORD *)(sub_1803C07B0(m_nodes, v3) + 8) = v8;
		            m_nodes = this->fields.m_nodes;
		            if ( m_nodes )
		            {
		              *(_DWORD *)(sub_1803C07B0(m_nodes, v8) + 4) = v3;
		              return;
		            }
		          }
		        }
		      }
		    }
		LABEL_9:
		    sub_1800D8260(m_nodes, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(4003, 0LL);
		  if ( !Patch )
		    goto LABEL_9;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, v3, 0LL);
		}
		
		public void Visit(int idx) {} // 0x0000000189C23A94-0x0000000189C23BCC
		// Void Visit(Int32)
		void HG::Rendering::Runtime::LRUCache::Visit(LRUCache *this, int32_t idx, MethodInfo *method)
		{
		  __int64 v3; // rdi
		  __int64 v5; // rdx
		  LRUNode__Array *m_nodes; // rcx
		  __int64 v7; // rax
		  __int64 v8; // rsi
		  __int64 v9; // rbp
		  __int64 v10; // rax
		  __int64 v11; // rsi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = idx;
		  if ( !IFix::WrappersManagerImpl::IsPatched(2050, 0LL) )
		  {
		    m_nodes = this->fields.m_nodes;
		    if ( m_nodes )
		    {
		      v7 = sub_1803C07B0(m_nodes, v3);
		      m_nodes = this->fields.m_nodes;
		      v8 = *(int *)(v7 + 4);
		      if ( m_nodes )
		      {
		        v9 = *(int *)(sub_1803C07B0(m_nodes, v3) + 8);
		        if ( (_DWORD)v8 == -1 )
		          return;
		        m_nodes = this->fields.m_nodes;
		        if ( m_nodes )
		        {
		          *(_DWORD *)(sub_1803C07B0(m_nodes, v8) + 8) = v9;
		          m_nodes = this->fields.m_nodes;
		          if ( m_nodes )
		          {
		            *(_DWORD *)(sub_1803C07B0(m_nodes, v9) + 4) = v8;
		            m_nodes = this->fields.m_nodes;
		            if ( m_nodes )
		            {
		              v10 = sub_1803C07B0(m_nodes, 0LL);
		              m_nodes = this->fields.m_nodes;
		              v11 = *(int *)(v10 + 8);
		              if ( m_nodes )
		              {
		                *(_DWORD *)(sub_1803C07B0(m_nodes, 0LL) + 8) = v3;
		                m_nodes = this->fields.m_nodes;
		                if ( m_nodes )
		                {
		                  *(_DWORD *)(sub_1803C07B0(m_nodes, v11) + 4) = v3;
		                  m_nodes = this->fields.m_nodes;
		                  if ( m_nodes )
		                  {
		                    *(_DWORD *)(sub_1803C07B0(m_nodes, v3) + 4) = 0;
		                    m_nodes = this->fields.m_nodes;
		                    if ( m_nodes )
		                    {
		                      *(_DWORD *)(sub_1803C07B0(m_nodes, v3) + 8) = v11;
		                      return;
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_14:
		    sub_1800D8260(m_nodes, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2050, 0LL);
		  if ( !Patch )
		    goto LABEL_14;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, v3, 0LL);
		}
		
		public ValueTuple<int, int> Allocate(int newKey) => default; // 0x0000000189C23660-0x0000000189C237CC
		// ValueTuple`2[Int32,Int32] Allocate(Int32)
		ValueTuple_2_Int32_Int32_ HG::Rendering::Runtime::LRUCache::Allocate(
		        LRUCache *this,
		        int32_t newKey,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  LRUNode__Array *m_nodes; // rcx
		  __int64 v7; // rax
		  __int64 v8; // rdi
		  __int64 v9; // rax
		  __int64 v10; // rbp
		  __int64 v11; // rax
		  __int64 v12; // rsi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ValueTuple_2_Int32_Int32_ v15; // [rsp+58h] [rbp+20h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2051, 0LL) )
		  {
		    m_nodes = this->fields.m_nodes;
		    if ( m_nodes )
		    {
		      v7 = sub_1803C07B0(m_nodes, 0LL);
		      m_nodes = this->fields.m_nodes;
		      v8 = *(int *)(v7 + 4);
		      if ( m_nodes )
		      {
		        v15.Item1 = *(_DWORD *)(v7 + 4);
		        v15.Item2 = *(_DWORD *)sub_1803C07B0(m_nodes, v15.Item1);
		        m_nodes = this->fields.m_nodes;
		        if ( m_nodes )
		        {
		          v9 = sub_1803C07B0(m_nodes, v8);
		          m_nodes = this->fields.m_nodes;
		          v10 = *(int *)(v9 + 4);
		          if ( m_nodes )
		          {
		            v11 = sub_1803C07B0(m_nodes, 0LL);
		            m_nodes = this->fields.m_nodes;
		            v12 = *(int *)(v11 + 8);
		            if ( m_nodes )
		            {
		              *(_DWORD *)(sub_1803C07B0(m_nodes, 0LL) + 4) = v10;
		              m_nodes = this->fields.m_nodes;
		              if ( m_nodes )
		              {
		                *(_DWORD *)(sub_1803C07B0(m_nodes, 0LL) + 8) = v8;
		                m_nodes = this->fields.m_nodes;
		                if ( m_nodes )
		                {
		                  *(_DWORD *)(sub_1803C07B0(m_nodes, v10) + 8) = 0;
		                  m_nodes = this->fields.m_nodes;
		                  if ( m_nodes )
		                  {
		                    *(_DWORD *)(sub_1803C07B0(m_nodes, v12) + 4) = v8;
		                    m_nodes = this->fields.m_nodes;
		                    if ( m_nodes )
		                    {
		                      *(_DWORD *)sub_1803C07B0(m_nodes, v8) = newKey;
		                      m_nodes = this->fields.m_nodes;
		                      if ( m_nodes )
		                      {
		                        *(_DWORD *)(sub_1803C07B0(m_nodes, v8) + 4) = 0;
		                        m_nodes = this->fields.m_nodes;
		                        if ( m_nodes )
		                        {
		                          *(_DWORD *)(sub_1803C07B0(m_nodes, v8) + 8) = v12;
		                          return v15;
		                        }
		                      }
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_15:
		    sub_1800D8260(m_nodes, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2051, 0LL);
		  if ( !Patch )
		    goto LABEL_15;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_821(Patch, (Object *)this, newKey, 0LL);
		}
		
	}
}
