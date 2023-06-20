using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.category.category.select
{
    public partial class check : UserControl
    {
        public check(Control panel)
        {
            InitializeComponent();
        }

        private void item_categoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.item_categoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.category_dbDataSet);

        }
    }
}
