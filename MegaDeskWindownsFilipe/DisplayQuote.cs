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
            List<DeskQuote> deskQuotes = new List<DeskQuote>();

            //Read from the existing file
            if (File.Exists(quotesFile))
            {
                using(StreamReader reader = new StreamReader(quotesFile))
                {
                    //load the quotes to string
                    string quotes = reader.ReadToEnd();

                    //test
                    Console.WriteLine("Read from the file " + quotes);

                    if(quotes.Length > 0)
                    {
                        deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);
                    }
                }
            }

            //test
            Console.WriteLine("Create the file " + quote.ToString());

            //add to the list
            deskQuotes.Add(quote);

            //call the file save method
            saveToFile(deskQuotes);

        }

        /// <summary>
        /// Save the passed list to the file when it gets 
        /// updated
        /// </summary>
        /// <param name="deskQuotes"></param>
        private void saveToFile(List<DeskQuote> deskQuotes)
        {

        }
    }
}
