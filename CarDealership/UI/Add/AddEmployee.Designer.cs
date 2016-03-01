namespace CarDealership
{
    partial class AddEmployee
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
            this.txtEmpNum = new System.Windows.Forms.TextBox();
            this.txtEmpFName = new System.Windows.Forms.TextBox();
            this.txtEmpLName = new System.Windows.Forms.TextBox();
            this.txtEmpDOB = new System.Windows.Forms.TextBox();
            this.txtEmpAddress = new System.Windows.Forms.TextBox();
            this.txtEmpCity = new System.Windows.Forms.TextBox();
            this.ddEmpStates = new System.Windows.Forms.DomainUpDown();
            this.btnEmpAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DOB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "State";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "City";
            // 
            // txtEmpNum
            // 
            this.txtEmpNum.Location = new System.Drawing.Point(134, 70);
            this.txtEmpNum.Name = "txtEmpNum";
            this.txtEmpNum.Size = new System.Drawing.Size(66, 20);
            this.txtEmpNum.TabIndex = 7;
            // 
            // txtEmpFName
            // 
            this.txtEmpFName.Location = new System.Drawing.Point(134, 129);
            this.txtEmpFName.Name = "txtEmpFName";
            this.txtEmpFName.Size = new System.Drawing.Size(163, 20);
            this.txtEmpFName.TabIndex = 8;
            // 
            // txtEmpLName
            // 
            this.txtEmpLName.Location = new System.Drawing.Point(134, 182);
            this.txtEmpLName.Name = "txtEmpLName";
            this.txtEmpLName.Size = new System.Drawing.Size(163, 20);
            this.txtEmpLName.TabIndex = 9;
            this.txtEmpLName.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtEmpDOB
            // 
            this.txtEmpDOB.Location = new System.Drawing.Point(134, 239);
            this.txtEmpDOB.Name = "txtEmpDOB";
            this.txtEmpDOB.Size = new System.Drawing.Size(163, 20);
            this.txtEmpDOB.TabIndex = 10;
            // 
            // txtEmpAddress
            // 
            this.txtEmpAddress.Location = new System.Drawing.Point(134, 289);
            this.txtEmpAddress.Name = "txtEmpAddress";
            this.txtEmpAddress.Size = new System.Drawing.Size(163, 20);
            this.txtEmpAddress.TabIndex = 11;
            // 
            // txtEmpCity
            // 
            this.txtEmpCity.Location = new System.Drawing.Point(134, 335);
            this.txtEmpCity.Name = "txtEmpCity";
            this.txtEmpCity.Size = new System.Drawing.Size(163, 20);
            this.txtEmpCity.TabIndex = 13;
            // 
            // ddEmpStates
            // 
            this.ddEmpStates.AllowDrop = true;
            this.ddEmpStates.Items.Add("AL");
            this.ddEmpStates.Items.Add("AK");
            this.ddEmpStates.Items.Add("AZ");
            this.ddEmpStates.Items.Add("AR");
            this.ddEmpStates.Items.Add("CA");
            this.ddEmpStates.Items.Add("CO");
            this.ddEmpStates.Items.Add("CT");
            this.ddEmpStates.Items.Add("DE");
            this.ddEmpStates.Items.Add("DC");
            this.ddEmpStates.Items.Add("FL");
            this.ddEmpStates.Items.Add("GA");
            this.ddEmpStates.Items.Add("HI");
            this.ddEmpStates.Items.Add("ID");
            this.ddEmpStates.Items.Add("IL");
            this.ddEmpStates.Items.Add("IN");
            this.ddEmpStates.Items.Add("IA");
            this.ddEmpStates.Items.Add("KS");
            this.ddEmpStates.Items.Add("KY");
            this.ddEmpStates.Items.Add("LA");
            this.ddEmpStates.Items.Add("ME");
            this.ddEmpStates.Items.Add("MD");
            this.ddEmpStates.Items.Add("MA");
            this.ddEmpStates.Items.Add("MI");
            this.ddEmpStates.Items.Add("MN");
            this.ddEmpStates.Items.Add("MS");
            this.ddEmpStates.Items.Add("MO");
            this.ddEmpStates.Items.Add("MT");
            this.ddEmpStates.Items.Add("NE");
            this.ddEmpStates.Items.Add("NV");
            this.ddEmpStates.Items.Add("NH");
            this.ddEmpStates.Items.Add("NJ");
            this.ddEmpStates.Items.Add("NM");
            this.ddEmpStates.Items.Add("NY");
            this.ddEmpStates.Items.Add("NC");
            this.ddEmpStates.Items.Add("ND");
            this.ddEmpStates.Items.Add("OH");
            this.ddEmpStates.Items.Add("OK");
            this.ddEmpStates.Items.Add("OR");
            this.ddEmpStates.Items.Add("PA");
            this.ddEmpStates.Items.Add("RI");
            this.ddEmpStates.Items.Add("SC");
            this.ddEmpStates.Items.Add("SD");
            this.ddEmpStates.Items.Add("TN");
            this.ddEmpStates.Items.Add("TX");
            this.ddEmpStates.Items.Add("UT");
            this.ddEmpStates.Items.Add("VT");
            this.ddEmpStates.Items.Add("VA");
            this.ddEmpStates.Items.Add("WA");
            this.ddEmpStates.Items.Add("WV");
            this.ddEmpStates.Items.Add("WI");
            this.ddEmpStates.Items.Add("WY");
            this.ddEmpStates.Location = new System.Drawing.Point(358, 335);
            this.ddEmpStates.Name = "ddEmpStates";
            this.ddEmpStates.Size = new System.Drawing.Size(40, 20);
            this.ddEmpStates.TabIndex = 14;
            this.ddEmpStates.UseWaitCursor = true;
            // 
            // btnEmpAdd
            // 
            this.btnEmpAdd.Location = new System.Drawing.Point(73, 370);
            this.btnEmpAdd.Name = "btnEmpAdd";
            this.btnEmpAdd.Size = new System.Drawing.Size(75, 23);
            this.btnEmpAdd.TabIndex = 15;
            this.btnEmpAdd.Text = "Add";
            this.btnEmpAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(262, 370);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 405);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEmpAdd);
            this.Controls.Add(this.ddEmpStates);
            this.Controls.Add(this.txtEmpCity);
            this.Controls.Add(this.txtEmpAddress);
            this.Controls.Add(this.txtEmpDOB);
            this.Controls.Add(this.txtEmpLName);
            this.Controls.Add(this.txtEmpFName);
            this.Controls.Add(this.txtEmpNum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEmployee";
            this.Text = "Add Employee";
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
        private System.Windows.Forms.TextBox txtEmpNum;
        private System.Windows.Forms.TextBox txtEmpFName;
        private System.Windows.Forms.TextBox txtEmpLName;
        private System.Windows.Forms.TextBox txtEmpDOB;
        private System.Windows.Forms.TextBox txtEmpAddress;
        private System.Windows.Forms.TextBox txtEmpCity;
        private System.Windows.Forms.DomainUpDown ddEmpStates;
        private System.Windows.Forms.Button btnEmpAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}