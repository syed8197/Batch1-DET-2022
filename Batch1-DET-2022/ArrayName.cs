using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class ArrayName
    {
        public static void main()
        {
            string[] names = { "syed", "tabrej", "john", "marry", "michael" };

            var names1 = from a in names
                         where a.Contains("o")
                         select a;
            foreach(string a in names1)
                Console.WriteLine(a);
        }
            
    }
}
