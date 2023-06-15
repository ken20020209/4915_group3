using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.Purchase.PO.create.CPA
{
    public partial class create : UserControl
    {
        public Control panelContent;
        public create(Control panelContent)
        {
            InitializeComponent();
            this.panelContent = panelContent;

            panelContent.Controls.Add(this);
            this.BringToFront();

            buyer_IDNumericUpDown.Value = General.login.Login.user_ID;
            supplierTableAdapter.Fill(this.purchase_dbDataSet.supplier);
            itemTableAdapter.Fill(this.purchase_dbDataSet.item);
        }

        private void kryptonButtonSubmit_Click(object sender, EventArgs e)
        {
            cpaTableAdapter.Insert(create_dateDateTimePicker.Value, effective_dateDateTimePicker.Value,int.Parse( supplier_IDComboBox.SelectedValue.ToString()),int.Parse( buyer_IDNumericUpDown.Value.ToString()), termsTextBox.Text, conditionTextBox.Text,int.Parse(item_IDComboBox.SelectedValue.ToString()));
            MessageBox.Show("create success");
        }
    }
}
