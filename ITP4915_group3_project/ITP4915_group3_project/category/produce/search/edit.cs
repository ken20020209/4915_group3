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
        category_dbDataSet.itemRow itemRow;
        category_dbDataSet.supplierRow supplierRow;
        Control panelContent;
        int id;
        public edit(Control edit,int id)
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
            itemRow.item_ID = int.Parse(kryptonTextBox3.Text);
            itemRow.item_name = kryptonTextBox1.Text;
            supplierRow.remarks = kryptonRichTextBox1.Text;
            supplierRow.supplier_ID = int.Parse(kryptonTextBox4.Text);
            supplierRow.name = kryptonTextBox2.Text;
            this.itemTableAdapter.UpdateQuery(itemRow.item_ID, itemRow.item_name);
            this.supplierTableAdapter.UpdateQuery(supplierRow.remarks, supplierRow.supplier_ID, supplierRow.name); 
            MessageBox.Show("save success");
        }
    }
}
