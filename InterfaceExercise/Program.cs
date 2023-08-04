using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {

        static void Main(string[] args)
        {
            List<IVehicle> vehicles = new List<IVehicle>();
            int addCar = 0;
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values


            var car = new Car()
            {
                numberOfDoors = 4,
                hasNewTires = true,
                Year = 2023,
                Make = "Cheverolet",
                Model = "Malibu",
                Color = "Green",
                Logo = "Gold Bowtie",
                luxuryModel = "Premier"
            };
            vehicles.Add(car);
            addCar++;


            var suv = new SUV()
            {
                isFullSize = true,
                numOfSeats = 7,
                Year = 2004,
                Make = "GMC",
                Model = "Yukon XL",
                Color = "Black",
                Logo = "Red GMC",
                luxuryModel = "Denali"


            };
            vehicles.Add(suv);
            addCar++;
            var truck = new Truck()
            {
                hemiOrDiesel = "Diesel",
                hasExtendedCab = true,
                Year = 2019,
                Make = "Ram",
                Model = "2500",
                Color = "Red",
                Logo = "Ram head",
                luxuryModel = "Limited"
            };
            vehicles.Add(truck);
            addCar++;
            Console.WriteLine($"You have a total number of {addCar} vehicles in your garage.");
            foreach (IVehicle vehicle in vehicles)
            {
                Console.WriteLine($"{vehicle.Year}\n{vehicle.Make}\n{vehicle.Model}\n{vehicle.Color}\n\n\n");
            }
            Console.WriteLine($"Quiz time!\nAnswer these quetions about these vehicles:");
            while (true)
            {
                Console.WriteLine("Is the luxury model for the Ram 2500 the KingRanch edition?\nType 1 for true and 2 for false.");
                bool answer_1 = int.TryParse(Console.ReadLine(), out int answer);
                if (answer == 1)
                {
                    Console.WriteLine("You are incorrect; it is the Limited.");
                }
                else if (answer == 2)
                {
                    Console.WriteLine("That's right, it's the Limited edition.");
                }
                else
                {
                    Console.WriteLine("Invalid input...");
                    continue;
                }
                Console.WriteLine("How many doors does the Chevy Malibu have?");
                var answer_2 = int.TryParse(Console.ReadLine(), out int answer2);
                switch(answer2)
                {
                    case 1:
                        Console.WriteLine("Incorrect! The answer is 4");
                        break;
                    case 2:
                        Console.WriteLine("Incorrect! The answer is 4");
                        break;
                    case 3:
                        Console.WriteLine("Incorrect! The answer is 4");
                        break;
                    case 4:
                        Console.WriteLine("Correct!");
                        break;
                    default:
                        Console.WriteLine("Invalid input... start over!");
                        continue;

                }
                Console.WriteLine("Last question!\nName the two luxury models for the Chevy malibu and the GMC Yukon XL.");
                var answer_3 = Console.ReadLine();
                switch(answer_3)
                {
                    case "Premier and Denali" or "Denali and Premier" or "premier and denali" or "denali and premier":
                        Console.WriteLine("Correct!");
                        break;
                    case "Premier, Denali" or "Denali, Premier" or "premier, denali" or "denali, premier":
                        Console.WriteLine("Correct!");
                        break;
                    default:
                        Console.WriteLine("Invalid input... start over again!");
                        continue;

                }
                Console.WriteLine("You are now finished with the quiz!\n\n\n");
            }
        }
    }
}
