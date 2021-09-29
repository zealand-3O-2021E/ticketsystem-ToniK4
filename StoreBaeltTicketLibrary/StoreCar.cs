using System;
using ClassLibraryTicketSystem;

namespace StoreBaeltTicketLibrary
{
    public class StoreCar : Car
    {
        private const double WeekendDiscount = 0.2;

        /// <summary>
        /// Price method after weekend and brobizz if applicable.
        /// </summary>
        /// <returns></returns>
        public override double Price()
        {
            double FinalPrice = 240;
            if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
            {
                FinalPrice = FinalPrice * (1 - WeekendDiscount);
            }

            if (Brobizz)
            {
                FinalPrice = FinalPrice * (1 - _brobizzDiscount);
            }

            return FinalPrice;
        }
    }
}
