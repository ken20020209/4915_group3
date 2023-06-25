using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.category.brand.search
{
    public partial class edit : UserControl
    {
        category_dbDataSet.partner_brandRow partner_brandRow;
        Control panelContent;
        public edit(Control edit, Control panelContent)
        {
            InitializeComponent();
            this.panelContent = panelContent;
            edit.Controls.Clear();
            edit.Controls.Add(this);

        }

        private void kryptonButton10_Click(object sender, EventArgs e)
        {
            this.Validate();
            partner_brandRow.name = kryptonTextBox1.Text;
            partner_brandRow.partner_brand_ID = int.Parse(kryptonTextBox2.Text);
            partner_brandRow.remarks = kryptonRichTextBox1.Text;
            this.partner_brandTableAdapter.UpdateQuery(partner_brandRow.name, partner_brandRow.partner_brand_ID, partner_brandRow.remarks);
            MessageBox.Show("save success");
        }
    }
}
