namespace CarDealership
{
    partial class FindEmployee
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmpNum = new System.Windows.Forms.TextBox();
            this.txtEmpFName = new System.Windows.Forms.TextBox();
            this.txtEmpLName = new System.Windows.Forms.TextBox();
            this.btnFindEmp = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPosition = new System.Windows.Forms.TextBox();
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 242);
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
            // btnFindEmp
            // 
            this.btnFindEmp.Location = new System.Drawing.Point(73, 283);
            this.btnFindEmp.Name = "btnFindEmp";
            this.btnFindEmp.Size = new System.Drawing.Size(113, 23);
            this.btnFindEmp.TabIndex = 15;
            this.btnFindEmp.Text = "Find";
            this.btnFindEmp.UseVisualStyleBackColor = true;
            this.btnFindEmp.Click += new System.EventHandler(this.btnEmpAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(258, 283);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(134, 235);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(163, 20);
            this.txtPosition.TabIndex = 13;
            // 
            // FindEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 322);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFindEmp);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.txtEmpLName);
            this.Controls.Add(this.txtEmpFName);
            this.Controls.Add(this.txtEmpNum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FindEmployee";
            this.Text = "Find Employee";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FindEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmpNum;
        private System.Windows.Forms.TextBox txtEmpFName;
        private System.Windows.Forms.TextBox txtEmpLName;
        private System.Windows.Forms.Button btnFindEmp;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtPosition;
    }
}