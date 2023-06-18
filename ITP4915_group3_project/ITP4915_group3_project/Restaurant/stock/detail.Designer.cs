
namespace ITP4915_group3_project.Restaurant.stock
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label qtyLabel;
            this.kryptonPanelContent = new Krypton.Toolkit.KryptonPanel();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.restaurant_stock_detailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurant_dbDataSet = new ITP4915_group3_project.restaurant_dbDataSet();
            this.kryptonButtonEdit = new Krypton.Toolkit.KryptonButton();
            this.kryptonTextBoxBrand = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabelBrand = new Krypton.Toolkit.KryptonLabel();
            this.kryptonRichTextBoxRemarks = new Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonLabelRemarks = new Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBoxCategory = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabelCategory = new Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBoxName = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabelName = new Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBoxID = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabelID = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelBack = new Krypton.Toolkit.KryptonLabel();
            this.labelDetail = new System.Windows.Forms.Label();
            this.tableAdapterManager = new ITP4915_group3_project.restaurant_dbDataSetTableAdapters.TableAdapterManager();
            qtyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelContent)).BeginInit();
            this.kryptonPanelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restaurant_stock_detailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurant_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // qtyLabel
            // 
            qtyLabel.AutoSize = true;
            qtyLabel.Location = new System.Drawing.Point(181, 208);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new System.Drawing.Size(23, 12);
            qtyLabel.TabIndex = 222;
            qtyLabel.Text = "qty:";
            // 
            // kryptonPanelContent
            // 
            this.kryptonPanelContent.Controls.Add(qtyLabel);
            this.kryptonPanelContent.Controls.Add(this.qtyTextBox);
            this.kryptonPanelContent.Controls.Add(this.kryptonButtonEdit);
            this.kryptonPanelContent.Controls.Add(this.kryptonTextBoxBrand);
            this.kryptonPanelContent.Controls.Add(this.kryptonLabelBrand);
            this.kryptonPanelContent.Controls.Add(this.kryptonRichTextBoxRemarks);
            this.kryptonPanelContent.Controls.Add(this.kryptonLabelRemarks);
            this.kryptonPanelContent.Controls.Add(this.kryptonTextBoxCategory);
            this.kryptonPanelContent.Controls.Add(this.kryptonLabelCategory);
            this.kryptonPanelContent.Controls.Add(this.kryptonTextBoxName);
            this.kryptonPanelContent.Controls.Add(this.kryptonLabelName);
            this.kryptonPanelContent.Controls.Add(this.kryptonTextBoxID);
            this.kryptonPanelContent.Controls.Add(this.kryptonLabelID);
            this.kryptonPanelContent.Controls.Add(this.kryptonLabelBack);
            this.kryptonPanelContent.Controls.Add(this.labelDetail);
            this.kryptonPanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanelContent.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanelContent.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanelContent.Name = "kryptonPanelContent";
            this.kryptonPanelContent.Size = new System.Drawing.Size(800, 500);
            this.kryptonPanelContent.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPanelContent.TabIndex = 1;
            this.kryptonPanelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonPanelContent_Paint);
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.restaurant_stock_detailBindingSource, "qty", true));
            this.qtyTextBox.Location = new System.Drawing.Point(210, 205);
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.ReadOnly = true;
            this.qtyTextBox.Size = new System.Drawing.Size(100, 22);
            this.qtyTextBox.TabIndex = 223;
            // 
            // restaurant_stock_detailBindingSource
            // 
            this.restaurant_stock_detailBindingSource.DataMember = "restaurant_stock_detail";
            this.restaurant_stock_detailBindingSource.DataSource = this.restaurant_dbDataSet;
            // 
            // restaurant_dbDataSet
            // 
            this.restaurant_dbDataSet.DataSetName = "restaurant_dbDataSet";
            this.restaurant_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kryptonButtonEdit
            // 
            this.kryptonButtonEdit.CornerRoundingRadius = 25F;
            this.kryptonButtonEdit.Location = new System.Drawing.Point(586, 60);
            this.kryptonButtonEdit.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonButtonEdit.Name = "kryptonButtonEdit";
            this.kryptonButtonEdit.Size = new System.Drawing.Size(97, 30);
            this.kryptonButtonEdit.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonButtonEdit.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonButtonEdit.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonButtonEdit.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonButtonEdit.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButtonEdit.StateCommon.Border.Rounding = 25F;
            this.kryptonButtonEdit.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButtonEdit.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButtonEdit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.kryptonButtonEdit.TabIndex = 222;
            this.kryptonButtonEdit.Values.Text = "Edit";
            this.kryptonButtonEdit.Click += new System.EventHandler(this.kryptonButtonEdit_Click);
            // 
            // kryptonTextBoxBrand
            // 
            this.kryptonTextBoxBrand.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.restaurant_stock_detailBindingSource, "name", true));
            this.kryptonTextBoxBrand.Location = new System.Drawing.Point(419, 164);
            this.kryptonTextBoxBrand.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonTextBoxBrand.Name = "kryptonTextBoxBrand";
            this.kryptonTextBoxBrand.ReadOnly = true;
            this.kryptonTextBoxBrand.Size = new System.Drawing.Size(100, 22);
            this.kryptonTextBoxBrand.StateCommon.Back.Color1 = System.Drawing.Color.LightGray;
            this.kryptonTextBoxBrand.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonTextBoxBrand.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonTextBoxBrand.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBoxBrand.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.kryptonTextBoxBrand.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBoxBrand.TabIndex = 221;
            this.kryptonTextBoxBrand.Text = "brand_name";
            this.kryptonTextBoxBrand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonLabelBrand
            // 
            this.kryptonLabelBrand.Location = new System.Drawing.Point(369, 164);
            this.kryptonLabelBrand.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabelBrand.Name = "kryptonLabelBrand";
            this.kryptonLabelBrand.Size = new System.Drawing.Size(48, 19);
            this.kryptonLabelBrand.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonLabelBrand.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelBrand.TabIndex = 220;
            this.kryptonLabelBrand.Values.Text = "Brand:";
            // 
            // kryptonRichTextBoxRemarks
            // 
            this.kryptonRichTextBoxRemarks.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.restaurant_stock_detailBindingSource, "remarks", true));
            this.kryptonRichTextBoxRemarks.Location = new System.Drawing.Point(214, 250);
            this.kryptonRichTextBoxRemarks.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonRichTextBoxRemarks.Name = "kryptonRichTextBoxRemarks";
            this.kryptonRichTextBoxRemarks.Size = new System.Drawing.Size(304, 91);
            this.kryptonRichTextBoxRemarks.StateCommon.Back.Color1 = System.Drawing.Color.LightGray;
            this.kryptonRichTextBoxRemarks.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonRichTextBoxRemarks.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonRichTextBoxRemarks.TabIndex = 219;
            this.kryptonRichTextBoxRemarks.Text = "Remarks for item";
            // 
            // kryptonLabelRemarks
            // 
            this.kryptonLabelRemarks.Location = new System.Drawing.Point(149, 250);
            this.kryptonLabelRemarks.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabelRemarks.Name = "kryptonLabelRemarks";
            this.kryptonLabelRemarks.Size = new System.Drawing.Size(64, 19);
            this.kryptonLabelRemarks.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonLabelRemarks.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelRemarks.TabIndex = 218;
            this.kryptonLabelRemarks.Values.Text = "Remarks:";
            // 
            // kryptonTextBoxCategory
            // 
            this.kryptonTextBoxCategory.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.restaurant_stock_detailBindingSource, "category_name", true));
            this.kryptonTextBoxCategory.Location = new System.Drawing.Point(214, 164);
            this.kryptonTextBoxCategory.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonTextBoxCategory.Name = "kryptonTextBoxCategory";
            this.kryptonTextBoxCategory.ReadOnly = true;
            this.kryptonTextBoxCategory.Size = new System.Drawing.Size(100, 22);
            this.kryptonTextBoxCategory.StateCommon.Back.Color1 = System.Drawing.Color.LightGray;
            this.kryptonTextBoxCategory.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonTextBoxCategory.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonTextBoxCategory.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBoxCategory.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.kryptonTextBoxCategory.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBoxCategory.TabIndex = 213;
            this.kryptonTextBoxCategory.Text = "category_name";
            this.kryptonTextBoxCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonLabelCategory
            // 
            this.kryptonLabelCategory.Location = new System.Drawing.Point(148, 164);
            this.kryptonLabelCategory.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabelCategory.Name = "kryptonLabelCategory";
            this.kryptonLabelCategory.Size = new System.Drawing.Size(65, 19);
            this.kryptonLabelCategory.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonLabelCategory.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelCategory.TabIndex = 212;
            this.kryptonLabelCategory.Values.Text = "Category:";
            // 
            // kryptonTextBoxName
            // 
            this.kryptonTextBoxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.restaurant_stock_detailBindingSource, "item_name", true));
            this.kryptonTextBoxName.Location = new System.Drawing.Point(418, 128);
            this.kryptonTextBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonTextBoxName.Name = "kryptonTextBoxName";
            this.kryptonTextBoxName.ReadOnly = true;
            this.kryptonTextBoxName.Size = new System.Drawing.Size(100, 22);
            this.kryptonTextBoxName.StateCommon.Back.Color1 = System.Drawing.Color.LightGray;
            this.kryptonTextBoxName.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonTextBoxName.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonTextBoxName.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBoxName.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.kryptonTextBoxName.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBoxName.TabIndex = 211;
            this.kryptonTextBoxName.Text = "Item_name";
            this.kryptonTextBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonLabelName
            // 
            this.kryptonLabelName.Location = new System.Drawing.Point(369, 128);
            this.kryptonLabelName.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabelName.Name = "kryptonLabelName";
            this.kryptonLabelName.Size = new System.Drawing.Size(48, 19);
            this.kryptonLabelName.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonLabelName.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelName.TabIndex = 210;
            this.kryptonLabelName.Values.Text = "Name:";
            // 
            // kryptonTextBoxID
            // 
            this.kryptonTextBoxID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.restaurant_stock_detailBindingSource, "item_ID", true));
            this.kryptonTextBoxID.Location = new System.Drawing.Point(214, 128);
            this.kryptonTextBoxID.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonTextBoxID.Name = "kryptonTextBoxID";
            this.kryptonTextBoxID.ReadOnly = true;
            this.kryptonTextBoxID.Size = new System.Drawing.Size(100, 22);
            this.kryptonTextBoxID.StateCommon.Back.Color1 = System.Drawing.Color.LightGray;
            this.kryptonTextBoxID.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonTextBoxID.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonTextBoxID.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBoxID.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.kryptonTextBoxID.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBoxID.TabIndex = 209;
            this.kryptonTextBoxID.Text = "00000000";
            this.kryptonTextBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonLabelID
            // 
            this.kryptonLabelID.Location = new System.Drawing.Point(183, 128);
            this.kryptonLabelID.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabelID.Name = "kryptonLabelID";
            this.kryptonLabelID.Size = new System.Drawing.Size(29, 19);
            this.kryptonLabelID.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonLabelID.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelID.TabIndex = 208;
            this.kryptonLabelID.Values.Text = "ID:";
            // 
            // kryptonLabelBack
            // 
            this.kryptonLabelBack.Location = new System.Drawing.Point(98, 92);
            this.kryptonLabelBack.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabelBack.Name = "kryptonLabelBack";
            this.kryptonLabelBack.Size = new System.Drawing.Size(50, 16);
            this.kryptonLabelBack.StateCommon.ShortText.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.kryptonLabelBack.TabIndex = 207;
            this.kryptonLabelBack.Values.Text = "← Back";
            this.kryptonLabelBack.Click += new System.EventHandler(this.kryptonLabelBack_Click);
            // 
            // labelDetail
            // 
            this.labelDetail.AutoSize = true;
            this.labelDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.labelDetail.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetail.Location = new System.Drawing.Point(94, 60);
            this.labelDetail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDetail.Name = "labelDetail";
            this.labelDetail.Size = new System.Drawing.Size(59, 22);
            this.labelDetail.TabIndex = 136;
            this.labelDetail.Text = "Detail";
            // 
            // restaurant_stock_detailTableAdapter
            // 
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.purchasers_requestTableAdapter = null;
            this.tableAdapterManager.restaurant_stock_itemTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ITP4915_group3_project.restaurant_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanelContent);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "detail";
            this.Size = new System.Drawing.Size(800, 500);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelContent)).EndInit();
            this.kryptonPanelContent.ResumeLayout(false);
            this.kryptonPanelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restaurant_stock_detailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurant_dbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanelContent;
        private Krypton.Toolkit.KryptonButton kryptonButtonEdit;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBoxBrand;
        private Krypton.Toolkit.KryptonLabel kryptonLabelBrand;
        private Krypton.Toolkit.KryptonRichTextBox kryptonRichTextBoxRemarks;
        private Krypton.Toolkit.KryptonLabel kryptonLabelRemarks;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBoxCategory;
        private Krypton.Toolkit.KryptonLabel kryptonLabelCategory;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBoxName;
        private Krypton.Toolkit.KryptonLabel kryptonLabelName;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBoxID;
        private Krypton.Toolkit.KryptonLabel kryptonLabelID;
        private Krypton.Toolkit.KryptonLabel kryptonLabelBack;
        private System.Windows.Forms.Label labelDetail;
        private restaurant_dbDataSet restaurant_dbDataSet;
        private System.Windows.Forms.BindingSource restaurant_stock_detailBindingSource;
        private restaurant_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox qtyTextBox;
    }
}