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
            this.txtState = new System.Windows.Forms.DomainUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ddVehicle = new System.Windows.Forms.DomainUpDown();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DOB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "State";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "City";
            // 
            // txtCusID
            // 
            this.txtCusID.Location = new System.Drawing.Point(118, 70);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.Size = new System.Drawing.Size(66, 20);
            this.txtCusID.TabIndex = 7;
            // 
            // txtCusFirstName
            // 
            this.txtCusFirstName.Location = new System.Drawing.Point(118, 129);
            this.txtCusFirstName.Name = "txtCusFirstName";
            this.txtCusFirstName.Size = new System.Drawing.Size(163, 20);
            this.txtCusFirstName.TabIndex = 8;
            // 
            // txtCusLastName
            // 
            this.txtCusLastName.Location = new System.Drawing.Point(118, 182);
            this.txtCusLastName.Name = "txtCusLastName";
            this.txtCusLastName.Size = new System.Drawing.Size(163, 20);
            this.txtCusLastName.TabIndex = 9;
            this.txtCusLastName.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(118, 239);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(163, 20);
            this.txtDOB.TabIndex = 10;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(118, 289);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(163, 20);
            this.txtAddress.TabIndex = 11;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(118, 335);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(163, 20);
            this.txtCity.TabIndex = 13;
            // 
            // txtState
            // 
            this.txtState.AllowDrop = true;
            this.txtState.Items.Add("AL");
            this.txtState.Items.Add("AK");
            this.txtState.Items.Add("AZ");
            this.txtState.Items.Add("AR");
            this.txtState.Items.Add("CA");
            this.txtState.Items.Add("CO");
            this.txtState.Items.Add("CT");
            this.txtState.Items.Add("DE");
            this.txtState.Items.Add("DC");
            this.txtState.Items.Add("FL");
            this.txtState.Items.Add("GA");
            this.txtState.Items.Add("HI");
            this.txtState.Items.Add("ID");
            this.txtState.Items.Add("IL");
            this.txtState.Items.Add("IN");
            this.txtState.Items.Add("IA");
            this.txtState.Items.Add("KS");
            this.txtState.Items.Add("KY");
            this.txtState.Items.Add("LA");
            this.txtState.Items.Add("ME");
            this.txtState.Items.Add("MD");
            this.txtState.Items.Add("MA");
            this.txtState.Items.Add("MI");
            this.txtState.Items.Add("MN");
            this.txtState.Items.Add("MS");
            this.txtState.Items.Add("MO");
            this.txtState.Items.Add("MT");
            this.txtState.Items.Add("NE");
            this.txtState.Items.Add("NV");
            this.txtState.Items.Add("NH");
            this.txtState.Items.Add("NJ");
            this.txtState.Items.Add("NM");
            this.txtState.Items.Add("NY");
            this.txtState.Items.Add("NC");
            this.txtState.Items.Add("ND");
            this.txtState.Items.Add("OH");
            this.txtState.Items.Add("OK");
            this.txtState.Items.Add("OR");
            this.txtState.Items.Add("PA");
            this.txtState.Items.Add("RI");
            this.txtState.Items.Add("SC");
            this.txtState.Items.Add("SD");
            this.txtState.Items.Add("TN");
            this.txtState.Items.Add("TX");
            this.txtState.Items.Add("UT");
            this.txtState.Items.Add("VT");
            this.txtState.Items.Add("VA");
            this.txtState.Items.Add("WA");
            this.txtState.Items.Add("WV");
            this.txtState.Items.Add("WI");
            this.txtState.Items.Add("WY");
            this.txtState.Location = new System.Drawing.Point(336, 335);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(40, 20);
            this.txtState.TabIndex = 14;
            this.txtState.UseWaitCursor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(97, 370);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(255, 370);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ddVehicle
            // 
            this.ddVehicle.Location = new System.Drawing.Point(331, 130);
            this.ddVehicle.Name = "ddVehicle";
            this.ddVehicle.Size = new System.Drawing.Size(120, 20);
            this.ddVehicle.TabIndex = 17;
            this.ddVehicle.Text = "domainUpDown1";
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 436);
            this.Controls.Add(this.ddVehicle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtState);
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
        private System.Windows.Forms.DomainUpDown txtState;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DomainUpDown ddVehicle;
    }
}