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
    public partial class create : UserControl
    {
        Control panelContent;
        public create(Control panel)
        {
            InitializeComponent();
            panelContent = panel;
            panelContent.Controls.Add(this);
            this.BringToFront();

            this.delivery_requestTableAdapter.Fill(this.delivery_dbDataSet.delivery_request);
            this.delivery_request_handlerTableAdapter.Fill(this.delivery_dbDataSet.delivery_request_handler);

            //create new record
            this.delivery_requestBindingSource.AddNew();
            this.delivery_requestBindingSource.MoveLast();

            this.delivery_request_handlerBindingSource.AllowNew = false;

            create_dateDateTimePicker.Value = DateTime.Now;
            delivery_dateDateTimePicker.Value = DateTime.Now;
            iDTextBox.Text = warehouse.user_name;

            delivery_address_IDTextBox.Text = "3";
            status_IDTextBox.Text = "3100";
        }

        private void kryptonButton7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.delivery_requestBindingSource.EndEdit();
            this.delivery_request_handlerBindingSource.EndEdit();

            this.delivery_requestTableAdapter.Update(this.delivery_dbDataSet.delivery_request);
            this.delivery_request_handlerTableAdapter.Update(this.delivery_dbDataSet.delivery_request_handler);

            //this.delivery_requestBindingSource.AddNew();
            //this.delivery_requestBindingSource.MoveLast();
            MessageBox.Show("create success");
      
        }
    }
}
