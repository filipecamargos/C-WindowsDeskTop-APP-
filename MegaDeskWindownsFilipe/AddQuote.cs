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
    /// <summary>
    /// This class is responsible for allowing the user 
    /// to input information and generate a code
    /// </summary>
    public partial class AddQuote : Form
    {  
        //DeskQuote which will hold the quote info
        //And a mainMenuForm to allow navegation back
        public DeskQuote Quote { get; set; }
        private Form mainMenuForm;

        //Initialize the form and set the Form Menu for navigation
        public AddQuote(Form mainMenuForm)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.mainMenuForm = mainMenuForm;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddQuote_Load(object sender, EventArgs e)
        {
            // Fill "material" dropdown with enum values
            material.DataSource = Enum.GetValues(typeof(SurfaceMaterial));
            material.SelectedItem = SurfaceMaterial.Pine;

            // Fill "shipping" dropdown with enum values
            // Make list of shipping descriptions
            List<string> shippingDescriptions = new List<string>();
            foreach (int shippingOption in Shipping.GetValues(typeof(Shipping)))
            {
                shippingDescriptions.Add(EnumHelpers.GetDescription<Shipping>((Shipping)shippingOption));
            }
            delivery.DataSource = shippingDescriptions;
            delivery.SelectedItem = EnumHelpers.GetDescription<Shipping>(Shipping.NoRush);
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

        //Instantiate the display quote and shows it
        private void navigateToDisplayQuote()
        {
            var displayQuoteForm = new DisplayQuote(Quote, mainMenuForm, this);        
            navigateToForm(displayQuoteForm);            
        }

        //handle the meny navigation
        private void navigateToMainMenu()
        {           
            navigateToForm(mainMenuForm);
        }

        //Event on close btn form
        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            navigateToMainMenu();
        }

        //Event on close btn
        private void closeAddQuote_Click(object sender, EventArgs e)
        {
            navigateToMainMenu();
        }

        /// <summary>
        /// Get information from the user to set the properties
        /// of the Desk
        /// </summary>
        /// <returns></returns>
        private Desk getDeskFromInput()
        {
            // get width, depth, and number of drawers from input
            decimal width = this.width.Value;
            decimal depth = this.depth.Value;
            int numberOfDrawers = (int)this.drawers.Value;

            Console.WriteLine("numberOfDrawers: " + numberOfDrawers);

            // get surface material from input and convert it to enum
            string surfaceMaterialStr = this.material.SelectedValue.ToString();
            SurfaceMaterial surfaceMaterial;
            surfaceMaterial = (SurfaceMaterial)Enum.Parse(typeof(SurfaceMaterial), surfaceMaterialStr);

            return new Desk(width, depth, numberOfDrawers, surfaceMaterial);
        }

        /// <summary>
        /// Get the information from the user input
        /// and save it into a object to creat the quote
        /// </summary>
        /// <returns></returns>
        private DeskQuote getDeskQuoteFromInput()
        {
            // get customer name and desk from input
            string customerName = this.customerName.Text;
            Desk desk = getDeskFromInput();

            // get shipping from input and convert to enum
            string shippingStr = this.delivery.SelectedItem.ToString();
            Shipping shipping = EnumHelpers.GetValueFromDescription<Shipping>(shippingStr);
                  
            // get current date
            DateTime date = DateTime.Today;

            return new DeskQuote(customerName, shipping, desk, date);
        }

        //Handle input check in order to allow to show the quote
        private void customerName_TextChanged(object sender, EventArgs e)
        {
            // Disable save quote button if no custome name has been entered
            if (customerName.Text != "")
            {
                btnShowQuote.Enabled = true;
            }
        }

        //Handle o show the quote on click
        private void btnShowQuote_Click(object sender, EventArgs e)
        {
            //Get all the information from the form inputs
            Quote = getDeskQuoteFromInput();

            //Save the quote and move to the display of the quote passing the new info             
            navigateToDisplayQuote();
        }
    }
}
