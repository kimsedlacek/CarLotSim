using Microsoft.VisualBasic;
using System;
using System.Xml.Schema;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var car1 = new Car();
            car1.Year = 2022;
            car1.Make = "Honda";
            car1.Model = "Odyssey";
            car1.EngineNoise = "Purrs like a kitten";
            car1.HonkNoise = "loud and annoying";
            car1.IsDriveable = true;

            Console.WriteLine($"The first car is a {car1.Year} {car1.Make} {car1.Model}.  " +
                $"It's engine {car1.EngineNoise} but it's horn is {car1.HonkNoise}.  This car is driveable, " +
                $"true or false? {car1.IsDriveable}");
           

            var car2 = new Car();
            car2.Year = 2000;
            car2.Make = "Jeep";
            car2.Model = "Cherokee";
            car2.EngineNoise = "rough";
            car2.HonkNoise = "no longer honks";
            car2.IsDriveable = true;

            Console.WriteLine($"The next car is a {car2.Year} {car2.Make} {car2.Model}.  This car is used for " +
                $"snow plowing, it's engine is {car2.EngineNoise} and the horn {car2.HonkNoise}. It's {car2.IsDriveable}" +
                $"that this car is driveable, but only on private property.");

            var car3 = new Car();
            car3.Year = 2015;
            car3.Make = "Dodge";
            car3.Model = "Ram 1500";
            car3.EngineNoise = "loud like a truck";
            car3.HonkNoise = "tough like a truck";
            car3.IsDriveable = true;

            Console.WriteLine($"Our last car is actually a truck, it is a {car3.Year} {car3.Make} {car3.Model}." +
                $"It's engine is {car3.EngineNoise} should be and it's horn sound is {car3.HonkNoise}. I don't like" +
                $"driving this truck but its {car3.IsDriveable}that it is driveable.");

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            //Dot notation
            car1.Year = 2022;
            car1.Make = "Honda";
            car1.Model = "Odyssey";
            car1.EngineNoise = "purrs like a kitten";
            car1.HonkNoise = "loud and annoying";
            car1.IsDriveable = true;

            //Object initializer syntax
            var car2 = new Car()
            {
                Year = 2000,
                Make = "Jeep",
                Model = "Cherokee",
                EngineNoise = "rough",
                HonkNoise = "no longer honks",
                IsDriveable = true,

            };

            //Custom constructor
            var car3 = new Car(2000, "Jeep", "Cherokee", "rough", "no longer honks", true);


            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console


        }
    }
}
