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
        public static int warehouse_ID;
        public static int warehouse_address_ID;
        public static string user_name;
        public warehouse()
        {
            InitializeComponent();

            //fake data
            warehouse_ID = 1;

            user_name = General.login.Login.userName;

            kryptonLabelUserName.Text = user_name;

            kryptonBtnPO_Click(null, null);
        }


        private void moveLeftPic(Control btn)
        {
            pictureBoxLeft.Top = btn.Top - 26;
        }




        private void kryptonBtnDeliveryNote_Click(object sender, EventArgs e)
        {
            new delivery_note.header(kryptonPanelHeader, kryptonPanelContent);
            moveLeftPic(kryptonBtnDeliveryNote);
        }

        private void kryptonBtnStock_Click(object sender, EventArgs e)
        {
            new search_stock.header(kryptonPanelHeader, kryptonPanelContent);
            moveLeftPic(kryptonBtnStock);
        }

        private void kryptonBtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonBtnPO_Click(object sender, EventArgs e)
        {
             new check_PO.header(kryptonPanelHeader, kryptonPanelContent);
             moveLeftPic(kryptonBtnPO);
           
        }

        private void kryptonBtnPickingList_Click(object sender, EventArgs e)
        {
            new picking_list.header(kryptonPanelHeader, kryptonPanelContent);
            moveLeftPic(kryptonBtnPickingList);
        }


    }
}
