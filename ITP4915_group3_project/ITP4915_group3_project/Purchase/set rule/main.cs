﻿using System;
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
    public partial class main : UserControl
    {
        public main(Control panelContent)
        {
            InitializeComponent();
            panelContent.Controls.Add(this);
        }
        private void toMatch(object sender, EventArgs e)
        {
            new match(this);
        }
        private void toTime(object sender, EventArgs e)
        {
            new time(this);
        }
    }
}
