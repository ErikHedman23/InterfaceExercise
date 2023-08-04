using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public string hemiOrDiesel { get; set; }
        public bool hasExtendedCab { get; set; }
        public int Year { get ; set ; }
        public string Make { get ; set ; }
        public string Model { get ; set ; }
        public string Color { get ; set ; }
        public string Logo { get ; set ; }
        public string luxuryModel { get ; set ; }
        public void OtherTruckDetails ()
        {
            Console.WriteLine($" This {Make} {Model} is a {hemiOrDiesel}.  That's {hasExtendedCab} it does indeed have an extended cab, and it features that lovely {Logo} logo in the front.");
        }
    }
}
