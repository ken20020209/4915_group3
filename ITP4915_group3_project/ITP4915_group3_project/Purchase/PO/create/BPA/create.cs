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
        public static Control panelContent;
        public create(Control panelContent)
        {
            InitializeComponent();
            create.panelContent = panelContent;

            panelContent.Controls.Add(this);
            this.BringToFront();

            this.bpa_headerTableAdapter.Fill(this.purchase_dbDataSet.bpa_header);
            this.bpa_linesTableAdapter.Fill(this.purchase_dbDataSet.bpa_lines);

            //create new record
            this.bpa_headerBindingSource.AddNew();
            this.bpa_headerBindingSource.MoveLast();

/*            int nextID = Convert.ToInt32(this.purchase_dbDataSet.bpa_header.Compute("MAX(header_ID)", "")) + 1;

            ((DataRowView)this.bpa_headerBindingSource.Current).Row.SetField<int>("header_ID", nextID);*/

            this.bpa_linesBindingSource.AllowNew = false;

            create_dateKryptonDateTimePicker.Value = DateTime.Now;
            effective_datesKryptonDateTimePicker.Value = DateTime.Now;
            purchase_order_revisionKryptonCheckBox.Checked =false;
            agreed_amountKryptonNumericUpDown.Value = 1;
            currencyKryptonNumericUpDown.Value = 1;



            //set buyer id
            buyer_IDKryptonTextBox.Text = General.login.Login.user_ID.ToString();
            

            this.supplierTableAdapter.Fill(this.purchase_dbDataSet.supplier);
            this.itemTableAdapter.Fill(this.purchase_dbDataSet.item);

            supplier_IDKryptonTextBox.Text = ((DataRowView)supplierBindingSource.Current).Row.Field<int>("supplier_ID").ToString();
        }


        private void supplierComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            supplier_IDKryptonTextBox.Text = int.Parse(supplierComboBox.SelectedValue.ToString()).ToString();
        }

        private void itemKryptonDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if(e.RowIndex==-1||e.ColumnIndex!=0)
            {
                return;
            }
            purchase_dbDataSet.bpa_linesRow bpa_LinesRow= this.purchase_dbDataSet.bpa_lines.Newbpa_linesRow();
            bpa_LinesRow.item_ID = (int)itemKryptonDataGridView.Rows[e.RowIndex].Cells[1].Value;
            bpa_LinesRow.header_ID = ((DataRowView)bpa_headerBindingSource.Current).Row.Field<int>("header_ID");
            
            bpa_LinesRow.promised_qty = (int)promised_qtyKryptonNumericUpDown.Value;
            bpa_LinesRow.UOM = uOMKryptonTextBox.Text;
            bpa_LinesRow.MoQ = (int)moQKryptonNumericUpDown.Value;
            bpa_LinesRow.price = (int)priceKryptonNumericUpDown.Value;
            bpa_LinesRow.amount = (int)amountKryptonNumericUpDown.Value;
            bpa_LinesRow.reference = referenceKryptonTextBox.Text;

            this.purchase_dbDataSet.bpa_lines.Addbpa_linesRow(bpa_LinesRow);

   

        }

        private void dataGridViewSelected_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex != 0)
            {
                return;
            }
            bpa_linesKryptonDataGridView.Rows.RemoveAt(e.RowIndex);
        }

        private void kryptonButtonSubmit_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bpa_headerBindingSource.EndEdit();
            this.bpa_linesBindingSource.EndEdit();

            if(this.purchase_dbDataSet.bpa_lines.Select("header_ID=-1").Length==0)
            {
                MessageBox.Show("no line bpa");
                return;
            }
            this.bpa_headerTableAdapter.Update(this.purchase_dbDataSet.bpa_header);
            
            foreach(DataRow dataRow in this.purchase_dbDataSet.bpa_lines.Select("header_ID=-1"))
            {
                dataRow.SetField<int>("header_ID", this.bpa_headerTableAdapter.GetData().Last().header_ID);
            }
            this.bpa_linesTableAdapter.Update(this.purchase_dbDataSet.bpa_lines);

           
            MessageBox.Show("create success");
            new create(create.panelContent);
        }


        private void bpa_linesKryptonDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex==-1||e.ColumnIndex!=0)
            {
                return;
            }
            bpa_linesBindingSource.RemoveCurrent();
        }
    }
}
