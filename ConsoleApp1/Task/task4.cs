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
            // Створення екземпляра MyList
            MyList myList = new MyList(5);

            // Додавання елементів у список
            myList.Add("Apple");
            myList.Add("Banana");
            myList.Add("Cherry");
            myList.Add("Date");
            myList.Add("Elderberry");

            // Отримання масиву через метод розширення
            var array = myList.GetArray<string>();

            // Виведення елементів масиву
            Console.WriteLine("Елементи масиву:");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }


        }
    }
    // Клас MyList для зберігання елементів
    public class MyList
    {
        private string[] items;
        private int count;

        public MyList(int capacity)
        {
            items = new string[capacity];
            count = 0;
        }

        // Метод для додавання елементів у список
        public void Add(string item)
        {
            if (count < items.Length)
            {
                items[count++] = item;
            }
            else
            {
                Console.WriteLine("Список заповнений!");
            }
        }

        // Індексатор для отримання елементів за індексом
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < count)
                {
                    return items[index];
                }
                else
                {
                    return "Індекс поза межами списку.";
                }
            }
        }

        // Властивість для отримання кількості елементів
        public int Count => count;
    }

    // Статичний клас з методами розширення
    public static class MyListExtensions
    {
        // Метод розширення для перетворення списку в масив
        public static T[] GetArray<T>(this MyList list)
        {
            T[] array = new T[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                array[i] = (T)Convert.ChangeType(list[i], typeof(T));
            }
            return array;
        }
    }


}