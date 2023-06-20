
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
            this.kryptonButtonSave = new Krypton.Toolkit.KryptonButton();
            this.cPA_IDTextBox = new System.Windows.Forms.TextBox();
            this.cpaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchase_dbDataSet = new ITP4915_group3_project.purchase_dbDataSet();
            this.create_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.effective_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.termsTextBox = new System.Windows.Forms.TextBox();
            this.conditionTextBox = new System.Windows.Forms.TextBox();
            this.cpaTableAdapter = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.cpaTableAdapter();
            this.tableAdapterManager = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.TableAdapterManager();
            this.kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            this.kryptonCheckSet1 = new Krypton.Toolkit.KryptonCheckSet(this.components);
            this.supplier_IDKryptonTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.buyer_IDKryptonTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.item_IDKryptonTextBox = new Krypton.Toolkit.KryptonTextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.cpaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonCheckSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // cPA_IDLabel
            // 
            cPA_IDLabel.AutoSize = true;
            cPA_IDLabel.Location = new System.Drawing.Point(143, 38);
            cPA_IDLabel.Name = "cPA_IDLabel";
            cPA_IDLabel.Size = new System.Drawing.Size(45, 12);
            cPA_IDLabel.TabIndex = 0;
            cPA_IDLabel.Text = "CPA ID:";
            // 
            // create_dateLabel
            // 
            create_dateLabel.AutoSize = true;
            create_dateLabel.Location = new System.Drawing.Point(143, 67);
            create_dateLabel.Name = "create_dateLabel";
            create_dateLabel.Size = new System.Drawing.Size(57, 12);
            create_dateLabel.TabIndex = 2;
            create_dateLabel.Text = "create date:";
            // 
            // effective_dateLabel
            // 
            effective_dateLabel.AutoSize = true;
            effective_dateLabel.Location = new System.Drawing.Point(143, 95);
            effective_dateLabel.Name = "effective_dateLabel";
            effective_dateLabel.Size = new System.Drawing.Size(70, 12);
            effective_dateLabel.TabIndex = 4;
            effective_dateLabel.Text = "effective date:";
            // 
            // supplier_IDLabel
            // 
            supplier_IDLabel.AutoSize = true;
            supplier_IDLabel.Location = new System.Drawing.Point(143, 122);
            supplier_IDLabel.Name = "supplier_IDLabel";
            supplier_IDLabel.Size = new System.Drawing.Size(60, 12);
            supplier_IDLabel.TabIndex = 6;
            supplier_IDLabel.Text = "supplier ID:";
            // 
            // buyer_IDLabel
            // 
            buyer_IDLabel.AutoSize = true;
            buyer_IDLabel.Location = new System.Drawing.Point(143, 145);
            buyer_IDLabel.Name = "buyer_IDLabel";
            buyer_IDLabel.Size = new System.Drawing.Size(50, 12);
            buyer_IDLabel.TabIndex = 8;
            buyer_IDLabel.Text = "buyer ID:";
            // 
            // termsLabel
            // 
            termsLabel.AutoSize = true;
            termsLabel.Location = new System.Drawing.Point(143, 175);
            termsLabel.Name = "termsLabel";
            termsLabel.Size = new System.Drawing.Size(33, 12);
            termsLabel.TabIndex = 10;
            termsLabel.Text = "terms:";
            // 
            // conditionLabel
            // 
            conditionLabel.AutoSize = true;
            conditionLabel.Location = new System.Drawing.Point(143, 203);
            conditionLabel.Name = "conditionLabel";
            conditionLabel.Size = new System.Drawing.Size(52, 12);
            conditionLabel.TabIndex = 12;
            conditionLabel.Text = "condition:";
            // 
            // item_IDLabel
            // 
            item_IDLabel.AutoSize = true;
            item_IDLabel.Location = new System.Drawing.Point(143, 231);
            item_IDLabel.Name = "item_IDLabel";
            item_IDLabel.Size = new System.Drawing.Size(43, 12);
            item_IDLabel.TabIndex = 14;
            item_IDLabel.Text = "item ID:";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPanel1.Controls.Add(this.kryptonButtonSave);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(800, 500);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonButtonSave
            // 
            this.kryptonButtonSave.CornerRoundingRadius = 25F;
            this.kryptonButtonSave.Location = new System.Drawing.Point(646, 41);
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
            this.kryptonButtonSave.Click += new System.EventHandler(this.kryptonButtonSave_Click);
            // 
            // cPA_IDTextBox
            // 
            this.cPA_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cpaBindingSource, "CPA_ID", true));
            this.cPA_IDTextBox.Location = new System.Drawing.Point(219, 35);
            this.cPA_IDTextBox.Name = "cPA_IDTextBox";
            this.cPA_IDTextBox.ReadOnly = true;
            this.cPA_IDTextBox.Size = new System.Drawing.Size(200, 22);
            this.cPA_IDTextBox.TabIndex = 1;
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
            // create_dateDateTimePicker
            // 
            this.create_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cpaBindingSource, "create_date", true));
            this.create_dateDateTimePicker.Location = new System.Drawing.Point(219, 63);
            this.create_dateDateTimePicker.Name = "create_dateDateTimePicker";
            this.create_dateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.create_dateDateTimePicker.TabIndex = 3;
            // 
            // effective_dateDateTimePicker
            // 
            this.effective_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cpaBindingSource, "effective_date", true));
            this.effective_dateDateTimePicker.Location = new System.Drawing.Point(219, 91);
            this.effective_dateDateTimePicker.Name = "effective_dateDateTimePicker";
            this.effective_dateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.effective_dateDateTimePicker.TabIndex = 5;
            // 
            // termsTextBox
            // 
            this.termsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cpaBindingSource, "terms", true));
            this.termsTextBox.Location = new System.Drawing.Point(219, 172);
            this.termsTextBox.Name = "termsTextBox";
            this.termsTextBox.Size = new System.Drawing.Size(200, 22);
            this.termsTextBox.TabIndex = 11;
            // 
            // conditionTextBox
            // 
            this.conditionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cpaBindingSource, "condition", true));
            this.conditionTextBox.Location = new System.Drawing.Point(219, 200);
            this.conditionTextBox.Name = "conditionTextBox";
            this.conditionTextBox.Size = new System.Drawing.Size(200, 22);
            this.conditionTextBox.TabIndex = 13;
            // 
            // cpaTableAdapter
            // 
            this.cpaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.blanket_releaseTableAdapter = null;
            this.tableAdapterManager.bpa_headerTableAdapter = null;
            this.tableAdapterManager.bpa_linesTableAdapter = null;
            this.tableAdapterManager.cpaTableAdapter = this.cpaTableAdapter;
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
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.CaptionStyle = Krypton.Toolkit.LabelStyle.GroupBoxCaption;
            this.kryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlGroupBox;
            this.kryptonGroupBox1.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.ControlGroupBox;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(67, 89);
            this.kryptonGroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.AutoScroll = true;
            this.kryptonGroupBox1.Panel.Controls.Add(this.item_IDKryptonTextBox);
            this.kryptonGroupBox1.Panel.Controls.Add(this.buyer_IDKryptonTextBox);
            this.kryptonGroupBox1.Panel.Controls.Add(this.supplier_IDKryptonTextBox);
            this.kryptonGroupBox1.Panel.Controls.Add(cPA_IDLabel);
            this.kryptonGroupBox1.Panel.Controls.Add(item_IDLabel);
            this.kryptonGroupBox1.Panel.Controls.Add(this.cPA_IDTextBox);
            this.kryptonGroupBox1.Panel.Controls.Add(this.conditionTextBox);
            this.kryptonGroupBox1.Panel.Controls.Add(create_dateLabel);
            this.kryptonGroupBox1.Panel.Controls.Add(conditionLabel);
            this.kryptonGroupBox1.Panel.Controls.Add(this.create_dateDateTimePicker);
            this.kryptonGroupBox1.Panel.Controls.Add(this.termsTextBox);
            this.kryptonGroupBox1.Panel.Controls.Add(effective_dateLabel);
            this.kryptonGroupBox1.Panel.Controls.Add(termsLabel);
            this.kryptonGroupBox1.Panel.Controls.Add(this.effective_dateDateTimePicker);
            this.kryptonGroupBox1.Panel.Controls.Add(supplier_IDLabel);
            this.kryptonGroupBox1.Panel.Controls.Add(buyer_IDLabel);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(622, 341);
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
            this.kryptonGroupBox1.TabIndex = 232;
            this.kryptonGroupBox1.Values.Heading = "CPA";
            // 
            // supplier_IDKryptonTextBox
            // 
            this.supplier_IDKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cpaBindingSource, "supplier_ID", true));
            this.supplier_IDKryptonTextBox.Location = new System.Drawing.Point(219, 116);
            this.supplier_IDKryptonTextBox.Name = "supplier_IDKryptonTextBox";
            this.supplier_IDKryptonTextBox.ReadOnly = true;
            this.supplier_IDKryptonTextBox.Size = new System.Drawing.Size(200, 23);
            this.supplier_IDKryptonTextBox.TabIndex = 16;
            // 
            // buyer_IDKryptonTextBox
            // 
            this.buyer_IDKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cpaBindingSource, "buyer_ID", true));
            this.buyer_IDKryptonTextBox.Location = new System.Drawing.Point(219, 143);
            this.buyer_IDKryptonTextBox.Name = "buyer_IDKryptonTextBox";
            this.buyer_IDKryptonTextBox.ReadOnly = true;
            this.buyer_IDKryptonTextBox.Size = new System.Drawing.Size(200, 23);
            this.buyer_IDKryptonTextBox.TabIndex = 17;
            // 
            // item_IDKryptonTextBox
            // 
            this.item_IDKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cpaBindingSource, "item_ID", true));
            this.item_IDKryptonTextBox.Location = new System.Drawing.Point(219, 231);
            this.item_IDKryptonTextBox.Name = "item_IDKryptonTextBox";
            this.item_IDKryptonTextBox.ReadOnly = true;
            this.item_IDKryptonTextBox.Size = new System.Drawing.Size(200, 23);
            this.item_IDKryptonTextBox.TabIndex = 18;
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
            ((System.ComponentModel.ISupportInitialize)(this.cpaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonCheckSet1)).EndInit();
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
        private System.Windows.Forms.TextBox termsTextBox;
        private System.Windows.Forms.TextBox conditionTextBox;
        private Krypton.Toolkit.KryptonButton kryptonButtonSave;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private Krypton.Toolkit.KryptonTextBox buyer_IDKryptonTextBox;
        private Krypton.Toolkit.KryptonTextBox supplier_IDKryptonTextBox;
        private Krypton.Toolkit.KryptonCheckSet kryptonCheckSet1;
        private Krypton.Toolkit.KryptonTextBox item_IDKryptonTextBox;
    }
}
