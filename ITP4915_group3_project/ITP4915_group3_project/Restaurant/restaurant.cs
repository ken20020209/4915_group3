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

        public restaurant()
        {
            InitializeComponent();

            //fake data
            restaurant_ID = 1;
            restaurant_Name = "yammay restaurant";

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
    }
}
