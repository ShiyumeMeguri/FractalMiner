using System;

namespace HG
{
	[Serializable]
	public class BatchGroupSetting
	{
		private BatchGroupSetting()
		{
			// // BatchGroupSetting()
			// void HG::BatchGroupSetting::BatchGroupSetting(BatchGroupSetting *this, MethodInfo *method)
			// {
			//   this.fields.lightmap2UVpadding = 1;
			//   this.fields.atemptResolution = 256;
			// }
			// 
		}

		public static BatchGroupSetting CreateDefault()
		{
			// // BatchGroupSetting CreateDefault()
			// BatchGroupSetting *HG::BatchGroupSetting::CreateDefault(MethodInfo *method)
			// {
			//   BatchGroupSetting *result; // rax
			//   __int64 v2; // rdx
			//   __int64 v3; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919301 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::BatchGroupSetting);
			//     byte_18D919301 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(6, 0LL) )
			//   {
			//     result = (BatchGroupSetting *)sub_180004920(TypeInfo::HG::BatchGroupSetting);
			//     if ( result )
			//     {
			//       result.fields.lightmap2UVpadding = 1;
			//       result.fields.atemptResolution = 256;
			//       result.fields.rebuildCollider = 1;
			//       return result;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v3, v2);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(6, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_6(Patch, 0LL);
			// }
			// 
			return null;
		}

		public int lightmap2UVpadding;

		public int atemptResolution;

		public bool rebuildCollider;
	}
}
