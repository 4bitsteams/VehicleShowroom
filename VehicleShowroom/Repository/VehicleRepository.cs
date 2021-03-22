using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleShowroom.Entity;

namespace VehicleShowroom.Repository
{
    public class VehicleRepository : IRepository<Vehicle>
    {
        public long Add(Vehicle entity, ref List<Vehicle> entities)
        {
            if (entity == null)
                return 0;
            entities.Add(entity);
            return 1;
        }

        public bool Exist(object id, ref List<Vehicle> entities)
        {
            return entities.Exists(x => x.Id == (long)id);
        }

        public List<Vehicle> GetAll(ref List<Vehicle> entities)
        {
            return entities;
        }

        public Vehicle GetById(object id, ref List<Vehicle> entities)
        {
            return entities.Find(x => x.Id == (long)id);
        }

        public bool Remove(object id, ref List<Vehicle> entities)
        {
            return entities.Remove(entities.Where(x => x.Id == Convert.ToInt64(id)).First());
        }

        public bool Update(Vehicle entity, ref List<Vehicle> entities)
        {
            throw new NotImplementedException();
        }
    }
}
