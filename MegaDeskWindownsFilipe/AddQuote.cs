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
        public DeskQuote Quote { get; set; }

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

        private void navigateBackToMainMenu()
        {
            var frmMainMenu = (MainMenu)this.Tag;
            frmMainMenu.Location = this.Location;
            this.Hide();
            frmMainMenu.Show();
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            material.DataSource = Enum.GetValues(typeof(SurfaceMaterial));
            material.SelectedItem = SurfaceMaterial.Pine;
            delivery.DataSource = Enum.GetValues(typeof(Shipping));
            delivery.SelectedItem = "14 day (no rush)";
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {         
            navigateBackToMainMenu();
        }

        private void closeAddQuote_Click(object sender, EventArgs e)
        {
            navigateBackToMainMenu();
        }

        private Desk getDeskFromInput()
        {
            decimal width = this.width.Value;
            decimal depth = this.depth.Value;
            int numberOfDrawers = (int)this.drawers.Value;
            string surfaceMaterialStr = this.material.SelectedValue.ToString();
            SurfaceMaterial surfaceMaterial;
            surfaceMaterial = (SurfaceMaterial)Enum.Parse(typeof(SurfaceMaterial), surfaceMaterialStr);

            return new Desk(width, depth, numberOfDrawers, surfaceMaterial);
        }

        private DeskQuote getDeskQuoteFromInput()
        {
            string customerName = this.customerName.Text;
            string shippingStr = this.delivery.SelectedItem.ToString();
            Shipping shipping;
            shipping = DeskQuote.shippingDict[shippingStr];
            Desk desk = getDeskFromInput();
            DateTime date = DateTime.Today;

            return new DeskQuote(customerName, shipping, desk, date);
        }

        private void saveQuote(object sender, EventArgs e)
        {
            //Get all the information from the form inputs
            Quote = getDeskQuoteFromInput();

            //Save the quote and move to the display of the quote passing the new info
            var displayQuoteForm = new DisplayQuote();
            navigateToForm(displayQuoteForm);
        }
    }
}
