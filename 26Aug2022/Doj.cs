using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCODE
{
    internal class Doj
    {
            int id;
            string name;
            string dept;
            double sal;
            DateOnly doj;

            
            public Doj(int eid, string ename, DateOnly doj)
            {
                id = eid; name = ename; this.doj = doj;
            }
            
            public int GetYearsofExp()
            {
                return DateTime.Now.Year - doj.Year;
            }
    }
}
