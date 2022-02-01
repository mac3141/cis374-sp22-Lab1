using System.Collections.Generic;
using DSA.DataStructures.Trees;

namespace Lab1
{
    class BinarySearchTreeKeyValueMap<TKey, TValue>: IKeyValueMap<TKey, TValue>
    {
        private BinarySearchTreeMap<TKey, TValue> binarySearchTreeMap = new BinarySearchTreeMap<TKey, TValue>();

        public BinarySearchTreeKeyValueMap()
        {
        }

        public int Height => binarySearchTreeMap.Height;

        public int Count => binarySearchTreeMap.Count;

        public void Add(TKey key, TValue value)
        {
            binarySearchTreeMap.Add(key, value);
        }

        public KeyValuePair<TKey, TValue> Get(TKey key)
        {
            var value = binarySearchTreeMap[key];
            return new KeyValuePair<TKey, TValue>(key, value);
        }

        public bool Remove(TKey key)
        {
            if( binarySearchTreeMap.ContainsKey(key))
            {
                binarySearchTreeMap.Remove(key);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}