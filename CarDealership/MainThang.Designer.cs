namespace CarDealership
{
    partial class CarDealership
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
            this.CarMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.editStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.findStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.printStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onLotToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.offLotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchasedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.templatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CarMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CarMenuStrip
            // 
            this.CarMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuStrip,
            this.viewToolStripMenuItem,
            this.templatesToolStripMenuItem});
            this.CarMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.CarMenuStrip.Name = "CarMenuStrip";
            this.CarMenuStrip.Size = new System.Drawing.Size(693, 29);
            this.CarMenuStrip.TabIndex = 0;
            this.CarMenuStrip.Text = "menuStrip1";
            // 
            // fileMenuStrip
            // 
            this.fileMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editStrip,
            this.findStrip,
            this.printStrip,
            this.deleteStrip,
            this.refreshStrip});
            this.fileMenuStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileMenuStrip.Name = "fileMenuStrip";
            this.fileMenuStrip.Size = new System.Drawing.Size(46, 25);
            this.fileMenuStrip.Text = "File";
            // 
            // editStrip
            // 
            this.editStrip.Name = "editStrip";
            this.editStrip.Size = new System.Drawing.Size(161, 26);
            this.editStrip.Text = "Edit";
            this.editStrip.Click += new System.EventHandler(this.editStrip_Click);
            // 
            // findStrip
            // 
            this.findStrip.Name = "findStrip";
            this.findStrip.Size = new System.Drawing.Size(161, 26);
            this.findStrip.Text = "Find";
            this.findStrip.Click += new System.EventHandler(this.findToolStripMenuItem2_Click);
            // 
            // printStrip
            // 
            this.printStrip.Name = "printStrip";
            this.printStrip.Size = new System.Drawing.Size(161, 26);
            this.printStrip.Text = "Print";
            // 
            // deleteStrip
            // 
            this.deleteStrip.Name = "deleteStrip";
            this.deleteStrip.Size = new System.Drawing.Size(161, 26);
            this.deleteStrip.Text = "Delete";
            // 
            // refreshStrip
            // 
            this.refreshStrip.Name = "refreshStrip";
            this.refreshStrip.Size = new System.Drawing.Size(161, 26);
            this.refreshStrip.Text = "Refresh List";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerStrip,
            this.employeeStrip,
            this.vehicleStrip});
            this.viewToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.viewToolStripMenuItem.Text = "Database";
            // 
            // customerStrip
            // 
            this.customerStrip.Name = "customerStrip";
            this.customerStrip.Size = new System.Drawing.Size(148, 26);
            this.customerStrip.Text = "Customer";
            // 
            // employeeStrip
            // 
            this.employeeStrip.Name = "employeeStrip";
            this.employeeStrip.Size = new System.Drawing.Size(148, 26);
            this.employeeStrip.Text = "Employee";
            // 
            // vehicleStrip
            // 
            this.vehicleStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseVehicleToolStripMenuItem,
            this.displayToolStripMenuItem1});
            this.vehicleStrip.Name = "vehicleStrip";
            this.vehicleStrip.Size = new System.Drawing.Size(152, 26);
            this.vehicleStrip.Text = "Vehicle";
            // 
            // purchaseVehicleToolStripMenuItem
            // 
            this.purchaseVehicleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onLotToolStripMenuItem1,
            this.offLotToolStripMenuItem,
            this.purchasedToolStripMenuItem,
            this.allToolStripMenuItem});
            this.purchaseVehicleToolStripMenuItem.Name = "purchaseVehicleToolStripMenuItem";
            this.purchaseVehicleToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.purchaseVehicleToolStripMenuItem.Text = "Display";
            // 
            // onLotToolStripMenuItem1
            // 
            this.onLotToolStripMenuItem1.Name = "onLotToolStripMenuItem1";
            this.onLotToolStripMenuItem1.Size = new System.Drawing.Size(152, 26);
            this.onLotToolStripMenuItem1.Text = "On lot";
            // 
            // offLotToolStripMenuItem
            // 
            this.offLotToolStripMenuItem.Name = "offLotToolStripMenuItem";
            this.offLotToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.offLotToolStripMenuItem.Text = "Off Lot";
            // 
            // purchasedToolStripMenuItem
            // 
            this.purchasedToolStripMenuItem.Name = "purchasedToolStripMenuItem";
            this.purchasedToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.purchasedToolStripMenuItem.Text = "Purchased";
            // 
            // displayToolStripMenuItem1
            // 
            this.displayToolStripMenuItem1.Name = "displayToolStripMenuItem1";
            this.displayToolStripMenuItem1.Size = new System.Drawing.Size(212, 26);
            this.displayToolStripMenuItem1.Text = "Purchased Vehicles";
            // 
            // templatesToolStripMenuItem
            // 
            this.templatesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findCustomerToolStripMenuItem,
            this.findEmployeeToolStripMenuItem,
            this.findInventoryToolStripMenuItem});
            this.templatesToolStripMenuItem.Name = "templatesToolStripMenuItem";
            this.templatesToolStripMenuItem.Size = new System.Drawing.Size(73, 25);
            this.templatesToolStripMenuItem.Text = "Templates";
            // 
            // findCustomerToolStripMenuItem
            // 
            this.findCustomerToolStripMenuItem.Name = "findCustomerToolStripMenuItem";
            this.findCustomerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.findCustomerToolStripMenuItem.Text = "Find Customer";
            this.findCustomerToolStripMenuItem.Click += new System.EventHandler(this.findCustomerToolStripMenuItem_Click);
            // 
            // findEmployeeToolStripMenuItem
            // 
            this.findEmployeeToolStripMenuItem.Name = "findEmployeeToolStripMenuItem";
            this.findEmployeeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.findEmployeeToolStripMenuItem.Text = "Find Employee";
            this.findEmployeeToolStripMenuItem.Click += new System.EventHandler(this.findEmployeeToolStripMenuItem_Click);
            // 
            // findInventoryToolStripMenuItem
            // 
            this.findInventoryToolStripMenuItem.Name = "findInventoryToolStripMenuItem";
            this.findInventoryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.findInventoryToolStripMenuItem.Text = "Find Inventory";
            this.findInventoryToolStripMenuItem.Click += new System.EventHandler(this.findInventoryToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(651, 264);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.allToolStripMenuItem.Text = "All";
            // 
            // CarDealership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 318);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CarMenuStrip);
            this.MainMenuStrip = this.CarMenuStrip;
            this.Name = "CarDealership";
            this.Text = "Car Dealership";
            this.Load += new System.EventHandler(this.CarDealership_Load);
            this.CarMenuStrip.ResumeLayout(false);
            this.CarMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip CarMenuStrip;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem fileMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editStrip;
        private System.Windows.Forms.ToolStripMenuItem findStrip;
        private System.Windows.Forms.ToolStripMenuItem printStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteStrip;
        private System.Windows.Forms.ToolStripMenuItem refreshStrip;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerStrip;
        private System.Windows.Forms.ToolStripMenuItem employeeStrip;
        private System.Windows.Forms.ToolStripMenuItem vehicleStrip;
        private System.Windows.Forms.ToolStripMenuItem purchaseVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onLotToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem offLotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchasedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem templatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;

    }
}

