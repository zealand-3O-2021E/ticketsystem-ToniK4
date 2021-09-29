using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// Base class for other tickets
    /// </summary>
    public abstract class BaseTicket
    {
        /// <summary>
        /// constant defining brobuzz discount. now - 5%
        /// </summary>
        protected const int broBuzzDiscount = 5;
        private string _licensePlate;
        
        /// <summary>
        /// Throws exception if you try to set licenseplate longer than 7 cahracters
        /// </summary>
        public string LicensePlate

        {
            get { return _licensePlate; }
            set 
            { 
                try 
                {
                    if (value.Length > 7)
                        throw new ArgumentException("LicensePlate should not be longer than 7 characters");
                    _licensePlate = value; 
                }
                catch (ArgumentException) { throw; }
            }
        }
        /// <summary>
        /// boolean saying whether brobuzz discount has been used
        /// </summary>
        public bool Brobuzz { get; set; }
        /// <summary>
        /// Date - when the ticket is valid
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// method returns the price of the crossing
        /// </summary>
        /// <returns>double</returns>
        public abstract double Price();
        /// <summary>
        /// returns the type of crossing veichle
        /// </summary>
        /// <returns>string </returns>
        public abstract string VeichleType();

        /// <summary>
        /// private method to calculate discount
        /// uses constant int which specifies discount in percents ( 5 means 5% discount)
        /// has an overload where you can choose another percentage as discount
        /// </summary>
        /// <param name="price"> takes original price</param>
        /// <returns> price with discount</returns>
        protected double Discount(double price)
        {
            return price* (1 - broBuzzDiscount / 100.0);
        }
        /// <summary>
        /// overload of the method allows to calculate the price after specific discount
        /// </summary>
        /// <param name="price"></param>
        /// <param name="discount"></param>
        /// <returns></returns>
        protected double Discount(double price,int discount)
        {
            return price*(1-discount/100.0);
        }
        
    }
}

