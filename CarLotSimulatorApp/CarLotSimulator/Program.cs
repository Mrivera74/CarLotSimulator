using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a CarLot class
            var lot = new CarLot();

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //Dot notation
            var marksCar = new Car();
            marksCar.Make = "Honda";
            marksCar.Model = "Accord";
            marksCar.Year = 2016;
            marksCar.EngineNoise = "vvvsssss";
            marksCar.HonkNoise = "regular honk";
            marksCar.IsDriveable = true;

            lot.Cars.Add(marksCar);

            //Object initializer Syntax 
            var jonsnewCar = new Car()
            {
                Make = "Honda",
                Model = "Civic",
                Year = 2019,
                EngineNoise = "fffsswww",
                HonkNoise = "",
                IsDriveable = true
            };

            lot.Cars.Add(jonsnewCar);

            //Constructor  to allow parameter values to be placed inside properties
            //Don't use this if not sure of the parameters
            var davidsCar = new Car(2020, "Dodge", "Challenger", "vvvvrrrrooooommmm", "aaaauuugggaa", true);

            lot.Cars.Add(davidsCar);

            //Call each of the methods for each car
            marksCar.MakeEngineNoise(marksCar.EngineNoise);
            jonsnewCar.MakeEngineNoise(jonsnewCar.EngineNoise);
            davidsCar.MakeEngineNoise(davidsCar.EngineNoise);



            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            Console.WriteLine();

            Console.WriteLine($"Number of Cars Created: {CarLot.numberOfCars}");

            Console.WriteLine();

            foreach (var car in lot.Cars)
            {
             Console .WriteLine($"Year: {car.Year}, Make: {car.Make}, Model: {car.Model}");
            }
        }
    }
    
}
