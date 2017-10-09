using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus17
{
    class Program
    {
        static void Main(string[] args)
        {
            Car motorsAdmin = new Car();

            Console.WriteLine("Welcome to the Grand Circus Motors admin console!");
            Console.WriteLine("How many cars are you entering:");
            int numberOfCars = int.Parse(Console.ReadLine());

            // 1. create an array to hold the objects
            Car[] GCMotors = new Car[numberOfCars];

            //2. creating the Car objects inside our array(GCMotors)
            for (int i = 0; i < GCMotors.Length; i++)
            {
                GCMotors[i] = new Car();//make an object
            }

            //3. initialize the objects
            for (int i = 0; i < GCMotors.Length; i++)
            {
                Console.WriteLine("Please enter the car's make");
                GCMotors[i].Make = Console.ReadLine();

                Console.WriteLine("Please enter the car's model");
                GCMotors[i].Model = Console.ReadLine();

                Console.WriteLine("Please enter the car's year");
                GCMotors[i].Year = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the car's price");
                GCMotors[i].Price = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Current Inventory:");
            Console.WriteLine("Make\tModel\tYear\tPrice");
            foreach (Car GCM in GCMotors)
            {
                Console.WriteLine($"{GCM.Make}\t{GCM.Model}\t{GCM.Year}\t${GCM.Price.ToString("n2")}");
            }

        }
    }
}
