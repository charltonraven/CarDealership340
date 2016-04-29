namespace CarDealership
{
    partial class Main_Page
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
            this.stripAddCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.editStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.printStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabTables = new System.Windows.Forms.TabControl();
            this.tabCustomer = new System.Windows.Forms.TabPage();
            this.dgCustomer = new System.Windows.Forms.DataGridView();
            this.tabInventory = new System.Windows.Forms.TabPage();
            this.dgInventory = new System.Windows.Forms.DataGridView();
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.dgEmp = new System.Windows.Forms.DataGridView();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPosition = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.CarMenuStrip.SuspendLayout();
            this.tabTables.SuspendLayout();
            this.tabCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomer)).BeginInit();
            this.tabInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInventory)).BeginInit();
            this.tabEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CarMenuStrip
            // 
            this.CarMenuStrip.BackColor = System.Drawing.SystemColors.Window;
            this.CarMenuStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CarMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuStrip,
            this.viewToolStripMenuItem});
            this.CarMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.CarMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.CarMenuStrip.Name = "CarMenuStrip";
            this.CarMenuStrip.Size = new System.Drawing.Size(829, 29);
            this.CarMenuStrip.TabIndex = 0;
            this.CarMenuStrip.Text = "MainMenuBar";
            this.CarMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.CarMenuStrip_ItemClicked);
            // 
            // fileMenuStrip
            // 
            this.fileMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripAddCustomer,
            this.editStrip,
            this.printStrip,
            this.refreshStrip,
            this.changePasswordToolStripMenuItem});
            this.fileMenuStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileMenuStrip.Name = "fileMenuStrip";
            this.fileMenuStrip.Size = new System.Drawing.Size(46, 25);
            this.fileMenuStrip.Text = "File";
            this.fileMenuStrip.Click += new System.EventHandler(this.fileMenuStrip_Click);
            // 
            // stripAddCustomer
            // 
            this.stripAddCustomer.Name = "stripAddCustomer";
            this.stripAddCustomer.Size = new System.Drawing.Size(203, 26);
            this.stripAddCustomer.Text = "Add";
            this.stripAddCustomer.Click += new System.EventHandler(this.stripAddCustomer_Click);
            // 
            // editStrip
            // 
            this.editStrip.Name = "editStrip";
            this.editStrip.Size = new System.Drawing.Size(203, 26);
            this.editStrip.Text = "Find/Edit";
            this.editStrip.Click += new System.EventHandler(this.editStrip_Click);
            // 
            // printStrip
            // 
            this.printStrip.Name = "printStrip";
            this.printStrip.Size = new System.Drawing.Size(203, 26);
            this.printStrip.Text = "Print";
            // 
            // refreshStrip
            // 
            this.refreshStrip.Name = "refreshStrip";
            this.refreshStrip.Size = new System.Drawing.Size(203, 26);
            this.refreshStrip.Text = "Refresh List";
            this.refreshStrip.Click += new System.EventHandler(this.refreshStrip_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(127, 25);
            this.viewToolStripMenuItem.Text = "Make Purchase";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
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
            this.tabTables.Size = new System.Drawing.Size(772, 295);
            this.tabTables.TabIndex = 1;
            // 
            // tabCustomer
            // 
            this.tabCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabCustomer.Controls.Add(this.dgCustomer);
            this.tabCustomer.Location = new System.Drawing.Point(4, 29);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomer.Size = new System.Drawing.Size(764, 262);
            this.tabCustomer.TabIndex = 0;
            this.tabCustomer.Text = "Customer";
            this.tabCustomer.UseVisualStyleBackColor = true;
            this.tabCustomer.BindingContextChanged += new System.EventHandler(this.tabCustomer_BindingContextChanged);
            this.tabCustomer.Click += new System.EventHandler(this.tabCustomer_Click);
            this.tabCustomer.DragOver += new System.Windows.Forms.DragEventHandler(this.tabCustomer_DragOver);
            // 
            // dgCustomer
            // 
            this.dgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomer.Location = new System.Drawing.Point(-18, 1);
            this.dgCustomer.Name = "dgCustomer";
            this.dgCustomer.Size = new System.Drawing.Size(784, 259);
            this.dgCustomer.TabIndex = 0;
            this.dgCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCustomer_CellClick);
            this.dgCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dgCustomer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCustomer_CellDoubleClick);
            // 
            // tabInventory
            // 
            this.tabInventory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabInventory.Controls.Add(this.dgInventory);
            this.tabInventory.Location = new System.Drawing.Point(4, 29);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabInventory.Size = new System.Drawing.Size(764, 262);
            this.tabInventory.TabIndex = 1;
            this.tabInventory.Text = "Inventory";
            this.tabInventory.UseVisualStyleBackColor = true;
            // 
            // dgInventory
            // 
            this.dgInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInventory.Location = new System.Drawing.Point(-2, -2);
            this.dgInventory.Name = "dgInventory";
            this.dgInventory.Size = new System.Drawing.Size(764, 259);
            this.dgInventory.TabIndex = 0;
            this.dgInventory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgInventory_CellDoubleClick);
            // 
            // tabEmployee
            // 
            this.tabEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabEmployee.Controls.Add(this.dgEmp);
            this.tabEmployee.Location = new System.Drawing.Point(4, 29);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Size = new System.Drawing.Size(764, 262);
            this.tabEmployee.TabIndex = 2;
            this.tabEmployee.Text = "Employee";
            this.tabEmployee.UseVisualStyleBackColor = true;
            // 
            // dgEmp
            // 
            this.dgEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmp.Location = new System.Drawing.Point(3, -2);
            this.dgEmp.Name = "dgEmp";
            this.dgEmp.Size = new System.Drawing.Size(754, 251);
            this.dgEmp.TabIndex = 0;
            this.dgEmp.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmp_CellDoubleClick);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(760, 330);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(44, 13);
            this.lblPosition.TabIndex = 2;
            this.lblPosition.Text = "Position";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 329);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.SystemColors.Window;
            this.lblUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUsername.Location = new System.Drawing.Point(654, 11);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(60, 13);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "User Name";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(754, 1);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Main_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 356);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.tabTables);
            this.Controls.Add(this.CarMenuStrip);
            this.MainMenuStrip = this.CarMenuStrip;
            this.Name = "Main_Page";
            this.Text = "Car Dealership";
            this.Load += new System.EventHandler(this.CarDealership_Load);
            this.CarMenuStrip.ResumeLayout(false);
            this.CarMenuStrip.PerformLayout();
            this.tabTables.ResumeLayout(false);
            this.tabCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomer)).EndInit();
            this.tabInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgInventory)).EndInit();
            this.tabEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmp)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem printStrip;
        private System.Windows.Forms.ToolStripMenuItem refreshStrip;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.TabControl tabTables;
        private System.Windows.Forms.TabPage tabCustomer;
        private System.Windows.Forms.TabPage tabInventory;
        private System.Windows.Forms.TabPage tabEmployee;
        private System.Windows.Forms.DataGridView dgInventory;
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
       // private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
      //  private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
       // private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.DataGridView dgCustomer;
        private System.Windows.Forms.DataGridView dgEmp;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ToolStripMenuItem stripAddCustomer;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
       // private cardealershipDataSetTestAgainTableAdapters.customerTableAdapter customerTableAdapter1;

    }
}

