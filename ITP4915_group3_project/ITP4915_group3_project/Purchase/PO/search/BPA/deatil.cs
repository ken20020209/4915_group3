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
    public partial class deatil : UserControl
    {
        public deatil()
        {
            InitializeComponent();
        }

        private void bpa_headerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
        }
    }
}
