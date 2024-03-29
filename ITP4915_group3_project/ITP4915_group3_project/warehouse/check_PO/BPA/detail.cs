﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.warehouse.check_PO.BPA
{
    public partial class detail : UserControl
    {
        public Control panel;
        public detail(Control panelContent, int header_ID)
        {
            InitializeComponent();
            panelContent.Controls.Add(this);
            panel = panelContent;
            this.BringToFront();
            this.bpa_headerTableAdapter.FillBy_header_ID(this.purchase_dbDataSet.bpa_header, header_ID);
            this.bpa_linesTableAdapter.Fill(this.purchase_dbDataSet.bpa_lines);

        }

        private void kryptonLabel4_Click(object sender, EventArgs e)
        {
            panel.Controls.Remove(this);
        }
    }
}
