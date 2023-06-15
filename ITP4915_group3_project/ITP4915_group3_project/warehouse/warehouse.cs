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

namespace ITP4915_group3_project.warehouse
{
    public partial class warehouse : KryptonForm
    {
        public warehouse()
        {
            InitializeComponent();

            kryptonBtnCheckPO_Click(null, null);
        }

        private void warehouse_Load(object sender, EventArgs e)
        {

        }

        private void kryptonPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonBtnCheckPO_Click(object sender, EventArgs e)
        {
            new check_PO.header(kryptonPanelHeader, kryptonPanelContent);
        }
    }
}
