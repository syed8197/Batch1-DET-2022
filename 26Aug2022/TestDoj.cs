using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCODE
{
    internal class TestDoj
    {
       
        public static void Main()
        {
           Doj  e = new Doj(5050, "Mary", new DateOnly(2020, 8, 1));
            Console.WriteLine($"Years of experience {e.GetYearsofExp()}");
        }
    }
}
