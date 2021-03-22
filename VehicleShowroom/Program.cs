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
        private static List<Vehicle> vehicles;
        private static VehicleManager vehicleManager;
        private static long TotalVisitor;

        static Program()
        {
            TotalVisitor = 30;
            vehicleManager = new VehicleManager
                 (
                new VehicleRepository(),
                new VehicleFactory());
            vehicles = vehicleManager.InItVehicles(new List<Vehicle>());
        }


        static void Main()
        {
            vehicleManager.CommandLineHelpInstruction();
            while (true)
            {
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
                        vehicleManager.ExecuteCommand(UserCommand, ref vehicleManager, ref vehicles, ref TotalVisitor);
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
