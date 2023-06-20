
namespace ITP4915_group3_project.category.supplier.search
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
            this.kryptonTextBox16 = new Krypton.Toolkit.KryptonTextBox();
            this.category_dbDataSet = new ITP4915_group3_project.category_dbDataSet();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierTableAdapter = new ITP4915_group3_project.category_dbDataSetTableAdapters.supplierTableAdapter();
            this.tableAdapterManager = new ITP4915_group3_project.category_dbDataSetTableAdapters.TableAdapterManager();
            this.supplierKryptonDataGridView = new Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.category_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierKryptonDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.supplierKryptonDataGridView);
            this.kryptonPanel4.Controls.Add(this.kryptonTextBox16);
            this.kryptonPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel4.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(808, 466);
            this.kryptonPanel4.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPanel4.StateCommon.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPanel4.TabIndex = 56;
            // 
            // kryptonTextBox16
            // 
            this.kryptonTextBox16.Location = new System.Drawing.Point(25, 27);
            this.kryptonTextBox16.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonTextBox16.Name = "kryptonTextBox16";
            this.kryptonTextBox16.Size = new System.Drawing.Size(244, 34);
            this.kryptonTextBox16.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.kryptonTextBox16.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonTextBox16.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonTextBox16.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox16.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonTextBox16.StateCommon.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonTextBox16.StateCommon.Border.Rounding = 25F;
            this.kryptonTextBox16.StateCommon.Border.Width = 1;
            this.kryptonTextBox16.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.kryptonTextBox16.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox16.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.kryptonTextBox16.TabIndex = 54;
            this.kryptonTextBox16.Text = "ID/Name                                               🔍 ";
            // 
            // category_dbDataSet
            // 
            this.category_dbDataSet.DataSetName = "category_dbDataSet";
            this.category_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "supplier";
            this.supplierBindingSource.DataSource = this.category_dbDataSet;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.item_categoryTableAdapter = null;
            this.tableAdapterManager.itemTableAdapter = null;
            this.tableAdapterManager.partner_brand_restaurantTableAdapter = null;
            this.tableAdapterManager.partner_brandTableAdapter = null;
            this.tableAdapterManager.supplier_contact_personTableAdapter = null;
            this.tableAdapterManager.supplierTableAdapter = this.supplierTableAdapter;
            this.tableAdapterManager.UpdateOrder = ITP4915_group3_project.category_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // supplierKryptonDataGridView
            // 
            this.supplierKryptonDataGridView.DataSource = this.supplierBindingSource;
            this.supplierKryptonDataGridView.Location = new System.Drawing.Point(25, 128);
            this.supplierKryptonDataGridView.Name = "supplierKryptonDataGridView";
            this.supplierKryptonDataGridView.RowTemplate.Height = 24;
            this.supplierKryptonDataGridView.Size = new System.Drawing.Size(743, 220);
            this.supplierKryptonDataGridView.TabIndex = 54;
            // 
            // check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel4);
            this.Name = "check";
            this.Size = new System.Drawing.Size(808, 466);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            this.kryptonPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.category_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierKryptonDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox16;
        private category_dbDataSet category_dbDataSet;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private category_dbDataSetTableAdapters.supplierTableAdapter supplierTableAdapter;
        private category_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Krypton.Toolkit.KryptonDataGridView supplierKryptonDataGridView;
    }
}
