
namespace ITP4915_group3_project.Purchase.PO.create.PPO
{
    partial class create
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
            System.Windows.Forms.Label purchase_order_revision_IDLabel;
            System.Windows.Forms.Label create_dateLabel;
            System.Windows.Forms.Label effective_dateLabel;
            System.Windows.Forms.Label buyer_IDLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label termLabel;
            System.Windows.Forms.Label conditionLabel;
            System.Windows.Forms.Label supplierNameLabel;
            System.Windows.Forms.Label tentative_schedulesLabel;
            System.Windows.Forms.Label currencyLabel1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.currencyKryptonNumericUpDown = new Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonButtonSubmit = new Krypton.Toolkit.KryptonButton();
            this.kryptonDataGridViewCart = new Krypton.Toolkit.KryptonDataGridView();
            this.delete = new Krypton.Toolkit.KryptonDataGridViewButtonColumn();
            this.item_name = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.qty = new Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.UOM = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.price = new Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.amount = new Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.reference = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.kryptonDataGridView1 = new Krypton.Toolkit.KryptonDataGridView();
            this.supplierNameKryptonComboBox = new Krypton.Toolkit.KryptonComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchase_dbDataSet = new ITP4915_group3_project.purchase_dbDataSet();
            this.kryptonDataGridViewChoose = new Krypton.Toolkit.KryptonDataGridView();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conditionKryptonTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.termKryptonTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.amountKryptonNumericUpDown = new Krypton.Toolkit.KryptonNumericUpDown();
            this.tentative_schedulesKryptonDateTimePicker = new Krypton.Toolkit.KryptonDateTimePicker();
            this.effective_dateKryptonDateTimePicker = new Krypton.Toolkit.KryptonDateTimePicker();
            this.create_dateKryptonDateTimePicker = new Krypton.Toolkit.KryptonDateTimePicker();
            this.purchase_order_revision_IDKryptonCheckBox = new Krypton.Toolkit.KryptonCheckBox();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableAdapterManager = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.TableAdapterManager();
            this.supplierTableAdapter = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.supplierTableAdapter();
            this.itemTableAdapter = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.itemTableAdapter();
            this.ppo_headerTableAdapter = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.ppo_headerTableAdapter();
            this.ppo_linesTableAdapter = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.ppo_linesTableAdapter();
            this.select = new Krypton.Toolkit.KryptonDataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kryptonTextBoxBuyerID = new Krypton.Toolkit.KryptonTextBox();
            purchase_order_revision_IDLabel = new System.Windows.Forms.Label();
            create_dateLabel = new System.Windows.Forms.Label();
            effective_dateLabel = new System.Windows.Forms.Label();
            buyer_IDLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            termLabel = new System.Windows.Forms.Label();
            conditionLabel = new System.Windows.Forms.Label();
            supplierNameLabel = new System.Windows.Forms.Label();
            tentative_schedulesLabel = new System.Windows.Forms.Label();
            currencyLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierNameKryptonComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewChoose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // purchase_order_revision_IDLabel
            // 
            purchase_order_revision_IDLabel.AutoSize = true;
            purchase_order_revision_IDLabel.Location = new System.Drawing.Point(375, 77);
            purchase_order_revision_IDLabel.Name = "purchase_order_revision_IDLabel";
            purchase_order_revision_IDLabel.Size = new System.Drawing.Size(45, 12);
            purchase_order_revision_IDLabel.TabIndex = 0;
            purchase_order_revision_IDLabel.Text = "revision:";
            // 
            // create_dateLabel
            // 
            create_dateLabel.AutoSize = true;
            create_dateLabel.Location = new System.Drawing.Point(367, 107);
            create_dateLabel.Name = "create_dateLabel";
            create_dateLabel.Size = new System.Drawing.Size(57, 12);
            create_dateLabel.TabIndex = 2;
            create_dateLabel.Text = "create date:";
            // 
            // effective_dateLabel
            // 
            effective_dateLabel.AutoSize = true;
            effective_dateLabel.Location = new System.Drawing.Point(354, 145);
            effective_dateLabel.Name = "effective_dateLabel";
            effective_dateLabel.Size = new System.Drawing.Size(70, 12);
            effective_dateLabel.TabIndex = 4;
            effective_dateLabel.Text = "effective date:";
            // 
            // buyer_IDLabel
            // 
            buyer_IDLabel.AutoSize = true;
            buyer_IDLabel.Location = new System.Drawing.Point(27, 77);
            buyer_IDLabel.Name = "buyer_IDLabel";
            buyer_IDLabel.Size = new System.Drawing.Size(50, 12);
            buyer_IDLabel.TabIndex = 6;
            buyer_IDLabel.Text = "buyer ID:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(381, 241);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(43, 12);
            amountLabel.TabIndex = 10;
            amountLabel.Text = "amount:";
            // 
            // termLabel
            // 
            termLabel.AutoSize = true;
            termLabel.Location = new System.Drawing.Point(395, 320);
            termLabel.Name = "termLabel";
            termLabel.Size = new System.Drawing.Size(29, 12);
            termLabel.TabIndex = 14;
            termLabel.Text = "term:";
            // 
            // conditionLabel
            // 
            conditionLabel.AutoSize = true;
            conditionLabel.Location = new System.Drawing.Point(372, 361);
            conditionLabel.Name = "conditionLabel";
            conditionLabel.Size = new System.Drawing.Size(52, 12);
            conditionLabel.TabIndex = 16;
            conditionLabel.Text = "condition:";
            // 
            // supplierNameLabel
            // 
            supplierNameLabel.AutoSize = true;
            supplierNameLabel.Location = new System.Drawing.Point(25, 363);
            supplierNameLabel.Name = "supplierNameLabel";
            supplierNameLabel.Size = new System.Drawing.Size(75, 12);
            supplierNameLabel.TabIndex = 19;
            supplierNameLabel.Text = "Supplier name:";
            // 
            // tentative_schedulesLabel
            // 
            tentative_schedulesLabel.AutoSize = true;
            tentative_schedulesLabel.Location = new System.Drawing.Point(330, 198);
            tentative_schedulesLabel.Name = "tentative_schedulesLabel";
            tentative_schedulesLabel.Size = new System.Drawing.Size(94, 12);
            tentative_schedulesLabel.TabIndex = 8;
            tentative_schedulesLabel.Text = "tentative schedules:";
            // 
            // currencyLabel1
            // 
            currencyLabel1.AutoSize = true;
            currencyLabel1.Location = new System.Drawing.Point(371, 293);
            currencyLabel1.Name = "currencyLabel1";
            currencyLabel1.Size = new System.Drawing.Size(49, 12);
            currencyLabel1.TabIndex = 24;
            currencyLabel1.Text = "currency:";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonTextBoxBuyerID);
            this.kryptonPanel1.Controls.Add(currencyLabel1);
            this.kryptonPanel1.Controls.Add(this.currencyKryptonNumericUpDown);
            this.kryptonPanel1.Controls.Add(this.kryptonButtonSubmit);
            this.kryptonPanel1.Controls.Add(this.kryptonDataGridViewCart);
            this.kryptonPanel1.Controls.Add(this.kryptonDataGridView1);
            this.kryptonPanel1.Controls.Add(supplierNameLabel);
            this.kryptonPanel1.Controls.Add(this.supplierNameKryptonComboBox);
            this.kryptonPanel1.Controls.Add(this.kryptonDataGridViewChoose);
            this.kryptonPanel1.Controls.Add(conditionLabel);
            this.kryptonPanel1.Controls.Add(this.conditionKryptonTextBox);
            this.kryptonPanel1.Controls.Add(termLabel);
            this.kryptonPanel1.Controls.Add(this.termKryptonTextBox);
            this.kryptonPanel1.Controls.Add(amountLabel);
            this.kryptonPanel1.Controls.Add(this.amountKryptonNumericUpDown);
            this.kryptonPanel1.Controls.Add(tentative_schedulesLabel);
            this.kryptonPanel1.Controls.Add(this.tentative_schedulesKryptonDateTimePicker);
            this.kryptonPanel1.Controls.Add(buyer_IDLabel);
            this.kryptonPanel1.Controls.Add(effective_dateLabel);
            this.kryptonPanel1.Controls.Add(this.effective_dateKryptonDateTimePicker);
            this.kryptonPanel1.Controls.Add(create_dateLabel);
            this.kryptonPanel1.Controls.Add(this.create_dateKryptonDateTimePicker);
            this.kryptonPanel1.Controls.Add(purchase_order_revision_IDLabel);
            this.kryptonPanel1.Controls.Add(this.purchase_order_revision_IDKryptonCheckBox);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(803, 942);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // currencyKryptonNumericUpDown
            // 
            this.currencyKryptonNumericUpDown.AllowDecimals = true;
            this.currencyKryptonNumericUpDown.DecimalPlaces = 2;
            this.currencyKryptonNumericUpDown.Location = new System.Drawing.Point(430, 283);
            this.currencyKryptonNumericUpDown.Name = "currencyKryptonNumericUpDown";
            this.currencyKryptonNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.currencyKryptonNumericUpDown.TabIndex = 25;
            // 
            // kryptonButtonSubmit
            // 
            this.kryptonButtonSubmit.CornerRoundingRadius = -1F;
            this.kryptonButtonSubmit.Location = new System.Drawing.Point(675, 818);
            this.kryptonButtonSubmit.Name = "kryptonButtonSubmit";
            this.kryptonButtonSubmit.Size = new System.Drawing.Size(90, 25);
            this.kryptonButtonSubmit.TabIndex = 23;
            this.kryptonButtonSubmit.UseMnemonic = false;
            this.kryptonButtonSubmit.Values.Text = "Submit";
            this.kryptonButtonSubmit.Click += new System.EventHandler(this.kryptonButtonSubmit_Click);
            // 
            // kryptonDataGridViewCart
            // 
            this.kryptonDataGridViewCart.AllowUserToAddRows = false;
            this.kryptonDataGridViewCart.AllowUserToDeleteRows = false;
            this.kryptonDataGridViewCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.delete,
            this.item_name,
            this.qty,
            this.UOM,
            this.price,
            this.amount,
            this.reference});
            this.kryptonDataGridViewCart.Location = new System.Drawing.Point(44, 625);
            this.kryptonDataGridViewCart.Name = "kryptonDataGridViewCart";
            this.kryptonDataGridViewCart.RowTemplate.Height = 24;
            this.kryptonDataGridViewCart.Size = new System.Drawing.Size(709, 167);
            this.kryptonDataGridViewCart.TabIndex = 22;
            this.kryptonDataGridViewCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kryptonDataGridViewCart_CellContentClick);
            // 
            // delete
            // 
            this.delete.ButtonStyle = Krypton.Toolkit.ButtonStyle.Standalone;
            this.delete.HeaderText = "delete";
            this.delete.Name = "delete";
            this.delete.Text = "delete";
            this.delete.UseColumnTextForButtonValue = true;
            this.delete.Width = 50;
            // 
            // item_name
            // 
            this.item_name.DefaultCellStyle = dataGridViewCellStyle7;
            this.item_name.HeaderText = "item_name";
            this.item_name.Name = "item_name";
            this.item_name.ReadOnly = true;
            this.item_name.Width = 100;
            // 
            // qty
            // 
            this.qty.AllowDecimals = false;
            this.qty.HeaderText = "qty";
            this.qty.Name = "qty";
            this.qty.Width = 100;
            // 
            // UOM
            // 
            this.UOM.DefaultCellStyle = dataGridViewCellStyle8;
            this.UOM.HeaderText = "UOM";
            this.UOM.Name = "UOM";
            this.UOM.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UOM.Width = 100;
            // 
            // price
            // 
            this.price.AllowDecimals = false;
            this.price.DecimalPlaces = 2;
            this.price.HeaderText = "price";
            this.price.Name = "price";
            this.price.Width = 100;
            // 
            // amount
            // 
            this.amount.AllowDecimals = false;
            this.amount.HeaderText = "amount";
            this.amount.Name = "amount";
            this.amount.Width = 100;
            // 
            // reference
            // 
            this.reference.DefaultCellStyle = dataGridViewCellStyle9;
            this.reference.HeaderText = "reference";
            this.reference.Name = "reference";
            this.reference.Width = 100;
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.Location = new System.Drawing.Point(165, 772);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.RowTemplate.Height = 24;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(240, 150);
            this.kryptonDataGridView1.TabIndex = 21;
            // 
            // supplierNameKryptonComboBox
            // 
            this.supplierNameKryptonComboBox.CornerRoundingRadius = -1F;
            this.supplierNameKryptonComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "name", true));
            this.supplierNameKryptonComboBox.DataSource = this.supplierBindingSource;
            this.supplierNameKryptonComboBox.DisplayMember = "name";
            this.supplierNameKryptonComboBox.DropDownWidth = 121;
            this.supplierNameKryptonComboBox.IntegralHeight = false;
            this.supplierNameKryptonComboBox.Location = new System.Drawing.Point(106, 363);
            this.supplierNameKryptonComboBox.Name = "supplierNameKryptonComboBox";
            this.supplierNameKryptonComboBox.Size = new System.Drawing.Size(121, 21);
            this.supplierNameKryptonComboBox.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.supplierNameKryptonComboBox.TabIndex = 20;
            this.supplierNameKryptonComboBox.ValueMember = "supplier_ID";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.AllowNew = false;
            this.supplierBindingSource.DataMember = "supplier";
            this.supplierBindingSource.DataSource = this.purchase_dbDataSet;
            // 
            // purchase_dbDataSet
            // 
            this.purchase_dbDataSet.DataSetName = "purchase_dbDataSet";
            this.purchase_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kryptonDataGridViewChoose
            // 
            this.kryptonDataGridViewChoose.AllowUserToAddRows = false;
            this.kryptonDataGridViewChoose.AllowUserToDeleteRows = false;
            this.kryptonDataGridViewChoose.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31});
            this.kryptonDataGridViewChoose.DataSource = this.itemBindingSource;
            this.kryptonDataGridViewChoose.Location = new System.Drawing.Point(54, 390);
            this.kryptonDataGridViewChoose.Name = "kryptonDataGridViewChoose";
            this.kryptonDataGridViewChoose.RowTemplate.Height = 24;
            this.kryptonDataGridViewChoose.Size = new System.Drawing.Size(723, 189);
            this.kryptonDataGridViewChoose.TabIndex = 18;
            this.kryptonDataGridViewChoose.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kryptonDataGridViewChoose_CellContentClick);
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "item_ID";
            this.dataGridViewTextBoxColumn20.HeaderText = "item_ID";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "item_name";
            this.dataGridViewTextBoxColumn21.HeaderText = "item_name";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn22.HeaderText = "price";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "size";
            this.dataGridViewTextBoxColumn23.HeaderText = "size";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "category_ID";
            this.dataGridViewTextBoxColumn24.HeaderText = "category_ID";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.Visible = false;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "partner_brand_ID";
            this.dataGridViewTextBoxColumn25.HeaderText = "partner_brand_ID";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.Visible = false;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "item";
            this.itemBindingSource.DataSource = this.purchase_dbDataSet;
            // 
            // conditionKryptonTextBox
            // 
            this.conditionKryptonTextBox.Location = new System.Drawing.Point(430, 361);
            this.conditionKryptonTextBox.Name = "conditionKryptonTextBox";
            this.conditionKryptonTextBox.Size = new System.Drawing.Size(100, 23);
            this.conditionKryptonTextBox.TabIndex = 17;
            // 
            // termKryptonTextBox
            // 
            this.termKryptonTextBox.Location = new System.Drawing.Point(430, 320);
            this.termKryptonTextBox.Name = "termKryptonTextBox";
            this.termKryptonTextBox.Size = new System.Drawing.Size(100, 23);
            this.termKryptonTextBox.TabIndex = 15;
            // 
            // amountKryptonNumericUpDown
            // 
            this.amountKryptonNumericUpDown.Location = new System.Drawing.Point(430, 241);
            this.amountKryptonNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.amountKryptonNumericUpDown.Name = "amountKryptonNumericUpDown";
            this.amountKryptonNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.amountKryptonNumericUpDown.TabIndex = 11;
            // 
            // tentative_schedulesKryptonDateTimePicker
            // 
            this.tentative_schedulesKryptonDateTimePicker.CornerRoundingRadius = -1F;
            this.tentative_schedulesKryptonDateTimePicker.Location = new System.Drawing.Point(430, 198);
            this.tentative_schedulesKryptonDateTimePicker.Name = "tentative_schedulesKryptonDateTimePicker";
            this.tentative_schedulesKryptonDateTimePicker.PaletteMode = Krypton.Toolkit.PaletteMode.Global;
            this.tentative_schedulesKryptonDateTimePicker.Size = new System.Drawing.Size(240, 21);
            this.tentative_schedulesKryptonDateTimePicker.TabIndex = 9;
            // 
            // effective_dateKryptonDateTimePicker
            // 
            this.effective_dateKryptonDateTimePicker.CornerRoundingRadius = -1F;
            this.effective_dateKryptonDateTimePicker.Location = new System.Drawing.Point(430, 145);
            this.effective_dateKryptonDateTimePicker.Name = "effective_dateKryptonDateTimePicker";
            this.effective_dateKryptonDateTimePicker.PaletteMode = Krypton.Toolkit.PaletteMode.Global;
            this.effective_dateKryptonDateTimePicker.Size = new System.Drawing.Size(240, 21);
            this.effective_dateKryptonDateTimePicker.TabIndex = 5;
            // 
            // create_dateKryptonDateTimePicker
            // 
            this.create_dateKryptonDateTimePicker.CornerRoundingRadius = -1F;
            this.create_dateKryptonDateTimePicker.Location = new System.Drawing.Point(430, 107);
            this.create_dateKryptonDateTimePicker.Name = "create_dateKryptonDateTimePicker";
            this.create_dateKryptonDateTimePicker.PaletteMode = Krypton.Toolkit.PaletteMode.Global;
            this.create_dateKryptonDateTimePicker.Size = new System.Drawing.Size(240, 21);
            this.create_dateKryptonDateTimePicker.TabIndex = 3;
            // 
            // purchase_order_revision_IDKryptonCheckBox
            // 
            this.purchase_order_revision_IDKryptonCheckBox.Location = new System.Drawing.Point(430, 76);
            this.purchase_order_revision_IDKryptonCheckBox.Name = "purchase_order_revision_IDKryptonCheckBox";
            this.purchase_order_revision_IDKryptonCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.purchase_order_revision_IDKryptonCheckBox.Size = new System.Drawing.Size(19, 13);
            this.purchase_order_revision_IDKryptonCheckBox.TabIndex = 1;
            this.purchase_order_revision_IDKryptonCheckBox.Values.Text = "";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "item_ID";
            this.dataGridViewTextBoxColumn8.HeaderText = "item_ID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "item_name";
            this.dataGridViewTextBoxColumn14.HeaderText = "item_name";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn15.HeaderText = "price";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "size";
            this.dataGridViewTextBoxColumn16.HeaderText = "size";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "category_ID";
            this.dataGridViewTextBoxColumn18.HeaderText = "category_ID";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Visible = false;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "partner_brand_ID";
            this.dataGridViewTextBoxColumn19.HeaderText = "partner_brand_ID";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "item_ID";
            this.dataGridViewTextBoxColumn7.HeaderText = "item_ID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn_item_name
            // 
            this.dataGridViewTextBoxColumn_item_name.DataPropertyName = "item_name";
            this.dataGridViewTextBoxColumn_item_name.HeaderText = "item_name";
            this.dataGridViewTextBoxColumn_item_name.Name = "dataGridViewTextBoxColumn_item_name";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn9.HeaderText = "price";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "size";
            this.dataGridViewTextBoxColumn10.HeaderText = "size";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "supplier_ID";
            this.dataGridViewTextBoxColumn11.HeaderText = "supplier_ID";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "category_ID";
            this.dataGridViewTextBoxColumn12.HeaderText = "category_ID";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "partner_brand_ID";
            this.dataGridViewTextBoxColumn13.HeaderText = "partner_brand_ID";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "item_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "item_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "item_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "item_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn3.HeaderText = "price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "size";
            this.dataGridViewTextBoxColumn4.HeaderText = "size";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "category_ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "category_ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "partner_brand_ID";
            this.dataGridViewTextBoxColumn6.HeaderText = "partner_brand_ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // supplier_ID
            // 
            this.supplier_ID.DataPropertyName = "supplier_ID";
            this.supplier_ID.HeaderText = "supplier_ID";
            this.supplier_ID.Name = "supplier_ID";
            this.supplier_ID.Visible = false;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.blanket_releaseTableAdapter = null;
            this.tableAdapterManager.bpa_headerTableAdapter = null;
            this.tableAdapterManager.bpa_linesTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.cpaTableAdapter = null;
            this.tableAdapterManager.itemTableAdapter = null;
            this.tableAdapterManager.ppo_headerTableAdapter = null;
            this.tableAdapterManager.ppo_linesTableAdapter = null;
            this.tableAdapterManager.purchase_order_allTableAdapter = null;
            this.tableAdapterManager.purchasers_requestTableAdapter = null;
            this.tableAdapterManager.restaurantTableAdapter = null;
            this.tableAdapterManager.schedule_releaseTableAdapter = null;
            this.tableAdapterManager.spo_headerTableAdapter = null;
            this.tableAdapterManager.spo_linesTableAdapter = null;
            this.tableAdapterManager.spo_releaseTableAdapter = null;
            this.tableAdapterManager.supplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ITP4915_group3_project.purchase_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            this.tableAdapterManager.warehouse_itemTableAdapter = null;
            this.tableAdapterManager.warehousedispatchinstructionTableAdapter = null;
            this.tableAdapterManager.warehouseTableAdapter = null;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // ppo_headerTableAdapter
            // 
            this.ppo_headerTableAdapter.ClearBeforeFill = true;
            // 
            // ppo_linesTableAdapter
            // 
            this.ppo_linesTableAdapter.ClearBeforeFill = true;
            // 
            // select
            // 
            this.select.ButtonStyle = Krypton.Toolkit.ButtonStyle.Standalone;
            this.select.HeaderText = "select";
            this.select.Name = "select";
            this.select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.select.Text = "add";
            this.select.UseColumnTextForButtonValue = true;
            this.select.Width = 50;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "supplier_ID";
            this.dataGridViewTextBoxColumn17.HeaderText = "supplier_ID";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Visible = false;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "item_ID";
            this.dataGridViewTextBoxColumn26.HeaderText = "item_ID";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "item_name";
            this.dataGridViewTextBoxColumn27.HeaderText = "item_name";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn28.HeaderText = "price";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "size";
            this.dataGridViewTextBoxColumn29.HeaderText = "size";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "category_ID";
            this.dataGridViewTextBoxColumn30.HeaderText = "category_ID";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.ReadOnly = true;
            this.dataGridViewTextBoxColumn30.Visible = false;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "partner_brand_ID";
            this.dataGridViewTextBoxColumn31.HeaderText = "partner_brand_ID";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.ReadOnly = true;
            this.dataGridViewTextBoxColumn31.Visible = false;
            // 
            // kryptonTextBoxBuyerID
            // 
            this.kryptonTextBoxBuyerID.Location = new System.Drawing.Point(83, 76);
            this.kryptonTextBoxBuyerID.Name = "kryptonTextBoxBuyerID";
            this.kryptonTextBoxBuyerID.ReadOnly = true;
            this.kryptonTextBoxBuyerID.Size = new System.Drawing.Size(120, 23);
            this.kryptonTextBoxBuyerID.TabIndex = 26;
            this.kryptonTextBoxBuyerID.Text = "kryptonTextBoxBuyerID";
            // 
            // create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "create";
            this.Size = new System.Drawing.Size(803, 942);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierNameKryptonComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewChoose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private purchase_dbDataSet purchase_dbDataSet;
        private purchase_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Krypton.Toolkit.KryptonCheckBox purchase_order_revision_IDKryptonCheckBox;
        private Krypton.Toolkit.KryptonTextBox conditionKryptonTextBox;
        private Krypton.Toolkit.KryptonTextBox termKryptonTextBox;
        private Krypton.Toolkit.KryptonNumericUpDown amountKryptonNumericUpDown;
        private Krypton.Toolkit.KryptonDateTimePicker tentative_schedulesKryptonDateTimePicker;
        private Krypton.Toolkit.KryptonDateTimePicker effective_dateKryptonDateTimePicker;
        private Krypton.Toolkit.KryptonDateTimePicker create_dateKryptonDateTimePicker;
        private Krypton.Toolkit.KryptonComboBox supplierNameKryptonComboBox;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewChoose;
        private purchase_dbDataSetTableAdapters.supplierTableAdapter supplierTableAdapter;
        private purchase_dbDataSetTableAdapters.itemTableAdapter itemTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_ID;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewCart;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn_item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private Krypton.Toolkit.KryptonDataGridViewButtonColumn delete;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn item_name;
        private Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn qty;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn UOM;
        private Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn price;
        private Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn amount;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn reference;
        private Krypton.Toolkit.KryptonButton kryptonButtonSubmit;
        private purchase_dbDataSetTableAdapters.ppo_headerTableAdapter ppo_headerTableAdapter;
        private Krypton.Toolkit.KryptonNumericUpDown currencyKryptonNumericUpDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private purchase_dbDataSetTableAdapters.ppo_linesTableAdapter ppo_linesTableAdapter;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private Krypton.Toolkit.KryptonDataGridViewButtonColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBoxBuyerID;
    }
}
