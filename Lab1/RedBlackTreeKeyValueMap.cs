using System.Collections.Generic;
using DSA.DataStructures.Trees;

namespace Lab1
{
    class RedBlackTreeKeyValueMap<TKey, TValue> : IKeyValueMap<TKey, TValue>
    {
        private RedBlackTreeMap<TKey, TValue> redBlackTreeMap = new RedBlackTreeMap<TKey, TValue>();

        public RedBlackTreeKeyValueMap()
        {
        }

        public int Height => redBlackTreeMap.Height;

        public int Count => redBlackTreeMap.Count;

        public void Add(TKey key, TValue value)
        {
            redBlackTreeMap.Add(key, value);
        }

        public KeyValuePair<TKey, TValue> Get(TKey key)
        {
            var value = redBlackTreeMap[key];
            return new KeyValuePair<TKey, TValue>(key, value);
        }

        public bool Remove(TKey key)
        {
            if (redBlackTreeMap.ContainsKey(key))
            {
                redBlackTreeMap.Remove(key);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}