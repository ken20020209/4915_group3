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
    public partial class detail : UserControl
    {
        private Control check;
        private int v;

        public detail(check check, int v)
        {
            this.check = check;
            this.v = v;
            InitializeComponent();
            check.Controls.Add(this);
            this.BringToFront();
            this.itemTableAdapter.Fill(this.category_dbDataSet.item);
            this.item_categoryTableAdapter.Fill(this.category_dbDataSet.item_category);
            this.partner_brandTableAdapter.Fill(this.category_dbDataSet.partner_brand);

            itemBindingSource.Filter = $"item_id={v}";
        }
        private void kryptonLabel12_Click(object sender, EventArgs e)
        {
            check.Controls.Remove(this);
        }
        private void kryptonLabel11_Click(object sender, EventArgs e)
        {
            itemBindingSource.RemoveCurrent();
            this.tableAdapterManager.UpdateAll(this.category_dbDataSet);
            MessageBox.Show("delete success");
            new delete_sucess().ShowDialog();
        }
        private void kryptonLabel10_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.category_dbDataSet);

            MessageBox.Show("save success");
        }

        private void kryptonComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            kryptonTextBox4.Text = kryptonComboBox2.SelectedValue.ToString();
        }

        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            kryptonTextBox2.Text = kryptonComboBox1.SelectedValue.ToString();
        }
    }
}
