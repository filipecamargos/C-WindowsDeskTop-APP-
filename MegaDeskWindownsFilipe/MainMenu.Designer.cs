
namespace MegaDeskWindownsFilipe
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Button();
            this.searchQuotes = new System.Windows.Forms.Button();
            this.viewAllQuotes = new System.Windows.Forms.Button();
            this.addNewQuote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 412);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(348, 295);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(223, 60);
            this.exit.TabIndex = 8;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            // 
            // searchQuotes
            // 
            this.searchQuotes.BackColor = System.Drawing.Color.LightSteelBlue;
            this.searchQuotes.FlatAppearance.BorderSize = 0;
            this.searchQuotes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.searchQuotes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.searchQuotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuotes.Location = new System.Drawing.Point(348, 205);
            this.searchQuotes.Name = "searchQuotes";
            this.searchQuotes.Size = new System.Drawing.Size(223, 60);
            this.searchQuotes.TabIndex = 7;
            this.searchQuotes.Text = "Search Quotes";
            this.searchQuotes.UseVisualStyleBackColor = false;
            // 
            // viewAllQuotes
            // 
            this.viewAllQuotes.BackColor = System.Drawing.Color.LightSteelBlue;
            this.viewAllQuotes.FlatAppearance.BorderSize = 0;
            this.viewAllQuotes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.viewAllQuotes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.viewAllQuotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewAllQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllQuotes.Location = new System.Drawing.Point(348, 115);
            this.viewAllQuotes.Name = "viewAllQuotes";
            this.viewAllQuotes.Size = new System.Drawing.Size(223, 60);
            this.viewAllQuotes.TabIndex = 6;
            this.viewAllQuotes.Text = "View Quotes";
            this.viewAllQuotes.UseVisualStyleBackColor = false;
            // 
            // addNewQuote
            // 
            this.addNewQuote.BackColor = System.Drawing.Color.LightSteelBlue;
            this.addNewQuote.FlatAppearance.BorderSize = 0;
            this.addNewQuote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.addNewQuote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.addNewQuote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewQuote.Location = new System.Drawing.Point(348, 25);
            this.addNewQuote.Name = "addNewQuote";
            this.addNewQuote.Size = new System.Drawing.Size(223, 60);
            this.addNewQuote.TabIndex = 5;
            this.addNewQuote.Text = "Add New Quote";
            this.addNewQuote.UseVisualStyleBackColor = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 411);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.searchQuotes);
            this.Controls.Add(this.viewAllQuotes);
            this.Controls.Add(this.addNewQuote);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(616, 450);
            this.MinimumSize = new System.Drawing.Size(616, 450);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MegaDesk App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button searchQuotes;
        private System.Windows.Forms.Button viewAllQuotes;
        private System.Windows.Forms.Button addNewQuote;
    }
}

