using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.Restaurant.request_order.create
{
    public partial class check_order : UserControl
    {
        Control panelContent;
        requestOrder newOrder;
        public check_order(Control panel,requestOrder newOrder)
        {
            InitializeComponent();
            panelContent = panel;
            panelContent.Controls.Add(this);
            this.BringToFront();

            this.newOrder = newOrder;
        }

        private void kryptonButtonConfirm_Click(object sender, EventArgs e)
        {
            new create_success().ShowDialog();
        }

        private void kryptonLabelback_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Remove(this);
        }
    }
}
