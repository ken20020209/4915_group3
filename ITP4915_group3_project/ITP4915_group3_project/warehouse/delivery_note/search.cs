using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.warehouse.delivery_note
{
    public partial class search : UserControl
    {
        public Control panel;
        public int request_ID;
        public String filterAddress;

        public search(Control panel)
        {
            InitializeComponent();
            this.panel = panel;
            panel.Controls.Clear();
            panel.Controls.Add(this);
            filterAddress = $"delivery_address_ID = {warehouse.address_ID} and status_ID NOT IN(3000)";

            this.delivery_requestTableAdapter.Fill(this.warehouse_dbDataSet.delivery_request);

            delivery_requestBindingSource.Filter = filterAddress + "and status_ID = 3100";
            kryptonLabel27.Text = delivery_requestBindingSource.Count.ToString();

            delivery_requestBindingSource.Filter = filterAddress + "and status_ID = 3200";
            kryptonLabel23.Text = delivery_requestBindingSource.Count.ToString();

            delivery_requestBindingSource.Filter = filterAddress;
            setResult();
        }

        private void searchNote()
        {
            request_ID = int.Parse(kryptonTextBox16.Text);
            delivery_requestBindingSource.Filter = filterAddress + $" and delivery_request_ID = {request_ID}";
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
                searchNote();
            }
            else
            {
                delivery_requestBindingSource.Filter = filterAddress;
                setResult();
            }
        }

        private void kryptonComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int status_ID = 3100;
            if(kryptonComboBox2.Text == "wait for sign")
            {
                status_ID = 3200;
            }else
            {
                status_ID = 3100;
            }
            delivery_requestBindingSource.Filter = filterAddress + $"and status_ID = {status_ID}";
            
            setResult();
        }

        private void kryptonDataGridView_deliveryNoteSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex != 0)
            {
                return;
            }
            //new detail(this, (int)kryptonDataGridView_deliveryNoteSearch.Rows[e.RowIndex].Cells[1].Value);
            new Restaurant.delivery_note.check(this, (int)kryptonDataGridView_deliveryNoteSearch.Rows[e.RowIndex].Cells[1].Value);
        }
    }
}
