using System;
using System.Collections.Generic;
using VehicleShowroom.Entity;

namespace VehicleShowroom
{
    class Program
    {
        private readonly static List<Vehicle> vehicles;

        static Program()
        {
            vehicles = new List<Vehicle>()
            {
                new NormalVehicle
                {
                    Id=1,
                    EnginePower=10,
                    ModelNumber="v12",
                    TireSize=120
                },
               new SportsVehicle
                {
                    Id=2,
                   EnginePower=12,
                   ModelNumber="v18",
                   TireSize=130,
                   Turbo="v18 Turbo"
                },
               new HeavyVehicle
               {
                   Id=3,
                   EnginePower=14,
                   ModelNumber="v20",
                   TireSize=100,
                   Weight=120
               }
            };
        }
        static void Main()
        {
            Console.Write("Id");
            Console.Write("\t" + "EnginePower");
            Console.Write("\t" + "EngineType");
            Console.Write("\t" + "ModelNumber");
            Console.Write("\t" + "TireSize");
            Console.Write("\t" + "Turbo");
            Console.Write("\t" + "Weight");
            Console.WriteLine();
            foreach (var item in vehicles)
            {
                Console.Write(item.Id);
                Console.Write("\t"+item.EnginePower);
                Console.Write("\t" + item.EngineType);
                Console.Write("\t" + item.ModelNumber);
                Console.Write("\t" + item.TireSize);
                
                if (item.GetType() == typeof(NormalVehicle))
                {
                    Console.Write("\t" + "-");
                    Console.Write("\t" + "-");
                }
                else if (item.GetType() == typeof(SportsVehicle))
                {
                    var items = (SportsVehicle)item;
                Console.Write("\t"+items.Turbo);
                    Console.Write("\t" + "-");
                }
                else if (item.GetType() == typeof(HeavyVehicle))
                {
                    HeavyVehicle items = (HeavyVehicle)item;
                    Console.Write("\t" + "-");
                    Console.Write("\t"+items.Weight);
                }

                Console.WriteLine();
            }
            
            Console.ReadKey();
        }
    }
}
