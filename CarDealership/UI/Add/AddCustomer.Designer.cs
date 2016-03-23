namespace CarDealership
{
    partial class AddCustomer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCusID = new System.Windows.Forms.TextBox();
            this.txtCusFirstName = new System.Windows.Forms.TextBox();
            this.txtCusLastName = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ddVehicle = new System.Windows.Forms.DomainUpDown();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.ddState = new System.Windows.Forms.DomainUpDown();
            this.txtState = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DOB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "State";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "City";
            // 
            // txtCusID
            // 
            this.txtCusID.Location = new System.Drawing.Point(118, 25);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.Size = new System.Drawing.Size(66, 20);
            this.txtCusID.TabIndex = 7;
            // 
            // txtCusFirstName
            // 
            this.txtCusFirstName.Location = new System.Drawing.Point(118, 64);
            this.txtCusFirstName.Name = "txtCusFirstName";
            this.txtCusFirstName.Size = new System.Drawing.Size(163, 20);
            this.txtCusFirstName.TabIndex = 8;
            // 
            // txtCusLastName
            // 
            this.txtCusLastName.Location = new System.Drawing.Point(118, 96);
            this.txtCusLastName.Name = "txtCusLastName";
            this.txtCusLastName.Size = new System.Drawing.Size(163, 20);
            this.txtCusLastName.TabIndex = 9;
            this.txtCusLastName.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(118, 129);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(163, 20);
            this.txtDOB.TabIndex = 10;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(118, 204);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(163, 20);
            this.txtAddress.TabIndex = 11;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(118, 240);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(163, 20);
            this.txtCity.TabIndex = 13;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(82, 302);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(223, 302);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ddVehicle
            // 
            this.ddVehicle.Location = new System.Drawing.Point(320, 137);
            this.ddVehicle.Name = "ddVehicle";
            this.ddVehicle.Size = new System.Drawing.Size(120, 20);
            this.ddVehicle.TabIndex = 17;
            this.ddVehicle.Text = "domainUpDown1";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(118, 166);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(163, 20);
            this.txtPhone.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Phone Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(290, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Zip Code";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(346, 236);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(64, 20);
            this.txtZip.TabIndex = 21;
            // 
            // ddState
            // 
            this.ddState.AllowDrop = true;
            this.ddState.Items.Add("AL");
            this.ddState.Items.Add("AK");
            this.ddState.Items.Add("AZ");
            this.ddState.Items.Add("AR");
            this.ddState.Items.Add("CA");
            this.ddState.Items.Add("CO");
            this.ddState.Items.Add("CT");
            this.ddState.Items.Add("DE");
            this.ddState.Items.Add("DC");
            this.ddState.Items.Add("FL");
            this.ddState.Items.Add("GA");
            this.ddState.Items.Add("HI");
            this.ddState.Items.Add("ID");
            this.ddState.Items.Add("IL");
            this.ddState.Items.Add("IN");
            this.ddState.Items.Add("IA");
            this.ddState.Items.Add("KS");
            this.ddState.Items.Add("KY");
            this.ddState.Items.Add("LA");
            this.ddState.Items.Add("ME");
            this.ddState.Items.Add("MD");
            this.ddState.Items.Add("MA");
            this.ddState.Items.Add("MI");
            this.ddState.Items.Add("MN");
            this.ddState.Items.Add("MS");
            this.ddState.Items.Add("MO");
            this.ddState.Items.Add("MT");
            this.ddState.Items.Add("NE");
            this.ddState.Items.Add("NV");
            this.ddState.Items.Add("NH");
            this.ddState.Items.Add("NJ");
            this.ddState.Items.Add("NM");
            this.ddState.Items.Add("NY");
            this.ddState.Items.Add("NC");
            this.ddState.Items.Add("ND");
            this.ddState.Items.Add("OH");
            this.ddState.Items.Add("OK");
            this.ddState.Items.Add("OR");
            this.ddState.Items.Add("PA");
            this.ddState.Items.Add("RI");
            this.ddState.Items.Add("SC");
            this.ddState.Items.Add("SD");
            this.ddState.Items.Add("TN");
            this.ddState.Items.Add("TX");
            this.ddState.Items.Add("UT");
            this.ddState.Items.Add("VT");
            this.ddState.Items.Add("VA");
            this.ddState.Items.Add("WA");
            this.ddState.Items.Add("WV");
            this.ddState.Items.Add("WI");
            this.ddState.Items.Add("WY");
            this.ddState.Location = new System.Drawing.Point(337, 87);
            this.ddState.Name = "ddState";
            this.ddState.Size = new System.Drawing.Size(42, 20);
            this.ddState.TabIndex = 22;
            this.ddState.SelectedItemChanged += new System.EventHandler(this.ddState_SelectedItemChanged);
            this.ddState.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ddState_MouseDown);
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(346, 204);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(33, 20);
            this.txtState.TabIndex = 23;
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 442);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.ddState);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.ddVehicle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.txtCusLastName);
            this.Controls.Add(this.txtCusFirstName);
            this.Controls.Add(this.txtCusID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCustomer";
            this.Text = "Add Customer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCusID;
        private System.Windows.Forms.TextBox txtCusFirstName;
        private System.Windows.Forms.TextBox txtCusLastName;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DomainUpDown ddVehicle;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.DomainUpDown ddState;
        private System.Windows.Forms.TextBox txtState;
    }
}