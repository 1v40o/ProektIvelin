using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektIvelin.Controlers
{
    public class VegetableTypeController
    {
        private VegetableContext _vegetableContext = new VegetableContext();

        public List<VegetableType> GetAllTypes()
        {
            return _vegetableContext.VegetableType.ToList();
        }
        public string GetVegetableTypeById(int id)
        {
            return _vegetableContext.VegetableType.Find(id).Name;
        }


    }
}
