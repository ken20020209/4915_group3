using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.warehouse.check_PO
{
    public partial class review : UserControl
    {
        public Control panelContent;
        public review(Control panelContent)
        {
            InitializeComponent();
            this.panelContent = panelContent;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(this);
        }
    }
}
