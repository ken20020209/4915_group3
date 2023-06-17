using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.Purchase.request_order
{
    public partial class check : UserControl
    {
        public int status_ID = 1000;
        string keyWord = "";
        public static Control panelContent;
        public check(Control panelContent)
        {
            InitializeComponent();
            panelContent.Controls.Clear();
            panelContent.Controls.Add(this);

            check.panelContent = panelContent;
            //load request
            search();
            

            
        }
        
        private void purchasers_requestKryptonDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0 || e.RowIndex == -1)
            {
                return;
            }
            else
            {
                int header_ID = (int)purchasers_requestKryptonDataGridView.Rows[e.RowIndex].Cells[1].Value;
                new detail(this, header_ID);
            }
        }
        private void searchButton(object sender,EventArgs e)
        {
            
            status_ID = int.Parse(((Krypton.Toolkit.KryptonCheckButton)sender).Tag.ToString());
            if(status_ID==1200)
            {
                match.Visible = false;   
            }
            else
            {
                match.Visible = true;
            }
            keyWord = kryptonTextBoxSearchKeyWord.Text;
            search();


            
        }
        private void search()
        {
            keyWord = "%" + keyWord + "%";
            this.purchasers_requestTableAdapter.FillBy_Status(this.purchase_dbDataSet.purchasers_request,status_ID,keyWord);

        }

        private void kryptonButtonSearch_Click(object sender, EventArgs e)
        {
            keyWord= kryptonTextBoxSearchKeyWord.Text;
            search();
        }
    }
}
