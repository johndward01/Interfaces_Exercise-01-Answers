using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Interfaces_Exericse_01_Answers.Vehicle_Parts
{
    // TODO: Create a class called MiscPart that conforms to IParts
    class MiscPart : IParts
    {
        // TODO: Implement the interface and creatively let the user know when a part is being built and when that part is done
        public IParts BuildPart()
        {
            Console.WriteLine();
            Console.WriteLine("Building misc part...");
            Thread.Sleep(1000);
            Console.WriteLine("Part built!!!");
            return new MiscPart();
        }
    }
}
