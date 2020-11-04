using System;
using System.Collections.Generic;

namespace generic_lists
{
    class Car
    {
        public string VIN { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
    }

    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car() { Brand = "Opel", Model = "Insignia", VIN = "felix" };
            Car car2 = new Car() { Brand = "Mazda", Model = "6", VIN = "mehiko" };
            Animal animal1 = new Animal("Giraffe", 27);

            List<Car> cars = new List<Car>();

            cars.Add(car1);
            cars.Add(car2);

            foreach(Car car in cars)
            {
                Console.WriteLine("{0} {1}", car.Brand, car.Model);
            }

            Dictionary<string, Car> carDictionary = new Dictionary<string, Car>();

            carDictionary.Add(car1.VIN, car1);
            carDictionary.Add(car2.VIN, car2);

            Console.WriteLine(carDictionary["mehiko"].Brand);

            List<Car> newCars = new List<Car>()
            {
                new Car { Brand = "Peugeot", Model = "407", VIN = "cacin_auto"},
                new Car { Brand = "Nissan", Model = "Skyline", VIN = "najs_car"}
            };

            Console.WriteLine(newCars[1].Brand);
        }
    }
}
