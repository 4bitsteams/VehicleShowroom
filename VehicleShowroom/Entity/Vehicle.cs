using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleShowroom.Common.Enum;

namespace VehicleShowroom.Entity
{
    public abstract class Vehicle : EntityBase
    {
        private EngineType __EngineType { get; set; }

        public String ModelNumber { get; set; }
        public EngineType EngineType
        {
            get
            {
                return __EngineType;
            }
            protected set
            {
                __EngineType = value;
            }
        }

        public Double EnginePower { get; set; }
        public Double TireSize { get; set; }
    }
}
