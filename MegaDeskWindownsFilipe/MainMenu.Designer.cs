
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
            this.addNewQuote = new System.Windows.Forms.Button();
            this.viewQuotes = new System.Windows.Forms.Button();
            this.searchQuotes = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewQuote
            // 
            this.addNewQuote.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.addNewQuote.Location = new System.Drawing.Point(48, 59);
            this.addNewQuote.Name = "addNewQuote";
            this.addNewQuote.Size = new System.Drawing.Size(180, 46);
            this.addNewQuote.TabIndex = 0;
            this.addNewQuote.Text = "Add New Quote";
            this.addNewQuote.UseVisualStyleBackColor = false;
            this.addNewQuote.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewQuotes
            // 
            this.viewQuotes.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.viewQuotes.Location = new System.Drawing.Point(48, 111);
            this.viewQuotes.Name = "viewQuotes";
            this.viewQuotes.Size = new System.Drawing.Size(180, 46);
            this.viewQuotes.TabIndex = 1;
            this.viewQuotes.Text = "View Quotes";
            this.viewQuotes.UseVisualStyleBackColor = false;
            // 
            // searchQuotes
            // 
            this.searchQuotes.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.searchQuotes.Location = new System.Drawing.Point(48, 163);
            this.searchQuotes.Name = "searchQuotes";
            this.searchQuotes.Size = new System.Drawing.Size(180, 46);
            this.searchQuotes.TabIndex = 2;
            this.searchQuotes.Text = "Search Quotes";
            this.searchQuotes.UseVisualStyleBackColor = false;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.exit.Location = new System.Drawing.Point(48, 215);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(180, 46);
            this.exit.TabIndex = 3;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MegaDeskWindownsFilipe.Properties.Resources.Laboratory_table2;
            this.pictureBox1.Location = new System.Drawing.Point(306, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 85);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 310);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.searchQuotes);
            this.Controls.Add(this.viewQuotes);
            this.Controls.Add(this.addNewQuote);
            this.Name = "MainMenu";
            this.Text = "MegaDesk App";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addNewQuote;
        private System.Windows.Forms.Button viewQuotes;
        private System.Windows.Forms.Button searchQuotes;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

