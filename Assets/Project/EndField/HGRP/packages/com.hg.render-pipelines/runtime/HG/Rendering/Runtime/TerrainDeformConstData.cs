using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal struct TerrainDeformConstData // TypeDefIndex: 38648
	{
		// Fields
		public Vector4 param0; // 0x00
		public Vector4 param1; // 0x10
		public Vector4 param2; // 0x20
	
		// Methods
		public void SetConstData(HGTerrainDeformManager deformManager) {} // 0x0000000189C23BCC-0x0000000189C23D00
		// Void SetConstData(HGTerrainDeformManager)
		void HG::Rendering::Runtime::TerrainDeformConstData::SetConstData(
		        TerrainDeformConstData *this,
		        HGTerrainDeformManager *deformManager,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  float v7; // xmm3_4
		  Vector4 v8; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 v10; // [rsp+20h] [rbp-18h]
		  Vector4 v11; // [rsp+20h] [rbp-18h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3418, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3418, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1233(Patch, this, (Object *)deformManager, 0LL);
		      return;
		    }
		LABEL_7:
		    sub_1800D8260(v6, v5);
		  }
		  if ( !deformManager )
		    goto LABEL_7;
		  *(_QWORD *)&v10.x = 0x3A80000044000000LL;
		  v10.z = (float)(deformManager->fields.curCenter.x - deformManager->fields.prevCenter.x) * 0.015625;
		  v10.w = (float)(deformManager->fields.curCenter.z - deformManager->fields.prevCenter.z) * 0.015625;
		  v7 = 0.0;
		  v8 = v10;
		  v10.x = 64.0;
		  this->param0 = v8;
		  v10.w = deformManager->fields.curCenter.z;
		  v10.z = deformManager->fields.curCenter.x;
		  v10.y = deformManager->fields.curCenter.y - 32.0;
		  this->param1 = v10;
		  if ( deformManager->fields.deformConfig.latency > 0.001 )
		    v7 = sub_180335960();
		  v11.y = deformManager->fields.deltaTime;
		  *(_QWORD *)&v11.z = LODWORD(v7);
		  v11.x = 0.125;
		  this->param2 = v11;
		}
		
	}
}
