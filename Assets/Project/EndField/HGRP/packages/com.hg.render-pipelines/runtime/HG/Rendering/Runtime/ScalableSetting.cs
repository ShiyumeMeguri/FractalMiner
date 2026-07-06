using System;
using System.Reflection;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[DefaultMember("Item")]
	[Serializable]
	public class ScalableSetting<T> : ISerializationCallbackReceiver
	{
		// (get) Token: 0x0600134B RID: 4939 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x0600134C RID: 4940 RVA: 0x000025D0 File Offset: 0x000007D0
		public ScalableSettingSchemaId schemaId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// (get) Token: 0x0600134D RID: 4941 RVA: 0x000025D2 File Offset: 0x000007D2
		public T Item
		{
			get
			{
				return null;
			}
		}

		public ScalableSetting(T[] values, ScalableSettingSchemaId schemaId)
		{
		}

		public bool TryGet(int index, out T value)
		{
			return default(bool);
		}

		private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		[SerializeField]
		private T[] m_Values;

		[SerializeField]
		private ScalableSettingSchemaId m_SchemaId;
	}
}
