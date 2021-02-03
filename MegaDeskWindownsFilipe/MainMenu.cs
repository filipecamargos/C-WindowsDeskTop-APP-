using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDeskWindownsFilipe
{
    /// <summary>
    /// This is a class form that initite the menu for 
    /// the quote program
    /// </summary>
    public partial class MainMenu : Form
    {
        /// <summary>
        /// Initiate the main menu
        /// </summary>
        public MainMenu()
        {
            InitializeComponent();
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
        /// Takes the the user to AddQuote and pass
        /// this as a reference
        /// </summary>
        private void navigateToAddQuote()
        {
            var addQuoteForm = new AddQuote(this);
            navigateToForm(addQuoteForm);
        }

        /// <summary>
        /// Takes the the user to ViewAllQuotes and pass
        /// this as a reference
        /// </summary>
        private void navigateToViewAllQuotes()
        {
            var viewAllQuotesForm = new ViewAllQuotes(this);
            navigateToForm(viewAllQuotesForm);
        }

        /// <summary>
        /// Takes the the user to SearchQuotes and pass
        /// this as a reference
        /// </summary>
        private void navigateToSearchQuotes()
        {
            var searchQuotesForm = new SearchQuotes(this);
            navigateToForm(searchQuotesForm);
        }

        //BTN to take to new Quote
        private void btnAddNewQuote_Click(object sender, EventArgs e)
        {
            navigateToAddQuote();
        }

        //BTN to take to view all quotes
        private void btnViewAllQuotes_Click(object sender, EventArgs e)
        {
            navigateToViewAllQuotes();
        }

        //BTN to take to search for quotes
        private void btnSearchQuotes_Click(object sender, EventArgs e)
        {
            navigateToSearchQuotes();
        }

        //Exite the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Empty load reference for when menu loads
        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
