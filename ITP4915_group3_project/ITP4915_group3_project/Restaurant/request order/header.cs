using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.Restaurant.request_order
{
    public partial class header : UserControl
    {
        Control panelContent;
        public header(Control panel)
        {
            InitializeComponent();
            this.panelContent = panel;
        }

        private void kryptonButtonCreate_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            Control select_item = new request_order.create.select_item();
            panelContent.Controls.Add(select_item);
            select_item.BringToFront();
        }

        private void kryptonButtonReview_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            panelContent.Controls.Add(new request_order.search.check());
        }
    }
}
