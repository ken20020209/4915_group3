using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.category.restaurant.stock
{
    public partial class check : UserControl
    {
        public static Control panel;

        public check(Control panel,int id)
        {
            InitializeComponent();
            panel.Controls.Clear();
            check.panel = panel;
            check.panel.Controls.Add(this);
            this.restaurant_stock_itemTableAdapter.Fill(this.category_dbDataSet.restaurant_stock_item);
            this.restaurant_stock_itemBindingSource.Filter = $"restaurant_ID={id}";
            
        }



        private void kryptonButton10_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.item_categoryBindingSource.EndEdit();
            this.restaurant_stock_itemTableAdapter.Update(this.category_dbDataSet.restaurant_stock_item);
            this.tableAdapterManager.UpdateAll(this.category_dbDataSet);

            MessageBox.Show("save success");
        }

    }
}
