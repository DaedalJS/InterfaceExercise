using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Car : IVehicle, ICompany
    {
        public Car()
        {
        }

        public Car(int year, string compaName, string model, string logo, int doorCount, int wheelCount, double trunkSize, bool hasEntSys)
        {
            Year = year;
            CompaName = compaName;
            Model = model;
            Logo = logo;
            DoorCount = doorCount;
            WheelCount = wheelCount;
            TrunkSize = trunkSize;
            HasEntSys = hasEntSys;
            
        }

        public double TrunkSize { get; set; }
        public bool HasEntSys { get; set; }
        public int WheelCount { get; set; }
        public int DoorCount { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Logo { get; set; }
        public string CompaName { get; set; }
       
    }
}
