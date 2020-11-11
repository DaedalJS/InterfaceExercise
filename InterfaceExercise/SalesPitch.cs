using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics;
using System.Text;

namespace InterfaceExercise
{
    static class SalesPitch
    {
        public static void VehSales(Car x)
        {
            Console.WriteLine($"{x.Year} {x.CompaName} {x.Logo} {x.Model}: {x.WheelCount} good wheels, {x.DoorCount} doors, {x.TrunkSize} cubic feet of trunk space.");
            if (x.HasEntSys == true) { Console.WriteLine("and it has a built in entertainment system to boot!\n"); }
            else { Console.WriteLine("\n"); }
        }
        public static void VehSales(SUV x)
        {
            Console.WriteLine($"{x.Year} {x.CompaName} {x.Logo} {x.Model}: {x.WheelCount} good wheels, {x.DoorCount} doors, {x.CargoHoldSize} cubic feet of cargo space.");
            if (x.SpareTire == true) { Console.WriteLine("and unlike some newer models it comes with an actual spare tire instead of a can of fix-a-flat!\n"); }
            else { Console.WriteLine("\n"); }
        }
        public static void VehSales(Truck x)
        {
            Console.WriteLine($"{x.Year} {x.CompaName} {x.Logo} {x.Model}: {x.WheelCount} good wheels, {x.DoorCount} doors, {x.BedSize} cubic feet of bed space.");
            if (x.FthWheelHitch == true) { Console.WriteLine("and if you want to haul a large camper it's already got a fifth wheel hitch installed.\n"); }
            else { Console.WriteLine("\n"); }
        }

    }
}
