using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.Purchase.set_rule
{
    public partial class time : UserControl
    {
        Control panelContent;
        public time(Control panelContent)
        {
            InitializeComponent();
            this.panelContent = panelContent;
            panelContent.Controls.Add(this);
            this.BringToFront();

            kryptonDateTimePicker1.CustomFormat = "HH:mm";
            kryptonDateTimePicker2.CustomFormat = "HH:mm";
            kryptonDateTimePicker3.CustomFormat = "HH:mm";

            kryptonDateTimePicker1.Value = Properties.Settings.Default.matchTime1;
            kryptonDateTimePicker2.Value = Properties.Settings.Default.matchTime2;
            kryptonDateTimePicker3.Value = Properties.Settings.Default.matchTime3;

            

            
            
        }

        private void kryptonLabelBack_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Remove(this);

            Properties.Settings.Default.matchTime1 = kryptonDateTimePicker1.Value;
            Properties.Settings.Default.matchTime2 = kryptonDateTimePicker2.Value;
            Properties.Settings.Default.matchTime3 = kryptonDateTimePicker3.Value;
        }
    }
}
