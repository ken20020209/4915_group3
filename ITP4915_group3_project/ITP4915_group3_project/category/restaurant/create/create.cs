using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.category.restaurant.create
{
    public partial class create : UserControl
    {
        public create()
        {
            InitializeComponent();
        }

        private void restaurantBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.restaurantBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.category_dbDataSet);

        }

        private void kryptonButtonConfirm_Click(object sender, EventArgs e)
        {

        }
    }
}
