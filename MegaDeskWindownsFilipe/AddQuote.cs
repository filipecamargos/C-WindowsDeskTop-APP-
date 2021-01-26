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
            var mainMenu = new MainMenu();
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
            //Get all the information
            string customerName = this.customerName.ToString();
            decimal width = this.width.Value;
            decimal depth = this.depth.Value;
            int numberOfDrawers = (int)this.drawers.Value;
            string surfaceMaterial = this.material.ToString();
            string shipping = this.delivery.ToString();

            //Creat the desk and set its properties
            Desk desk = new Desk();
            desk.Width = width;
            desk.Depth = depth;
            desk.NumberOfDrawers = numberOfDrawers;
            //need some work to get the surface matching the options
            //desk.SurfaceMaterial = (SurfaceMaterial)Enum.Parse(typeof(SurfaceMaterial), surfaceMaterial);

            //Get the quote and set its properties
            DeskQuote quote = new DeskQuote();
            quote.CustomerName = customerName;
            quote.Desk = desk;
            //need some work to get the shipping matching the options
            //quote.Shipping = (Shipping)Enum.Parse(typeof(Shipping), shipping);

            //Save the quote and move to the display of the quote passing the new info
            var displaQuote = new DisplayQuote();
            displaQuote.Tag = this;
            displaQuote.Tag = quote;
            displaQuote.Show();
            this.Hide();
        }
    }
}
