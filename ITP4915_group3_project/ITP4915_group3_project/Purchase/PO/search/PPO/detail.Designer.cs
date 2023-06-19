
namespace ITP4915_group3_project.Purchase.PO.search.PPO
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
            System.Windows.Forms.Label conditionLabel;
            System.Windows.Forms.Label termLabel;
            System.Windows.Forms.Label currencyLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label tentative_schedulesLabel;
            System.Windows.Forms.Label buyer_IDLabel;
            System.Windows.Forms.Label supplier_IDLabel;
            System.Windows.Forms.Label effective_dateLabel;
            System.Windows.Forms.Label create_dateLabel;
            System.Windows.Forms.Label purchase_order_revision_IDLabel;
            System.Windows.Forms.Label header_IDLabel;
            this.purchase_dbDataSet = new ITP4915_group3_project.purchase_dbDataSet();
            this.ppo_headerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ppo_headerTableAdapter = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.ppo_headerTableAdapter();
            this.tableAdapterManager = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.TableAdapterManager();
            this.tentative_schedulesKryptonDateTimePicker = new Krypton.Toolkit.KryptonDateTimePicker();
            this.effective_dateKryptonDateTimePicker = new Krypton.Toolkit.KryptonDateTimePicker();
            this.create_dateKryptonDateTimePicker = new Krypton.Toolkit.KryptonDateTimePicker();
            this.purchase_order_revision_IDKryptonCheckBox = new Krypton.Toolkit.KryptonCheckBox();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.ppo_linesKryptonDataGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.ppo_linesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kryptonButtonSave = new Krypton.Toolkit.KryptonButton();
            this.header_IDKryptonNumericUpDown = new Krypton.Toolkit.KryptonNumericUpDown();
            this.supplier_IDKryptonNumericUpDown = new Krypton.Toolkit.KryptonNumericUpDown();
            this.buyer_IDKryptonNumericUpDown = new Krypton.Toolkit.KryptonNumericUpDown();
            this.amountKryptonNumericUpDown = new Krypton.Toolkit.KryptonNumericUpDown();
            this.currencyKryptonNumericUpDown = new Krypton.Toolkit.KryptonNumericUpDown();
            this.termKryptonTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.conditionKryptonTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.ppo_linesTableAdapter = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.ppo_linesTableAdapter();
            conditionLabel = new System.Windows.Forms.Label();
            termLabel = new System.Windows.Forms.Label();
            currencyLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            tentative_schedulesLabel = new System.Windows.Forms.Label();
            buyer_IDLabel = new System.Windows.Forms.Label();
            supplier_IDLabel = new System.Windows.Forms.Label();
            effective_dateLabel = new System.Windows.Forms.Label();
            create_dateLabel = new System.Windows.Forms.Label();
            purchase_order_revision_IDLabel = new System.Windows.Forms.Label();
            header_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppo_headerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ppo_linesKryptonDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppo_linesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // conditionLabel
            // 
            conditionLabel.AutoSize = true;
            conditionLabel.Location = new System.Drawing.Point(24, 330);
            conditionLabel.Name = "conditionLabel";
            conditionLabel.Size = new System.Drawing.Size(52, 12);
            conditionLabel.TabIndex = 20;
            conditionLabel.Text = "condition:";
            // 
            // termLabel
            // 
            termLabel.AutoSize = true;
            termLabel.Location = new System.Drawing.Point(24, 302);
            termLabel.Name = "termLabel";
            termLabel.Size = new System.Drawing.Size(29, 12);
            termLabel.TabIndex = 18;
            termLabel.Text = "term:";
            // 
            // currencyLabel
            // 
            currencyLabel.AutoSize = true;
            currencyLabel.Location = new System.Drawing.Point(24, 275);
            currencyLabel.Name = "currencyLabel";
            currencyLabel.Size = new System.Drawing.Size(49, 12);
            currencyLabel.TabIndex = 16;
            currencyLabel.Text = "currency:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(24, 248);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(43, 12);
            amountLabel.TabIndex = 14;
            amountLabel.Text = "amount:";
            // 
            // tentative_schedulesLabel
            // 
            tentative_schedulesLabel.AutoSize = true;
            tentative_schedulesLabel.Location = new System.Drawing.Point(24, 221);
            tentative_schedulesLabel.Name = "tentative_schedulesLabel";
            tentative_schedulesLabel.Size = new System.Drawing.Size(94, 12);
            tentative_schedulesLabel.TabIndex = 12;
            tentative_schedulesLabel.Text = "tentative schedules:";
            // 
            // buyer_IDLabel
            // 
            buyer_IDLabel.AutoSize = true;
            buyer_IDLabel.Location = new System.Drawing.Point(24, 194);
            buyer_IDLabel.Name = "buyer_IDLabel";
            buyer_IDLabel.Size = new System.Drawing.Size(50, 12);
            buyer_IDLabel.TabIndex = 10;
            buyer_IDLabel.Text = "buyer ID:";
            // 
            // supplier_IDLabel
            // 
            supplier_IDLabel.AutoSize = true;
            supplier_IDLabel.Location = new System.Drawing.Point(24, 167);
            supplier_IDLabel.Name = "supplier_IDLabel";
            supplier_IDLabel.Size = new System.Drawing.Size(60, 12);
            supplier_IDLabel.TabIndex = 8;
            supplier_IDLabel.Text = "supplier ID:";
            // 
            // effective_dateLabel
            // 
            effective_dateLabel.AutoSize = true;
            effective_dateLabel.Location = new System.Drawing.Point(24, 140);
            effective_dateLabel.Name = "effective_dateLabel";
            effective_dateLabel.Size = new System.Drawing.Size(70, 12);
            effective_dateLabel.TabIndex = 6;
            effective_dateLabel.Text = "effective date:";
            // 
            // create_dateLabel
            // 
            create_dateLabel.AutoSize = true;
            create_dateLabel.Location = new System.Drawing.Point(24, 113);
            create_dateLabel.Name = "create_dateLabel";
            create_dateLabel.Size = new System.Drawing.Size(57, 12);
            create_dateLabel.TabIndex = 4;
            create_dateLabel.Text = "create date:";
            // 
            // purchase_order_revision_IDLabel
            // 
            purchase_order_revision_IDLabel.AutoSize = true;
            purchase_order_revision_IDLabel.Location = new System.Drawing.Point(24, 87);
            purchase_order_revision_IDLabel.Name = "purchase_order_revision_IDLabel";
            purchase_order_revision_IDLabel.Size = new System.Drawing.Size(132, 12);
            purchase_order_revision_IDLabel.TabIndex = 2;
            purchase_order_revision_IDLabel.Text = "purchase order revision ID:";
            // 
            // header_IDLabel
            // 
            header_IDLabel.AutoSize = true;
            header_IDLabel.Location = new System.Drawing.Point(24, 60);
            header_IDLabel.Name = "header_IDLabel";
            header_IDLabel.Size = new System.Drawing.Size(54, 12);
            header_IDLabel.TabIndex = 0;
            header_IDLabel.Text = "header ID:";
            // 
            // purchase_dbDataSet
            // 
            this.purchase_dbDataSet.DataSetName = "purchase_dbDataSet";
            this.purchase_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ppo_headerBindingSource
            // 
            this.ppo_headerBindingSource.DataMember = "ppo_header";
            this.ppo_headerBindingSource.DataSource = this.purchase_dbDataSet;
            // 
            // ppo_headerTableAdapter
            // 
            this.ppo_headerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.blanket_releaseTableAdapter = null;
            this.tableAdapterManager.bpa_headerTableAdapter = null;
            this.tableAdapterManager.bpa_linesTableAdapter = null;
            this.tableAdapterManager.cpaTableAdapter = null;
            this.tableAdapterManager.itemTableAdapter = null;
            this.tableAdapterManager.ppo_headerTableAdapter = this.ppo_headerTableAdapter;
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
            // tentative_schedulesKryptonDateTimePicker
            // 
            this.tentative_schedulesKryptonDateTimePicker.CornerRoundingRadius = -1F;
            this.tentative_schedulesKryptonDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ppo_headerBindingSource, "tentative_schedules", true));
            this.tentative_schedulesKryptonDateTimePicker.Location = new System.Drawing.Point(162, 221);
            this.tentative_schedulesKryptonDateTimePicker.Name = "tentative_schedulesKryptonDateTimePicker";
            this.tentative_schedulesKryptonDateTimePicker.Size = new System.Drawing.Size(240, 21);
            this.tentative_schedulesKryptonDateTimePicker.TabIndex = 13;
            // 
            // effective_dateKryptonDateTimePicker
            // 
            this.effective_dateKryptonDateTimePicker.CornerRoundingRadius = -1F;
            this.effective_dateKryptonDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ppo_headerBindingSource, "effective_date", true));
            this.effective_dateKryptonDateTimePicker.Location = new System.Drawing.Point(162, 140);
            this.effective_dateKryptonDateTimePicker.Name = "effective_dateKryptonDateTimePicker";
            this.effective_dateKryptonDateTimePicker.Size = new System.Drawing.Size(240, 21);
            this.effective_dateKryptonDateTimePicker.TabIndex = 7;
            // 
            // create_dateKryptonDateTimePicker
            // 
            this.create_dateKryptonDateTimePicker.CornerRoundingRadius = -1F;
            this.create_dateKryptonDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ppo_headerBindingSource, "create_date", true));
            this.create_dateKryptonDateTimePicker.Location = new System.Drawing.Point(162, 113);
            this.create_dateKryptonDateTimePicker.Name = "create_dateKryptonDateTimePicker";
            this.create_dateKryptonDateTimePicker.Size = new System.Drawing.Size(240, 21);
            this.create_dateKryptonDateTimePicker.TabIndex = 5;
            // 
            // purchase_order_revision_IDKryptonCheckBox
            // 
            this.purchase_order_revision_IDKryptonCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.ppo_headerBindingSource, "purchase_order_revision_ID", true));
            this.purchase_order_revision_IDKryptonCheckBox.Location = new System.Drawing.Point(162, 87);
            this.purchase_order_revision_IDKryptonCheckBox.Name = "purchase_order_revision_IDKryptonCheckBox";
            this.purchase_order_revision_IDKryptonCheckBox.Size = new System.Drawing.Size(125, 20);
            this.purchase_order_revision_IDKryptonCheckBox.TabIndex = 3;
            this.purchase_order_revision_IDKryptonCheckBox.Values.Text = "kryptonCheckBox1";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.AutoScroll = true;
            this.kryptonPanel1.AutoSize = true;
            this.kryptonPanel1.Controls.Add(this.ppo_linesKryptonDataGridView);
            this.kryptonPanel1.Controls.Add(this.kryptonButtonSave);
            this.kryptonPanel1.Controls.Add(header_IDLabel);
            this.kryptonPanel1.Controls.Add(this.header_IDKryptonNumericUpDown);
            this.kryptonPanel1.Controls.Add(purchase_order_revision_IDLabel);
            this.kryptonPanel1.Controls.Add(this.purchase_order_revision_IDKryptonCheckBox);
            this.kryptonPanel1.Controls.Add(create_dateLabel);
            this.kryptonPanel1.Controls.Add(this.create_dateKryptonDateTimePicker);
            this.kryptonPanel1.Controls.Add(effective_dateLabel);
            this.kryptonPanel1.Controls.Add(this.effective_dateKryptonDateTimePicker);
            this.kryptonPanel1.Controls.Add(supplier_IDLabel);
            this.kryptonPanel1.Controls.Add(this.supplier_IDKryptonNumericUpDown);
            this.kryptonPanel1.Controls.Add(buyer_IDLabel);
            this.kryptonPanel1.Controls.Add(this.buyer_IDKryptonNumericUpDown);
            this.kryptonPanel1.Controls.Add(tentative_schedulesLabel);
            this.kryptonPanel1.Controls.Add(this.tentative_schedulesKryptonDateTimePicker);
            this.kryptonPanel1.Controls.Add(amountLabel);
            this.kryptonPanel1.Controls.Add(this.amountKryptonNumericUpDown);
            this.kryptonPanel1.Controls.Add(currencyLabel);
            this.kryptonPanel1.Controls.Add(this.currencyKryptonNumericUpDown);
            this.kryptonPanel1.Controls.Add(termLabel);
            this.kryptonPanel1.Controls.Add(this.termKryptonTextBox);
            this.kryptonPanel1.Controls.Add(conditionLabel);
            this.kryptonPanel1.Controls.Add(this.conditionKryptonTextBox);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(875, 888);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // ppo_linesKryptonDataGridView
            // 
            this.ppo_linesKryptonDataGridView.AllowUserToAddRows = false;
            this.ppo_linesKryptonDataGridView.AllowUserToDeleteRows = false;
            this.ppo_linesKryptonDataGridView.DataSource = this.ppo_linesBindingSource;
            this.ppo_linesKryptonDataGridView.Location = new System.Drawing.Point(3, 495);
            this.ppo_linesKryptonDataGridView.Name = "ppo_linesKryptonDataGridView";
            this.ppo_linesKryptonDataGridView.RowTemplate.Height = 24;
            this.ppo_linesKryptonDataGridView.Size = new System.Drawing.Size(869, 231);
            this.ppo_linesKryptonDataGridView.TabIndex = 58;
            // 
            // ppo_linesBindingSource
            // 
            this.ppo_linesBindingSource.DataMember = "PPO_lines_header_ID_fk";
            this.ppo_linesBindingSource.DataSource = this.ppo_headerBindingSource;
            // 
            // kryptonButtonSave
            // 
            this.kryptonButtonSave.CornerRoundingRadius = 25F;
            this.kryptonButtonSave.Location = new System.Drawing.Point(617, 52);
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
            this.kryptonButtonSave.TabIndex = 58;
            this.kryptonButtonSave.Values.Text = "Save";
            this.kryptonButtonSave.Click += new System.EventHandler(this.kryptonButtonSave_Click);
            // 
            // header_IDKryptonNumericUpDown
            // 
            this.header_IDKryptonNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ppo_headerBindingSource, "header_ID", true));
            this.header_IDKryptonNumericUpDown.Location = new System.Drawing.Point(162, 60);
            this.header_IDKryptonNumericUpDown.Name = "header_IDKryptonNumericUpDown";
            this.header_IDKryptonNumericUpDown.Size = new System.Drawing.Size(240, 22);
            this.header_IDKryptonNumericUpDown.TabIndex = 1;
            // 
            // supplier_IDKryptonNumericUpDown
            // 
            this.supplier_IDKryptonNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ppo_headerBindingSource, "supplier_ID", true));
            this.supplier_IDKryptonNumericUpDown.Location = new System.Drawing.Point(162, 167);
            this.supplier_IDKryptonNumericUpDown.Name = "supplier_IDKryptonNumericUpDown";
            this.supplier_IDKryptonNumericUpDown.Size = new System.Drawing.Size(240, 22);
            this.supplier_IDKryptonNumericUpDown.TabIndex = 9;
            // 
            // buyer_IDKryptonNumericUpDown
            // 
            this.buyer_IDKryptonNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ppo_headerBindingSource, "buyer_ID", true));
            this.buyer_IDKryptonNumericUpDown.Location = new System.Drawing.Point(162, 194);
            this.buyer_IDKryptonNumericUpDown.Name = "buyer_IDKryptonNumericUpDown";
            this.buyer_IDKryptonNumericUpDown.Size = new System.Drawing.Size(240, 22);
            this.buyer_IDKryptonNumericUpDown.TabIndex = 11;
            // 
            // amountKryptonNumericUpDown
            // 
            this.amountKryptonNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ppo_headerBindingSource, "amount", true));
            this.amountKryptonNumericUpDown.Location = new System.Drawing.Point(162, 248);
            this.amountKryptonNumericUpDown.Name = "amountKryptonNumericUpDown";
            this.amountKryptonNumericUpDown.Size = new System.Drawing.Size(240, 22);
            this.amountKryptonNumericUpDown.TabIndex = 15;
            // 
            // currencyKryptonNumericUpDown
            // 
            this.currencyKryptonNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ppo_headerBindingSource, "currency", true));
            this.currencyKryptonNumericUpDown.Location = new System.Drawing.Point(162, 275);
            this.currencyKryptonNumericUpDown.Name = "currencyKryptonNumericUpDown";
            this.currencyKryptonNumericUpDown.Size = new System.Drawing.Size(240, 22);
            this.currencyKryptonNumericUpDown.TabIndex = 17;
            // 
            // termKryptonTextBox
            // 
            this.termKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ppo_headerBindingSource, "term", true));
            this.termKryptonTextBox.Location = new System.Drawing.Point(162, 302);
            this.termKryptonTextBox.Name = "termKryptonTextBox";
            this.termKryptonTextBox.Size = new System.Drawing.Size(240, 23);
            this.termKryptonTextBox.TabIndex = 19;
            this.termKryptonTextBox.Text = "kryptonTextBox1";
            // 
            // conditionKryptonTextBox
            // 
            this.conditionKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ppo_headerBindingSource, "condition", true));
            this.conditionKryptonTextBox.Location = new System.Drawing.Point(162, 330);
            this.conditionKryptonTextBox.Name = "conditionKryptonTextBox";
            this.conditionKryptonTextBox.Size = new System.Drawing.Size(240, 23);
            this.conditionKryptonTextBox.TabIndex = 21;
            this.conditionKryptonTextBox.Text = "kryptonTextBox1";
            // 
            // ppo_linesTableAdapter
            // 
            this.ppo_linesTableAdapter.ClearBeforeFill = true;
            // 
            // detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "detail";
            this.Size = new System.Drawing.Size(875, 888);
            ((System.ComponentModel.ISupportInitialize)(this.purchase_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppo_headerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ppo_linesKryptonDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppo_linesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private purchase_dbDataSet purchase_dbDataSet;
        private System.Windows.Forms.BindingSource ppo_headerBindingSource;
        private purchase_dbDataSetTableAdapters.ppo_headerTableAdapter ppo_headerTableAdapter;
        private purchase_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Krypton.Toolkit.KryptonDateTimePicker tentative_schedulesKryptonDateTimePicker;
        private Krypton.Toolkit.KryptonDateTimePicker effective_dateKryptonDateTimePicker;
        private Krypton.Toolkit.KryptonDateTimePicker create_dateKryptonDateTimePicker;
        private Krypton.Toolkit.KryptonCheckBox purchase_order_revision_IDKryptonCheckBox;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonNumericUpDown header_IDKryptonNumericUpDown;
        private Krypton.Toolkit.KryptonNumericUpDown supplier_IDKryptonNumericUpDown;
        private Krypton.Toolkit.KryptonNumericUpDown buyer_IDKryptonNumericUpDown;
        private Krypton.Toolkit.KryptonNumericUpDown amountKryptonNumericUpDown;
        private Krypton.Toolkit.KryptonNumericUpDown currencyKryptonNumericUpDown;
        private Krypton.Toolkit.KryptonTextBox termKryptonTextBox;
        private Krypton.Toolkit.KryptonTextBox conditionKryptonTextBox;
        private Krypton.Toolkit.KryptonButton kryptonButtonSave;
        private Krypton.Toolkit.KryptonDataGridView ppo_linesKryptonDataGridView;
        private System.Windows.Forms.BindingSource ppo_linesBindingSource;
        private purchase_dbDataSetTableAdapters.ppo_linesTableAdapter ppo_linesTableAdapter;
    }
}
