using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektIvelin.Controlers
{
    public class VegetableTypeController
    {
        private VegetableContext _VegetableContext;

        public VegetableTypeController(int id)
        {
            Vegetables findedVegetables = _VegetableContext.Vegetables.Find(id);
            if (findedVegetables != null)
            {
                _VegetableContext.Entry(findedVegetables).Reference (x=>x.VegetableType).Load();
            }
           return;
        }



    }
}
