using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.Restaurant.stock
{
    public partial class check : UserControl
    {
        public check()
        {
            InitializeComponent();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            new detail("0", "0").Show();
        }
    }
}
