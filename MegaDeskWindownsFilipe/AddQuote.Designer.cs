
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
            this.saveNewQuote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawers)).BeginInit();
            this.SuspendLayout();
            // 
            // closeAddQuote
            // 
            this.closeAddQuote.BackColor = System.Drawing.SystemColors.ControlDark;
            this.closeAddQuote.Location = new System.Drawing.Point(252, 274);
            this.closeAddQuote.Name = "closeAddQuote";
            this.closeAddQuote.Size = new System.Drawing.Size(150, 54);
            this.closeAddQuote.TabIndex = 1;
            this.closeAddQuote.Text = "Close";
            this.closeAddQuote.UseVisualStyleBackColor = false;
            this.closeAddQuote.Click += new System.EventHandler(this.closeAddQuote_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer Name:";
            // 
            // customerName
            // 
            this.customerName.Location = new System.Drawing.Point(146, 47);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(316, 20);
            this.customerName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Width:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Depth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(249, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number of Drawers:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(249, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Surface Material:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(159, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Delivery";
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(139, 131);
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
            this.width.Size = new System.Drawing.Size(79, 20);
            this.width.TabIndex = 9;
            this.width.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // depth
            // 
            this.depth.Location = new System.Drawing.Point(139, 164);
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
            this.depth.Size = new System.Drawing.Size(79, 20);
            this.depth.TabIndex = 10;
            this.depth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // drawers
            // 
            this.drawers.Location = new System.Drawing.Point(383, 131);
            this.drawers.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.drawers.Name = "drawers";
            this.drawers.Size = new System.Drawing.Size(79, 20);
            this.drawers.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(193, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 23);
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
            this.material.Location = new System.Drawing.Point(383, 162);
            this.material.Name = "material";
            this.material.Size = new System.Drawing.Size(79, 21);
            this.material.TabIndex = 13;
            // 
            // delivery
            // 
            this.delivery.FormattingEnabled = true;
            this.delivery.Items.AddRange(new object[] {
            "NoRush",
            "Rush3Days",
            "Rush5Days",
            "Rush7Day"});
            this.delivery.Location = new System.Drawing.Point(233, 205);
            this.delivery.Name = "delivery";
            this.delivery.Size = new System.Drawing.Size(79, 21);
            this.delivery.TabIndex = 14;
            // 
            // saveNewQuote
            // 
            this.saveNewQuote.BackColor = System.Drawing.SystemColors.ControlDark;
            this.saveNewQuote.Location = new System.Drawing.Point(70, 274);
            this.saveNewQuote.Name = "saveNewQuote";
            this.saveNewQuote.Size = new System.Drawing.Size(150, 54);
            this.saveNewQuote.TabIndex = 15;
            this.saveNewQuote.Text = "Save Quote";
            this.saveNewQuote.UseVisualStyleBackColor = false;
            this.saveNewQuote.Click += new System.EventHandler(this.saveQuote);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.saveNewQuote);
            this.Controls.Add(this.delivery);
            this.Controls.Add(this.material);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.drawers);
            this.Controls.Add(this.depth);
            this.Controls.Add(this.width);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeAddQuote);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawers)).EndInit();
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
        private System.Windows.Forms.Button saveNewQuote;
    }
}