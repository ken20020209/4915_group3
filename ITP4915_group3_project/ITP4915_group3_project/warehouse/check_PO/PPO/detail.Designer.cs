
namespace ITP4915_group3_project.warehouse.check_PO.PPO
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
            System.Windows.Forms.Label header_IDLabel;
            System.Windows.Forms.Label purchase_order_revision_IDLabel;
            System.Windows.Forms.Label create_dateLabel;
            System.Windows.Forms.Label effective_dateLabel;
            System.Windows.Forms.Label supplier_IDLabel;
            System.Windows.Forms.Label buyer_IDLabel;
            System.Windows.Forms.Label tentative_schedulesLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label currencyLabel;
            System.Windows.Forms.Label termLabel;
            System.Windows.Forms.Label conditionLabel;
            this.kryptonPanelContent = new Krypton.Toolkit.KryptonPanel();
            this.kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            this.header_IDKryptonTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.ppo_headerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchase_dbDataSet = new ITP4915_group3_project.purchase_dbDataSet();
            this.purchase_order_revision_IDKryptonCheckBox = new Krypton.Toolkit.KryptonCheckBox();
            this.create_dateKryptonDateTimePicker = new Krypton.Toolkit.KryptonDateTimePicker();
            this.effective_dateKryptonDateTimePicker = new Krypton.Toolkit.KryptonDateTimePicker();
            this.supplier_IDKryptonTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.buyer_IDKryptonTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.tentative_schedulesKryptonDateTimePicker = new Krypton.Toolkit.KryptonDateTimePicker();
            this.amountKryptonNumericUpDown = new Krypton.Toolkit.KryptonNumericUpDown();
            this.currencyKryptonNumericUpDown = new Krypton.Toolkit.KryptonNumericUpDown();
            this.termKryptonTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.conditionKryptonTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.kryptonGroupBox4 = new Krypton.Toolkit.KryptonGroupBox();
            this.ppo_linesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ppo_linesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ppo_linesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ppo_linesTableAdapter = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.ppo_linesTableAdapter();
            this.tableAdapterManager = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.TableAdapterManager();
            this.ppo_headerTableAdapter = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.ppo_headerTableAdapter();
            header_IDLabel = new System.Windows.Forms.Label();
            purchase_order_revision_IDLabel = new System.Windows.Forms.Label();
            create_dateLabel = new System.Windows.Forms.Label();
            effective_dateLabel = new System.Windows.Forms.Label();
            supplier_IDLabel = new System.Windows.Forms.Label();
            buyer_IDLabel = new System.Windows.Forms.Label();
            tentative_schedulesLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            currencyLabel = new System.Windows.Forms.Label();
            termLabel = new System.Windows.Forms.Label();
            conditionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelContent)).BeginInit();
            this.kryptonPanelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ppo_headerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox4.Panel)).BeginInit();
            this.kryptonGroupBox4.Panel.SuspendLayout();
            this.kryptonGroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ppo_linesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppo_linesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppo_linesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // header_IDLabel
            // 
            header_IDLabel.AutoSize = true;
            header_IDLabel.Location = new System.Drawing.Point(52, 21);
            header_IDLabel.Name = "header_IDLabel";
            header_IDLabel.Size = new System.Drawing.Size(54, 12);
            header_IDLabel.TabIndex = 0;
            header_IDLabel.Text = "header ID:";
            // 
            // purchase_order_revision_IDLabel
            // 
            purchase_order_revision_IDLabel.AutoSize = true;
            purchase_order_revision_IDLabel.Location = new System.Drawing.Point(52, 49);
            purchase_order_revision_IDLabel.Name = "purchase_order_revision_IDLabel";
            purchase_order_revision_IDLabel.Size = new System.Drawing.Size(132, 12);
            purchase_order_revision_IDLabel.TabIndex = 2;
            purchase_order_revision_IDLabel.Text = "purchase order revision ID:";
            // 
            // create_dateLabel
            // 
            create_dateLabel.AutoSize = true;
            create_dateLabel.Location = new System.Drawing.Point(52, 75);
            create_dateLabel.Name = "create_dateLabel";
            create_dateLabel.Size = new System.Drawing.Size(57, 12);
            create_dateLabel.TabIndex = 4;
            create_dateLabel.Text = "create date:";
            // 
            // effective_dateLabel
            // 
            effective_dateLabel.AutoSize = true;
            effective_dateLabel.Location = new System.Drawing.Point(52, 102);
            effective_dateLabel.Name = "effective_dateLabel";
            effective_dateLabel.Size = new System.Drawing.Size(70, 12);
            effective_dateLabel.TabIndex = 6;
            effective_dateLabel.Text = "effective date:";
            // 
            // supplier_IDLabel
            // 
            supplier_IDLabel.AutoSize = true;
            supplier_IDLabel.Location = new System.Drawing.Point(52, 129);
            supplier_IDLabel.Name = "supplier_IDLabel";
            supplier_IDLabel.Size = new System.Drawing.Size(60, 12);
            supplier_IDLabel.TabIndex = 8;
            supplier_IDLabel.Text = "supplier ID:";
            // 
            // buyer_IDLabel
            // 
            buyer_IDLabel.AutoSize = true;
            buyer_IDLabel.Location = new System.Drawing.Point(52, 157);
            buyer_IDLabel.Name = "buyer_IDLabel";
            buyer_IDLabel.Size = new System.Drawing.Size(50, 12);
            buyer_IDLabel.TabIndex = 10;
            buyer_IDLabel.Text = "buyer ID:";
            // 
            // tentative_schedulesLabel
            // 
            tentative_schedulesLabel.AutoSize = true;
            tentative_schedulesLabel.Location = new System.Drawing.Point(52, 185);
            tentative_schedulesLabel.Name = "tentative_schedulesLabel";
            tentative_schedulesLabel.Size = new System.Drawing.Size(94, 12);
            tentative_schedulesLabel.TabIndex = 12;
            tentative_schedulesLabel.Text = "tentative schedules:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(52, 212);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(43, 12);
            amountLabel.TabIndex = 14;
            amountLabel.Text = "amount:";
            // 
            // currencyLabel
            // 
            currencyLabel.AutoSize = true;
            currencyLabel.Location = new System.Drawing.Point(52, 239);
            currencyLabel.Name = "currencyLabel";
            currencyLabel.Size = new System.Drawing.Size(49, 12);
            currencyLabel.TabIndex = 16;
            currencyLabel.Text = "currency:";
            // 
            // termLabel
            // 
            termLabel.AutoSize = true;
            termLabel.Location = new System.Drawing.Point(52, 266);
            termLabel.Name = "termLabel";
            termLabel.Size = new System.Drawing.Size(29, 12);
            termLabel.TabIndex = 18;
            termLabel.Text = "term:";
            // 
            // conditionLabel
            // 
            conditionLabel.AutoSize = true;
            conditionLabel.Location = new System.Drawing.Point(52, 294);
            conditionLabel.Name = "conditionLabel";
            conditionLabel.Size = new System.Drawing.Size(52, 12);
            conditionLabel.TabIndex = 20;
            conditionLabel.Text = "condition:";
            // 
            // kryptonPanelContent
            // 
            this.kryptonPanelContent.AutoScroll = true;
            this.kryptonPanelContent.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPanelContent.Controls.Add(this.kryptonLabel4);
            this.kryptonPanelContent.Controls.Add(this.label1);
            this.kryptonPanelContent.Controls.Add(this.kryptonGroupBox4);
            this.kryptonPanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanelContent.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanelContent.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanelContent.Name = "kryptonPanelContent";
            this.kryptonPanelContent.Size = new System.Drawing.Size(827, 565);
            this.kryptonPanelContent.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPanelContent.TabIndex = 287;
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(53, 87);
            this.kryptonGroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.AutoScroll = true;
            this.kryptonGroupBox1.Panel.Controls.Add(header_IDLabel);
            this.kryptonGroupBox1.Panel.Controls.Add(this.header_IDKryptonTextBox);
            this.kryptonGroupBox1.Panel.Controls.Add(purchase_order_revision_IDLabel);
            this.kryptonGroupBox1.Panel.Controls.Add(this.purchase_order_revision_IDKryptonCheckBox);
            this.kryptonGroupBox1.Panel.Controls.Add(create_dateLabel);
            this.kryptonGroupBox1.Panel.Controls.Add(this.create_dateKryptonDateTimePicker);
            this.kryptonGroupBox1.Panel.Controls.Add(effective_dateLabel);
            this.kryptonGroupBox1.Panel.Controls.Add(this.effective_dateKryptonDateTimePicker);
            this.kryptonGroupBox1.Panel.Controls.Add(supplier_IDLabel);
            this.kryptonGroupBox1.Panel.Controls.Add(this.supplier_IDKryptonTextBox);
            this.kryptonGroupBox1.Panel.Controls.Add(buyer_IDLabel);
            this.kryptonGroupBox1.Panel.Controls.Add(this.buyer_IDKryptonTextBox);
            this.kryptonGroupBox1.Panel.Controls.Add(tentative_schedulesLabel);
            this.kryptonGroupBox1.Panel.Controls.Add(this.tentative_schedulesKryptonDateTimePicker);
            this.kryptonGroupBox1.Panel.Controls.Add(amountLabel);
            this.kryptonGroupBox1.Panel.Controls.Add(this.amountKryptonNumericUpDown);
            this.kryptonGroupBox1.Panel.Controls.Add(currencyLabel);
            this.kryptonGroupBox1.Panel.Controls.Add(this.currencyKryptonNumericUpDown);
            this.kryptonGroupBox1.Panel.Controls.Add(termLabel);
            this.kryptonGroupBox1.Panel.Controls.Add(this.termKryptonTextBox);
            this.kryptonGroupBox1.Panel.Controls.Add(conditionLabel);
            this.kryptonGroupBox1.Panel.Controls.Add(this.conditionKryptonTextBox);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(712, 370);
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
            this.kryptonGroupBox1.TabIndex = 208;
            this.kryptonGroupBox1.Values.Heading = "HEADER";
            // 
            // header_IDKryptonTextBox
            // 
            this.header_IDKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ppo_headerBindingSource, "header_ID", true));
            this.header_IDKryptonTextBox.Location = new System.Drawing.Point(190, 21);
            this.header_IDKryptonTextBox.Name = "header_IDKryptonTextBox";
            this.header_IDKryptonTextBox.Size = new System.Drawing.Size(240, 23);
            this.header_IDKryptonTextBox.TabIndex = 1;
            this.header_IDKryptonTextBox.Text = "kryptonTextBox1";
            // 
            // ppo_headerBindingSource
            // 
            this.ppo_headerBindingSource.DataMember = "ppo_header";
            this.ppo_headerBindingSource.DataSource = this.purchase_dbDataSet;
            // 
            // purchase_dbDataSet
            // 
            this.purchase_dbDataSet.DataSetName = "purchase_dbDataSet";
            this.purchase_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchase_order_revision_IDKryptonCheckBox
            // 
            this.purchase_order_revision_IDKryptonCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.ppo_headerBindingSource, "purchase_order_revision_ID", true));
            this.purchase_order_revision_IDKryptonCheckBox.Location = new System.Drawing.Point(190, 49);
            this.purchase_order_revision_IDKryptonCheckBox.Name = "purchase_order_revision_IDKryptonCheckBox";
            this.purchase_order_revision_IDKryptonCheckBox.Size = new System.Drawing.Size(19, 13);
            this.purchase_order_revision_IDKryptonCheckBox.TabIndex = 3;
            this.purchase_order_revision_IDKryptonCheckBox.Values.Text = "";
            // 
            // create_dateKryptonDateTimePicker
            // 
            this.create_dateKryptonDateTimePicker.CornerRoundingRadius = -1F;
            this.create_dateKryptonDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ppo_headerBindingSource, "create_date", true));
            this.create_dateKryptonDateTimePicker.Location = new System.Drawing.Point(190, 75);
            this.create_dateKryptonDateTimePicker.Name = "create_dateKryptonDateTimePicker";
            this.create_dateKryptonDateTimePicker.Size = new System.Drawing.Size(240, 21);
            this.create_dateKryptonDateTimePicker.TabIndex = 5;
            // 
            // effective_dateKryptonDateTimePicker
            // 
            this.effective_dateKryptonDateTimePicker.CornerRoundingRadius = -1F;
            this.effective_dateKryptonDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ppo_headerBindingSource, "effective_date", true));
            this.effective_dateKryptonDateTimePicker.Location = new System.Drawing.Point(190, 102);
            this.effective_dateKryptonDateTimePicker.Name = "effective_dateKryptonDateTimePicker";
            this.effective_dateKryptonDateTimePicker.Size = new System.Drawing.Size(240, 21);
            this.effective_dateKryptonDateTimePicker.TabIndex = 7;
            // 
            // supplier_IDKryptonTextBox
            // 
            this.supplier_IDKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ppo_headerBindingSource, "supplier_ID", true));
            this.supplier_IDKryptonTextBox.Location = new System.Drawing.Point(190, 129);
            this.supplier_IDKryptonTextBox.Name = "supplier_IDKryptonTextBox";
            this.supplier_IDKryptonTextBox.Size = new System.Drawing.Size(240, 23);
            this.supplier_IDKryptonTextBox.TabIndex = 9;
            this.supplier_IDKryptonTextBox.Text = "kryptonTextBox1";
            // 
            // buyer_IDKryptonTextBox
            // 
            this.buyer_IDKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ppo_headerBindingSource, "buyer_ID", true));
            this.buyer_IDKryptonTextBox.Location = new System.Drawing.Point(190, 157);
            this.buyer_IDKryptonTextBox.Name = "buyer_IDKryptonTextBox";
            this.buyer_IDKryptonTextBox.Size = new System.Drawing.Size(240, 23);
            this.buyer_IDKryptonTextBox.TabIndex = 11;
            this.buyer_IDKryptonTextBox.Text = "kryptonTextBox1";
            // 
            // tentative_schedulesKryptonDateTimePicker
            // 
            this.tentative_schedulesKryptonDateTimePicker.CornerRoundingRadius = -1F;
            this.tentative_schedulesKryptonDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ppo_headerBindingSource, "tentative_schedules", true));
            this.tentative_schedulesKryptonDateTimePicker.Location = new System.Drawing.Point(190, 185);
            this.tentative_schedulesKryptonDateTimePicker.Name = "tentative_schedulesKryptonDateTimePicker";
            this.tentative_schedulesKryptonDateTimePicker.Size = new System.Drawing.Size(240, 21);
            this.tentative_schedulesKryptonDateTimePicker.TabIndex = 13;
            // 
            // amountKryptonNumericUpDown
            // 
            this.amountKryptonNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ppo_headerBindingSource, "amount", true));
            this.amountKryptonNumericUpDown.Location = new System.Drawing.Point(190, 212);
            this.amountKryptonNumericUpDown.Name = "amountKryptonNumericUpDown";
            this.amountKryptonNumericUpDown.Size = new System.Drawing.Size(240, 22);
            this.amountKryptonNumericUpDown.TabIndex = 15;
            // 
            // currencyKryptonNumericUpDown
            // 
            this.currencyKryptonNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ppo_headerBindingSource, "currency", true));
            this.currencyKryptonNumericUpDown.Location = new System.Drawing.Point(190, 239);
            this.currencyKryptonNumericUpDown.Name = "currencyKryptonNumericUpDown";
            this.currencyKryptonNumericUpDown.Size = new System.Drawing.Size(240, 22);
            this.currencyKryptonNumericUpDown.TabIndex = 17;
            // 
            // termKryptonTextBox
            // 
            this.termKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ppo_headerBindingSource, "term", true));
            this.termKryptonTextBox.Location = new System.Drawing.Point(190, 266);
            this.termKryptonTextBox.Name = "termKryptonTextBox";
            this.termKryptonTextBox.Size = new System.Drawing.Size(240, 23);
            this.termKryptonTextBox.TabIndex = 19;
            this.termKryptonTextBox.Text = "kryptonTextBox1";
            // 
            // conditionKryptonTextBox
            // 
            this.conditionKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ppo_headerBindingSource, "condition", true));
            this.conditionKryptonTextBox.Location = new System.Drawing.Point(190, 294);
            this.conditionKryptonTextBox.Name = "conditionKryptonTextBox";
            this.conditionKryptonTextBox.Size = new System.Drawing.Size(240, 23);
            this.conditionKryptonTextBox.TabIndex = 21;
            this.conditionKryptonTextBox.Text = "kryptonTextBox1";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(23, 49);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(50, 16);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.kryptonLabel4.TabIndex = 207;
            this.kryptonLabel4.Values.Text = "← Back";
            this.kryptonLabel4.Click += new System.EventHandler(this.kryptonLabel4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 136;
            this.label1.Text = "Detail";
            // 
            // kryptonGroupBox4
            // 
            this.kryptonGroupBox4.Location = new System.Drawing.Point(53, 478);
            this.kryptonGroupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonGroupBox4.Name = "kryptonGroupBox4";
            // 
            // kryptonGroupBox4.Panel
            // 
            this.kryptonGroupBox4.Panel.AutoScroll = true;
            this.kryptonGroupBox4.Panel.Controls.Add(this.ppo_linesDataGridView);
            this.kryptonGroupBox4.Size = new System.Drawing.Size(712, 206);
            this.kryptonGroupBox4.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonGroupBox4.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonGroupBox4.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonGroupBox4.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox4.StateCommon.Border.Rounding = 12F;
            this.kryptonGroupBox4.StateCommon.Border.Width = 2;
            this.kryptonGroupBox4.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonGroupBox4.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox4.TabIndex = 206;
            this.kryptonGroupBox4.Values.Heading = "LINE";
            // 
            // ppo_linesDataGridView
            // 
            this.ppo_linesDataGridView.AllowUserToAddRows = false;
            this.ppo_linesDataGridView.AutoGenerateColumns = false;
            this.ppo_linesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ppo_linesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.ppo_linesDataGridView.DataSource = this.ppo_linesBindingSource1;
            this.ppo_linesDataGridView.Location = new System.Drawing.Point(3, 3);
            this.ppo_linesDataGridView.Name = "ppo_linesDataGridView";
            this.ppo_linesDataGridView.RowTemplate.Height = 24;
            this.ppo_linesDataGridView.Size = new System.Drawing.Size(694, 170);
            this.ppo_linesDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "lines_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "lines_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "header_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "header_ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "item_ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "item_ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "qty";
            this.dataGridViewTextBoxColumn4.HeaderText = "qty";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "UOM";
            this.dataGridViewTextBoxColumn5.HeaderText = "UOM";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn6.HeaderText = "price";
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
            this.dataGridViewTextBoxColumn8.DataPropertyName = "reference";
            this.dataGridViewTextBoxColumn8.HeaderText = "reference";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // ppo_linesBindingSource1
            // 
            this.ppo_linesBindingSource1.DataMember = "PPO_lines_header_ID_fk";
            this.ppo_linesBindingSource1.DataSource = this.ppo_headerBindingSource;
            // 
            // ppo_linesBindingSource
            // 
            this.ppo_linesBindingSource.DataMember = "ppo_lines";
            this.ppo_linesBindingSource.DataSource = this.purchase_dbDataSet;
            // 
            // ppo_linesTableAdapter
            // 
            this.ppo_linesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.addressTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.blanket_releaseTableAdapter = null;
            this.tableAdapterManager.bpa_headerTableAdapter = null;
            this.tableAdapterManager.bpa_linesTableAdapter = null;
            this.tableAdapterManager.cpaTableAdapter = null;
            this.tableAdapterManager.itemTableAdapter = null;
            this.tableAdapterManager.ppo_headerTableAdapter = this.ppo_headerTableAdapter;
            this.tableAdapterManager.ppo_linesTableAdapter = this.ppo_linesTableAdapter;
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
            // ppo_headerTableAdapter
            // 
            this.ppo_headerTableAdapter.ClearBeforeFill = true;
            // 
            // detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanelContent);
            this.Name = "detail";
            this.Size = new System.Drawing.Size(827, 565);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelContent)).EndInit();
            this.kryptonPanelContent.ResumeLayout(false);
            this.kryptonPanelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ppo_headerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox4.Panel)).EndInit();
            this.kryptonGroupBox4.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox4)).EndInit();
            this.kryptonGroupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ppo_linesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppo_linesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppo_linesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanelContent;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox4;
        private System.Windows.Forms.BindingSource ppo_linesBindingSource;
        private purchase_dbDataSet purchase_dbDataSet;
        private System.Windows.Forms.BindingSource ppo_headerBindingSource;
        private purchase_dbDataSetTableAdapters.ppo_linesTableAdapter ppo_linesTableAdapter;
        private purchase_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private purchase_dbDataSetTableAdapters.ppo_headerTableAdapter ppo_headerTableAdapter;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private Krypton.Toolkit.KryptonTextBox header_IDKryptonTextBox;
        private Krypton.Toolkit.KryptonCheckBox purchase_order_revision_IDKryptonCheckBox;
        private Krypton.Toolkit.KryptonDateTimePicker create_dateKryptonDateTimePicker;
        private Krypton.Toolkit.KryptonDateTimePicker effective_dateKryptonDateTimePicker;
        private Krypton.Toolkit.KryptonTextBox supplier_IDKryptonTextBox;
        private Krypton.Toolkit.KryptonTextBox buyer_IDKryptonTextBox;
        private Krypton.Toolkit.KryptonDateTimePicker tentative_schedulesKryptonDateTimePicker;
        private Krypton.Toolkit.KryptonNumericUpDown amountKryptonNumericUpDown;
        private Krypton.Toolkit.KryptonNumericUpDown currencyKryptonNumericUpDown;
        private Krypton.Toolkit.KryptonTextBox termKryptonTextBox;
        private Krypton.Toolkit.KryptonTextBox conditionKryptonTextBox;
        private System.Windows.Forms.DataGridView ppo_linesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource ppo_linesBindingSource1;
    }
}
