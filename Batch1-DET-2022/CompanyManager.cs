﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class CompanyManager
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string phone { get; set; }
        public string print()
        {
            return $"Name={Name}, Surname={Surname}, phone={phone}";
        }
    }
}
