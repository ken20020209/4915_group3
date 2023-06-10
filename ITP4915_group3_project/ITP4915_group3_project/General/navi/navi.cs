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
namespace ITP4915_group3_project.General.navi
{
    public partial class navi : Krypton.Toolkit.KryptonForm
    {
        public navi()
        {
            InitializeComponent();
        }

        private void kryptonButtonRestaurant_Click(object sender, EventArgs e)
        {
            // jump to restaurant form
            this.Hide();
            new Restaurant.restaurant().ShowDialog();
            this.Close();
        }

        private void kryptonButtonWarehosue_Click(object sender, EventArgs e)
        {
            this.Hide();
            new warehouse.warehouse().ShowDialog();
            this.Close();
        }

        private void kryptonButtonPurchase_Click(object sender, EventArgs e)
        {
            this.Hide();
            new purchase().ShowDialog();
            this.Close();
        }

        private void kryptonButtonDelivery_Click(object sender, EventArgs e)
        {
            this.Hide();
            new delivery.delivery().ShowDialog();
            this.Close();
        }

        private void kryptonButtonCategory_Click(object sender, EventArgs e)
        {
            this.Hide();
            new category.Category().ShowDialog();
            this.Close();
        }

        private void kryptonButtonAccounting_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Accounting.accounting().ShowDialog();
            this.Close();
        }
    }
}
