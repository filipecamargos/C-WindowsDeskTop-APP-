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
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainMenu = (MainMenu)this.Tag;
            mainMenu.Show();
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }

        private void closeAddQuote_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveQuote(object sender, EventArgs e)
        {
            var displaQuote = new DisplayQuote();
            displaQuote.Tag = this;
            displaQuote.Show();
            this.Hide();
        }
    }
}
