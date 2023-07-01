using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.category.warehouse.stock
{
    public partial class check : UserControl
    {
        public static Control panel;

        public check(Control panel ,int id)
        {
            InitializeComponent();
            panel.Controls.Clear();
            check.panel = panel;
            check.panel.Controls.Add(this);
            this.warehouse_itemTableAdapter.Fill(this.category_dbDataSet.warehouse_item);
            warehouse_itemBindingSource.Filter = $"warehouse_ID={id}";
        }
        private void item_categoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.warehouse_itemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.category_dbDataSet);
            MessageBox.Show("save success");

        }

    }
}
