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
    public partial class SearchQuotes : Form
    {
        private Form mainMenuForm;

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
    }
}
