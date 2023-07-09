using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.warehouse
{
    public partial class choose : Form
    {
        public choose()
        {
            InitializeComponent();
        }



        private void choose_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'warehouse_dbDataSet.warehouse' table. You can move, or remove it, as needed.
            this.warehouseTableAdapter.Fill(this.warehouse_dbDataSet.warehouse);


        }

        private void restaurantKryptonDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex==-1||e.ColumnIndex!=0)
            {
                return;
            }
            warehouse.warehouse_ID = (int)restaurantKryptonDataGridView.Rows[e.RowIndex].Cells[1].Value;
            warehouse.warehouse_address_ID=(int)restaurantKryptonDataGridView.Rows[e.RowIndex].Cells[3].Value;
            warehouse.address_ID=(int)restaurantKryptonDataGridView.Rows[e.RowIndex].Cells[3].Value;

            this.Close();
        }
    }
}
