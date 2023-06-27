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
        Control panelContent;
        public edit(Control edit, int id)
        {
            InitializeComponent();
            this.panelContent = panelContent;
            edit.Controls.Add(this);
            this.BringToFront();
            partner_brandTableAdapter.Fill(this.category_dbDataSet.partner_brand);
            item_categoryTableAdapter.Fill(this.category_dbDataSet.item_category);
            item_categoryBindingSource.Filter = $"category_ID={id}";
        }
        private void kryptonButton10_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.item_categoryBindingSource.EndEdit();
            this.partner_brandBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.category_dbDataSet);

            MessageBox.Show("save success");
        }
    }
}
