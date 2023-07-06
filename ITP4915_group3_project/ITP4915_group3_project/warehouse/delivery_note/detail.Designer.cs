
namespace ITP4915_group3_project.warehouse.delivery_note
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
            System.Windows.Forms.Label delivery_request_IDLabel;
            System.Windows.Forms.Label delivery_address_IDLabel;
            System.Windows.Forms.Label receive_address_IDLabel;
            System.Windows.Forms.Label item_IDLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label status_IDLabel;
            System.Windows.Forms.Label create_dateLabel;
            System.Windows.Forms.Label delivery_dateLabel;
            System.Windows.Forms.Label receive_timeLabel;
            System.Windows.Forms.Label delivery_timeLabel;
            System.Windows.Forms.Label vehicle_IDLabel;
            this.kryptonPanelContent = new Krypton.Toolkit.KryptonPanel();
            this.kryptonButtonSign = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.delivery_dbDataSet = new ITP4915_group3_project.delivery_dbDataSet();
            this.delivery_requestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.delivery_requestTableAdapter = new ITP4915_group3_project.delivery_dbDataSetTableAdapters.delivery_requestTableAdapter();
            this.tableAdapterManager = new ITP4915_group3_project.delivery_dbDataSetTableAdapters.TableAdapterManager();
            this.delivery_request_IDTextBox = new System.Windows.Forms.TextBox();
            this.delivery_address_IDTextBox = new System.Windows.Forms.TextBox();
            this.receive_address_IDTextBox = new System.Windows.Forms.TextBox();
            this.item_IDTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.status_IDTextBox = new System.Windows.Forms.TextBox();
            this.create_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.delivery_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.receive_timeTextBox = new System.Windows.Forms.TextBox();
            this.delivery_timeTextBox = new System.Windows.Forms.TextBox();
            this.vehicle_IDTextBox = new System.Windows.Forms.TextBox();
            delivery_request_IDLabel = new System.Windows.Forms.Label();
            delivery_address_IDLabel = new System.Windows.Forms.Label();
            receive_address_IDLabel = new System.Windows.Forms.Label();
            item_IDLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            status_IDLabel = new System.Windows.Forms.Label();
            create_dateLabel = new System.Windows.Forms.Label();
            delivery_dateLabel = new System.Windows.Forms.Label();
            receive_timeLabel = new System.Windows.Forms.Label();
            delivery_timeLabel = new System.Windows.Forms.Label();
            vehicle_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelContent)).BeginInit();
            this.kryptonPanelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delivery_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delivery_requestBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanelContent
            // 
            this.kryptonPanelContent.AutoScroll = true;
            this.kryptonPanelContent.Controls.Add(delivery_request_IDLabel);
            this.kryptonPanelContent.Controls.Add(this.delivery_request_IDTextBox);
            this.kryptonPanelContent.Controls.Add(delivery_address_IDLabel);
            this.kryptonPanelContent.Controls.Add(this.delivery_address_IDTextBox);
            this.kryptonPanelContent.Controls.Add(receive_address_IDLabel);
            this.kryptonPanelContent.Controls.Add(this.receive_address_IDTextBox);
            this.kryptonPanelContent.Controls.Add(item_IDLabel);
            this.kryptonPanelContent.Controls.Add(this.item_IDTextBox);
            this.kryptonPanelContent.Controls.Add(quantityLabel);
            this.kryptonPanelContent.Controls.Add(this.quantityTextBox);
            this.kryptonPanelContent.Controls.Add(status_IDLabel);
            this.kryptonPanelContent.Controls.Add(this.status_IDTextBox);
            this.kryptonPanelContent.Controls.Add(create_dateLabel);
            this.kryptonPanelContent.Controls.Add(this.create_dateDateTimePicker);
            this.kryptonPanelContent.Controls.Add(delivery_dateLabel);
            this.kryptonPanelContent.Controls.Add(this.delivery_dateDateTimePicker);
            this.kryptonPanelContent.Controls.Add(receive_timeLabel);
            this.kryptonPanelContent.Controls.Add(this.receive_timeTextBox);
            this.kryptonPanelContent.Controls.Add(delivery_timeLabel);
            this.kryptonPanelContent.Controls.Add(this.delivery_timeTextBox);
            this.kryptonPanelContent.Controls.Add(vehicle_IDLabel);
            this.kryptonPanelContent.Controls.Add(this.vehicle_IDTextBox);
            this.kryptonPanelContent.Controls.Add(this.kryptonButtonSign);
            this.kryptonPanelContent.Controls.Add(this.kryptonLabel8);
            this.kryptonPanelContent.Controls.Add(this.label1);
            this.kryptonPanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanelContent.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanelContent.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanelContent.Name = "kryptonPanelContent";
            this.kryptonPanelContent.Size = new System.Drawing.Size(827, 549);
            this.kryptonPanelContent.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPanelContent.TabIndex = 218;
            // 
            // kryptonButtonSign
            // 
            this.kryptonButtonSign.CornerRoundingRadius = 25F;
            this.kryptonButtonSign.Location = new System.Drawing.Point(670, 29);
            this.kryptonButtonSign.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonButtonSign.Name = "kryptonButtonSign";
            this.kryptonButtonSign.Size = new System.Drawing.Size(97, 30);
            this.kryptonButtonSign.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(138)))), ((int)(((byte)(82)))));
            this.kryptonButtonSign.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(138)))), ((int)(((byte)(82)))));
            this.kryptonButtonSign.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(138)))), ((int)(((byte)(82)))));
            this.kryptonButtonSign.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(138)))), ((int)(((byte)(82)))));
            this.kryptonButtonSign.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButtonSign.StateCommon.Border.Rounding = 25F;
            this.kryptonButtonSign.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButtonSign.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButtonSign.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.kryptonButtonSign.TabIndex = 218;
            this.kryptonButtonSign.Values.Text = "Sign";
            this.kryptonButtonSign.Click += new System.EventHandler(this.kryptonButtonSign_Click);
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(24, 43);
            this.kryptonLabel8.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(50, 16);
            this.kryptonLabel8.StateCommon.ShortText.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.kryptonLabel8.TabIndex = 215;
            this.kryptonLabel8.Values.Text = "← Back";
            this.kryptonLabel8.Click += new System.EventHandler(this.kryptonLabel8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 208;
            this.label1.Text = "Detail";
            // 
            // delivery_dbDataSet
            // 
            this.delivery_dbDataSet.DataSetName = "delivery_dbDataSet";
            this.delivery_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // delivery_requestBindingSource
            // 
            this.delivery_requestBindingSource.DataMember = "delivery_request";
            this.delivery_requestBindingSource.DataSource = this.delivery_dbDataSet;
            // 
            // delivery_requestTableAdapter
            // 
            this.delivery_requestTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.addressTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.delivery_request_handlerTableAdapter = null;
            this.tableAdapterManager.delivery_requestTableAdapter = this.delivery_requestTableAdapter;
            this.tableAdapterManager.item_categoryTableAdapter = null;
            this.tableAdapterManager.itemTableAdapter = null;
            this.tableAdapterManager.restaurantTableAdapter = null;
            this.tableAdapterManager.statusTableAdapter = null;
            this.tableAdapterManager.supplier_contact_personTableAdapter = null;
            this.tableAdapterManager.supplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ITP4915_group3_project.delivery_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            this.tableAdapterManager.warehouseTableAdapter = null;
            // 
            // delivery_request_IDLabel
            // 
            delivery_request_IDLabel.AutoSize = true;
            delivery_request_IDLabel.Location = new System.Drawing.Point(98, 100);
            delivery_request_IDLabel.Name = "delivery_request_IDLabel";
            delivery_request_IDLabel.Size = new System.Drawing.Size(97, 12);
            delivery_request_IDLabel.TabIndex = 218;
            delivery_request_IDLabel.Text = "delivery request ID:";
            // 
            // delivery_request_IDTextBox
            // 
            this.delivery_request_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.delivery_requestBindingSource, "delivery_request_ID", true));
            this.delivery_request_IDTextBox.Location = new System.Drawing.Point(202, 97);
            this.delivery_request_IDTextBox.Name = "delivery_request_IDTextBox";
            this.delivery_request_IDTextBox.Size = new System.Drawing.Size(200, 22);
            this.delivery_request_IDTextBox.TabIndex = 219;
            // 
            // delivery_address_IDLabel
            // 
            delivery_address_IDLabel.AutoSize = true;
            delivery_address_IDLabel.Location = new System.Drawing.Point(98, 128);
            delivery_address_IDLabel.Name = "delivery_address_IDLabel";
            delivery_address_IDLabel.Size = new System.Drawing.Size(98, 12);
            delivery_address_IDLabel.TabIndex = 220;
            delivery_address_IDLabel.Text = "delivery address ID:";
            // 
            // delivery_address_IDTextBox
            // 
            this.delivery_address_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.delivery_requestBindingSource, "delivery_address_ID", true));
            this.delivery_address_IDTextBox.Location = new System.Drawing.Point(202, 125);
            this.delivery_address_IDTextBox.Name = "delivery_address_IDTextBox";
            this.delivery_address_IDTextBox.Size = new System.Drawing.Size(200, 22);
            this.delivery_address_IDTextBox.TabIndex = 221;
            // 
            // receive_address_IDLabel
            // 
            receive_address_IDLabel.AutoSize = true;
            receive_address_IDLabel.Location = new System.Drawing.Point(98, 156);
            receive_address_IDLabel.Name = "receive_address_IDLabel";
            receive_address_IDLabel.Size = new System.Drawing.Size(93, 12);
            receive_address_IDLabel.TabIndex = 222;
            receive_address_IDLabel.Text = "receive address ID:";
            // 
            // receive_address_IDTextBox
            // 
            this.receive_address_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.delivery_requestBindingSource, "receive_address_ID", true));
            this.receive_address_IDTextBox.Location = new System.Drawing.Point(202, 153);
            this.receive_address_IDTextBox.Name = "receive_address_IDTextBox";
            this.receive_address_IDTextBox.Size = new System.Drawing.Size(200, 22);
            this.receive_address_IDTextBox.TabIndex = 223;
            // 
            // item_IDLabel
            // 
            item_IDLabel.AutoSize = true;
            item_IDLabel.Location = new System.Drawing.Point(98, 184);
            item_IDLabel.Name = "item_IDLabel";
            item_IDLabel.Size = new System.Drawing.Size(43, 12);
            item_IDLabel.TabIndex = 224;
            item_IDLabel.Text = "item ID:";
            // 
            // item_IDTextBox
            // 
            this.item_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.delivery_requestBindingSource, "item_ID", true));
            this.item_IDTextBox.Location = new System.Drawing.Point(202, 181);
            this.item_IDTextBox.Name = "item_IDTextBox";
            this.item_IDTextBox.Size = new System.Drawing.Size(200, 22);
            this.item_IDTextBox.TabIndex = 225;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(98, 212);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(46, 12);
            quantityLabel.TabIndex = 226;
            quantityLabel.Text = "quantity:";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.delivery_requestBindingSource, "quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(202, 209);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(200, 22);
            this.quantityTextBox.TabIndex = 227;
            // 
            // status_IDLabel
            // 
            status_IDLabel.AutoSize = true;
            status_IDLabel.Location = new System.Drawing.Point(98, 240);
            status_IDLabel.Name = "status_IDLabel";
            status_IDLabel.Size = new System.Drawing.Size(48, 12);
            status_IDLabel.TabIndex = 228;
            status_IDLabel.Text = "status ID:";
            // 
            // status_IDTextBox
            // 
            this.status_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.delivery_requestBindingSource, "status_ID", true));
            this.status_IDTextBox.Location = new System.Drawing.Point(202, 237);
            this.status_IDTextBox.Name = "status_IDTextBox";
            this.status_IDTextBox.Size = new System.Drawing.Size(200, 22);
            this.status_IDTextBox.TabIndex = 229;
            // 
            // create_dateLabel
            // 
            create_dateLabel.AutoSize = true;
            create_dateLabel.Location = new System.Drawing.Point(98, 269);
            create_dateLabel.Name = "create_dateLabel";
            create_dateLabel.Size = new System.Drawing.Size(57, 12);
            create_dateLabel.TabIndex = 230;
            create_dateLabel.Text = "create date:";
            // 
            // create_dateDateTimePicker
            // 
            this.create_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.delivery_requestBindingSource, "create_date", true));
            this.create_dateDateTimePicker.Location = new System.Drawing.Point(202, 265);
            this.create_dateDateTimePicker.Name = "create_dateDateTimePicker";
            this.create_dateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.create_dateDateTimePicker.TabIndex = 231;
            // 
            // delivery_dateLabel
            // 
            delivery_dateLabel.AutoSize = true;
            delivery_dateLabel.Location = new System.Drawing.Point(98, 297);
            delivery_dateLabel.Name = "delivery_dateLabel";
            delivery_dateLabel.Size = new System.Drawing.Size(68, 12);
            delivery_dateLabel.TabIndex = 232;
            delivery_dateLabel.Text = "delivery date:";
            // 
            // delivery_dateDateTimePicker
            // 
            this.delivery_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.delivery_requestBindingSource, "delivery_date", true));
            this.delivery_dateDateTimePicker.Location = new System.Drawing.Point(202, 293);
            this.delivery_dateDateTimePicker.Name = "delivery_dateDateTimePicker";
            this.delivery_dateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.delivery_dateDateTimePicker.TabIndex = 233;
            // 
            // receive_timeLabel
            // 
            receive_timeLabel.AutoSize = true;
            receive_timeLabel.Location = new System.Drawing.Point(98, 324);
            receive_timeLabel.Name = "receive_timeLabel";
            receive_timeLabel.Size = new System.Drawing.Size(64, 12);
            receive_timeLabel.TabIndex = 234;
            receive_timeLabel.Text = "receive time:";
            // 
            // receive_timeTextBox
            // 
            this.receive_timeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.delivery_requestBindingSource, "receive_time", true));
            this.receive_timeTextBox.Location = new System.Drawing.Point(202, 321);
            this.receive_timeTextBox.Name = "receive_timeTextBox";
            this.receive_timeTextBox.Size = new System.Drawing.Size(200, 22);
            this.receive_timeTextBox.TabIndex = 235;
            // 
            // delivery_timeLabel
            // 
            delivery_timeLabel.AutoSize = true;
            delivery_timeLabel.Location = new System.Drawing.Point(98, 352);
            delivery_timeLabel.Name = "delivery_timeLabel";
            delivery_timeLabel.Size = new System.Drawing.Size(69, 12);
            delivery_timeLabel.TabIndex = 236;
            delivery_timeLabel.Text = "delivery time:";
            // 
            // delivery_timeTextBox
            // 
            this.delivery_timeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.delivery_requestBindingSource, "delivery_time", true));
            this.delivery_timeTextBox.Location = new System.Drawing.Point(202, 349);
            this.delivery_timeTextBox.Name = "delivery_timeTextBox";
            this.delivery_timeTextBox.Size = new System.Drawing.Size(200, 22);
            this.delivery_timeTextBox.TabIndex = 237;
            // 
            // vehicle_IDLabel
            // 
            vehicle_IDLabel.AutoSize = true;
            vehicle_IDLabel.Location = new System.Drawing.Point(98, 380);
            vehicle_IDLabel.Name = "vehicle_IDLabel";
            vehicle_IDLabel.Size = new System.Drawing.Size(56, 12);
            vehicle_IDLabel.TabIndex = 238;
            vehicle_IDLabel.Text = "vehicle ID:";
            // 
            // vehicle_IDTextBox
            // 
            this.vehicle_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.delivery_requestBindingSource, "vehicle_ID", true));
            this.vehicle_IDTextBox.Location = new System.Drawing.Point(202, 377);
            this.vehicle_IDTextBox.Name = "vehicle_IDTextBox";
            this.vehicle_IDTextBox.Size = new System.Drawing.Size(200, 22);
            this.vehicle_IDTextBox.TabIndex = 239;
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
            ((System.ComponentModel.ISupportInitialize)(this.delivery_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delivery_requestBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanelContent;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonButton kryptonButtonSign;
        private delivery_dbDataSet delivery_dbDataSet;
        private System.Windows.Forms.BindingSource delivery_requestBindingSource;
        private delivery_dbDataSetTableAdapters.delivery_requestTableAdapter delivery_requestTableAdapter;
        private delivery_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox delivery_request_IDTextBox;
        private System.Windows.Forms.TextBox delivery_address_IDTextBox;
        private System.Windows.Forms.TextBox receive_address_IDTextBox;
        private System.Windows.Forms.TextBox item_IDTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox status_IDTextBox;
        private System.Windows.Forms.DateTimePicker create_dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker delivery_dateDateTimePicker;
        private System.Windows.Forms.TextBox receive_timeTextBox;
        private System.Windows.Forms.TextBox delivery_timeTextBox;
        private System.Windows.Forms.TextBox vehicle_IDTextBox;
    }
}
