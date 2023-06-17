using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.Purchase.request_order
{
    public partial class check : UserControl
    {
        public check(Control panelContent)
        {
            InitializeComponent();
            panelContent.Controls.Add(this);

            //load request
            this.purchasers_requestTableAdapter.Fill(this.purchase_dbDataSet.purchasers_request);

            
        }

        private void purchasers_requestKryptonDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0 || e.RowIndex == -1)
            {
                return;
            }
            else
            {
                int header_ID = (int)purchasers_requestKryptonDataGridView.Rows[e.RowIndex].Cells[1].Value;
                new detail(this, header_ID);
            }
        }
    }
}
