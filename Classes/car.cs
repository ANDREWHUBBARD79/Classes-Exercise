using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Car
    {
        public Car() //special member method that has the same as its class
        {
        }

        public Car(string make, string model, int year)

        { 
        Make = make;
        Model = model;
        Year = year;
        }

        //fields
        //properties
        //Methods

        //Create a Make Property of Type String that is Public
        public string Make { get; set; } //get = read set = write
        public string Model { get; set; }
        public int Year { get; set; }

    }

       

       
}

