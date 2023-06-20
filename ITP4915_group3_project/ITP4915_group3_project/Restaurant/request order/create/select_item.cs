using System;
using System.Windows.Forms;

namespace ITP4915_group3_project.Restaurant.request_order.create
{
    public partial class select_item : UserControl
    {
        public requestOrder newOrder;
        public static Control panelContent;
        public string keyword="";
        public select_item(Control panelContent)
        {
            InitializeComponent();

            select_item.panelContent = panelContent;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(this);

            this.newOrder = new requestOrder(restaurant.restaurant_ID, restaurant.restaurant_Name, General.login.Login.user_ID, General.login.Login.realName);
            search();

        }
        private void search()
        {
            keyword = "%" + kryptonTextBoxSearch.Text + "%";
            this.dataTable_restaurant_stock_searchTableAdapter.Fill(this.restaurant_dbDataSet.DataTable_restaurant_stock_search, keyword);
            dataTable_restaurant_stock_searchBindingSource.Filter = $"restaurant_ID={newOrder.restaurant_ID}";
            if(kryptonComboBoxFilter.Text== "low stock")
            {
                dataTable_restaurant_stock_searchBindingSource.Filter += $" and qty<expected_inventory";
            }

        }

        private void kryptonButtonCountinue_Click(object sender, EventArgs e)
        {
            if(kryptonDataGridViewSelected.Rows.Count==0)
            {
                MessageBox.Show("please select item");
                return;
            }
            foreach (DataGridViewRow row in kryptonDataGridViewSelected.Rows)
            {
                if(row.Cells[1].Value.ToString()=="0")
                {
                    MessageBox.Show("some item order 0 qty");
                    return;
                }
            }
            foreach (DataGridViewRow row in kryptonDataGridViewSelected.Rows)
            { 
                newOrder.item_ID.Add(int.Parse(row.Cells["realID"].Value.ToString()));
                newOrder.item_name.Add(row.Cells[3].Value.ToString());
                newOrder.item_qty.Add(int.Parse(row.Cells[1].Value.ToString()));
                newOrder.vID.Add(row.Cells[2].Value.ToString());
                newOrder.size.Add(row.Cells[4].Value.ToString());
            }
           
            new check_order(this, newOrder);
        }

        private void kryptonTextBox2_TextChanged(object sender, EventArgs e)
        {
            search();

        }

        private void kryptonDataGridViewSelected_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex==-1 || e.ColumnIndex!=0)
            {
                return;
            }
            kryptonDataGridViewSelected.Rows.RemoveAt(e.RowIndex);
        }

        private void dataTable_restaurant_stock_searchKryptonDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex != 0)
            {
                return;
            }
            int qty = 0;
            string vID = dataTable_restaurant_stock_searchKryptonDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
           
            int itemID= (int)dataTable_restaurant_stock_searchKryptonDataGridView.Rows[e.RowIndex].Cells[6].Value;
            String itemName = dataTable_restaurant_stock_searchKryptonDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            String size = dataTable_restaurant_stock_searchKryptonDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();

            kryptonDataGridViewSelected.Rows.Insert(0,null, qty, vID, itemName, size, itemID);
        }

        private void kryptonComboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            search();
        }
    }
}
