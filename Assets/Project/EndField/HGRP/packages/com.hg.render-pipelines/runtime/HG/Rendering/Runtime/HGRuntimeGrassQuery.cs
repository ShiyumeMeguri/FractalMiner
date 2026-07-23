using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.HyperGryph.ECS;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGRuntimeGrassQuery // TypeDefIndex: 37999
	{
		// Fields
		private Node m_root; // 0x10
		private Dictionary<Entity, Node> m_grassClusterToNode; // 0x18
	
		// Nested types
		public class Node // TypeDefIndex: 37998
		{
			// Fields
			public Bounds bounds; // 0x10
			public Node parent; // 0x28
			public Node left; // 0x30
			public Node right; // 0x38
			public Bounds[] grassInstanceBounds; // 0x40
	
			// Constructors
			public Node() {} // Dummy constructor
			public Node(Node p, Node l, Node r) {} // 0x0000000189B6DC24-0x0000000189B6DCDC
			// HGRuntimeGrassQuery+Node(HGRuntimeGrassQuery+Node, HGRuntimeGrassQuery+Node, HGRuntimeGrassQuery+Node)
			void HG::Rendering::Runtime::HGRuntimeGrassQuery::Node::Node(
			        HGRuntimeGrassQuery_Node *this,
			        HGRuntimeGrassQuery_Node *p,
			        HGRuntimeGrassQuery_Node *l,
			        HGRuntimeGrassQuery_Node *r,
			        MethodInfo *method)
			{
			  __int64 v9; // xmm1_8
			  __int64 v10; // xmm1_8
			  HGRuntimeGrassQuery_Node *v11; // rdx
			  HGRuntimeGrassQuery_Node *v12; // r8
			  Int32__Array **v13; // r9
			  HGRuntimeGrassQuery_Node *v14; // rdx
			  HGRuntimeGrassQuery_Node *v15; // r8
			  Int32__Array **v16; // r9
			  HGRuntimeGrassQuery_Node *v17; // rdx
			  HGRuntimeGrassQuery_Node *v18; // r8
			  Int32__Array **v19; // r9
			  Bounds v20; // [rsp+20h] [rbp-28h] BYREF
			
			  if ( !l
			    || (v9 = *(_QWORD *)&l->fields.bounds.m_Extents.y,
			        *(_OWORD *)&v20.m_Center.x = *(_OWORD *)&l->fields.bounds.m_Center.x,
			        *(_QWORD *)&v20.m_Extents.y = v9,
			        UnityEngine::Bounds::Encapsulate(&this->fields.bounds, &v20, 0LL),
			        !r) )
			  {
			    sub_1800D8260(this, p);
			  }
			  v10 = *(_QWORD *)&r->fields.bounds.m_Extents.y;
			  *(_OWORD *)&v20.m_Center.x = *(_OWORD *)&r->fields.bounds.m_Center.x;
			  *(_QWORD *)&v20.m_Extents.y = v10;
			  UnityEngine::Bounds::Encapsulate(&this->fields.bounds, &v20, 0LL);
			  this->fields.parent = p;
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.parent, v11, v12, v13, *(MethodInfo **)&v20.m_Center.x);
			  this->fields.left = l;
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.left, v14, v15, v16, *(MethodInfo **)&v20.m_Center.x);
			  this->fields.right = r;
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.right, v17, v18, v19, method);
			}
			
			public Node(Bounds b) {} // 0x0000000184D99830-0x0000000184D99850
			// Void set_value(Ray)
			void ParadoxNotion::EventData<UnityEngine::Ray>::set_value(
			        EventData_1_UnityEngine_Ray_ *this,
			        Ray *value,
			        MethodInfo *method)
			{
			  __int64 v3; // xmm1_8
			
			  v3 = *(_QWORD *)&value->m_Direction.y;
			  *(_OWORD *)&this->_value_k__BackingField.m_Origin.x = *(_OWORD *)&value->m_Origin.x;
			  *(_QWORD *)&this->_value_k__BackingField.m_Direction.y = v3;
			}
			
	
			// Methods
			public bool IsLeaf() => default; // 0x0000000189B6DAA8-0x0000000189B6DB08
			// Boolean IsLeaf()
			bool HG::Rendering::Runtime::HGRuntimeGrassQuery::Node::IsLeaf(HGRuntimeGrassQuery_Node *this, MethodInfo *method)
			{
			  bool result; // al
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			
			  result = IFix::WrappersManagerImpl::IsPatched(2655, 0LL);
			  if ( result )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(2655, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v6, v5);
			    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
			  }
			  else if ( !this->fields.left )
			  {
			    return this->fields.right == 0LL;
			  }
			  return result;
			}
			
			public float ComputeMergeCost(Bounds b) => default; // 0x0000000189B6D954-0x0000000189B6DA40
			// Single ComputeMergeCost(Bounds)
			float HG::Rendering::Runtime::HGRuntimeGrassQuery::Node::ComputeMergeCost(
			        HGRuntimeGrassQuery_Node *this,
			        Bounds *b,
			        MethodInfo *method)
			{
			  __int64 v5; // xmm1_8
			  __int64 v6; // xmm1_8
			  float BoundsVolume; // xmm0_4
			  __int64 v8; // xmm2_8
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v11; // rdx
			  __int64 v12; // rcx
			  __int64 v13; // xmm1_8
			  Bounds v14; // [rsp+20h] [rbp-30h] BYREF
			
			  if ( IFix::WrappersManagerImpl::IsPatched(2653, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(2653, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v12, v11);
			    v13 = *(_QWORD *)&b->m_Extents.y;
			    *(_OWORD *)&v14.m_Center.x = *(_OWORD *)&b->m_Center.x;
			    *(_QWORD *)&v14.m_Extents.y = v13;
			    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_980(Patch, (Object *)this, &v14, 0LL);
			  }
			  else
			  {
			    v5 = *(_QWORD *)&this->fields.bounds.m_Extents.y;
			    *(_OWORD *)&v14.m_Center.x = *(_OWORD *)&this->fields.bounds.m_Center.x;
			    *(_QWORD *)&v14.m_Extents.y = v5;
			    UnityEngine::Bounds::Encapsulate(b, &v14, 0LL);
			    v6 = *(_QWORD *)&b->m_Extents.y;
			    *(_OWORD *)&v14.m_Center.x = *(_OWORD *)&b->m_Center.x;
			    *(_QWORD *)&v14.m_Extents.y = v6;
			    BoundsVolume = HG::Rendering::Runtime::HGRuntimeGrassQuery::Node::_GetBoundsVolume(this, &v14, 0LL);
			    v8 = *(_QWORD *)&this->fields.bounds.m_Extents.y;
			    *(_OWORD *)&v14.m_Center.x = *(_OWORD *)&this->fields.bounds.m_Center.x;
			    *(_QWORD *)&v14.m_Extents.y = v8;
			    return BoundsVolume - HG::Rendering::Runtime::HGRuntimeGrassQuery::Node::_GetBoundsVolume(this, &v14, 0LL);
			  }
			}
			
			public bool ReplaceChild(Node oldChild, Node newChild) => default; // 0x0000000189B6DB08-0x0000000189B6DB98
			// Boolean ReplaceChild(HGRuntimeGrassQuery+Node, HGRuntimeGrassQuery+Node)
			bool HG::Rendering::Runtime::HGRuntimeGrassQuery::Node::ReplaceChild(
			        HGRuntimeGrassQuery_Node *this,
			        HGRuntimeGrassQuery_Node *oldChild,
			        HGRuntimeGrassQuery_Node *newChild,
			        MethodInfo *method)
			{
			  bool result; // al
			  HGRuntimeGrassQuery_Node *v8; // rdx
			  HGRuntimeGrassQuery_Node *v9; // r8
			  Int32__Array **v10; // r9
			  HGRuntimeGrassQuery_Node **p_left; // rcx
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v13; // rdx
			  __int64 v14; // rcx
			  MethodInfo *v15; // [rsp+20h] [rbp-18h]
			
			  result = IFix::WrappersManagerImpl::IsPatched(2656, 0LL);
			  if ( result )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(2656, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v14, v13);
			    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_10(
			             (ILFixDynamicMethodWrapper_20 *)Patch,
			             (Object *)this,
			             (Object *)oldChild,
			             (Object *)newChild,
			             0LL);
			  }
			  else
			  {
			    if ( this->fields.left == oldChild )
			    {
			      this->fields.left = newChild;
			      p_left = &this->fields.left;
			    }
			    else
			    {
			      if ( this->fields.right != oldChild )
			        return result;
			      this->fields.right = newChild;
			      p_left = &this->fields.right;
			    }
			    sub_18002D1B0((HGRuntimeGrassQuery_Node *)p_left, v8, v9, v10, v15);
			    return 1;
			  }
			}
			
			public Node FindSibling() => default; // 0x0000000189B6DA40-0x0000000189B6DAA8
			// HGRuntimeGrassQuery+Node FindSibling()
			HGRuntimeGrassQuery_Node *HG::Rendering::Runtime::HGRuntimeGrassQuery::Node::FindSibling(
			        HGRuntimeGrassQuery_Node *this,
			        MethodInfo *method)
			{
			  __int64 v3; // rdx
			  HGRuntimeGrassQuery_Node *parent; // rcx
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			
			  if ( IFix::WrappersManagerImpl::IsPatched(2660, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(2660, 0LL);
			    if ( Patch )
			      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_978(Patch, (Object *)this, 0LL);
			LABEL_7:
			    sub_1800D8260(parent, v3);
			  }
			  parent = this->fields.parent;
			  if ( !parent )
			    goto LABEL_7;
			  if ( parent->fields.left == this )
			    return parent->fields.right;
			  else
			    return parent->fields.left;
			}
			
			private float _GetBoundsVolume(Bounds b) => default; // 0x0000000189B6DB98-0x0000000189B6DC24
			// Single _GetBoundsVolume(Bounds)
			float HG::Rendering::Runtime::HGRuntimeGrassQuery::Node::_GetBoundsVolume(
			        HGRuntimeGrassQuery_Node *this,
			        Bounds *b,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v7; // rdx
			  __int64 v8; // rcx
			  __int64 v9; // xmm1_8
			  Bounds v10; // [rsp+40h] [rbp-28h] BYREF
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(2654, 0LL) )
			    return (float)(COERCE_FLOAT(HIDWORD(*(_QWORD *)&b->m_Extents.x)) * COERCE_FLOAT(*(_QWORD *)&b->m_Extents.x))
			         * b->m_Extents.z;
			  Patch = IFix::WrappersManagerImpl::GetPatch(2654, 0LL);
			  if ( !Patch )
			    sub_1800D8260(v8, v7);
			  v9 = *(_QWORD *)&b->m_Extents.y;
			  *(_OWORD *)&v10.m_Center.x = *(_OWORD *)&b->m_Center.x;
			  *(_QWORD *)&v10.m_Extents.y = v9;
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_980(Patch, (Object *)this, &v10, 0LL);
			}
			
		}
	
		// Constructors
		public HGRuntimeGrassQuery() {} // 0x0000000182ED8C70-0x0000000182ED8CC0
		// HGRuntimeGrassQuery()
		void HG::Rendering::Runtime::HGRuntimeGrassQuery::HGRuntimeGrassQuery(HGRuntimeGrassQuery *this, MethodInfo *method)
		{
		  Dictionary_2_UnityEngine_HyperGryph_ECS_Entity_System_Single_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  Dictionary_2_UnityEngine_HyperGryph_ECS_Entity_HG_Rendering_Runtime_HGRuntimeGrassQuery_Node_ *v6; // rbx
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+50h] [rbp+28h]
		
		  v3 = (Dictionary_2_UnityEngine_HyperGryph_ECS_Entity_System_Single_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::HGRuntimeGrassQuery::Node>);
		  v6 = (Dictionary_2_UnityEngine_HyperGryph_ECS_Entity_HG_Rendering_Runtime_HGRuntimeGrassQuery_Node_ *)v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,float>::Dictionary(
		    v3,
		    MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::HGRuntimeGrassQuery::Node>::Dictionary);
		  this->fields.m_grassClusterToNode = v6;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_grassClusterToNode, v7, v8, v9, v10);
		}
		
	
		// Methods
		public Node GetNodeRoot() => default; // 0x0000000189B6CA24-0x0000000189B6CA74
		// HGRuntimeGrassQuery+Node GetNodeRoot()
		HGRuntimeGrassQuery_Node *HG::Rendering::Runtime::HGRuntimeGrassQuery::GetNodeRoot(
		        HGRuntimeGrassQuery *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2649, 0LL) )
		    return this->fields.m_root;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2649, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_978(Patch, (Object *)this, 0LL);
		}
		
		public Dictionary<Entity, Node> GetNodeLeaves() => default; // 0x0000000189B6C9D4-0x0000000189B6CA24
		// Dictionary`2[UnityEngine.HyperGryph.ECS.Entity,HG.Rendering.Runtime.HGRuntimeGrassQuery+Node] GetNodeLeaves()
		Dictionary_2_UnityEngine_HyperGryph_ECS_Entity_HG_Rendering_Runtime_HGRuntimeGrassQuery_Node_ *HG::Rendering::Runtime::HGRuntimeGrassQuery::GetNodeLeaves(
		        HGRuntimeGrassQuery *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2650, 0LL) )
		    return this->fields.m_grassClusterToNode;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2650, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_979(Patch, (Object *)this, 0LL);
		}
		
		public void RegisterGrassCluster(Entity grassCluster, Bounds meshBounds) {} // 0x0000000189B6CB14-0x0000000189B6CEA0
		// Void RegisterGrassCluster(Entity, Bounds)
		void HG::Rendering::Runtime::HGRuntimeGrassQuery::RegisterGrassCluster(
		        HGRuntimeGrassQuery *this,
		        Entity_1 grassCluster,
		        Bounds *meshBounds,
		        MethodInfo *method)
		{
		  __int64 v7; // rax
		  __int64 v8; // rdx
		  Dictionary_2_UnityEngine_HyperGryph_ECS_Entity_HG_Rendering_Runtime_HGRuntimeGrassQuery_Node_ *m_grassClusterToNode; // rcx
		  __int64 v10; // rsi
		  __int64 v11; // xmm1_8
		  uint64_t ComponentMaskLow; // rax
		  uint8_t *ComponentPtrLowBits; // rax
		  int v14; // r15d
		  uint8_t *v15; // r12
		  HGRuntimeGrassQuery_Node *v16; // rdx
		  HGRuntimeGrassQuery_Node *v17; // r8
		  Int32__Array **v18; // r9
		  int v19; // r14d
		  Matrix4x4 *v20; // rdi
		  MethodInfo *v21; // r8
		  Vector3 *v22; // rax
		  __int64 v23; // xmm8_8
		  float z; // ebx
		  Vector4 v25; // xmm0
		  MethodInfo *v26; // rdx
		  __m128 v27; // xmm7
		  MethodInfo *v28; // rdx
		  __m128 v29; // xmm6
		  MethodInfo *v30; // rdx
		  float v31; // eax
		  Vector3 *size; // rax
		  MethodInfo *v33; // r9
		  Vector3 *v34; // rax
		  __int64 v35; // xmm3_8
		  MethodInfo *v36; // r9
		  Vector3 *v37; // rax
		  __int64 v38; // xmm3_8
		  __int64 v39; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v41; // xmm1_8
		  MethodInfo *v42; // [rsp+28h] [rbp-E0h]
		  Bounds v43; // [rsp+38h] [rbp-D0h] BYREF
		  Bounds v44; // [rsp+58h] [rbp-B0h] BYREF
		  Vector3 v45; // [rsp+78h] [rbp-90h] BYREF
		  Vector3 v46; // [rsp+88h] [rbp-80h] BYREF
		  Vector3 v47; // [rsp+98h] [rbp-70h] BYREF
		  Vector3 v48; // [rsp+A8h] [rbp-60h] BYREF
		  Vector3 v49; // [rsp+B8h] [rbp-50h] BYREF
		  Vector3 v50; // [rsp+C8h] [rbp-40h] BYREF
		  Bounds aabb; // [rsp+D8h] [rbp-30h] BYREF
		  Vector3 v52; // [rsp+F0h] [rbp-18h] BYREF
		  Vector3 v53; // [rsp+100h] [rbp-8h] BYREF
		  Vector3 v54; // [rsp+110h] [rbp+8h] BYREF
		  Vector3 v55; // [rsp+120h] [rbp+18h] BYREF
		  Vector4 v56; // [rsp+130h] [rbp+28h] BYREF
		  Vector4 v57; // [rsp+140h] [rbp+38h] BYREF
		  Vector4 v58; // [rsp+150h] [rbp+48h] BYREF
		  Entity_1 entity; // [rsp+1D0h] [rbp+C8h] BYREF
		
		  entity = grassCluster;
		  memset(&aabb, 0, sizeof(aabb));
		  if ( IFix::WrappersManagerImpl::IsPatched(2651, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2651, 0LL);
		    if ( !Patch )
		      goto LABEL_12;
		    v41 = *(_QWORD *)&meshBounds->m_Extents.y;
		    *(_OWORD *)&v44.m_Center.x = *(_OWORD *)&meshBounds->m_Center.x;
		    *(_QWORD *)&v44.m_Extents.y = v41;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_982(Patch, (Object *)this, grassCluster, &v44, 0LL);
		  }
		  else
		  {
		    *(EntityManager *)&v43.m_Center.x = *UnityEngine::HyperGryph::ECS::EntityManager::GetRendererEntityManager(
		                                           (EntityManager *)&v43,
		                                           0LL);
		    if ( !UnityEngine::HyperGryph::ECS::EntityManager::TryGetWorldAABBFromRendererEntity(
		            (EntityManager *)&v43,
		            &entity,
		            &aabb,
		            0LL) )
		    {
		      HG::Rendering::HGRPLogger::LogError((String *)"Invalid Grass Cluster", 0LL);
		      return;
		    }
		    v7 = sub_18002C620(TypeInfo::HG::Rendering::Runtime::HGRuntimeGrassQuery::Node);
		    v10 = v7;
		    if ( !v7
		      || (v11 = *(_QWORD *)&aabb.m_Extents.y,
		          *(_OWORD *)(v7 + 16) = *(_OWORD *)&aabb.m_Center.x,
		          *(_QWORD *)(v7 + 32) = v11,
		          (m_grassClusterToNode = this->fields.m_grassClusterToNode) == 0LL) )
		    {
		LABEL_12:
		      sub_1800D8260(m_grassClusterToNode, v8);
		    }
		    System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,System::Object>::Add(
		      (Dictionary_2_UnityEngine_HyperGryph_ECS_Entity_System_Object_ *)m_grassClusterToNode,
		      entity,
		      (Object *)v7,
		      MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::HGRuntimeGrassQuery::Node>::Add);
		    HG::Rendering::Runtime::HGRuntimeGrassQuery::_AddNode(this, (HGRuntimeGrassQuery_Node *)v10, 0LL);
		    ComponentMaskLow = UnityEngine::HyperGryph::ECS::EntityManager::GetComponentMaskLow(
		                         (EntityManager *)&v43,
		                         &entity,
		                         0LL);
		    ComponentPtrLowBits = UnityEngine::HyperGryph::ECS::EntityManager::GetComponentPtrLowBits(
		                            (EntityManager *)&v43,
		                            &entity,
		                            ComponentMaskLow & 0x1E000000000LL,
		                            0LL);
		    v14 = *(_DWORD *)ComponentPtrLowBits;
		    v15 = ComponentPtrLowBits + 4;
		    *(_QWORD *)(v10 + 64) = il2cpp_array_new_specific_1(
		                              TypeInfo::UnityEngine::Bounds,
		                              *(unsigned int *)ComponentPtrLowBits);
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)(v10 + 64), v16, v17, v18, v42);
		    v19 = 0;
		    if ( v14 > 0 )
		    {
		      while ( 1 )
		      {
		        m_grassClusterToNode = (Dictionary_2_UnityEngine_HyperGryph_ECS_Entity_HG_Rendering_Runtime_HGRuntimeGrassQuery_Node_ *)&v15[96 * v19];
		        if ( !m_grassClusterToNode )
		          break;
		        v20 = (Matrix4x4 *)&v15[96 * v19];
		        *(Vector4 *)&v43.m_Center.x = *UnityEngine::Matrix4x4::GetColumn(&v56, v20, 3, 0LL);
		        v22 = UnityEngine::Vector4::op_Implicit(&v52, (Vector4 *)&v43, v21);
		        v23 = *(_QWORD *)&v22->x;
		        z = v22->z;
		        v25 = *UnityEngine::Matrix4x4::GetColumn(&v57, v20, 0, 0LL);
		        *(Vector4 *)&v43.m_Center.x = v25;
		        v25.x = UnityEngine::Vector4::get_magnitude((Vector4 *)&v43, v26);
		        v27 = (__m128)v25;
		        *(Vector4 *)&v43.m_Center.x = *UnityEngine::Matrix4x4::GetColumn(&v58, v20, 1, 0LL);
		        v25.x = UnityEngine::Vector4::get_magnitude((Vector4 *)&v43, v28);
		        v29 = (__m128)v25;
		        *(Vector4 *)&v43.m_Center.x = *UnityEngine::Matrix4x4::GetColumn((Vector4 *)&aabb, v20, 2, 0LL);
		        v25.x = UnityEngine::Vector4::get_magnitude((Vector4 *)&v43, v30);
		        v31 = meshBounds->m_Center.z;
		        *(_QWORD *)&v48.x = *(_QWORD *)&meshBounds->m_Center.x;
		        *(_QWORD *)&v45.x = _mm_unpacklo_ps(v27, v29).m128_u64[0];
		        v45.z = v25.x;
		        *(_QWORD *)&v47.x = v23;
		        v47.z = z;
		        v48.z = v31;
		        size = UnityEngine::Bounds::get_size(&v53, meshBounds, 0LL);
		        *(_QWORD *)&v25.x = *(_QWORD *)&size->x;
		        *(float *)&size = size->z;
		        *(_QWORD *)&v46.x = *(_QWORD *)&v25.x;
		        LODWORD(v46.z) = (_DWORD)size;
		        memset(&v44, 0, sizeof(v44));
		        v34 = UnityEngine::Vector3::Scale(&v54, &v46, &v45, v33);
		        v35 = *(_QWORD *)&v34->x;
		        *(float *)&v34 = v34->z;
		        *(_QWORD *)&v49.x = v35;
		        LODWORD(v49.z) = (_DWORD)v34;
		        v37 = UnityEngine::Vector3::op_Addition(&v55, &v48, &v47, v36);
		        v38 = *(_QWORD *)&v37->x;
		        *(float *)&v37 = v37->z;
		        *(_QWORD *)&v50.x = v38;
		        LODWORD(v50.z) = (_DWORD)v37;
		        UnityEngine::Bounds::Bounds(&v44, &v50, &v49, 0LL);
		        if ( !*(_QWORD *)(v10 + 64) )
		          break;
		        v39 = *(_QWORD *)(v10 + 64);
		        v43 = v44;
		        sub_18046BC2C(v39, v19++, &v43);
		        if ( v19 >= v14 )
		          return;
		      }
		      goto LABEL_12;
		    }
		  }
		}
		
		public void UnregisterGrassCluster(Entity grassCluster) {} // 0x0000000189B6CEA0-0x0000000189B6CF34
		// Void UnregisterGrassCluster(Entity)
		void HG::Rendering::Runtime::HGRuntimeGrassQuery::UnregisterGrassCluster(
		        HGRuntimeGrassQuery *this,
		        Entity_1 grassCluster,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  Dictionary_2_UnityEngine_HyperGryph_ECS_Entity_HG_Rendering_Runtime_HGRuntimeGrassQuery_Node_ *m_grassClusterToNode; // rcx
		  Object *Item; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2658, 0LL) )
		  {
		    m_grassClusterToNode = this->fields.m_grassClusterToNode;
		    if ( m_grassClusterToNode )
		    {
		      Item = System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,System::Object>::get_Item(
		               (Dictionary_2_UnityEngine_HyperGryph_ECS_Entity_System_Object_ *)m_grassClusterToNode,
		               grassCluster,
		               MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::HGRuntimeGrassQuery::Node>::get_Item);
		      HG::Rendering::Runtime::HGRuntimeGrassQuery::_RemoveNode(this, (HGRuntimeGrassQuery_Node *)Item, 0LL);
		      m_grassClusterToNode = this->fields.m_grassClusterToNode;
		      if ( m_grassClusterToNode )
		      {
		        System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,System::Object>::Remove(
		          (Dictionary_2_UnityEngine_HyperGryph_ECS_Entity_System_Object_ *)m_grassClusterToNode,
		          grassCluster,
		          MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::HGRuntimeGrassQuery::Node>::Remove);
		        return;
		      }
		    }
		LABEL_6:
		    sub_1800D8260(m_grassClusterToNode, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2658, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_692(Patch, (Object *)this, grassCluster, 0LL);
		}
		
		public bool InGrassBoundingBox(Vector3 worldPos, out Bounds overlapBounds) {
			overlapBounds = default;
			return default;
		} // 0x0000000189B6CA74-0x0000000189B6CB14
		// Boolean InGrassBoundingBox(Vector3, Bounds ByRef)
		bool HG::Rendering::Runtime::HGRuntimeGrassQuery::InGrassBoundingBox(
		        HGRuntimeGrassQuery *this,
		        Vector3 *worldPos,
		        Bounds *overlapBounds,
		        MethodInfo *method)
		{
		  __int64 v8; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  float z; // eax
		  Vector3 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2661, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2661, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v8);
		    z = worldPos->z;
		    *(_QWORD *)&v11.x = *(_QWORD *)&worldPos->x;
		    v11.z = z;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_984(Patch, (Object *)this, &v11, overlapBounds, 0LL);
		  }
		  else
		  {
		    *(_OWORD *)&overlapBounds->m_Center.x = 0LL;
		    *(_QWORD *)&overlapBounds->m_Extents.y = 0LL;
		    return HG::Rendering::Runtime::HGRuntimeGrassQuery::_InGrassBoundingBox(
		             this,
		             this->fields.m_root,
		             worldPos,
		             overlapBounds,
		             0LL);
		  }
		}
		
		private bool _InGrassBoundingBox(Node node, ref Vector3 worldPos, ref Bounds overlapBounds) => default; // 0x0000000189B6D1C8-0x0000000189B6D34C
		// Boolean _InGrassBoundingBox(HGRuntimeGrassQuery+Node, Vector3 ByRef, Bounds ByRef)
		bool HG::Rendering::Runtime::HGRuntimeGrassQuery::_InGrassBoundingBox(
		        HGRuntimeGrassQuery *this,
		        HGRuntimeGrassQuery_Node *node,
		        Vector3 *worldPos,
		        Bounds *overlapBounds,
		        MethodInfo *method)
		{
		  float z; // eax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  Bounds__Array *grassInstanceBounds; // r14
		  int32_t v14; // ebx
		  float v15; // eax
		  __int64 v16; // xmm1_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 v18; // [rsp+30h] [rbp-40h] BYREF
		  Bounds v19; // [rsp+40h] [rbp-30h] BYREF
		  __int128 v20; // [rsp+58h] [rbp-18h] BYREF
		  __int64 v21; // [rsp+68h] [rbp-8h]
		
		  memset(&v19, 0, sizeof(v19));
		  if ( IFix::WrappersManagerImpl::IsPatched(2662, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2662, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_983(
		               Patch,
		               (Object *)this,
		               (Object *)node,
		               worldPos,
		               overlapBounds,
		               0LL);
		    goto LABEL_15;
		  }
		  if ( !node )
		    return 0;
		  z = worldPos->z;
		  *(_QWORD *)&v18.x = *(_QWORD *)&worldPos->x;
		  v18.z = z;
		  if ( !UnityEngine::Bounds::Contains(&node->fields.bounds, &v18, 0LL) )
		    return 0;
		  if ( HG::Rendering::Runtime::HGRuntimeGrassQuery::Node::IsLeaf(node, 0LL) )
		  {
		    grassInstanceBounds = node->fields.grassInstanceBounds;
		    v14 = 0;
		    if ( grassInstanceBounds )
		    {
		      while ( v14 < grassInstanceBounds->max_length.size )
		      {
		        sub_1803C07D0(grassInstanceBounds, &v20, v14);
		        v15 = worldPos->z;
		        *(_OWORD *)&v19.m_Center.x = v20;
		        v18.z = v15;
		        *(_QWORD *)&v18.x = *(_QWORD *)&worldPos->x;
		        *(_QWORD *)&v19.m_Extents.y = v21;
		        if ( UnityEngine::Bounds::Contains(&v19, &v18, 0LL) )
		        {
		          v16 = *(_QWORD *)&v19.m_Extents.y;
		          *(_OWORD *)&overlapBounds->m_Center.x = *(_OWORD *)&v19.m_Center.x;
		          *(_QWORD *)&overlapBounds->m_Extents.y = v16;
		          return 1;
		        }
		        ++v14;
		      }
		      return 0;
		    }
		LABEL_15:
		    sub_1800D8260(v11, v10);
		  }
		  return HG::Rendering::Runtime::HGRuntimeGrassQuery::_InGrassBoundingBox(
		           this,
		           node->fields.left,
		           worldPos,
		           overlapBounds,
		           0LL)
		      || HG::Rendering::Runtime::HGRuntimeGrassQuery::_InGrassBoundingBox(
		           this,
		           node->fields.right,
		           worldPos,
		           overlapBounds,
		           0LL);
		}
		
		private void _AddNode(Node node) {} // 0x0000000189B6CF34-0x0000000189B6D0FC
		// Void _AddNode(HGRuntimeGrassQuery+Node)
		void HG::Rendering::Runtime::HGRuntimeGrassQuery::_AddNode(
		        HGRuntimeGrassQuery *this,
		        HGRuntimeGrassQuery_Node *node,
		        MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v5; // rdx
		  HGRuntimeGrassQuery_Node *left; // rcx
		  HGRuntimeGrassQuery_Node *v7; // r8
		  Int32__Array **v8; // r9
		  HGRuntimeGrassQuery_Node *m_root; // rbx
		  __int64 v10; // xmm1_8
		  float v11; // xmm0_4
		  __int64 v12; // xmm2_8
		  HGRuntimeGrassQuery_Node *parent; // r14
		  HGRuntimeGrassQuery_Node *v14; // rax
		  HGRuntimeGrassQuery_Node *v15; // rbp
		  HGRuntimeGrassQuery_Node *v16; // r8
		  Int32__Array **v17; // r9
		  HGRuntimeGrassQuery_Node *v18; // rdx
		  HGRuntimeGrassQuery_Node *v19; // r8
		  Int32__Array **v20; // r9
		  HGRuntimeGrassQuery_Node *v21; // r8
		  Int32__Array **v22; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v24; // [rsp+20h] [rbp-68h]
		  MethodInfo *v25; // [rsp+20h] [rbp-68h]
		  MethodInfo *v26; // [rsp+20h] [rbp-68h]
		  Bounds v27; // [rsp+30h] [rbp-58h] BYREF
		  Bounds v28; // [rsp+50h] [rbp-38h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2652, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2652, 0LL);
		    if ( !Patch )
		      goto LABEL_21;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)node,
		      0LL);
		  }
		  else
		  {
		    if ( this->fields.m_root )
		    {
		      m_root = this->fields.m_root;
		      while ( 1 )
		      {
		        if ( !m_root )
		          goto LABEL_21;
		        if ( HG::Rendering::Runtime::HGRuntimeGrassQuery::Node::IsLeaf(m_root, 0LL) )
		          break;
		        if ( !node )
		          goto LABEL_21;
		        left = m_root->fields.left;
		        if ( !left )
		          goto LABEL_21;
		        v10 = *(_QWORD *)&node->fields.bounds.m_Extents.y;
		        *(_OWORD *)&v27.m_Center.x = *(_OWORD *)&node->fields.bounds.m_Center.x;
		        *(_QWORD *)&v27.m_Extents.y = v10;
		        v11 = HG::Rendering::Runtime::HGRuntimeGrassQuery::Node::ComputeMergeCost(left, &v27, 0LL);
		        left = m_root->fields.right;
		        if ( !left )
		          goto LABEL_21;
		        v12 = *(_QWORD *)&node->fields.bounds.m_Extents.y;
		        *(_OWORD *)&v28.m_Center.x = *(_OWORD *)&node->fields.bounds.m_Center.x;
		        *(_QWORD *)&v28.m_Extents.y = v12;
		        if ( HG::Rendering::Runtime::HGRuntimeGrassQuery::Node::ComputeMergeCost(left, &v28, 0LL) > v11 )
		          m_root = m_root->fields.left;
		        else
		          m_root = m_root->fields.right;
		      }
		      parent = m_root->fields.parent;
		      v14 = (HGRuntimeGrassQuery_Node *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::HGRuntimeGrassQuery::Node);
		      v15 = v14;
		      if ( v14 )
		      {
		        HG::Rendering::Runtime::HGRuntimeGrassQuery::Node::Node(v14, parent, m_root, node, 0LL);
		        if ( m_root->fields.parent )
		        {
		          left = m_root->fields.parent;
		          if ( !left )
		            goto LABEL_21;
		          HG::Rendering::Runtime::HGRuntimeGrassQuery::Node::ReplaceChild(left, m_root, v15, 0LL);
		        }
		        else
		        {
		          this->fields.m_root = v15;
		          sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v5, v16, v17, v25);
		        }
		        m_root->fields.parent = v15;
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&m_root->fields.parent, v18, v19, v20, v25);
		        if ( node )
		        {
		          node->fields.parent = v15;
		          sub_18002D1B0((HGRuntimeGrassQuery_Node *)&node->fields.parent, v5, v21, v22, v26);
		          HG::Rendering::Runtime::HGRuntimeGrassQuery::_BroadcastBounds(this, v15->fields.parent, 0LL);
		          return;
		        }
		      }
		LABEL_21:
		      sub_1800D8260(left, v5);
		    }
		    this->fields.m_root = node;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v5, v7, v8, v24);
		  }
		}
		
		private void _RemoveNode(Node node) {} // 0x0000000189B6D34C-0x0000000189B6D450
		// Void _RemoveNode(HGRuntimeGrassQuery+Node)
		void HG::Rendering::Runtime::HGRuntimeGrassQuery::_RemoveNode(
		        HGRuntimeGrassQuery *this,
		        HGRuntimeGrassQuery_Node *node,
		        MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v5; // rdx
		  HGRuntimeGrassQuery_Node *parent; // rcx
		  HGRuntimeGrassQuery_Node *v7; // r8
		  Int32__Array **v8; // r9
		  HGRuntimeGrassQuery_Node *Sibling; // rax
		  HGRuntimeGrassQuery_Node *v10; // r8
		  Int32__Array **v11; // r9
		  HGRuntimeGrassQuery_Node *v12; // rdi
		  HGRuntimeGrassQuery_Node *v13; // r8
		  HGRuntimeGrassQuery_Node *v14; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v16; // [rsp+20h] [rbp-8h]
		  MethodInfo *v17; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2659, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2659, 0LL);
		    if ( !Patch )
		      goto LABEL_14;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)node,
		      0LL);
		  }
		  else
		  {
		    if ( this->fields.m_root != node )
		    {
		      if ( node )
		      {
		        Sibling = HG::Rendering::Runtime::HGRuntimeGrassQuery::Node::FindSibling(node, 0LL);
		        v12 = Sibling;
		        if ( Sibling )
		        {
		          parent = Sibling->fields.parent;
		          if ( parent )
		          {
		            Sibling->fields.parent = parent->fields.parent;
		            sub_18002D1B0((HGRuntimeGrassQuery_Node *)&Sibling->fields.parent, v5, v10, v11, v16);
		            v14 = node->fields.parent;
		            if ( v14 )
		            {
		              if ( !v14->fields.parent )
		              {
		                this->fields.m_root = v12;
		                sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v5, v13, (Int32__Array **)v14, v17);
		LABEL_11:
		                HG::Rendering::Runtime::HGRuntimeGrassQuery::_BroadcastBounds(this, v12->fields.parent, 0LL);
		                return;
		              }
		              parent = v14->fields.parent;
		              if ( parent )
		              {
		                HG::Rendering::Runtime::HGRuntimeGrassQuery::Node::ReplaceChild(parent, node->fields.parent, v12, 0LL);
		                goto LABEL_11;
		              }
		            }
		          }
		        }
		      }
		LABEL_14:
		      sub_1800D8260(parent, v5);
		    }
		    this->fields.m_root = 0LL;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v5, v7, v8, v16);
		  }
		}
		
		private void _BroadcastBounds(Node node) {} // 0x0000000189B6D0FC-0x0000000189B6D1C8
		// Void _BroadcastBounds(HGRuntimeGrassQuery+Node)
		void HG::Rendering::Runtime::HGRuntimeGrassQuery::_BroadcastBounds(
		        HGRuntimeGrassQuery *this,
		        HGRuntimeGrassQuery_Node *node,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  HGRuntimeGrassQuery_Node *left; // rax
		  __int64 v8; // xmm1_8
		  HGRuntimeGrassQuery_Node *right; // rax
		  __int64 v10; // xmm1_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Bounds v12; // [rsp+20h] [rbp-48h] BYREF
		  Bounds v13; // [rsp+40h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2657, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2657, 0LL);
		    if ( !Patch )
		LABEL_9:
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)node,
		      0LL);
		  }
		  else
		  {
		    while ( node )
		    {
		      *(_OWORD *)&node->fields.bounds.m_Center.x = 0LL;
		      *(_QWORD *)&node->fields.bounds.m_Extents.y = 0LL;
		      left = node->fields.left;
		      if ( !left )
		        goto LABEL_9;
		      v8 = *(_QWORD *)&left->fields.bounds.m_Extents.y;
		      *(_OWORD *)&v12.m_Center.x = *(_OWORD *)&left->fields.bounds.m_Center.x;
		      *(_QWORD *)&v12.m_Extents.y = v8;
		      UnityEngine::Bounds::Encapsulate(&node->fields.bounds, &v12, 0LL);
		      right = node->fields.right;
		      if ( !right )
		        goto LABEL_9;
		      v10 = *(_QWORD *)&right->fields.bounds.m_Extents.y;
		      *(_OWORD *)&v13.m_Center.x = *(_OWORD *)&right->fields.bounds.m_Center.x;
		      *(_QWORD *)&v13.m_Extents.y = v10;
		      UnityEngine::Bounds::Encapsulate(&node->fields.bounds, &v13, 0LL);
		      node = node->fields.parent;
		    }
		  }
		}
		
	}
}
