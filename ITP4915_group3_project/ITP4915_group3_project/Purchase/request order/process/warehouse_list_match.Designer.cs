
namespace ITP4915_group3_project.Purchase.request_order.process
{
    partial class warehouse_list_match
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
            System.Windows.Forms.Label item_nameLabel;
            System.Windows.Forms.Label sizeLabel;
            System.Windows.Forms.Label qtyLabel;
            this.panel2 = new System.Windows.Forms.Panel();
            this.kryptonLabelRemark = new Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBoxRemark = new Krypton.Toolkit.KryptonTextBox();
            this.qtyKryptonTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.purchasers_requestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchase_dbDataSet = new ITP4915_group3_project.purchase_dbDataSet();
            this.warehouse_itemKryptonDataGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.warehouse_itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.item_nameTextBox = new System.Windows.Forms.TextBox();
            this.item_IDKryptonTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabelBack = new Krypton.Toolkit.KryptonLabel();
            this.kryptonButtonConfirm = new Krypton.Toolkit.KryptonButton();
            this.kryptonBorderEdge1 = new Krypton.Toolkit.KryptonBorderEdge();
            this.kryptonButton9 = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton7 = new Krypton.Toolkit.KryptonButton();
            this.label3 = new System.Windows.Forms.Label();
            this.purchasers_requestTableAdapter = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.purchasers_requestTableAdapter();
            this.tableAdapterManager = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.TableAdapterManager();
            this.itemTableAdapter = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.itemTableAdapter();
            this.warehouse_itemTableAdapter = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.warehouse_itemTableAdapter();
            this.purchase_order_allTableAdapter = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.purchase_order_allTableAdapter();
            this.warehousedispatchinstructionTableAdapter = new ITP4915_group3_project.purchase_dbDataSetTableAdapters.warehousedispatchinstructionTableAdapter();
            item_IDLabel = new System.Windows.Forms.Label();
            item_nameLabel = new System.Windows.Forms.Label();
            sizeLabel = new System.Windows.Forms.Label();
            qtyLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchasers_requestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse_itemKryptonDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse_itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // item_IDLabel
            // 
            item_IDLabel.AutoSize = true;
            item_IDLabel.Location = new System.Drawing.Point(74, 114);
            item_IDLabel.Name = "item_IDLabel";
            item_IDLabel.Size = new System.Drawing.Size(43, 12);
            item_IDLabel.TabIndex = 208;
            item_IDLabel.Text = "item ID:";
            // 
            // item_nameLabel
            // 
            item_nameLabel.AutoSize = true;
            item_nameLabel.Location = new System.Drawing.Point(260, 117);
            item_nameLabel.Name = "item_nameLabel";
            item_nameLabel.Size = new System.Drawing.Size(56, 12);
            item_nameLabel.TabIndex = 209;
            item_nameLabel.Text = "item name:";
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Location = new System.Drawing.Point(459, 120);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new System.Drawing.Size(25, 12);
            sizeLabel.TabIndex = 210;
            sizeLabel.Text = "size:";
            // 
            // qtyLabel
            // 
            qtyLabel.AutoSize = true;
            qtyLabel.Location = new System.Drawing.Point(58, 166);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new System.Drawing.Size(59, 12);
            qtyLabel.TabIndex = 211;
            qtyLabel.Text = "require qty:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.kryptonLabelRemark);
            this.panel2.Controls.Add(this.kryptonTextBoxRemark);
            this.panel2.Controls.Add(qtyLabel);
            this.panel2.Controls.Add(this.qtyKryptonTextBox);
            this.panel2.Controls.Add(this.warehouse_itemKryptonDataGridView);
            this.panel2.Controls.Add(sizeLabel);
            this.panel2.Controls.Add(this.sizeTextBox);
            this.panel2.Controls.Add(item_nameLabel);
            this.panel2.Controls.Add(this.item_nameTextBox);
            this.panel2.Controls.Add(item_IDLabel);
            this.panel2.Controls.Add(this.item_IDKryptonTextBox);
            this.panel2.Controls.Add(this.kryptonLabelBack);
            this.panel2.Controls.Add(this.kryptonButtonConfirm);
            this.panel2.Controls.Add(this.kryptonBorderEdge1);
            this.panel2.Controls.Add(this.kryptonButton9);
            this.panel2.Controls.Add(this.kryptonButton7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(812, 605);
            this.panel2.TabIndex = 7;
            // 
            // kryptonLabelRemark
            // 
            this.kryptonLabelRemark.Location = new System.Drawing.Point(426, 194);
            this.kryptonLabelRemark.Name = "kryptonLabelRemark";
            this.kryptonLabelRemark.Size = new System.Drawing.Size(49, 20);
            this.kryptonLabelRemark.TabIndex = 216;
            this.kryptonLabelRemark.Values.Text = "remark";
            // 
            // kryptonTextBoxRemark
            // 
            this.kryptonTextBoxRemark.Location = new System.Drawing.Point(490, 191);
            this.kryptonTextBoxRemark.Name = "kryptonTextBoxRemark";
            this.kryptonTextBoxRemark.Size = new System.Drawing.Size(100, 23);
            this.kryptonTextBoxRemark.TabIndex = 214;
            this.kryptonTextBoxRemark.Text = "kryptonTextBoxRemark";
            // 
            // qtyKryptonTextBox
            // 
            this.qtyKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchasers_requestBindingSource, "qty", true));
            this.qtyKryptonTextBox.Location = new System.Drawing.Point(123, 166);
            this.qtyKryptonTextBox.Name = "qtyKryptonTextBox";
            this.qtyKryptonTextBox.Size = new System.Drawing.Size(100, 23);
            this.qtyKryptonTextBox.TabIndex = 212;
            this.qtyKryptonTextBox.Text = "kryptonTextBox1";
            // 
            // purchasers_requestBindingSource
            // 
            this.purchasers_requestBindingSource.AllowNew = false;
            this.purchasers_requestBindingSource.DataMember = "purchasers_request";
            this.purchasers_requestBindingSource.DataSource = this.purchase_dbDataSet;
            // 
            // purchase_dbDataSet
            // 
            this.purchase_dbDataSet.DataSetName = "purchase_dbDataSet";
            this.purchase_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // warehouse_itemKryptonDataGridView
            // 
            this.warehouse_itemKryptonDataGridView.AllowUserToAddRows = false;
            this.warehouse_itemKryptonDataGridView.DataSource = this.warehouse_itemBindingSource;
            this.warehouse_itemKryptonDataGridView.Location = new System.Drawing.Point(76, 262);
            this.warehouse_itemKryptonDataGridView.Name = "warehouse_itemKryptonDataGridView";
            this.warehouse_itemKryptonDataGridView.RowTemplate.Height = 24;
            this.warehouse_itemKryptonDataGridView.Size = new System.Drawing.Size(611, 212);
            this.warehouse_itemKryptonDataGridView.TabIndex = 211;
            // 
            // warehouse_itemBindingSource
            // 
            this.warehouse_itemBindingSource.DataMember = "Warehouse_item_item_ID_fk";
            this.warehouse_itemBindingSource.DataSource = this.itemBindingSource;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "purchasers_request_item";
            this.itemBindingSource.DataSource = this.purchasers_requestBindingSource;
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemBindingSource, "size", true));
            this.sizeTextBox.Location = new System.Drawing.Point(490, 117);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(100, 22);
            this.sizeTextBox.TabIndex = 211;
            // 
            // item_nameTextBox
            // 
            this.item_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemBindingSource, "item_name", true));
            this.item_nameTextBox.Location = new System.Drawing.Point(322, 114);
            this.item_nameTextBox.Name = "item_nameTextBox";
            this.item_nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.item_nameTextBox.TabIndex = 210;
            // 
            // item_IDKryptonTextBox
            // 
            this.item_IDKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchasers_requestBindingSource, "item_ID", true));
            this.item_IDKryptonTextBox.Location = new System.Drawing.Point(123, 114);
            this.item_IDKryptonTextBox.Name = "item_IDKryptonTextBox";
            this.item_IDKryptonTextBox.Size = new System.Drawing.Size(100, 23);
            this.item_IDKryptonTextBox.TabIndex = 209;
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
            this.kryptonLabelBack.Values.Text = "← Back";
            this.kryptonLabelBack.Click += new System.EventHandler(this.kryptonLabelBack_Click);
            // 
            // kryptonButtonConfirm
            // 
            this.kryptonButtonConfirm.CornerRoundingRadius = 25F;
            this.kryptonButtonConfirm.Location = new System.Drawing.Point(590, 13);
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
            // kryptonBorderEdge1
            // 
            this.kryptonBorderEdge1.Location = new System.Drawing.Point(286, 27);
            this.kryptonBorderEdge1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            this.kryptonBorderEdge1.Size = new System.Drawing.Size(67, 4);
            this.kryptonBorderEdge1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonBorderEdge1.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonBorderEdge1.StateCommon.Width = 4;
            this.kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // kryptonButton9
            // 
            this.kryptonButton9.CornerRoundingRadius = 50F;
            this.kryptonButton9.Location = new System.Drawing.Point(246, 5);
            this.kryptonButton9.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonButton9.Name = "kryptonButton9";
            this.kryptonButton9.Size = new System.Drawing.Size(43, 43);
            this.kryptonButton9.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton9.StateCommon.Border.Rounding = 50F;
            this.kryptonButton9.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.kryptonButton9.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.kryptonButton9.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonButton9.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonButton9.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton9.StateNormal.Border.Width = 2;
            this.kryptonButton9.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonButton9.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton9.TabIndex = 46;
            this.kryptonButton9.Values.Text = "1";
            // 
            // kryptonButton7
            // 
            this.kryptonButton7.CornerRoundingRadius = 50F;
            this.kryptonButton7.Location = new System.Drawing.Point(351, 4);
            this.kryptonButton7.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonButton7.Name = "kryptonButton7";
            this.kryptonButton7.Size = new System.Drawing.Size(43, 43);
            this.kryptonButton7.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton7.StateCommon.Border.Rounding = 50F;
            this.kryptonButton7.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonButton7.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonButton7.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonButton7.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonButton7.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton7.StateNormal.Border.Width = 2;
            this.kryptonButton7.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton7.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton7.TabIndex = 45;
            this.kryptonButton7.Values.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 22);
            this.label3.TabIndex = 44;
            this.label3.Text = "Select warehouse";
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
            this.tableAdapterManager.price_breaksTableAdapter = null;
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
            this.tableAdapterManager.warehouse_itemTableAdapter = this.warehouse_itemTableAdapter;
            this.tableAdapterManager.warehousedispatchinstructionTableAdapter = null;
            this.tableAdapterManager.warehouseTableAdapter = null;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // warehouse_itemTableAdapter
            // 
            this.warehouse_itemTableAdapter.ClearBeforeFill = true;
            // 
            // purchase_order_allTableAdapter
            // 
            this.purchase_order_allTableAdapter.ClearBeforeFill = true;
            // 
            // warehousedispatchinstructionTableAdapter
            // 
            this.warehousedispatchinstructionTableAdapter.ClearBeforeFill = true;
            // 
            // warehouse_list_match
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "warehouse_list_match";
            this.Size = new System.Drawing.Size(812, 605);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchasers_requestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse_itemKryptonDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse_itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabelBack;
        private Krypton.Toolkit.KryptonButton kryptonButtonConfirm;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private Krypton.Toolkit.KryptonButton kryptonButton9;
        private Krypton.Toolkit.KryptonButton kryptonButton7;
        private System.Windows.Forms.Label label3;
        private purchase_dbDataSet purchase_dbDataSet;
        private System.Windows.Forms.BindingSource purchasers_requestBindingSource;
        private purchase_dbDataSetTableAdapters.purchasers_requestTableAdapter purchasers_requestTableAdapter;
        private purchase_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Krypton.Toolkit.KryptonDataGridView warehouse_itemKryptonDataGridView;
        private System.Windows.Forms.BindingSource warehouse_itemBindingSource;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.TextBox item_nameTextBox;
        private Krypton.Toolkit.KryptonTextBox item_IDKryptonTextBox;
        private purchase_dbDataSetTableAdapters.itemTableAdapter itemTableAdapter;
        private purchase_dbDataSetTableAdapters.warehouse_itemTableAdapter warehouse_itemTableAdapter;
        private Krypton.Toolkit.KryptonTextBox qtyKryptonTextBox;
        private purchase_dbDataSetTableAdapters.purchase_order_allTableAdapter purchase_order_allTableAdapter;
        private Krypton.Toolkit.KryptonLabel kryptonLabelRemark;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBoxRemark;
        private purchase_dbDataSetTableAdapters.warehousedispatchinstructionTableAdapter warehousedispatchinstructionTableAdapter;
    }
}