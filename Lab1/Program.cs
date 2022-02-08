using System;
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
                    intKeyValuePairs.Add(new KeyValuePair<int, int>(i, i + 2));
                }

                // Hashtable
                /*var dictionaryKeyValueMap = new DictionaryKeyValueMap<int, int>();

                Console.WriteLine("DictionaryKeyValueMap");
                Console.WriteLine("Ordered");
                CreateKeyValueMap<int, int>(dictionaryKeyValueMap, intKeyValuePairs);

                Console.WriteLine("Unordered");
                intKeyValuePairs.Shuffle();
                dictionaryKeyValueMap = new DictionaryKeyValueMap<int, int>();

                CreateKeyValueMap<int, int>(dictionaryKeyValueMap, intKeyValuePairs);*/

                // ---------------------------------------------------------------------

                // BST
                /*var bstKeyValueMap = new BinarySearchTreeKeyValueMap<int, int>();

                Console.WriteLine("BSTKeyValueMap");
                Console.WriteLine("Ordered");
                CreateKeyValueMap<int, int>(bstKeyValueMap, intKeyValuePairs);

                Console.WriteLine("Unordered");
                intKeyValuePairs.Shuffle();
                bstKeyValueMap = new BinarySearchTreeKeyValueMap<int, int>();

                CreateKeyValueMap<int, int>(bstKeyValueMap, intKeyValuePairs);*/

                // ---------------------------------------------------------------------

                // AVL
                /*var avlKeyValueMap = new AVLTreeKeyValueMap<int, int>();

                Console.WriteLine("AVLKeyValueMap");
                Console.WriteLine("Ordered");
                CreateKeyValueMap<int, int>(avlKeyValueMap, intKeyValuePairs);

                Console.WriteLine("Unordered");
                intKeyValuePairs.Shuffle();
                avlKeyValueMap = new AVLTreeKeyValueMap<int, int>();

                CreateKeyValueMap<int, int>(avlKeyValueMap, intKeyValuePairs);*/

                // ---------------------------------------------------------------------

                // RedBlack
                /*var redBlackKeyValueMap = new RedBlackTreeKeyValueMap<int, int>();

                Console.WriteLine("RedBlackKeyValueMap");
                Console.WriteLine("Ordered");
                CreateKeyValueMap<int, int>(redBlackKeyValueMap, intKeyValuePairs);

                Console.WriteLine("Unordered");
                intKeyValuePairs.Shuffle();
                redBlackKeyValueMap = new RedBlackTreeKeyValueMap<int, int>();

                CreateKeyValueMap<int, int>(redBlackKeyValueMap, intKeyValuePairs);*/
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
