using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.Purchase.PO.search
{
    public partial class check : UserControl
    {
        public Control panel;
        public check(Control panel)
        {
            InitializeComponent();
            this.panel = panel;
            this.panel.Controls.Add(this);
        }

        private void kryptonCheckButtonBPA_Click(object sender, EventArgs e)
        {
            new BPA.search(kryptonPanelSearchResult, kryptonTextBoxSearchBar.Text);
        }
    }
}
