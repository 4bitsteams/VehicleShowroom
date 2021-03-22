using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleShowroom.Common.Enum;
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

        public static void ExecuteCommand(int UserCommand)
        {
            if (UserCommand == (int)Commandtype.Add)
            {
                Console.WriteLine("You Press 1");
            }
            else if (UserCommand == (int)Commandtype.Remove)
            {
                Console.WriteLine("You Press 2");
            }
            else if (UserCommand == (int)Commandtype.ShowVehicleList)
            {
                Console.WriteLine("You Press 3");
            }
            else if (UserCommand == (int)Commandtype.ClearCommandLine)
            {
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Please Press Command Between 1 and 5");
            }
        }

        public static void CommandLineHelpInstruction()
        {
            Console.WriteLine("Press 1 for Add Vehicle");
            Console.WriteLine("Press 2 for Remove Vehicle");
            Console.WriteLine("Press 3 for Show Vehicle List");
            Console.WriteLine("Press 4 for Exit");
            Console.WriteLine("Press 5 for Clear Command Line");
            Console.WriteLine();
        }

        //ToDo it is not permanent Solution . if property value length is more large then grid size will  broken . 
        public static void ShowVechileList(List<Vehicle> vehicles)
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
            Console.WriteLine("--------------------------------------------------------------------------------------");
        }
    }
}
