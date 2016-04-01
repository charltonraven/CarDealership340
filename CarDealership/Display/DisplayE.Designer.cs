namespace CarDealership
{
    partial class DisplayE
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
            this.dgDisplay = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDisplay
            // 
            this.dgDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDisplay.Location = new System.Drawing.Point(7, 5);
            this.dgDisplay.Name = "dgDisplay";
            this.dgDisplay.Size = new System.Drawing.Size(829, 169);
            this.dgDisplay.TabIndex = 0;
            this.dgDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDisplay_CellContentClick);
            this.dgDisplay.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDisplay_CellDoubleClick);
            // 
            // DisplayE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 179);
            this.Controls.Add(this.dgDisplay);
            this.Name = "DisplayE";
            this.Text = "DisplayE";
            this.Load += new System.EventHandler(this.DisplayE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDisplay;
    }
}