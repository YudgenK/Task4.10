using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Task
{
    class task6
    {
        public void Run()
        {
            ArrayList list = new ArrayList();

            MyStruct structElement = new MyStruct { Value = 10 };
            MyClass classElement = new MyClass { Value = 20 };

            list.Add(structElement); 
            list.Add(classElement);  

            for (int i = 0; i < list.Count; i++)
            {
                var item = list[i];

                // Проблема: потрібно використовувати кастинг для доступу до конкретних полів
                if (item is MyStruct)
                {
                    MyStruct temp = (MyStruct)item;
                    Console.WriteLine("Структура: " + temp.Value);
                }
                else if (item is MyClass)
                {
                    MyClass temp = (MyClass)item;
                    Console.WriteLine("Клас: " + temp.Value);
                }
            }
        }
    }

    struct MyStruct
    {
        public int Value;
    }

    class MyClass
    {
        public int Value;
    }


}