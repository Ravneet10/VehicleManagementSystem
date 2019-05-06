using System;
using Business.VehicleSystem.Interface;
using Business.VehicleSystem.Model;
using DAL.VehicleSystem.Interface;
using DAL.VehicleSystem;
using System.Data.Entity;
using DAL.VehicleSystem.DALEntities;

namespace Business.VehicleSystem
{
   public class DefaultVehicle:IVehicleType
    {
       
        
        VehicleRepository _repo = new VehicleRepository();
        public void Save(VehicleModel data)
        {
            VehicleEntity vehicledata = new VehicleEntity();
            vehicledata = new VehicleEntity
            {
                VehicleType = data.VehicleType,
                BodyType = data.BodyType,
                Engine = data.Engine,
                Make = data.Make,
                Model = data.Model,
                WheelsCount = data.WheelsCount
            };
            // vehicledata = new AutoMapper.Mapper.Map<VehicleModel, VehicleEntity>(data, vehicledata);            
            //_repo.Save(vehicledata);

        }
    }
}
