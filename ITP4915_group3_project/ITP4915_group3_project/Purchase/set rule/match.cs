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
    public partial class match : UserControl
    {
        Control panelContent;
        public match(Control panelContent)
        {
            InitializeComponent();
            this.panelContent = panelContent;
            panelContent.Controls.Add(this);
            this.BringToFront();

            kryptonComboBoxMatchBPA.Text= Properties.Settings.Default.autoBPA;
            kryptonComboBoxAutoMatch.Text = Properties.Settings.Default.autoMatch;
            kryptonComboBoxMatchWarehouse.Text = Properties.Settings.Default.autoWarehouse;
        }

        private void kryptonLabelBack_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Remove(this);
        }

        private void kryptonButtonSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.autoBPA = kryptonComboBoxMatchBPA.Text;
            Properties.Settings.Default.autoMatch = kryptonComboBoxAutoMatch.Text;
            Properties.Settings.Default.autoWarehouse = kryptonComboBoxMatchWarehouse.Text;
            Properties.Settings.Default.Save();
        }
    }
}
