using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace MegaDeskWindownsFilipe
{
    public partial class DisplayQuote : Form
    {
        private DeskQuote quote;

        public DisplayQuote(DeskQuote quote)
        {
            InitializeComponent();
            this.quote = quote;
        }

        private void displayQuote__FormClosed(object sender, FormClosedEventArgs e)
        {
            var addQuote = new AddQuote();
            addQuote.Show();
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {

        }

        private void saveQuote_Click(object sender, EventArgs e)
        {
            AddQuoteToFile();
        }        

        /// <summary>
        /// Handle to save the quote data to the file
        /// </summary>
        private void AddQuoteToFile()
        {
            var quotesFile = @"testFile.json";

            // Get list of existing quotes (if any)
            List<DeskQuote> deskQuotes = getQuotesFromFile(quotesFile);

            // Add new quote
            deskQuotes.Add(quote);

            // Save quotes to file
            saveToFile(quotesFile, deskQuotes);
        }

        /// <summary>
        /// Reads a deserializes desk quote objects into a list from the
        /// supplied file (returns empty list if file does not exist)
        /// </summary>
        /// <param name="quotesFile"></param>
        /// <returns></returns>
        private List<DeskQuote> getQuotesFromFile(in string quotesFile)
        {
            //Read from the existing file
            if (File.Exists(quotesFile))
            {
                using (StreamReader reader = new StreamReader(quotesFile))
                {
                    //load the quotes to string
                    string quotes = reader.ReadToEnd();
                    
                    //test
                    Console.WriteLine("Read from the file " + quotes);

                    if (quotes.Length > 0)
                    {
                        return JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);
                    }
                }
            }
            return new List<DeskQuote>();
        }

        /// <summary>
        /// Serialize a list of DeskQuotes and write to a file
        /// </summary>
        /// <param name="deskQuotes"></param>
        private void saveToFile(in string quotesFile, in List<DeskQuote> deskQuotes)
        {
            using (StreamWriter writer = new StreamWriter(quotesFile))
            {
                var quotesJson = JsonConvert.SerializeObject(deskQuotes);
                writer.Write(quotesJson);
            }
        }
    }
}
