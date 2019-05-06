using AspDotNetReact.Interface;
using Business.VehicleSystem.Model;
using System;

namespace AspDotNetReact.Models
{
    public class Vehicle
    {
        IVehicleType _vehicleType;
        public string Model { get; set; }
        public string Make { get; set; }
        public string VehicleType { get; set; }
        public string Engine { get; set; }
        //   public int NumberOfDoors { get; set; }
        public int WheelsCount { get; set; }
        public string BodyType { get; set; }
        public Vehicle(IVehicleType vehicleType)
        {
            _vehicleType = vehicleType;
        }

        public void start()
        {
            Console.WriteLine("start the vehicle");
        }
        public void Brake()
        {
            Console.WriteLine("Stop the vehicle");
        }
        public void Accelerate()
        {
            Console.WriteLine("Accelerate the vehicle");
        }
        //put all the common functions but diffrent implementation in  abstract method.  
        //public abstract double price();
        //public abstract int getTotalSeat();
        //public abstract string colors();
        public void CreateVehicle(VehicleModel data)
        {

            _vehicleType.Save(data);
        }
    }
}