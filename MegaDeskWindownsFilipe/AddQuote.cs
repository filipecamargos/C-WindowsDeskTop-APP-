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
    public partial class AddQuote : Form
    {  
        public DeskQuote Quote { get; set; }
        private Form mainMenu;

        public AddQuote(Form mainMenu)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
        }

        /// <summary>
        /// Give the appearance of navigation by hiding the current form and
        /// showing the supplied form.
        /// </summary>
        /// <param name="form"></param>
        private void navigateToForm(Form form)
        {                    
            form.Location = this.Location;
            this.Hide();
            form.Show();
        }

        private void navigateToDisplayQuote()
        {
            var displayQuoteForm = new DisplayQuote(Quote, mainMenu, this);        
            navigateToForm(displayQuoteForm);            
        }

        private void navigateToMainMenu()
        {
            var mainMenuForm = (MainMenu)mainMenu;
            navigateToForm(mainMenuForm);
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            material.DataSource = Enum.GetValues(typeof(SurfaceMaterial));
            material.SelectedItem = SurfaceMaterial.Pine;
            delivery.SelectedItem = "14 day (no rush)";
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {         
            navigateToMainMenu();
        }

        private void closeAddQuote_Click(object sender, EventArgs e)
        {
            navigateToMainMenu();
        }

        private Desk getDeskFromInput()
        {
            // get width, depth, and number of drawers from input
            decimal width = this.width.Value;
            decimal depth = this.depth.Value;
            int numberOfDrawers = (int)this.drawers.Value;

            // get surface material from input and convert it to enum
            string surfaceMaterialStr = this.material.SelectedValue.ToString();
            SurfaceMaterial surfaceMaterial;
            surfaceMaterial = (SurfaceMaterial)Enum.Parse(typeof(SurfaceMaterial), surfaceMaterialStr);

            Console.WriteLine(surfaceMaterial); //Console the surface

            return new Desk(width, depth, numberOfDrawers, surfaceMaterial);
        }

        private DeskQuote getDeskQuoteFromInput()
        {
            // get customer name and desk from input
            string customerName = this.customerName.Text;
            Desk desk = getDeskFromInput();

            // get shipping from input and convert to enum
            string shippingStr = this.delivery.SelectedItem.ToString();
            Shipping shipping;
            shipping = DeskQuote.shippingDict[shippingStr];
                  
            DateTime date = DateTime.Today;

            return new DeskQuote(customerName, shipping, desk, date);
        }

        private void customerName_TextChanged(object sender, EventArgs e)
        {
            // Disable save quote button if no custome name has been entered
            if (customerName.Text != "")
            {
                btnShowQuote.Enabled = true;
            }
        }

        /// <summary>
        /// Event handle with the button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowQuote_Click(object sender, EventArgs e)
        {
            //Get all the information from the form inputs
            Quote = getDeskQuoteFromInput();

            //test
            Console.WriteLine(Quote);

            //Save the quote and move to the display of the quote passing the new info             
            navigateToDisplayQuote();
        }
    }
}
