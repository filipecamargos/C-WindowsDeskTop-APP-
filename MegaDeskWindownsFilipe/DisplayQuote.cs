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
        public DisplayQuote()
        {
            InitializeComponent();
        }

        private void displayQuote__FormClosed(object sender, FormClosedEventArgs e)
        {
            var addQuote = (AddQuote)this.Tag;
            addQuote.Show();
        }


    }
}
