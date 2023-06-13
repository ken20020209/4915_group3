using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.Restaurant.request_order.create
{
    public partial class complete_detail : UserControl
    {
        Control panelContent;
        requestOrder newOrder;
        public complete_detail(select_item panel,requestOrder newOrder)
        {
            InitializeComponent();
            this.panelContent = panel;
            panel.Controls.Add(this);
            this.BringToFront();

            
            this.newOrder = newOrder;
            //get id form selected control
            for(int i=0;i<newOrder.item_ID.Count();i++)
            {
                dataGridViewDetail.Rows.Insert(0, newOrder.item_ID[i], null, newOrder.item_name[i]);
            }
            kryptonTextBoxQtyOfItems.Text = newOrder.item_ID.Count().ToString();
        }

        private void kryptonButtonCountinue_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow qty in dataGridViewDetail.Rows)
            {
                //miss validation
                newOrder.item_qty.Add(int.Parse(qty.Cells[1].Value.ToString()));
            }
            new check_order(this,newOrder);
        }

        private void kryptonLabelback_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Remove(this);
        }
    }
}
