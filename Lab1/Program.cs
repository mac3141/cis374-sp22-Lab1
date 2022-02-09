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
            int MAX = 10000000;

            #region insertion
            /*//Console.WriteLine("DictionaryKeyValueMap\n");
            //Console.WriteLine("BSTKeyValueMap\n");
            //Console.WriteLine("AVLKeyValueMap\n");
            //Console.WriteLine("RedBlackKeyValueMap\n");
            Console.WriteLine("Ordered");

            for (int c = 0; c < 10; c++)
            {
                var intKeyValuePairs = new List<KeyValuePair<int, int>>();

                for (int i = 0; i < MAX; i++)
                {
                    intKeyValuePairs.Add(new KeyValuePair<int, int>(i, i + 2));
                }

                // Hashtable
                *//*var dictionaryKeyValueMap = new DictionaryKeyValueMap<int, int>();

                CreateKeyValueMap<int, int>(dictionaryKeyValueMap, intKeyValuePairs);*//*

                // ---------------------------------------------------------------------

                // BST
                *//*var bstKeyValueMap = new BinarySearchTreeKeyValueMap<int, int>();

                CreateKeyValueMap<int, int>(bstKeyValueMap, intKeyValuePairs);*//*

                // ---------------------------------------------------------------------

                // AVL
                *//*var avlKeyValueMap = new AVLTreeKeyValueMap<int, int>();

                CreateKeyValueMap<int, int>(avlKeyValueMap, intKeyValuePairs);*//*

                // ---------------------------------------------------------------------

                // RedBlack
                *//*var redBlackKeyValueMap = new RedBlackTreeKeyValueMap<int, int>();

                CreateKeyValueMap<int, int>(redBlackKeyValueMap, intKeyValuePairs);*//*
            }

            Console.WriteLine("\nUnordered");

            for (int c = 0; c < 10; c++)
            {
                var intKeyValuePairs = new List<KeyValuePair<int, int>>();

                for (int i = 0; i < MAX; i++)
                {
                    intKeyValuePairs.Add(new KeyValuePair<int, int>(i, i + 2));
                }

                // Hashtable
                *//*var dictionaryKeyValueMap = new DictionaryKeyValueMap<int, int>();

                intKeyValuePairs.Shuffle();

                CreateKeyValueMap<int, int>(dictionaryKeyValueMap, intKeyValuePairs);*//*

                // ---------------------------------------------------------------------

                // BST
                *//*var bstKeyValueMap = new BinarySearchTreeKeyValueMap<int, int>();

                intKeyValuePairs.Shuffle();

                CreateKeyValueMap<int, int>(bstKeyValueMap, intKeyValuePairs);*//*

                // ---------------------------------------------------------------------

                // AVL
                *//*var avlKeyValueMap = new AVLTreeKeyValueMap<int, int>();

                intKeyValuePairs.Shuffle();

                CreateKeyValueMap<int, int>(avlKeyValueMap, intKeyValuePairs);*//*

                // ---------------------------------------------------------------------

                // RedBlack
                *//*var redBlackKeyValueMap = new RedBlackTreeKeyValueMap<int, int>();

                intKeyValuePairs.Shuffle();

                CreateKeyValueMap<int, int>(redBlackKeyValueMap, intKeyValuePairs);*//*
            }*/
            #endregion

            #region lookup
            /*//Console.WriteLine("DictionaryKeyValueMap\n");
            //Console.WriteLine("BSTKeyValueMap\n");
            //Console.WriteLine("AVLKeyValueMap\n");
            //Console.WriteLine("RedBlackKeyValueMap\n");
            Console.WriteLine("Ordered");

            for (int c = 0; c < 10; c++)
            {
                var intKeyValuePairs = new List<KeyValuePair<int, int>>();

                for (int i = 0; i < MAX; i++)
                {
                    intKeyValuePairs.Add(new KeyValuePair<int, int>(i, i + 2));
                }

                // Hashtable
                *//*var dictionaryKeyValueMap = new DictionaryKeyValueMap<int, int>();

                CreateKeyValueMap<int, int>(dictionaryKeyValueMap, intKeyValuePairs);
                QueryKeyValueMap(dictionaryKeyValueMap, intKeyValuePairs);*//*

                // ---------------------------------------------------------------------

                // BST
                *//*var bstKeyValueMap = new BinarySearchTreeKeyValueMap<int, int>();

                CreateKeyValueMap<int, int>(bstKeyValueMap, intKeyValuePairs);
                QueryKeyValueMap(bstKeyValueMap, intKeyValuePairs);*//*

                // ---------------------------------------------------------------------

                // AVL
                *//*var avlKeyValueMap = new AVLTreeKeyValueMap<int, int>();

                CreateKeyValueMap<int, int>(avlKeyValueMap, intKeyValuePairs);
                QueryKeyValueMap(avlKeyValueMap, intKeyValuePairs);*//*

                // ---------------------------------------------------------------------

                // RedBlack
                *//*var redBlackKeyValueMap = new RedBlackTreeKeyValueMap<int, int>();

                CreateKeyValueMap<int, int>(redBlackKeyValueMap, intKeyValuePairs);
                QueryKeyValueMap(redBlackKeyValueMap, intKeyValuePairs);*//*
            }

            Console.WriteLine("\nUnordered");

            for (int c = 0; c < 10; c++)
            {
                var intKeyValuePairs = new List<KeyValuePair<int, int>>();

                for (int i = 0; i < MAX; i++)
                {
                    intKeyValuePairs.Add(new KeyValuePair<int, int>(i, i + 2));
                }

                // Hashtable
                *//*var dictionaryKeyValueMap = new DictionaryKeyValueMap<int, int>();

                intKeyValuePairs.Shuffle();

                CreateKeyValueMap<int, int>(dictionaryKeyValueMap, intKeyValuePairs);
                QueryKeyValueMap(dictionaryKeyValueMap, intKeyValuePairs);*//*

                // ---------------------------------------------------------------------

                // BST
                *//*var bstKeyValueMap = new BinarySearchTreeKeyValueMap<int, int>();

                intKeyValuePairs.Shuffle();

                CreateKeyValueMap<int, int>(bstKeyValueMap, intKeyValuePairs);
                QueryKeyValueMap(bstKeyValueMap, intKeyValuePairs);*//*

                // ---------------------------------------------------------------------

                // AVL
                *//*var avlKeyValueMap = new AVLTreeKeyValueMap<int, int>();

                intKeyValuePairs.Shuffle();

                CreateKeyValueMap<int, int>(avlKeyValueMap, intKeyValuePairs);
                QueryKeyValueMap(avlKeyValueMap, intKeyValuePairs);*//*

                // ---------------------------------------------------------------------

                // RedBlack
               *//* var redBlackKeyValueMap = new RedBlackTreeKeyValueMap<int, int>();

                intKeyValuePairs.Shuffle();

                CreateKeyValueMap<int, int>(redBlackKeyValueMap, intKeyValuePairs);
                QueryKeyValueMap(redBlackKeyValueMap, intKeyValuePairs);*//*
            }*/
            #endregion

            #region removal
            //Console.WriteLine("DictionaryKeyValueMap\n");
            //Console.WriteLine("BSTKeyValueMap\n");
            //Console.WriteLine("AVLKeyValueMap\n");
            Console.WriteLine("RedBlackKeyValueMap\n");
            Console.WriteLine("Ordered");

            for (int c = 0; c < 10; c++)
            {
                var intKeyValuePairs = new List<KeyValuePair<int, int>>();

                for (int i = 0; i < MAX; i++)
                {
                    intKeyValuePairs.Add(new KeyValuePair<int, int>(i, i + 2));
                }

                // Hashtable
                /*var dictionaryKeyValueMap = new DictionaryKeyValueMap<int, int>();

                CreateKeyValueMap<int, int>(dictionaryKeyValueMap, intKeyValuePairs);
                RemoveKeyValueMap(dictionaryKeyValueMap, intKeyValuePairs);*/

                // ---------------------------------------------------------------------

                // BST
                /*var bstKeyValueMap = new BinarySearchTreeKeyValueMap<int, int>();

                CreateKeyValueMap<int, int>(bstKeyValueMap, intKeyValuePairs);
                RemoveKeyValueMap(bstKeyValueMap, intKeyValuePairs);*/

                // ---------------------------------------------------------------------

                // AVL
                /*var avlKeyValueMap = new AVLTreeKeyValueMap<int, int>();

                CreateKeyValueMap<int, int>(avlKeyValueMap, intKeyValuePairs);
                RemoveKeyValueMap(avlKeyValueMap, intKeyValuePairs);*/

                // ---------------------------------------------------------------------

                // RedBlack
                var redBlackKeyValueMap = new RedBlackTreeKeyValueMap<int, int>();

                CreateKeyValueMap<int, int>(redBlackKeyValueMap, intKeyValuePairs);
                RemoveKeyValueMap(redBlackKeyValueMap, intKeyValuePairs);
            }

            Console.WriteLine("\nUnordered");

            for (int c = 0; c < 10; c++)
            {
                var intKeyValuePairs = new List<KeyValuePair<int, int>>();

                for (int i = 0; i < MAX; i++)
                {
                    intKeyValuePairs.Add(new KeyValuePair<int, int>(i, i + 2));
                }

                // Hashtable
                /*var dictionaryKeyValueMap = new DictionaryKeyValueMap<int, int>();

                intKeyValuePairs.Shuffle();

                CreateKeyValueMap<int, int>(dictionaryKeyValueMap, intKeyValuePairs);
                RemoveKeyValueMap(dictionaryKeyValueMap, intKeyValuePairs);*/

                // ---------------------------------------------------------------------

                // BST
                /*var bstKeyValueMap = new BinarySearchTreeKeyValueMap<int, int>();

                intKeyValuePairs.Shuffle();

                CreateKeyValueMap<int, int>(bstKeyValueMap, intKeyValuePairs);
                RemoveKeyValueMap(bstKeyValueMap, intKeyValuePairs);*/

                // ---------------------------------------------------------------------

                // AVL
                /*var avlKeyValueMap = new AVLTreeKeyValueMap<int, int>();

                intKeyValuePairs.Shuffle();

                CreateKeyValueMap<int, int>(avlKeyValueMap, intKeyValuePairs);
                RemoveKeyValueMap(avlKeyValueMap, intKeyValuePairs);*/

                // ---------------------------------------------------------------------

                // RedBlack
                var redBlackKeyValueMap = new RedBlackTreeKeyValueMap<int, int>();

                intKeyValuePairs.Shuffle();

                CreateKeyValueMap<int, int>(redBlackKeyValueMap, intKeyValuePairs);
                RemoveKeyValueMap(redBlackKeyValueMap, intKeyValuePairs);
            }
            #endregion
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

            //Console.WriteLine(stopwatch.Elapsed.TotalSeconds);
            //Console.WriteLine(keyValueMap.Height);

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

            //Console.WriteLine(stopwatch.Elapsed.TotalSeconds);
            //Console.WriteLine(keyValueMap.Height);
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
            //Console.WriteLine(keyValueMap.Height);
        }
    }
}
