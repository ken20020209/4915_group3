using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.Purchase.PO.search.PPO
{
    public partial class detail : UserControl
    {
        public detail(Control panelContent, int header_ID)
        {
            InitializeComponent();
            panelContent.Controls.Add(this);
            this.BringToFront();
            this.ppo_headerTableAdapter.Fill(this.purchase_dbDataSet.ppo_header);
            

        }

        private void kryptonButtonSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ppo_headerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.purchase_dbDataSet);
        }
    }
}
