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
    public partial class detail : UserControl
    {
        public Control check;
        public int invoiceID;
        public detail(Control panel, int invoiceID)
        {
            InitializeComponent();
            check = panel;
            check.Controls.Add(this);
            this.invoiceID = invoiceID;
            this.BringToFront();

            this.invoiceTableAdapter.Fill(accounting_dbDataSet.invoice);
            this.itemTableAdapter.Fill(accounting_dbDataSet.item);
            this.delivery_requestTableAdapter.Fill(accounting_dbDataSet.delivery_request);

            invoiceBindingSource.Filter = $"invoice_ID = {invoiceID}";

            DataRowView dataRowView = (DataRowView)invoiceBindingSource.Current;
            accounting_dbDataSet.invoiceRow dataRow = invoiceTableAdapter.GetData().FindByInvoice_ID(invoiceID);
            if (dataRow.status_ID == "4100")
            {
                kryptonButton11.Visible = false;
            }
        }

        private void kryptonButton11_Click(object sender, EventArgs e)
        {
            new invoice.process.compare(this, invoiceID);
        }

        private void kryptonLabel4_Click(object sender, EventArgs e)
        {
            check.Controls.Remove(this);
        }
    }
}
