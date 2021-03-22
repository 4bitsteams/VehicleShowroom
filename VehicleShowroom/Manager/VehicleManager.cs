using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleShowroom.Entity;
using VehicleShowroom.Repository;

namespace VehicleShowroom.Manager
{
    public class VehicleManager
    {
        private readonly VehicleRepository vehicleRepository;

        public long Add(Vehicle entity, ref List<Vehicle> entities)
        {
            return vehicleRepository.Add(entity, ref entities);
        }

        public bool Remove(object id, ref List<Vehicle> entities)
        {
            return vehicleRepository.Remove(id, ref entities);
        }

        public List<Vehicle> GetAll(ref List<Vehicle> entities)
        {
            return vehicleRepository.GetAll(ref entities);
        }
    }
}
