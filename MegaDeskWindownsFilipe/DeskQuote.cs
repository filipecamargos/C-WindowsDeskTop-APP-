using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDeskWindownsFilipe
{
    public enum Shipping
    {
        NoRush,
        Rush3Days,
        Rush5Days,
        Rush7Day,
    }

    class DeskQuote
    {
        public string CustomerName { get; set; }

        public DateTime QuoteDate { get; set; }

        public Shipping Shipping { get; set; }

        public Desk Desk { get; set; }

        public decimal GetQuotePrice()
        {
            decimal area;
            try
            {
                area = Desk.DeskArea();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.ToString());
            }

            //TO DO
            return 0;
        }

        private decimal getMaterialPrice()
        {
            //TO DO
            return 0;
        }

        private decimal getShippingPrice()
        {
            //TO DO
            return 0;
        }
    }
}
