using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.Purchase.PO.search.CPA
{
    public partial class detail : UserControl
    {
        public detail(Control panelContent, int cpa_ID)
        {
            InitializeComponent();
            panelContent.Controls.Add(this);
            this.BringToFront();
            this.cpaTableAdapter.FillBy_cpa_id(this.purchase_dbDataSet.cpa, cpa_ID);


        }
        private void kryptonButtonSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cpaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.purchase_dbDataSet);
            MessageBox.Show("edit success");
        }


    }
}
