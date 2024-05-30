using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_1
{
    public class VehicleStorage<T>
    {
        List<T> vehicles = new List<T>();
        T data;
        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        public void Add(T vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void DisplayVehicle()
        {
            foreach (var v in vehicles)
            {
                Console.WriteLine(v);
            }
        }
    }

    public class Car
    {
        string name;
        string model;

        public Car(string Name, string Model)
        {
            name = Name;
            model = Model;
        }
    }

    class Van
    {
        string name;
        string model;
        public Van(string Name, string Model)
        {
            name = Name;
            model = Model;
        }
    }

    class GenericClassTest
    {
     /*   static void Main(string[] args)
        {
            Car car = new Car("Toyota", "2024_Corolla");
            VehicleStorage <Car> carStorage = new VehicleStorage<Car>();
            carStorage.Add(car);
            carStorage.DisplayVehicle();

            Van van = new Van("Ford", "Transit-2018");
            VehicleStorage<Van> vanStorage = new VehicleStorage<Van>();
            vanStorage.Add(van);
            vanStorage.DisplayVehicle();
            Console.ReadLine();
        }*/
    }
}
