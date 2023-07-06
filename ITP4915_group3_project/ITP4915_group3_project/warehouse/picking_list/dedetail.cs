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
    public partial class dedetail : UserControl
    {
        public Control check;
        public int listID, warehouseID;
        public dedetail(Control panel, int listID)
        {
            InitializeComponent();
            check = panel;
            check.Controls.Add(this);
            this.listID = listID;
            warehouseID = warehouse.warehouse_ID;
            this.BringToFront();

            this.warehousedispatchinstructionTableAdapter.Fill(this.warehouse_dbDataSet.warehousedispatchinstruction);
            warehousedispatchinstructionBindingSource.Filter = $"Instruction_ID = {listID}";
        }

        private void kryptonLabel7_Click(object sender, EventArgs e)
        {
            check.Controls.Remove(this);
        }

        private void kryptonButton8_Click(object sender, EventArgs e)
        {
            new confrim(check, listID).ShowDialog();
        }
    }
}
