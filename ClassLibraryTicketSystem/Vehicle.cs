using System;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// Abstract superclass of vehicles.
    /// </summary>
    public abstract class Vehicle
    {
        /// <summary>
        /// Returns a string of the vehicle's License plate.
        /// Can't be longer than 7.
        /// </summary>
        
        public string Licenseplate
        {
            get => Licenseplate;
            set
            {
                if (value.Length > 7)
                {
                    throw new ArgumentException("License plate string should not be longer than 7 characters.");
                }

                Licenseplate = value;
            }

        }
        /// <summary>
        /// Returns a DateTime of the vehicle's date of manufacture.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Abstract method for the price of the vehicle.
        /// </summary>
        /// <returns></returns>
        public abstract double Price();

        /// <summary>
        /// Abstract method for the type of the vehicle.
        /// </summary>
        /// <returns></returns>
        public abstract string VehicleType();
    }
}
