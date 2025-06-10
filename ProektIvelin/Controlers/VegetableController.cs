using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektIvelin.Controlers
{
    public class VegetableController
    {
        private VegetableContext _VegetableContext;

        public VegetableController(int id)
        {
            Vegetables foundVegetables = _VegetableContext.Vegetables.Find(id);
            if (foundVegetables != null)
            {
                _VegetableContext.Entry(foundVegetables).Reference(x => x.VegetableType).Load();
            }
            return;
        }


        public List<Vegetables> GetAll()
        {
            return _VegetableContext.Vegetables.Include("VegetableType").ToList();
        }

        public void Create(Vegetables vegetables)
        {
            _VegetableContext.Vegetables.Add(vegetables);
            _VegetableContext.SaveChanges();
        }

        public void Update(int id, Vegetables vegetables)
        {
            Vegetables foundVegetables = _VegetableContext.Vegetables.Find(id);
            if (foundVegetables == null)
            {
                return;
            }
            foundVegetables.Name = vegetables.Name;
            _VegetableContext.SaveChanges();
        }

        public void Delete(int id)

        {
            Vegetables foundVegetables = _VegetableContext.Vegetables.Find(id);
            _VegetableContext.Vegetables.Remove(foundVegetables);
        }

    }
}
