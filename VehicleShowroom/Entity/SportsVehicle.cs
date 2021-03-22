using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleShowroom.Common.Enum;
namespace VehicleShowroom.Entity
{
    public class SportsVehicle : Vehicle
    {
        SportsVehicle()
        {
            this.EngineType = EngineType.Oil;
        }

        public dynamic Turbo { get; set; }
    }
}
