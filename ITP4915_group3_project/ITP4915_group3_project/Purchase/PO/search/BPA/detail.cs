using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.Purchase.PO.search.BPA
{
    public partial class detail : UserControl
    {
        public detail(Control panelContent,int header_ID)
        {
            InitializeComponent();
            panelContent.Controls.Add(this);
            this.BringToFront();
            this.bpa_headerTableAdapter.FillBy_header_ID(this.purchase_dbDataSet.bpa_header, header_ID);
            this.bpa_linesTableAdapter.Fill(this.purchase_dbDataSet.bpa_lines);

            
        }
        private void kryptonButtonSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bpa_headerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.purchase_dbDataSet);

            MessageBox.Show("edit success");
        }
    }
}
