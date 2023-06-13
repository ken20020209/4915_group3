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
    public partial class check_order : UserControl
    {
        Control panelContent;
        requestOrder newOrder;
        public check_order(Control panel,requestOrder newOrder)
        {
            InitializeComponent();
            panelContent = panel;
            panelContent.Controls.Add(this);
            this.BringToFront();

            this.newOrder = newOrder;
            //load data to form
            for (int i = 0; i < newOrder.item_ID.Count(); i++)
            {
                dataGridViewDetail.Rows.Insert(0, newOrder.item_ID[i], newOrder.item_qty[i], newOrder.item_name[i]);
            }
            kryptonTextBox1RestaurantName.Text = newOrder.restaurant_Name;
            kryptonTextBoxRestaurantID.Text = newOrder.restaurant_ID;
            kryptonTextBoxCreatorID.Text = newOrder.creator_ID;
            kryptonTextBoxCreatorName.Text = newOrder.creator_Name;
            kryptonTextBoxRequestID.Text = newOrder.request_ID;
            kryptonTextBoxCreateDate.Text = newOrder.mysqlDate.ToString();


        }

        private void kryptonButtonConfirm_Click(object sender, EventArgs e)
        {
            newOrder.priority = comboBoxPriority.Text;
            newOrder.insertDB();
            new create_success().ShowDialog();
        }

        private void kryptonLabelback_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Remove(this);
        }
    }
}
