
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(create));
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
            this.purchase_dbDataSet = new ITP4915_group3_project.purchase_dbDataSet();
            this.bpa_headerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bpa_headerTableAdapter = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.bpa_headerTableAdapter();
            this.tableAdapterManager = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.TableAdapterManager();
            this.bpa_headerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bpa_headerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.header_IDTextBox = new System.Windows.Forms.TextBox();
            this.purchase_order_revisionTextBox = new System.Windows.Forms.TextBox();
            this.create_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.effective_datesDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.supplier_IDTextBox = new System.Windows.Forms.TextBox();
            this.buyer_IDTextBox = new System.Windows.Forms.TextBox();
            this.agreed_amountTextBox = new System.Windows.Forms.TextBox();
            this.currencyTextBox = new System.Windows.Forms.TextBox();
            this.termsTextBox = new System.Windows.Forms.TextBox();
            this.conditionTextBox = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.purchase_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpa_headerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpa_headerBindingNavigator)).BeginInit();
            this.bpa_headerBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(header_IDLabel);
            this.kryptonPanel1.Controls.Add(this.header_IDTextBox);
            this.kryptonPanel1.Controls.Add(purchase_order_revisionLabel);
            this.kryptonPanel1.Controls.Add(this.purchase_order_revisionTextBox);
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
            // bpa_headerBindingSource
            // 
            this.bpa_headerBindingSource.DataMember = "bpa_header";
            this.bpa_headerBindingSource.DataSource = this.purchase_dbDataSet;
            // 
            // bpa_headerTableAdapter
            // 
            this.bpa_headerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bpa_headerTableAdapter = this.bpa_headerTableAdapter;
            this.tableAdapterManager.bpa_linesTableAdapter = null;
            this.tableAdapterManager.itemTableAdapter = null;
            this.tableAdapterManager.supplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ITP4915_group3_project.purchase_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // bpa_headerBindingNavigator
            // 
            this.bpa_headerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bpa_headerBindingNavigator.BindingSource = this.bpa_headerBindingSource;
            this.bpa_headerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bpa_headerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bpa_headerBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bpa_headerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bpa_headerBindingNavigatorSaveItem});
            this.bpa_headerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bpa_headerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bpa_headerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bpa_headerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bpa_headerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bpa_headerBindingNavigator.Name = "bpa_headerBindingNavigator";
            this.bpa_headerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bpa_headerBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.bpa_headerBindingNavigator.TabIndex = 1;
            this.bpa_headerBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bpa_headerBindingNavigatorSaveItem
            // 
            this.bpa_headerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bpa_headerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bpa_headerBindingNavigatorSaveItem.Image")));
            this.bpa_headerBindingNavigatorSaveItem.Name = "bpa_headerBindingNavigatorSaveItem";
            this.bpa_headerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.bpa_headerBindingNavigatorSaveItem.Text = "Save Data";
            this.bpa_headerBindingNavigatorSaveItem.Click += new System.EventHandler(this.bpa_headerBindingNavigatorSaveItem_Click);
            // 
            // header_IDLabel
            // 
            header_IDLabel.AutoSize = true;
            header_IDLabel.Location = new System.Drawing.Point(203, 132);
            header_IDLabel.Name = "header_IDLabel";
            header_IDLabel.Size = new System.Drawing.Size(54, 12);
            header_IDLabel.TabIndex = 0;
            header_IDLabel.Text = "header ID:";
            // 
            // header_IDTextBox
            // 
            this.header_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bpa_headerBindingSource, "header_ID", true));
            this.header_IDTextBox.Location = new System.Drawing.Point(326, 129);
            this.header_IDTextBox.Name = "header_IDTextBox";
            this.header_IDTextBox.Size = new System.Drawing.Size(200, 22);
            this.header_IDTextBox.TabIndex = 1;
            // 
            // purchase_order_revisionLabel
            // 
            purchase_order_revisionLabel.AutoSize = true;
            purchase_order_revisionLabel.Location = new System.Drawing.Point(203, 160);
            purchase_order_revisionLabel.Name = "purchase_order_revisionLabel";
            purchase_order_revisionLabel.Size = new System.Drawing.Size(117, 12);
            purchase_order_revisionLabel.TabIndex = 2;
            purchase_order_revisionLabel.Text = "purchase order revision:";
            // 
            // purchase_order_revisionTextBox
            // 
            this.purchase_order_revisionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bpa_headerBindingSource, "purchase_order_revision", true));
            this.purchase_order_revisionTextBox.Location = new System.Drawing.Point(326, 157);
            this.purchase_order_revisionTextBox.Name = "purchase_order_revisionTextBox";
            this.purchase_order_revisionTextBox.Size = new System.Drawing.Size(200, 22);
            this.purchase_order_revisionTextBox.TabIndex = 3;
            // 
            // create_dateLabel
            // 
            create_dateLabel.AutoSize = true;
            create_dateLabel.Location = new System.Drawing.Point(203, 189);
            create_dateLabel.Name = "create_dateLabel";
            create_dateLabel.Size = new System.Drawing.Size(57, 12);
            create_dateLabel.TabIndex = 4;
            create_dateLabel.Text = "create date:";
            // 
            // create_dateDateTimePicker
            // 
            this.create_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bpa_headerBindingSource, "create_date", true));
            this.create_dateDateTimePicker.Location = new System.Drawing.Point(326, 185);
            this.create_dateDateTimePicker.Name = "create_dateDateTimePicker";
            this.create_dateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.create_dateDateTimePicker.TabIndex = 5;
            // 
            // effective_datesLabel
            // 
            effective_datesLabel.AutoSize = true;
            effective_datesLabel.Location = new System.Drawing.Point(203, 217);
            effective_datesLabel.Name = "effective_datesLabel";
            effective_datesLabel.Size = new System.Drawing.Size(74, 12);
            effective_datesLabel.TabIndex = 6;
            effective_datesLabel.Text = "effective dates:";
            // 
            // effective_datesDateTimePicker
            // 
            this.effective_datesDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bpa_headerBindingSource, "effective_dates", true));
            this.effective_datesDateTimePicker.Location = new System.Drawing.Point(326, 213);
            this.effective_datesDateTimePicker.Name = "effective_datesDateTimePicker";
            this.effective_datesDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.effective_datesDateTimePicker.TabIndex = 7;
            // 
            // supplier_IDLabel
            // 
            supplier_IDLabel.AutoSize = true;
            supplier_IDLabel.Location = new System.Drawing.Point(203, 244);
            supplier_IDLabel.Name = "supplier_IDLabel";
            supplier_IDLabel.Size = new System.Drawing.Size(60, 12);
            supplier_IDLabel.TabIndex = 8;
            supplier_IDLabel.Text = "supplier ID:";
            // 
            // supplier_IDTextBox
            // 
            this.supplier_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bpa_headerBindingSource, "supplier_ID", true));
            this.supplier_IDTextBox.Location = new System.Drawing.Point(326, 241);
            this.supplier_IDTextBox.Name = "supplier_IDTextBox";
            this.supplier_IDTextBox.Size = new System.Drawing.Size(200, 22);
            this.supplier_IDTextBox.TabIndex = 9;
            // 
            // buyer_IDLabel
            // 
            buyer_IDLabel.AutoSize = true;
            buyer_IDLabel.Location = new System.Drawing.Point(203, 272);
            buyer_IDLabel.Name = "buyer_IDLabel";
            buyer_IDLabel.Size = new System.Drawing.Size(50, 12);
            buyer_IDLabel.TabIndex = 10;
            buyer_IDLabel.Text = "buyer ID:";
            // 
            // buyer_IDTextBox
            // 
            this.buyer_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bpa_headerBindingSource, "buyer_ID", true));
            this.buyer_IDTextBox.Location = new System.Drawing.Point(326, 269);
            this.buyer_IDTextBox.Name = "buyer_IDTextBox";
            this.buyer_IDTextBox.Size = new System.Drawing.Size(200, 22);
            this.buyer_IDTextBox.TabIndex = 11;
            // 
            // agreed_amountLabel
            // 
            agreed_amountLabel.AutoSize = true;
            agreed_amountLabel.Location = new System.Drawing.Point(203, 300);
            agreed_amountLabel.Name = "agreed_amountLabel";
            agreed_amountLabel.Size = new System.Drawing.Size(77, 12);
            agreed_amountLabel.TabIndex = 12;
            agreed_amountLabel.Text = "agreed amount:";
            // 
            // agreed_amountTextBox
            // 
            this.agreed_amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bpa_headerBindingSource, "agreed_amount", true));
            this.agreed_amountTextBox.Location = new System.Drawing.Point(326, 297);
            this.agreed_amountTextBox.Name = "agreed_amountTextBox";
            this.agreed_amountTextBox.Size = new System.Drawing.Size(200, 22);
            this.agreed_amountTextBox.TabIndex = 13;
            // 
            // currencyLabel
            // 
            currencyLabel.AutoSize = true;
            currencyLabel.Location = new System.Drawing.Point(203, 328);
            currencyLabel.Name = "currencyLabel";
            currencyLabel.Size = new System.Drawing.Size(49, 12);
            currencyLabel.TabIndex = 14;
            currencyLabel.Text = "currency:";
            // 
            // currencyTextBox
            // 
            this.currencyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bpa_headerBindingSource, "currency", true));
            this.currencyTextBox.Location = new System.Drawing.Point(326, 325);
            this.currencyTextBox.Name = "currencyTextBox";
            this.currencyTextBox.Size = new System.Drawing.Size(200, 22);
            this.currencyTextBox.TabIndex = 15;
            // 
            // termsLabel
            // 
            termsLabel.AutoSize = true;
            termsLabel.Location = new System.Drawing.Point(203, 356);
            termsLabel.Name = "termsLabel";
            termsLabel.Size = new System.Drawing.Size(33, 12);
            termsLabel.TabIndex = 16;
            termsLabel.Text = "terms:";
            // 
            // termsTextBox
            // 
            this.termsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bpa_headerBindingSource, "terms", true));
            this.termsTextBox.Location = new System.Drawing.Point(326, 353);
            this.termsTextBox.Name = "termsTextBox";
            this.termsTextBox.Size = new System.Drawing.Size(200, 22);
            this.termsTextBox.TabIndex = 17;
            // 
            // conditionLabel
            // 
            conditionLabel.AutoSize = true;
            conditionLabel.Location = new System.Drawing.Point(203, 384);
            conditionLabel.Name = "conditionLabel";
            conditionLabel.Size = new System.Drawing.Size(52, 12);
            conditionLabel.TabIndex = 18;
            conditionLabel.Text = "condition:";
            // 
            // conditionTextBox
            // 
            this.conditionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bpa_headerBindingSource, "condition", true));
            this.conditionTextBox.Location = new System.Drawing.Point(326, 381);
            this.conditionTextBox.Name = "conditionTextBox";
            this.conditionTextBox.Size = new System.Drawing.Size(200, 22);
            this.conditionTextBox.TabIndex = 19;
            // 
            // create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bpa_headerBindingNavigator);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "create";
            this.Size = new System.Drawing.Size(800, 500);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpa_headerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpa_headerBindingNavigator)).EndInit();
            this.bpa_headerBindingNavigator.ResumeLayout(false);
            this.bpa_headerBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private purchase_dbDataSet purchase_dbDataSet;
        private System.Windows.Forms.BindingSource bpa_headerBindingSource;
        private purchase_dbDataSetTableAdapters.bpa_headerTableAdapter bpa_headerTableAdapter;
        private purchase_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bpa_headerBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bpa_headerBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox header_IDTextBox;
        private System.Windows.Forms.TextBox purchase_order_revisionTextBox;
        private System.Windows.Forms.DateTimePicker create_dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker effective_datesDateTimePicker;
        private System.Windows.Forms.TextBox supplier_IDTextBox;
        private System.Windows.Forms.TextBox buyer_IDTextBox;
        private System.Windows.Forms.TextBox agreed_amountTextBox;
        private System.Windows.Forms.TextBox currencyTextBox;
        private System.Windows.Forms.TextBox termsTextBox;
        private System.Windows.Forms.TextBox conditionTextBox;
    }
}
