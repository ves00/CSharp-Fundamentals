using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace _07.VehicleCatalogue
{
    internal class Program
    {
        static void Main()
        {
            //Car / Maserati / Levante / 350
            //Truck / Mercedes / Actros / 9019
            string input = Console.ReadLine();

            Catalog catalog = new Catalog();

            while (input != "end")
            {
                string[] vehicleInfo = input.Split('/');

                string vehicleType = vehicleInfo[0];
                string brand = vehicleInfo[1];
                string model = vehicleInfo[2];
                int value = int.Parse(vehicleInfo[3]); // can be HP or weight

                if (vehicleType == "Truck")
                {
                    Truck truck = new Truck(brand, model, value);
                    catalog.Trucks.Add(truck);
                }
                else
                {
                    Car car = new Car(brand, model, value);
                    catalog.Cars.Add(car);
                }
                input = Console.ReadLine();
            }
            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine($"Cars:");
            }


            foreach (Car car in catalog.Cars.OrderBy(x => x.Brand))
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }

            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine($"Trucks:");
            }

            foreach (Truck truck in catalog.Trucks.OrderBy(x => x.Brand))
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }
    public class Catalog
    {
        public Catalog()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }

        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
    public class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    public class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }

        public string Brand { get; set; }
        public string Model { get; set; }

        public int Weight { get; set; }
    }
}
