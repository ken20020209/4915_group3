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
    public partial class create : UserControl
    {
        Control panelContent;
        public create(Control panel)
        {
            InitializeComponent();
            panelContent = panel;
            panelContent.Controls.Add(this);
            this.BringToFront();


        }

        private void delivery_requestBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.delivery_requestBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.delivery_dbDataSet);

        }

        private void kryptonGroupBox1_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void delivery_address_IDTextBox_TextChanged(object sender, EventArgs e)
        {

           // kryptonRichTextBoxShipFrom.Text = ;
        }
    }
}
