using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base.NugetHello;

namespace NuGetConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Begin: Base.ConsoleApplication.");
            Example e = new Example();
            e.WriteLicense();
            Console.WriteLine(e.GetMessage());
            Console.WriteLine("");
            Console.WriteLine("End: Base.ConsoleApplication.");
            Console.WriteLine("");
            Console.WriteLine("Press anykey to exit.");
            Console.ReadKey();
       
        }
    }
}
