using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.Restaurant.request_order.search
{
    public partial class check : UserControl
    {
        public static Control panelContent;
        string keyword = "";
        int status = 1000;
        public check(Control panelContent)
        {
            InitializeComponent();

            check.panelContent = panelContent;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(this);
            search();
        }



        private void kryptonButtonSearch_Click(object sender, EventArgs e)
        {
            search();
        }
        private void search()
        {

            keyword = "%" + kryptonTextBoxSearchKeyWord.Text + "%";
            purchaseRequestDetailTableAdapter.FillBy_search(this.restaurant_dbDataSet.purchaseRequestDetail, restaurant.restaurant_ID, keyword);

            purchaseRequestDetailBindingSource.Filter = $"status_ID={status}"; 

            int result = purchaseRequestDetailBindingSource.Count;
            kryptonLabelResult.Text = $"RESULT ({result})";
            
        }

        private void purchaseRequestDetailKryptonDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex==-1||e.ColumnIndex!=0)
            {
                return;
            }
            new detail(this, (int)purchaseRequestDetailKryptonDataGridView.Rows[e.RowIndex].Cells[1].Value);
        }

        private void kryptonCheckButtonWait_Click(object sender, EventArgs e)
        {
            status = 1000;
            search();
        }

        private void kryptonCheckButtonError_Click(object sender, EventArgs e)
        {
            status = 1100;
            search();
        }

        private void kryptonCheckButtonComplete_Click(object sender, EventArgs e)
        {
            status = 1200;
            search();
        }

    }
}
