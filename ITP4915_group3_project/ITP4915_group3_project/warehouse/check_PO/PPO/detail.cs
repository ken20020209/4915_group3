using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.warehouse.check_PO.PPO
{
    public partial class detail : UserControl
    {
        public detail(Control panelContent, int header_ID)
        {
            InitializeComponent();
            panelContent.Controls.Add(this);
            this.BringToFront();
            this.ppo_headerTableAdapter.Fill(this.purchase_dbDataSet.ppo_header);
            this.ppo_linesTableAdapter.Fill(this.purchase_dbDataSet.ppo_lines);
        }
    }
}
