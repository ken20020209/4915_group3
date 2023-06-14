using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.Purchase.PO
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
            new create.select(panelContent);
        }

        private void kryptonButtonReview_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            new search.check(panelContent);
        }
    }
}
