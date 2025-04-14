using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Task
{
    class task3
    {
        public void Run()
        {
            var myDictionary = new Dictionary<string, int>();

            myDictionary.Add("Apple", 10);
            myDictionary.Add("Banana", 20);
            myDictionary.Add("Cherry", 30);

            Console.WriteLine("Вміст словника:");
            myDictionary.Display();

            Console.WriteLine("\nЗначення за ключем 'Banana':");
            Console.WriteLine(myDictionary["Banana"]);

            Console.WriteLine("\nКількість елементів у словнику:");
            Console.WriteLine(myDictionary.Count);

            try
            {
                Console.WriteLine("\nСпроба отримати значення за неіснуючим ключем:");
                Console.WriteLine(myDictionary["Orange"]);
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public class Dictionary<TKey, TValue>
        {
            private List<KeyValuePair<TKey, TValue>> _items;

            public Dictionary()
            {
                _items = new List<KeyValuePair<TKey, TValue>>();
            }

            public int Count => _items.Count;

            public void Add(TKey key, TValue value)
            {
                _items.Add(new KeyValuePair<TKey, TValue>(key, value));
            }

            public TValue this[TKey key]
            {
                get
                {
                    foreach (var pair in _items)
                    {
                        if (EqualityComparer<TKey>.Default.Equals(pair.Key, key))
                        {
                            return pair.Value;
                        }
                    }

                    throw new KeyNotFoundException("Ключ не знайдений.");
                }
            }
            public void Display()
            {
                foreach (var pair in _items)
                {
                    Console.WriteLine($"Ключ: {pair.Key}, Значення: {pair.Value}");
                }
            }
        }

    }
}