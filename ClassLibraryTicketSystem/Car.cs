using System;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// Subclass of Vehicle.
    /// </summary>
    public class Car : Vehicle
    {

        /// <summary>
        /// Returns a double of the price of the car.
        /// </summary>
        /// <returns></returns>
        public override double Price()
        {
            double FinalPrice = 240;
            if (Brobizz)
            {
                FinalPrice = FinalPrice * (1 - _brobizzDiscount);
            }
            return FinalPrice;
        }

        /// <summary>
        /// Returns a string of the type of the vehicle.
        /// </summary>
        /// <returns></returns>
        public override string VehicleType()
        {
            return "Car";
        }
    }
}
