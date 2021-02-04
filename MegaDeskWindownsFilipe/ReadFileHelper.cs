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
    }
}
