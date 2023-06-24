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

namespace ITP4915_group3_project.Accounting
{
    public partial class accounting : KryptonForm
    {
        public static string user_name;
        public accounting()
        {
            InitializeComponent();

            user_name = General.login.Login.userName;
            kryptonLabelName.Text = user_name;

            kryptonButtonInvoice_Click(null, null);
        }
        private void moveLeftPic(Control btn)
        {
            pictureBoxLeft.Top = btn.Top - 26;
        }

        private void kryptonButtonInvoice_Click(object sender, EventArgs e)
        {
            new invoice.header(kryptonPanelHeader, kryptonPanelContent);
            moveLeftPic(kryptonButtonInvoice);
        }

        private void kryptonButton7_Click(object sender, EventArgs e)
        {
            new report.header(kryptonPanelHeader, kryptonPanelContent);
            moveLeftPic(kryptonButton7);
        }

        private void kryptonButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
