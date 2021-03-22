using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleShowroom.Common.Enum;
namespace VehicleShowroom.Entity
{
    public class HeavyVehicle : Vehicle
    {
        HeavyVehicle()
        {
            this.EngineType = EngineType.Diesel;
        }

        public Double Weight { get; set; }
    }
}
