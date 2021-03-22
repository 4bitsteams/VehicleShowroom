using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleShowroom.Common.Enum
{
    public enum EngineType
    {
        Oil = 1,
        Gas = 2,
        Diesel = 3
    }

    public enum Commandtype
    {
        Add = 1,
        Remove = 2,
        ShowVehicleList = 3,
        Exit = 4,
        ClearCommandLine = 5
    }

    public enum VehicleType
    {
        Normal = 1,
        Sports = 2,
        Heavy = 3
    }
}
