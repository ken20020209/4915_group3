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
    public partial class complete_detail : UserControl
    {
        Control panelContent;
        public complete_detail(Control panel)
        {
            InitializeComponent();
            this.panelContent = panel;
            panel.Controls.Add(this);
        }

        private void kryptonButtonCountinue_Click(object sender, EventArgs e)
        {
            new check_order(this);
        }

        private void kryptonLabelback_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Remove(this);
        }
    }
}
