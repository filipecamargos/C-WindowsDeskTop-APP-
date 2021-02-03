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
    public partial class ViewAllQuotes : Form
    {
        private Form mainMenuForm;

        public ViewAllQuotes(in Form mainMenuForm)
        {
            InitializeComponent();
            this.mainMenuForm = mainMenuForm;
        }

        private void navigateToForm(Form form)
        {
            form.Location = this.Location;
            this.Hide();
            form.Show();
        }

        private void ViewAllQuotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            navigateToForm(mainMenuForm);
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            // Read quotes from file into list
            var quotesFilename = @"quotes.json";
            List<DeskQuote> quotes = getQuotesFromFile(quotesFilename);

            // Fill Data Grid View
            addQuoteColumnHeaders(ref quotesGrid);
            addQuoteRows(ref quotesGrid, in quotes);

        }

        private void addQuoteColumnHeaders(ref DataGridView quotesGrid)
        {         
            quotesGrid.ColumnCount = 8;

            quotesGrid.Columns[0].Name = "Quote Date";
            quotesGrid.Columns[1].Name = "Customer Name";
            quotesGrid.Columns[2].Name = "Shipping Option";
            quotesGrid.Columns[3].Name = "Quote Price";
            quotesGrid.Columns[4].Name = "Desk Width";
            quotesGrid.Columns[5].Name = "Desk Depth";
            quotesGrid.Columns[6].Name = "Desk Drawers";
            quotesGrid.Columns[7].Name = "Desk Material";
        }

        /// <summary>
        /// Insert all the quotes into the quotes grid view
        /// </summary>
        private void addQuoteRows(ref DataGridView quoteGrid, in List<DeskQuote> quotes)
        {        
            List<List<string>> quoteRows = makeQuoteRows(quotes);
            foreach (List<string> quoteRow in quoteRows)
            {
                quoteGrid.Rows.Add(quoteRow.ToArray());
            }
        }

        /// <summary>
        /// Transform a list of quotes into a list of DataGridView-compatible rows
        /// </summary>
        private List<List<string>> makeQuoteRows(in List<DeskQuote> quotes)
        {
            List<List<string>> quoteRows = new List<List<string>>();

            foreach (DeskQuote quote in quotes)
            {
                quoteRows.Add(makeQuoteRow(quote));
            }

            return quoteRows;
        }

        /// <summary>
        /// Transform a quote into a format suitable for insertion into a DataGridView
        /// </summary>
        private List<string> makeQuoteRow(in DeskQuote quote)
        {
            List<string> quoteRow = new List<string>();

            quoteRow.Add(quote.QuoteDate.ToString("MMM dd, yyyy"));
            quoteRow.Add(quote.CustomerName);
            quoteRow.Add(EnumHelpers.GetDescription<Shipping>(quote.Shipping));
            quoteRow.Add(quote.QuotePrice.ToString());
            quoteRow.Add(quote.Desk.Width.ToString());
            quoteRow.Add(quote.Desk.Depth.ToString());
            quoteRow.Add(quote.Desk.NumberOfDrawers.ToString());
            quoteRow.Add(quote.Desk.SurfaceMaterial.ToString());

            return quoteRow;
        }

        /// <summary>
        /// Reads and deserializes desk quote objects into a list from the
        /// supplied file (returns empty list if file does not exist)
        /// </summary>
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
    }
}
