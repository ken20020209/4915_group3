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
            Form restaurant = new restaurant();
            restaurant.Show();
            this.Close();
        }
    }
}
