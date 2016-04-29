namespace CarDealership
{
    partial class WeeklySales
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
            this.rbPercentage = new System.Windows.Forms.RadioButton();
            this.rbFlatRate = new System.Windows.Forms.RadioButton();
            this.txtPercentages = new System.Windows.Forms.TextBox();
            this.txtFlatRate = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.rbNoSale = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rbPercentage
            // 
            this.rbPercentage.AutoSize = true;
            this.rbPercentage.Location = new System.Drawing.Point(73, 61);
            this.rbPercentage.Name = "rbPercentage";
            this.rbPercentage.Size = new System.Drawing.Size(80, 17);
            this.rbPercentage.TabIndex = 0;
            this.rbPercentage.TabStop = true;
            this.rbPercentage.Text = "Percentage";
            this.rbPercentage.UseVisualStyleBackColor = true;
            // 
            // rbFlatRate
            // 
            this.rbFlatRate.AutoSize = true;
            this.rbFlatRate.Location = new System.Drawing.Point(73, 122);
            this.rbFlatRate.Name = "rbFlatRate";
            this.rbFlatRate.Size = new System.Drawing.Size(68, 17);
            this.rbFlatRate.TabIndex = 1;
            this.rbFlatRate.TabStop = true;
            this.rbFlatRate.Text = "Flat Rate";
            this.rbFlatRate.UseVisualStyleBackColor = true;
            // 
            // txtPercentages
            // 
            this.txtPercentages.Location = new System.Drawing.Point(186, 58);
            this.txtPercentages.Name = "txtPercentages";
            this.txtPercentages.Size = new System.Drawing.Size(100, 20);
            this.txtPercentages.TabIndex = 2;
            // 
            // txtFlatRate
            // 
            this.txtFlatRate.Location = new System.Drawing.Point(186, 122);
            this.txtFlatRate.Name = "txtFlatRate";
            this.txtFlatRate.Size = new System.Drawing.Size(100, 20);
            this.txtFlatRate.TabIndex = 3;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(133, 238);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 4;
            this.btnSet.Text = "Confirm";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // rbNoSale
            // 
            this.rbNoSale.AutoSize = true;
            this.rbNoSale.Location = new System.Drawing.Point(73, 183);
            this.rbNoSale.Name = "rbNoSale";
            this.rbNoSale.Size = new System.Drawing.Size(63, 17);
            this.rbNoSale.TabIndex = 5;
            this.rbNoSale.TabStop = true;
            this.rbNoSale.Text = "No Sale";
            this.rbNoSale.UseVisualStyleBackColor = true;
            // 
            // WeeklySales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 300);
            this.Controls.Add(this.rbNoSale);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.txtFlatRate);
            this.Controls.Add(this.txtPercentages);
            this.Controls.Add(this.rbFlatRate);
            this.Controls.Add(this.rbPercentage);
            this.Name = "WeeklySales";
            this.Text = "WeeklySales";
            this.Load += new System.EventHandler(this.WeeklySales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbPercentage;
        private System.Windows.Forms.RadioButton rbFlatRate;
        private System.Windows.Forms.TextBox txtPercentages;
        private System.Windows.Forms.TextBox txtFlatRate;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.RadioButton rbNoSale;
    }
}