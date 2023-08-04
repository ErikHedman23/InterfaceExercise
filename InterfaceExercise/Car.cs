using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public int numberOfDoors { get; set; }
        public bool hasNewTires { get; set; }
        public int Year { get ; set ; }
        public string Make { get ; set ; }
        public string Model { get ; set ; }
        public string Color { get ; set ; }
        public string Logo { get ; set ; }
        public string luxuryModel { get ; set ; }
        
    }
}
