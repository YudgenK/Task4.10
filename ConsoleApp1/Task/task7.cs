using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Task
{
    class task7
    {
        public void Run()
        {
            int intValue = MyClass<int>.FactoryMethod();
            Console.WriteLine("intValue: " + intValue);  

            //string strValue = MyClass<string>.FactoryMethod();
            //Console.WriteLine("strValue: " + strValue);  

            DateTime dateValue = MyClass<DateTime>.FactoryMethod();
            Console.WriteLine("dateValue: " + dateValue);  

        }
    }
    public class MyClass<T> where T : new()
    {
        public static T FactoryMethod()
        {
            return new T(); 
        }
    }
    //Тип T повинен відповідати обмеженню new (), 
    // щоб можна було створити його екземпляр за допомогою конструктора без параметрів.
    //Якщо тип T не має такого конструктора, компілятор видасть помилку.

}