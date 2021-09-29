﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// Subclass of Vehicle.
    /// </summary>
    public class MC : Vehicle
    {
        /// <summary>
        /// Returns a double of the price of the MC, which is set to 125.
        /// </summary>
        /// <returns></returns>
        public override double Price()
        {
            return 125;
        }

        /// <summary>
        /// Returns a string of the type of the vehicle, which is "MC".
        /// </summary>
        /// <returns></returns>
        public override string VehicleType()
        {
            return "MC";
        }
    }
}
