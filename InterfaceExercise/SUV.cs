using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class SUV : IVehicle , ICompany
    {
        public SUV()
        {
        }

        public SUV(int year, string compaName, string model, string logo, int doorCount, int wheelCount, double cargoHoldSize, bool spareTire)
        {
            Year = year;
            CompaName = compaName;
            Model = model;
            Logo = logo;
            DoorCount = doorCount;
            WheelCount = wheelCount;
            CargoHoldSize = cargoHoldSize;
            SpareTire = spareTire;
        }

        public double CargoHoldSize { get; set; }
        public bool SpareTire { get; set; }
        public int WheelCount { get; set; }
        public int DoorCount { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Logo { get; set; }
        public string CompaName { get; set; }
    }
}
