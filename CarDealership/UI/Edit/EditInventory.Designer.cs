namespace CarDealership
{
    partial class EditInventory
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnVehCommit = new System.Windows.Forms.Button();
            this.btnVehCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ddMake = new System.Windows.Forms.DomainUpDown();
            this.ddModel = new System.Windows.Forms.DomainUpDown();
            this.ddYear = new System.Windows.Forms.DomainUpDown();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.ddCondition = new System.Windows.Forms.DomainUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.cbSold = new System.Windows.Forms.CheckBox();
            this.cbOnLot = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "VehicleID";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = " Condition";
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
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(118, 46);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(66, 20);
            this.txtID.TabIndex = 7;
            // 
            // btnVehCommit
            // 
            this.btnVehCommit.Location = new System.Drawing.Point(29, 370);
            this.btnVehCommit.Name = "btnVehCommit";
            this.btnVehCommit.Size = new System.Drawing.Size(75, 23);
            this.btnVehCommit.TabIndex = 15;
            this.btnVehCommit.Text = "Commit";
            this.btnVehCommit.UseVisualStyleBackColor = true;
            // 
            // btnVehCancel
            // 
            this.btnVehCancel.Location = new System.Drawing.Point(237, 370);
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
            // ddMake
            // 
            this.ddMake.Items.Add("Audi");
            this.ddMake.Items.Add("Chevrolet");
            this.ddMake.Items.Add("Ford");
            this.ddMake.Items.Add("Bugatti");
            this.ddMake.Items.Add("BMW");
            this.ddMake.Items.Add("GMC");
            this.ddMake.Items.Add("Toyota");
            this.ddMake.Items.Add("Chrysler");
            this.ddMake.Items.Add("Dodge");
            this.ddMake.Items.Add("BuickKia");
            this.ddMake.Items.Add("Land Rover");
            this.ddMake.Items.Add("Honda");
            this.ddMake.Location = new System.Drawing.Point(118, 133);
            this.ddMake.Name = "ddMake";
            this.ddMake.Size = new System.Drawing.Size(120, 20);
            this.ddMake.TabIndex = 18;
            // 
            // ddModel
            // 
            this.ddModel.Items.Add("Blah");
            this.ddModel.Items.Add("Blah");
            this.ddModel.Items.Add("Blah");
            this.ddModel.Items.Add("Blah");
            this.ddModel.Items.Add("Blah");
            this.ddModel.Items.Add("Blah");
            this.ddModel.Items.Add("What !");
            this.ddModel.Items.Add("Blah");
            this.ddModel.Items.Add("Blah");
            this.ddModel.Items.Add("Blah");
            this.ddModel.Items.Add("Blah");
            this.ddModel.Location = new System.Drawing.Point(118, 186);
            this.ddModel.Name = "ddModel";
            this.ddModel.Size = new System.Drawing.Size(120, 20);
            this.ddModel.TabIndex = 19;
            // 
            // ddYear
            // 
            this.ddYear.Location = new System.Drawing.Point(118, 83);
            this.ddYear.Name = "ddYear";
            this.ddYear.Size = new System.Drawing.Size(120, 20);
            this.ddYear.TabIndex = 20;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(118, 282);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(120, 20);
            this.txtColor.TabIndex = 21;
            // 
            // ddCondition
            // 
            this.ddCondition.AllowDrop = true;
            this.ddCondition.Items.Add("2017");
            this.ddCondition.Items.Add("2016");
            this.ddCondition.Items.Add("2015");
            this.ddCondition.Items.Add("2014");
            this.ddCondition.Items.Add("2013");
            this.ddCondition.Items.Add("2012");
            this.ddCondition.Items.Add("2011");
            this.ddCondition.Items.Add("2010");
            this.ddCondition.Items.Add("2009");
            this.ddCondition.Items.Add("2008");
            this.ddCondition.Items.Add("2007");
            this.ddCondition.Items.Add("2006");
            this.ddCondition.Items.Add("2005");
            this.ddCondition.Items.Add("2004");
            this.ddCondition.Items.Add("2003");
            this.ddCondition.Items.Add("2002");
            this.ddCondition.Items.Add("2001");
            this.ddCondition.Items.Add("2000");
            this.ddCondition.Items.Add("1999");
            this.ddCondition.Location = new System.Drawing.Point(118, 236);
            this.ddCondition.Name = "ddCondition";
            this.ddCondition.Size = new System.Drawing.Size(120, 20);
            this.ddCondition.TabIndex = 22;
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
            // cbSold
            // 
            this.cbSold.AutoSize = true;
            this.cbSold.Location = new System.Drawing.Point(291, 116);
            this.cbSold.Name = "cbSold";
            this.cbSold.Size = new System.Drawing.Size(47, 17);
            this.cbSold.TabIndex = 25;
            this.cbSold.Text = "Sold";
            this.cbSold.UseVisualStyleBackColor = true;
            // 
            // cbOnLot
            // 
            this.cbOnLot.AutoSize = true;
            this.cbOnLot.Location = new System.Drawing.Point(291, 188);
            this.cbOnLot.Name = "cbOnLot";
            this.cbOnLot.Size = new System.Drawing.Size(58, 17);
            this.cbOnLot.TabIndex = 26;
            this.cbOnLot.Text = "On Lot";
            this.cbOnLot.UseVisualStyleBackColor = true;
            // 
            // EditInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 398);
            this.Controls.Add(this.cbOnLot);
            this.Controls.Add(this.cbSold);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ddCondition);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.ddYear);
            this.Controls.Add(this.ddModel);
            this.Controls.Add(this.ddMake);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVehCancel);
            this.Controls.Add(this.btnVehCommit);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditInventory";
            this.Text = "Edit Vehicle";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.EditInventory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnVehCommit;
        private System.Windows.Forms.Button btnVehCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DomainUpDown ddMake;
        private System.Windows.Forms.DomainUpDown ddModel;
        private System.Windows.Forms.DomainUpDown ddYear;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.DomainUpDown ddCondition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.CheckBox cbSold;
        private System.Windows.Forms.CheckBox cbOnLot;
    }
}