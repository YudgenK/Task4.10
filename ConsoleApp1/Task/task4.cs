using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Task
{
    class task4
    {
        public void Run()
        {
            ArrayList<int> intList = new ArrayList<int>();

            intList.Add(10);
            intList.Add(5);
            intList.Add(15);

            Console.WriteLine("Вміст ArrayList для типу int:");
            intList.Display();

            ArrayList<string> stringList = new ArrayList<string>();

            stringList.Add("apple");
            stringList.Add("banana");
            stringList.Add("cherry");

            Console.WriteLine("\nВміст ArrayList для типу string:");
            stringList.Display();

            Console.WriteLine("\nКількість елементів у ArrayList для int:");
            Console.WriteLine(intList.Count);

            Console.WriteLine("\nКількість елементів у ArrayList для string:");
            Console.WriteLine(stringList.Count);

            try
            {
                Console.WriteLine("\nОтримання елемента на індексі 5 для int:");
                Console.WriteLine(intList[5]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message); 
            }
        }
    }
    public class ArrayList<T> where T : IComparable<T> 
    {
        private T[] _items;
        private int _size;

        public ArrayList()
        {
            _items = new T[4]; 
            _size = 0;
        }

        public int Count
        {
            get { return _size; }
        }

        public void Add(T item)
        {
            if (_size == _items.Length)
            {
                Resize(_items.Length * 2); 
            }

            _items[_size++] = item; 
        }

        
        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < _size)
                    return _items[index];
                else
                    throw new IndexOutOfRangeException("Індекс знаходиться за межами масиву.");
            }
        }

       
        private void Resize(int newSize)
        {
            T[] newItems = new T[newSize];
            Array.Copy(_items, newItems, _size);
            _items = newItems;
        }
        public void Display()
        {
            for (int i = 0; i < _size; i++)
            {
                Console.WriteLine(_items[i]);
            }
        }
    }

}