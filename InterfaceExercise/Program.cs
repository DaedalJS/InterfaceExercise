using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */
            
            //Now, create objects of your 3 classes and give their members values;

            Car v1 = new Car(2006, "Tesla", "Roadster", "(T)", 2, 4, 12, false);
            SUV v2 = new SUV(1998, "Chevvy", "Blazer", "(V)", 4, 4, 30, true);
            Truck v3 = new Truck(2004, "Ford", "F150", "(FORD)", 4, 4, 30, false);

            //Creatively display and organize their values


            string searchingFor;
            do
            {
                Console.WriteLine("would you like to look at the car, truck, or SUV? \n");
                searchingFor = Console.ReadLine();

                switch (searchingFor.ToLower())
                {
                    case "car":

                        SalesPitch.VehSales(v1);

                        break;

                    case "truck":
                        SalesPitch.VehSales(v3);
                        break;

                    case "suv":
                        SalesPitch.VehSales(v2);

                        break;

                    case "no":
                        Console.WriteLine(" alrighty then. have a nice day.\n");
                        searchingFor = "bye";
                            break;

                        default:
                        Console.WriteLine(" I'm sorry i didn't quite catch that.\n");
                        break;
                } 
            
            } while (searchingFor != "bye");



        }
    }
}
