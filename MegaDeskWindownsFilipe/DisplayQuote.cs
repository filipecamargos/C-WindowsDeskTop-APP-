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
        private Form mainMenuForm;
        private Form addQuoteForm;

        public DisplayQuote(DeskQuote quote, Form mainMenuForm, Form addQuoteForm)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.quote = quote;
            this.mainMenuForm = mainMenuForm;
            this.addQuoteForm = addQuoteForm;
        }

        /// <summary>
        /// Give the appearance of navigation by hiding the current form and
        /// showing the supplied form.
        /// </summary>
        /// <param name="form"></param>
        private void navigateToForm(Form form)
        {
            form.Location = this.Location;
            this.Hide();
            form.Show();
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            // populate all the labels with quote info
            dateFinal.Text = quote.QuoteDate.ToString("MMM dd, yyyy");
            nameFinal.Text = quote.CustomerName;
            shippingFinal.Text = EnumHelpers.GetDescription<Shipping>(quote.Shipping);
            widthFinal.Text = quote.Desk.Width.ToString();
            depthFinal.Text = quote.Desk.Depth.ToString();
            drawersFinal.Text = quote.Desk.NumberOfDrawers.ToString();
            materialFinal.Text = quote.Desk.SurfaceMaterial.ToString();
            total.Text = "$ " + quote.QuotePrice.ToString();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveQuote_Click(object sender, EventArgs e)
        {
            AddQuoteToFile();
            this.Close();
            addQuoteForm.Close(); // navigates to Main Menu via form close function
        }

        private void DisplayQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            navigateToForm(addQuoteForm);
        }

        /// <summary>
        /// Handle to save the quote data to the file
        /// </summary>
        private void AddQuoteToFile()
        {
            var quotesFile = @"quotes.json";

            // Get list of existing quotes (if any)
            List<DeskQuote> deskQuotes = getQuotesFromFile(quotesFile);

            // Add new quote
            deskQuotes.Add(quote);

            // Save quotes to file
            saveQuotesToFile(quotesFile, deskQuotes);
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
        private void saveQuotesToFile(in string quotesFile, in List<DeskQuote> deskQuotes)
        {
            using (StreamWriter writer = new StreamWriter(quotesFile))
            {
                // Serialize quotes list
                var quotesJson = JsonConvert.SerializeObject(deskQuotes);

                // Write to file
                writer.Write(quotesJson);
            }
        }


    }
}
