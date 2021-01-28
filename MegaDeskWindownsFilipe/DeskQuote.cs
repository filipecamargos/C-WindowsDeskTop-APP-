﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDeskWindownsFilipe
{
    public enum Shipping
    {
        NoRush,
        Rush7Days,
        Rush5Days,
        Rush3Days      
    }

    class DeskQuote
    {
        public static Dictionary<string, Shipping> shippingDict
            = new Dictionary<string, Shipping> {
                { "14 day (no rush)", Shipping.NoRush },
                { "7 day", Shipping.Rush3Days },
                { "5 day", Shipping.Rush5Days },
                { "3 day", Shipping.Rush7Days }
            };

        public string CustomerName { get; set; }
        public Shipping Shipping { get; set; }
        public Desk Desk { get; set; }
        public DateTime QuoteDate { get; set; }
        public decimal QuotePrice { get; set; }
        

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

        public decimal GetQuotePrice()
        {
            decimal basePrice = 200;
            
            return basePrice + getDrawersPrice() + getSurfaceAreaPrice()
                   + getMaterialPrice() + getShippingPrice();
        }

        private decimal getDrawersPrice()
        {
            return 50 * Desk.NumberOfDrawers;
        }

        private decimal getSurfaceAreaPrice()
        {
            return Desk.SurfaceArea > 1000 ? Desk.SurfaceArea - 1000 : 0;
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

        private decimal _getShippingPrice()
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
            int sizeIndex = (int)Desk.SurfaceArea / 1000;
            decimal shippingPrice = shippingPrices[rushIndex, sizeIndex];
            return shippingPrice;
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
                    case Shipping.Rush7Days:
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
                    case Shipping.Rush7Days:
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
                    case Shipping.Rush7Days:
                        return 40;
                }
            }
            //If there is not rush just return
            return 0;
        }
    }
}
