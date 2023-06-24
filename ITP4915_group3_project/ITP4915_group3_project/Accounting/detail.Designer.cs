
namespace ITP4915_group3_project.Accounting
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
            this.kryptonGroupBox2 = new Krypton.Toolkit.KryptonGroupBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.delivery_requestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accounting_dbDataSet = new ITP4915_group3_project.accounting_dbDataSet();
            this.item_IDTextBox = new System.Windows.Forms.TextBox();
            this.kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            this.kryptonTextBox2 = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kryptonTextBox8 = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel24 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel11 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBox3 = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonButton11 = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.invoiceTableAdapter = new ITP4915_group3_project.accounting_dbDataSetTableAdapters.invoiceTableAdapter();
            this.tableAdapterManager = new ITP4915_group3_project.accounting_dbDataSetTableAdapters.TableAdapterManager();
            this.delivery_requestTableAdapter = new ITP4915_group3_project.accounting_dbDataSetTableAdapters.delivery_requestTableAdapter();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemTableAdapter = new ITP4915_group3_project.accounting_dbDataSetTableAdapters.itemTableAdapter();
            this.item_nameTextBox = new System.Windows.Forms.TextBox();
            item_IDLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            item_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delivery_requestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounting_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // item_IDLabel
            // 
            item_IDLabel.AutoSize = true;
            item_IDLabel.Location = new System.Drawing.Point(48, 40);
            item_IDLabel.Name = "item_IDLabel";
            item_IDLabel.Size = new System.Drawing.Size(43, 12);
            item_IDLabel.TabIndex = 0;
            item_IDLabel.Text = "item ID:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(275, 41);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(46, 12);
            quantityLabel.TabIndex = 2;
            quantityLabel.Text = "quantity:";
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.AutoScroll = true;
            this.kryptonPanel4.Controls.Add(this.kryptonGroupBox2);
            this.kryptonPanel4.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPanel4.Controls.Add(this.kryptonButton11);
            this.kryptonPanel4.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel4.Controls.Add(this.label1);
            this.kryptonPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel4.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(827, 567);
            this.kryptonPanel4.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPanel4.TabIndex = 55;
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.Location = new System.Drawing.Point(41, 242);
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
            this.kryptonGroupBox2.Size = new System.Drawing.Size(535, 145);
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
            this.kryptonGroupBox2.TabIndex = 225;
            this.kryptonGroupBox2.Values.Heading = "ITEM";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.delivery_requestBindingSource, "quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(327, 38);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.ReadOnly = true;
            this.quantityTextBox.Size = new System.Drawing.Size(100, 22);
            this.quantityTextBox.TabIndex = 3;
            // 
            // delivery_requestBindingSource
            // 
            this.delivery_requestBindingSource.DataMember = "delivery_request";
            this.delivery_requestBindingSource.DataSource = this.accounting_dbDataSet;
            // 
            // accounting_dbDataSet
            // 
            this.accounting_dbDataSet.DataSetName = "accounting_dbDataSet";
            this.accounting_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // item_IDTextBox
            // 
            this.item_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.delivery_requestBindingSource, "item_ID", true));
            this.item_IDTextBox.Location = new System.Drawing.Point(97, 37);
            this.item_IDTextBox.Name = "item_IDTextBox";
            this.item_IDTextBox.ReadOnly = true;
            this.item_IDTextBox.Size = new System.Drawing.Size(100, 22);
            this.item_IDTextBox.TabIndex = 1;
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(41, 84);
            this.kryptonGroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonTextBox2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel5);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonTextBox1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonTextBox8);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel24);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel11);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonTextBox3);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel6);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(535, 125);
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
            this.kryptonGroupBox1.TabIndex = 222;
            this.kryptonGroupBox1.Values.Heading = "GENERAL";
            // 
            // kryptonTextBox2
            // 
            this.kryptonTextBox2.Location = new System.Drawing.Point(295, 48);
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
            this.kryptonTextBox2.TabIndex = 223;
            this.kryptonTextBox2.Text = "01/02/2023";
            this.kryptonTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(197, 48);
            this.kryptonLabel5.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(94, 19);
            this.kryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 222;
            this.kryptonLabel5.Values.Text = "Shipping Date:";
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "arrival_date", true));
            this.kryptonTextBox1.Location = new System.Drawing.Point(295, 10);
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
            this.kryptonTextBox1.TabIndex = 219;
            this.kryptonTextBox1.Text = "01/02/2023";
            this.kryptonTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "invoice";
            this.invoiceBindingSource.DataSource = this.accounting_dbDataSet;
            // 
            // kryptonTextBox8
            // 
            this.kryptonTextBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "purchase_order_ID", true));
            this.kryptonTextBox8.Location = new System.Drawing.Point(73, 47);
            this.kryptonTextBox8.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonTextBox8.Name = "kryptonTextBox8";
            this.kryptonTextBox8.ReadOnly = true;
            this.kryptonTextBox8.Size = new System.Drawing.Size(100, 22);
            this.kryptonTextBox8.StateCommon.Back.Color1 = System.Drawing.Color.LightGray;
            this.kryptonTextBox8.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonTextBox8.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonTextBox8.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox8.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.kryptonTextBox8.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox8.TabIndex = 221;
            this.kryptonTextBox8.Text = "123456789";
            this.kryptonTextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonLabel24
            // 
            this.kryptonLabel24.Location = new System.Drawing.Point(41, 13);
            this.kryptonLabel24.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel24.Name = "kryptonLabel24";
            this.kryptonLabel24.Size = new System.Drawing.Size(29, 19);
            this.kryptonLabel24.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonLabel24.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel24.TabIndex = 216;
            this.kryptonLabel24.Values.Text = "ID:";
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(8, 48);
            this.kryptonLabel11.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(63, 19);
            this.kryptonLabel11.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonLabel11.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel11.TabIndex = 220;
            this.kryptonLabel11.Values.Text = "P.O. No.:";
            // 
            // kryptonTextBox3
            // 
            this.kryptonTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "Invoice_ID", true));
            this.kryptonTextBox3.Location = new System.Drawing.Point(73, 12);
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
            this.kryptonTextBox3.TabIndex = 217;
            this.kryptonTextBox3.Text = "123456789";
            this.kryptonTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(197, 13);
            this.kryptonLabel6.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(84, 19);
            this.kryptonLabel6.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 218;
            this.kryptonLabel6.Values.Text = "Arrival Date:";
            // 
            // kryptonButton11
            // 
            this.kryptonButton11.CornerRoundingRadius = 25F;
            this.kryptonButton11.Location = new System.Drawing.Point(515, 13);
            this.kryptonButton11.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonButton11.Name = "kryptonButton11";
            this.kryptonButton11.Size = new System.Drawing.Size(97, 30);
            this.kryptonButton11.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonButton11.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonButton11.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonButton11.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonButton11.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton11.StateCommon.Border.Rounding = 25F;
            this.kryptonButton11.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton11.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton11.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.kryptonButton11.TabIndex = 208;
            this.kryptonButton11.Values.Text = "Process";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(23, 47);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(50, 16);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.kryptonLabel4.TabIndex = 207;
            this.kryptonLabel4.Values.Text = "← Back";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 136;
            this.label1.Text = "Detail";
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.delivery_requestTableAdapter = this.delivery_requestTableAdapter;
            this.tableAdapterManager.invoiceTableAdapter = this.invoiceTableAdapter;
            this.tableAdapterManager.itemTableAdapter = null;
            this.tableAdapterManager.purchase_order_allTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ITP4915_group3_project.accounting_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // delivery_requestTableAdapter
            // 
            this.delivery_requestTableAdapter.ClearBeforeFill = true;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "item";
            this.itemBindingSource.DataSource = this.accounting_dbDataSet;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // item_nameLabel
            // 
            item_nameLabel.AutoSize = true;
            item_nameLabel.Location = new System.Drawing.Point(35, 83);
            item_nameLabel.Name = "item_nameLabel";
            item_nameLabel.Size = new System.Drawing.Size(56, 12);
            item_nameLabel.TabIndex = 4;
            item_nameLabel.Text = "item name:";
            // 
            // item_nameTextBox
            // 
            this.item_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemBindingSource, "item_name", true));
            this.item_nameTextBox.Location = new System.Drawing.Point(97, 80);
            this.item_nameTextBox.Name = "item_nameTextBox";
            this.item_nameTextBox.ReadOnly = true;
            this.item_nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.item_nameTextBox.TabIndex = 5;
            // 
            // detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel4);
            this.Name = "detail";
            this.Size = new System.Drawing.Size(827, 567);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            this.kryptonPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.delivery_requestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounting_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox8;
        private Krypton.Toolkit.KryptonLabel kryptonLabel24;
        private Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonButton kryptonButton11;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.BindingSource delivery_requestBindingSource;
        private accounting_dbDataSet accounting_dbDataSet;
        private System.Windows.Forms.TextBox item_IDTextBox;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private accounting_dbDataSetTableAdapters.invoiceTableAdapter invoiceTableAdapter;
        private accounting_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private accounting_dbDataSetTableAdapters.delivery_requestTableAdapter delivery_requestTableAdapter;
        private System.Windows.Forms.TextBox item_nameTextBox;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private accounting_dbDataSetTableAdapters.itemTableAdapter itemTableAdapter;
    }
}
