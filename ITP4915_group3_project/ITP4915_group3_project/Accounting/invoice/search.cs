using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.Accounting
{
    public partial class search : UserControl
    {
        public Control panel;
        private int invoice_ID;
        
        public search(Control panel)
        {
            InitializeComponent();
            this.panel = panel;
            panel.Controls.Clear();
            panel.Controls.Add(this);

            this.invoiceTableAdapter.Fill(this.accounting_dbDataSet.invoice);

            invoiceBindingSource.Filter = "status_ID = 4000";
            kryptonLabel27.Text = invoiceBindingSource.Count.ToString();

            invoiceBindingSource.Filter = "";
            kryptonLabelResult.Text = "RESULT(" + invoiceBindingSource.Count.ToString() + ")";
        }

        private void searchInvoice()
        {
            invoice_ID = int.Parse(kryptonTextBox16.Text);
            invoiceBindingSource.Filter = $"invoice_ID = {invoice_ID}";
            kryptonLabelResult.Text = "RESULT(" + invoiceBindingSource.Count.ToString() + ")";
        }

        private void kryptonTextBox16_TextChanged(object sender, EventArgs e)
        {
            if (kryptonTextBox16.TextLength > 0)
            {
                searchInvoice();
            }
            else
            {
                invoiceBindingSource.Filter = "";
                kryptonLabelResult.Text = "RESULT(" + invoiceBindingSource.Count.ToString() + ")";
            }
        }

        private void kryptonComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int status_ID = 4100;
            if (kryptonComboBox2.Text == "wait for process")
            {
                status_ID = 4000;
            }
            invoiceBindingSource.Filter = $"status_ID = {status_ID}";
        }

        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex != 0)
            {
                return;
            }
            new detail(this, int.Parse(kryptonDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()));
        }
    }
}
