using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace ITP4915_group3_project.delivery
{
    public partial class delivery : KryptonForm
    {
        public static string user_name;
        public delivery()
        {
            InitializeComponent();

            user_name = General.login.Login.userName;
            kryptonLabelName.Text = user_name;

            kryptonButtonShedue_Click(null,null);
        }

        private void kryptonButtonShedue_Click(object sender, EventArgs e)
        {
            new search_schedule.header(kryptonPanelHeader, kryptonPanelContent);
        }

        private void kryptonButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
