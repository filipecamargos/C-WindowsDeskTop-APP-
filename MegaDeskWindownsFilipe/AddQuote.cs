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
        private void navigateToForm(Form form)
        {
            form.Tag = this;
            this.Hide();
            form.Show();
            form.Location = this.Location;
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainMenuForm = new MainMenu();
            navigateToForm(mainMenuForm);
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }

        private void closeAddQuote_Click(object sender, EventArgs e)
        {
            var mainMenuForm = new MainMenu();
            navigateToForm(mainMenuForm);
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void delivery_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void drawers_ValueChanged(object sender, EventArgs e)
        {

        }

        private void material_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void depth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void width_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
