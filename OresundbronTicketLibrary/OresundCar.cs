using System;
using ClassLibraryTicketSystem;
namespace OresundbronTicketLibrary
{

    public class OresundCar : Car
    {
        public override double Price()
        {
            double FinalPrice = 410;
            if (Brobizz)
            {
                FinalPrice = 161;
            }
            return FinalPrice;
        }

        public override string VehicleType()
        {
            return "Oresund car";
        }
    }
}
