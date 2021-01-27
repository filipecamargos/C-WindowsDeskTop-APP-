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

        private void openForm(Form form)
        {            
            form.Tag = this;
            this.Hide();
            form.Show();
            form.Location = this.Location;
        }

        private void btnAddNewQuote_Click(object sender, EventArgs e)
        {
            var addQuoteForm = new AddQuote();
            openForm(addQuoteForm);
        }

        private void btnViewAllQuotes_Click(object sender, EventArgs e)
        {
            var viewAllQuotesForm = new ViewAllQuotes();
            openForm(viewAllQuotesForm);
        }

        private void btnSearchQuotes_Click(object sender, EventArgs e)
        {          
            var searchQuotesForm = new SearchQuotes();
            openForm(searchQuotesForm);
        }

        private void btn_exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
