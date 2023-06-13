using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.Restaurant.request_order.search
{

    
    public partial class detail : UserControl
    {
        Control checkUserControl;
        public detail(Control panel, int requestOrder_ID)
        {
            InitializeComponent();
            panel.Controls.Add(this);
            checkUserControl = panel;
            this.BringToFront();
            this.requestDetail_purhcases_requestTableAdapter.FillBy_RestID_RequestID(this._4523_g1_project_dbDataSet.requestDetail_purhcases_request, restaurant.restaurant_ID, requestOrder_ID);
        }

        private void kryptonLabelBack_Click(object sender, EventArgs e)
        {
            checkUserControl.Controls.Remove(this);
        }


    }
        
}
