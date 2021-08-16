using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Exericse_01_Answers.Vehicle_Parts
{
    // TODO: Create a class called PlanePart that conforms to IParts
    public class PlanePart : IParts
    {
        // TODO: Implement the interface and creatively let the user know when a part is being built and when that part is done
        public IParts BuildPart()
        {
            Console.WriteLine();
            Console.WriteLine("Building plane part...");
            Thread.Sleep(1000);
            Console.WriteLine("Part built!!!");
            
            return new PlanePart();
        }
    }
}
