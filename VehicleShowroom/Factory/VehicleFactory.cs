using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleShowroom.Common.Enum;
using VehicleShowroom.Entity;

namespace VehicleShowroom.Factory
{
    public class VehicleFactory
    {
        //use GetVehicle method to get object of type Vehicle 
        public Vehicle GetVehicle(VehicleType vehicleType)
        {
            if (!(vehicleType > 0))
            {
                return null;
            }
            if (vehicleType == VehicleType.Normal)
            {
                return new NormalVehicle();

            }
            else if (vehicleType == VehicleType.Sports)
            {
                return new SportsVehicle();

            }
            else if (vehicleType == VehicleType.Heavy)
            {
                return new HeavyVehicle();
            }

            return null;
        }
    }
}
