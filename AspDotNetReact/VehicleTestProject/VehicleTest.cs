using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business.VehicleSystem.Model;
using AspDotNetReact.Domain;

namespace VehicleTestProject
{
    [TestClass]
    public class VehicleTest
    {
        VehicleModel vm = new VehicleModel
        {
            Model = "ABC",
            Make = "TEST",
            WheelsCount = 10,
            BodyType = "DEF",
            Engine = "Double",
            VehicleType = "Car",
            VehicleProperties=new VehicleProperties
            {
                NumberofDoors=4,
                PassengerSeats=4
            }
        };
        VehicleModel bikeVehicle = new VehicleModel
        {
            Model = "ABC",
            Make = "TEST",
            WheelsCount = 2,
            BodyType = "DEF",
            Engine = "Double",
            VehicleType = "Bike"
        };
        /// <summary>
        /// Create Car Vehicle
        /// </summary>
        [TestMethod]
        public void CreateCarVehicle()
        {
            
            ExtensionHelper.CreateVehicle(vm);
        }
        /// <summary>
        /// Create Bike Vehicle
        /// </summary>
        [TestMethod]
        public void CreateBikeVehicle()
        {

            ExtensionHelper.CreateVehicle(bikeVehicle);
        }

    }
}
