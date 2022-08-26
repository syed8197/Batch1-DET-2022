using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCODE
{
    internal class circlearea
    {
        public static void Main()
        {
            area a = new area(50);
            Console.WriteLine($"the area of the circle is {a.GetArea()} cm square");
        }
    }
}
