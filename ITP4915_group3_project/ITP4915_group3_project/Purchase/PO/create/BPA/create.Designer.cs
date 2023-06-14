
namespace ITP4915_group3_project.Purchase.PO.create.BPA
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
            System.Windows.Forms.Label header_IDLabel;
            System.Windows.Forms.Label purchase_order_revisionLabel;
            System.Windows.Forms.Label create_dateLabel;
            System.Windows.Forms.Label effective_datesLabel;
            System.Windows.Forms.Label supplier_IDLabel;
            System.Windows.Forms.Label buyer_IDLabel;
            System.Windows.Forms.Label agreed_amountLabel;
            System.Windows.Forms.Label currencyLabel;
            System.Windows.Forms.Label termsLabel;
            System.Windows.Forms.Label conditionLabel;
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.itemKryptonDataGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchase_dbDataSet = new ITP4915_group3_project.purchase_dbDataSet();
            this.header_IDTextBox = new System.Windows.Forms.TextBox();
            this.purchase_order_revisionComboBox = new System.Windows.Forms.ComboBox();
            this.create_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.effective_datesDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.supplier_IDTextBox = new System.Windows.Forms.TextBox();
            this.buyer_IDTextBox = new System.Windows.Forms.TextBox();
            this.agreed_amountTextBox = new System.Windows.Forms.TextBox();
            this.currencyTextBox = new System.Windows.Forms.TextBox();
            this.termsTextBox = new System.Windows.Forms.TextBox();
            this.conditionTextBox = new System.Windows.Forms.TextBox();
            this.kryptonLabelSupplier = new Krypton.Toolkit.KryptonLabel();
            this.supplierComboBox = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierTableAdapter = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.supplierTableAdapter();
            this.tableAdapterManager = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.TableAdapterManager();
            this.bpa_linesTableAdapter = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.bpa_linesTableAdapter();
            this.itemTableAdapter = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.itemTableAdapter();
            this.bpa_linesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            header_IDLabel = new System.Windows.Forms.Label();
            purchase_order_revisionLabel = new System.Windows.Forms.Label();
            create_dateLabel = new System.Windows.Forms.Label();
            effective_datesLabel = new System.Windows.Forms.Label();
            supplier_IDLabel = new System.Windows.Forms.Label();
            buyer_IDLabel = new System.Windows.Forms.Label();
            agreed_amountLabel = new System.Windows.Forms.Label();
            currencyLabel = new System.Windows.Forms.Label();
            termsLabel = new System.Windows.Forms.Label();
            conditionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemKryptonDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpa_linesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // header_IDLabel
            // 
            header_IDLabel.AutoSize = true;
            header_IDLabel.Location = new System.Drawing.Point(19, 17);
            header_IDLabel.Name = "header_IDLabel";
            header_IDLabel.Size = new System.Drawing.Size(54, 12);
            header_IDLabel.TabIndex = 2;
            header_IDLabel.Text = "header ID:";
            // 
            // purchase_order_revisionLabel
            // 
            purchase_order_revisionLabel.AutoSize = true;
            purchase_order_revisionLabel.Location = new System.Drawing.Point(19, 45);
            purchase_order_revisionLabel.Name = "purchase_order_revisionLabel";
            purchase_order_revisionLabel.Size = new System.Drawing.Size(117, 12);
            purchase_order_revisionLabel.TabIndex = 4;
            purchase_order_revisionLabel.Text = "purchase order revision:";
            // 
            // create_dateLabel
            // 
            create_dateLabel.AutoSize = true;
            create_dateLabel.Location = new System.Drawing.Point(19, 72);
            create_dateLabel.Name = "create_dateLabel";
            create_dateLabel.Size = new System.Drawing.Size(57, 12);
            create_dateLabel.TabIndex = 6;
            create_dateLabel.Text = "create date:";
            // 
            // effective_datesLabel
            // 
            effective_datesLabel.AutoSize = true;
            effective_datesLabel.Location = new System.Drawing.Point(19, 100);
            effective_datesLabel.Name = "effective_datesLabel";
            effective_datesLabel.Size = new System.Drawing.Size(74, 12);
            effective_datesLabel.TabIndex = 8;
            effective_datesLabel.Text = "effective dates:";
            // 
            // supplier_IDLabel
            // 
            supplier_IDLabel.AutoSize = true;
            supplier_IDLabel.Location = new System.Drawing.Point(19, 127);
            supplier_IDLabel.Name = "supplier_IDLabel";
            supplier_IDLabel.Size = new System.Drawing.Size(60, 12);
            supplier_IDLabel.TabIndex = 10;
            supplier_IDLabel.Text = "supplier ID:";
            // 
            // buyer_IDLabel
            // 
            buyer_IDLabel.AutoSize = true;
            buyer_IDLabel.Location = new System.Drawing.Point(19, 155);
            buyer_IDLabel.Name = "buyer_IDLabel";
            buyer_IDLabel.Size = new System.Drawing.Size(50, 12);
            buyer_IDLabel.TabIndex = 12;
            buyer_IDLabel.Text = "buyer ID:";
            // 
            // agreed_amountLabel
            // 
            agreed_amountLabel.AutoSize = true;
            agreed_amountLabel.Location = new System.Drawing.Point(19, 183);
            agreed_amountLabel.Name = "agreed_amountLabel";
            agreed_amountLabel.Size = new System.Drawing.Size(77, 12);
            agreed_amountLabel.TabIndex = 14;
            agreed_amountLabel.Text = "agreed amount:";
            // 
            // currencyLabel
            // 
            currencyLabel.AutoSize = true;
            currencyLabel.Location = new System.Drawing.Point(19, 211);
            currencyLabel.Name = "currencyLabel";
            currencyLabel.Size = new System.Drawing.Size(49, 12);
            currencyLabel.TabIndex = 16;
            currencyLabel.Text = "currency:";
            // 
            // termsLabel
            // 
            termsLabel.AutoSize = true;
            termsLabel.Location = new System.Drawing.Point(19, 239);
            termsLabel.Name = "termsLabel";
            termsLabel.Size = new System.Drawing.Size(33, 12);
            termsLabel.TabIndex = 18;
            termsLabel.Text = "terms:";
            // 
            // conditionLabel
            // 
            conditionLabel.AutoSize = true;
            conditionLabel.Location = new System.Drawing.Point(19, 267);
            conditionLabel.Name = "conditionLabel";
            conditionLabel.Size = new System.Drawing.Size(52, 12);
            conditionLabel.TabIndex = 20;
            conditionLabel.Text = "condition:";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.itemKryptonDataGridView);
            this.kryptonPanel1.Controls.Add(header_IDLabel);
            this.kryptonPanel1.Controls.Add(this.header_IDTextBox);
            this.kryptonPanel1.Controls.Add(purchase_order_revisionLabel);
            this.kryptonPanel1.Controls.Add(this.purchase_order_revisionComboBox);
            this.kryptonPanel1.Controls.Add(create_dateLabel);
            this.kryptonPanel1.Controls.Add(this.create_dateDateTimePicker);
            this.kryptonPanel1.Controls.Add(effective_datesLabel);
            this.kryptonPanel1.Controls.Add(this.effective_datesDateTimePicker);
            this.kryptonPanel1.Controls.Add(supplier_IDLabel);
            this.kryptonPanel1.Controls.Add(this.supplier_IDTextBox);
            this.kryptonPanel1.Controls.Add(buyer_IDLabel);
            this.kryptonPanel1.Controls.Add(this.buyer_IDTextBox);
            this.kryptonPanel1.Controls.Add(agreed_amountLabel);
            this.kryptonPanel1.Controls.Add(this.agreed_amountTextBox);
            this.kryptonPanel1.Controls.Add(currencyLabel);
            this.kryptonPanel1.Controls.Add(this.currencyTextBox);
            this.kryptonPanel1.Controls.Add(termsLabel);
            this.kryptonPanel1.Controls.Add(this.termsTextBox);
            this.kryptonPanel1.Controls.Add(conditionLabel);
            this.kryptonPanel1.Controls.Add(this.conditionTextBox);
            this.kryptonPanel1.Controls.Add(this.kryptonLabelSupplier);
            this.kryptonPanel1.Controls.Add(this.supplierComboBox);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(800, 608);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // itemKryptonDataGridView
            // 
            this.itemKryptonDataGridView.AllowUserToAddRows = false;
            this.itemKryptonDataGridView.AllowUserToDeleteRows = false;
            this.itemKryptonDataGridView.DataSource = this.itemBindingSource;
            this.itemKryptonDataGridView.Location = new System.Drawing.Point(21, 341);
            this.itemKryptonDataGridView.Name = "itemKryptonDataGridView";
            this.itemKryptonDataGridView.RowTemplate.Height = 24;
            this.itemKryptonDataGridView.Size = new System.Drawing.Size(758, 203);
            this.itemKryptonDataGridView.TabIndex = 22;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "item";
            this.itemBindingSource.DataSource = this.purchase_dbDataSet;
            // 
            // purchase_dbDataSet
            // 
            this.purchase_dbDataSet.DataSetName = "purchase_dbDataSet";
            this.purchase_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // header_IDTextBox
            // 
            this.header_IDTextBox.Location = new System.Drawing.Point(142, 14);
            this.header_IDTextBox.Name = "header_IDTextBox";
            this.header_IDTextBox.Size = new System.Drawing.Size(200, 22);
            this.header_IDTextBox.TabIndex = 3;
            // 
            // purchase_order_revisionComboBox
            // 
            this.purchase_order_revisionComboBox.FormattingEnabled = true;
            this.purchase_order_revisionComboBox.Location = new System.Drawing.Point(142, 42);
            this.purchase_order_revisionComboBox.Name = "purchase_order_revisionComboBox";
            this.purchase_order_revisionComboBox.Size = new System.Drawing.Size(200, 20);
            this.purchase_order_revisionComboBox.TabIndex = 5;
            // 
            // create_dateDateTimePicker
            // 
            this.create_dateDateTimePicker.Location = new System.Drawing.Point(142, 68);
            this.create_dateDateTimePicker.Name = "create_dateDateTimePicker";
            this.create_dateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.create_dateDateTimePicker.TabIndex = 7;
            // 
            // effective_datesDateTimePicker
            // 
            this.effective_datesDateTimePicker.Location = new System.Drawing.Point(142, 96);
            this.effective_datesDateTimePicker.Name = "effective_datesDateTimePicker";
            this.effective_datesDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.effective_datesDateTimePicker.TabIndex = 9;
            // 
            // supplier_IDTextBox
            // 
            this.supplier_IDTextBox.Location = new System.Drawing.Point(142, 124);
            this.supplier_IDTextBox.Name = "supplier_IDTextBox";
            this.supplier_IDTextBox.Size = new System.Drawing.Size(200, 22);
            this.supplier_IDTextBox.TabIndex = 11;
            // 
            // buyer_IDTextBox
            // 
            this.buyer_IDTextBox.Location = new System.Drawing.Point(142, 152);
            this.buyer_IDTextBox.Name = "buyer_IDTextBox";
            this.buyer_IDTextBox.Size = new System.Drawing.Size(200, 22);
            this.buyer_IDTextBox.TabIndex = 13;
            // 
            // agreed_amountTextBox
            // 
            this.agreed_amountTextBox.Location = new System.Drawing.Point(142, 180);
            this.agreed_amountTextBox.Name = "agreed_amountTextBox";
            this.agreed_amountTextBox.Size = new System.Drawing.Size(200, 22);
            this.agreed_amountTextBox.TabIndex = 15;
            // 
            // currencyTextBox
            // 
            this.currencyTextBox.Location = new System.Drawing.Point(142, 208);
            this.currencyTextBox.Name = "currencyTextBox";
            this.currencyTextBox.Size = new System.Drawing.Size(200, 22);
            this.currencyTextBox.TabIndex = 17;
            // 
            // termsTextBox
            // 
            this.termsTextBox.Location = new System.Drawing.Point(142, 236);
            this.termsTextBox.Name = "termsTextBox";
            this.termsTextBox.Size = new System.Drawing.Size(200, 22);
            this.termsTextBox.TabIndex = 19;
            // 
            // conditionTextBox
            // 
            this.conditionTextBox.Location = new System.Drawing.Point(142, 264);
            this.conditionTextBox.Name = "conditionTextBox";
            this.conditionTextBox.Size = new System.Drawing.Size(200, 22);
            this.conditionTextBox.TabIndex = 21;
            // 
            // kryptonLabelSupplier
            // 
            this.kryptonLabelSupplier.Location = new System.Drawing.Point(78, 301);
            this.kryptonLabelSupplier.Name = "kryptonLabelSupplier";
            this.kryptonLabelSupplier.Size = new System.Drawing.Size(58, 20);
            this.kryptonLabelSupplier.TabIndex = 1;
            this.kryptonLabelSupplier.Values.Text = "Supplier:";
            // 
            // supplierComboBox
            // 
            this.supplierComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.supplierBindingSource, "supplier_ID", true));
            this.supplierComboBox.DataSource = this.supplierBindingSource;
            this.supplierComboBox.DisplayMember = "name";
            this.supplierComboBox.FormattingEnabled = true;
            this.supplierComboBox.Location = new System.Drawing.Point(142, 301);
            this.supplierComboBox.Name = "supplierComboBox";
            this.supplierComboBox.Size = new System.Drawing.Size(72, 20);
            this.supplierComboBox.TabIndex = 0;
            this.supplierComboBox.ValueMember = "supplier_ID";
            this.supplierComboBox.SelectedIndexChanged += new System.EventHandler(this.supplierComboBox_SelectedIndexChanged);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "supplier";
            this.supplierBindingSource.DataSource = this.purchase_dbDataSet;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bpa_headerTableAdapter = null;
            this.tableAdapterManager.bpa_linesTableAdapter = this.bpa_linesTableAdapter;
            this.tableAdapterManager.itemTableAdapter = this.itemTableAdapter;
            this.tableAdapterManager.supplierTableAdapter = this.supplierTableAdapter;
            this.tableAdapterManager.UpdateOrder = ITP4915_group3_project.purchase_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // bpa_linesTableAdapter
            // 
            this.bpa_linesTableAdapter.ClearBeforeFill = true;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // bpa_linesBindingSource
            // 
            this.bpa_linesBindingSource.DataMember = "bpa_lines";
            this.bpa_linesBindingSource.DataSource = this.purchase_dbDataSet;
            // 
            // create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "create";
            this.Size = new System.Drawing.Size(800, 608);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemKryptonDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpa_linesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private purchase_dbDataSet purchase_dbDataSet;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private purchase_dbDataSetTableAdapters.supplierTableAdapter supplierTableAdapter;
        private purchase_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox supplierComboBox;
        private Krypton.Toolkit.KryptonLabel kryptonLabelSupplier;
        private System.Windows.Forms.TextBox header_IDTextBox;
        private System.Windows.Forms.ComboBox purchase_order_revisionComboBox;
        private System.Windows.Forms.DateTimePicker create_dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker effective_datesDateTimePicker;
        private System.Windows.Forms.TextBox supplier_IDTextBox;
        private System.Windows.Forms.TextBox buyer_IDTextBox;
        private System.Windows.Forms.TextBox agreed_amountTextBox;
        private System.Windows.Forms.TextBox currencyTextBox;
        private System.Windows.Forms.TextBox termsTextBox;
        private System.Windows.Forms.TextBox conditionTextBox;
        private Krypton.Toolkit.KryptonDataGridView itemKryptonDataGridView;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private purchase_dbDataSetTableAdapters.bpa_linesTableAdapter bpa_linesTableAdapter;
        private purchase_dbDataSetTableAdapters.itemTableAdapter itemTableAdapter;
        private System.Windows.Forms.BindingSource bpa_linesBindingSource;
    }
}
