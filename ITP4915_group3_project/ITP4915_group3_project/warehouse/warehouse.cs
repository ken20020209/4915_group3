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

namespace ITP4915_group3_project.warehouse
{
    public partial class warehouse : KryptonForm
    {
        public warehouse()
        {
            InitializeComponent();

            kryptonBtnPO_Click(null, null);
        }



        private void kryptonBtnPO_Click(object sender, EventArgs e)
        {
            new check_PO.header(kryptonPanelHeader, kryptonPanelContent);
        }

        private void kryptonBtnPickingList_Click(object sender, EventArgs e)
        {
            new picking_list.header(kryptonPanelHeader, kryptonPanelContent);
        }

        private void kryptonBtnDeliveryNote_Click(object sender, EventArgs e)
        {
            new delivery_note.header(kryptonPanelHeader, kryptonPanelContent);
        }

        private void kryptonBtnStock_Click(object sender, EventArgs e)
        {
            new search_stock.header(kryptonPanelHeader, kryptonPanelContent);
        }

        private void kryptonBtnPO_Click_1(object sender, EventArgs e)
        {
            new check_PO.header(kryptonPanelHeader, kryptonPanelContent);
        }
    }
}
