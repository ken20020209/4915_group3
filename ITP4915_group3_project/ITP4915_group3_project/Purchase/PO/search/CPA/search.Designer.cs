
namespace ITP4915_group3_project.Purchase.PO.search.CPA
{
    partial class search
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonDataGridViewSearchResult = new Krypton.Toolkit.KryptonDataGridView();
            this.detail = new Krypton.Toolkit.KryptonDataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchase_dbDataSet = new ITP4915_group3_project.purchase_dbDataSet();
            this.cpa_search_resultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cpa_search_resultTableAdapter = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.cpa_search_resultTableAdapter();
            this.tableAdapterManager = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewSearchResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpa_search_resultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonDataGridViewSearchResult
            // 
            this.kryptonDataGridViewSearchResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detail});
            this.kryptonDataGridViewSearchResult.DataSource = this.cpa_search_resultBindingSource;
            this.kryptonDataGridViewSearchResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDataGridViewSearchResult.Location = new System.Drawing.Point(0, 0);
            this.kryptonDataGridViewSearchResult.Name = "kryptonDataGridViewSearchResult";
            this.kryptonDataGridViewSearchResult.RowTemplate.Height = 24;
            this.kryptonDataGridViewSearchResult.Size = new System.Drawing.Size(600, 300);
            this.kryptonDataGridViewSearchResult.TabIndex = 0;
            this.kryptonDataGridViewSearchResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kryptonDataGridViewSearchResult_CellContentClick);
            // 
            // detail
            // 
            this.detail.HeaderText = "detail";
            this.detail.Name = "detail";
            this.detail.Text = "detail";
            this.detail.UseColumnTextForButtonValue = true;
            this.detail.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "header_ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "header_ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "create_date";
            this.dataGridViewTextBoxColumn5.HeaderText = "create_date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "suplier name";
            this.dataGridViewTextBoxColumn6.HeaderText = "suplier name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "header_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "header_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "create_date";
            this.dataGridViewTextBoxColumn2.HeaderText = "create_date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "suplier name";
            this.dataGridViewTextBoxColumn3.HeaderText = "suplier name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CPA_ID";
            this.dataGridViewTextBoxColumn7.HeaderText = "CPA_ID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "create_date";
            this.dataGridViewTextBoxColumn8.HeaderText = "create_date";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "effective_date";
            this.dataGridViewTextBoxColumn9.HeaderText = "effective_date";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "supplier_ID";
            this.dataGridViewTextBoxColumn10.HeaderText = "supplier_ID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "buyer_ID";
            this.dataGridViewTextBoxColumn11.HeaderText = "buyer_ID";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "terms";
            this.dataGridViewTextBoxColumn12.HeaderText = "terms";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "condition";
            this.dataGridViewTextBoxColumn13.HeaderText = "condition";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "item_ID";
            this.dataGridViewTextBoxColumn14.HeaderText = "item_ID";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "item_name";
            this.dataGridViewTextBoxColumn15.HeaderText = "item_name";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "size";
            this.dataGridViewTextBoxColumn16.HeaderText = "size";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // purchase_dbDataSet
            // 
            this.purchase_dbDataSet.DataSetName = "purchase_dbDataSet";
            this.purchase_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cpa_search_resultBindingSource
            // 
            this.cpa_search_resultBindingSource.AllowNew = false;
            this.cpa_search_resultBindingSource.DataMember = "cpa_search_result";
            this.cpa_search_resultBindingSource.DataSource = this.purchase_dbDataSet;
            // 
            // cpa_search_resultTableAdapter
            // 
            this.cpa_search_resultTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bpa_headerTableAdapter = null;
            this.tableAdapterManager.bpa_linesTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.cpaTableAdapter = null;
            this.tableAdapterManager.itemTableAdapter = null;
            this.tableAdapterManager.ppo_headerTableAdapter = null;
            this.tableAdapterManager.ppo_linesTableAdapter = null;
            this.tableAdapterManager.spo_headerTableAdapter = null;
            this.tableAdapterManager.spo_linesTableAdapter = null;
            this.tableAdapterManager.supplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ITP4915_group3_project.purchase_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonDataGridViewSearchResult);
            this.Name = "search";
            this.Size = new System.Drawing.Size(600, 300);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewSearchResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpa_search_resultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewSearchResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Krypton.Toolkit.KryptonDataGridViewButtonColumn detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private purchase_dbDataSet purchase_dbDataSet;
        private System.Windows.Forms.BindingSource cpa_search_resultBindingSource;
        private purchase_dbDataSetTableAdapters.cpa_search_resultTableAdapter cpa_search_resultTableAdapter;
        private purchase_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}
