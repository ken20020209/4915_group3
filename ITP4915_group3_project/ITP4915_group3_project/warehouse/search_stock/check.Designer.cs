
namespace ITP4915_group3_project.warehouse.search_stock
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
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonDataGridView1 = new Krypton.Toolkit.KryptonDataGridView();
            this.dataTable_warehouse_stock_searchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouse_dbDataSet = new ITP4915_group3_project.warehouse_dbDataSet();
            this.kryptonGroup1 = new Krypton.Toolkit.KryptonGroup();
            this.kryptonLabel24 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelLowStock = new Krypton.Toolkit.KryptonLabel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.kryptonGroup2 = new Krypton.Toolkit.KryptonGroup();
            this.kryptonLabel22 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelTotalItem = new Krypton.Toolkit.KryptonLabel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.kryptonComboBox1 = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonTextBoxSearch = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonGroup3 = new Krypton.Toolkit.KryptonGroup();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.dataTable_warehouse_stock_searchTableAdapter = new ITP4915_group3_project.warehouse_dbDataSetTableAdapters.DataTable_warehouse_stock_searchTableAdapter();
            this.tableAdapterManager = new ITP4915_group3_project.warehouse_dbDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable_warehouse_stock_searchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2.Panel)).BeginInit();
            this.kryptonGroup2.Panel.SuspendLayout();
            this.kryptonGroup2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3.Panel)).BeginInit();
            this.kryptonGroup3.Panel.SuspendLayout();
            this.kryptonGroup3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonDataGridView1);
            this.kryptonPanel1.Controls.Add(this.kryptonGroup1);
            this.kryptonPanel1.Controls.Add(this.kryptonGroup2);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel1.Controls.Add(this.label2);
            this.kryptonPanel1.Controls.Add(this.kryptonComboBox1);
            this.kryptonPanel1.Controls.Add(this.kryptonTextBoxSearch);
            this.kryptonPanel1.Controls.Add(this.kryptonGroup3);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(695, 431);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPanel1.TabIndex = 1;
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.DataSource = this.dataTable_warehouse_stock_searchBindingSource;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(62, 238);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.ReadOnly = true;
            this.kryptonDataGridView1.RowTemplate.Height = 24;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(545, 167);
            this.kryptonDataGridView1.TabIndex = 77;
            // 
            // dataTable_warehouse_stock_searchBindingSource
            // 
            this.dataTable_warehouse_stock_searchBindingSource.DataMember = "DataTable_warehouse_stock_search";
            this.dataTable_warehouse_stock_searchBindingSource.DataSource = this.warehouse_dbDataSet;
            // 
            // warehouse_dbDataSet
            // 
            this.warehouse_dbDataSet.DataSetName = "warehouse_dbDataSet";
            this.warehouse_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.Location = new System.Drawing.Point(58, 34);
            this.kryptonGroup1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonGroup1.Name = "kryptonGroup1";
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonLabel24);
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonLabelLowStock);
            this.kryptonGroup1.Panel.Controls.Add(this.pictureBox5);
            this.kryptonGroup1.Size = new System.Drawing.Size(147, 83);
            this.kryptonGroup1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(98)))), ((int)(((byte)(93)))));
            this.kryptonGroup1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(98)))), ((int)(((byte)(93)))));
            this.kryptonGroup1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroup1.StateCommon.Border.Rounding = 25F;
            this.kryptonGroup1.TabIndex = 70;
            // 
            // kryptonLabel24
            // 
            this.kryptonLabel24.Location = new System.Drawing.Point(52, 42);
            this.kryptonLabel24.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel24.Name = "kryptonLabel24";
            this.kryptonLabel24.Size = new System.Drawing.Size(84, 22);
            this.kryptonLabel24.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel24.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel24.TabIndex = 2;
            this.kryptonLabel24.Values.Text = "Low Stock";
            // 
            // kryptonLabelLowStock
            // 
            this.kryptonLabelLowStock.Location = new System.Drawing.Point(78, 13);
            this.kryptonLabelLowStock.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabelLowStock.Name = "kryptonLabelLowStock";
            this.kryptonLabelLowStock.Size = new System.Drawing.Size(22, 26);
            this.kryptonLabelLowStock.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabelLowStock.StateNormal.ShortText.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelLowStock.TabIndex = 1;
            this.kryptonLabelLowStock.Values.Text = "2";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(98)))), ((int)(((byte)(93)))));
            this.pictureBox5.Image = global::ITP4915_group3_project.Properties.Resources.icons8_obsolete_stock_40;
            this.pictureBox5.Location = new System.Drawing.Point(2, 13);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(47, 47);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // kryptonGroup2
            // 
            this.kryptonGroup2.Location = new System.Drawing.Point(266, 34);
            this.kryptonGroup2.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonGroup2.Name = "kryptonGroup2";
            // 
            // kryptonGroup2.Panel
            // 
            this.kryptonGroup2.Panel.Controls.Add(this.kryptonLabel22);
            this.kryptonGroup2.Panel.Controls.Add(this.kryptonLabelTotalItem);
            this.kryptonGroup2.Panel.Controls.Add(this.pictureBox6);
            this.kryptonGroup2.Size = new System.Drawing.Size(147, 83);
            this.kryptonGroup2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(134)))), ((int)(((byte)(166)))));
            this.kryptonGroup2.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(134)))), ((int)(((byte)(166)))));
            this.kryptonGroup2.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroup2.StateCommon.Border.Rounding = 25F;
            this.kryptonGroup2.TabIndex = 71;
            // 
            // kryptonLabel22
            // 
            this.kryptonLabel22.Location = new System.Drawing.Point(53, 42);
            this.kryptonLabel22.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel22.Name = "kryptonLabel22";
            this.kryptonLabel22.Size = new System.Drawing.Size(81, 22);
            this.kryptonLabel22.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel22.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel22.TabIndex = 2;
            this.kryptonLabel22.Values.Text = "Total Item";
            // 
            // kryptonLabelTotalItem
            // 
            this.kryptonLabelTotalItem.Location = new System.Drawing.Point(77, 13);
            this.kryptonLabelTotalItem.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabelTotalItem.Name = "kryptonLabelTotalItem";
            this.kryptonLabelTotalItem.Size = new System.Drawing.Size(32, 26);
            this.kryptonLabelTotalItem.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabelTotalItem.StateNormal.ShortText.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelTotalItem.TabIndex = 1;
            this.kryptonLabelTotalItem.Values.Text = "53";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(134)))), ((int)(((byte)(166)))));
            this.pictureBox6.Image = global::ITP4915_group3_project.Properties.Resources.icons8_sell_40;
            this.pictureBox6.Location = new System.Drawing.Point(2, 13);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(47, 47);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(37, 136);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(51, 27);
            this.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 76;
            this.kryptonLabel4.Values.Text = "Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.label2.Location = new System.Drawing.Point(469, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 75;
            this.label2.Text = "Filter:";
            // 
            // kryptonComboBox1
            // 
            this.kryptonComboBox1.CornerRoundingRadius = 25F;
            this.kryptonComboBox1.DropDownWidth = 153;
            this.kryptonComboBox1.IntegralHeight = false;
            this.kryptonComboBox1.Location = new System.Drawing.Point(516, 167);
            this.kryptonComboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonComboBox1.Name = "kryptonComboBox1";
            this.kryptonComboBox1.Size = new System.Drawing.Size(113, 37);
            this.kryptonComboBox1.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.kryptonComboBox1.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonComboBox1.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonComboBox1.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonComboBox1.StateCommon.ComboBox.Border.Rounding = 25F;
            this.kryptonComboBox1.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Gray;
            this.kryptonComboBox1.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonComboBox1.StateCommon.DropBack.Color1 = System.Drawing.Color.White;
            this.kryptonComboBox1.StateCommon.DropBack.Color2 = System.Drawing.Color.White;
            this.kryptonComboBox1.TabIndex = 74;
            this.kryptonComboBox1.Text = "Category";
            // 
            // kryptonTextBoxSearch
            // 
            this.kryptonTextBoxSearch.CueHint.CueHintText = "ID/name";
            this.kryptonTextBoxSearch.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.kryptonTextBoxSearch.Location = new System.Drawing.Point(58, 169);
            this.kryptonTextBoxSearch.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonTextBoxSearch.Name = "kryptonTextBoxSearch";
            this.kryptonTextBoxSearch.Size = new System.Drawing.Size(244, 34);
            this.kryptonTextBoxSearch.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.kryptonTextBoxSearch.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonTextBoxSearch.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonTextBoxSearch.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBoxSearch.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonTextBoxSearch.StateCommon.Border.Rounding = 25F;
            this.kryptonTextBoxSearch.StateCommon.Border.Width = 1;
            this.kryptonTextBoxSearch.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.kryptonTextBoxSearch.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBoxSearch.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.kryptonTextBoxSearch.TabIndex = 73;
            this.kryptonTextBoxSearch.Text = "Name";
            this.kryptonTextBoxSearch.TextChanged += new System.EventHandler(this.kryptonTextBoxSearch_TextChanged);
            // 
            // kryptonGroup3
            // 
            this.kryptonGroup3.Location = new System.Drawing.Point(482, 34);
            this.kryptonGroup3.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonGroup3.Name = "kryptonGroup3";
            // 
            // kryptonGroup3.Panel
            // 
            this.kryptonGroup3.Panel.Controls.Add(this.kryptonLabel5);
            this.kryptonGroup3.Panel.Controls.Add(this.kryptonLabel6);
            this.kryptonGroup3.Panel.Controls.Add(this.pictureBox7);
            this.kryptonGroup3.Size = new System.Drawing.Size(147, 83);
            this.kryptonGroup3.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(189)))), ((int)(((byte)(26)))));
            this.kryptonGroup3.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(189)))), ((int)(((byte)(26)))));
            this.kryptonGroup3.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroup3.StateCommon.Border.Rounding = 25F;
            this.kryptonGroup3.TabIndex = 72;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(64, 39);
            this.kryptonLabel5.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(52, 22);
            this.kryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 2;
            this.kryptonLabel5.Values.Text = "Brand";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(81, 13);
            this.kryptonLabel6.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(22, 26);
            this.kryptonLabel6.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel6.StateNormal.ShortText.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 1;
            this.kryptonLabel6.Values.Text = "3";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(189)))), ((int)(((byte)(26)))));
            this.pictureBox7.Image = global::ITP4915_group3_project.Properties.Resources.icons8_handshake_40;
            this.pictureBox7.Location = new System.Drawing.Point(2, 13);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(47, 47);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            // 
            // dataTable_warehouse_stock_searchTableAdapter
            // 
            this.dataTable_warehouse_stock_searchTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.delivery_requestTableAdapter = null;
            this.tableAdapterManager.item_categoryTableAdapter = null;
            this.tableAdapterManager.itemTableAdapter = null;
            this.tableAdapterManager.purchase_order_allTableAdapter = null;
            this.tableAdapterManager.statusTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ITP4915_group3_project.warehouse_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            this.tableAdapterManager.warehouse_itemTableAdapter = null;
            this.tableAdapterManager.warehousedispatchinstructionTableAdapter = null;
            this.tableAdapterManager.warehouseTableAdapter = null;
            // 
            // check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "check";
            this.Size = new System.Drawing.Size(695, 431);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable_warehouse_stock_searchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            this.kryptonGroup1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2.Panel)).EndInit();
            this.kryptonGroup2.Panel.ResumeLayout(false);
            this.kryptonGroup2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2)).EndInit();
            this.kryptonGroup2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3.Panel)).EndInit();
            this.kryptonGroup3.Panel.ResumeLayout(false);
            this.kryptonGroup3.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3)).EndInit();
            this.kryptonGroup3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel24;
        private Krypton.Toolkit.KryptonLabel kryptonLabelLowStock;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Krypton.Toolkit.KryptonGroup kryptonGroup2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel22;
        private Krypton.Toolkit.KryptonLabel kryptonLabelTotalItem;
        private System.Windows.Forms.PictureBox pictureBox6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private System.Windows.Forms.Label label2;
        private Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBoxSearch;
        private Krypton.Toolkit.KryptonGroup kryptonGroup3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private System.Windows.Forms.BindingSource dataTable_warehouse_stock_searchBindingSource;
        private warehouse_dbDataSet warehouse_dbDataSet;
        private warehouse_dbDataSetTableAdapters.DataTable_warehouse_stock_searchTableAdapter dataTable_warehouse_stock_searchTableAdapter;
        private warehouse_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}
