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
    public partial class header : UserControl
    {
        Control panelContent;
        public header(Control header, Control panelContent)
        {
            InitializeComponent();
            this.panelContent = panelContent;
            header.Controls.Clear();
            header.Controls.Add(this);
            kryptonBtnReview_Click(null, null);
        }

        private void kryptonBtnReview_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            new picking_list.check(panelContent);
        }

        private void kryptonPanelHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
