using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG
{
	[Serializable]
	public class BatchGroupSetting // TypeDefIndex: 37396
	{
		// Fields
		public int lightmap2UVpadding; // 0x10
		public int atemptResolution; // 0x14
		public bool rebuildCollider; // 0x18
	
		// Constructors
		private BatchGroupSetting() {} // 0x0000000184DA1120-0x0000000184DA1130
		// BatchGroupSetting()
		void HG::BatchGroupSetting::BatchGroupSetting(BatchGroupSetting *this, MethodInfo *method)
		{
		  this->fields.lightmap2UVpadding = 1;
		  this->fields.atemptResolution = 256;
		}
		
	
		// Methods
		public static BatchGroupSetting CreateDefault() => default; // 0x0000000189B2563C-0x0000000189B25698
		// BatchGroupSetting CreateDefault()
		BatchGroupSetting *HG::BatchGroupSetting::CreateDefault(MethodInfo *method)
		{
		  BatchGroupSetting *result; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(0, 0LL) )
		  {
		    result = (BatchGroupSetting *)sub_18002C620(TypeInfo::HG::BatchGroupSetting);
		    if ( result )
		    {
		      result->fields.lightmap2UVpadding = 1;
		      result->fields.atemptResolution = 256;
		      result->fields.rebuildCollider = 1;
		      return result;
		    }
		LABEL_5:
		    sub_1800D8260(v3, v2);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(0, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(Patch, 0LL);
		}
		
	}
}
