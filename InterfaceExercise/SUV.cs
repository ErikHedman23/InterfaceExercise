﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise 
{
    public class SUV : IVehicle, ICompany
    {
        public  bool isFullSize {  get; set; }
        public int numOfSeats { get; set; }
    public int Year { get ; set ; }
    public string Make { get ; set ; }
    public string Model { get ; set ; }
    public string Color { get;  set; }
    public string Logo { get ; set ; }
    public string luxuryModel { get ; set; }
}
}