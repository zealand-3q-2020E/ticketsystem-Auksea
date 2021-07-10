using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{/// <summary>
/// base class Vehicle
/// </summary>
    public class Vehicle
    {/// <summary>
     /// property LicensePlate
     /// </summary>
        public string LicensePlate { get; set; }
        /// <summary>
        /// property Date
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// prop price
        /// </summary>
        private double price;
        /// <summary>
        /// prop brobizz
        /// </summary>
        public bool Brobizz { get; set; }
        /// <summary>
        /// prop weekenddiscount
        /// </summary>
        public bool weekendDiscount { get; set; }
        /// <summary>
        /// base class constructor
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <param name="date"></param>
        /// <param name="brobizz"></param>
        /// <param name="weekenddiscount"></param>
        public Vehicle(string licensePlate, DateTime date, bool brobizz, bool weekenddiscount)
        {
            LicensePlate = licensePlate;
            Date = date;
            Brobizz = brobizz;
            weekendDiscount = weekenddiscount;
        }
        /// <summary>
        /// base class method Price, it has to be virtual to be possible to override it in child classes
        /// </summary>
        /// <returns>double</returns>
        public virtual double Price()
        {
            return price;
        }
        /// <summary>
        /// License Plate Length exception, if character number is longer than 7 the number is incorrect
        /// </summary>
        public string LicensePlateLength
        {
            get { return LicensePlate; }
            set
            {
                if (LicensePlate.Length <= 7)
                {
                    Console.WriteLine("License Plate number is: " + LicensePlate);
                }
                else
                {
                    throw new ArgumentException("License Plate number is incorrect");

                }
            }
        }
        /// <summary>
        /// base class method for the weekenddiscount
        /// </summary>
        /// <returns>boolean</returns>
        //public bool WeekendDiscount()
        //{
        //    return weekendDiscount;
        //}
        
    }
}
