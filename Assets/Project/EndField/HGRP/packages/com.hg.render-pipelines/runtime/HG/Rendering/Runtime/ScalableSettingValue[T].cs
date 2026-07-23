using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public class ScalableSettingValue<T> // TypeDefIndex: 38561
	{
		// Fields
		[SerializeField]
		private T m_Override;
		[SerializeField]
		private bool m_UseOverride;
		[SerializeField]
		private int m_Level;
	
		// Properties
		public int level { get => default; set {} }
		public bool useOverride { get => default; set {} }
		public T override { get => default; set {} }
	
		// Constructors
		public ScalableSettingValue() {}
	
		// Methods
		public T Value(ScalableSetting<T> source) => default;
		public void CopyTo(ScalableSettingValue<T> target) {}
	}
}
