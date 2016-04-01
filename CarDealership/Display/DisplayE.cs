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
    public partial class DisplayE : Form
    {
        public DisplayE()
        {
            InitializeComponent();
        }

        private void DisplayE_Load(object sender, EventArgs e)
        {
            String myConnString = "SERVER=localhost;Port=3306;Database=carDealership2;uid=root;Password=Raven47946$;";
            MySqlConnection conn = new MySqlConnection(myConnString);
            conn.Open();
            FindEmployee.FindEmployeeSQL = new MySqlCommand(FindEmployee.FindEmployeeSr, conn);
            FindEmployee.MyAdapter.SelectCommand = FindEmployee.FindEmployeeSQL;
            FindEmployee.MyAdapter.Fill(FindEmployee.dTable);
            dgDisplay.DataSource = FindEmployee.dTable;
            
        }

        private void dgDisplay_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Point pt = dgDisplay.PointToClient(MousePosition);
            DataGridView.HitTestInfo hti = dgDisplay.HitTest(pt.X, pt.Y);
            if (hti.Type == DataGridViewHitTestType.Cell)
            {
                dgDisplay.ClearSelection();
                dgDisplay.CurrentCell = dgDisplay.Rows[hti.RowIndex].Cells[hti.ColumnIndex];
                dgDisplay.Rows[hti.RowIndex].Selected = true;

                String ID = dgDisplay.Rows[hti.RowIndex].Cells[0].Value.ToString();
                MessageBox.Show(ID);
                String First = dgDisplay.Rows[hti.RowIndex].Cells[1].Value.ToString();
                String Last = dgDisplay.Rows[hti.RowIndex].Cells[2].Value.ToString();
                String HireDate = dgDisplay.Rows[hti.RowIndex].Cells[3].Value.ToString();
                String Salary = dgDisplay.Rows[hti.RowIndex].Cells[4].Value.ToString();
                String Position = dgDisplay.Rows[hti.RowIndex].Cells[5].Value.ToString();
                String Password = dgDisplay.Rows[hti.RowIndex].Cells[6].Value.ToString();
                EditEmployee ec = new EditEmployee(ID, First, Last, HireDate, Salary, Position);
                ec.Show();
                this.Close();
            }
        }

        private void dgDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
