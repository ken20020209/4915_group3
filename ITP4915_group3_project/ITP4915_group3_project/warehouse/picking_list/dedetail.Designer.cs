
namespace ITP4915_group3_project.warehouse.picking_list
{
    partial class dedetail
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
            System.Windows.Forms.Label instruction_IDLabel;
            System.Windows.Forms.Label handlerLabel;
            System.Windows.Forms.Label itemIDLabel;
            System.Windows.Forms.Label status_idLabel;
            System.Windows.Forms.Label purchasers_Request_idLabel;
            System.Windows.Forms.Label remarkLabel1;
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonButton8 = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonGroupBox2 = new Krypton.Toolkit.KryptonGroupBox();
            this.kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.warehouse_dbDataSet = new ITP4915_group3_project.warehouse_dbDataSet();
            this.warehousedispatchinstructionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehousedispatchinstructionTableAdapter = new ITP4915_group3_project.warehouse_dbDataSetTableAdapters.warehousedispatchinstructionTableAdapter();
            this.tableAdapterManager = new ITP4915_group3_project.warehouse_dbDataSetTableAdapters.TableAdapterManager();
            this.instruction_IDTextBox = new System.Windows.Forms.TextBox();
            this.handlerTextBox = new System.Windows.Forms.TextBox();
            this.itemIDTextBox = new System.Windows.Forms.TextBox();
            this.status_idTextBox = new System.Windows.Forms.TextBox();
            this.purchasers_Request_idTextBox = new System.Windows.Forms.TextBox();
            this.remarkRichTextBox = new System.Windows.Forms.RichTextBox();
            instruction_IDLabel = new System.Windows.Forms.Label();
            handlerLabel = new System.Windows.Forms.Label();
            itemIDLabel = new System.Windows.Forms.Label();
            status_idLabel = new System.Windows.Forms.Label();
            purchasers_Request_idLabel = new System.Windows.Forms.Label();
            remarkLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehousedispatchinstructionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonButton8);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel7);
            this.kryptonPanel1.Controls.Add(this.kryptonGroupBox2);
            this.kryptonPanel1.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPanel1.Controls.Add(this.label1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(827, 549);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonButton8
            // 
            this.kryptonButton8.CornerRoundingRadius = 25F;
            this.kryptonButton8.Location = new System.Drawing.Point(697, 48);
            this.kryptonButton8.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonButton8.Name = "kryptonButton8";
            this.kryptonButton8.Size = new System.Drawing.Size(97, 30);
            this.kryptonButton8.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(138)))), ((int)(((byte)(82)))));
            this.kryptonButton8.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(138)))), ((int)(((byte)(82)))));
            this.kryptonButton8.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(138)))), ((int)(((byte)(82)))));
            this.kryptonButton8.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(138)))), ((int)(((byte)(82)))));
            this.kryptonButton8.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton8.StateCommon.Border.Rounding = 25F;
            this.kryptonButton8.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton8.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton8.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.kryptonButton8.TabIndex = 229;
            this.kryptonButton8.Values.Text = "Finish";
            this.kryptonButton8.Click += new System.EventHandler(this.kryptonButton8_Click);
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(58, 72);
            this.kryptonLabel7.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(50, 16);
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.kryptonLabel7.TabIndex = 228;
            this.kryptonLabel7.Values.Text = "← Back";
            this.kryptonLabel7.Click += new System.EventHandler(this.kryptonLabel7_Click);
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.Location = new System.Drawing.Point(58, 293);
            this.kryptonGroupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.AutoScroll = true;
            this.kryptonGroupBox2.Panel.Controls.Add(remarkLabel1);
            this.kryptonGroupBox2.Panel.Controls.Add(this.remarkRichTextBox);
            this.kryptonGroupBox2.Panel.Controls.Add(itemIDLabel);
            this.kryptonGroupBox2.Panel.Controls.Add(this.itemIDTextBox);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(565, 184);
            this.kryptonGroupBox2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonGroupBox2.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonGroupBox2.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonGroupBox2.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox2.StateCommon.Border.Rounding = 12F;
            this.kryptonGroupBox2.StateCommon.Border.Width = 2;
            this.kryptonGroupBox2.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonGroupBox2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox2.TabIndex = 227;
            this.kryptonGroupBox2.Values.Heading = "ITEM";
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(58, 119);
            this.kryptonGroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(handlerLabel);
            this.kryptonGroupBox1.Panel.Controls.Add(this.status_idTextBox);
            this.kryptonGroupBox1.Panel.Controls.Add(status_idLabel);
            this.kryptonGroupBox1.Panel.Controls.Add(purchasers_Request_idLabel);
            this.kryptonGroupBox1.Panel.Controls.Add(this.purchasers_Request_idTextBox);
            this.kryptonGroupBox1.Panel.Controls.Add(instruction_IDLabel);
            this.kryptonGroupBox1.Panel.Controls.Add(this.handlerTextBox);
            this.kryptonGroupBox1.Panel.Controls.Add(this.instruction_IDTextBox);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(565, 143);
            this.kryptonGroupBox1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonGroupBox1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonGroupBox1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonGroupBox1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox1.StateCommon.Border.Rounding = 12F;
            this.kryptonGroupBox1.StateCommon.Border.Width = 2;
            this.kryptonGroupBox1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonGroupBox1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox1.TabIndex = 226;
            this.kryptonGroupBox1.Values.Heading = "GENERAL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 225;
            this.label1.Text = "Detail";
            // 
            // warehouse_dbDataSet
            // 
            this.warehouse_dbDataSet.DataSetName = "warehouse_dbDataSet";
            this.warehouse_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // warehousedispatchinstructionBindingSource
            // 
            this.warehousedispatchinstructionBindingSource.DataMember = "warehousedispatchinstruction";
            this.warehousedispatchinstructionBindingSource.DataSource = this.warehouse_dbDataSet;
            // 
            // warehousedispatchinstructionTableAdapter
            // 
            this.warehousedispatchinstructionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.delivery_request_handlerTableAdapter = null;
            this.tableAdapterManager.delivery_requestTableAdapter = null;
            this.tableAdapterManager.item_categoryTableAdapter = null;
            this.tableAdapterManager.itemTableAdapter = null;
            this.tableAdapterManager.purchase_order_allTableAdapter = null;
            this.tableAdapterManager.statusTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ITP4915_group3_project.warehouse_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            this.tableAdapterManager.warehouse_itemTableAdapter = null;
            this.tableAdapterManager.warehousedispatchinstructionTableAdapter = this.warehousedispatchinstructionTableAdapter;
            this.tableAdapterManager.warehouseTableAdapter = null;
            // 
            // instruction_IDLabel
            // 
            instruction_IDLabel.AutoSize = true;
            instruction_IDLabel.Location = new System.Drawing.Point(22, 20);
            instruction_IDLabel.Name = "instruction_IDLabel";
            instruction_IDLabel.Size = new System.Drawing.Size(73, 12);
            instruction_IDLabel.TabIndex = 0;
            instruction_IDLabel.Text = "Instruction ID:";
            // 
            // instruction_IDTextBox
            // 
            this.instruction_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.warehousedispatchinstructionBindingSource, "Instruction_ID", true));
            this.instruction_IDTextBox.Location = new System.Drawing.Point(137, 17);
            this.instruction_IDTextBox.Name = "instruction_IDTextBox";
            this.instruction_IDTextBox.ReadOnly = true;
            this.instruction_IDTextBox.Size = new System.Drawing.Size(100, 22);
            this.instruction_IDTextBox.TabIndex = 1;
            // 
            // handlerLabel
            // 
            handlerLabel.AutoSize = true;
            handlerLabel.Location = new System.Drawing.Point(288, 20);
            handlerLabel.Name = "handlerLabel";
            handlerLabel.Size = new System.Drawing.Size(43, 12);
            handlerLabel.TabIndex = 4;
            handlerLabel.Text = "handler:";
            // 
            // handlerTextBox
            // 
            this.handlerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.warehousedispatchinstructionBindingSource, "handler", true));
            this.handlerTextBox.Location = new System.Drawing.Point(403, 17);
            this.handlerTextBox.Name = "handlerTextBox";
            this.handlerTextBox.ReadOnly = true;
            this.handlerTextBox.Size = new System.Drawing.Size(100, 22);
            this.handlerTextBox.TabIndex = 5;
            // 
            // itemIDLabel
            // 
            itemIDLabel.AutoSize = true;
            itemIDLabel.Location = new System.Drawing.Point(52, 21);
            itemIDLabel.Name = "itemIDLabel";
            itemIDLabel.Size = new System.Drawing.Size(43, 12);
            itemIDLabel.TabIndex = 8;
            itemIDLabel.Text = "item ID:";
            // 
            // itemIDTextBox
            // 
            this.itemIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.warehousedispatchinstructionBindingSource, "itemID", true));
            this.itemIDTextBox.Location = new System.Drawing.Point(137, 18);
            this.itemIDTextBox.Name = "itemIDTextBox";
            this.itemIDTextBox.ReadOnly = true;
            this.itemIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.itemIDTextBox.TabIndex = 9;
            // 
            // status_idLabel
            // 
            status_idLabel.AutoSize = true;
            status_idLabel.Location = new System.Drawing.Point(288, 51);
            status_idLabel.Name = "status_idLabel";
            status_idLabel.Size = new System.Drawing.Size(45, 12);
            status_idLabel.TabIndex = 10;
            status_idLabel.Text = "status id:";
            // 
            // status_idTextBox
            // 
            this.status_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.warehousedispatchinstructionBindingSource, "status_id", true));
            this.status_idTextBox.Location = new System.Drawing.Point(403, 48);
            this.status_idTextBox.Name = "status_idTextBox";
            this.status_idTextBox.ReadOnly = true;
            this.status_idTextBox.Size = new System.Drawing.Size(100, 22);
            this.status_idTextBox.TabIndex = 11;
            // 
            // purchasers_Request_idLabel
            // 
            purchasers_Request_idLabel.AutoSize = true;
            purchasers_Request_idLabel.Location = new System.Drawing.Point(22, 48);
            purchasers_Request_idLabel.Name = "purchasers_Request_idLabel";
            purchasers_Request_idLabel.Size = new System.Drawing.Size(109, 12);
            purchasers_Request_idLabel.TabIndex = 12;
            purchasers_Request_idLabel.Text = "Purchasers Request id:";
            // 
            // purchasers_Request_idTextBox
            // 
            this.purchasers_Request_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.warehousedispatchinstructionBindingSource, "Purchasers_Request_id", true));
            this.purchasers_Request_idTextBox.Location = new System.Drawing.Point(137, 45);
            this.purchasers_Request_idTextBox.Name = "purchasers_Request_idTextBox";
            this.purchasers_Request_idTextBox.ReadOnly = true;
            this.purchasers_Request_idTextBox.Size = new System.Drawing.Size(100, 22);
            this.purchasers_Request_idTextBox.TabIndex = 13;
            // 
            // remarkLabel1
            // 
            remarkLabel1.AutoSize = true;
            remarkLabel1.Location = new System.Drawing.Point(54, 67);
            remarkLabel1.Name = "remarkLabel1";
            remarkLabel1.Size = new System.Drawing.Size(41, 12);
            remarkLabel1.TabIndex = 9;
            remarkLabel1.Text = "remark:";
            // 
            // remarkRichTextBox
            // 
            this.remarkRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.warehousedispatchinstructionBindingSource, "remark", true));
            this.remarkRichTextBox.Location = new System.Drawing.Point(137, 64);
            this.remarkRichTextBox.Name = "remarkRichTextBox";
            this.remarkRichTextBox.ReadOnly = true;
            this.remarkRichTextBox.Size = new System.Drawing.Size(366, 64);
            this.remarkRichTextBox.TabIndex = 10;
            this.remarkRichTextBox.Text = "";
            // 
            // dedetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "dedetail";
            this.Size = new System.Drawing.Size(827, 549);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.warehouse_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehousedispatchinstructionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton kryptonButton8;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private System.Windows.Forms.Label label1;
        private warehouse_dbDataSet warehouse_dbDataSet;
        private System.Windows.Forms.BindingSource warehousedispatchinstructionBindingSource;
        private warehouse_dbDataSetTableAdapters.warehousedispatchinstructionTableAdapter warehousedispatchinstructionTableAdapter;
        private warehouse_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.RichTextBox remarkRichTextBox;
        private System.Windows.Forms.TextBox itemIDTextBox;
        private System.Windows.Forms.TextBox status_idTextBox;
        private System.Windows.Forms.TextBox purchasers_Request_idTextBox;
        private System.Windows.Forms.TextBox handlerTextBox;
        private System.Windows.Forms.TextBox instruction_IDTextBox;
    }
}
