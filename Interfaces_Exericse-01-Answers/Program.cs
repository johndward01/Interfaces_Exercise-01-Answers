using Interfaces_Exericse_01_Answers.Vehicle_Parts;
using System;
using System.Collections.Generic;

namespace Interfaces_Exericse_01_Answers
{
    class Program
    {
        // TODO: Create an Interface called IParts
        // TODO: Create a BuildPart() stubbed out method that has a return type of IParts       

        // TODO: Create a class called PlanePart that conforms to IParts
        // TODO: Implement the interface and creatively let the user know when a part is being built and when that part is done

        // TODO: Create a class called TruckPart that conforms to IParts
        // TODO: Implement the interface and creatively let the user know when a part is being built and when that part is done

        // TODO: Create a class called CarPart that conforms to IParts
        // TODO: Implement the interface and creatively let the user know when a part is being built and when that part is done

        // TODO: Create a class called BikePart that conforms to IParts
        // TODO: Implement the interface and creatively let the user know when a part is being built and when that part is done

        // TODO: Create a class called MiscPart that conforms to IParts
        // TODO: Implement the interface and creatively let the user know when a part is being built and when that part is done


        // BONUS
        // TODO: Create methods to abstract away most of the code from your Main() method
        // TODO: Create a Utility class to encapsulate those methods into 1 location

        static void Main(string[] args)
        {
            // TODO: Create an IParts List called partsList that will hold all of the parts we want to create
            var partsList = new List<IParts>();

            // TODO: Create a do-while loop that only ends when the user types "no" (or 'n')
            Utility.Greet();
            do
            {
                // TODO: Greet the user and ask them which part they would like to create
                var part = Utility.GetPart();

                // TODO: Call that parts BuildPart() method
                part.BuildPart();

                // TODO: Add the part to the partsList
                partsList.Add(part);

                // TODO: Ask them if they would like to continue or exit the program
                var continuing = Utility.Continue();
                if (continuing == "n" || continuing == "no")
                {
                    break;
                }
            } while (true);

            // TODO: Print out all the parts in the parts list to the console
            Console.WriteLine("PARTS LIST:");
            int counter = 0;
            foreach (var part in partsList)
            {
                Console.WriteLine($"Part #{counter}: {part.GetType().Name}");
                counter++;
            }
        }
    }
}
