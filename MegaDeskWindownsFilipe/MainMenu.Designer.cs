
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearchQuotes = new System.Windows.Forms.Button();
            this.btnViewAllQuotes = new System.Windows.Forms.Button();
            this.btnAddNewQuote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 507);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(464, 363);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(297, 74);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSearchQuotes
            // 
            this.btnSearchQuotes.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSearchQuotes.FlatAppearance.BorderSize = 0;
            this.btnSearchQuotes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btnSearchQuotes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnSearchQuotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchQuotes.Location = new System.Drawing.Point(464, 252);
            this.btnSearchQuotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchQuotes.Name = "btnSearchQuotes";
            this.btnSearchQuotes.Size = new System.Drawing.Size(297, 74);
            this.btnSearchQuotes.TabIndex = 7;
            this.btnSearchQuotes.Text = "Search Quotes";
            this.btnSearchQuotes.UseVisualStyleBackColor = false;
            this.btnSearchQuotes.Click += new System.EventHandler(this.btnSearchQuotes_Click);
            // 
            // btnViewAllQuotes
            // 
            this.btnViewAllQuotes.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnViewAllQuotes.FlatAppearance.BorderSize = 0;
            this.btnViewAllQuotes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btnViewAllQuotes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnViewAllQuotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAllQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllQuotes.Location = new System.Drawing.Point(464, 142);
            this.btnViewAllQuotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewAllQuotes.Name = "btnViewAllQuotes";
            this.btnViewAllQuotes.Size = new System.Drawing.Size(297, 74);
            this.btnViewAllQuotes.TabIndex = 6;
            this.btnViewAllQuotes.Text = "View Quotes";
            this.btnViewAllQuotes.UseVisualStyleBackColor = false;
            this.btnViewAllQuotes.Click += new System.EventHandler(this.btnViewAllQuotes_Click);
            // 
            // btnAddNewQuote
            // 
            this.btnAddNewQuote.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddNewQuote.FlatAppearance.BorderSize = 0;
            this.btnAddNewQuote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btnAddNewQuote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnAddNewQuote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewQuote.Location = new System.Drawing.Point(464, 31);
            this.btnAddNewQuote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddNewQuote.Name = "btnAddNewQuote";
            this.btnAddNewQuote.Size = new System.Drawing.Size(297, 74);
            this.btnAddNewQuote.TabIndex = 5;
            this.btnAddNewQuote.Text = "Add New Quote";
            this.btnAddNewQuote.UseVisualStyleBackColor = false;
            this.btnAddNewQuote.Click += new System.EventHandler(this.btnAddNewQuote_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearchQuotes);
            this.Controls.Add(this.btnViewAllQuotes);
            this.Controls.Add(this.btnAddNewQuote);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 545);
            this.MinimumSize = new System.Drawing.Size(816, 545);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MegaDesk App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSearchQuotes;
        private System.Windows.Forms.Button btnViewAllQuotes;
        private System.Windows.Forms.Button btnAddNewQuote;
    }
}

