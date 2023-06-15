using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.Purchase.PO.create.BPA
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

            this.supplierTableAdapter.Fill(this.purchase_dbDataSet.supplier);

            //set buyer id
            buyer_IDTextBox.Text = General.login.Login.user_ID.ToString();
        }


        private void supplierComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
/*            Console.WriteLine(supplierComboBox.SelectedValue.ToString());*/
            this.itemTableAdapter.FillBy_supplierID(this.purchase_dbDataSet.item, int.Parse(supplierComboBox.SelectedValue.ToString()));
            supplier_IDTextBox.Text = int.Parse(supplierComboBox.SelectedValue.ToString()).ToString();
        }

        private void itemKryptonDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Console.WriteLine(itemKryptonDataGridView.Rows[e.RowIndex].Cells[0]);
            dataGridViewSelected.Rows.Insert(0,"" ,itemKryptonDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
            dataGridViewSelected.Rows[0].Cells[1].Tag = itemKryptonDataGridView.Rows[e.RowIndex].Cells[1].Value;

        }

        private void dataGridViewSelected_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewSelected.Rows.RemoveAt(e.RowIndex);
        }

        private void kryptonButtonSubmit_Click(object sender, EventArgs e)
        {
            bpa_headerTableAdapter.Insert(purchase_order_revisionComboBox.Text == "true"?(byte)1:(byte)0, create_dateDateTimePicker.Value, effective_datesDateTimePicker.Value, int.Parse(supplier_IDTextBox.Text), int.Parse(buyer_IDTextBox.Text), int.Parse(agreed_amountTextBox.Text), int.Parse(currencyTextBox.Text), termsTextBox.Text, conditionTextBox.Text);

            // get key of header
            int key = bpa_headerTableAdapter.GetData().Last().header_ID;


            foreach (DataGridViewRow row in dataGridViewSelected.Rows)
            {
                int header_ID = key;
                int item_ID = int.Parse(row.Cells["item_name"].Tag.ToString());
                int promised_qty = int.Parse(row.Cells["promised_qty"].Value.ToString());
                string UOM = row.Cells["UOM"].Value.ToString();
                int MoQ = int.Parse(row.Cells["MoQ"].Value.ToString());
                decimal price = decimal.Parse(row.Cells["price"].Value.ToString());
                int amount = int.Parse(row.Cells["amount"].Value.ToString());
                // bug : if reference is empty
                string reference = row.Cells["reference"].Value.ToString();

                bpa_linesTableAdapter.Insert(header_ID, item_ID, promised_qty, UOM, MoQ, price, amount, reference);
            }

            MessageBox.Show("create success");
        }
    }
}
