using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.Restaurant.delivery_note
{
    public partial class check : UserControl
    {
        public Control panel;
        public check(Control panel)
        {
            InitializeComponent();

            this.panel = panel;
            this.panel.Controls.Clear();
            this.panel.Controls.Add(this);
        }

        private void kryptonGroupBox5_Panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
