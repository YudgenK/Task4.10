using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Task
{
    class task2
    {

        public void Run()
        {
            CarCollection<Car> carCollection = new CarCollection<Car>();

            carCollection.AddCar("Toyota Camry", 2020);
            carCollection.AddCar("Honda Accord", 2018);
            carCollection.AddCar("BMW 3 Series", 2022);

            Console.WriteLine($"Кількість автомобілів у колекції: {carCollection.Count}");

            Console.WriteLine("Автомобілі в колекції:");
            for (int i = 0; i < carCollection.Count; i++)
            {
                Console.WriteLine(carCollection[i]);
            }

            carCollection.RemoveAllCars();
            Console.WriteLine("\nПісля видалення всіх автомобілів:");
            Console.WriteLine($"Кількість автомобілів у колекції: {carCollection.Count}");

        }

    }
    public class Car
    {
        public string Name { get; set; }
        public int Year { get; set; }

        public Car(string name, int year)
        {
            Name = name;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Name} ({Year})";
        }
    }

    public class CarCollection<T> where T : Car 
    {
        private List<T> cars;

        public CarCollection()
        {
            cars = new List<T>();
        }

        public int Count => cars.Count;

        public void AddCar(string name, int year)
        {
            T car = (T)Activator.CreateInstance(typeof(T), name, year);
            cars.Add(car);
        }

        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < cars.Count)
                {
                    return cars[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Індекс поза межами колекції.");
                }
            }
        }
        public void RemoveAllCars()
        {
            cars.Clear();
        }
    }


}


