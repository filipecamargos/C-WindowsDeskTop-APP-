using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace MegaDeskWindownsFilipe
{
    public partial class ViewAllQuotes : Form
    {
        private Form mainMenuForm;

        public ViewAllQuotes(in Form mainMenuForm)
        {
            InitializeComponent();
            this.mainMenuForm = mainMenuForm;
        }

        private void navigateToForm(Form form)
        {
            form.Location = this.Location;
            this.Hide();
            form.Show();
        }

        private void ViewAllQuotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            navigateToForm(mainMenuForm);
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            // Read quotes from file into list
            var quotesFilename = @"quotes.json";
            List<DeskQuote> quotes = getQuotesFromFile(quotesFilename);

            // Fill Data Grid View
            quotesGrid.DataSource = quotes;
            //quotesGrid.Columns[0].Name = "Customer Name";
/*            quotesGrid.Columns[1].Name = "Shipping Option";
            quotesGrid.Columns[2].Name = "Desk";
            quotesGrid.Columns[3].Name = "Quote Date";
            quotesGrid.Columns[4].Name = "Quote Price";*/
        }



        /// <summary>
        /// Reads and deserializes desk quote objects into a list from the
        /// supplied file (returns empty list if file does not exist)
        /// </summary>
        /// <param name="quotesFile"></param>
        /// <returns></returns>
        private List<DeskQuote> getQuotesFromFile(in string quotesFile)
        {
            //Read from the existing file
            if (File.Exists(quotesFile))
            {
                using (StreamReader reader = new StreamReader(quotesFile))
                {
                    //load the quotes to string
                    string quotes = reader.ReadToEnd();

                    if (quotes.Length > 0)
                    {
                        return JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);
                    }
                }
            }
            return new List<DeskQuote>();
        }
    }
}
