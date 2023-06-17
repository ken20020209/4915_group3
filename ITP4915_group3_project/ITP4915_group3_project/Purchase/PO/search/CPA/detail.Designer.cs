
namespace ITP4915_group3_project.Purchase.PO.search.CPA
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
            System.Windows.Forms.Label cPA_IDLabel;
            System.Windows.Forms.Label create_dateLabel;
            System.Windows.Forms.Label effective_dateLabel;
            System.Windows.Forms.Label supplier_IDLabel;
            System.Windows.Forms.Label buyer_IDLabel;
            System.Windows.Forms.Label termsLabel;
            System.Windows.Forms.Label conditionLabel;
            System.Windows.Forms.Label item_IDLabel;
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.purchase_dbDataSet = new ITP4915_group3_project.purchase_dbDataSet();
            this.cpaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cpaTableAdapter = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.cpaTableAdapter();
            this.tableAdapterManager = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.TableAdapterManager();
            this.cPA_IDTextBox = new System.Windows.Forms.TextBox();
            this.create_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.effective_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.supplier_IDComboBox = new System.Windows.Forms.ComboBox();
            this.buyer_IDKryptonNumericUpDown = new Krypton.Toolkit.KryptonNumericUpDown();
            this.termsTextBox = new System.Windows.Forms.TextBox();
            this.conditionTextBox = new System.Windows.Forms.TextBox();
            this.item_IDComboBox = new System.Windows.Forms.ComboBox();
            this.kryptonButtonSave = new Krypton.Toolkit.KryptonButton();
            cPA_IDLabel = new System.Windows.Forms.Label();
            create_dateLabel = new System.Windows.Forms.Label();
            effective_dateLabel = new System.Windows.Forms.Label();
            supplier_IDLabel = new System.Windows.Forms.Label();
            buyer_IDLabel = new System.Windows.Forms.Label();
            termsLabel = new System.Windows.Forms.Label();
            conditionLabel = new System.Windows.Forms.Label();
            item_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonButtonSave);
            this.kryptonPanel1.Controls.Add(cPA_IDLabel);
            this.kryptonPanel1.Controls.Add(this.cPA_IDTextBox);
            this.kryptonPanel1.Controls.Add(create_dateLabel);
            this.kryptonPanel1.Controls.Add(this.create_dateDateTimePicker);
            this.kryptonPanel1.Controls.Add(effective_dateLabel);
            this.kryptonPanel1.Controls.Add(this.effective_dateDateTimePicker);
            this.kryptonPanel1.Controls.Add(supplier_IDLabel);
            this.kryptonPanel1.Controls.Add(this.supplier_IDComboBox);
            this.kryptonPanel1.Controls.Add(buyer_IDLabel);
            this.kryptonPanel1.Controls.Add(this.buyer_IDKryptonNumericUpDown);
            this.kryptonPanel1.Controls.Add(termsLabel);
            this.kryptonPanel1.Controls.Add(this.termsTextBox);
            this.kryptonPanel1.Controls.Add(conditionLabel);
            this.kryptonPanel1.Controls.Add(this.conditionTextBox);
            this.kryptonPanel1.Controls.Add(item_IDLabel);
            this.kryptonPanel1.Controls.Add(this.item_IDComboBox);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(800, 500);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // purchase_dbDataSet
            // 
            this.purchase_dbDataSet.DataSetName = "purchase_dbDataSet";
            this.purchase_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cpaBindingSource
            // 
            this.cpaBindingSource.DataMember = "cpa";
            this.cpaBindingSource.DataSource = this.purchase_dbDataSet;
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
            this.tableAdapterManager.itemTableAdapter = null;
            this.tableAdapterManager.ppo_headerTableAdapter = null;
            this.tableAdapterManager.ppo_linesTableAdapter = null;
            this.tableAdapterManager.spo_headerTableAdapter = null;
            this.tableAdapterManager.spo_linesTableAdapter = null;
            this.tableAdapterManager.supplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ITP4915_group3_project.purchase_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // cPA_IDLabel
            // 
            cPA_IDLabel.AutoSize = true;
            cPA_IDLabel.Location = new System.Drawing.Point(174, 138);
            cPA_IDLabel.Name = "cPA_IDLabel";
            cPA_IDLabel.Size = new System.Drawing.Size(45, 12);
            cPA_IDLabel.TabIndex = 0;
            cPA_IDLabel.Text = "CPA ID:";
            // 
            // cPA_IDTextBox
            // 
            this.cPA_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cpaBindingSource, "CPA_ID", true));
            this.cPA_IDTextBox.Location = new System.Drawing.Point(250, 135);
            this.cPA_IDTextBox.Name = "cPA_IDTextBox";
            this.cPA_IDTextBox.Size = new System.Drawing.Size(200, 22);
            this.cPA_IDTextBox.TabIndex = 1;
            // 
            // create_dateLabel
            // 
            create_dateLabel.AutoSize = true;
            create_dateLabel.Location = new System.Drawing.Point(174, 167);
            create_dateLabel.Name = "create_dateLabel";
            create_dateLabel.Size = new System.Drawing.Size(57, 12);
            create_dateLabel.TabIndex = 2;
            create_dateLabel.Text = "create date:";
            // 
            // create_dateDateTimePicker
            // 
            this.create_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cpaBindingSource, "create_date", true));
            this.create_dateDateTimePicker.Location = new System.Drawing.Point(250, 163);
            this.create_dateDateTimePicker.Name = "create_dateDateTimePicker";
            this.create_dateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.create_dateDateTimePicker.TabIndex = 3;
            // 
            // effective_dateLabel
            // 
            effective_dateLabel.AutoSize = true;
            effective_dateLabel.Location = new System.Drawing.Point(174, 195);
            effective_dateLabel.Name = "effective_dateLabel";
            effective_dateLabel.Size = new System.Drawing.Size(70, 12);
            effective_dateLabel.TabIndex = 4;
            effective_dateLabel.Text = "effective date:";
            // 
            // effective_dateDateTimePicker
            // 
            this.effective_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cpaBindingSource, "effective_date", true));
            this.effective_dateDateTimePicker.Location = new System.Drawing.Point(250, 191);
            this.effective_dateDateTimePicker.Name = "effective_dateDateTimePicker";
            this.effective_dateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.effective_dateDateTimePicker.TabIndex = 5;
            // 
            // supplier_IDLabel
            // 
            supplier_IDLabel.AutoSize = true;
            supplier_IDLabel.Location = new System.Drawing.Point(174, 222);
            supplier_IDLabel.Name = "supplier_IDLabel";
            supplier_IDLabel.Size = new System.Drawing.Size(60, 12);
            supplier_IDLabel.TabIndex = 6;
            supplier_IDLabel.Text = "supplier ID:";
            // 
            // supplier_IDComboBox
            // 
            this.supplier_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cpaBindingSource, "supplier_ID", true));
            this.supplier_IDComboBox.FormattingEnabled = true;
            this.supplier_IDComboBox.Location = new System.Drawing.Point(250, 219);
            this.supplier_IDComboBox.Name = "supplier_IDComboBox";
            this.supplier_IDComboBox.Size = new System.Drawing.Size(200, 20);
            this.supplier_IDComboBox.TabIndex = 7;
            // 
            // buyer_IDLabel
            // 
            buyer_IDLabel.AutoSize = true;
            buyer_IDLabel.Location = new System.Drawing.Point(174, 245);
            buyer_IDLabel.Name = "buyer_IDLabel";
            buyer_IDLabel.Size = new System.Drawing.Size(50, 12);
            buyer_IDLabel.TabIndex = 8;
            buyer_IDLabel.Text = "buyer ID:";
            // 
            // buyer_IDKryptonNumericUpDown
            // 
            this.buyer_IDKryptonNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cpaBindingSource, "buyer_ID", true));
            this.buyer_IDKryptonNumericUpDown.Location = new System.Drawing.Point(250, 245);
            this.buyer_IDKryptonNumericUpDown.Name = "buyer_IDKryptonNumericUpDown";
            this.buyer_IDKryptonNumericUpDown.Size = new System.Drawing.Size(200, 22);
            this.buyer_IDKryptonNumericUpDown.TabIndex = 9;
            // 
            // termsLabel
            // 
            termsLabel.AutoSize = true;
            termsLabel.Location = new System.Drawing.Point(174, 275);
            termsLabel.Name = "termsLabel";
            termsLabel.Size = new System.Drawing.Size(33, 12);
            termsLabel.TabIndex = 10;
            termsLabel.Text = "terms:";
            // 
            // termsTextBox
            // 
            this.termsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cpaBindingSource, "terms", true));
            this.termsTextBox.Location = new System.Drawing.Point(250, 272);
            this.termsTextBox.Name = "termsTextBox";
            this.termsTextBox.Size = new System.Drawing.Size(200, 22);
            this.termsTextBox.TabIndex = 11;
            // 
            // conditionLabel
            // 
            conditionLabel.AutoSize = true;
            conditionLabel.Location = new System.Drawing.Point(174, 303);
            conditionLabel.Name = "conditionLabel";
            conditionLabel.Size = new System.Drawing.Size(52, 12);
            conditionLabel.TabIndex = 12;
            conditionLabel.Text = "condition:";
            // 
            // conditionTextBox
            // 
            this.conditionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cpaBindingSource, "condition", true));
            this.conditionTextBox.Location = new System.Drawing.Point(250, 300);
            this.conditionTextBox.Name = "conditionTextBox";
            this.conditionTextBox.Size = new System.Drawing.Size(200, 22);
            this.conditionTextBox.TabIndex = 13;
            // 
            // item_IDLabel
            // 
            item_IDLabel.AutoSize = true;
            item_IDLabel.Location = new System.Drawing.Point(174, 331);
            item_IDLabel.Name = "item_IDLabel";
            item_IDLabel.Size = new System.Drawing.Size(43, 12);
            item_IDLabel.TabIndex = 14;
            item_IDLabel.Text = "item ID:";
            // 
            // item_IDComboBox
            // 
            this.item_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cpaBindingSource, "item_ID", true));
            this.item_IDComboBox.FormattingEnabled = true;
            this.item_IDComboBox.Location = new System.Drawing.Point(250, 328);
            this.item_IDComboBox.Name = "item_IDComboBox";
            this.item_IDComboBox.Size = new System.Drawing.Size(200, 20);
            this.item_IDComboBox.TabIndex = 15;
            // 
            // kryptonButtonSave
            // 
            this.kryptonButtonSave.CornerRoundingRadius = 25F;
            this.kryptonButtonSave.Location = new System.Drawing.Point(628, 63);
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
            this.kryptonButtonSave.Click += new System.EventHandler(this.kryptonButtonSave_Click);
            // 
            // detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "detail";
            this.Size = new System.Drawing.Size(800, 500);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private purchase_dbDataSet purchase_dbDataSet;
        private System.Windows.Forms.BindingSource cpaBindingSource;
        private purchase_dbDataSetTableAdapters.cpaTableAdapter cpaTableAdapter;
        private purchase_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cPA_IDTextBox;
        private System.Windows.Forms.DateTimePicker create_dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker effective_dateDateTimePicker;
        private System.Windows.Forms.ComboBox supplier_IDComboBox;
        private Krypton.Toolkit.KryptonNumericUpDown buyer_IDKryptonNumericUpDown;
        private System.Windows.Forms.TextBox termsTextBox;
        private System.Windows.Forms.TextBox conditionTextBox;
        private System.Windows.Forms.ComboBox item_IDComboBox;
        private Krypton.Toolkit.KryptonButton kryptonButtonSave;
    }
}
