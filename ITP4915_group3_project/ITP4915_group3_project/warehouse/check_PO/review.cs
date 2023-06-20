using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.warehouse.check_PO
{
    public partial class review : UserControl
    {
        public Control panel;
        private int curPO = 0;
        public review(Control panel)
        {
            InitializeComponent();
            this.panel = panel;
            panel.Controls.Clear();
            panel.Controls.Add(this);
        }


        private void kryptonButtonSearch_Click(object sender, EventArgs e)
        {
   
        }



    }
}
