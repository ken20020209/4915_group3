
namespace ITP4915_group3_project.warehouse.check_PO.CPA
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
            System.Windows.Forms.Label cPA_IDLabel;
            System.Windows.Forms.Label create_dateLabel;
            System.Windows.Forms.Label effective_dateLabel;
            System.Windows.Forms.Label supplier_IDLabel;
            System.Windows.Forms.Label buyer_IDLabel;
            System.Windows.Forms.Label termsLabel;
            System.Windows.Forms.Label conditionLabel;
            System.Windows.Forms.Label item_IDLabel;
            this.kryptonPanelContent = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.cpa_itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchase_dbDataSet = new ITP4915_group3_project.purchase_dbDataSet();
            this.cpaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cpa_itemTableAdapter = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.cpa_itemTableAdapter();
            this.tableAdapterManager = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.TableAdapterManager();
            this.cpaTableAdapter = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.cpaTableAdapter();
            this.cPA_IDTextBox = new System.Windows.Forms.TextBox();
            this.create_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.effective_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.supplier_IDKryptonTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.buyer_IDKryptonTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.termsTextBox = new System.Windows.Forms.TextBox();
            this.conditionTextBox = new System.Windows.Forms.TextBox();
            this.item_IDKryptonTextBox = new Krypton.Toolkit.KryptonTextBox();
            cPA_IDLabel = new System.Windows.Forms.Label();
            create_dateLabel = new System.Windows.Forms.Label();
            effective_dateLabel = new System.Windows.Forms.Label();
            supplier_IDLabel = new System.Windows.Forms.Label();
            buyer_IDLabel = new System.Windows.Forms.Label();
            termsLabel = new System.Windows.Forms.Label();
            conditionLabel = new System.Windows.Forms.Label();
            item_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelContent)).BeginInit();
            this.kryptonPanelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpa_itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanelContent
            // 
            this.kryptonPanelContent.AutoScroll = true;
            this.kryptonPanelContent.Controls.Add(cPA_IDLabel);
            this.kryptonPanelContent.Controls.Add(this.cPA_IDTextBox);
            this.kryptonPanelContent.Controls.Add(create_dateLabel);
            this.kryptonPanelContent.Controls.Add(this.create_dateDateTimePicker);
            this.kryptonPanelContent.Controls.Add(effective_dateLabel);
            this.kryptonPanelContent.Controls.Add(this.effective_dateDateTimePicker);
            this.kryptonPanelContent.Controls.Add(supplier_IDLabel);
            this.kryptonPanelContent.Controls.Add(this.supplier_IDKryptonTextBox);
            this.kryptonPanelContent.Controls.Add(buyer_IDLabel);
            this.kryptonPanelContent.Controls.Add(this.buyer_IDKryptonTextBox);
            this.kryptonPanelContent.Controls.Add(termsLabel);
            this.kryptonPanelContent.Controls.Add(this.termsTextBox);
            this.kryptonPanelContent.Controls.Add(conditionLabel);
            this.kryptonPanelContent.Controls.Add(this.conditionTextBox);
            this.kryptonPanelContent.Controls.Add(item_IDLabel);
            this.kryptonPanelContent.Controls.Add(this.item_IDKryptonTextBox);
            this.kryptonPanelContent.Controls.Add(this.kryptonLabel4);
            this.kryptonPanelContent.Controls.Add(this.label1);
            this.kryptonPanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanelContent.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanelContent.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanelContent.Name = "kryptonPanelContent";
            this.kryptonPanelContent.Size = new System.Drawing.Size(827, 549);
            this.kryptonPanelContent.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPanelContent.TabIndex = 287;
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
            // cpa_itemBindingSource
            // 
            this.cpa_itemBindingSource.DataMember = "cpa_item";
            this.cpa_itemBindingSource.DataSource = this.purchase_dbDataSet;
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
            // cpa_itemTableAdapter
            // 
            this.cpa_itemTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.addressTableAdapter = null;
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
            // cpaTableAdapter
            // 
            this.cpaTableAdapter.ClearBeforeFill = true;
            // 
            // cPA_IDLabel
            // 
            cPA_IDLabel.AutoSize = true;
            cPA_IDLabel.Location = new System.Drawing.Point(274, 158);
            cPA_IDLabel.Name = "cPA_IDLabel";
            cPA_IDLabel.Size = new System.Drawing.Size(45, 12);
            cPA_IDLabel.TabIndex = 207;
            cPA_IDLabel.Text = "CPA ID:";
            // 
            // cPA_IDTextBox
            // 
            this.cPA_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cpaBindingSource, "CPA_ID", true));
            this.cPA_IDTextBox.Location = new System.Drawing.Point(350, 155);
            this.cPA_IDTextBox.Name = "cPA_IDTextBox";
            this.cPA_IDTextBox.Size = new System.Drawing.Size(200, 22);
            this.cPA_IDTextBox.TabIndex = 208;
            // 
            // create_dateLabel
            // 
            create_dateLabel.AutoSize = true;
            create_dateLabel.Location = new System.Drawing.Point(274, 187);
            create_dateLabel.Name = "create_dateLabel";
            create_dateLabel.Size = new System.Drawing.Size(57, 12);
            create_dateLabel.TabIndex = 209;
            create_dateLabel.Text = "create date:";
            // 
            // create_dateDateTimePicker
            // 
            this.create_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cpaBindingSource, "create_date", true));
            this.create_dateDateTimePicker.Location = new System.Drawing.Point(350, 183);
            this.create_dateDateTimePicker.Name = "create_dateDateTimePicker";
            this.create_dateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.create_dateDateTimePicker.TabIndex = 210;
            // 
            // effective_dateLabel
            // 
            effective_dateLabel.AutoSize = true;
            effective_dateLabel.Location = new System.Drawing.Point(274, 215);
            effective_dateLabel.Name = "effective_dateLabel";
            effective_dateLabel.Size = new System.Drawing.Size(70, 12);
            effective_dateLabel.TabIndex = 211;
            effective_dateLabel.Text = "effective date:";
            // 
            // effective_dateDateTimePicker
            // 
            this.effective_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cpaBindingSource, "effective_date", true));
            this.effective_dateDateTimePicker.Location = new System.Drawing.Point(350, 211);
            this.effective_dateDateTimePicker.Name = "effective_dateDateTimePicker";
            this.effective_dateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.effective_dateDateTimePicker.TabIndex = 212;
            // 
            // supplier_IDLabel
            // 
            supplier_IDLabel.AutoSize = true;
            supplier_IDLabel.Location = new System.Drawing.Point(274, 239);
            supplier_IDLabel.Name = "supplier_IDLabel";
            supplier_IDLabel.Size = new System.Drawing.Size(60, 12);
            supplier_IDLabel.TabIndex = 213;
            supplier_IDLabel.Text = "supplier ID:";
            // 
            // supplier_IDKryptonTextBox
            // 
            this.supplier_IDKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cpaBindingSource, "supplier_ID", true));
            this.supplier_IDKryptonTextBox.Location = new System.Drawing.Point(350, 239);
            this.supplier_IDKryptonTextBox.Name = "supplier_IDKryptonTextBox";
            this.supplier_IDKryptonTextBox.Size = new System.Drawing.Size(200, 23);
            this.supplier_IDKryptonTextBox.TabIndex = 214;
            this.supplier_IDKryptonTextBox.Text = "kryptonTextBox1";
            // 
            // buyer_IDLabel
            // 
            buyer_IDLabel.AutoSize = true;
            buyer_IDLabel.Location = new System.Drawing.Point(274, 267);
            buyer_IDLabel.Name = "buyer_IDLabel";
            buyer_IDLabel.Size = new System.Drawing.Size(50, 12);
            buyer_IDLabel.TabIndex = 215;
            buyer_IDLabel.Text = "buyer ID:";
            // 
            // buyer_IDKryptonTextBox
            // 
            this.buyer_IDKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cpaBindingSource, "buyer_ID", true));
            this.buyer_IDKryptonTextBox.Location = new System.Drawing.Point(350, 267);
            this.buyer_IDKryptonTextBox.Name = "buyer_IDKryptonTextBox";
            this.buyer_IDKryptonTextBox.Size = new System.Drawing.Size(200, 23);
            this.buyer_IDKryptonTextBox.TabIndex = 216;
            this.buyer_IDKryptonTextBox.Text = "kryptonTextBox1";
            // 
            // termsLabel
            // 
            termsLabel.AutoSize = true;
            termsLabel.Location = new System.Drawing.Point(274, 298);
            termsLabel.Name = "termsLabel";
            termsLabel.Size = new System.Drawing.Size(33, 12);
            termsLabel.TabIndex = 217;
            termsLabel.Text = "terms:";
            // 
            // termsTextBox
            // 
            this.termsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cpaBindingSource, "terms", true));
            this.termsTextBox.Location = new System.Drawing.Point(350, 295);
            this.termsTextBox.Name = "termsTextBox";
            this.termsTextBox.Size = new System.Drawing.Size(200, 22);
            this.termsTextBox.TabIndex = 218;
            // 
            // conditionLabel
            // 
            conditionLabel.AutoSize = true;
            conditionLabel.Location = new System.Drawing.Point(274, 326);
            conditionLabel.Name = "conditionLabel";
            conditionLabel.Size = new System.Drawing.Size(52, 12);
            conditionLabel.TabIndex = 219;
            conditionLabel.Text = "condition:";
            // 
            // conditionTextBox
            // 
            this.conditionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cpaBindingSource, "condition", true));
            this.conditionTextBox.Location = new System.Drawing.Point(350, 323);
            this.conditionTextBox.Name = "conditionTextBox";
            this.conditionTextBox.Size = new System.Drawing.Size(200, 22);
            this.conditionTextBox.TabIndex = 220;
            // 
            // item_IDLabel
            // 
            item_IDLabel.AutoSize = true;
            item_IDLabel.Location = new System.Drawing.Point(274, 351);
            item_IDLabel.Name = "item_IDLabel";
            item_IDLabel.Size = new System.Drawing.Size(43, 12);
            item_IDLabel.TabIndex = 221;
            item_IDLabel.Text = "item ID:";
            // 
            // item_IDKryptonTextBox
            // 
            this.item_IDKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cpaBindingSource, "item_ID", true));
            this.item_IDKryptonTextBox.Location = new System.Drawing.Point(350, 351);
            this.item_IDKryptonTextBox.Name = "item_IDKryptonTextBox";
            this.item_IDKryptonTextBox.Size = new System.Drawing.Size(200, 23);
            this.item_IDKryptonTextBox.TabIndex = 222;
            this.item_IDKryptonTextBox.Text = "kryptonTextBox1";
            // 
            // detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanelContent);
            this.Name = "detail";
            this.Size = new System.Drawing.Size(827, 549);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelContent)).EndInit();
            this.kryptonPanelContent.ResumeLayout(false);
            this.kryptonPanelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpa_itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanelContent;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource cpa_itemBindingSource;
        private purchase_dbDataSet purchase_dbDataSet;
        private System.Windows.Forms.BindingSource cpaBindingSource;
        private purchase_dbDataSetTableAdapters.cpa_itemTableAdapter cpa_itemTableAdapter;
        private purchase_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private purchase_dbDataSetTableAdapters.cpaTableAdapter cpaTableAdapter;
        private System.Windows.Forms.TextBox cPA_IDTextBox;
        private System.Windows.Forms.DateTimePicker create_dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker effective_dateDateTimePicker;
        private Krypton.Toolkit.KryptonTextBox supplier_IDKryptonTextBox;
        private Krypton.Toolkit.KryptonTextBox buyer_IDKryptonTextBox;
        private System.Windows.Forms.TextBox termsTextBox;
        private System.Windows.Forms.TextBox conditionTextBox;
        private Krypton.Toolkit.KryptonTextBox item_IDKryptonTextBox;
    }
}
