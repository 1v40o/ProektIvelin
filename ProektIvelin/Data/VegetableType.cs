﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektIvelin
{
    public class VegetableType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<VegetableType> VegetableTypes { get; set; }
    }
}
