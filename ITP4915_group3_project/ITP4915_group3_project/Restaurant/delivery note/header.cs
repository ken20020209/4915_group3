﻿using System;
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
    public partial class header : UserControl
    {
        Control panelContent;
        public header(Control panel)
        {
            InitializeComponent();
            this.panelContent = panel;
        }
        private void kryptonButtonReview_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            panelContent.Controls.Add(new search());
        }
    }
}
