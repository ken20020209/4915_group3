using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.warehouse.delivery_note
{
    public partial class detail : UserControl
    {
        public Control panel;
        int deliveryID;
        public detail(Control panel, int deliveryID)
        {
            InitializeComponent();

            this.panel = panel;
            this.panel.Controls.Add(this);
            this.BringToFront();
            this.deliveryID = deliveryID;


        }
    }
}
