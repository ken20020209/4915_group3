
namespace ITP4915_group3_project.Purchase.PO.search.BPA
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
            this.purchase_dbDataSet = new ITP4915_group3_project.purchase_dbDataSet();
            this.bpa_search_resultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bpa_search_resultTableAdapter = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.bpa_search_resultTableAdapter();
            this.tableAdapterManager = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewSearchResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpa_search_resultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonDataGridViewSearchResult
            // 
            this.kryptonDataGridViewSearchResult.DataSource = this.bpa_search_resultBindingSource;
            this.kryptonDataGridViewSearchResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDataGridViewSearchResult.Location = new System.Drawing.Point(0, 0);
            this.kryptonDataGridViewSearchResult.Name = "kryptonDataGridViewSearchResult";
            this.kryptonDataGridViewSearchResult.RowTemplate.Height = 24;
            this.kryptonDataGridViewSearchResult.Size = new System.Drawing.Size(600, 300);
            this.kryptonDataGridViewSearchResult.TabIndex = 0;
            // 
            // purchase_dbDataSet
            // 
            this.purchase_dbDataSet.DataSetName = "purchase_dbDataSet";
            this.purchase_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bpa_search_resultBindingSource
            // 
            this.bpa_search_resultBindingSource.DataMember = "bpa_search_result";
            this.bpa_search_resultBindingSource.DataSource = this.purchase_dbDataSet;
            // 
            // bpa_search_resultTableAdapter
            // 
            this.bpa_search_resultTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.bpa_search_resultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewSearchResult;
        private purchase_dbDataSet purchase_dbDataSet;
        private System.Windows.Forms.BindingSource bpa_search_resultBindingSource;
        private purchase_dbDataSetTableAdapters.bpa_search_resultTableAdapter bpa_search_resultTableAdapter;
        private purchase_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}
