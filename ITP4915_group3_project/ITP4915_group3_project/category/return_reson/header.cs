using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.category.return_reson
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
            kryptonButtonReview_Click(null, null);
        }
        private void kryptonButtonCreate_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            new create.create(panelContent);

        }

        private void kryptonButtonReview_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            new return_reson.select.check(panelContent);

        }


    }
}