
namespace ITP4915_group3_project.Purchase.request_order.process
{
    partial class select_ppo_match
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
            System.Windows.Forms.Label sizeLabel;
            System.Windows.Forms.Label item_nameLabel;
            System.Windows.Forms.Label qtyLabel;
            System.Windows.Forms.Label item_IDLabel;
            this.kryptonPanelContent = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonDateTimePickerExpected = new Krypton.Toolkit.KryptonDateTimePicker();
            this.sizeKryptonTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchasers_requestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchase_dbDataSet = new ITP4915_group3_project.purchase_dbDataSet();
            this.item_nameKryptonTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.qtyKryptonTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.item_IDKryptonTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabelBack = new Krypton.Toolkit.KryptonLabel();
            this.kryptonButtonConfirm = new Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.kryptonComboBox2 = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonTextBox20 = new Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.purchasers_requestTableAdapter = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.purchasers_requestTableAdapter();
            this.tableAdapterManager = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.TableAdapterManager();
            this.itemTableAdapter = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.itemTableAdapter();
            this.match_ppoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.match_ppoTableAdapter = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.match_ppoTableAdapter();
            this.match_ppoKryptonDataGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.kryptonLabelRemark = new Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBoxRemark = new Krypton.Toolkit.KryptonTextBox();
            this.purchase_order_allTableAdapter = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.purchase_order_allTableAdapter();
            this.purchase_order_allTableAdapter1 = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.purchase_order_allTableAdapter();
            sizeLabel = new System.Windows.Forms.Label();
            item_nameLabel = new System.Windows.Forms.Label();
            qtyLabel = new System.Windows.Forms.Label();
            item_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelContent)).BeginInit();
            this.kryptonPanelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasers_requestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.match_ppoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.match_ppoKryptonDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Location = new System.Drawing.Point(491, 276);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new System.Drawing.Size(25, 12);
            sizeLabel.TabIndex = 223;
            sizeLabel.Text = "size:";
            // 
            // item_nameLabel
            // 
            item_nameLabel.AutoSize = true;
            item_nameLabel.Location = new System.Drawing.Point(460, 209);
            item_nameLabel.Name = "item_nameLabel";
            item_nameLabel.Size = new System.Drawing.Size(56, 12);
            item_nameLabel.TabIndex = 221;
            item_nameLabel.Text = "item name:";
            // 
            // qtyLabel
            // 
            qtyLabel.AutoSize = true;
            qtyLabel.Location = new System.Drawing.Point(277, 209);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new System.Drawing.Size(23, 12);
            qtyLabel.TabIndex = 219;
            qtyLabel.Text = "qty:";
            // 
            // item_IDLabel
            // 
            item_IDLabel.AutoSize = true;
            item_IDLabel.Location = new System.Drawing.Point(79, 209);
            item_IDLabel.Name = "item_IDLabel";
            item_IDLabel.Size = new System.Drawing.Size(43, 12);
            item_IDLabel.TabIndex = 217;
            item_IDLabel.Text = "item ID:";
            // 
            // kryptonPanelContent
            // 
            this.kryptonPanelContent.Controls.Add(this.kryptonLabelRemark);
            this.kryptonPanelContent.Controls.Add(this.kryptonTextBoxRemark);
            this.kryptonPanelContent.Controls.Add(this.match_ppoKryptonDataGridView);
            this.kryptonPanelContent.Controls.Add(this.kryptonLabel2);
            this.kryptonPanelContent.Controls.Add(this.kryptonDateTimePickerExpected);
            this.kryptonPanelContent.Controls.Add(sizeLabel);
            this.kryptonPanelContent.Controls.Add(this.sizeKryptonTextBox);
            this.kryptonPanelContent.Controls.Add(item_nameLabel);
            this.kryptonPanelContent.Controls.Add(this.item_nameKryptonTextBox);
            this.kryptonPanelContent.Controls.Add(qtyLabel);
            this.kryptonPanelContent.Controls.Add(this.qtyKryptonTextBox);
            this.kryptonPanelContent.Controls.Add(item_IDLabel);
            this.kryptonPanelContent.Controls.Add(this.item_IDKryptonTextBox);
            this.kryptonPanelContent.Controls.Add(this.kryptonLabelBack);
            this.kryptonPanelContent.Controls.Add(this.kryptonButtonConfirm);
            this.kryptonPanelContent.Controls.Add(this.label1);
            this.kryptonPanelContent.Controls.Add(this.kryptonComboBox2);
            this.kryptonPanelContent.Controls.Add(this.kryptonTextBox20);
            this.kryptonPanelContent.Controls.Add(this.label3);
            this.kryptonPanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanelContent.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanelContent.Name = "kryptonPanelContent";
            this.kryptonPanelContent.Size = new System.Drawing.Size(1200, 804);
            this.kryptonPanelContent.TabIndex = 0;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(213, 278);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(133, 20);
            this.kryptonLabel2.TabIndex = 227;
            this.kryptonLabel2.Values.Text = "expected delivery date";
            // 
            // kryptonDateTimePickerExpected
            // 
            this.kryptonDateTimePickerExpected.CornerRoundingRadius = -1F;
            this.kryptonDateTimePickerExpected.Location = new System.Drawing.Point(352, 278);
            this.kryptonDateTimePickerExpected.Name = "kryptonDateTimePickerExpected";
            this.kryptonDateTimePickerExpected.Size = new System.Drawing.Size(110, 21);
            this.kryptonDateTimePickerExpected.TabIndex = 226;
            // 
            // sizeKryptonTextBox
            // 
            this.sizeKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemBindingSource, "size", true));
            this.sizeKryptonTextBox.Location = new System.Drawing.Point(522, 276);
            this.sizeKryptonTextBox.Name = "sizeKryptonTextBox";
            this.sizeKryptonTextBox.Size = new System.Drawing.Size(100, 23);
            this.sizeKryptonTextBox.TabIndex = 225;
            this.sizeKryptonTextBox.Text = "kryptonTextBox1";
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
            // item_nameKryptonTextBox
            // 
            this.item_nameKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemBindingSource, "item_name", true));
            this.item_nameKryptonTextBox.Location = new System.Drawing.Point(522, 209);
            this.item_nameKryptonTextBox.Name = "item_nameKryptonTextBox";
            this.item_nameKryptonTextBox.Size = new System.Drawing.Size(100, 23);
            this.item_nameKryptonTextBox.TabIndex = 224;
            this.item_nameKryptonTextBox.Text = "kryptonTextBox1";
            // 
            // qtyKryptonTextBox
            // 
            this.qtyKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchasers_requestBindingSource, "qty", true));
            this.qtyKryptonTextBox.Location = new System.Drawing.Point(306, 209);
            this.qtyKryptonTextBox.Name = "qtyKryptonTextBox";
            this.qtyKryptonTextBox.Size = new System.Drawing.Size(100, 23);
            this.qtyKryptonTextBox.TabIndex = 222;
            this.qtyKryptonTextBox.Text = "kryptonTextBox1";
            // 
            // item_IDKryptonTextBox
            // 
            this.item_IDKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchasers_requestBindingSource, "item_ID", true));
            this.item_IDKryptonTextBox.Location = new System.Drawing.Point(128, 209);
            this.item_IDKryptonTextBox.Name = "item_IDKryptonTextBox";
            this.item_IDKryptonTextBox.Size = new System.Drawing.Size(100, 23);
            this.item_IDKryptonTextBox.TabIndex = 220;
            this.item_IDKryptonTextBox.Text = "kryptonTextBox1";
            // 
            // kryptonLabelBack
            // 
            this.kryptonLabelBack.Location = new System.Drawing.Point(33, 66);
            this.kryptonLabelBack.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabelBack.Name = "kryptonLabelBack";
            this.kryptonLabelBack.Size = new System.Drawing.Size(50, 16);
            this.kryptonLabelBack.StateCommon.ShortText.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.kryptonLabelBack.TabIndex = 218;
            this.kryptonLabelBack.UseMnemonic = false;
            this.kryptonLabelBack.Values.Text = "← Back";
            this.kryptonLabelBack.Click += new System.EventHandler(this.kryptonLabelBack_Click);
            // 
            // kryptonButtonConfirm
            // 
            this.kryptonButtonConfirm.CornerRoundingRadius = 25F;
            this.kryptonButtonConfirm.Location = new System.Drawing.Point(649, 41);
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
            this.kryptonButtonConfirm.TabIndex = 216;
            this.kryptonButtonConfirm.Values.Text = "Confirm";
            this.kryptonButtonConfirm.Click += new System.EventHandler(this.kryptonButtonConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.label1.Location = new System.Drawing.Point(462, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 215;
            this.label1.Text = "Filter:";
            // 
            // kryptonComboBox2
            // 
            this.kryptonComboBox2.CornerRoundingRadius = 25F;
            this.kryptonComboBox2.DropDownWidth = 153;
            this.kryptonComboBox2.IntegralHeight = false;
            this.kryptonComboBox2.Location = new System.Drawing.Point(509, 107);
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
            this.kryptonComboBox2.TabIndex = 214;
            this.kryptonComboBox2.Text = "Category";
            // 
            // kryptonTextBox20
            // 
            this.kryptonTextBox20.Location = new System.Drawing.Point(70, 107);
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
            this.kryptonTextBox20.TabIndex = 213;
            this.kryptonTextBox20.Text = "ID/name                                                 🔍 ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 22);
            this.label3.TabIndex = 212;
            this.label3.Text = "Select ppo";
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
            // match_ppoBindingSource
            // 
            this.match_ppoBindingSource.DataMember = "item_match_ppo";
            this.match_ppoBindingSource.DataSource = this.itemBindingSource;
            // 
            // match_ppoTableAdapter
            // 
            this.match_ppoTableAdapter.ClearBeforeFill = true;
            // 
            // match_ppoKryptonDataGridView
            // 
            this.match_ppoKryptonDataGridView.DataSource = this.match_ppoBindingSource;
            this.match_ppoKryptonDataGridView.Location = new System.Drawing.Point(43, 470);
            this.match_ppoKryptonDataGridView.Name = "match_ppoKryptonDataGridView";
            this.match_ppoKryptonDataGridView.RowTemplate.Height = 24;
            this.match_ppoKryptonDataGridView.Size = new System.Drawing.Size(1122, 221);
            this.match_ppoKryptonDataGridView.TabIndex = 227;
            // 
            // kryptonLabelRemark
            // 
            this.kryptonLabelRemark.Location = new System.Drawing.Point(458, 325);
            this.kryptonLabelRemark.Name = "kryptonLabelRemark";
            this.kryptonLabelRemark.Size = new System.Drawing.Size(49, 20);
            this.kryptonLabelRemark.TabIndex = 229;
            this.kryptonLabelRemark.Values.Text = "remark";
            // 
            // kryptonTextBoxRemark
            // 
            this.kryptonTextBoxRemark.Location = new System.Drawing.Point(522, 322);
            this.kryptonTextBoxRemark.Name = "kryptonTextBoxRemark";
            this.kryptonTextBoxRemark.Size = new System.Drawing.Size(100, 23);
            this.kryptonTextBoxRemark.TabIndex = 228;
            this.kryptonTextBoxRemark.Text = "kryptonTextBoxRemark";
            // 
            // purchase_order_allTableAdapter
            // 
            this.purchase_order_allTableAdapter.ClearBeforeFill = true;
            // 
            // purchase_order_allTableAdapter1
            // 
            this.purchase_order_allTableAdapter1.ClearBeforeFill = true;
            // 
            // select_ppo_match
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanelContent);
            this.Name = "select_ppo_match";
            this.Size = new System.Drawing.Size(1200, 804);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelContent)).EndInit();
            this.kryptonPanelContent.ResumeLayout(false);
            this.kryptonPanelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasers_requestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.match_ppoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.match_ppoKryptonDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanelContent;
        private Krypton.Toolkit.KryptonTextBox sizeKryptonTextBox;
        private Krypton.Toolkit.KryptonTextBox item_nameKryptonTextBox;
        private Krypton.Toolkit.KryptonTextBox qtyKryptonTextBox;
        private Krypton.Toolkit.KryptonTextBox item_IDKryptonTextBox;
        private Krypton.Toolkit.KryptonLabel kryptonLabelBack;
        private Krypton.Toolkit.KryptonButton kryptonButtonConfirm;
        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonComboBox kryptonComboBox2;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox20;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.BindingSource purchasers_requestBindingSource;
        private purchase_dbDataSet purchase_dbDataSet;
        private purchase_dbDataSetTableAdapters.purchasers_requestTableAdapter purchasers_requestTableAdapter;
        private purchase_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private purchase_dbDataSetTableAdapters.itemTableAdapter itemTableAdapter;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePickerExpected;
        private System.Windows.Forms.BindingSource match_ppoBindingSource;
        private purchase_dbDataSetTableAdapters.match_ppoTableAdapter match_ppoTableAdapter;
        private Krypton.Toolkit.KryptonDataGridView match_ppoKryptonDataGridView;
        private Krypton.Toolkit.KryptonLabel kryptonLabelRemark;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBoxRemark;
        private purchase_dbDataSetTableAdapters.purchase_order_allTableAdapter purchase_order_allTableAdapter;
        private purchase_dbDataSetTableAdapters.purchase_order_allTableAdapter purchase_order_allTableAdapter1;
    }
}
