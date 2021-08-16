using Interfaces_Exericse_01_Answers.Vehicle_Parts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Exericse_01_Answers
{
    public class Utility
    {
        public static void AddSpaces()
        {
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void Greet()
        {
            Console.WriteLine("Welcome to the Factory Parts Picker!");
            Console.WriteLine("For a bike part type: bike");
            Console.WriteLine("For a car part type: car");
            Console.WriteLine("For a truck part type: truck");
            Console.WriteLine("For a plane part type: plane");
            AddSpaces();
        }

        public static IParts GetPart()
        {
            Console.WriteLine("Which part would you like to create?");
            Console.WriteLine();

            var partType = Console.ReadLine();
            IParts part = partType switch
            {
                "bike" => new BikePart(),
                "car" => new CarPart(),
                "truck" => new TruckPart(),
                "plane" => new PlanePart(),
                _ => new MiscPart(),
            };
            return part;
        }

        public static string Continue()
        {
            AddSpaces();
            Console.WriteLine("Would you like to continue?");
            Console.Write("Type y for yes and n for no: ");
            AddSpaces();
            var continuing = Console.ReadLine();
            AddSpaces();
            return continuing.ToLower();
        }
    }
}
