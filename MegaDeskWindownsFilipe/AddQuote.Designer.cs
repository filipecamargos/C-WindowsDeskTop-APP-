﻿
namespace MegaDeskWindownsFilipe
{
    partial class AddQuote
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
            this.closeAddQuote = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.NumericUpDown();
            this.depth = new System.Windows.Forms.NumericUpDown();
            this.drawers = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.material = new System.Windows.Forms.ComboBox();
            this.delivery = new System.Windows.Forms.ComboBox();
            this.btnShowQuote = new System.Windows.Forms.Button();
            this.grpOrderDetails = new System.Windows.Forms.GroupBox();
            this.grpDeskDetails = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawers)).BeginInit();
            this.grpOrderDetails.SuspendLayout();
            this.grpDeskDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeAddQuote
            // 
            this.closeAddQuote.BackColor = System.Drawing.SystemColors.ControlDark;
            this.closeAddQuote.Location = new System.Drawing.Point(318, 330);
            this.closeAddQuote.Name = "closeAddQuote";
            this.closeAddQuote.Size = new System.Drawing.Size(150, 54);
            this.closeAddQuote.TabIndex = 3;
            this.closeAddQuote.Text = "Close";
            this.closeAddQuote.UseVisualStyleBackColor = false;
            this.closeAddQuote.Click += new System.EventHandler(this.closeAddQuote_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // customerName
            // 
            this.customerName.Location = new System.Drawing.Point(36, 45);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(217, 20);
            this.customerName.TabIndex = 0;
            this.customerName.TextChanged += new System.EventHandler(this.customerName_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Width:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Depth:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number of Drawers:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Surface Material:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Delivery:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(139, 28);
            this.width.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.width.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(120, 20);
            this.width.TabIndex = 0;
            this.width.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // depth
            // 
            this.depth.Location = new System.Drawing.Point(139, 58);
            this.depth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.depth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(120, 20);
            this.depth.TabIndex = 1;
            this.depth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // drawers
            // 
            this.drawers.Location = new System.Drawing.Point(139, 88);
            this.drawers.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.drawers.Name = "drawers";
            this.drawers.Size = new System.Drawing.Size(120, 20);
            this.drawers.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(14, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 37);
            this.label7.TabIndex = 12;
            this.label7.Text = "New Quote";
            // 
            // material
            // 
            this.material.FormattingEnabled = true;
            this.material.Items.AddRange(new object[] {
            "laminate",
            "oak",
            "rosewood",
            "veneer",
            "pine"});
            this.material.Location = new System.Drawing.Point(139, 118);
            this.material.Name = "material";
            this.material.Size = new System.Drawing.Size(120, 21);
            this.material.TabIndex = 3;
            // 
            // delivery
            // 
            this.delivery.FormattingEnabled = true;
            this.delivery.Items.AddRange(new object[] {
            "14 day (no rush)",
            "7 day",
            "5 day",
            "3 day"});
            this.delivery.Location = new System.Drawing.Point(36, 98);
            this.delivery.Name = "delivery";
            this.delivery.Size = new System.Drawing.Size(121, 21);
            this.delivery.TabIndex = 1;
            // 
            // btnShowQuote
            // 
            this.btnShowQuote.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnShowQuote.Enabled = false;
            this.btnShowQuote.Location = new System.Drawing.Point(140, 330);
            this.btnShowQuote.Name = "btnShowQuote";
            this.btnShowQuote.Size = new System.Drawing.Size(150, 54);
            this.btnShowQuote.TabIndex = 2;
            this.btnShowQuote.Text = "Show Quote";
            this.btnShowQuote.UseVisualStyleBackColor = false;
            this.btnShowQuote.Click += new System.EventHandler(this.btnShowQuote_Click);
            // 
            // grpOrderDetails
            // 
            this.grpOrderDetails.Controls.Add(this.label1);
            this.grpOrderDetails.Controls.Add(this.customerName);
            this.grpOrderDetails.Controls.Add(this.delivery);
            this.grpOrderDetails.Controls.Add(this.label6);
            this.grpOrderDetails.Location = new System.Drawing.Point(20, 85);
            this.grpOrderDetails.Name = "grpOrderDetails";
            this.grpOrderDetails.Size = new System.Drawing.Size(270, 156);
            this.grpOrderDetails.TabIndex = 0;
            this.grpOrderDetails.TabStop = false;
            this.grpOrderDetails.Text = "Order Details";
            // 
            // grpDeskDetails
            // 
            this.grpDeskDetails.Controls.Add(this.label4);
            this.grpDeskDetails.Controls.Add(this.label2);
            this.grpDeskDetails.Controls.Add(this.label3);
            this.grpDeskDetails.Controls.Add(this.material);
            this.grpDeskDetails.Controls.Add(this.label5);
            this.grpDeskDetails.Controls.Add(this.width);
            this.grpDeskDetails.Controls.Add(this.drawers);
            this.grpDeskDetails.Controls.Add(this.depth);
            this.grpDeskDetails.Location = new System.Drawing.Point(318, 85);
            this.grpDeskDetails.Name = "grpDeskDetails";
            this.grpDeskDetails.Size = new System.Drawing.Size(270, 156);
            this.grpDeskDetails.TabIndex = 1;
            this.grpDeskDetails.TabStop = false;
            this.grpDeskDetails.Text = "Desk Details";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 411);
            this.Controls.Add(this.grpDeskDetails);
            this.Controls.Add(this.grpOrderDetails);
            this.Controls.Add(this.btnShowQuote);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.closeAddQuote);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(616, 450);
            this.MinimumSize = new System.Drawing.Size(616, 450);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawers)).EndInit();
            this.grpOrderDetails.ResumeLayout(false);
            this.grpOrderDetails.PerformLayout();
            this.grpDeskDetails.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button closeAddQuote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown width;
        private System.Windows.Forms.NumericUpDown depth;
        private System.Windows.Forms.NumericUpDown drawers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox material;
        private System.Windows.Forms.ComboBox delivery;
        private System.Windows.Forms.Button btnShowQuote;
        private System.Windows.Forms.GroupBox grpOrderDetails;
        private System.Windows.Forms.GroupBox grpDeskDetails;
    }
}