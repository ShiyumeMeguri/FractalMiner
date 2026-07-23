using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class SettingParameter<T> : HGRenderPipelineSettingHub.SettingParameterBase // TypeDefIndex: 38595
	{
		// Properties
		public T paramValue { get; set; }
		public T defaultValue { get; set; }
	
		// Constructors
		public SettingParameter() {} // Dummy constructor
		private SettingParameter(T defaultVal, string featureName, string paramName) {}
	
		// Methods
		internal static SettingParameter<T> Create(T defaultVal, string featureName, string paramName) => default;
		public void Override(T val) {}
		public bool IsOverrided() => default;
		public bool IsFromCode() => default;
		private bool ChangeParamValue(string valueString, bool markOverrided) => default;
		protected override void RefreshInternal() {}
		internal override bool OverrideWithString(string valueString) => default;
		public static implicit operator T(SettingParameter<T> p) => default;
		public override string ToString() => default;
	}
}
