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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnAddNewQuote_Click(object sender, EventArgs e)
        {
            //Create a new fromAddQuotes object
            var formAddQuote = new AddQuote();

            //Pass a reference to this Main manu as a tag to the addQuoteform
            formAddQuote.Tag = this;

            //Display the add quote and hide the Main menu
            formAddQuote.Show();
            this.Hide();

        }

        private void btnViewAllQuotes_Click(object sender, EventArgs e)
        {
            //Create a new viewAllQuotes object
            var viewAllQuotes = new ViewAllQuotes();

            //Pass a reference to this Main manu as a tag to the viewAllQuotes
            viewAllQuotes.Tag = this;

            //Display the viewAllQuotes and hide the Main menu
            viewAllQuotes.Show();
            this.Hide();

        }

        private void btnSearchQuotes_Click(object sender, EventArgs e)
        {
            //Create a new searchQuotes object
            var searchQuotes = new SearchQuotes();

            //Pass a reference to this Main manu as a tag to the searchQuotes
            searchQuotes.Tag = this;

            //Display the searchQuotes and hide the Main menu
            searchQuotes.Show();
            this.Hide();
        }

        private void btn_exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
