namespace CarDealership
{
    partial class FindInventory
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
            this.lblVin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblQuality = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVin = new System.Windows.Forms.TextBox();
            this.btnFindInventory = new System.Windows.Forms.Button();
            this.btnVehCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.cbMake = new System.Windows.Forms.ComboBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.cbQuality = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDamaged = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblVin
            // 
            this.lblVin.AutoSize = true;
            this.lblVin.Location = new System.Drawing.Point(44, 46);
            this.lblVin.Name = "lblVin";
            this.lblVin.Size = new System.Drawing.Size(65, 13);
            this.lblVin.TabIndex = 0;
            this.lblVin.Text = "VIN Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Make";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Model";
            // 
            // lblQuality
            // 
            this.lblQuality.AutoSize = true;
            this.lblQuality.Location = new System.Drawing.Point(42, 236);
            this.lblQuality.Name = "lblQuality";
            this.lblQuality.Size = new System.Drawing.Size(39, 13);
            this.lblQuality.TabIndex = 4;
            this.lblQuality.Text = "Quality";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Year";
            // 
            // txtVin
            // 
            this.txtVin.Location = new System.Drawing.Point(118, 39);
            this.txtVin.Name = "txtVin";
            this.txtVin.Size = new System.Drawing.Size(139, 20);
            this.txtVin.TabIndex = 7;
            // 
            // btnFindInventory
            // 
            this.btnFindInventory.Location = new System.Drawing.Point(47, 370);
            this.btnFindInventory.Name = "btnFindInventory";
            this.btnFindInventory.Size = new System.Drawing.Size(75, 23);
            this.btnFindInventory.TabIndex = 15;
            this.btnFindInventory.Text = "Find";
            this.btnFindInventory.UseVisualStyleBackColor = true;
            this.btnFindInventory.Click += new System.EventHandler(this.btnVehAdd_Click);
            // 
            // btnVehCancel
            // 
            this.btnVehCancel.Location = new System.Drawing.Point(242, 370);
            this.btnVehCancel.Name = "btnVehCancel";
            this.btnVehCancel.Size = new System.Drawing.Size(75, 23);
            this.btnVehCancel.TabIndex = 16;
            this.btnVehCancel.Text = "Cancel";
            this.btnVehCancel.UseVisualStyleBackColor = true;
            this.btnVehCancel.Click += new System.EventHandler(this.btnVehCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = " Color";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(118, 282);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(120, 20);
            this.txtColor.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "CustomerID";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(118, 325);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(120, 20);
            this.txtCustomerID.TabIndex = 24;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(118, 83);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 25;
            this.txtYear.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbMake
            // 
            this.cbMake.FormattingEnabled = true;
            this.cbMake.Items.AddRange(new object[] {
            "Audi",
            "BMW",
            "Bugatti",
            "Buick",
            "Cadillac",
            "Cheverolet",
            "Dodge",
            "Ford",
            "GMC",
            "Mercedes",
            "Mitsubishi",
            "Nissan",
            "Toyota"});
            this.cbMake.Location = new System.Drawing.Point(117, 132);
            this.cbMake.Name = "cbMake";
            this.cbMake.Size = new System.Drawing.Size(121, 21);
            this.cbMake.TabIndex = 26;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(118, 181);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 27;
            // 
            // cbQuality
            // 
            this.cbQuality.FormattingEnabled = true;
            this.cbQuality.Items.AddRange(new object[] {
            "New",
            "Used"});
            this.cbQuality.Location = new System.Drawing.Point(118, 228);
            this.cbQuality.Name = "cbQuality";
            this.cbQuality.Size = new System.Drawing.Size(53, 21);
            this.cbQuality.TabIndex = 28;
            this.cbQuality.SelectedIndexChanged += new System.EventHandler(this.cbQuality_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Damaged";
            // 
            // cbDamaged
            // 
            this.cbDamaged.FormattingEnabled = true;
            this.cbDamaged.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.cbDamaged.Location = new System.Drawing.Point(244, 233);
            this.cbDamaged.Name = "cbDamaged";
            this.cbDamaged.Size = new System.Drawing.Size(45, 21);
            this.cbDamaged.TabIndex = 30;
            // 
            // FindInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 405);
            this.Controls.Add(this.cbDamaged);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbQuality);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.cbMake);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVehCancel);
            this.Controls.Add(this.btnFindInventory);
            this.Controls.Add(this.txtVin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblQuality);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblVin);
            this.Name = "FindInventory";
            this.Text = "Find Inventory";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FindInventory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblQuality;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVin;
        private System.Windows.Forms.Button btnFindInventory;
        private System.Windows.Forms.Button btnVehCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.ComboBox cbMake;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.ComboBox cbQuality;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDamaged;
    }
}