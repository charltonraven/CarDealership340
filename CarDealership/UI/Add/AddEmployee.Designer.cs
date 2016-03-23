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
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmpNum = new System.Windows.Forms.TextBox();
            this.txtEmpFName = new System.Windows.Forms.TextBox();
            this.txtEmpLName = new System.Windows.Forms.TextBox();
            this.txtEmpHireDate = new System.Windows.Forms.TextBox();
            this.btnEmpAdd = new System.Windows.Forms.Button();
            this.btnEmpCancel = new System.Windows.Forms.Button();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
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
            this.label4.Location = new System.Drawing.Point(70, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hire Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Salary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Position";
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
            // txtEmpHireDate
            // 
            this.txtEmpHireDate.Location = new System.Drawing.Point(134, 239);
            this.txtEmpHireDate.Name = "txtEmpHireDate";
            this.txtEmpHireDate.Size = new System.Drawing.Size(163, 20);
            this.txtEmpHireDate.TabIndex = 10;
            // 
            // btnEmpAdd
            // 
            this.btnEmpAdd.Location = new System.Drawing.Point(73, 403);
            this.btnEmpAdd.Name = "btnEmpAdd";
            this.btnEmpAdd.Size = new System.Drawing.Size(75, 23);
            this.btnEmpAdd.TabIndex = 15;
            this.btnEmpAdd.Text = "Add";
            this.btnEmpAdd.UseVisualStyleBackColor = true;
            this.btnEmpAdd.Click += new System.EventHandler(this.btnEmpAdd_Click);
            // 
            // btnEmpCancel
            // 
            this.btnEmpCancel.Location = new System.Drawing.Point(262, 403);
            this.btnEmpCancel.Name = "btnEmpCancel";
            this.btnEmpCancel.Size = new System.Drawing.Size(75, 23);
            this.btnEmpCancel.TabIndex = 16;
            this.btnEmpCancel.Text = "Cancel";
            this.btnEmpCancel.UseVisualStyleBackColor = true;
            this.btnEmpCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(134, 289);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(66, 20);
            this.txtSalary.TabIndex = 11;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(134, 335);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(163, 20);
            this.txtPosition.TabIndex = 13;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(134, 377);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(163, 20);
            this.txtPassword.TabIndex = 17;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Password";
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 456);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnEmpCancel);
            this.Controls.Add(this.btnEmpAdd);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtEmpHireDate);
            this.Controls.Add(this.txtEmpLName);
            this.Controls.Add(this.txtEmpFName);
            this.Controls.Add(this.txtEmpNum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEmployee";
            this.Text = "Add Employee";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmpNum;
        private System.Windows.Forms.TextBox txtEmpFName;
        private System.Windows.Forms.TextBox txtEmpLName;
        private System.Windows.Forms.TextBox txtEmpHireDate;
        private System.Windows.Forms.Button btnEmpAdd;
        private System.Windows.Forms.Button btnEmpCancel;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label6;
    }
}