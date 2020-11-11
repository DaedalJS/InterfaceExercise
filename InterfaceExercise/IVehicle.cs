using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    interface IVehicle
    {
        public int WheelCount { get; set; }
        public int DoorCount { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        
    }
}
