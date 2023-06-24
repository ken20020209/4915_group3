using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.warehouse.delivery_note
{
    public partial class sign_confirm : Form
    {
        int deliveryID;
        public sign_confirm(int deliveryID)
        {
            InitializeComponent();
            this.deliveryID = deliveryID;
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            delivery_dbDataSet.delivery_requestRow dataRow = delivery_requestTableAdapter.GetData().FindBydelivery_request_ID(deliveryID);
            dataRow.status_ID = 3100;
            delivery_requestTableAdapter.Update(dataRow);
        }



    }
}
