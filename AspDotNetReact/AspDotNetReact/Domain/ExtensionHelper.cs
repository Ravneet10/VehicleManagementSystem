using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Business.VehicleSystem.Interface;
using Business.VehicleSystem;
using Business.VehicleSystem.Model;

namespace AspDotNetReact.Domain
{
    public static  class ExtensionHelper
    {
        public static  List<VehicleModel> historyData = new List<VehicleModel>();
        public enum VehicleType
        {
            Car,
            Bike,
            
            Default
        }
        #region Members

        private static Dictionary<VehicleType, IVehicleType> _strategies =
            new Dictionary<VehicleType, IVehicleType>();

        #endregion

        #region Ctor

        public static void CreateList()
        {
            _strategies =
             new Dictionary<VehicleType, IVehicleType>();
            _strategies.Add(VehicleType.Car, new VehicleCar());                               
           _strategies.Add(VehicleType.Bike, new VehicleBike());
            _strategies.Add(VehicleType.Default, new DefaultVehicle());

        }

        #endregion
        public static void CreateVehicle(VehicleModel vehicleTypeData)
        {
            VehicleType vehicleType;
            CreateList();
            if (!Enum.IsDefined(typeof(VehicleType), vehicleTypeData.VehicleType))
                vehicleType = VehicleType.Default;
            else
            Enum.TryParse(vehicleTypeData.VehicleType, out vehicleType);

            if (_strategies.ContainsKey(vehicleType))
                _strategies[vehicleType].Save(vehicleTypeData);
            
        }

    }
}