﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleShowroom.Common.Enum;
using VehicleShowroom.Common.Utils;
using VehicleShowroom.Entity;
using VehicleShowroom.Factory;
using VehicleShowroom.Repository;

namespace VehicleShowroom.Manager
{
    public class VehicleManager
    {
        private readonly VehicleRepository __vehicleRepository;
        private readonly VehicleFactory __vehicleFactory;

        public VehicleManager(VehicleRepository vehicleRepository, VehicleFactory vehicleFactory)
        {
            this.__vehicleRepository = vehicleRepository;
            this.__vehicleFactory = vehicleFactory;
        }
        public long Add(Vehicle entity, ref List<Vehicle> entities)
        {
            return __vehicleRepository.Add(entity, ref entities);
        }

        public bool Remove(object id, ref List<Vehicle> entities)
        {
            return __vehicleRepository.Remove(id, ref entities);
        }

        public List<Vehicle> GetAll(ref List<Vehicle> entities)
        {
            return __vehicleRepository.GetAll(ref entities);
        }

        public long GetNextId(List<Vehicle> entities)
        {
            return Q.GetNextId(entities);
        }

        public Vehicle GetVehicle(VehicleType vehicleType)
        {
            return __vehicleFactory.GetVehicle(vehicleType);
        }

        public void ShowVechileList(List<Vehicle> vehicles)
        {
            Q.ShowVechileList(vehicles);
        }

        public void CommandLineHelpInstruction()
        {
            Q.CommandLineHelpInstruction();
        }

        public void ExecuteCommand(int UserCommand)
        {
            Q.ExecuteCommand(UserCommand);
        }
    }
}
