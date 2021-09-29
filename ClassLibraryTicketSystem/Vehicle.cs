using System;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// Abstract superclass of vehicles.
    /// </summary>
    public abstract class Vehicle
    {
        private string _licenseplate;

        /// <summary>
        /// Returns a string of the vehicle's License plate.
        /// Can't be longer than 7.
        /// </summary>
        public string Licenseplate
        {
            get => _licenseplate;
            set
            {
                if (value.Length > 7)
                {
                    throw new ArgumentException("License plate string should not be longer than 7 characters.");
                }

                _licenseplate = value;
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
