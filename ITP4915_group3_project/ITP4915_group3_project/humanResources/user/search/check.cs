﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.humanResources.user.search
{
    public partial class check : UserControl
    {
        public Control panel;
        private int curPO = 0;
        public check(Control panel)
        {
            InitializeComponent();
            this.panel = panel;
            this.panel.Controls.Add(this);

        }


    }
}