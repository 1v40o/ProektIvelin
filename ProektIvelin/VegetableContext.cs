using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektIvelin
{
    public class VegetableContext : DbContext
    {
        public VegetableContext() : base("MagIvelin")
        { }
        public DbSet<Vegetables> Vegetables { get; set; }
        public DbSet<VegetableType> VegetableType { get; set; }



    }
}
