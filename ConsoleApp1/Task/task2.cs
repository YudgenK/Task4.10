using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Task
{
    class task2
    {

        public void Run()
        {
            // Створюємо екземпляр MyList для зберігання цілих чисел
            MyList<int> myList = new MyList<int>();

            // Додаємо елементи в список
            myList.Add(10);
            myList.Add(20);
            myList.Add(30);

            Console.WriteLine($"Кількість елементів: {myList.Count}");

            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine($"Елемент {i + 1}: {myList[i]}");
            }

            // Використовуємо індексатор для зміни значення елемента
            myList[1] = 50;

            Console.WriteLine("\nОновлений список:");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine($"Елемент {i + 1}: {myList[i]}");
            }
        }

    }
    class MyList<T>
    {
        private T[] elements;
        private int count;

        public MyList()
        {
            elements = new T[4];  // Початковий розмір масиву
            count = 0;
        }

        // Властивість для отримання кількості елементів
        public int Count
        {
            get { return count; }
        }

        // Індексатор для доступу до елементів за індексом
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException("Індекс знаходиться поза межами списку.");
                }
                return elements[index];
            }
            set
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException("Індекс знаходиться поза межами списку.");
                }
                elements[index] = value;
            }
        }

        // Метод для додавання елемента в список
        public void Add(T item)
        {
            if (count == elements.Length)
            {
                Resize();
            }
            elements[count] = item;
            count++;
        }

        // Метод для збільшення розміру масиву
        private void Resize()
        {
            T[] newArray = new T[elements.Length * 2];
            Array.Copy(elements, newArray, elements.Length);
            elements = newArray;
        }
    }

}


