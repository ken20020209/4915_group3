using System;
using System.Windows.Forms;

namespace ITP4915_group3_project.Purchase.PO.create.SPO
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

            //laod data
            this.supplierTableAdapter.Fill(this.purchase_dbDataSet.supplier);
            this.cpa_itemTableAdapter.Fill(this.purchase_dbDataSet.cpa_item);

            kryptonTextBoxBuyer.Text = General.login.Login.user_ID.ToString();
        }

        private void kryptonDataGridViewCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0 || e.RowIndex == -1)
            {
                return;
            }
            else
            {
                kryptonDataGridViewCart.Rows.RemoveAt(e.RowIndex);
            }

        }

        private void cpa_itemKryptonDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex != 0 || e.RowIndex == -1)
            {
                return;
            }
            else
            {
                // add item id and name to tag and value
                kryptonDataGridViewCart.Rows.Insert(0, "", cpa_itemKryptonDataGridView.Rows[e.RowIndex].Cells[1].Value, cpa_itemKryptonDataGridView.Rows[e.RowIndex].Cells[9].Value,0,"",0,0,"");
                kryptonDataGridViewCart.Rows[0].Cells[2].Tag = cpa_itemKryptonDataGridView.Rows[e.RowIndex].Cells[8].Value;
            }
        }

        private void kryptonButtonSubmit_Click(object sender, EventArgs e)
        {
            //insert header 
            int buyerID = int.Parse(kryptonTextBoxBuyer.Text);
            int supplierID = int.Parse(nameKryptonComboBox.SelectedValue.ToString());

            spo_headerTableAdapter.Insert(create_dateKryptonDateTimePicker.Value,
                effective_dateKryptonDateTimePicker.Value,
                supplierID,
                buyerID,
                expected_delivery_dateKryptonDateTimePicker.Value,
                termsKryptonTextBox.Text,
                conditionKryptonTextBox.Text
                );

            int spo_header_id = Convert.ToInt32(spo_headerTableAdapter.GetData().Compute("MAX(header_ID)", ""));


            foreach (DataGridViewRow row in kryptonDataGridViewCart.Rows)
            {
                int header_ID = spo_header_id;
                int item_ID = int.Parse(row.Cells[2].Tag.ToString());
                int qty = int.Parse(row.Cells[3].Value.ToString());
                decimal price = decimal.Parse(row.Cells[5].Value.ToString());
                string UOM = row.Cells[4].Value.ToString();

                int amount = int.Parse(row.Cells[6].Value.ToString());
                int cpa_ID = int.Parse(row.Cells[1].Value.ToString());
/*                string reference = row.Cells[7].Value.ToString();*/

                spo_linesTableAdapter.Insert(header_ID, item_ID, qty, price, UOM, amount, cpa_ID, 0);

            }

            MessageBox.Show("create success");
        }
    }
}