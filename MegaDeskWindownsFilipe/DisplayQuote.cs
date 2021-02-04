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
    /// <summary>
    /// Form resposnible for display the quote to the user
    /// it also provides the saving functionality
    /// </summary>
    public partial class DisplayQuote : Form
    {
        //quote = to hold the quote 
        // mainMenuForm = reference to Menu 
        // addQuoteFrom = reference to the Add Quote option
        private DeskQuote quote;
        private Form mainMenuForm;
        private Form addQuoteForm;

        /// <summary>
        /// Intantiate the objects
        /// And initilize the components for the form
        /// </summary>
        /// <param name="quote"></param>
        /// <param name="mainMenuForm"></param>
        /// <param name="addQuoteForm"></param>
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

        /// <summary>
        /// Get all the information from the quore and 
        /// display to the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            shippingPrice.Text = "$ " + quote.ShippingPrice.ToString();
            total.Text = "$ " + quote.QuotePrice.ToString();
        }

        //Handle the cancel btn
        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Handle the save quote btn
        private void saveQuote_Click(object sender, EventArgs e)
        {
            AddQuoteToFile();
            this.Close();
            addQuoteForm.Close(); // navigates to Main Menu via form close function
        }

        //Handle the form being exit out
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
            List<DeskQuote> deskQuotes = ReadFileHelper.GetQuotesFromFile(quotesFile);

            // Add new quote
            deskQuotes.Add(quote);

            // Save quotes to file
            saveQuotesToFile(quotesFile, deskQuotes);
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
