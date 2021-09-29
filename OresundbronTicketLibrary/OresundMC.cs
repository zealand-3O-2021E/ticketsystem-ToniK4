using System;
using ClassLibraryTicketSystem;
namespace OresundbronTicketLibrary
{
    public class OresundMC : MC
    {
        public override double Price()
        {
            double FinalPrice = 210;
            if (Brobizz)
            {
                FinalPrice = 73;
            }
            return FinalPrice;
        }

        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}
