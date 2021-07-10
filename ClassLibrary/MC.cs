using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{/// <summary>
/// Child class MC
/// </summary>
    public class MC: Vehicle
    {
        /// <summary>
        /// properties of MC
        /// </summary>
        //public string LicensePlate { get; set; }
        //public DateTime Date { get; set; }
        private double price = 125;
        /// <summary>
        /// constructor of MC class
        /// </summary>
        public MC(string licensePlate, DateTime date, bool brobizz, bool weekenddiscount)
            :base(licensePlate, date, brobizz, weekenddiscount)
        {
            LicensePlate = licensePlate;
            Date = date;
            Brobizz = brobizz;
            weekendDiscount = weekenddiscount;
        }
        /// <summary>
        /// Price method for the MC class
        /// </summary>
        /// <returns>double</returns>
        public override double Price()
        {
            if(Brobizz == true)
            {
                price = 118.5;
            }
            return price;
        }
        /// <summary>
        /// VehicleType method for the MC class
        /// </summary>
        /// <returns>string</returns>
        public string VehicleType()
        {
            return "MC";
        }
    }
}
