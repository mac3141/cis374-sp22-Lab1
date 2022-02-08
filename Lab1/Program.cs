﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using DSA.DataStructures.Trees;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int MAX = 100000;

            for (int c = 0; c < 10; c++)
            {
                var intKeyValuePairs = new List<KeyValuePair<int, int>>();

                for (int i = 0; i < MAX; i++)
                {
                    intKeyValuePairs.Add(new KeyValuePair<int, int>(i, i + 42));
                }

                //var dictionaryKeyValueMap = new DictionaryKeyValueMap<int, int>();
                var bstKeyValueMap = new BinarySearchTreeKeyValueMap<int, int>();
                //var avlKeyValueMap = new AVLTreeKeyValueMap<int, int>();
                //var redBlackKeyValueMap = new RedBlackTreeKeyValueMap<int, int>();



                //Console.WriteLine("DictionaryKeyValueMap");
                Console.WriteLine("BSTKeyValueMap");
                Console.WriteLine("Ordered");
                CreateKeyValueMap<int, int>(bstKeyValueMap, intKeyValuePairs);

                Console.WriteLine("Unordered");
                intKeyValuePairs.Shuffle();
                bstKeyValueMap = new BinarySearchTreeKeyValueMap<int, int>();

                CreateKeyValueMap<int, int>(bstKeyValueMap, intKeyValuePairs);
            }

        }


        public static void CreateKeyValueMap<TKey, TValue>(
                IKeyValueMap<TKey, TValue> keyValueMap,
                List<KeyValuePair<TKey, TValue>> keyValuePairs)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            foreach (var kvp in keyValuePairs)
            {
                keyValueMap.Add(kvp.Key, kvp.Value);
            }
            stopwatch.Stop();

            Console.WriteLine(stopwatch.Elapsed.TotalSeconds);
            Console.WriteLine(keyValueMap.Height);

        }


        public static void QueryKeyValueMap<TKey, TValue>(
                IKeyValueMap<TKey, TValue> keyValueMap,
                List<KeyValuePair<TKey, TValue>> keyValuePairs)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            foreach (var kvp in keyValuePairs)
            {
                var value = keyValueMap.Get(kvp.Key);
            }
            stopwatch.Stop();

            Console.WriteLine(stopwatch.Elapsed.TotalSeconds);
            Console.WriteLine(keyValueMap.Height);
        }

        public static void RemoveKeyValueMap<TKey, TValue>(
                IKeyValueMap<TKey, TValue> keyValueMap,
                List<KeyValuePair<TKey, TValue>> keyValuePairs)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            foreach (var kvp in keyValuePairs)
            {
                var removed = keyValueMap.Remove(kvp.Key);
            }
            stopwatch.Stop();

            Console.WriteLine(stopwatch.Elapsed.TotalSeconds);
            Console.WriteLine(keyValueMap.Height);
        }
    }
}
