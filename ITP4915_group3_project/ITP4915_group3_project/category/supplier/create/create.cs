using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915_group3_project.category.supplier.create
{
    public partial class create : UserControl
    {
        private Control panelContent;
        public create(Control panelContent)
        {
            InitializeComponent();
            this.panelContent = panelContent;

            panelContent.Controls.Add(this);
            this.BringToFront();


            this.supplierTableAdapter.Fill(this.category_dbDataSet.supplier);
/*            this.addressTableAdapter.Fill(this.category_dbDataSet.address);
            this.supplier_contact_personTableAdapter.Fill(this.category_dbDataSet.supplier_contact_person);*/

            supplierBindingSource.AddNew();
            supplierBindingSource.MoveLast();

            address_IDKryptonTextBox.Text = "1";
            contact_person_IDKryptonTextBox.Text = "1";
        }
        private void kryptonButtonConfirm_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.supplierBindingSource.EndEdit();
            try
            {
                this.tableAdapterManager.UpdateAll(this.category_dbDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("create success");
            supplierBindingSource.AddNew();
            supplierBindingSource.MoveLast();

            address_IDKryptonTextBox.Text = "1";
            contact_person_IDKryptonTextBox.Text = "1";
        }
    }
}
