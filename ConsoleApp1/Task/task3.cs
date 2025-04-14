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
            // Створюємо істот
            Human human = new Human();
            Elf elf = new Elf();
            Robot robot = new Robot();

            // Створюємо чарівні мішки для кожної істоти
            MagicBag<Human> humanBag = new MagicBag<Human>(human);
            MagicBag<Elf> elfBag = new MagicBag<Elf>(elf);
            MagicBag<Robot> robotBag = new MagicBag<Robot>(robot);

            // Істоти відкривають мішки
            humanBag.OpenBag();  // Людина отримує подарунок
            elfBag.OpenBag();    // Ельф отримує подарунок
            robotBag.OpenBag();  // Робот отримує подарунок

            // Спробуємо знову відкрити мішок для людини
            Console.WriteLine();
            humanBag.OpenBag();  // Людина вже відкривав мішок сьогодні
        }

        // Інтерфейс для істот
        public interface ICreature
        {
            string Type { get; }
        }

        // Клас для створення подарунків
        public class Gift
        {
            public string Name { get; set; }

            public Gift(string name)
            {
                Name = name;
            }
        }

        // Чарівний мішок
        public class MagicBag<T> where T : ICreature
        {
            private Gift _gift;
            private DateTime _lastOpened;
            private T _creature;

            public MagicBag(T creature)
            {
                _creature = creature;
                _lastOpened = DateTime.MinValue;  // Ініціалізація часу останнього відкриття
            }

            // Метод для відкриття мішка
            public Gift OpenBag()
            {
                // Перевірка, чи вже істота відкривала мішок сьогодні
                if (_lastOpened.Date == DateTime.Today)
                {
                    Console.WriteLine($"{_creature.Type} вже відкривав мішок сьогодні!");
                    return null;
                }

                // Створюємо подарунок для цієї істоти
                _gift = new Gift($"Подарунок для {_creature.Type}");
                _lastOpened = DateTime.Now;  // Оновлюємо час останнього відкриття

                Console.WriteLine($"{_creature.Type} отримав подарунок: {_gift.Name}");
                return _gift;
            }
        }

        // Клас для людини
        public class Human : ICreature
        {
            public string Type => "Людина";
        }

        // Клас для ельфа
        public class Elf : ICreature
        {
            public string Type => "Ельф";
        }

        // Клас для робота
        public class Robot : ICreature
        {
            public string Type => "Робот";
        }

    }
}