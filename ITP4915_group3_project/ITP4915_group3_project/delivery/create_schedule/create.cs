﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.delivery.create_schedule
{
    public partial class create : UserControl
    {
        public Control panel;
        public create(Control panel)
        {
            InitializeComponent();
            this.panel = panel;
            panel.Controls.Clear();
            panel.Controls.Add(this);
        }
    }
}
