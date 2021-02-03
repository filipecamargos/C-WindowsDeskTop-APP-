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
    /// This class is responsible for allowing the user 
    /// to search for a specifc quote 
    /// </summary>
    public partial class SearchQuotes : Form
    {
        private Form mainMenuForm;

        //hold the string to be searched
        private string quoteToBeSearched;

        public SearchQuotes(in Form mainMenuForm)
        {
            InitializeComponent();
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

        private void searchQuotes_FormClose(object sender, FormClosedEventArgs e)
        {
            navigateToForm(mainMenuForm);
        }


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

        }
    }
}
