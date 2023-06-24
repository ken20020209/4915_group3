using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.Accounting
{
    public partial class detail : UserControl
    {
        public Control check;
        public int invoiceID;
        public detail(Control panel, int invoiceID)
        {
            InitializeComponent();
            check = panel;
            check.Controls.Add(this);
            this.invoiceID = invoiceID;
            this.BringToFront();
        }
    }
}
