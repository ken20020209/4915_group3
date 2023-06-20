using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.humanResources.user.search
{
    public partial class check : UserControl
    {
        public static Control panel;
        public check(Control panel)
        {
            InitializeComponent();
            panel.Controls.Clear();
            check.panel = panel;
            check.panel.Controls.Add(this);
            //load data
            this.userTableAdapter.Fill(this.humanResources_dbDataSet.user);
            kryptonLabelResult.Text = $"RESULT ({userBindingSource.Count})";


        }

        private void search()
        {
            string keyword = "'%" + kryptonTextBoxSearchBar.Text + "%'";
            userBindingSource.Filter = $" first_name like {keyword} or last_name like {keyword}";
            try
            {
                userBindingSource.Filter += $" or user_id = {int.Parse(kryptonTextBoxSearchBar.Text)}";
            }
            catch(Exception ex)
            {
                ex.ToString();
            }
            kryptonLabelResult.Text = $"RESULT ({userBindingSource.Count})";


        }
        private void userKryptonDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex != 0 || e.RowIndex == -1)
            {
                return;
            }
            new detail(this,(int)userKryptonDataGridView.Rows[e.RowIndex].Cells[1].Value);
        }

        private void kryptonTextBoxSearchBar_TextChanged(object sender, EventArgs e)
        {
            search();
        }
    }
}
