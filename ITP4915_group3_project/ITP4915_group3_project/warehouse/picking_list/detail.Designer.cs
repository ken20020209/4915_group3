
namespace ITP4915_group3_project.warehouse.picking_list
{
    partial class detail
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
            System.Windows.Forms.Label item_IDLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label item_nameLabel;
            this.kryptonPanel4 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonButton8 = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonGroupBox2 = new Krypton.Toolkit.KryptonGroupBox();
            this.item_nameTextBox = new System.Windows.Forms.TextBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouse_dbDataSet = new ITP4915_group3_project.warehouse_dbDataSet();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.delivery_requestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.item_IDTextBox = new System.Windows.Forms.TextBox();
            this.kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            this.kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBox2 = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBox3 = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.delivery_requestTableAdapter = new ITP4915_group3_project.warehouse_dbDataSetTableAdapters.delivery_requestTableAdapter();
            this.tableAdapterManager = new ITP4915_group3_project.warehouse_dbDataSetTableAdapters.TableAdapterManager();
            this.itemTableAdapter = new ITP4915_group3_project.warehouse_dbDataSetTableAdapters.itemTableAdapter();
            item_IDLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            item_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delivery_requestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // item_IDLabel
            // 
            item_IDLabel.AutoSize = true;
            item_IDLabel.Location = new System.Drawing.Point(38, 31);
            item_IDLabel.Name = "item_IDLabel";
            item_IDLabel.Size = new System.Drawing.Size(43, 12);
            item_IDLabel.TabIndex = 0;
            item_IDLabel.Text = "item ID:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(261, 28);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(46, 12);
            quantityLabel.TabIndex = 2;
            quantityLabel.Text = "quantity:";
            // 
            // item_nameLabel
            // 
            item_nameLabel.AutoSize = true;
            item_nameLabel.Location = new System.Drawing.Point(25, 72);
            item_nameLabel.Name = "item_nameLabel";
            item_nameLabel.Size = new System.Drawing.Size(56, 12);
            item_nameLabel.TabIndex = 4;
            item_nameLabel.Text = "item name:";
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.AutoScroll = true;
            this.kryptonPanel4.Controls.Add(this.kryptonButton8);
            this.kryptonPanel4.Controls.Add(this.kryptonLabel7);
            this.kryptonPanel4.Controls.Add(this.kryptonGroupBox2);
            this.kryptonPanel4.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPanel4.Controls.Add(this.label1);
            this.kryptonPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel4.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(827, 549);
            this.kryptonPanel4.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPanel4.TabIndex = 9;
            // 
            // kryptonButton8
            // 
            this.kryptonButton8.CornerRoundingRadius = 25F;
            this.kryptonButton8.Location = new System.Drawing.Point(675, 29);
            this.kryptonButton8.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonButton8.Name = "kryptonButton8";
            this.kryptonButton8.Size = new System.Drawing.Size(97, 30);
            this.kryptonButton8.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(138)))), ((int)(((byte)(82)))));
            this.kryptonButton8.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(138)))), ((int)(((byte)(82)))));
            this.kryptonButton8.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(138)))), ((int)(((byte)(82)))));
            this.kryptonButton8.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(138)))), ((int)(((byte)(82)))));
            this.kryptonButton8.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton8.StateCommon.Border.Rounding = 25F;
            this.kryptonButton8.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton8.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton8.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.kryptonButton8.TabIndex = 224;
            this.kryptonButton8.Values.Text = "Finish";
            this.kryptonButton8.Click += new System.EventHandler(this.kryptonButton8_Click);
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(36, 53);
            this.kryptonLabel7.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(50, 16);
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.kryptonLabel7.TabIndex = 223;
            this.kryptonLabel7.Values.Text = "← Back";
            this.kryptonLabel7.Click += new System.EventHandler(this.kryptonLabel7_Click);
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.Location = new System.Drawing.Point(36, 246);
            this.kryptonGroupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.AutoScroll = true;
            this.kryptonGroupBox2.Panel.Controls.Add(item_nameLabel);
            this.kryptonGroupBox2.Panel.Controls.Add(this.item_nameTextBox);
            this.kryptonGroupBox2.Panel.Controls.Add(quantityLabel);
            this.kryptonGroupBox2.Panel.Controls.Add(this.quantityTextBox);
            this.kryptonGroupBox2.Panel.Controls.Add(item_IDLabel);
            this.kryptonGroupBox2.Panel.Controls.Add(this.item_IDTextBox);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(565, 136);
            this.kryptonGroupBox2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonGroupBox2.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonGroupBox2.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonGroupBox2.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox2.StateCommon.Border.Rounding = 12F;
            this.kryptonGroupBox2.StateCommon.Border.Width = 2;
            this.kryptonGroupBox2.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonGroupBox2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox2.TabIndex = 222;
            this.kryptonGroupBox2.Values.Heading = "ITEM";
            // 
            // item_nameTextBox
            // 
            this.item_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemBindingSource, "item_name", true));
            this.item_nameTextBox.Location = new System.Drawing.Point(87, 69);
            this.item_nameTextBox.Name = "item_nameTextBox";
            this.item_nameTextBox.ReadOnly = true;
            this.item_nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.item_nameTextBox.TabIndex = 5;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "item";
            this.itemBindingSource.DataSource = this.warehouse_dbDataSet;
            // 
            // warehouse_dbDataSet
            // 
            this.warehouse_dbDataSet.DataSetName = "warehouse_dbDataSet";
            this.warehouse_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.delivery_requestBindingSource, "quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(313, 25);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.ReadOnly = true;
            this.quantityTextBox.Size = new System.Drawing.Size(100, 22);
            this.quantityTextBox.TabIndex = 3;
            // 
            // delivery_requestBindingSource
            // 
            this.delivery_requestBindingSource.DataMember = "delivery_request";
            this.delivery_requestBindingSource.DataSource = this.warehouse_dbDataSet;
            // 
            // item_IDTextBox
            // 
            this.item_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.delivery_requestBindingSource, "item_ID", true));
            this.item_IDTextBox.Location = new System.Drawing.Point(87, 28);
            this.item_IDTextBox.Name = "item_IDTextBox";
            this.item_IDTextBox.ReadOnly = true;
            this.item_IDTextBox.Size = new System.Drawing.Size(100, 22);
            this.item_IDTextBox.TabIndex = 1;
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(36, 117);
            this.kryptonGroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonTextBox1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonTextBox2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonTextBox3);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel5);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel4);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel6);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(565, 111);
            this.kryptonGroupBox1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonGroupBox1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonGroupBox1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonGroupBox1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox1.StateCommon.Border.Rounding = 12F;
            this.kryptonGroupBox1.StateCommon.Border.Width = 2;
            this.kryptonGroupBox1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonGroupBox1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox1.TabIndex = 221;
            this.kryptonGroupBox1.Values.Heading = "GENERAL";
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.delivery_requestBindingSource, "delivery_request_ID", true));
            this.kryptonTextBox1.Location = new System.Drawing.Point(118, 7);
            this.kryptonTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.ReadOnly = true;
            this.kryptonTextBox1.Size = new System.Drawing.Size(100, 22);
            this.kryptonTextBox1.StateCommon.Back.Color1 = System.Drawing.Color.LightGray;
            this.kryptonTextBox1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonTextBox1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonTextBox1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox1.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.kryptonTextBox1.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox1.TabIndex = 209;
            this.kryptonTextBox1.Text = "0";
            this.kryptonTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonTextBox2
            // 
            this.kryptonTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.delivery_requestBindingSource, "delivery_date", true));
            this.kryptonTextBox2.Location = new System.Drawing.Point(369, 45);
            this.kryptonTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonTextBox2.Name = "kryptonTextBox2";
            this.kryptonTextBox2.ReadOnly = true;
            this.kryptonTextBox2.Size = new System.Drawing.Size(100, 22);
            this.kryptonTextBox2.StateCommon.Back.Color1 = System.Drawing.Color.LightGray;
            this.kryptonTextBox2.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonTextBox2.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonTextBox2.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox2.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.kryptonTextBox2.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox2.TabIndex = 208;
            this.kryptonTextBox2.Text = "00000000";
            this.kryptonTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonTextBox3
            // 
            this.kryptonTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.delivery_requestBindingSource, "create_date", true));
            this.kryptonTextBox3.Location = new System.Drawing.Point(369, 10);
            this.kryptonTextBox3.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonTextBox3.Name = "kryptonTextBox3";
            this.kryptonTextBox3.ReadOnly = true;
            this.kryptonTextBox3.Size = new System.Drawing.Size(100, 22);
            this.kryptonTextBox3.StateCommon.Back.Color1 = System.Drawing.Color.LightGray;
            this.kryptonTextBox3.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonTextBox3.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonTextBox3.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox3.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.kryptonTextBox3.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox3.TabIndex = 134;
            this.kryptonTextBox3.Text = "01/02/2023";
            this.kryptonTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(285, 10);
            this.kryptonLabel5.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(80, 19);
            this.kryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 130;
            this.kryptonLabel5.Values.Text = "Create Date:";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(298, 45);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(67, 19);
            this.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 129;
            this.kryptonLabel4.Values.Text = "Due Date:";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(15, 10);
            this.kryptonLabel6.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(99, 19);
            this.kryptonLabel6.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 128;
            this.kryptonLabel6.Values.Text = "Picking List ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 220;
            this.label1.Text = "Detail";
            // 
            // delivery_requestTableAdapter
            // 
            this.delivery_requestTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.delivery_request_handlerTableAdapter = null;
            this.tableAdapterManager.delivery_requestTableAdapter = this.delivery_requestTableAdapter;
            this.tableAdapterManager.item_categoryTableAdapter = null;
            this.tableAdapterManager.itemTableAdapter = this.itemTableAdapter;
            this.tableAdapterManager.purchase_order_allTableAdapter = null;
            this.tableAdapterManager.statusTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ITP4915_group3_project.warehouse_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            this.tableAdapterManager.warehouse_itemTableAdapter = null;
            this.tableAdapterManager.warehousedispatchinstructionTableAdapter = null;
            this.tableAdapterManager.warehouseTableAdapter = null;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel4);
            this.Name = "detail";
            this.Size = new System.Drawing.Size(827, 549);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            this.kryptonPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delivery_requestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private Krypton.Toolkit.KryptonButton kryptonButton8;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private System.Windows.Forms.Label label1;
        private warehouse_dbDataSet warehouse_dbDataSet;
        private System.Windows.Forms.BindingSource delivery_requestBindingSource;
        private warehouse_dbDataSetTableAdapters.delivery_requestTableAdapter delivery_requestTableAdapter;
        private warehouse_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox item_IDTextBox;
        private System.Windows.Forms.TextBox item_nameTextBox;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private warehouse_dbDataSetTableAdapters.itemTableAdapter itemTableAdapter;
    }
}
