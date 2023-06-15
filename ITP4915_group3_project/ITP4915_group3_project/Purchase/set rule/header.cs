using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.Purchase.set_rule
{
    public partial class header : UserControl
    {
        Control panelContent;
        public header(Control header,Control panelContent)
        {
            InitializeComponent();
            this.panelContent = panelContent;

            header.Controls.Clear();
            header.Controls.Add(this);

            panelContent.Controls.Clear();
            new main(panelContent);

            
        }

    }
}
