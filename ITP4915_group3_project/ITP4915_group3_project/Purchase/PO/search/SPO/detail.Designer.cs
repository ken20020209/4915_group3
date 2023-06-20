
namespace ITP4915_group3_project.Purchase.PO.search.SPO
{
    partial class detail
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
            System.Windows.Forms.Label header_IDLabel;
            System.Windows.Forms.Label create_dateLabel;
            System.Windows.Forms.Label effective_dateLabel;
            System.Windows.Forms.Label supplier_IDLabel;
            System.Windows.Forms.Label buyer_IDLabel;
            System.Windows.Forms.Label expected_delivery_dateLabel;
            System.Windows.Forms.Label termsLabel;
            System.Windows.Forms.Label conditionLabel;
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.spo_linesKryptonDataGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.spo_linesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spo_headerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchase_dbDataSet = new ITP4915_group3_project.purchase_dbDataSet();
            this.create_dateKryptonDateTimePicker = new Krypton.Toolkit.KryptonDateTimePicker();
            this.effective_dateKryptonDateTimePicker = new Krypton.Toolkit.KryptonDateTimePicker();
            this.expected_delivery_dateKryptonDateTimePicker = new Krypton.Toolkit.KryptonDateTimePicker();
            this.termsKryptonTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.conditionKryptonTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonButtonSave = new Krypton.Toolkit.KryptonButton();
            this.spo_headerTableAdapter = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.spo_headerTableAdapter();
            this.tableAdapterManager = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.TableAdapterManager();
            this.spo_linesTableAdapter = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.spo_linesTableAdapter();
            this.kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            this.kryptonGroupBox2 = new Krypton.Toolkit.KryptonGroupBox();
            this.header_IDKryptonTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.supplier_IDKryptonTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.buyer_IDKryptonTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            header_IDLabel = new System.Windows.Forms.Label();
            create_dateLabel = new System.Windows.Forms.Label();
            effective_dateLabel = new System.Windows.Forms.Label();
            supplier_IDLabel = new System.Windows.Forms.Label();
            buyer_IDLabel = new System.Windows.Forms.Label();
            expected_delivery_dateLabel = new System.Windows.Forms.Label();
            termsLabel = new System.Windows.Forms.Label();
            conditionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spo_linesKryptonDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spo_linesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spo_headerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // header_IDLabel
            // 
            header_IDLabel.AutoSize = true;
            header_IDLabel.Location = new System.Drawing.Point(29, 38);
            header_IDLabel.Name = "header_IDLabel";
            header_IDLabel.Size = new System.Drawing.Size(54, 12);
            header_IDLabel.TabIndex = 59;
            header_IDLabel.Text = "header ID:";
            // 
            // create_dateLabel
            // 
            create_dateLabel.AutoSize = true;
            create_dateLabel.Location = new System.Drawing.Point(29, 65);
            create_dateLabel.Name = "create_dateLabel";
            create_dateLabel.Size = new System.Drawing.Size(57, 12);
            create_dateLabel.TabIndex = 61;
            create_dateLabel.Text = "create date:";
            // 
            // effective_dateLabel
            // 
            effective_dateLabel.AutoSize = true;
            effective_dateLabel.Location = new System.Drawing.Point(29, 92);
            effective_dateLabel.Name = "effective_dateLabel";
            effective_dateLabel.Size = new System.Drawing.Size(70, 12);
            effective_dateLabel.TabIndex = 63;
            effective_dateLabel.Text = "effective date:";
            // 
            // supplier_IDLabel
            // 
            supplier_IDLabel.AutoSize = true;
            supplier_IDLabel.Location = new System.Drawing.Point(29, 119);
            supplier_IDLabel.Name = "supplier_IDLabel";
            supplier_IDLabel.Size = new System.Drawing.Size(60, 12);
            supplier_IDLabel.TabIndex = 65;
            supplier_IDLabel.Text = "supplier ID:";
            // 
            // buyer_IDLabel
            // 
            buyer_IDLabel.AutoSize = true;
            buyer_IDLabel.Location = new System.Drawing.Point(29, 146);
            buyer_IDLabel.Name = "buyer_IDLabel";
            buyer_IDLabel.Size = new System.Drawing.Size(50, 12);
            buyer_IDLabel.TabIndex = 67;
            buyer_IDLabel.Text = "buyer ID:";
            // 
            // expected_delivery_dateLabel
            // 
            expected_delivery_dateLabel.AutoSize = true;
            expected_delivery_dateLabel.Location = new System.Drawing.Point(29, 173);
            expected_delivery_dateLabel.Name = "expected_delivery_dateLabel";
            expected_delivery_dateLabel.Size = new System.Drawing.Size(112, 12);
            expected_delivery_dateLabel.TabIndex = 69;
            expected_delivery_dateLabel.Text = "expected delivery date:";
            // 
            // termsLabel
            // 
            termsLabel.AutoSize = true;
            termsLabel.Location = new System.Drawing.Point(29, 200);
            termsLabel.Name = "termsLabel";
            termsLabel.Size = new System.Drawing.Size(33, 12);
            termsLabel.TabIndex = 71;
            termsLabel.Text = "terms:";
            // 
            // conditionLabel
            // 
            conditionLabel.AutoSize = true;
            conditionLabel.Location = new System.Drawing.Point(29, 228);
            conditionLabel.Name = "conditionLabel";
            conditionLabel.Size = new System.Drawing.Size(52, 12);
            conditionLabel.TabIndex = 73;
            conditionLabel.Text = "condition:";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonGroupBox2);
            this.kryptonPanel1.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPanel1.Controls.Add(this.kryptonButtonSave);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1048, 845);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // spo_linesKryptonDataGridView
            // 
            this.spo_linesKryptonDataGridView.AllowUserToAddRows = false;
            this.spo_linesKryptonDataGridView.AllowUserToDeleteRows = false;
            this.spo_linesKryptonDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.spo_linesKryptonDataGridView.DataSource = this.spo_linesBindingSource;
            this.spo_linesKryptonDataGridView.Location = new System.Drawing.Point(15, 14);
            this.spo_linesKryptonDataGridView.Name = "spo_linesKryptonDataGridView";
            this.spo_linesKryptonDataGridView.RowTemplate.Height = 24;
            this.spo_linesKryptonDataGridView.Size = new System.Drawing.Size(849, 284);
            this.spo_linesKryptonDataGridView.TabIndex = 74;
            // 
            // spo_linesBindingSource
            // 
            this.spo_linesBindingSource.DataMember = "SPO_lines_header_ID_fk";
            this.spo_linesBindingSource.DataSource = this.spo_headerBindingSource;
            // 
            // spo_headerBindingSource
            // 
            this.spo_headerBindingSource.DataMember = "spo_header";
            this.spo_headerBindingSource.DataSource = this.purchase_dbDataSet;
            // 
            // purchase_dbDataSet
            // 
            this.purchase_dbDataSet.DataSetName = "purchase_dbDataSet";
            this.purchase_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // create_dateKryptonDateTimePicker
            // 
            this.create_dateKryptonDateTimePicker.CornerRoundingRadius = -1F;
            this.create_dateKryptonDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.spo_headerBindingSource, "create_date", true));
            this.create_dateKryptonDateTimePicker.Location = new System.Drawing.Point(147, 65);
            this.create_dateKryptonDateTimePicker.Name = "create_dateKryptonDateTimePicker";
            this.create_dateKryptonDateTimePicker.PaletteMode = Krypton.Toolkit.PaletteMode.Global;
            this.create_dateKryptonDateTimePicker.Size = new System.Drawing.Size(240, 21);
            this.create_dateKryptonDateTimePicker.TabIndex = 62;
            // 
            // effective_dateKryptonDateTimePicker
            // 
            this.effective_dateKryptonDateTimePicker.CornerRoundingRadius = -1F;
            this.effective_dateKryptonDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.spo_headerBindingSource, "effective_date", true));
            this.effective_dateKryptonDateTimePicker.Location = new System.Drawing.Point(147, 92);
            this.effective_dateKryptonDateTimePicker.Name = "effective_dateKryptonDateTimePicker";
            this.effective_dateKryptonDateTimePicker.PaletteMode = Krypton.Toolkit.PaletteMode.Global;
            this.effective_dateKryptonDateTimePicker.Size = new System.Drawing.Size(240, 21);
            this.effective_dateKryptonDateTimePicker.TabIndex = 64;
            // 
            // expected_delivery_dateKryptonDateTimePicker
            // 
            this.expected_delivery_dateKryptonDateTimePicker.CornerRoundingRadius = -1F;
            this.expected_delivery_dateKryptonDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.spo_headerBindingSource, "expected_delivery_date", true));
            this.expected_delivery_dateKryptonDateTimePicker.Location = new System.Drawing.Point(147, 173);
            this.expected_delivery_dateKryptonDateTimePicker.Name = "expected_delivery_dateKryptonDateTimePicker";
            this.expected_delivery_dateKryptonDateTimePicker.PaletteMode = Krypton.Toolkit.PaletteMode.Global;
            this.expected_delivery_dateKryptonDateTimePicker.Size = new System.Drawing.Size(240, 21);
            this.expected_delivery_dateKryptonDateTimePicker.TabIndex = 70;
            // 
            // termsKryptonTextBox
            // 
            this.termsKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spo_headerBindingSource, "terms", true));
            this.termsKryptonTextBox.Location = new System.Drawing.Point(147, 200);
            this.termsKryptonTextBox.Name = "termsKryptonTextBox";
            this.termsKryptonTextBox.Size = new System.Drawing.Size(240, 23);
            this.termsKryptonTextBox.TabIndex = 72;
            // 
            // conditionKryptonTextBox
            // 
            this.conditionKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spo_headerBindingSource, "condition", true));
            this.conditionKryptonTextBox.Location = new System.Drawing.Point(147, 228);
            this.conditionKryptonTextBox.Name = "conditionKryptonTextBox";
            this.conditionKryptonTextBox.Size = new System.Drawing.Size(240, 23);
            this.conditionKryptonTextBox.TabIndex = 74;
            // 
            // kryptonButtonSave
            // 
            this.kryptonButtonSave.CornerRoundingRadius = 25F;
            this.kryptonButtonSave.Location = new System.Drawing.Point(737, 56);
            this.kryptonButtonSave.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonButtonSave.Name = "kryptonButtonSave";
            this.kryptonButtonSave.Size = new System.Drawing.Size(97, 30);
            this.kryptonButtonSave.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(138)))), ((int)(((byte)(82)))));
            this.kryptonButtonSave.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(138)))), ((int)(((byte)(82)))));
            this.kryptonButtonSave.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonButtonSave.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(138)))), ((int)(((byte)(82)))));
            this.kryptonButtonSave.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(138)))), ((int)(((byte)(82)))));
            this.kryptonButtonSave.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButtonSave.StateCommon.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonButtonSave.StateCommon.Border.Rounding = 25F;
            this.kryptonButtonSave.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButtonSave.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButtonSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.kryptonButtonSave.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonButtonSave.StateCommon.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonButtonSave.TabIndex = 59;
            this.kryptonButtonSave.Values.Text = "Save";
            // 
            // spo_headerTableAdapter
            // 
            this.spo_headerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.blanket_releaseTableAdapter = null;
            this.tableAdapterManager.bpa_headerTableAdapter = null;
            this.tableAdapterManager.bpa_linesTableAdapter = null;
            this.tableAdapterManager.cpaTableAdapter = null;
            this.tableAdapterManager.itemTableAdapter = null;
            this.tableAdapterManager.ppo_headerTableAdapter = null;
            this.tableAdapterManager.ppo_linesTableAdapter = null;
            this.tableAdapterManager.purchase_order_allTableAdapter = null;
            this.tableAdapterManager.purchasers_requestTableAdapter = null;
            this.tableAdapterManager.restaurantTableAdapter = null;
            this.tableAdapterManager.schedule_releaseTableAdapter = null;
            this.tableAdapterManager.spo_headerTableAdapter = this.spo_headerTableAdapter;
            this.tableAdapterManager.spo_linesTableAdapter = this.spo_linesTableAdapter;
            this.tableAdapterManager.spo_releaseTableAdapter = null;
            this.tableAdapterManager.supplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ITP4915_group3_project.purchase_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            this.tableAdapterManager.warehouse_itemTableAdapter = null;
            this.tableAdapterManager.warehousedispatchinstructionTableAdapter = null;
            this.tableAdapterManager.warehouseTableAdapter = null;
            // 
            // spo_linesTableAdapter
            // 
            this.spo_linesTableAdapter.ClearBeforeFill = true;
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.CaptionStyle = Krypton.Toolkit.LabelStyle.GroupBoxCaption;
            this.kryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlGroupBox;
            this.kryptonGroupBox1.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.ControlGroupBox;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(44, 47);
            this.kryptonGroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.AutoScroll = true;
            this.kryptonGroupBox1.Panel.Controls.Add(this.buyer_IDKryptonTextBox);
            this.kryptonGroupBox1.Panel.Controls.Add(this.supplier_IDKryptonTextBox);
            this.kryptonGroupBox1.Panel.Controls.Add(this.header_IDKryptonTextBox);
            this.kryptonGroupBox1.Panel.Controls.Add(header_IDLabel);
            this.kryptonGroupBox1.Panel.Controls.Add(this.conditionKryptonTextBox);
            this.kryptonGroupBox1.Panel.Controls.Add(conditionLabel);
            this.kryptonGroupBox1.Panel.Controls.Add(this.termsKryptonTextBox);
            this.kryptonGroupBox1.Panel.Controls.Add(create_dateLabel);
            this.kryptonGroupBox1.Panel.Controls.Add(termsLabel);
            this.kryptonGroupBox1.Panel.Controls.Add(this.create_dateKryptonDateTimePicker);
            this.kryptonGroupBox1.Panel.Controls.Add(this.expected_delivery_dateKryptonDateTimePicker);
            this.kryptonGroupBox1.Panel.Controls.Add(effective_dateLabel);
            this.kryptonGroupBox1.Panel.Controls.Add(expected_delivery_dateLabel);
            this.kryptonGroupBox1.Panel.Controls.Add(this.effective_dateKryptonDateTimePicker);
            this.kryptonGroupBox1.Panel.Controls.Add(supplier_IDLabel);
            this.kryptonGroupBox1.Panel.Controls.Add(buyer_IDLabel);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(557, 352);
            this.kryptonGroupBox1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonGroupBox1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonGroupBox1.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonGroupBox1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonGroupBox1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox1.StateCommon.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonGroupBox1.StateCommon.Border.Rounding = 12F;
            this.kryptonGroupBox1.StateCommon.Border.Width = 2;
            this.kryptonGroupBox1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonGroupBox1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox1.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonGroupBox1.StateCommon.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonGroupBox1.TabIndex = 208;
            this.kryptonGroupBox1.Values.Heading = "Header";
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.CaptionStyle = Krypton.Toolkit.LabelStyle.GroupBoxCaption;
            this.kryptonGroupBox2.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlGroupBox;
            this.kryptonGroupBox2.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.ControlGroupBox;
            this.kryptonGroupBox2.Location = new System.Drawing.Point(44, 435);
            this.kryptonGroupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.spo_linesKryptonDataGridView);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(882, 332);
            this.kryptonGroupBox2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonGroupBox2.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonGroupBox2.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonGroupBox2.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonGroupBox2.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox2.StateCommon.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonGroupBox2.StateCommon.Border.Rounding = 12F;
            this.kryptonGroupBox2.StateCommon.Border.Width = 2;
            this.kryptonGroupBox2.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonGroupBox2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox2.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonGroupBox2.StateCommon.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonGroupBox2.TabIndex = 209;
            this.kryptonGroupBox2.Values.Heading = "Line";
            // 
            // header_IDKryptonTextBox
            // 
            this.header_IDKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spo_headerBindingSource, "header_ID", true));
            this.header_IDKryptonTextBox.Location = new System.Drawing.Point(147, 36);
            this.header_IDKryptonTextBox.Name = "header_IDKryptonTextBox";
            this.header_IDKryptonTextBox.ReadOnly = true;
            this.header_IDKryptonTextBox.Size = new System.Drawing.Size(240, 23);
            this.header_IDKryptonTextBox.TabIndex = 75;
            // 
            // supplier_IDKryptonTextBox
            // 
            this.supplier_IDKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spo_headerBindingSource, "supplier_ID", true));
            this.supplier_IDKryptonTextBox.Location = new System.Drawing.Point(147, 119);
            this.supplier_IDKryptonTextBox.Name = "supplier_IDKryptonTextBox";
            this.supplier_IDKryptonTextBox.ReadOnly = true;
            this.supplier_IDKryptonTextBox.Size = new System.Drawing.Size(240, 23);
            this.supplier_IDKryptonTextBox.TabIndex = 76;
            // 
            // buyer_IDKryptonTextBox
            // 
            this.buyer_IDKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spo_headerBindingSource, "buyer_ID", true));
            this.buyer_IDKryptonTextBox.Location = new System.Drawing.Point(147, 146);
            this.buyer_IDKryptonTextBox.Name = "buyer_IDKryptonTextBox";
            this.buyer_IDKryptonTextBox.ReadOnly = true;
            this.buyer_IDKryptonTextBox.Size = new System.Drawing.Size(240, 23);
            this.buyer_IDKryptonTextBox.TabIndex = 77;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "lines_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "lines_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "header_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "header_ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "item_ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "item_ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "qty";
            this.dataGridViewTextBoxColumn4.HeaderText = "qty";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn5.HeaderText = "price";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "UOM";
            this.dataGridViewTextBoxColumn6.HeaderText = "UOM";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "amount";
            this.dataGridViewTextBoxColumn7.HeaderText = "amount";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CPA_ID";
            this.dataGridViewTextBoxColumn8.HeaderText = "CPA_ID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Quotation_ID";
            this.dataGridViewTextBoxColumn9.HeaderText = "Quotation_ID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "detail";
            this.Size = new System.Drawing.Size(1048, 845);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spo_linesKryptonDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spo_linesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spo_headerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton kryptonButtonSave;
        private purchase_dbDataSet purchase_dbDataSet;
        private System.Windows.Forms.BindingSource spo_headerBindingSource;
        private purchase_dbDataSetTableAdapters.spo_headerTableAdapter spo_headerTableAdapter;
        private purchase_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Krypton.Toolkit.KryptonDataGridView spo_linesKryptonDataGridView;
        private System.Windows.Forms.BindingSource spo_linesBindingSource;
        private Krypton.Toolkit.KryptonDateTimePicker create_dateKryptonDateTimePicker;
        private Krypton.Toolkit.KryptonDateTimePicker effective_dateKryptonDateTimePicker;
        private Krypton.Toolkit.KryptonDateTimePicker expected_delivery_dateKryptonDateTimePicker;
        private Krypton.Toolkit.KryptonTextBox termsKryptonTextBox;
        private Krypton.Toolkit.KryptonTextBox conditionKryptonTextBox;
        private purchase_dbDataSetTableAdapters.spo_linesTableAdapter spo_linesTableAdapter;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private Krypton.Toolkit.KryptonTextBox buyer_IDKryptonTextBox;
        private Krypton.Toolkit.KryptonTextBox supplier_IDKryptonTextBox;
        private Krypton.Toolkit.KryptonTextBox header_IDKryptonTextBox;
    }
}
