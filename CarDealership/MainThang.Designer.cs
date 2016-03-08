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
            this.components = new System.ComponentModel.Container();
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
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.templatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabTables = new System.Windows.Forms.TabControl();
            this.tabCustomer = new System.Windows.Forms.TabPage();
            this.tabInventory = new System.Windows.Forms.TabPage();
            this.dgInventory = new System.Windows.Forms.DataGridView();
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.dgEmployee = new System.Windows.Forms.DataGridView();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPosition = new System.Windows.Forms.Label();
          //  this.customerTableAdapter1 = new CarDealership.cardealershipDataSetTestAgainTableAdapters.customerTableAdapter();
            this.CarMenuStrip.SuspendLayout();
            this.tabTables.SuspendLayout();
            this.tabInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInventory)).BeginInit();
            this.tabEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CarMenuStrip
            // 
            this.CarMenuStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CarMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuStrip,
            this.viewToolStripMenuItem,
            this.templatesToolStripMenuItem});
            this.CarMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.CarMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.CarMenuStrip.Name = "CarMenuStrip";
            this.CarMenuStrip.Size = new System.Drawing.Size(693, 29);
            this.CarMenuStrip.TabIndex = 0;
            this.CarMenuStrip.Text = "MainMenuBar";
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
            this.vehicleStrip.Size = new System.Drawing.Size(148, 26);
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
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.allToolStripMenuItem.Text = "All";
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
            // tabTables
            // 
            this.tabTables.Controls.Add(this.tabCustomer);
            this.tabTables.Controls.Add(this.tabInventory);
            this.tabTables.Controls.Add(this.tabEmployee);
            this.tabTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTables.Location = new System.Drawing.Point(12, 32);
            this.tabTables.Name = "tabTables";
            this.tabTables.SelectedIndex = 0;
            this.tabTables.Size = new System.Drawing.Size(655, 257);
            this.tabTables.TabIndex = 1;
            // 
            // tabCustomer
            // 
            this.tabCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabCustomer.Location = new System.Drawing.Point(4, 29);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomer.Size = new System.Drawing.Size(647, 224);
            this.tabCustomer.TabIndex = 0;
            this.tabCustomer.Text = "Customer";
            this.tabCustomer.UseVisualStyleBackColor = true;
            // 
            // tabInventory
            // 
            this.tabInventory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabInventory.Controls.Add(this.dgInventory);
            this.tabInventory.Location = new System.Drawing.Point(4, 29);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabInventory.Size = new System.Drawing.Size(647, 224);
            this.tabInventory.TabIndex = 1;
            this.tabInventory.Text = "Inventory";
            this.tabInventory.UseVisualStyleBackColor = true;
            // 
            // dgInventory
            // 
            this.dgInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInventory.Location = new System.Drawing.Point(-2, -2);
            this.dgInventory.Name = "dgInventory";
            this.dgInventory.Size = new System.Drawing.Size(647, 224);
            this.dgInventory.TabIndex = 0;
            // 
            // tabEmployee
            // 
            this.tabEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabEmployee.Controls.Add(this.dgEmployee);
            this.tabEmployee.Location = new System.Drawing.Point(4, 29);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Size = new System.Drawing.Size(647, 224);
            this.tabEmployee.TabIndex = 2;
            this.tabEmployee.Text = "Employee";
            this.tabEmployee.UseVisualStyleBackColor = true;
            // 
            // dgEmployee
            // 
            this.dgEmployee.AutoGenerateColumns = false;
            this.dgEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployee.DataSource = this.employeeBindingSource;
            this.dgEmployee.Location = new System.Drawing.Point(-2, -2);
            this.dgEmployee.Name = "dgEmployee";
            this.dgEmployee.Size = new System.Drawing.Size(639, 216);
            this.dgEmployee.TabIndex = 0;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(628, 296);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(0, 13);
            this.lblPosition.TabIndex = 2;
            // 
            // customerTableAdapter1
            // 
        //    this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // CarDealership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 318);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.tabTables);
            this.Controls.Add(this.CarMenuStrip);
            this.MainMenuStrip = this.CarMenuStrip;
            this.Name = "CarDealership";
            this.Text = "Car Dealership";
            this.Load += new System.EventHandler(this.CarDealership_Load);
            this.CarMenuStrip.ResumeLayout(false);
            this.CarMenuStrip.PerformLayout();
            this.tabTables.ResumeLayout(false);
            this.tabInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgInventory)).EndInit();
            this.tabEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip CarMenuStrip;
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
        private System.Windows.Forms.TabControl tabTables;
        private System.Windows.Forms.TabPage tabCustomer;
        private System.Windows.Forms.TabPage tabInventory;
        private System.Windows.Forms.TabPage tabEmployee;
        private System.Windows.Forms.DataGridView dgInventory;
        private System.Windows.Forms.DataGridView dgEmployee;
       // private cardealershipDataSetTestAgain cardealershipDataSetTestAgain;
        private System.Windows.Forms.BindingSource customerBindingSource;
       // private cardealershipDataSetTestAgainTableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
       // private cardealershipDataSetTestAgainTableAdapters.vehicleTableAdapter vehicleTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
      //  private cardealershipDataSetTestAgainTableAdapters.employeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeFNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeLNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeHireDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblPosition;
       // private cardealershipDataSetTestAgainTableAdapters.customerTableAdapter customerTableAdapter1;

    }
}

