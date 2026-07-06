using System;

namespace HG.Rendering.Runtime
{
	public interface IVersionable<TVersion> where TVersion : struct, IConvertible
	{
		// (get) Token: 0x060003AE RID: 942
		// (set) Token: 0x060003AF RID: 943
		TVersion version
		{
			get;
			set;
		}
	}
}
