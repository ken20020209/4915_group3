
namespace ITP4915_group3_project.category.warehouse.stock
{
    partial class check
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonPanel4 = new Krypton.Toolkit.KryptonPanel();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category_dbDataSet = new ITP4915_group3_project.category_dbDataSet();
            this.warehouse_itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouse_itemTableAdapter = new ITP4915_group3_project.category_dbDataSetTableAdapters.warehouse_itemTableAdapter();
            this.tableAdapterManager = new ITP4915_group3_project.category_dbDataSetTableAdapters.TableAdapterManager();
            this.warehouse_itemKryptonDataGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.kryptonButton10 = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.category_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse_itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse_itemKryptonDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.kryptonButton10);
            this.kryptonPanel4.Controls.Add(this.warehouse_itemKryptonDataGridView);
            this.kryptonPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel4.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(777, 478);
            this.kryptonPanel4.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPanel4.TabIndex = 52;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "category_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "category_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "category_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "category_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn3.HeaderText = "description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // category_dbDataSet
            // 
            this.category_dbDataSet.DataSetName = "category_dbDataSet";
            this.category_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // warehouse_itemBindingSource
            // 
            this.warehouse_itemBindingSource.DataMember = "warehouse_item";
            this.warehouse_itemBindingSource.DataSource = this.category_dbDataSet;
            // 
            // warehouse_itemTableAdapter
            // 
            this.warehouse_itemTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.addressTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.item_categoryTableAdapter = null;
            this.tableAdapterManager.itemTableAdapter = null;
            this.tableAdapterManager.partner_brand_restaurantTableAdapter = null;
            this.tableAdapterManager.partner_brandTableAdapter = null;
            this.tableAdapterManager.restaurant_stock_itemTableAdapter = null;
            this.tableAdapterManager.restaurantTableAdapter = null;
            this.tableAdapterManager.supplier_contact_personTableAdapter = null;
            this.tableAdapterManager.supplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ITP4915_group3_project.category_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.warehouse_itemTableAdapter = this.warehouse_itemTableAdapter;
            this.tableAdapterManager.warehouseTableAdapter = null;
            // 
            // warehouse_itemKryptonDataGridView
            // 
            this.warehouse_itemKryptonDataGridView.DataSource = this.warehouse_itemBindingSource;
            this.warehouse_itemKryptonDataGridView.Location = new System.Drawing.Point(95, 189);
            this.warehouse_itemKryptonDataGridView.Name = "warehouse_itemKryptonDataGridView";
            this.warehouse_itemKryptonDataGridView.RowTemplate.Height = 24;
            this.warehouse_itemKryptonDataGridView.Size = new System.Drawing.Size(537, 199);
            this.warehouse_itemKryptonDataGridView.TabIndex = 0;
            // 
            // kryptonButton10
            // 
            this.kryptonButton10.CornerRoundingRadius = 25F;
            this.kryptonButton10.Location = new System.Drawing.Point(632, 47);
            this.kryptonButton10.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonButton10.Name = "kryptonButton10";
            this.kryptonButton10.Size = new System.Drawing.Size(97, 30);
            this.kryptonButton10.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(138)))), ((int)(((byte)(82)))));
            this.kryptonButton10.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(138)))), ((int)(((byte)(82)))));
            this.kryptonButton10.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(138)))), ((int)(((byte)(82)))));
            this.kryptonButton10.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(138)))), ((int)(((byte)(82)))));
            this.kryptonButton10.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton10.StateCommon.Border.Rounding = 25F;
            this.kryptonButton10.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton10.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton10.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.kryptonButton10.TabIndex = 224;
            this.kryptonButton10.Values.Text = "Save";
            this.kryptonButton10.Click += new System.EventHandler(this.item_categoryBindingNavigatorSaveItem_Click);
            // 
            // check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel4);
            this.Name = "check";
            this.Size = new System.Drawing.Size(777, 478);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.category_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse_itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse_itemKryptonDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private category_dbDataSet category_dbDataSet;
        private System.Windows.Forms.BindingSource warehouse_itemBindingSource;
        private category_dbDataSetTableAdapters.warehouse_itemTableAdapter warehouse_itemTableAdapter;
        private category_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Krypton.Toolkit.KryptonDataGridView warehouse_itemKryptonDataGridView;
        private Krypton.Toolkit.KryptonButton kryptonButton10;
    }
}
