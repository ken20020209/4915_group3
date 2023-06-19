
namespace ITP4915_group3_project.Purchase.request_order.process
{
    partial class select_BPA_match
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label item_IDLabel;
            System.Windows.Forms.Label qtyLabel;
            System.Windows.Forms.Label item_nameLabel;
            System.Windows.Forms.Label sizeLabel;
            this.panel2 = new System.Windows.Forms.Panel();
            this.kryptonLabelRemark = new Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBoxRemark = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonDateTimePickerExpected = new Krypton.Toolkit.KryptonDateTimePicker();
            this.bpa_remain_qtyKryptonDataGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.bpa_remain_qtyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchasers_requestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchase_dbDataSet = new ITP4915_group3_project.purchase_dbDataSet();
            this.sizeKryptonTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.item_nameKryptonTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.qtyKryptonTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.item_IDKryptonTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabelBack = new Krypton.Toolkit.KryptonLabel();
            this.kryptonButtonConfirm = new Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.kryptonComboBox2 = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonTextBox20 = new Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasers_requestTableAdapter = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.purchasers_requestTableAdapter();
            this.tableAdapterManager = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.TableAdapterManager();
            this.itemTableAdapter = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.itemTableAdapter();
            this.bpa_remain_qtyTableAdapter = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.bpa_remain_qtyTableAdapter();
            this.blanket_releaseTableAdapter = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.blanket_releaseTableAdapter();
            this.purchase_order_allTableAdapter = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.purchase_order_allTableAdapter();
            item_IDLabel = new System.Windows.Forms.Label();
            qtyLabel = new System.Windows.Forms.Label();
            item_nameLabel = new System.Windows.Forms.Label();
            sizeLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bpa_remain_qtyKryptonDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpa_remain_qtyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasers_requestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // item_IDLabel
            // 
            item_IDLabel.AutoSize = true;
            item_IDLabel.Location = new System.Drawing.Point(65, 181);
            item_IDLabel.Name = "item_IDLabel";
            item_IDLabel.Size = new System.Drawing.Size(43, 12);
            item_IDLabel.TabIndex = 207;
            item_IDLabel.Text = "item ID:";
            // 
            // qtyLabel
            // 
            qtyLabel.AutoSize = true;
            qtyLabel.Location = new System.Drawing.Point(263, 181);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new System.Drawing.Size(23, 12);
            qtyLabel.TabIndex = 208;
            qtyLabel.Text = "qty:";
            // 
            // item_nameLabel
            // 
            item_nameLabel.AutoSize = true;
            item_nameLabel.Location = new System.Drawing.Point(446, 181);
            item_nameLabel.Name = "item_nameLabel";
            item_nameLabel.Size = new System.Drawing.Size(56, 12);
            item_nameLabel.TabIndex = 209;
            item_nameLabel.Text = "item name:";
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Location = new System.Drawing.Point(477, 248);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new System.Drawing.Size(25, 12);
            sizeLabel.TabIndex = 210;
            sizeLabel.Text = "size:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.kryptonLabelRemark);
            this.panel2.Controls.Add(this.kryptonTextBoxRemark);
            this.panel2.Controls.Add(this.kryptonLabel2);
            this.panel2.Controls.Add(this.kryptonDateTimePickerExpected);
            this.panel2.Controls.Add(this.bpa_remain_qtyKryptonDataGridView);
            this.panel2.Controls.Add(sizeLabel);
            this.panel2.Controls.Add(this.sizeKryptonTextBox);
            this.panel2.Controls.Add(item_nameLabel);
            this.panel2.Controls.Add(this.item_nameKryptonTextBox);
            this.panel2.Controls.Add(qtyLabel);
            this.panel2.Controls.Add(this.qtyKryptonTextBox);
            this.panel2.Controls.Add(item_IDLabel);
            this.panel2.Controls.Add(this.item_IDKryptonTextBox);
            this.panel2.Controls.Add(this.kryptonLabelBack);
            this.panel2.Controls.Add(this.kryptonButtonConfirm);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.kryptonComboBox2);
            this.panel2.Controls.Add(this.kryptonTextBox20);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 800);
            this.panel2.TabIndex = 7;
            // 
            // kryptonLabelRemark
            // 
            this.kryptonLabelRemark.Location = new System.Drawing.Point(444, 302);
            this.kryptonLabelRemark.Name = "kryptonLabelRemark";
            this.kryptonLabelRemark.Size = new System.Drawing.Size(49, 20);
            this.kryptonLabelRemark.TabIndex = 218;
            this.kryptonLabelRemark.Values.Text = "remark";
            // 
            // kryptonTextBoxRemark
            // 
            this.kryptonTextBoxRemark.Location = new System.Drawing.Point(508, 299);
            this.kryptonTextBoxRemark.Name = "kryptonTextBoxRemark";
            this.kryptonTextBoxRemark.Size = new System.Drawing.Size(100, 23);
            this.kryptonTextBoxRemark.TabIndex = 217;
            this.kryptonTextBoxRemark.Text = "kryptonTextBoxRemark";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(166, 302);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(133, 20);
            this.kryptonLabel2.TabIndex = 214;
            this.kryptonLabel2.Values.Text = "expected delivery date";
            // 
            // kryptonDateTimePickerExpected
            // 
            this.kryptonDateTimePickerExpected.CornerRoundingRadius = -1F;
            this.kryptonDateTimePickerExpected.Location = new System.Drawing.Point(305, 302);
            this.kryptonDateTimePickerExpected.Name = "kryptonDateTimePickerExpected";
            this.kryptonDateTimePickerExpected.Size = new System.Drawing.Size(110, 21);
            this.kryptonDateTimePickerExpected.TabIndex = 212;
            // 
            // bpa_remain_qtyKryptonDataGridView
            // 
            this.bpa_remain_qtyKryptonDataGridView.AllowUserToAddRows = false;
            this.bpa_remain_qtyKryptonDataGridView.AllowUserToDeleteRows = false;
            this.bpa_remain_qtyKryptonDataGridView.DataSource = this.bpa_remain_qtyBindingSource;
            this.bpa_remain_qtyKryptonDataGridView.Location = new System.Drawing.Point(56, 346);
            this.bpa_remain_qtyKryptonDataGridView.Name = "bpa_remain_qtyKryptonDataGridView";
            this.bpa_remain_qtyKryptonDataGridView.RowTemplate.Height = 24;
            this.bpa_remain_qtyKryptonDataGridView.Size = new System.Drawing.Size(860, 207);
            this.bpa_remain_qtyKryptonDataGridView.TabIndex = 211;
            // 
            // bpa_remain_qtyBindingSource
            // 
            this.bpa_remain_qtyBindingSource.DataMember = "bpa_remain_qty_item";
            this.bpa_remain_qtyBindingSource.DataSource = this.itemBindingSource;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "purchasers_request_item";
            this.itemBindingSource.DataSource = this.purchasers_requestBindingSource;
            // 
            // purchasers_requestBindingSource
            // 
            this.purchasers_requestBindingSource.DataMember = "purchasers_request";
            this.purchasers_requestBindingSource.DataSource = this.purchase_dbDataSet;
            // 
            // purchase_dbDataSet
            // 
            this.purchase_dbDataSet.DataSetName = "purchase_dbDataSet";
            this.purchase_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sizeKryptonTextBox
            // 
            this.sizeKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemBindingSource, "size", true));
            this.sizeKryptonTextBox.Location = new System.Drawing.Point(508, 248);
            this.sizeKryptonTextBox.Name = "sizeKryptonTextBox";
            this.sizeKryptonTextBox.Size = new System.Drawing.Size(100, 23);
            this.sizeKryptonTextBox.TabIndex = 211;
            this.sizeKryptonTextBox.Text = "kryptonTextBox1";
            // 
            // item_nameKryptonTextBox
            // 
            this.item_nameKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemBindingSource, "item_name", true));
            this.item_nameKryptonTextBox.Location = new System.Drawing.Point(508, 181);
            this.item_nameKryptonTextBox.Name = "item_nameKryptonTextBox";
            this.item_nameKryptonTextBox.Size = new System.Drawing.Size(100, 23);
            this.item_nameKryptonTextBox.TabIndex = 210;
            this.item_nameKryptonTextBox.Text = "kryptonTextBox1";
            // 
            // qtyKryptonTextBox
            // 
            this.qtyKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchasers_requestBindingSource, "qty", true));
            this.qtyKryptonTextBox.Location = new System.Drawing.Point(292, 181);
            this.qtyKryptonTextBox.Name = "qtyKryptonTextBox";
            this.qtyKryptonTextBox.Size = new System.Drawing.Size(100, 23);
            this.qtyKryptonTextBox.TabIndex = 209;
            this.qtyKryptonTextBox.Text = "kryptonTextBox1";
            // 
            // item_IDKryptonTextBox
            // 
            this.item_IDKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchasers_requestBindingSource, "item_ID", true));
            this.item_IDKryptonTextBox.Location = new System.Drawing.Point(114, 181);
            this.item_IDKryptonTextBox.Name = "item_IDKryptonTextBox";
            this.item_IDKryptonTextBox.Size = new System.Drawing.Size(100, 23);
            this.item_IDKryptonTextBox.TabIndex = 208;
            this.item_IDKryptonTextBox.Text = "kryptonTextBox1";
            // 
            // kryptonLabelBack
            // 
            this.kryptonLabelBack.Location = new System.Drawing.Point(19, 38);
            this.kryptonLabelBack.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabelBack.Name = "kryptonLabelBack";
            this.kryptonLabelBack.Size = new System.Drawing.Size(50, 16);
            this.kryptonLabelBack.StateCommon.ShortText.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.kryptonLabelBack.TabIndex = 207;
            this.kryptonLabelBack.UseMnemonic = false;
            this.kryptonLabelBack.Values.Text = "← Back";
            this.kryptonLabelBack.Click += new System.EventHandler(this.kryptonLabelBack_Click);
            // 
            // kryptonButtonConfirm
            // 
            this.kryptonButtonConfirm.CornerRoundingRadius = 25F;
            this.kryptonButtonConfirm.Location = new System.Drawing.Point(665, 13);
            this.kryptonButtonConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonButtonConfirm.Name = "kryptonButtonConfirm";
            this.kryptonButtonConfirm.Size = new System.Drawing.Size(97, 30);
            this.kryptonButtonConfirm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(138)))), ((int)(((byte)(82)))));
            this.kryptonButtonConfirm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(138)))), ((int)(((byte)(82)))));
            this.kryptonButtonConfirm.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(138)))), ((int)(((byte)(82)))));
            this.kryptonButtonConfirm.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(138)))), ((int)(((byte)(82)))));
            this.kryptonButtonConfirm.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButtonConfirm.StateCommon.Border.Rounding = 25F;
            this.kryptonButtonConfirm.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButtonConfirm.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButtonConfirm.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.kryptonButtonConfirm.TabIndex = 57;
            this.kryptonButtonConfirm.Values.Text = "Confirm";
            this.kryptonButtonConfirm.Click += new System.EventHandler(this.kryptonButtonConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.label1.Location = new System.Drawing.Point(448, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 52;
            this.label1.Text = "Filter:";
            // 
            // kryptonComboBox2
            // 
            this.kryptonComboBox2.CornerRoundingRadius = 25F;
            this.kryptonComboBox2.DropDownWidth = 153;
            this.kryptonComboBox2.IntegralHeight = false;
            this.kryptonComboBox2.Location = new System.Drawing.Point(495, 79);
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
            this.kryptonComboBox2.TabIndex = 51;
            this.kryptonComboBox2.Text = "Category";
            // 
            // kryptonTextBox20
            // 
            this.kryptonTextBox20.Location = new System.Drawing.Point(56, 79);
            this.kryptonTextBox20.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonTextBox20.Name = "kryptonTextBox20";
            this.kryptonTextBox20.Size = new System.Drawing.Size(244, 34);
            this.kryptonTextBox20.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.kryptonTextBox20.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonTextBox20.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonTextBox20.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox20.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonTextBox20.StateCommon.Border.Rounding = 25F;
            this.kryptonTextBox20.StateCommon.Border.Width = 1;
            this.kryptonTextBox20.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.kryptonTextBox20.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox20.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.kryptonTextBox20.TabIndex = 48;
            this.kryptonTextBox20.Text = "ID/name                                                 🔍 ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 44;
            this.label3.Text = "Select BPA";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "header_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "header_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "lines_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "lines_ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "remain qty";
            this.dataGridViewTextBoxColumn3.HeaderText = "remain qty";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "UOM";
            this.dataGridViewTextBoxColumn4.HeaderText = "UOM";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MoQ";
            this.dataGridViewTextBoxColumn5.HeaderText = "MoQ";
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
            this.dataGridViewTextBoxColumn7.DataPropertyName = "supplier name";
            this.dataGridViewTextBoxColumn7.HeaderText = "supplier name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "item_ID";
            this.dataGridViewTextBoxColumn8.HeaderText = "item_ID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // purchasers_requestTableAdapter
            // 
            this.purchasers_requestTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.blanket_releaseTableAdapter = null;
            this.tableAdapterManager.bpa_headerTableAdapter = null;
            this.tableAdapterManager.bpa_linesTableAdapter = null;
            this.tableAdapterManager.cpaTableAdapter = null;
            this.tableAdapterManager.itemTableAdapter = this.itemTableAdapter;
            this.tableAdapterManager.ppo_headerTableAdapter = null;
            this.tableAdapterManager.ppo_linesTableAdapter = null;
            this.tableAdapterManager.purchase_order_allTableAdapter = null;
            this.tableAdapterManager.purchasers_requestTableAdapter = this.purchasers_requestTableAdapter;
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
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // bpa_remain_qtyTableAdapter
            // 
            this.bpa_remain_qtyTableAdapter.ClearBeforeFill = true;
            // 
            // blanket_releaseTableAdapter
            // 
            this.blanket_releaseTableAdapter.ClearBeforeFill = true;
            // 
            // purchase_order_allTableAdapter
            // 
            this.purchase_order_allTableAdapter.ClearBeforeFill = true;
            // 
            // select_BPA_match
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "select_BPA_match";
            this.Size = new System.Drawing.Size(1200, 800);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bpa_remain_qtyKryptonDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpa_remain_qtyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasers_requestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabelBack;
        private Krypton.Toolkit.KryptonButton kryptonButtonConfirm;
        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonComboBox kryptonComboBox2;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox20;
        private System.Windows.Forms.Label label3;
        private purchase_dbDataSet purchase_dbDataSet;
        private System.Windows.Forms.BindingSource purchasers_requestBindingSource;
        private purchase_dbDataSetTableAdapters.purchasers_requestTableAdapter purchasers_requestTableAdapter;
        private purchase_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Krypton.Toolkit.KryptonTextBox sizeKryptonTextBox;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private Krypton.Toolkit.KryptonTextBox item_nameKryptonTextBox;
        private Krypton.Toolkit.KryptonTextBox qtyKryptonTextBox;
        private Krypton.Toolkit.KryptonTextBox item_IDKryptonTextBox;
        private purchase_dbDataSetTableAdapters.itemTableAdapter itemTableAdapter;
        private System.Windows.Forms.BindingSource bpa_remain_qtyBindingSource;
        private purchase_dbDataSetTableAdapters.bpa_remain_qtyTableAdapter bpa_remain_qtyTableAdapter;
        private Krypton.Toolkit.KryptonDataGridView bpa_remain_qtyKryptonDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePickerExpected;
        private purchase_dbDataSetTableAdapters.blanket_releaseTableAdapter blanket_releaseTableAdapter;
        private purchase_dbDataSetTableAdapters.purchase_order_allTableAdapter purchase_order_allTableAdapter;
        private Krypton.Toolkit.KryptonLabel kryptonLabelRemark;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBoxRemark;
    }
}