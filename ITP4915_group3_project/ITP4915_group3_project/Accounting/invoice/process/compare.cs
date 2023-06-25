using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.Accounting.invoice.process
{
    public partial class compare : UserControl
    {
        public Control detail;
        public int invoice_ID;
        public compare(Control panel, int invoice_ID)
        {
            InitializeComponent();
            detail = panel;
            detail.Controls.Add(this);
            this.invoice_ID = invoice_ID;
            this.BringToFront();

            this.invoiceTableAdapter.Fill(this.accounting_dbDataSet.invoice);
            this.itemTableAdapter.Fill(this.accounting_dbDataSet.item);
            this.delivery_requestTableAdapter.Fill(this.accounting_dbDataSet.delivery_request);

            invoiceBindingSource.Filter = $"Invoice_ID = {invoice_ID}";
        }

        private void kryptonLabel4_Click(object sender, EventArgs e)
        {
            detail.Controls.Remove(this);
        }

        private void kryptonButton11_Click(object sender, EventArgs e)
        {
            new confrim(invoice_ID).ShowDialog();
        }
    }
}
