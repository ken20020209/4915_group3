﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form login = new General.login.Login();
            /*Application.Run(new test());*/
            Application.Run(login);

            /*Application.Run(new Restaurant.stock.detail("0","0"));*/
        }
    }
}