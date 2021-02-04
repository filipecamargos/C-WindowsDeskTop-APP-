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

        //DeskQuote properties
        public string CustomerName { get; set; }
        public Shipping Shipping { get; set; }
        public decimal ShippingPrice { get; set; }
        public Desk Desk { get; set; }
        public DateTime QuoteDate { get; set; }

        //Call the quote price caculation
        public decimal QuotePrice
        {
            get
            {
                // If quote price has not been set, calculate, set,
                // and return it
                if (quotePrice == -1)
                    quotePrice = calculateQuotePrice();
                
                return quotePrice;
            }
            set { }
        }

        private decimal quotePrice = -1;

        //Default Contructor
        public DeskQuote()
        {
            CustomerName = "anonymous";
            Shipping = Shipping.NoRush;
            Desk = new Desk();
            QuoteDate = DateTime.Today;
        }

        //No Default Contructor to set up values needed
        public DeskQuote(string customerName, Shipping rushOrderOption, Desk desk, DateTime date)
        {
            CustomerName = customerName;
            Shipping = rushOrderOption;
            Desk = desk;
            QuoteDate = date;
            ShippingPrice = getShippingPrice();
        }

        /// <summary>
        /// Caculate the price of the Quote
        /// </summary>
        /// <returns></returns>
        private decimal calculateQuotePrice()
        {
            decimal basePrice = BASE_PRICE;

            return basePrice + getDrawersPrice() + getSurfaceAreaPrice()
                   + getMaterialPrice() + ShippingPrice;
        }

        //Get the Drawer Price
        private decimal getDrawersPrice()
        {
            return DRAWER_PRICE * Desk.NumberOfDrawers;
        }

        //Get the surface Price
        private decimal getSurfaceAreaPrice()
        {
            return Desk.SurfaceArea > MAX_FREE_SURFACE_AREA ? Desk.SurfaceArea - MAX_FREE_SURFACE_AREA : 0;
        }

        //Get the Material Price
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

        //Get the Shipping Price
        private decimal getShippingPrice()
        {
            /*  
            Shipping Price Array Visualization Default Price

            |Shipping |     Size of Desk (in^2)           |
            |---------|-----------------------------------|
            |         |    0-1000 | 1001-2000 | 2001-inf  |
            |---------|-----------+-----------|-----------|
            | 3 Day   |    $ 60   |    $ 70   |    $ 80   |
            | 5 Day   |    $ 40   |    $ 50   |    $ 60   |
            | 7 Day   |    $ 30   |    $ 35   |    $ 40   |
*/
            int[,] shippingPrices;

            //call the methodo to read the file
            var shippingFilename = @"rushFile.txt";
            shippingPrices = ReadFileHelper.UpdateRushPrices(shippingFilename);

            int rushIndex = (int)Shipping;
            int sizeIndex = (int)Desk.SurfaceArea > 2000 ? 2 : ((int)(Desk.SurfaceArea - 1) / 1000);
            
            return shippingPrices[rushIndex, sizeIndex];
        }
    }
}
