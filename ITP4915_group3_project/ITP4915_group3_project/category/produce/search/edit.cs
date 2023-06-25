using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.category.produce.search
{
    public partial class edit : UserControl
    {
        public edit()
        {
            InitializeComponent();
        }
        private void kryptonButton10_Click(object sender, EventArgs e)
        {
            this.Validate();
            item_categoryRow.category_name = kryptonTextBox2.Text;
            item_categoryRow.category_ID = int.Parse(kryptonTextBox1.Text);
            partner_brandRow.remarks = kryptonRichTextBox2.Text;
            item_categoryRow.description = kryptonRichTextBox1.Text;
            this.item_categoryTableAdapter.UpdateQuery(item_categoryRow.category_ID, item_categoryRow.category_ID, partner_brandRow.remarks, item_categoryRow.description);
            MessageBox.Show("save success");
        }
    }
}
