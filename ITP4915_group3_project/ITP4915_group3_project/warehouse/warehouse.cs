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
        public static int address_ID;
        public static int warehouse_address_ID;
        public static string user_name;
        public warehouse()
        {
            InitializeComponent();

            warehouse_ID = getWarehouseID(General.login.Login.role_id);

            user_name = General.login.Login.userName;
            kryptonLabelUserName.Text = user_name;

            kryptonBtnPO_Click(null, null);
        }

        private int getWarehouseID(int ware)
        {
            switch (ware)
            {
                case 21:
                    address_ID = 3;
                    return 1;
                case 22:
                    address_ID = 4;
                    return 2;
                case 23:
                    address_ID = 1;
                    return 3;
                default:
                    address_ID = 3;
                    return 1;
            }
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
