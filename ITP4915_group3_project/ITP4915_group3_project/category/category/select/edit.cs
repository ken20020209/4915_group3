using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.category.category.select
{
    public partial class edit : UserControl
    {
        category_dbDataSet.item_categoryRow item_categoryRow;
        category_dbDataSet.partner_brandRow partner_brandRow;
        int id;
        Control panelContent;
        public edit(Control edit, int id)
        {
            InitializeComponent();
            this.panelContent = panelContent;
            this.id = id;
            edit.Controls.Clear();
            edit.Controls.Add(this);
        }
        private void kryptonButton10_Click(object sender, EventArgs e)
        {
            this.Validate();
            item_categoryRow.category_name = kryptonTextBox2.Text;
            //item_categoryRow.category_ID = int.Parse(kryptonTextBox1.Text);
            partner_brandRow.remarks = kryptonRichTextBox2.Text;
            item_categoryRow.description = kryptonRichTextBox1.Text;
            this.item_categoryTableAdapter.UpdateQuery(item_categoryRow.category_name,id, partner_brandRow.remarks,item_categoryRow.description);
            MessageBox.Show("save success");
        }
    }
}
