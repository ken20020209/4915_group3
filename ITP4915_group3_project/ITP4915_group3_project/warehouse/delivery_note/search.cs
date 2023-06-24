using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.warehouse.delivery_note
{
    public partial class search : UserControl
    {
        public Control panel;
        public int request_ID;
        
        public search(Control panel)
        {
            InitializeComponent();
            this.panel = panel;
            panel.Controls.Clear();
            panel.Controls.Add(this);
            searchNote();
        }

        private void searchNote()
        {
            //request_ID = int.Parse(kryptonTextBox16.Text);
            this.delivery_requestTableAdapter.Fill(this.warehouse_dbDataSet.delivery_request);
        }
    }
}
