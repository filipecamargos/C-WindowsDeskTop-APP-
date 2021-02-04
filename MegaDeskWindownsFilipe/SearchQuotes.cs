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
    /// This class is responsible for allowing the user 
    /// to search for a specifc quote 
    /// </summary>
    public partial class SearchQuotes : Form
    {
        //Reference to the mainMenuForm to facilitate navigation
        private Form mainMenuForm;

        //hold the string to be searched
        private string quoteToBeSearched;

        //Hold the found quotes
        List<DeskQuote> foundQuotes = new List<DeskQuote>();

        //Initilize the form
        public SearchQuotes(in Form mainMenuForm)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.mainMenuForm = mainMenuForm;
        }

        /// <summary>
        /// Give the appearance of navigation by hiding the current form and
        /// showing the supplied form
        /// </summary>
        /// <param name="form"></param>
        private void navigateToForm(Form form)
        {
            form.Location = this.Location;
            this.Hide();
            form.Show();
        }

        //Handles when the form is exited
        private void searchQuotes_FormClose(object sender, FormClosedEventArgs e)
        {
            navigateToForm(mainMenuForm);
        }

        //Exectuted as part of the framWork for the form load
        private void SearchQuotes_Load(object sender, EventArgs e)
        {

        }

        //Handle input check in order to allow to show the quote
        private void quoteToBeSearched_TextChanged(object sender, EventArgs e)
        {
            // Disable save quote button if no custome name has been entered
            if (inputToSearch.Text != "")
            {
                searchQuote.Enabled = true;
            }
        }

        //Event fired when the searchQuote btn is clicked
        private void searchQuote_Click(object sender, EventArgs e)
        {
            foundQuotes.Clear();
            quotesSearchedGrid.ColumnCount = 0;
            this.quoteToBeSearched = inputToSearch.Text;
            searchQuoteMethod();
            
        }

        /// <summary>
        /// This method will search for the quote given
        /// by the user
        /// </summary>
        private void searchQuoteMethod()
        {
            // Read quotes from file into list
            var quotesFilename = @"quotes.json";
            List<DeskQuote> quotes = ReadFileHelper.GetQuotesFromFile(quotesFilename);

            //Find the quote searched by the user
            foreach (var quote in quotes)
            {
                //Display to the user if found else handle it in the display
                if(quote.CustomerName.ToLower().Contains(this.quoteToBeSearched.Trim().ToLower()))
                {
                    foundQuotes.Add(quote);
                }
            }

            displayFoundInfo();
        }

        /// <summary>
        /// This method will Display the quoted requested by the user
        /// </summary>
        private void displayFoundInfo()
        {
            if (foundQuotes.Count > 0)
            {
                addQuoteColumnHeaders(ref quotesSearchedGrid);
                addQuoteRows(ref quotesSearchedGrid, in foundQuotes);
            }
        }

        //Set a nice interface to improve readbility
        private void addQuoteColumnHeaders(ref DataGridView quotesSearchedGrid)
        {
            quotesSearchedGrid.ColumnCount = 8;

            quotesSearchedGrid.Columns[0].Name = "Quote Date";
            quotesSearchedGrid.Columns[1].Name = "Customer Name";
            quotesSearchedGrid.Columns[2].Name = "Shipping Option";
            quotesSearchedGrid.Columns[3].Name = "Quote Price";
            quotesSearchedGrid.Columns[4].Name = "Desk Width";
            quotesSearchedGrid.Columns[5].Name = "Desk Depth";
            quotesSearchedGrid.Columns[6].Name = "Desk Drawers";
            quotesSearchedGrid.Columns[7].Name = "Desk Material";
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

        //Clean will just handle the page back with reference to mainMenu
        private void clearSearch_Click(object sender, EventArgs e)
        {
            var searchQuotesForm = new SearchQuotes(this.mainMenuForm);
            navigateToForm(searchQuotesForm);
        }
    }
}
