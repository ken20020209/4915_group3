using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.Restaurant
{
    public partial class choose : Form
    {
        public choose()
        {
            InitializeComponent();
        }



        private void choose_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurant_dbDataSet.restaurant' table. You can move, or remove it, as needed.
            this.restaurantTableAdapter.Fill(this.restaurant_dbDataSet.restaurant);

        }

        private void restaurantKryptonDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex==-1||e.ColumnIndex!=0)
            {
                return;
            }
            restaurant.restaurant_Name = restaurantKryptonDataGridView.Rows[e.RowIndex].Cells["name"].Value.ToString();
            restaurant.restaurant_ID=(int)restaurantKryptonDataGridView.Rows[e.RowIndex].Cells["restaurant_ID"].Value;
            restaurant.address_ID=(int)restaurantKryptonDataGridView.Rows[e.RowIndex].Cells["address_ID"].Value;

            this.Close();
        }
    }
}
