﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.category.brand.create
{
    public partial class create : Form
    {
        public create()
        {
            InitializeComponent();
        }

        private void kryptonButtonConfirm_Click(object sender, EventArgs e)
        {
            Form create_success = new brand.create.create_success();
            create_success.Show();
            
        }
    }
}