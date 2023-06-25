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
    public partial class confrim : Form
    {
        int invoiceID;
        public confrim(int invoiceID)
        {
            InitializeComponent();
            this.invoiceID = invoiceID;
        }

        private void kryptonButton8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            accounting_dbDataSet.invoiceRow dataRow = invoiceTableAdapter.GetData().FindByInvoice_ID(invoiceID);
            dataRow.status_ID = "4100";
            invoiceTableAdapter.Update(dataRow);
            MessageBox.Show("process complete");
            this.Close();
        }

    }

}
