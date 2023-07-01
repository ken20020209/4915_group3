
namespace ITP4915_group3_project.category.restaurant.create
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
            System.Windows.Forms.Label restaurant_IDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label address_IDLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label manager_IDLabel;
            this.kryptionPanelContent = new Krypton.Toolkit.KryptonPanel();
            this.kryptonButtonConfirm = new Krypton.Toolkit.KryptonButton();
            this.labelNew = new System.Windows.Forms.Label();
            this.category_dbDataSet = new ITP4915_group3_project.category_dbDataSet();
            this.restaurantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantTableAdapter = new ITP4915_group3_project.category_dbDataSetTableAdapters.restaurantTableAdapter();
            this.tableAdapterManager = new ITP4915_group3_project.category_dbDataSetTableAdapters.TableAdapterManager();
            this.restaurant_IDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.address_IDTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.manager_IDTextBox = new System.Windows.Forms.TextBox();
            restaurant_IDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            address_IDLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            manager_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kryptionPanelContent)).BeginInit();
            this.kryptionPanelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.category_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptionPanelContent
            // 
            this.kryptionPanelContent.Controls.Add(restaurant_IDLabel);
            this.kryptionPanelContent.Controls.Add(this.restaurant_IDTextBox);
            this.kryptionPanelContent.Controls.Add(nameLabel);
            this.kryptionPanelContent.Controls.Add(this.nameTextBox);
            this.kryptionPanelContent.Controls.Add(address_IDLabel);
            this.kryptionPanelContent.Controls.Add(this.address_IDTextBox);
            this.kryptionPanelContent.Controls.Add(typeLabel);
            this.kryptionPanelContent.Controls.Add(this.typeTextBox);
            this.kryptionPanelContent.Controls.Add(phoneLabel);
            this.kryptionPanelContent.Controls.Add(this.phoneTextBox);
            this.kryptionPanelContent.Controls.Add(manager_IDLabel);
            this.kryptionPanelContent.Controls.Add(this.manager_IDTextBox);
            this.kryptionPanelContent.Controls.Add(this.kryptonButtonConfirm);
            this.kryptionPanelContent.Controls.Add(this.labelNew);
            this.kryptionPanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptionPanelContent.Location = new System.Drawing.Point(0, 0);
            this.kryptionPanelContent.Margin = new System.Windows.Forms.Padding(2);
            this.kryptionPanelContent.Name = "kryptionPanelContent";
            this.kryptionPanelContent.Size = new System.Drawing.Size(780, 473);
            this.kryptionPanelContent.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptionPanelContent.TabIndex = 53;
            // 
            // kryptonButtonConfirm
            // 
            this.kryptonButtonConfirm.CornerRoundingRadius = 25F;
            this.kryptonButtonConfirm.Location = new System.Drawing.Point(621, 13);
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
            this.kryptonButtonConfirm.TabIndex = 212;
            this.kryptonButtonConfirm.Values.Text = "Comfirm";
            this.kryptonButtonConfirm.Click += new System.EventHandler(this.kryptonButtonConfirm_Click);
            // 
            // labelNew
            // 
            this.labelNew.AutoSize = true;
            this.labelNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.labelNew.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNew.Location = new System.Drawing.Point(21, 13);
            this.labelNew.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNew.Name = "labelNew";
            this.labelNew.Size = new System.Drawing.Size(48, 22);
            this.labelNew.TabIndex = 160;
            this.labelNew.Text = "New";
            // 
            // category_dbDataSet
            // 
            this.category_dbDataSet.DataSetName = "category_dbDataSet";
            this.category_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // restaurantBindingSource
            // 
            this.restaurantBindingSource.DataMember = "restaurant";
            this.restaurantBindingSource.DataSource = this.category_dbDataSet;
            // 
            // restaurantTableAdapter
            // 
            this.restaurantTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.addressTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.item_categoryTableAdapter = null;
            this.tableAdapterManager.itemTableAdapter = null;
            this.tableAdapterManager.partner_brand_restaurantTableAdapter = null;
            this.tableAdapterManager.partner_brandTableAdapter = null;
            this.tableAdapterManager.restaurant_stock_itemTableAdapter = null;
            this.tableAdapterManager.restaurantTableAdapter = this.restaurantTableAdapter;
            this.tableAdapterManager.supplier_contact_personTableAdapter = null;
            this.tableAdapterManager.supplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ITP4915_group3_project.category_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.warehouse_itemTableAdapter = null;
            this.tableAdapterManager.warehouseTableAdapter = null;
            // 
            // restaurant_IDLabel
            // 
            restaurant_IDLabel.AutoSize = true;
            restaurant_IDLabel.Location = new System.Drawing.Point(271, 150);
            restaurant_IDLabel.Name = "restaurant_IDLabel";
            restaurant_IDLabel.Size = new System.Drawing.Size(68, 12);
            restaurant_IDLabel.TabIndex = 212;
            restaurant_IDLabel.Text = "restaurant ID:";
            // 
            // restaurant_IDTextBox
            // 
            this.restaurant_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.restaurantBindingSource, "restaurant_ID", true));
            this.restaurant_IDTextBox.Location = new System.Drawing.Point(345, 147);
            this.restaurant_IDTextBox.Name = "restaurant_IDTextBox";
            this.restaurant_IDTextBox.Size = new System.Drawing.Size(100, 22);
            this.restaurant_IDTextBox.TabIndex = 213;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(271, 178);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(33, 12);
            nameLabel.TabIndex = 214;
            nameLabel.Text = "name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.restaurantBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(345, 175);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 215;
            // 
            // address_IDLabel
            // 
            address_IDLabel.AutoSize = true;
            address_IDLabel.Location = new System.Drawing.Point(271, 206);
            address_IDLabel.Name = "address_IDLabel";
            address_IDLabel.Size = new System.Drawing.Size(57, 12);
            address_IDLabel.TabIndex = 216;
            address_IDLabel.Text = "address ID:";
            // 
            // address_IDTextBox
            // 
            this.address_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.restaurantBindingSource, "address_ID", true));
            this.address_IDTextBox.Location = new System.Drawing.Point(345, 203);
            this.address_IDTextBox.Name = "address_IDTextBox";
            this.address_IDTextBox.Size = new System.Drawing.Size(100, 22);
            this.address_IDTextBox.TabIndex = 217;
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(271, 234);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(28, 12);
            typeLabel.TabIndex = 218;
            typeLabel.Text = "type:";
            // 
            // typeTextBox
            // 
            this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.restaurantBindingSource, "type", true));
            this.typeTextBox.Location = new System.Drawing.Point(345, 231);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(100, 22);
            this.typeTextBox.TabIndex = 219;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(271, 262);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(37, 12);
            phoneLabel.TabIndex = 220;
            phoneLabel.Text = "phone:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.restaurantBindingSource, "phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(345, 259);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 22);
            this.phoneTextBox.TabIndex = 221;
            // 
            // manager_IDLabel
            // 
            manager_IDLabel.AutoSize = true;
            manager_IDLabel.Location = new System.Drawing.Point(271, 290);
            manager_IDLabel.Name = "manager_IDLabel";
            manager_IDLabel.Size = new System.Drawing.Size(63, 12);
            manager_IDLabel.TabIndex = 222;
            manager_IDLabel.Text = "manager ID:";
            // 
            // manager_IDTextBox
            // 
            this.manager_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.restaurantBindingSource, "manager_ID", true));
            this.manager_IDTextBox.Location = new System.Drawing.Point(345, 287);
            this.manager_IDTextBox.Name = "manager_IDTextBox";
            this.manager_IDTextBox.Size = new System.Drawing.Size(100, 22);
            this.manager_IDTextBox.TabIndex = 223;
            // 
            // create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptionPanelContent);
            this.Name = "create";
            this.Size = new System.Drawing.Size(780, 473);
            ((System.ComponentModel.ISupportInitialize)(this.kryptionPanelContent)).EndInit();
            this.kryptionPanelContent.ResumeLayout(false);
            this.kryptionPanelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.category_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptionPanelContent;
        private Krypton.Toolkit.KryptonButton kryptonButtonConfirm;
        private System.Windows.Forms.Label labelNew;
        private category_dbDataSet category_dbDataSet;
        private System.Windows.Forms.BindingSource restaurantBindingSource;
        private category_dbDataSetTableAdapters.restaurantTableAdapter restaurantTableAdapter;
        private category_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox restaurant_IDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox address_IDTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox manager_IDTextBox;
    }
}
