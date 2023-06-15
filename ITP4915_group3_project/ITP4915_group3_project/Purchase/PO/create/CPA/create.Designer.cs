
namespace ITP4915_group3_project.Purchase.PO.create.CPA
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
            System.Windows.Forms.Label create_dateLabel;
            System.Windows.Forms.Label effective_dateLabel;
            System.Windows.Forms.Label supplier_IDLabel;
            System.Windows.Forms.Label buyer_IDLabel;
            System.Windows.Forms.Label termsLabel;
            System.Windows.Forms.Label conditionLabel;
            System.Windows.Forms.Label item_IDLabel;
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.item_IDComboBox = new System.Windows.Forms.ComboBox();
            this.cpaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchase_dbDataSet = new ITP4915_group3_project.purchase_dbDataSet();
            this.itemsupplierIDfkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conditionTextBox = new System.Windows.Forms.TextBox();
            this.termsTextBox = new System.Windows.Forms.TextBox();
            this.buyer_IDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.supplier_IDComboBox = new System.Windows.Forms.ComboBox();
            this.effective_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.create_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cpaTableAdapter = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.cpaTableAdapter();
            this.tableAdapterManager = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.TableAdapterManager();
            this.itemTableAdapter = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.itemTableAdapter();
            this.supplierTableAdapter = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.supplierTableAdapter();
            this.kryptonButtonSubmit = new Krypton.Toolkit.KryptonButton();
            create_dateLabel = new System.Windows.Forms.Label();
            effective_dateLabel = new System.Windows.Forms.Label();
            supplier_IDLabel = new System.Windows.Forms.Label();
            buyer_IDLabel = new System.Windows.Forms.Label();
            termsLabel = new System.Windows.Forms.Label();
            conditionLabel = new System.Windows.Forms.Label();
            item_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsupplierIDfkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyer_IDNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // create_dateLabel
            // 
            create_dateLabel.AutoSize = true;
            create_dateLabel.Location = new System.Drawing.Point(65, 125);
            create_dateLabel.Name = "create_dateLabel";
            create_dateLabel.Size = new System.Drawing.Size(57, 12);
            create_dateLabel.TabIndex = 0;
            create_dateLabel.Text = "create date:";
            // 
            // effective_dateLabel
            // 
            effective_dateLabel.AutoSize = true;
            effective_dateLabel.Location = new System.Drawing.Point(52, 153);
            effective_dateLabel.Name = "effective_dateLabel";
            effective_dateLabel.Size = new System.Drawing.Size(70, 12);
            effective_dateLabel.TabIndex = 2;
            effective_dateLabel.Text = "effective date:";
            // 
            // supplier_IDLabel
            // 
            supplier_IDLabel.AutoSize = true;
            supplier_IDLabel.Location = new System.Drawing.Point(387, 124);
            supplier_IDLabel.Name = "supplier_IDLabel";
            supplier_IDLabel.Size = new System.Drawing.Size(60, 12);
            supplier_IDLabel.TabIndex = 4;
            supplier_IDLabel.Text = "supplier ID:";
            // 
            // buyer_IDLabel
            // 
            buyer_IDLabel.AutoSize = true;
            buyer_IDLabel.Location = new System.Drawing.Point(72, 64);
            buyer_IDLabel.Name = "buyer_IDLabel";
            buyer_IDLabel.Size = new System.Drawing.Size(50, 12);
            buyer_IDLabel.TabIndex = 6;
            buyer_IDLabel.Text = "buyer ID:";
            // 
            // termsLabel
            // 
            termsLabel.AutoSize = true;
            termsLabel.Location = new System.Drawing.Point(89, 206);
            termsLabel.Name = "termsLabel";
            termsLabel.Size = new System.Drawing.Size(33, 12);
            termsLabel.TabIndex = 8;
            termsLabel.Text = "terms:";
            // 
            // conditionLabel
            // 
            conditionLabel.AutoSize = true;
            conditionLabel.Location = new System.Drawing.Point(70, 244);
            conditionLabel.Name = "conditionLabel";
            conditionLabel.Size = new System.Drawing.Size(52, 12);
            conditionLabel.TabIndex = 10;
            conditionLabel.Text = "condition:";
            // 
            // item_IDLabel
            // 
            item_IDLabel.AutoSize = true;
            item_IDLabel.Location = new System.Drawing.Point(404, 156);
            item_IDLabel.Name = "item_IDLabel";
            item_IDLabel.Size = new System.Drawing.Size(43, 12);
            item_IDLabel.TabIndex = 12;
            item_IDLabel.Text = "item ID:";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonButtonSubmit);
            this.kryptonPanel1.Controls.Add(item_IDLabel);
            this.kryptonPanel1.Controls.Add(this.item_IDComboBox);
            this.kryptonPanel1.Controls.Add(conditionLabel);
            this.kryptonPanel1.Controls.Add(this.conditionTextBox);
            this.kryptonPanel1.Controls.Add(termsLabel);
            this.kryptonPanel1.Controls.Add(this.termsTextBox);
            this.kryptonPanel1.Controls.Add(buyer_IDLabel);
            this.kryptonPanel1.Controls.Add(this.buyer_IDNumericUpDown);
            this.kryptonPanel1.Controls.Add(supplier_IDLabel);
            this.kryptonPanel1.Controls.Add(this.supplier_IDComboBox);
            this.kryptonPanel1.Controls.Add(effective_dateLabel);
            this.kryptonPanel1.Controls.Add(this.effective_dateDateTimePicker);
            this.kryptonPanel1.Controls.Add(create_dateLabel);
            this.kryptonPanel1.Controls.Add(this.create_dateDateTimePicker);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(800, 500);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // item_IDComboBox
            // 
            this.item_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cpaBindingSource, "item_ID", true));
            this.item_IDComboBox.DataSource = this.itemsupplierIDfkBindingSource;
            this.item_IDComboBox.DisplayMember = "item_name";
            this.item_IDComboBox.FormattingEnabled = true;
            this.item_IDComboBox.Location = new System.Drawing.Point(453, 153);
            this.item_IDComboBox.Name = "item_IDComboBox";
            this.item_IDComboBox.Size = new System.Drawing.Size(121, 20);
            this.item_IDComboBox.TabIndex = 13;
            this.item_IDComboBox.ValueMember = "item_ID";
            // 
            // cpaBindingSource
            // 
            this.cpaBindingSource.DataMember = "cpa";
            this.cpaBindingSource.DataSource = this.purchase_dbDataSet;
            // 
            // purchase_dbDataSet
            // 
            this.purchase_dbDataSet.DataSetName = "purchase_dbDataSet";
            this.purchase_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsupplierIDfkBindingSource
            // 
            this.itemsupplierIDfkBindingSource.DataMember = "item_supplier_ID_fk";
            this.itemsupplierIDfkBindingSource.DataSource = this.supplierBindingSource;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "supplier";
            this.supplierBindingSource.DataSource = this.purchase_dbDataSet;
            // 
            // conditionTextBox
            // 
            this.conditionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cpaBindingSource, "condition", true));
            this.conditionTextBox.Location = new System.Drawing.Point(128, 241);
            this.conditionTextBox.Name = "conditionTextBox";
            this.conditionTextBox.Size = new System.Drawing.Size(100, 22);
            this.conditionTextBox.TabIndex = 11;
            // 
            // termsTextBox
            // 
            this.termsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cpaBindingSource, "terms", true));
            this.termsTextBox.Location = new System.Drawing.Point(128, 203);
            this.termsTextBox.Name = "termsTextBox";
            this.termsTextBox.Size = new System.Drawing.Size(100, 22);
            this.termsTextBox.TabIndex = 9;
            // 
            // buyer_IDNumericUpDown
            // 
            this.buyer_IDNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cpaBindingSource, "buyer_ID", true));
            this.buyer_IDNumericUpDown.InterceptArrowKeys = false;
            this.buyer_IDNumericUpDown.Location = new System.Drawing.Point(128, 64);
            this.buyer_IDNumericUpDown.Name = "buyer_IDNumericUpDown";
            this.buyer_IDNumericUpDown.ReadOnly = true;
            this.buyer_IDNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.buyer_IDNumericUpDown.TabIndex = 7;
            // 
            // supplier_IDComboBox
            // 
            this.supplier_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cpaBindingSource, "supplier_ID", true));
            this.supplier_IDComboBox.DataSource = this.supplierBindingSource;
            this.supplier_IDComboBox.DisplayMember = "name";
            this.supplier_IDComboBox.FormattingEnabled = true;
            this.supplier_IDComboBox.Location = new System.Drawing.Point(453, 121);
            this.supplier_IDComboBox.Name = "supplier_IDComboBox";
            this.supplier_IDComboBox.Size = new System.Drawing.Size(121, 20);
            this.supplier_IDComboBox.TabIndex = 5;
            this.supplier_IDComboBox.ValueMember = "supplier_ID";
            // 
            // effective_dateDateTimePicker
            // 
            this.effective_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cpaBindingSource, "effective_date", true));
            this.effective_dateDateTimePicker.Location = new System.Drawing.Point(128, 149);
            this.effective_dateDateTimePicker.Name = "effective_dateDateTimePicker";
            this.effective_dateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.effective_dateDateTimePicker.TabIndex = 3;
            // 
            // create_dateDateTimePicker
            // 
            this.create_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cpaBindingSource, "create_date", true));
            this.create_dateDateTimePicker.Location = new System.Drawing.Point(128, 121);
            this.create_dateDateTimePicker.Name = "create_dateDateTimePicker";
            this.create_dateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.create_dateDateTimePicker.TabIndex = 1;
            // 
            // cpaTableAdapter
            // 
            this.cpaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bpa_headerTableAdapter = null;
            this.tableAdapterManager.bpa_linesTableAdapter = null;
            this.tableAdapterManager.cpaTableAdapter = this.cpaTableAdapter;
            this.tableAdapterManager.itemTableAdapter = this.itemTableAdapter;
            this.tableAdapterManager.supplierTableAdapter = this.supplierTableAdapter;
            this.tableAdapterManager.UpdateOrder = ITP4915_group3_project.purchase_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // kryptonButtonSubmit
            // 
            this.kryptonButtonSubmit.CornerRoundingRadius = -1F;
            this.kryptonButtonSubmit.Location = new System.Drawing.Point(625, 412);
            this.kryptonButtonSubmit.Name = "kryptonButtonSubmit";
            this.kryptonButtonSubmit.Size = new System.Drawing.Size(90, 25);
            this.kryptonButtonSubmit.TabIndex = 14;
            this.kryptonButtonSubmit.Values.Text = "Submit";
            this.kryptonButtonSubmit.Click += new System.EventHandler(this.kryptonButtonSubmit_Click);
            // 
            // create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "create";
            this.Size = new System.Drawing.Size(800, 500);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsupplierIDfkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyer_IDNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private purchase_dbDataSet purchase_dbDataSet;
        private System.Windows.Forms.BindingSource cpaBindingSource;
        private purchase_dbDataSetTableAdapters.cpaTableAdapter cpaTableAdapter;
        private purchase_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox item_IDComboBox;
        private System.Windows.Forms.TextBox conditionTextBox;
        private System.Windows.Forms.TextBox termsTextBox;
        private System.Windows.Forms.NumericUpDown buyer_IDNumericUpDown;
        private System.Windows.Forms.ComboBox supplier_IDComboBox;
        private System.Windows.Forms.DateTimePicker effective_dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker create_dateDateTimePicker;
        private System.Windows.Forms.BindingSource itemsupplierIDfkBindingSource;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private purchase_dbDataSetTableAdapters.itemTableAdapter itemTableAdapter;
        private purchase_dbDataSetTableAdapters.supplierTableAdapter supplierTableAdapter;
        private Krypton.Toolkit.KryptonButton kryptonButtonSubmit;
    }
}
