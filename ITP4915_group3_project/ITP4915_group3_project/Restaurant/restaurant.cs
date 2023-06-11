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
        public restaurant()
        {
            InitializeComponent();
            
        }

        private void krytonBtnMenuRequestOrder_Click(object sender, EventArgs e)
        {
    /*        // change content to request oders page
            // get stock.check form
            Form check = new Restaurant.request_order.check();
            //clear all contorls of panel
            kryptonPanelContent.Controls.Clear();
            //find control 
            Control content = check.Controls.Find("kryptonGroupContent", true)[0];
            //place on content
            kryptonPanelContent.Controls.Add(content);*/

           /* kryptonPanelContent.Controls.Clear();*/
            kryptonPanelContent.Controls.Add(new request_order.search.check());
            kryptonPanelHeader.Controls.Clear();
            kryptonPanelHeader.Controls.Add(new request_order.header(kryptonPanelContent));
            
        }

        private void kryptonButtonMenuDeliveryNote_Click(object sender, EventArgs e)
        {
/*            // change content to Delivery Note page
            // get stock.check form
            Form check = new Restaurant.delivery_note.search();
            //clear all contorls of panel
            kryptonPanelContent.Controls.Clear();
            //find control 
            Control content = check.Controls.Find("panelContent", true)[0];
            //place on content
            kryptonPanelContent.Controls.Add(content);
            kryptonPanelContent.Controls.Clear();
            kryptonPanelContent.Controls.Add(new stock.check());*/

            kryptonPanelContent.Controls.Clear();
            kryptonPanelContent.Controls.Add(new delivery_note.check());
        }

        private void kryptonButtonMenuStock_Click(object sender, EventArgs e)
        {
            /*// change content to stock page
            // get stock.check form
            Form check = new Restaurant.stock.check();
            //clear all contorls of panel
            kryptonPanelContent.Controls.Clear();
            //find control from stock
            Control content = check.Controls.Find("panelContent", true)[0];
            //place on content
            kryptonPanelContent.Controls.Add(content);*/

            // use user controls 
            kryptonPanelContent.Controls.Clear();
            kryptonPanelContent.Controls.Add(new stock.check());
            
        }
    }
}
