using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDeskWindownsFilipe
{
    /// <summary>
    /// Provide the shipping options
    /// </summary>
    public enum Shipping
    {
        [Description("14 days (no rush)")]
        NoRush,

        [Description("7 days")]
        Rush7Days,

        [Description("5 days")]
        Rush5Days,

        [Description("3 days")]
        Rush3Days      
    }

    /// <summary>
    /// DeskQuote class will hold the data and information
    /// for quote as well the values of it and the Desk type
    /// </summary>
    public class DeskQuote
    {
        //Requirement based prices
        private const decimal BASE_PRICE = 200;
        private const decimal DRAWER_PRICE = 50;
        private const decimal MAX_FREE_SURFACE_AREA = 50;

        //Creates a dictionary of the rush prices
        public static Dictionary<string, Shipping> shippingDict
            = new Dictionary<string, Shipping> {
                { "14 day (no rush)", Shipping.NoRush },
                { "7 day", Shipping.Rush3Days },
                { "5 day", Shipping.Rush5Days },
                { "3 day", Shipping.Rush7Days }
            };

        //DeskQuote properties
        public string CustomerName { get; set; }
        public Shipping Shipping { get; set; }
        public Desk Desk { get; set; }
        public DateTime QuoteDate { get; set; }


        public decimal QuotePrice
        {
            get
            {
                if (quotePrice == -1)
                    quotePrice = calculateQuotePrice();
                
                return quotePrice;
            }
            set { }
        }

        private decimal quotePrice = -1;

        public DeskQuote()
        {
            CustomerName = "anonymous";
            Shipping = Shipping.NoRush;
            Desk = new Desk();
            QuoteDate = DateTime.Today; // change this to an outrageous date?
        }

        public DeskQuote(string customerName, Shipping rushOrderOption, Desk desk, DateTime date)
        {
            CustomerName = customerName;
            Shipping = rushOrderOption;
            Desk = desk;
            QuoteDate = date;
        }

        private decimal calculateQuotePrice()
        {
            decimal basePrice = BASE_PRICE;

            return basePrice + getDrawersPrice() + getSurfaceAreaPrice()
                   + getMaterialPrice() + getShippingPrice();
        }

        private decimal getDrawersPrice()
        {
            return DRAWER_PRICE * Desk.NumberOfDrawers;
        }

        private decimal getSurfaceAreaPrice()
        {
            return Desk.SurfaceArea > MAX_FREE_SURFACE_AREA ? Desk.SurfaceArea - MAX_FREE_SURFACE_AREA : 0;
        }

        private decimal getMaterialPrice()
        {
            // Calculate Surface material price
            switch (Desk.SurfaceMaterial)
            {
                case SurfaceMaterial.Pine:
                    return 50;
                case SurfaceMaterial.Laminate:
                    return 100;
                case SurfaceMaterial.Veneer:
                    return 125;
                case SurfaceMaterial.Oak:
                    return 200;
                case SurfaceMaterial.Rosewood:
                    return 300;
                default:
                    return 0;
            }
        }

        private decimal getShippingPrice()
        {
            /*  
            Shipping Price Array Visualization

            |Shipping |     Size of Desk (in^2)           |
            |---------|-----------------------------------|
            |         |    0-1000 | 1001-2000 | 2001-inf  |
            |---------|-----------+-----------|-----------|
            | 3 Day   |    $ 60   |    $ 70   |    $ 80   |
            | 5 Day   |    $ 40   |    $ 50   |    $ 60   |
            | 7 Day   |    $ 30   |    $ 35   |    $ 40   |
*/
            int[,] shippingPrices = { { 0,   0,  0},
                                      { 30, 35, 40 }, 
                                      { 40, 50, 60},
                                      { 60, 70, 80 }};
            int rushIndex = (int)Shipping;
            int sizeIndex = (int)Desk.SurfaceArea > 2000 ? 3 : ((int)(Desk.SurfaceArea - 1) / 1000);
            decimal shippingPrice = shippingPrices[rushIndex, sizeIndex];
            
            return shippingPrice;
        }
    }
}
