using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleShowroom.Entity;

namespace VehicleShowroom.Common.Utils
{
    public static partial class Q
    {
        public static long GetNextId(List<Vehicle> entities)
        {
            if (entities == null || !(entities.Count > 0))
                return 1;
            return entities.Max(x => x.Id) + 1;
        }
    }
}
