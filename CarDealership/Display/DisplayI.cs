using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CarDealership
{
    public partial class DisplayI : Form
    {
        public DisplayI()
        {
            InitializeComponent();
        }

        private void dgDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Point pt = dgDisplay.PointToClient(MousePosition);
            DataGridView.HitTestInfo hti = dgDisplay.HitTest(pt.X, pt.Y);
            if (hti.Type == DataGridViewHitTestType.Cell)
            {
                dgDisplay.ClearSelection();
                dgDisplay.CurrentCell = dgDisplay.Rows[hti.RowIndex].Cells[hti.ColumnIndex];
                dgDisplay.Rows[hti.RowIndex].Selected = true;

                String VINnumber = dgDisplay.Rows[hti.RowIndex].Cells[0].Value.ToString();
                String Year = dgDisplay.Rows[hti.RowIndex].Cells[1].Value.ToString();
                String Make = dgDisplay.Rows[hti.RowIndex].Cells[2].Value.ToString();
                String Model = dgDisplay.Rows[hti.RowIndex].Cells[3].Value.ToString();
                String Quality = dgDisplay.Rows[hti.RowIndex].Cells[4].Value.ToString();
                String Color = dgDisplay.Rows[hti.RowIndex].Cells[5].Value.ToString();
                String CustomerID = dgDisplay.Rows[hti.RowIndex].Cells[6].Value.ToString();
                EditInventory ei = new EditInventory(VINnumber, Year, Make, Model, Quality, Color, CustomerID);
                ei.Show();
                this.Close();
            }
        }

        private void DisplayI_Load(object sender, EventArgs e)
        {
            String myConnString = "SERVER=localhost;Port=3306;Database=carDealership2;uid=root;Password=Raven47946$;";
            MySqlConnection conn = new MySqlConnection(myConnString);
            conn.Open();
            FindInventory.FindInventorySQL = new MySqlCommand(FindInventory.FindInventoryStatement, conn);
            FindInventory.MyAdapter.SelectCommand = FindInventory.FindInventorySQL;
            FindInventory.MyAdapter.Fill(FindInventory.dTable);
            dgDisplay.DataSource = FindInventory.dTable;
        }
    }
}
