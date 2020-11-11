using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Truck : IVehicle, ICompany
    {
        public Truck()
        {
        }

        public Truck(int year, string compaName, string model, string logo, int doorCount, int wheelCount, double bedSize, bool fthWheelHitch)
        {
            Year = year;
            CompaName = compaName;
            Model = model;
            Logo = logo;
            DoorCount = doorCount;
            WheelCount = wheelCount;
            BedSize = bedSize;
            FthWheelHitch = fthWheelHitch;
        }

        public double BedSize { get; set; }
        public bool FthWheelHitch { get; set; }
        public int WheelCount { get; set; }
        public int DoorCount { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Logo { get; set; }
        public string CompaName { get; set; }
        
    }
}
