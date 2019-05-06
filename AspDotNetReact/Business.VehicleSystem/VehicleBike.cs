using System;
using System.Collections.Generic;
using System.Text;
using Business.VehicleSystem.Interface;
using Business.VehicleSystem.Model;

namespace Business.VehicleSystem
{
    public class VehicleBike : IVehicleType
    {
        public void Save(VehicleModel data)
        {
            data.BodyType = "metal";
            data.Engine = "Strong";
            
            //implement save functionality with business if any
        }
    }
}
