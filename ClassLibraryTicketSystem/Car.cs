using System;

namespace ClassLibraryTicketSystem
{
    public class Car
    {
        public string Licenseplate;
        public DateTime Date;

        /// <summary>
        /// Returns a double of the price of the car, which is set to 240.
        /// </summary>
        /// <returns></returns>
        public double Price()
        {
            return 240;
        }

        /// <summary>
        /// Returns a string of the type of the vehicle, which is "Car".
        /// </summary>
        /// <returns></returns>
        public string VehicleType()
        {
            return "Car";
        }
    }
}
