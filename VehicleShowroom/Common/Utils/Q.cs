using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleShowroom.Common.Enum;
using VehicleShowroom.Entity;
using VehicleShowroom.Manager;

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


        public static ref Vehicle SetVehicleTypeWiseData(ref Vehicle vehicle, ref long TotalVisitor)
        {
            if (vehicle.GetType() == typeof(NormalVehicle))
            {

            }
            else if (vehicle.GetType() == typeof(SportsVehicle))
            {
                TotalVisitor = TotalVisitor + 20;
                var SportsVehicle = (SportsVehicle)vehicle;
                Console.WriteLine("Give Vehicle Turbo");
                SportsVehicle.Turbo = Console.ReadLine();
                vehicle = SportsVehicle;
            }
            else if (vehicle.GetType() == typeof(HeavyVehicle))
            {
                var HeavyVehicle = (HeavyVehicle)vehicle;
                Console.WriteLine("Give Vehicle Weight");
                HeavyVehicle.Weight = Convert.ToDouble(Console.ReadLine());
                vehicle = HeavyVehicle;
            }
            return ref vehicle;
        }
        public static Vehicle SetVechileData(Vehicle vehicle, long VehicleNextId, ref long TotalVisitor)
        {
            vehicle.Id = VehicleNextId;
            Console.WriteLine("Give Vehicle Engine Power");
            vehicle.EnginePower = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Give Vehicle Model Number");
            vehicle.ModelNumber = Console.ReadLine();
            Console.WriteLine("Give Vehicle Tire Size");
            vehicle.TireSize = Convert.ToDouble(Console.ReadLine());
            vehicle = SetVehicleTypeWiseData(ref vehicle, ref TotalVisitor);

            return vehicle;
        }
        public static void VehicleTypeSelectInstruction()
        {
            Console.WriteLine("Select Vehicle Type");
            Console.WriteLine("Press 1 for Normal Vehicle");
            Console.WriteLine("Press 2 for Sports Vehicle");
            Console.WriteLine("Press 3 for Heavy Vehicle");
            Console.WriteLine("Please Press Command");
        }
        public static void CommandLineHelpInstruction()
        {
            Console.WriteLine("Press 1 for Add Vehicle");
            Console.WriteLine("Press 2 for Remove Vehicle");
            Console.WriteLine("Press 3 for Show Vehicle List");
            Console.WriteLine("Press 4 for Exit");
            Console.WriteLine("Press 5 for Clear Command Line");
            Console.WriteLine("Press 6 for Command Line Help");
            Console.WriteLine("Press 7 for Show Vehicle List With Total Visitor");
            Console.WriteLine();
        }


        public static void ExecuteCommand(int UserCommand, ref VehicleManager vehicleManager, ref List<Vehicle> vehicles, ref long TotalVisitor)
        {
            if (UserCommand == (int)Commandtype.Add)
            {
                vehicleManager.VehicleTypeSelectInstruction();
                Int32 vehicleType = Convert.ToInt32(Console.ReadLine());
                Vehicle vehicle = vehicleManager.GetVehicle((VehicleType)vehicleType);
                long VehicleNextId = vehicleManager.GetNextId(vehicles);
                vehicleManager.Add(vehicleManager.SetVechileData(vehicle, VehicleNextId, ref TotalVisitor), ref vehicles);
            }
            else if (UserCommand == (int)Commandtype.Remove)
            {
                Console.WriteLine("Use Vehicle Id for Remove Vehicle");
                vehicleManager.ShowVechileList(vehicles);
                Console.WriteLine("Please Press Vehile Id");
                object VehicleId = Convert.ToInt32(Console.ReadLine());
                vehicleManager.Remove(VehicleId, ref vehicles);
                Console.WriteLine("Remove Success VehicleId=" + VehicleId);
            }
            else if (UserCommand == (int)Commandtype.ShowVehicleList)
            {
                vehicleManager.ShowVechileList(vehicles);
            }
            else if (UserCommand == (int)Commandtype.ShowVehicleListWithTotalVisitor)
            {
                Console.WriteLine("Total Visitor Is:" + TotalVisitor);
                vehicleManager.ShowVechileList(vehicles);
            }
            else if (UserCommand == (int)Commandtype.ClearCommandLine)
            {
                Console.Clear();
            }
            else if (UserCommand == (int)Commandtype.CommandLineHelp)
            {
                vehicleManager.CommandLineHelpInstruction();
            }
            else
            {
                Console.WriteLine("Please Press Command Between 1 and 5");
            }
        }

        //All Data Is Fake or Dummy Data
        public static List<Vehicle> InItVehicles(List<Vehicle> vehicles)
        {

            vehicles.Add(new NormalVehicle
            {
                Id = 1,
                EnginePower = 10,
                ModelNumber = "v12",
                TireSize = 120
            });
            vehicles.Add(new SportsVehicle
            {
                Id = 2,
                EnginePower = 12,
                ModelNumber = "v18",
                TireSize = 130,
                Turbo = "v18"
            });
            vehicles.Add(new HeavyVehicle
            {
                Id = 3,
                EnginePower = 14,
                ModelNumber = "v20",
                TireSize = 100,
                Weight = 120
            });

            return vehicles;
        }

        public static void GenerateVehicleGridHeader()
        {
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.Write("Id");
            Console.Write("\t" + "EnginePower");
            Console.Write("\t" + "EngineType");
            Console.Write("\t" + "ModelNumber");
            Console.Write("\t" + "TireSize");
            Console.Write("\t" + "Turbo");
            Console.Write("\t" + "Weight");
            Console.WriteLine();
        }

        public static void GenerateVehicleGridBody(List<Vehicle> vehicles)
        {
            foreach (var item in vehicles)
            {
                Console.Write(item.Id);
                Console.Write("\t\t" + item.EnginePower);
                Console.Write("\t\t" + (!(item.EngineType > 0) ? "-" : item.EngineType.ToString()));
                Console.Write("\t" + item.ModelNumber);
                Console.Write("\t\t" + item.TireSize);

                if (item.GetType() == typeof(NormalVehicle))
                {
                    Console.Write("\t\t" + "-");
                    Console.Write("\t" + "-");
                }
                else if (item.GetType() == typeof(SportsVehicle))
                {
                    var items = (SportsVehicle)item;
                    Console.Write("\t\t" + items.Turbo);
                    Console.Write("\t" + "-");
                }
                else if (item.GetType() == typeof(HeavyVehicle))
                {
                    HeavyVehicle items = (HeavyVehicle)item;
                    Console.Write("\t\t" + "-");
                    Console.Write("\t" + items.Weight);
                }
                Console.WriteLine();

            }
        }

        public static void GenerateVehicleGridFooter()
        {
            Console.WriteLine("--------------------------------------------------------------------------------------");
        }

        //ToDo it is not permanent Solution . if property value length is more large then grid size will  broken . 
        public static void ShowVehicleList(List<Vehicle> vehicles)
        {
            GenerateVehicleGridHeader();
            GenerateVehicleGridBody(vehicles);
            GenerateVehicleGridFooter();
        }
    }
}
