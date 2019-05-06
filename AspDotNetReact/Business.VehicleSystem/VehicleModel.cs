﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Business.VehicleSystem.Model
{
    public class VehicleModel
    {
        public string Model { get; set; }
        public string Make { get; set; }
        public string VehicleType { get; set; }
        public string Engine { get; set; }
        //   public int NumberOfDoors { get; set; }
        public int WheelsCount { get; set; }
        public string BodyType { get; set; }
        public VehicleProperties VehicleProperties{get;set;}
    }
    public class VehicleProperties
    {
        public int? NumberofDoors { get; set; }
        public int? PassengerSeats { get; set; }
      
    }
}