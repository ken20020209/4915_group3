using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.Purchase.request_order.process
{
    public partial class select_treatment : UserControl
    {
        public int requestID;
        public select_treatment(Control panelContent,int requestID)
        {
            InitializeComponent();
            panelContent.Controls.Add(this);
            this.BringToFront();

            this.requestID = requestID;
        }

        private void match_ppo(object sender, EventArgs e)
        {

        }
        private void match_spo(object sender, EventArgs e)
        {

        }
        private void match_bpa(object sender, EventArgs e)
        {

        }
        private void match_warehouse(object sender, EventArgs e)
        {
            new warehouse_list_match(this, requestID);
            
        }

        private void kryptonLabelBack_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }
    }
}
