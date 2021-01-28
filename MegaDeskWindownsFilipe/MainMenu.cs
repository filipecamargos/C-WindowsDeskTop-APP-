﻿using System;
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

        private void navigateToForm(Form form)
        {
            form.Tag = this;
            form.Location = this.Location;
            this.Hide();
            form.Show();
        }

        private void navigateToAddQuote()
        {
            var addQuoteForm = new AddQuote();
            navigateToForm(addQuoteForm);
        }

        private void navigateToViewAllQuotes()
        {
            var viewAllQuotesForm = new ViewAllQuotes();
            navigateToForm(viewAllQuotesForm);
        }

        private void navigateToSearchQuotes()
        {
            var searchQuotesForm = new SearchQuotes();
            navigateToForm(searchQuotesForm);
        }

        private void btnAddNewQuote_Click(object sender, EventArgs e)
        {
            navigateToAddQuote();
        }

        private void btnViewAllQuotes_Click(object sender, EventArgs e)
        {
            navigateToViewAllQuotes();
        }

        private void btnSearchQuotes_Click(object sender, EventArgs e)
        {
            navigateToSearchQuotes();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
