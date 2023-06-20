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


namespace ITP4915_group3_project.Restaurant
{
    public partial class restaurant : KryptonForm
    {
        public static int restaurant_ID;
        public static string restaurant_Name;
        public static int address_ID;

        public restaurant()
        {
            InitializeComponent();

            //fake data
            restaurant_ID = 1;
            restaurant_Name = "yammay restaurant";
            address_ID = 1;

            this.restaurantTableAdapter.Fill(this.restaurant_dbDataSet.restaurant);

            restaurant_dbDataSet.restaurantRow[] rows= (restaurant_dbDataSet.restaurantRow[])this.restaurant_dbDataSet.restaurant.Select($"manager_ID='{General.login.Login.user_ID}'");

            if(rows.Length==1)
            {
                restaurant_Name = rows[0].name;
                restaurant_ID = rows[0].restaurant_ID;
                address_ID = rows[0].address_ID;
            }
            else
            {
                //pick a restaurant code
                new choose().ShowDialog();
            }

            
            kryptonLabelUserName.Text = General.login.Login.userName;

            krytonBtnMenuRequestOrder_Click(null, null);
            
        }

        private void krytonBtnMenuRequestOrder_Click(object sender, EventArgs e)
        {
            // add content and header change page
            new request_order.header(kryptonPanelHeader,kryptonPanelContent);
            
        }

        private void kryptonButtonMenuDeliveryNote_Click(object sender, EventArgs e)
        {
            // add content and header change page
            new delivery_note.header(kryptonPanelHeader,kryptonPanelContent);


        }

        private void kryptonButtonMenuStock_Click(object sender, EventArgs e)
        {
            // add content and header change page
            new stock.header(kryptonPanelHeader, kryptonPanelContent);

        }

        private void kryptonButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonLabelUserName_Click(object sender, EventArgs e)
        {

        }
    }
}
