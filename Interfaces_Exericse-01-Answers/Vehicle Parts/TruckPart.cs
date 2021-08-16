using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Interfaces_Exericse_01_Answers
{
    // TODO: Create a class called TruckPart that conforms to IParts
    public class TruckPart : IParts
    {
        // TODO: Implement the interface and creatively let the user know when a part is being built and when that part is done
        public IParts BuildPart()
        {
            Console.WriteLine();
            Console.WriteLine("Building truck part...");
            Thread.Sleep(1000);
            Console.WriteLine("Part built!!!");
            return new TruckPart();
        }
    }
}
