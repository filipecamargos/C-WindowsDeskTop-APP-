using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace MegaDeskWindownsFilipe
{
    class ReadFileHelper
    {
        /// <summary>
        /// Reads and deserializes desk quote objects into a list from the
        /// supplied file (returns empty list if file does not exist)
        /// </summary>
        public static List<DeskQuote> GetQuotesFromFile(in string quotesFile)
        {
            List<DeskQuote> quotes = new List<DeskQuote>();

            //Read from the existing file
            if (File.Exists(quotesFile))
            {
                using (StreamReader reader = new StreamReader(quotesFile))
                {
                    //load the quotes to string
                    string quotesString = reader.ReadToEnd();

                    if (quotesString.Length > 0)
                        quotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotesString);
                }
            }
            return quotes;
        }

        /// <summary>
        /// Takes the array and the read the prices into it to 
        /// update that in our program
        /// </summary>
        /// <param name="shippingPrices"></param>
        /// <param name="pricefile"></param>
        public static int[,] UpdateRushPrices(in string pricefile)
        {
            //Initialize the array with the default prices
            int[,] newShippingPrice = { { 0,   0,  0},
                                      { 30, 35, 40 },
                                      { 40, 50, 60},
                                      { 60, 70, 80 }};

            //Read from the existing file
            if (File.Exists(pricefile))
            {
                using (StreamReader reader = new StreamReader(pricefile))
                {
                     //Read the file into the array
                    for(int i = 1; i < 4; i ++)
                    {
                        for(int j = 0; j < 3; j++)
                        {
                            newShippingPrice[i, j] = int.Parse(reader.ReadLine());
                        }
                    }
                }
            }

            return newShippingPrice;
        }
    }
}
