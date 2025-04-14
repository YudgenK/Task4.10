using ConsoleApp1.Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TasksSelector
    {
        public void sealectTask()
        {
            Console.Clear();
            Console.WriteLine("Оберіть завдання:");
            int.TryParse(Console.ReadLine(), out int taskNamber);

            switch (taskNamber)
            {
                case 2:
                    {
                        task2();
                        break;
                    }
                case 3:
                    {
                        task3();
                        break;
                    }
                case 4:
                    {
                        task4();
                        break;
                    }
                case 6:
                    {
                        task6();
                        break;
                    }
                case 7:
                    {
                        task7();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Такого завдання немає");
                        break;
                    }
            }
        }

        private static void task2()
        {
            var Task2 = new task2();
            Task2.Run();
        }

        private static void task3()
        {
            var Task3 = new task3();
            Task3.Run();
        }
        private static void task4()
        {
            var Task4 = new task4();
            Task4.Run();
        }
        private static void task6()
        {
            var Task6 = new ConsoleApp1.Task.task6();
            Task6.Run();
        }
        private static void task7()
        {
            var Task7 = new task7();
            Task7.Run();
        }

    }
}
