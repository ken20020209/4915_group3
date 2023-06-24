using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.warehouse.picking_list
{
    public partial class check : UserControl
    {
        public Control panel;
        public String filterAddress;
        public int listID; 
        public check(Control panel)
        {
            InitializeComponent();
            this.panel = panel;
            panel.Controls.Clear();
            panel.Controls.Add(this);
            filterAddress = $"delivery_address_ID = {warehouse.address_ID} and status_ID = 3000";

            this.delivery_requestTableAdapter.Fill(this.warehouse_dbDataSet.delivery_request);

            delivery_requestBindingSource.Filter = filterAddress;
            setResult();
        }

        private void searchList()
        {
            listID = int.Parse(kryptonTextBox16.Text);
            delivery_requestBindingSource.Filter = filterAddress + $" and delivery_request_ID = {listID}";
            setResult();
        }

        private void setResult()
        {
            int result = delivery_requestBindingSource.Count;
            kryptonLabelResult.Text = $"RESULT ({result})";
        }

        private void kryptonTextBox16_TextChanged(object sender, EventArgs e)
        {
            if (kryptonTextBox16.TextLength > 0)
            {
                searchList();
            }
            else
            {
                delivery_requestBindingSource.Filter = filterAddress;
                setResult();
            }
        }

        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex != 0)
            {
                return;
            }
            new detail(this, listID);
        }
    }
}
