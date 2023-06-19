
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
            this.header_IDKryptonNumericUpDown = new Krypton.Toolkit.KryptonNumericUpDown();
            this.create_dateKryptonDateTimePicker = new Krypton.Toolkit.KryptonDateTimePicker();
            this.effective_dateKryptonDateTimePicker = new Krypton.Toolkit.KryptonDateTimePicker();
            this.supplier_IDKryptonNumericUpDown = new Krypton.Toolkit.KryptonNumericUpDown();
            this.buyer_IDKryptonNumericUpDown = new Krypton.Toolkit.KryptonNumericUpDown();
            this.expected_delivery_dateKryptonDateTimePicker = new Krypton.Toolkit.KryptonDateTimePicker();
            this.termsKryptonTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.conditionKryptonTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonButtonSave = new Krypton.Toolkit.KryptonButton();
            this.spo_headerTableAdapter = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.spo_headerTableAdapter();
            this.tableAdapterManager = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.TableAdapterManager();
            this.spo_linesTableAdapter = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.spo_linesTableAdapter();
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
            this.SuspendLayout();
            // 
            // header_IDLabel
            // 
            header_IDLabel.AutoSize = true;
            header_IDLabel.Location = new System.Drawing.Point(75, 87);
            header_IDLabel.Name = "header_IDLabel";
            header_IDLabel.Size = new System.Drawing.Size(54, 12);
            header_IDLabel.TabIndex = 59;
            header_IDLabel.Text = "header ID:";
            // 
            // create_dateLabel
            // 
            create_dateLabel.AutoSize = true;
            create_dateLabel.Location = new System.Drawing.Point(75, 114);
            create_dateLabel.Name = "create_dateLabel";
            create_dateLabel.Size = new System.Drawing.Size(57, 12);
            create_dateLabel.TabIndex = 61;
            create_dateLabel.Text = "create date:";
            // 
            // effective_dateLabel
            // 
            effective_dateLabel.AutoSize = true;
            effective_dateLabel.Location = new System.Drawing.Point(75, 141);
            effective_dateLabel.Name = "effective_dateLabel";
            effective_dateLabel.Size = new System.Drawing.Size(70, 12);
            effective_dateLabel.TabIndex = 63;
            effective_dateLabel.Text = "effective date:";
            // 
            // supplier_IDLabel
            // 
            supplier_IDLabel.AutoSize = true;
            supplier_IDLabel.Location = new System.Drawing.Point(75, 168);
            supplier_IDLabel.Name = "supplier_IDLabel";
            supplier_IDLabel.Size = new System.Drawing.Size(60, 12);
            supplier_IDLabel.TabIndex = 65;
            supplier_IDLabel.Text = "supplier ID:";
            // 
            // buyer_IDLabel
            // 
            buyer_IDLabel.AutoSize = true;
            buyer_IDLabel.Location = new System.Drawing.Point(75, 195);
            buyer_IDLabel.Name = "buyer_IDLabel";
            buyer_IDLabel.Size = new System.Drawing.Size(50, 12);
            buyer_IDLabel.TabIndex = 67;
            buyer_IDLabel.Text = "buyer ID:";
            // 
            // expected_delivery_dateLabel
            // 
            expected_delivery_dateLabel.AutoSize = true;
            expected_delivery_dateLabel.Location = new System.Drawing.Point(75, 222);
            expected_delivery_dateLabel.Name = "expected_delivery_dateLabel";
            expected_delivery_dateLabel.Size = new System.Drawing.Size(112, 12);
            expected_delivery_dateLabel.TabIndex = 69;
            expected_delivery_dateLabel.Text = "expected delivery date:";
            // 
            // termsLabel
            // 
            termsLabel.AutoSize = true;
            termsLabel.Location = new System.Drawing.Point(75, 249);
            termsLabel.Name = "termsLabel";
            termsLabel.Size = new System.Drawing.Size(33, 12);
            termsLabel.TabIndex = 71;
            termsLabel.Text = "terms:";
            // 
            // conditionLabel
            // 
            conditionLabel.AutoSize = true;
            conditionLabel.Location = new System.Drawing.Point(75, 277);
            conditionLabel.Name = "conditionLabel";
            conditionLabel.Size = new System.Drawing.Size(52, 12);
            conditionLabel.TabIndex = 73;
            conditionLabel.Text = "condition:";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.spo_linesKryptonDataGridView);
            this.kryptonPanel1.Controls.Add(header_IDLabel);
            this.kryptonPanel1.Controls.Add(this.header_IDKryptonNumericUpDown);
            this.kryptonPanel1.Controls.Add(create_dateLabel);
            this.kryptonPanel1.Controls.Add(this.create_dateKryptonDateTimePicker);
            this.kryptonPanel1.Controls.Add(effective_dateLabel);
            this.kryptonPanel1.Controls.Add(this.effective_dateKryptonDateTimePicker);
            this.kryptonPanel1.Controls.Add(supplier_IDLabel);
            this.kryptonPanel1.Controls.Add(this.supplier_IDKryptonNumericUpDown);
            this.kryptonPanel1.Controls.Add(buyer_IDLabel);
            this.kryptonPanel1.Controls.Add(this.buyer_IDKryptonNumericUpDown);
            this.kryptonPanel1.Controls.Add(expected_delivery_dateLabel);
            this.kryptonPanel1.Controls.Add(this.expected_delivery_dateKryptonDateTimePicker);
            this.kryptonPanel1.Controls.Add(termsLabel);
            this.kryptonPanel1.Controls.Add(this.termsKryptonTextBox);
            this.kryptonPanel1.Controls.Add(conditionLabel);
            this.kryptonPanel1.Controls.Add(this.conditionKryptonTextBox);
            this.kryptonPanel1.Controls.Add(this.kryptonButtonSave);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(968, 949);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // spo_linesKryptonDataGridView
            // 
            this.spo_linesKryptonDataGridView.AllowUserToAddRows = false;
            this.spo_linesKryptonDataGridView.AllowUserToDeleteRows = false;
            this.spo_linesKryptonDataGridView.DataSource = this.spo_linesBindingSource;
            this.spo_linesKryptonDataGridView.Location = new System.Drawing.Point(-5, 482);
            this.spo_linesKryptonDataGridView.Name = "spo_linesKryptonDataGridView";
            this.spo_linesKryptonDataGridView.RowTemplate.Height = 24;
            this.spo_linesKryptonDataGridView.Size = new System.Drawing.Size(970, 256);
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
            // header_IDKryptonNumericUpDown
            // 
            this.header_IDKryptonNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.spo_headerBindingSource, "header_ID", true));
            this.header_IDKryptonNumericUpDown.Location = new System.Drawing.Point(193, 87);
            this.header_IDKryptonNumericUpDown.Name = "header_IDKryptonNumericUpDown";
            this.header_IDKryptonNumericUpDown.Size = new System.Drawing.Size(240, 22);
            this.header_IDKryptonNumericUpDown.TabIndex = 60;
            // 
            // create_dateKryptonDateTimePicker
            // 
            this.create_dateKryptonDateTimePicker.CornerRoundingRadius = -1F;
            this.create_dateKryptonDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.spo_headerBindingSource, "create_date", true));
            this.create_dateKryptonDateTimePicker.Location = new System.Drawing.Point(193, 114);
            this.create_dateKryptonDateTimePicker.Name = "create_dateKryptonDateTimePicker";
            this.create_dateKryptonDateTimePicker.Size = new System.Drawing.Size(240, 21);
            this.create_dateKryptonDateTimePicker.TabIndex = 62;
            // 
            // effective_dateKryptonDateTimePicker
            // 
            this.effective_dateKryptonDateTimePicker.CornerRoundingRadius = -1F;
            this.effective_dateKryptonDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.spo_headerBindingSource, "effective_date", true));
            this.effective_dateKryptonDateTimePicker.Location = new System.Drawing.Point(193, 141);
            this.effective_dateKryptonDateTimePicker.Name = "effective_dateKryptonDateTimePicker";
            this.effective_dateKryptonDateTimePicker.Size = new System.Drawing.Size(240, 21);
            this.effective_dateKryptonDateTimePicker.TabIndex = 64;
            // 
            // supplier_IDKryptonNumericUpDown
            // 
            this.supplier_IDKryptonNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.spo_headerBindingSource, "supplier_ID", true));
            this.supplier_IDKryptonNumericUpDown.Location = new System.Drawing.Point(193, 168);
            this.supplier_IDKryptonNumericUpDown.Name = "supplier_IDKryptonNumericUpDown";
            this.supplier_IDKryptonNumericUpDown.Size = new System.Drawing.Size(240, 22);
            this.supplier_IDKryptonNumericUpDown.TabIndex = 66;
            // 
            // buyer_IDKryptonNumericUpDown
            // 
            this.buyer_IDKryptonNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.spo_headerBindingSource, "buyer_ID", true));
            this.buyer_IDKryptonNumericUpDown.Location = new System.Drawing.Point(193, 195);
            this.buyer_IDKryptonNumericUpDown.Name = "buyer_IDKryptonNumericUpDown";
            this.buyer_IDKryptonNumericUpDown.Size = new System.Drawing.Size(240, 22);
            this.buyer_IDKryptonNumericUpDown.TabIndex = 68;
            // 
            // expected_delivery_dateKryptonDateTimePicker
            // 
            this.expected_delivery_dateKryptonDateTimePicker.CornerRoundingRadius = -1F;
            this.expected_delivery_dateKryptonDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.spo_headerBindingSource, "expected_delivery_date", true));
            this.expected_delivery_dateKryptonDateTimePicker.Location = new System.Drawing.Point(193, 222);
            this.expected_delivery_dateKryptonDateTimePicker.Name = "expected_delivery_dateKryptonDateTimePicker";
            this.expected_delivery_dateKryptonDateTimePicker.Size = new System.Drawing.Size(240, 21);
            this.expected_delivery_dateKryptonDateTimePicker.TabIndex = 70;
            // 
            // termsKryptonTextBox
            // 
            this.termsKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spo_headerBindingSource, "terms", true));
            this.termsKryptonTextBox.Location = new System.Drawing.Point(193, 249);
            this.termsKryptonTextBox.Name = "termsKryptonTextBox";
            this.termsKryptonTextBox.Size = new System.Drawing.Size(240, 23);
            this.termsKryptonTextBox.TabIndex = 72;
            this.termsKryptonTextBox.Text = "kryptonTextBox1";
            // 
            // conditionKryptonTextBox
            // 
            this.conditionKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spo_headerBindingSource, "condition", true));
            this.conditionKryptonTextBox.Location = new System.Drawing.Point(193, 277);
            this.conditionKryptonTextBox.Name = "conditionKryptonTextBox";
            this.conditionKryptonTextBox.Size = new System.Drawing.Size(240, 23);
            this.conditionKryptonTextBox.TabIndex = 74;
            this.conditionKryptonTextBox.Text = "kryptonTextBox1";
            // 
            // kryptonButtonSave
            // 
            this.kryptonButtonSave.CornerRoundingRadius = 25F;
            this.kryptonButtonSave.Location = new System.Drawing.Point(607, 47);
            this.kryptonButtonSave.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonButtonSave.Name = "kryptonButtonSave";
            this.kryptonButtonSave.Size = new System.Drawing.Size(97, 30);
            this.kryptonButtonSave.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(138)))), ((int)(((byte)(82)))));
            this.kryptonButtonSave.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(138)))), ((int)(((byte)(82)))));
            this.kryptonButtonSave.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(138)))), ((int)(((byte)(82)))));
            this.kryptonButtonSave.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(138)))), ((int)(((byte)(82)))));
            this.kryptonButtonSave.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButtonSave.StateCommon.Border.Rounding = 25F;
            this.kryptonButtonSave.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButtonSave.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButtonSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10F);
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
            // detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "detail";
            this.Size = new System.Drawing.Size(968, 949);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spo_linesKryptonDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spo_linesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spo_headerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_dbDataSet)).EndInit();
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
        private Krypton.Toolkit.KryptonNumericUpDown header_IDKryptonNumericUpDown;
        private Krypton.Toolkit.KryptonDateTimePicker create_dateKryptonDateTimePicker;
        private Krypton.Toolkit.KryptonDateTimePicker effective_dateKryptonDateTimePicker;
        private Krypton.Toolkit.KryptonNumericUpDown supplier_IDKryptonNumericUpDown;
        private Krypton.Toolkit.KryptonNumericUpDown buyer_IDKryptonNumericUpDown;
        private Krypton.Toolkit.KryptonDateTimePicker expected_delivery_dateKryptonDateTimePicker;
        private Krypton.Toolkit.KryptonTextBox termsKryptonTextBox;
        private Krypton.Toolkit.KryptonTextBox conditionKryptonTextBox;
        private purchase_dbDataSetTableAdapters.spo_linesTableAdapter spo_linesTableAdapter;
    }
}
