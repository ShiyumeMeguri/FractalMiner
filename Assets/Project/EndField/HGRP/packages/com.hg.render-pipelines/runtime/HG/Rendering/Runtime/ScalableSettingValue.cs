using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[Serializable]
	public class ScalableSettingValue<T>
	{
		// (get) Token: 0x06001364 RID: 4964 RVA: 0x00002608 File Offset: 0x00000808
		// (set) Token: 0x06001365 RID: 4965 RVA: 0x000025D0 File Offset: 0x000007D0
		public int level
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// (get) Token: 0x06001366 RID: 4966 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x06001367 RID: 4967 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool useOverride
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		// (get) Token: 0x06001368 RID: 4968 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06001369 RID: 4969 RVA: 0x000025D0 File Offset: 0x000007D0
		public T @override
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ScalableSettingValue()
		{
		}

		public T Value(ScalableSetting<T> source)
		{
			return null;
		}

		public void CopyTo(ScalableSettingValue<T> target)
		{
		}

		[SerializeField]
		private T m_Override;

		[SerializeField]
		private bool m_UseOverride;

		[SerializeField]
		private int m_Level;
	}
}
