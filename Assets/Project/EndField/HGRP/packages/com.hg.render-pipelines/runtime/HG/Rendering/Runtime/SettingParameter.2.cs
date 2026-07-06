using System;
using System.Runtime.CompilerServices;

namespace HG.Rendering.Runtime
{
	public class SettingParameter<T> : HGRenderPipelineSettingHub.SettingParameterBase
	{
		// (get) Token: 0x0600147D RID: 5245 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x0600147E RID: 5246 RVA: 0x000025D0 File Offset: 0x000007D0
		public T paramValue
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// (get) Token: 0x0600147F RID: 5247 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06001480 RID: 5248 RVA: 0x000025D0 File Offset: 0x000007D0
		public T defaultValue
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private SettingParameter(T defaultVal, string featureName, string paramName)
		{
		}

		internal static SettingParameter<T> Create(T defaultVal, string featureName, string paramName)
		{
			return null;
		}

		public void Override(T val)
		{
		}

		public bool IsOverrided()
		{
			return default(bool);
		}

		public bool IsFromCode()
		{
			return default(bool);
		}

		private bool ChangeParamValue(string valueString, bool markOverrided)
		{
			return default(bool);
		}

		protected override void RefreshInternal()
		{
		}

		internal override bool OverrideWithString(string valueString)
		{
			return default(bool);
		}

		public static implicit operator T(SettingParameter<T> p)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
