using System;
using System.Collections.Generic;

namespace TokenWebAPI.Models
{
    interface IVehicles
    {
        int year { get; set; }
        string Make { get; set; }
        string Model { get; set; }
        string VinNumber { get; set; }
        public bool ValidateVehicles();
    }
    interface ILandVehicles : IVehicles
    {
        string LicensePlateNumber { get; set; }
    }

    interface IWaterVehicles : IVehicles
    {
        string Type { get; set; }
        string NauticalRegistrationNumber { get; set; }
    }

    public class LandVehicles : ILandVehicles
    {
        int IVehicles.year { get; set; }
        string IVehicles.Make { get; set; }
        string IVehicles.Model { get; set; }
        string IVehicles.VinNumber { get; set; }
        string ILandVehicles.LicensePlateNumber { get; set; }
        public bool ValidateVehicles()
        {
            return true;
        }
    }
    public class WaterVehicles : IWaterVehicles
    {
        int IVehicles.year { get; set; }
        string IVehicles.Make { get; set; }
        string IVehicles.Model { get; set; }
        string IVehicles.VinNumber { get; set; }
        string IWaterVehicles.Type { get; set; }
        string IWaterVehicles.NauticalRegistrationNumber { get; set; }
        public bool ValidateVehicles()
        {
            return true;
        }
    }
}
