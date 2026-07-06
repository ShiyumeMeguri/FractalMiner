using System;
using System.Collections.Generic;

namespace HG.Rendering.Runtime
{
	public class BidirectionalDictionary<TKey, TValue>
	{
		// (get) Token: 0x06000BF5 RID: 3061 RVA: 0x00002608 File Offset: 0x00000808
		public int Count
		{
			get
			{
				return 0;
			}
		}

		public BidirectionalDictionary()
		{
		}

		public void Add(TKey key, TValue value)
		{
		}

		public bool TryAdd(TKey key, TValue value)
		{
			return default(bool);
		}

		public void Remove(TKey key, TValue value)
		{
		}

		public void RemoveByKey(TKey key)
		{
		}

		public void RemoveByValue(TValue value)
		{
		}

		public bool TryRemove(TKey key, TValue value)
		{
			return default(bool);
		}

		public bool TryRemoveByKey(TKey key)
		{
			return default(bool);
		}

		public bool TryRemoveByValue(TValue value)
		{
			return default(bool);
		}

		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		public bool ContainsValue(TValue value)
		{
			return default(bool);
		}

		public TValue GetValueByKey(TKey key)
		{
			return null;
		}

		public TKey GetKeyByValue(TValue value)
		{
			return null;
		}

		public bool TryGetValueByKey(TKey key, out TValue value)
		{
			return default(bool);
		}

		public bool TryGetKeyByValue(TValue value, out TKey key)
		{
			return default(bool);
		}

		public void Clear()
		{
		}

		private readonly Dictionary<TKey, TValue> m_forwardDictionary;

		private readonly Dictionary<TValue, TKey> m_reverseDictionary;
	}
}
