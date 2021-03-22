using System;
using System.Collections.Generic;
using VehicleShowroom.Common.Enum;
using VehicleShowroom.Entity;
using VehicleShowroom.Factory;
using VehicleShowroom.Manager;
using VehicleShowroom.Repository;

namespace VehicleShowroom
{
    class Program
    {
        private readonly static List<Vehicle> vehicles;
        private readonly static VehicleManager vehicleManager;

        static Program()
        {
            vehicleManager = new VehicleManager
                 (
                new VehicleRepository(),
                new VehicleFactory());
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
                   Turbo="v18"
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
            //vehicleManager.ShowVechileList(vehicles);

            while (true)
            {
                vehicleManager.CommandLineHelpInstruction();
                Console.WriteLine("Please Press Command");
                int UserCommand;
                try
                {
                    UserCommand = Convert.ToInt32(Console.ReadLine());
                    if (UserCommand == (int)Commandtype.Exit)
                    {
                        Console.WriteLine("You Press 4");
                        break;
                    }
                    else
                    {
                        vehicleManager.ExecuteCommand(UserCommand);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
