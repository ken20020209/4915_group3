using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.category.category.create
{
    public partial class create : UserControl 
    {
        public create(Control panelContent)
        {
            InitializeComponent();
            panelContent.Controls.Add(this);
            this.BringToFront();
        }
    }
}
