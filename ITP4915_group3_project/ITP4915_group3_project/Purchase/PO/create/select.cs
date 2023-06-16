using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.Purchase.PO.create
{
    public partial class select : UserControl
    {
        public Control panel;
        public select(Control panel)
        {
            InitializeComponent();
            this.panel = panel;
            this.panel.Controls.Add(this);
        }
        public void createBPA(object sender, EventArgs e)
        {
            new BPA.create(this);
        }
        public void createCPA(object sender, EventArgs e)
        {
            new CPA.create(this);
        }
        public void createPPO(object sender, EventArgs e)
        {
            new PPO.create(this);
        }
        public void createSPO(object sender, EventArgs e)
        {
            new SPO.create(this);
        }
        

    }
}
