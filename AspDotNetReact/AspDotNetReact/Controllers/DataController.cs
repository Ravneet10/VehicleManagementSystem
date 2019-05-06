using AspDotNetReact.Domain;
using AspDotNetReact.Models;
using System.Collections.Generic;
using System.Web.Mvc;
using Business.VehicleSystem.Model;

namespace AspDotNetReact.Controllers
{
    public class DataController : Controller
    {
        List<VehicleModel> vm = new List<VehicleModel>();
       
        // GET: Data
        [HttpGet]
        public JsonResult Index()
        {
            List<Data> data = new List<Data>()
            {
                new Data(){Id = 1, Name = "Krishan",Company = "Infosys"},
                new Data(){Id=2,Name = "Preetham", Company = "Momentum"},
                new Data(){Id = 3,Name = "Vijay",Company = "Hydro"}
            };
            return Json(new { result = data }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult SaveData(VehicleModel vehicleModelData)
        {
           
            ExtensionHelper.historyData.Add(vehicleModelData);
            ExtensionHelper.CreateVehicle(vehicleModelData);
            
            return null;
        }
        [HttpPost]
        public JsonResult SaveCarData(VehicleModel vehicleModelData, VehicleProperties vehicleProperties)
        {
            vehicleModelData.VehicleProperties = new VehicleProperties
            {
                NumberofDoors = vehicleProperties.NumberofDoors,
                PassengerSeats = vehicleProperties.PassengerSeats
            };


            ExtensionHelper.historyData.Add(vehicleModelData);
            ExtensionHelper.CreateVehicle(vehicleModelData);
            return null;
        }
    }
}   