using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class BidirectionalDictionary<TKey, TValue> // TypeDefIndex: 37985
	{
		// Fields
		private readonly Dictionary<TKey, TValue> m_forwardDictionary;
		private readonly Dictionary<TValue, TKey> m_reverseDictionary;
	
		// Properties
		public int Count { get => default; }
	
		// Constructors
		public BidirectionalDictionary() {}
	
		// Methods
		public void Add(TKey key, TValue value) {}
		public bool TryAdd(TKey key, TValue value) => default;
		public void Remove(TKey key, TValue value) {}
		public void RemoveByKey(TKey key) {}
		public void RemoveByValue(TValue value) {}
		public bool TryRemove(TKey key, TValue value) => default;
		public bool TryRemoveByKey(TKey key) => default;
		public bool TryRemoveByValue(TValue value) => default;
		public bool ContainsKey(TKey key) => default;
		public bool ContainsValue(TValue value) => default;
		public TValue GetValueByKey(TKey key) => default;
		public TKey GetKeyByValue(TValue value) => default;
		public bool TryGetValueByKey(TKey key, out ref TValue value) {
			value = default;
			return default;
		}
		public bool TryGetKeyByValue(TValue value, out ref TKey key) {
			key = default;
			return default;
		}
		public void Clear() {}
	}
}
