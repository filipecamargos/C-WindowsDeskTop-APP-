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
            decimal basePrice = 200;
            decimal drawersPrice = 50 * Desk.NumberOfDrawers;
            
            decimal area;
            try
            {
                area = Desk.SurfaceArea;
            }
            catch (Exception e)
            {

                Console.WriteLine(e.ToString());
            }

            //TO DO
            return basePrice + drawersPrice + getMaterialPrice() + getShippingPrice();
        }

        private decimal getMaterialPrice()
        {
            // Calculate price for large Desk
            decimal extraCostPerSquare = Desk.SurfaceArea > 1000 ? Desk.SurfaceArea - 1000 : 0;
            
            // Calculate Surface material price
            switch (Desk.SurfaceMaterial)
            {
                case SurfaceMaterial.Laminate:
                    return 100 + extraCostPerSquare;
                case SurfaceMaterial.Oak:
                    return 200 + extraCostPerSquare;
                case SurfaceMaterial.Rosewood:
                    return 300 + extraCostPerSquare;
                case SurfaceMaterial.Veneer:
                    return 125 + extraCostPerSquare;
                case SurfaceMaterial.Pine:
                    return 50 + extraCostPerSquare;
                default:
                    return 0;
            }
        }

        private decimal getShippingPrice()
        {
            //Desk are less than a 1000
            if(Desk.SurfaceArea < 1000)
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
            else if (Desk.SurfaceArea >= 1000 && Desk.SurfaceArea <= 2000)
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
            else if (Desk.SurfaceArea > 2000)
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
