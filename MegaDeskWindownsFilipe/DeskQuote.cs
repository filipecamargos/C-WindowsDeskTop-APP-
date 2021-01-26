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
            return 0;

        }

        private decimal getShippingPrice()
        {
            //Desk are less than a 1000
            if(Desk.DeskArea() < 1000)
            {
                switch (Shipping)
                {
                    case Shipping.Rush3Days:
                        return 60;
                    case Shipping.Rush5Days:
                        return 40;
                    case Shipping.Rush7Day:
                        return 30;
                }
            }

            //Shipping area between 1000 and 2000
            else if (Desk.DeskArea() >= 1000 && Desk.DeskArea() <= 2000)
            {
                switch (Shipping)
                {
                    case Shipping.Rush3Days:
                        return 70;
                    case Shipping.Rush5Days:
                        return 50;
                    case Shipping.Rush7Day:
                        return 35;
                }
            }
            //Shipping area between 1000 and 2000
            else if (Desk.DeskArea() > 2000)
            {
                switch (Shipping)
                {
                    case Shipping.Rush3Days:
                        return 80;
                    case Shipping.Rush5Days:
                        return 60;
                    case Shipping.Rush7Day:
                        return 40;
                }
            }
            //If there is not rush just return
            return 0;
        }
    }
}
