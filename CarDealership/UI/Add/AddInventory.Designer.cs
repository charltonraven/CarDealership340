﻿namespace CarDealership
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtVehicleID = new System.Windows.Forms.TextBox();
            this.btnVehAdd = new System.Windows.Forms.Button();
            this.btnVehCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVehicleColor = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMake = new System.Windows.Forms.ComboBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
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
            this.txtVehicleID.Size = new System.Drawing.Size(136, 20);
            this.txtVehicleID.TabIndex = 7;
            this.txtVehicleID.TextChanged += new System.EventHandler(this.txtVehicleID_TextChanged);
            // 
            // btnVehAdd
            // 
            this.btnVehAdd.Location = new System.Drawing.Point(22, 350);
            this.btnVehAdd.Name = "btnVehAdd";
            this.btnVehAdd.Size = new System.Drawing.Size(75, 23);
            this.btnVehAdd.TabIndex = 15;
            this.btnVehAdd.Text = "Add";
            this.btnVehAdd.UseVisualStyleBackColor = true;
            this.btnVehAdd.Click += new System.EventHandler(this.btnVehAdd_Click);
            // 
            // btnVehCancel
            // 
            this.btnVehCancel.Location = new System.Drawing.Point(249, 350);
            this.btnVehCancel.Name = "btnVehCancel";
            this.btnVehCancel.Size = new System.Drawing.Size(75, 23);
            this.btnVehCancel.TabIndex = 16;
            this.btnVehCancel.Text = "Close";
            this.btnVehCancel.UseVisualStyleBackColor = true;
            this.btnVehCancel.Click += new System.EventHandler(this.btnVehCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = " Color";
            // 
            // txtVehicleColor
            // 
            this.txtVehicleColor.Location = new System.Drawing.Point(118, 242);
            this.txtVehicleColor.Name = "txtVehicleColor";
            this.txtVehicleColor.Size = new System.Drawing.Size(120, 20);
            this.txtVehicleColor.TabIndex = 21;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(118, 296);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(120, 20);
            this.txtPrice.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Price";
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
            this.cbMake.Location = new System.Drawing.Point(118, 132);
            this.cbMake.Name = "cbMake";
            this.cbMake.Size = new System.Drawing.Size(121, 21);
            this.cbMake.TabIndex = 25;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(118, 188);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(121, 20);
            this.txtModel.TabIndex = 26;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(118, 87);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(136, 20);
            this.txtYear.TabIndex = 27;
            // 
            // AddInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 407);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.cbMake);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtVehicleColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVehCancel);
            this.Controls.Add(this.btnVehAdd);
            this.Controls.Add(this.txtVehicleID);
            this.Controls.Add(this.label7);
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVehicleID;
        private System.Windows.Forms.Button btnVehAdd;
        private System.Windows.Forms.Button btnVehCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVehicleColor;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMake;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtYear;
    }
}