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
            filterAddress = $"warehouse_ID = {warehouse.warehouse_ID}";

            this.warehousedispatchinstructionTableAdapter.Fill(this.warehouse_dbDataSet.warehousedispatchinstruction);

            warehousedispatchinstructionBindingSource.Filter = filterAddress;
            kryptonLabel27.Text = warehousedispatchinstructionBindingSource.Count.ToString();
            setResult();
        }

        private void searchList()
        {
            listID = int.Parse(kryptonTextBox16.Text);
            warehousedispatchinstructionBindingSource.Filter = filterAddress + $" and Instruction_ID = {listID}";
            setResult();
        }

        private void setResult()
        {
            int result = warehousedispatchinstructionBindingSource.Count;
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
                warehousedispatchinstructionBindingSource.Filter = filterAddress;
                setResult();
            }
        }

        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == -1 || e.ColumnIndex != 0)
            {
                return;
            }
            new dedetail(this, (int)kryptonDataGridView1.Rows[e.RowIndex].Cells[1].Value);
        }
    }
}
