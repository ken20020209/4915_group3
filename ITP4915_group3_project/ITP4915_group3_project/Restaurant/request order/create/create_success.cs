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

namespace ITP4915_group3_project.Restaurant.request_order.create
{
    public partial class create_success : KryptonForm
    {
        public create_success()
        {
            InitializeComponent();
        }

        private void kryptonButtonOk_Click(object sender, EventArgs e)
        {
            new select_item(select_item.panelContent);
            this.Close();
        }
    }
}
