﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCODE
{
    internal class area
    {
        int redius;
        public area (int circleredius)
        {
            redius = circleredius; 
        }

        public double GetArea()
        {
            return 3.142 * redius * redius;
        }
    }
}
