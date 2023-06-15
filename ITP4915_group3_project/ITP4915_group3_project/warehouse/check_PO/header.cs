using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.warehouse.check_PO
{
    public partial class header : UserControl
    {
        private KryptonPanel kryptonPanelHeader;
        private KryptonPanel kryptonPanelContent;

        public header()
        {
            InitializeComponent();
        }

        public header(KryptonPanel kryptonPanelHeader, KryptonPanel kryptonPanelContent)
        {
            this.kryptonPanelHeader = kryptonPanelHeader;
            this.kryptonPanelContent = kryptonPanelContent;
        }

        private void kryptonButtonReview_Click(object sender, EventArgs e)
        {
            kryptonPanelContent.Controls.Clear();
            new check_PO.review(kryptonPanelContent);
        }
    }
}
