using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{/// <summary>
/// child class Car
/// </summary>
    public class Car: Vehicle
    {
        /// <summary>
        /// properties
        /// </summary>
        //public string LicensePlate { get; set; }
        //public DateTime Date { get; set; }
        private double price = 240;
        
        /// <summary>
        /// constructor of a car class
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <param name="date"></param>
        /// <param name="brobizz"></param>
        /// <param name="weekenddiscount"></param>
        public Car(string licensePlate, DateTime date, bool brobizz, bool weekenddiscount)
            :base(licensePlate, date, brobizz, weekenddiscount)
        {
            LicensePlate = licensePlate;
            Date = date;
            Brobizz = brobizz;
            weekendDiscount = weekenddiscount;
        }
        /// <summary>
        /// price method
        /// </summary>
        /// <returns>double</returns>
        public override double Price()
        {
            if(Brobizz == true)
            {
                price = 228;
            }
            else if (weekendDiscount == true)
            {
                price = 192;
            }
            return price;
        }
        /// <summary>
        /// vehicle type method
        /// </summary>
        /// <returns>string</returns>
        public string VehicleType()
        {
            return "Car";
        }
    }
}
