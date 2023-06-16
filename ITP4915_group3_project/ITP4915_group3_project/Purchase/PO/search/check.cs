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
        private int curPO = 0;
        public check(Control panel)
        {
            InitializeComponent();
            this.panel = panel;
            this.panel.Controls.Add(this);
        }

        private void kryptonCheckButtonBPA_Click(object sender, EventArgs e)
        {
            new BPA.search(kryptonPanelSearchResult, kryptonTextBoxSearchBar.Text);
            curPO = 0;
        }

        private void kryptonCheckButtonCPA_Click(object sender, EventArgs e)
        {

            new CPA.search(kryptonPanelSearchResult, kryptonTextBoxSearchBar.Text);
            curPO = 1;
        }

        private void kryptonCheckButtonPPO_Click(object sender, EventArgs e)
        {
            new PPO.search(kryptonPanelSearchResult, kryptonTextBoxSearchBar.Text);
            curPO = 2;
        }
        private void kryptonCheckButtonSPO_Click(object sender, EventArgs e)
        {
            new SPO.search(kryptonPanelSearchResult, kryptonTextBoxSearchBar.Text);
            curPO = 3;

        }
        private void kryptonButtonSearch_Click(object sender, EventArgs e)
        {
            switch (curPO)
            {
                case 0: new BPA.search(kryptonPanelSearchResult, kryptonTextBoxSearchBar.Text); break;
                case 1: new CPA.search(kryptonPanelSearchResult, kryptonTextBoxSearchBar.Text); break;
                case 2: new PPO.search(kryptonPanelSearchResult, kryptonTextBoxSearchBar.Text); break;
                case 3: new SPO.search(kryptonPanelSearchResult, kryptonTextBoxSearchBar.Text); break;
            }
        }
    }
}
