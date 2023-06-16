using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace ITP4915_group3_project.Purchase
{
    public partial class purchase : KryptonForm
    {
        public purchase()
        {
            InitializeComponent();

            //load first page
            kryptonButtonPurchaseOrder_Click(null, null);
        }

        private void kryptonButtonPurchaseOrder_Click(object sender, EventArgs e)
        {
            new PO.header(kryptonPanelHeader, kryptonPanelContent);

        }

        private void kryptonButtonRequestOrder_Click(object sender, EventArgs e)
        {
            new request_order.header(kryptonPanelHeader, kryptonPanelContent);
        }

        private void kryptonButtonRuleSetting_Click(object sender, EventArgs e)
        {
            new set_rule.header(kryptonPanelHeader, kryptonPanelContent);
        }

        private void kryptonButtonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
