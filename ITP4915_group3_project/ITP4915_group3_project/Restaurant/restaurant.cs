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
            
            
        }

        private void krytonBtnMenuRequestOrder_Click(object sender, EventArgs e)
        {

            kryptonPanelContent.Controls.Clear();
            kryptonPanelContent.Controls.Add(new request_order.search.check());
            kryptonPanelHeader.Controls.Clear();
            kryptonPanelHeader.Controls.Add(new request_order.header(kryptonPanelContent));
            
        }

        private void kryptonButtonMenuDeliveryNote_Click(object sender, EventArgs e)
        {

            kryptonPanelContent.Controls.Clear();
            kryptonPanelContent.Controls.Add(new delivery_note.check());
        }

        private void kryptonButtonMenuStock_Click(object sender, EventArgs e)
        {
            // use user controls 
            kryptonPanelContent.Controls.Clear();
            kryptonPanelContent.Controls.Add(new stock.check());
            
        }
    }
}
