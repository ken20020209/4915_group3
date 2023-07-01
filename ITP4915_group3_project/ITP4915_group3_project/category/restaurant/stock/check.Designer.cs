
namespace ITP4915_group3_project.category.restaurant.stock
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
            this.kryptonButton10 = new Krypton.Toolkit.KryptonButton();
            this.restaurant_stock_itemKryptonDataGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.restaurant_stock_itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.category_dbDataSet = new ITP4915_group3_project.category_dbDataSet();
            this.item_categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_categoryTableAdapter = new ITP4915_group3_project.category_dbDataSetTableAdapters.item_categoryTableAdapter();
            this.tableAdapterManager = new ITP4915_group3_project.category_dbDataSetTableAdapters.TableAdapterManager();
            this.restaurant_stock_itemTableAdapter = new ITP4915_group3_project.category_dbDataSetTableAdapters.restaurant_stock_itemTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restaurant_stock_itemKryptonDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurant_stock_itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.category_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.kryptonButton10);
            this.kryptonPanel4.Controls.Add(this.restaurant_stock_itemKryptonDataGridView);
            this.kryptonPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel4.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(777, 474);
            this.kryptonPanel4.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPanel4.TabIndex = 52;
            // 
            // kryptonButton10
            // 
            this.kryptonButton10.CornerRoundingRadius = 25F;
            this.kryptonButton10.Location = new System.Drawing.Point(610, 42);
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
            this.kryptonButton10.TabIndex = 223;
            this.kryptonButton10.Values.Text = "Save";
            this.kryptonButton10.Click += new System.EventHandler(this.kryptonButton10_Click);
            // 
            // restaurant_stock_itemKryptonDataGridView
            // 
            this.restaurant_stock_itemKryptonDataGridView.DataSource = this.restaurant_stock_itemBindingSource;
            this.restaurant_stock_itemKryptonDataGridView.Location = new System.Drawing.Point(53, 176);
            this.restaurant_stock_itemKryptonDataGridView.Name = "restaurant_stock_itemKryptonDataGridView";
            this.restaurant_stock_itemKryptonDataGridView.RowTemplate.Height = 24;
            this.restaurant_stock_itemKryptonDataGridView.Size = new System.Drawing.Size(666, 185);
            this.restaurant_stock_itemKryptonDataGridView.TabIndex = 0;
            // 
            // restaurant_stock_itemBindingSource
            // 
            this.restaurant_stock_itemBindingSource.DataMember = "restaurant_stock_item";
            this.restaurant_stock_itemBindingSource.DataSource = this.category_dbDataSet;
            // 
            // category_dbDataSet
            // 
            this.category_dbDataSet.DataSetName = "category_dbDataSet";
            this.category_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // item_categoryBindingSource
            // 
            this.item_categoryBindingSource.DataMember = "item_category";
            this.item_categoryBindingSource.DataSource = this.category_dbDataSet;
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
            // item_categoryTableAdapter
            // 
            this.item_categoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.addressTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.item_categoryTableAdapter = this.item_categoryTableAdapter;
            this.tableAdapterManager.itemTableAdapter = null;
            this.tableAdapterManager.partner_brand_restaurantTableAdapter = null;
            this.tableAdapterManager.partner_brandTableAdapter = null;
            this.tableAdapterManager.restaurant_stock_itemTableAdapter = null;
            this.tableAdapterManager.restaurantTableAdapter = null;
            this.tableAdapterManager.supplier_contact_personTableAdapter = null;
            this.tableAdapterManager.supplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ITP4915_group3_project.category_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.warehouse_itemTableAdapter = null;
            this.tableAdapterManager.warehouseTableAdapter = null;
            // 
            // restaurant_stock_itemTableAdapter
            // 
            this.restaurant_stock_itemTableAdapter.ClearBeforeFill = true;
            // 
            // check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel4);
            this.Name = "check";
            this.Size = new System.Drawing.Size(777, 474);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.restaurant_stock_itemKryptonDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurant_stock_itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.category_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_categoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private category_dbDataSet category_dbDataSet;
        private System.Windows.Forms.BindingSource item_categoryBindingSource;
        private category_dbDataSetTableAdapters.item_categoryTableAdapter item_categoryTableAdapter;
        private category_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Krypton.Toolkit.KryptonDataGridView restaurant_stock_itemKryptonDataGridView;
        private System.Windows.Forms.BindingSource restaurant_stock_itemBindingSource;
        private category_dbDataSetTableAdapters.restaurant_stock_itemTableAdapter restaurant_stock_itemTableAdapter;
        private Krypton.Toolkit.KryptonButton kryptonButton10;
    }
}
