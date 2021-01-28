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
    public partial class DisplayQuote : Form
    {
        private DeskQuote quote;

        public DisplayQuote(DeskQuote quote)
        {
            InitializeComponent();
            this.quote = quote;
        }

        private void displayQuote__FormClosed(object sender, FormClosedEventArgs e)
        {
            var addQuote = new AddQuote();
            addQuote.Show();
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {

        }
    }
}
