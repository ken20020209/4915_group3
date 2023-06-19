
namespace ITP4915_group3_project.Restaurant
{
    partial class choose
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.restaurant_dbDataSet = new ITP4915_group3_project.restaurant_dbDataSet();
            this.restaurantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantTableAdapter = new ITP4915_group3_project.restaurant_dbDataSetTableAdapters.restaurantTableAdapter();
            this.tableAdapterManager = new ITP4915_group3_project.restaurant_dbDataSetTableAdapters.TableAdapterManager();
            this.restaurantKryptonDataGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.chooseRest = new Krypton.Toolkit.KryptonDataGridViewButtonColumn();
            this.restaurant_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.restaurant_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantKryptonDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // restaurant_dbDataSet
            // 
            this.restaurant_dbDataSet.DataSetName = "restaurant_dbDataSet";
            this.restaurant_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // restaurantBindingSource
            // 
            this.restaurantBindingSource.AllowNew = false;
            this.restaurantBindingSource.DataMember = "restaurant";
            this.restaurantBindingSource.DataSource = this.restaurant_dbDataSet;
            // 
            // restaurantTableAdapter
            // 
            this.restaurantTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.addressTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.delivery_requestTableAdapter = null;
            this.tableAdapterManager.item_categoryTableAdapter = null;
            this.tableAdapterManager.itemTableAdapter = null;
            this.tableAdapterManager.partner_brand_restaurantTableAdapter = null;
            this.tableAdapterManager.partner_brandTableAdapter = null;
            this.tableAdapterManager.purchasers_requestTableAdapter = null;
            this.tableAdapterManager.restaurant_stock_itemTableAdapter = null;
            this.tableAdapterManager.restaurantTableAdapter = this.restaurantTableAdapter;
            this.tableAdapterManager.statusTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ITP4915_group3_project.restaurant_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // restaurantKryptonDataGridView
            // 
            this.restaurantKryptonDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chooseRest,
            this.restaurant_ID,
            this.name,
            this.address_ID,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.restaurantKryptonDataGridView.DataSource = this.restaurantBindingSource;
            this.restaurantKryptonDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.restaurantKryptonDataGridView.Location = new System.Drawing.Point(0, 0);
            this.restaurantKryptonDataGridView.Name = "restaurantKryptonDataGridView";
            this.restaurantKryptonDataGridView.RowTemplate.Height = 24;
            this.restaurantKryptonDataGridView.Size = new System.Drawing.Size(552, 355);
            this.restaurantKryptonDataGridView.TabIndex = 1;
            this.restaurantKryptonDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.restaurantKryptonDataGridView_CellContentClick);
            // 
            // chooseRest
            // 
            this.chooseRest.HeaderText = "choose";
            this.chooseRest.Name = "chooseRest";
            this.chooseRest.Text = "choose";
            this.chooseRest.UseColumnTextForButtonValue = true;
            // 
            // restaurant_ID
            // 
            this.restaurant_ID.DataPropertyName = "restaurant_ID";
            this.restaurant_ID.HeaderText = "restaurant_ID";
            this.restaurant_ID.Name = "restaurant_ID";
            this.restaurant_ID.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // address_ID
            // 
            this.address_ID.DataPropertyName = "address_ID";
            this.address_ID.HeaderText = "address_ID";
            this.address_ID.Name = "address_ID";
            this.address_ID.ReadOnly = true;
            this.address_ID.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "type";
            this.dataGridViewTextBoxColumn4.HeaderText = "type";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "phone";
            this.dataGridViewTextBoxColumn5.HeaderText = "phone";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "manager_ID";
            this.dataGridViewTextBoxColumn6.HeaderText = "manager_ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // choose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 355);
            this.Controls.Add(this.restaurantKryptonDataGridView);
            this.Name = "choose";
            this.Text = "choose";
            this.Load += new System.EventHandler(this.choose_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restaurant_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantKryptonDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private restaurant_dbDataSet restaurant_dbDataSet;
        private System.Windows.Forms.BindingSource restaurantBindingSource;
        private restaurant_dbDataSetTableAdapters.restaurantTableAdapter restaurantTableAdapter;
        private restaurant_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Krypton.Toolkit.KryptonDataGridView restaurantKryptonDataGridView;
        private Krypton.Toolkit.KryptonDataGridViewButtonColumn chooseRest;
        private System.Windows.Forms.DataGridViewTextBoxColumn restaurant_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}