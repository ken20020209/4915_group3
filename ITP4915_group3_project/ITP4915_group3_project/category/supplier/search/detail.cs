﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.category.supplier.search
{
    public partial class detail : UserControl
    {
        private Control check;
        private int v;
        public detail(check check, int v)
        {
            this.check = check;
            this.v = v;
            InitializeComponent();
            check.Controls.Add(this);
            this.BringToFront();
        }
        private void kryptonLabel20_Click(object sender, EventArgs e)
        {
            check.Controls.Remove(this);
        }
        private void kryptonLabel11_Click(object sender, EventArgs e)
        {
            supplierBindingSource.RemoveCurrent();
            this.tableAdapterManager.UpdateAll(this.category_dbDataSet);
            MessageBox.Show("delete success");
            new delete_sucess().ShowDialog();
        }
        private void kryptonLabel10_Click(object sender, EventArgs e)
        {
            kryptonTextBox1.ReadOnly = false;
            kryptonTextBox2.ReadOnly = false;
            kryptonTextBox3.ReadOnly = false;
            kryptonTextBox4.ReadOnly = false;
            kryptonTextBox5.ReadOnly = false;
            kryptonTextBox6.ReadOnly = false;
            kryptonTextBox7.ReadOnly = false;
            kryptonTextBox8.ReadOnly = false;
            kryptonTextBox9.ReadOnly = false;
            kryptonTextBox10.ReadOnly = false;
            kryptonTextBox11.ReadOnly = false;
            kryptonTextBox12.ReadOnly = false;
            kryptonTextBox13.ReadOnly = false;
            kryptonRichTextBox1.ReadOnly = false;
            kryptonDomainUpDown1.ReadOnly = false;
            kryptonDropButton1.AllowDrop = true;
        }
    }
}
