﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace ITP4915_group3_project.General.login
{
    public partial class Login : KryptonForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void kryptonButtonSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new General.navi.navi().ShowDialog();
            this.Show();
            
            

        }

        private void kryptonLabelForgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Forget().ShowDialog();
            this.Show();
        }
    }
}