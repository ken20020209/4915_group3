using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.category.produce.create
{
    public partial class create : UserControl
    {
        private Control panelContent;
        public create(Control panelContent)
        {
            InitializeComponent();
            this.panelContent = panelContent;

            panelContent.Controls.Add(this);
            this.BringToFront();


            this.itemTableAdapter.Fill(this.category_dbDataSet.item);
            this.item_categoryTableAdapter.Fill(this.category_dbDataSet.item_category);
            this.partner_brandTableAdapter.Fill(this.category_dbDataSet.partner_brand);
            


            itemBindingSource.AddNew();
            itemBindingSource.MoveLast();

            priceKryptonNumericUpDown.Value = 1;
        }
        private void kryptonButtonConfirm_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemBindingSource.EndEdit();
            try
            {
                this.tableAdapterManager.UpdateAll(this.category_dbDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("create success");
            itemBindingSource.AddNew();
            itemBindingSource.MoveLast();

        }



        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            kryptonTextBox2.Text = kryptonComboBox1.SelectedValue.ToString();
        }

        private void kryptonComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            kryptonTextBox4.Text = kryptonComboBox2.SelectedValue.ToString();
        }
    }
}
