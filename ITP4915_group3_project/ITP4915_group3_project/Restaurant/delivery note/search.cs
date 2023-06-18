using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.Restaurant.delivery_note
{
    public partial class search : UserControl
    {
        public static Control panelContent1;

        public string filterAddress;
        public search(Control panelContent)
        {
            InitializeComponent();

            search.panelContent1 = panelContent;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(this);

            this.dataTable_deliverynote_searchTableAdapter.Fill(this.restaurant_dbDataSet.DataTable_deliverynote_search);

            filterAddress = $"receive_address_ID={restaurant.address_ID}";

            dataTable_deliverynote_searchBindingSource.Filter = filterAddress + $" and status_ID=2000";

            kryptonLabelWaitForSign.Text = dataTable_deliverynote_searchBindingSource.Count.ToString();

            

        }

        private void kryptonComboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            int filterStatus = 2000;
            if(kryptonComboBoxFilter.Text== "wait for sign")
            {
                filterStatus = 2000;
            }
            else
            {
                filterStatus = 2100;
            }
            dataTable_deliverynote_searchBindingSource.Filter = filterAddress+$" and status_ID={filterStatus}";
            Console.WriteLine(filterAddress + $" and status_ID={filterStatus}");
        }

        private void dataTable_deliverynote_searchKryptonDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex==-1 || e.ColumnIndex!=0)
            {
                return;
            }
            new check(this, (int)dataTable_deliverynote_searchKryptonDataGridView.Rows[e.RowIndex].Cells[2].Value);
        }
    }
}
