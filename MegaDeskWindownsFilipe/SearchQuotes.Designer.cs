
namespace MegaDeskWindownsFilipe
{
    partial class SearchQuotes
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
            this.label7 = new System.Windows.Forms.Label();
            this.inputToSearch = new System.Windows.Forms.TextBox();
            this.searchQuote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(168, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Search for Quotes:";
            // 
            // inputToSearch
            // 
            this.inputToSearch.Location = new System.Drawing.Point(172, 65);
            this.inputToSearch.Name = "inputToSearch";
            this.inputToSearch.Size = new System.Drawing.Size(297, 22);
            this.inputToSearch.TabIndex = 18;
            this.inputToSearch.TextChanged += new System.EventHandler(this.quoteToBeSearched_TextChanged);
            // 
            // searchQuote
            // 
            this.searchQuote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.searchQuote.Enabled = false;
            this.searchQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuote.Location = new System.Drawing.Point(475, 62);
            this.searchQuote.Name = "searchQuote";
            this.searchQuote.Size = new System.Drawing.Size(102, 29);
            this.searchQuote.TabIndex = 19;
            this.searchQuote.Text = "Search";
            this.searchQuote.UseVisualStyleBackColor = false;
            this.searchQuote.Click += new System.EventHandler(this.searchQuote_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.searchQuote);
            this.Controls.Add(this.inputToSearch);
            this.Controls.Add(this.label7);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 545);
            this.MinimumSize = new System.Drawing.Size(816, 545);
            this.Name = "SearchQuotes";
            this.Text = "Search Quotes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.searchQuotes_FormClose);
            this.Load += new System.EventHandler(this.SearchQuotes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inputToSearch;
        private System.Windows.Forms.Button searchQuote;
    }
}