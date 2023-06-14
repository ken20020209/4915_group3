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
    public partial class search : UserControl
    {
        public Control panelContent1;
        public search(Control panelContent)
        {
            InitializeComponent();

            this.panelContent1 = panelContent;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(this);
        }
    }
}
