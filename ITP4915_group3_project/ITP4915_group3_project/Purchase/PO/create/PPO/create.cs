using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.Purchase.PO.create.PPO
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

            // load data
            this.supplierTableAdapter.Fill(this.purchase_dbDataSet.supplier);
            this.itemTableAdapter.Fill(this.purchase_dbDataSet.item);
            kryptonTextBoxBuyerID.Text = General.login.Login.user_ID.ToString();
        }


        private void kryptonDataGridViewChoose_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0 || e.RowIndex==-1)
            {
                return;
            }
            else
            {
                // add item id and name to tag and value
                kryptonDataGridViewCart.Rows.Insert(0,"", kryptonDataGridViewChoose.Rows[e.RowIndex].Cells[3].Value,0,"",0,0,"");
                kryptonDataGridViewCart.Rows[0].Cells[1].Tag = kryptonDataGridViewChoose.Rows[e.RowIndex].Cells[2].Value;
            }
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

        private void kryptonButtonSubmit_Click(object sender, EventArgs e)
        {

            if(kryptonDataGridViewCart.Rows.Count==0)
            {
                MessageBox.Show("no line");
                return;
            }
            // insert header first 

            byte revision = (byte)(purchase_order_revision_IDKryptonCheckBox.CheckState.ToString()=="true"?1:0);
            DateTime create_date = create_dateKryptonDateTimePicker.Value;
            DateTime effective_date = effective_dateKryptonDateTimePicker.Value;
            int supplier_ID = int.Parse( supplierNameKryptonComboBox.SelectedValue.ToString());
            int buyer_ID = int.Parse(kryptonTextBoxBuyerID.Text.ToString());
            DateTime tentaive_schedules = tentative_schedulesKryptonDateTimePicker.Value;
            int amount = ((int)amountKryptonNumericUpDown.Value);
            decimal currency = currencyKryptonNumericUpDown.Value;
            string term = termKryptonTextBox.Text;
            string condition = conditionKryptonTextBox.Text;


            ppo_headerTableAdapter.Insert(revision, create_date, effective_date, supplier_ID, buyer_ID, tentaive_schedules, amount, currency, term, condition);

            int ppo_header_id = ppo_headerTableAdapter.GetData().Last().header_ID;

            foreach (DataGridViewRow row in kryptonDataGridViewCart.Rows)
            {
                try
                { 
                    int header_ID = ppo_header_id;
                    int item_ID = int.Parse(row.Cells[1].Tag.ToString());
                    int qty = int.Parse(row.Cells[2].Value.ToString());
                    string UOM = row.Cells[3].Value.ToString();
                    decimal price = decimal.Parse(row.Cells[4].Value.ToString());
                    int line_amount = int.Parse(row.Cells[5].Value.ToString());
                    // bug : if reference is empty
                    string reference = row.Cells[6].Value.ToString();
                    Console.WriteLine("test");
                    ppo_linesTableAdapter.Insert(header_ID, item_ID, qty, UOM, price, line_amount, reference);
                }
                catch(Exception ex)
                {
                    ex.ToString();
                    MessageBox.Show(row.Cells[1].Value.ToString() + " miss input");
                    ppo_headerTableAdapter.Delete(ppo_header_id,revision, create_date, effective_date, supplier_ID, buyer_ID, tentaive_schedules, amount, currency, term, condition);
                    return;
                }
                
                
            }

            MessageBox.Show("create success");


        }
    }
}
