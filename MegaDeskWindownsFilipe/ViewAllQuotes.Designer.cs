﻿
namespace MegaDeskWindownsFilipe
{
    partial class ViewAllQuotes
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
            this.quotesGrid = new System.Windows.Forms.DataGridView();
            this.btnDeleteQuotes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quotesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(19, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 37);
            this.label7.TabIndex = 16;
            this.label7.Text = "All Quotes";
            // 
            // quotesGrid
            // 
            this.quotesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quotesGrid.Location = new System.Drawing.Point(16, 60);
            this.quotesGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quotesGrid.Name = "quotesGrid";
            this.quotesGrid.Size = new System.Drawing.Size(768, 382);
            this.quotesGrid.TabIndex = 17;
            // 
            // btnDeleteQuotes
            // 
            this.btnDeleteQuotes.Location = new System.Drawing.Point(621, 453);
            this.btnDeleteQuotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteQuotes.Name = "btnDeleteQuotes";
            this.btnDeleteQuotes.Size = new System.Drawing.Size(163, 42);
            this.btnDeleteQuotes.TabIndex = 18;
            this.btnDeleteQuotes.Text = "Delete All Quotes";
            this.btnDeleteQuotes.UseVisualStyleBackColor = true;
            this.btnDeleteQuotes.Click += new System.EventHandler(this.btnDeleteQuotes_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.btnDeleteQuotes);
            this.Controls.Add(this.quotesGrid);
            this.Controls.Add(this.label7);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 545);
            this.MinimumSize = new System.Drawing.Size(816, 545);
            this.Name = "ViewAllQuotes";
            this.Text = "View All Quotes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewAllQuotes_FormClosing);
            this.Load += new System.EventHandler(this.ViewAllQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quotesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView quotesGrid;
        private System.Windows.Forms.Button btnDeleteQuotes;
    }
}