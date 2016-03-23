namespace CarDealership
{
    partial class AddInventory
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
            this.txtVehicleID = new System.Windows.Forms.TextBox();
            this.btnVehAdd = new System.Windows.Forms.Button();
            this.btnVehCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ddVehicleMake = new System.Windows.Forms.DomainUpDown();
            this.ddVehicleModel = new System.Windows.Forms.DomainUpDown();
            this.ddVehicleYear = new System.Windows.Forms.DomainUpDown();
            this.txtVehicleColor = new System.Windows.Forms.TextBox();
            this.ddVehicleCondition = new System.Windows.Forms.DomainUpDown();
            this.cbTradeIn = new System.Windows.Forms.CheckBox();
            this.rbCustID = new System.Windows.Forms.RadioButton();
            this.rbNewCustomBool = new System.Windows.Forms.RadioButton();
            this.txtCustID = new System.Windows.Forms.TextBox();
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
            // txtVehicleID
            // 
            this.txtVehicleID.Location = new System.Drawing.Point(118, 46);
            this.txtVehicleID.Name = "txtVehicleID";
            this.txtVehicleID.Size = new System.Drawing.Size(66, 20);
            this.txtVehicleID.TabIndex = 7;
            // 
            // btnVehAdd
            // 
            this.btnVehAdd.Location = new System.Drawing.Point(29, 429);
            this.btnVehAdd.Name = "btnVehAdd";
            this.btnVehAdd.Size = new System.Drawing.Size(75, 23);
            this.btnVehAdd.TabIndex = 15;
            this.btnVehAdd.Text = "Add";
            this.btnVehAdd.UseVisualStyleBackColor = true;
            this.btnVehAdd.Click += new System.EventHandler(this.btnVehAdd_Click);
            // 
            // btnVehCancel
            // 
            this.btnVehCancel.Location = new System.Drawing.Point(276, 429);
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
            // ddVehicleMake
            // 
            this.ddVehicleMake.Items.Add("Audi");
            this.ddVehicleMake.Items.Add("Chevrolet");
            this.ddVehicleMake.Items.Add("Ford");
            this.ddVehicleMake.Items.Add("Bugatti");
            this.ddVehicleMake.Items.Add("BMW");
            this.ddVehicleMake.Items.Add("GMC");
            this.ddVehicleMake.Items.Add("Toyota");
            this.ddVehicleMake.Items.Add("Chrysler");
            this.ddVehicleMake.Items.Add("Dodge");
            this.ddVehicleMake.Items.Add("BuickKia");
            this.ddVehicleMake.Items.Add("Land Rover");
            this.ddVehicleMake.Items.Add("Honda");
            this.ddVehicleMake.Location = new System.Drawing.Point(118, 133);
            this.ddVehicleMake.Name = "ddVehicleMake";
            this.ddVehicleMake.Size = new System.Drawing.Size(120, 20);
            this.ddVehicleMake.TabIndex = 18;
            // 
            // ddVehicleModel
            // 
            this.ddVehicleModel.Items.Add("Blah");
            this.ddVehicleModel.Items.Add("Blah");
            this.ddVehicleModel.Items.Add("Blah");
            this.ddVehicleModel.Items.Add("Blah");
            this.ddVehicleModel.Items.Add("Blah");
            this.ddVehicleModel.Items.Add("Blah");
            this.ddVehicleModel.Items.Add("What !");
            this.ddVehicleModel.Items.Add("Blah");
            this.ddVehicleModel.Items.Add("Blah");
            this.ddVehicleModel.Items.Add("Blah");
            this.ddVehicleModel.Items.Add("Blah");
            this.ddVehicleModel.Location = new System.Drawing.Point(118, 186);
            this.ddVehicleModel.Name = "ddVehicleModel";
            this.ddVehicleModel.Size = new System.Drawing.Size(120, 20);
            this.ddVehicleModel.TabIndex = 19;
            // 
            // ddVehicleYear
            // 
            this.ddVehicleYear.Location = new System.Drawing.Point(118, 83);
            this.ddVehicleYear.Name = "ddVehicleYear";
            this.ddVehicleYear.Size = new System.Drawing.Size(120, 20);
            this.ddVehicleYear.TabIndex = 20;
            // 
            // txtVehicleColor
            // 
            this.txtVehicleColor.Location = new System.Drawing.Point(118, 282);
            this.txtVehicleColor.Name = "txtVehicleColor";
            this.txtVehicleColor.Size = new System.Drawing.Size(120, 20);
            this.txtVehicleColor.TabIndex = 21;
            // 
            // ddVehicleCondition
            // 
            this.ddVehicleCondition.AllowDrop = true;
            this.ddVehicleCondition.Items.Add("2017");
            this.ddVehicleCondition.Items.Add("2016");
            this.ddVehicleCondition.Items.Add("2015");
            this.ddVehicleCondition.Items.Add("2014");
            this.ddVehicleCondition.Items.Add("2013");
            this.ddVehicleCondition.Items.Add("2012");
            this.ddVehicleCondition.Items.Add("2011");
            this.ddVehicleCondition.Items.Add("2010");
            this.ddVehicleCondition.Items.Add("2009");
            this.ddVehicleCondition.Items.Add("2008");
            this.ddVehicleCondition.Items.Add("2007");
            this.ddVehicleCondition.Items.Add("2006");
            this.ddVehicleCondition.Items.Add("2005");
            this.ddVehicleCondition.Items.Add("2004");
            this.ddVehicleCondition.Items.Add("2003");
            this.ddVehicleCondition.Items.Add("2002");
            this.ddVehicleCondition.Items.Add("2001");
            this.ddVehicleCondition.Items.Add("2000");
            this.ddVehicleCondition.Items.Add("1999");
            this.ddVehicleCondition.Location = new System.Drawing.Point(118, 236);
            this.ddVehicleCondition.Name = "ddVehicleCondition";
            this.ddVehicleCondition.Size = new System.Drawing.Size(120, 20);
            this.ddVehicleCondition.TabIndex = 22;
            // 
            // cbTradeIn
            // 
            this.cbTradeIn.AutoSize = true;
            this.cbTradeIn.Location = new System.Drawing.Point(47, 320);
            this.cbTradeIn.Name = "cbTradeIn";
            this.cbTradeIn.Size = new System.Drawing.Size(66, 17);
            this.cbTradeIn.TabIndex = 25;
            this.cbTradeIn.Text = "Trade In";
            this.cbTradeIn.UseVisualStyleBackColor = true;
            this.cbTradeIn.CheckedChanged += new System.EventHandler(this.cbTradeIn_CheckedChanged);
            // 
            // rbCustID
            // 
            this.rbCustID.AutoSize = true;
            this.rbCustID.Location = new System.Drawing.Point(45, 362);
            this.rbCustID.Name = "rbCustID";
            this.rbCustID.Size = new System.Drawing.Size(63, 17);
            this.rbCustID.TabIndex = 28;
            this.rbCustID.TabStop = true;
            this.rbCustID.Text = "Cust. ID";
            this.rbCustID.UseVisualStyleBackColor = true;
            this.rbCustID.CheckedChanged += new System.EventHandler(this.rbCustID_CheckedChanged);
            // 
            // rbNewCustomBool
            // 
            this.rbNewCustomBool.AutoSize = true;
            this.rbNewCustomBool.Location = new System.Drawing.Point(228, 362);
            this.rbNewCustomBool.Name = "rbNewCustomBool";
            this.rbNewCustomBool.Size = new System.Drawing.Size(94, 17);
            this.rbNewCustomBool.TabIndex = 29;
            this.rbNewCustomBool.TabStop = true;
            this.rbNewCustomBool.Text = "New Customer";
            this.rbNewCustomBool.UseVisualStyleBackColor = true;
            this.rbNewCustomBool.CheckedChanged += new System.EventHandler(this.rbNewCustomBool_CheckedChanged);
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(122, 359);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(100, 20);
            this.txtCustID.TabIndex = 30;
            // 
            // AddInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 464);
            this.Controls.Add(this.txtCustID);
            this.Controls.Add(this.rbNewCustomBool);
            this.Controls.Add(this.rbCustID);
            this.Controls.Add(this.cbTradeIn);
            this.Controls.Add(this.ddVehicleCondition);
            this.Controls.Add(this.txtVehicleColor);
            this.Controls.Add(this.ddVehicleYear);
            this.Controls.Add(this.ddVehicleModel);
            this.Controls.Add(this.ddVehicleMake);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVehCancel);
            this.Controls.Add(this.btnVehAdd);
            this.Controls.Add(this.txtVehicleID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddInventory";
            this.Text = "Add Vehicle";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddInventory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVehicleID;
        private System.Windows.Forms.Button btnVehAdd;
        private System.Windows.Forms.Button btnVehCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DomainUpDown ddVehicleMake;
        private System.Windows.Forms.DomainUpDown ddVehicleModel;
        private System.Windows.Forms.DomainUpDown ddVehicleYear;
        private System.Windows.Forms.TextBox txtVehicleColor;
        private System.Windows.Forms.DomainUpDown ddVehicleCondition;
        private System.Windows.Forms.CheckBox cbTradeIn;
        private System.Windows.Forms.RadioButton rbCustID;
        private System.Windows.Forms.RadioButton rbNewCustomBool;
        private System.Windows.Forms.TextBox txtCustID;
    }
}