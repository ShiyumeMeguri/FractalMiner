using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public class ScalableSetting<T> : ISerializationCallbackReceiver // TypeDefIndex: 38554
	{
		// Fields
		[SerializeField]
		private T[] m_Values;
		[SerializeField]
		private ScalableSettingSchemaId m_SchemaId;
	
		// Properties
		public ScalableSettingSchemaId schemaId { get => default; set {} }
		public T this[int index] { get => default; }
	
		// Constructors
		public ScalableSetting() {} // Dummy constructor
		public ScalableSetting(T[] values, ScalableSettingSchemaId schemaId) {}
	
		// Methods
		public bool TryGet(int index, out ref T value) {
			value = default;
			return default;
		}
		void ISerializationCallbackReceiver.OnAfterDeserialize() {}
		void ISerializationCallbackReceiver.OnBeforeSerialize() {}
	}
}
