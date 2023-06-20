
namespace ITP4915_group3_project.category.brand.search
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
            this.label3 = new System.Windows.Forms.Label();
            this.kryptonComboBox2 = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonTextBox16 = new Krypton.Toolkit.KryptonTextBox();
            this.category_dbDataSet = new ITP4915_group3_project.category_dbDataSet();
            this.partner_brandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partner_brandTableAdapter = new ITP4915_group3_project.category_dbDataSetTableAdapters.partner_brandTableAdapter();
            this.tableAdapterManager = new ITP4915_group3_project.category_dbDataSetTableAdapters.TableAdapterManager();
            this.partner_brandKryptonDataGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.detail = new Krypton.Toolkit.KryptonDataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.category_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partner_brandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partner_brandKryptonDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.partner_brandKryptonDataGridView);
            this.kryptonPanel4.Controls.Add(this.label3);
            this.kryptonPanel4.Controls.Add(this.kryptonComboBox2);
            this.kryptonPanel4.Controls.Add(this.kryptonTextBox16);
            this.kryptonPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel4.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(1009, 511);
            this.kryptonPanel4.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPanel4.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.label3.Location = new System.Drawing.Point(436, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 56;
            this.label3.Text = "Filter:";
            // 
            // kryptonComboBox2
            // 
            this.kryptonComboBox2.CornerRoundingRadius = 25F;
            this.kryptonComboBox2.DropDownWidth = 153;
            this.kryptonComboBox2.IntegralHeight = false;
            this.kryptonComboBox2.Location = new System.Drawing.Point(483, 25);
            this.kryptonComboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonComboBox2.Name = "kryptonComboBox2";
            this.kryptonComboBox2.Size = new System.Drawing.Size(113, 37);
            this.kryptonComboBox2.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.kryptonComboBox2.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonComboBox2.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonComboBox2.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonComboBox2.StateCommon.ComboBox.Border.Rounding = 25F;
            this.kryptonComboBox2.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Gray;
            this.kryptonComboBox2.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonComboBox2.StateCommon.DropBack.Color1 = System.Drawing.Color.White;
            this.kryptonComboBox2.StateCommon.DropBack.Color2 = System.Drawing.Color.White;
            this.kryptonComboBox2.TabIndex = 55;
            this.kryptonComboBox2.Text = "type";
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
            this.kryptonTextBox16.StateCommon.Border.Rounding = 25F;
            this.kryptonTextBox16.StateCommon.Border.Width = 1;
            this.kryptonTextBox16.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.kryptonTextBox16.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox16.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.kryptonTextBox16.TabIndex = 54;
            this.kryptonTextBox16.Text = "ID                                                         🔍 ";
            // 
            // category_dbDataSet
            // 
            this.category_dbDataSet.DataSetName = "category_dbDataSet";
            this.category_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partner_brandBindingSource
            // 
            this.partner_brandBindingSource.DataMember = "partner_brand";
            this.partner_brandBindingSource.DataSource = this.category_dbDataSet;
            // 
            // partner_brandTableAdapter
            // 
            this.partner_brandTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.item_categoryTableAdapter = null;
            this.tableAdapterManager.itemTableAdapter = null;
            this.tableAdapterManager.partner_brand_restaurantTableAdapter = null;
            this.tableAdapterManager.partner_brandTableAdapter = this.partner_brandTableAdapter;
            this.tableAdapterManager.UpdateOrder = ITP4915_group3_project.category_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // partner_brandKryptonDataGridView
            // 
            this.partner_brandKryptonDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detail,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.partner_brandKryptonDataGridView.DataSource = this.partner_brandBindingSource;
            this.partner_brandKryptonDataGridView.Location = new System.Drawing.Point(25, 119);
            this.partner_brandKryptonDataGridView.Name = "partner_brandKryptonDataGridView";
            this.partner_brandKryptonDataGridView.RowTemplate.Height = 24;
            this.partner_brandKryptonDataGridView.Size = new System.Drawing.Size(548, 220);
            this.partner_brandKryptonDataGridView.TabIndex = 56;
            // 
            // detail
            // 
            this.detail.HeaderText = "detail";
            this.detail.Name = "detail";
            this.detail.Text = "detail";
            this.detail.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "partner_brand_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "partner_brand_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "type";
            this.dataGridViewTextBoxColumn3.HeaderText = "type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "remarks";
            this.dataGridViewTextBoxColumn4.HeaderText = "remarks";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel4);
            this.Name = "check";
            this.Size = new System.Drawing.Size(1009, 511);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            this.kryptonPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.category_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partner_brandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partner_brandKryptonDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private System.Windows.Forms.Label label3;
        private Krypton.Toolkit.KryptonComboBox kryptonComboBox2;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox16;
        private category_dbDataSet category_dbDataSet;
        private System.Windows.Forms.BindingSource partner_brandBindingSource;
        private category_dbDataSetTableAdapters.partner_brandTableAdapter partner_brandTableAdapter;
        private category_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Krypton.Toolkit.KryptonDataGridView partner_brandKryptonDataGridView;
        private Krypton.Toolkit.KryptonDataGridViewButtonColumn detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
