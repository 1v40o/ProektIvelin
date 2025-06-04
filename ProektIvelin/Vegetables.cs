using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektIvelin
{
    public class Vegetables
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Type { get; set; }
        public int VegetableTypeId { get; set; }

        public VegetableType VegetableType { get; set; }
    }
}
