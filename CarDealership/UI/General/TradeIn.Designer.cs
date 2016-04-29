namespace CarDealership
{
    partial class TradeIn
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
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ddMake = new System.Windows.Forms.ComboBox();
            this.cbDamaged = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "VIN Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Make";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Model";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Year";
            // 
            // txtVehicleID
            // 
            this.txtVehicleID.Location = new System.Drawing.Point(109, 46);
            this.txtVehicleID.Name = "txtVehicleID";
            this.txtVehicleID.Size = new System.Drawing.Size(137, 20);
            this.txtVehicleID.TabIndex = 7;
            // 
            // btnVehAdd
            // 
            this.btnVehAdd.Location = new System.Drawing.Point(18, 342);
            this.btnVehAdd.Name = "btnVehAdd";
            this.btnVehAdd.Size = new System.Drawing.Size(75, 23);
            this.btnVehAdd.TabIndex = 15;
            this.btnVehAdd.Text = "Add";
            this.btnVehAdd.UseVisualStyleBackColor = true;
            this.btnVehAdd.Click += new System.EventHandler(this.btnVehAdd_Click);
            // 
            // btnVehCancel
            // 
            this.btnVehCancel.Location = new System.Drawing.Point(195, 342);
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
            this.label3.Location = new System.Drawing.Point(54, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = " Color";
            // 
            // txtVehicleColor
            // 
            this.txtVehicleColor.Location = new System.Drawing.Point(109, 267);
            this.txtVehicleColor.Name = "txtVehicleColor";
            this.txtVehicleColor.Size = new System.Drawing.Size(120, 20);
            this.txtVehicleColor.TabIndex = 21;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(109, 94);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 32;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(109, 183);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Damaged Scale";
            // 
            // ddMake
            // 
            this.ddMake.FormattingEnabled = true;
            this.ddMake.Items.AddRange(new object[] {
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
            this.ddMake.Location = new System.Drawing.Point(109, 138);
            this.ddMake.Name = "ddMake";
            this.ddMake.Size = new System.Drawing.Size(121, 21);
            this.ddMake.TabIndex = 39;
            // 
            // cbDamaged
            // 
            this.cbDamaged.FormattingEnabled = true;
            this.cbDamaged.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbDamaged.Location = new System.Drawing.Point(109, 227);
            this.cbDamaged.Name = "cbDamaged";
            this.cbDamaged.Size = new System.Drawing.Size(31, 21);
            this.cbDamaged.TabIndex = 40;
            // 
            // TradeIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 460);
            this.Controls.Add(this.cbDamaged);
            this.Controls.Add(this.ddMake);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtVehicleColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVehCancel);
            this.Controls.Add(this.btnVehAdd);
            this.Controls.Add(this.txtVehicleID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TradeIn";
            this.Text = "Trade-In";
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
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ddMake;
        private System.Windows.Forms.ComboBox cbDamaged;
    }
}