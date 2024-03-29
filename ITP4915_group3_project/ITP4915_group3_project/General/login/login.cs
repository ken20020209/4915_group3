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
        public static string userName;
        public static string password;
        public static int user_ID=0;
        public static string realName;
        public static int role_id=0;
        public Login()
        {
            InitializeComponent();

            //fake data need to fetch from database
            userName = "test";
            password = "test";
            user_ID = 5;
            realName = "sam yau";
        }

        private void kryptonButtonSignIn_Click(object sender, EventArgs e)
        {

            // where id =id password = password
            if(kryptonTextBoxPassword.Text==null || kryptonTextBoxUserName.Text.Length==0)
            {
                MessageBox.Show("Please enter password and user name");
                return;
            }
            
            restaurant_dbDataSet.userDataTable user = userTableAdapter.GetDataBy_UserName_Password(kryptonTextBoxPassword.Text, kryptonTextBoxUserName.Text);
            if(user.Rows.Count==1)
            {
                //save data
                userName = user.Rows[0]["user_name"].ToString();
                user_ID = int.Parse(user.Rows[0]["user_id"].ToString());
                password = user.Rows[0]["password"].ToString();
                realName = user.Rows[0]["last_name"].ToString() + user.Rows[0]["first_name"].ToString();

                /*Console.WriteLine(userName + " " + password + " " + user_ID +" "+ realName);*/

                // follow role to different system
                humanResources_dbDataSetTableAdapters.roleTableAdapter roleTableAdapter = new humanResources_dbDataSetTableAdapters.roleTableAdapter();
                role_id = (int)user.Rows[0]["role_id"];
                string role_name = roleTableAdapter.GetData().FindByrole_id(role_id).role_name;

                this.Hide();
                new General.navi.navi(role_name).ShowDialog();
                this.Show();
                

               
            }
            else
            {
                MessageBox.Show("wrong user id and name");
            }

            
            
            

        }

        private void kryptonLabelForgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Forget().ShowDialog();
            this.Show();
        }

        private void kryptonButtonWhitOutPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            new General.navi.navi().ShowDialog();
            this.Show();
        }
    }
}
