﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.Purchase.PO.search.CPA
{
    public partial class search : UserControl
    {
        public search(Control panel,string keyword)
        {
            InitializeComponent();
            //wizard search
            keyword = "%" + keyword + "%";
            panel.Controls.Clear();
            panel.Controls.Add(this);

            this.cpa_search_resultTableAdapter.Fill(this.purchase_dbDataSet.cpa_search_result, keyword);


        }

        private void kryptonDataGridViewSearchResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex!=0 || e.RowIndex==-1)
            {
                return;
            }
            else
            {

            }
        }

       
    }
}
