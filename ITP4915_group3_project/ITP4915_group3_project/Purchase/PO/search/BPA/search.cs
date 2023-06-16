using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.Purchase.PO.search.BPA
{
    public partial class search : UserControl
    {
        public check panelContent;
        public search(check panelContent,string keyword)
        {
            InitializeComponent();
            keyword = "%" + keyword + "%";
            this.panelContent = panelContent;
            panelContent.Controls.Find("kryptonPanelSearchResult", true)[0].Controls.Clear();
            panelContent.Controls.Find("kryptonPanelSearchResult", true)[0].Controls.Add(this);

            this.bpa_search_resultTableAdapter.Fill(this.purchase_dbDataSet.bpa_search_result, keyword);

        }

        private void kryptonDataGridViewSearchResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex!=0 || e.RowIndex==-1)
            {
                return;
            }
            else
            {
                int header_ID = (int)kryptonDataGridViewSearchResult.Rows[e.RowIndex].Cells[1].Value;
                new deatil(panelContent,header_ID);
            }
        }
    }
}
