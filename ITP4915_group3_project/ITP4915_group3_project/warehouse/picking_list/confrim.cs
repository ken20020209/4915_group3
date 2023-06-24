using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.warehouse.picking_list
{
    public partial class confrim : Form
    {
        int listID;
        public confrim(int listID)
        {
            InitializeComponent();
            this.listID = listID;
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            warehouse_dbDataSet.delivery_requestRow dataRow = delivery_requestTableAdapter.GetData().FindBydelivery_request_ID(listID);
            dataRow.status_ID = 3200;
            delivery_requestTableAdapter.Update(dataRow);
        }
    }
}
