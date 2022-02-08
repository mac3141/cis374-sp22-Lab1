﻿using System.Collections.Generic;
using DSA.DataStructures.Trees;

namespace Lab1
{
    class AVLTreeKeyValueMap<TKey, TValue> : IKeyValueMap<TKey, TValue>
    {
        private AVLTreeMap<TKey, TValue> avlTreeMap = new AVLTreeMap<TKey, TValue>();

        public AVLTreeKeyValueMap()
        {
        }

        public int Height => avlTreeMap.Height;

        public int Count => avlTreeMap.Count;

        public void Add(TKey key, TValue value)
        {
            avlTreeMap.Add(key, value);
        }

        public KeyValuePair<TKey, TValue> Get(TKey key)
        {
            var value = avlTreeMap[key];
            return new KeyValuePair<TKey, TValue>(key, value);
        }

        public bool Remove(TKey key)
        {
            if (avlTreeMap.ContainsKey(key))
            {
                avlTreeMap.Remove(key);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}