using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.warehouse.check_PO.SPO
{
    public partial class detail : UserControl
    {
        public detail(Control panelContent, int header_ID)
        {
            InitializeComponent();
            panelContent.Controls.Add(this);
            this.BringToFront();
            this.spo_headerTableAdapter.FillBy_header_ID(this.purchase_dbDataSet.spo_header, header_ID);
            this.spo_linesTableAdapter.Fill(this.purchase_dbDataSet.spo_lines);
        }


    }
}
