﻿
namespace ITP4915_group3_project.category.brand.create
{
    partial class create
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
            this.kryptionPanelContent = new Krypton.Toolkit.KryptonPanel();
            this.kryptonButtonConfirm = new Krypton.Toolkit.KryptonButton();
            this.kryptonTextBoxType = new Krypton.Toolkit.KryptonTextBox();
            this.partner_brandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.category_dbDataSet = new ITP4915_group3_project.category_dbDataSet();
            this.kryptonLabelType = new Krypton.Toolkit.KryptonLabel();
            this.kryptonRichTextBoxRemarks = new Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonLabelRemarks = new Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBoxName = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabelName = new Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBoxID = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabelID = new Krypton.Toolkit.KryptonLabel();
            this.labelNew = new System.Windows.Forms.Label();
            this.partner_brandTableAdapter = new ITP4915_group3_project.category_dbDataSetTableAdapters.partner_brandTableAdapter();
            this.tableAdapterManager = new ITP4915_group3_project.category_dbDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.kryptionPanelContent)).BeginInit();
            this.kryptionPanelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partner_brandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.category_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptionPanelContent
            // 
            this.kryptionPanelContent.Controls.Add(this.kryptonButtonConfirm);
            this.kryptionPanelContent.Controls.Add(this.kryptonTextBoxType);
            this.kryptionPanelContent.Controls.Add(this.kryptonLabelType);
            this.kryptionPanelContent.Controls.Add(this.kryptonRichTextBoxRemarks);
            this.kryptionPanelContent.Controls.Add(this.kryptonLabelRemarks);
            this.kryptionPanelContent.Controls.Add(this.kryptonTextBoxName);
            this.kryptionPanelContent.Controls.Add(this.kryptonLabelName);
            this.kryptionPanelContent.Controls.Add(this.kryptonTextBoxID);
            this.kryptionPanelContent.Controls.Add(this.kryptonLabelID);
            this.kryptionPanelContent.Controls.Add(this.labelNew);
            this.kryptionPanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptionPanelContent.Location = new System.Drawing.Point(0, 0);
            this.kryptionPanelContent.Margin = new System.Windows.Forms.Padding(2);
            this.kryptionPanelContent.Name = "kryptionPanelContent";
            this.kryptionPanelContent.Size = new System.Drawing.Size(780, 473);
            this.kryptionPanelContent.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptionPanelContent.TabIndex = 52;
            // 
            // kryptonButtonConfirm
            // 
            this.kryptonButtonConfirm.CornerRoundingRadius = 25F;
            this.kryptonButtonConfirm.Location = new System.Drawing.Point(518, 13);
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
            // kryptonTextBoxType
            // 
            this.kryptonTextBoxType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partner_brandBindingSource, "type", true));
            this.kryptonTextBoxType.Location = new System.Drawing.Point(206, 157);
            this.kryptonTextBoxType.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonTextBoxType.Name = "kryptonTextBoxType";
            this.kryptonTextBoxType.Size = new System.Drawing.Size(100, 22);
            this.kryptonTextBoxType.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonTextBoxType.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonTextBoxType.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonTextBoxType.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBoxType.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.kryptonTextBoxType.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBoxType.TabIndex = 211;
            this.kryptonTextBoxType.Text = "type";
            this.kryptonTextBoxType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // partner_brandBindingSource
            // 
            this.partner_brandBindingSource.DataMember = "partner_brand";
            this.partner_brandBindingSource.DataSource = this.category_dbDataSet;
            // 
            // category_dbDataSet
            // 
            this.category_dbDataSet.DataSetName = "category_dbDataSet";
            this.category_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kryptonLabelType
            // 
            this.kryptonLabelType.Location = new System.Drawing.Point(161, 157);
            this.kryptonLabelType.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabelType.Name = "kryptonLabelType";
            this.kryptonLabelType.Size = new System.Drawing.Size(43, 19);
            this.kryptonLabelType.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonLabelType.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelType.TabIndex = 210;
            this.kryptonLabelType.Values.Text = "Type:";
            // 
            // kryptonRichTextBoxRemarks
            // 
            this.kryptonRichTextBoxRemarks.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partner_brandBindingSource, "remarks", true));
            this.kryptonRichTextBoxRemarks.Location = new System.Drawing.Point(206, 204);
            this.kryptonRichTextBoxRemarks.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonRichTextBoxRemarks.Name = "kryptonRichTextBoxRemarks";
            this.kryptonRichTextBoxRemarks.Size = new System.Drawing.Size(315, 76);
            this.kryptonRichTextBoxRemarks.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonRichTextBoxRemarks.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonRichTextBoxRemarks.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonRichTextBoxRemarks.TabIndex = 170;
            this.kryptonRichTextBoxRemarks.Text = "Remarks";
            // 
            // kryptonLabelRemarks
            // 
            this.kryptonLabelRemarks.Location = new System.Drawing.Point(141, 204);
            this.kryptonLabelRemarks.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabelRemarks.Name = "kryptonLabelRemarks";
            this.kryptonLabelRemarks.Size = new System.Drawing.Size(64, 19);
            this.kryptonLabelRemarks.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonLabelRemarks.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelRemarks.TabIndex = 169;
            this.kryptonLabelRemarks.Values.Text = "Remarks:";
            // 
            // kryptonTextBoxName
            // 
            this.kryptonTextBoxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partner_brandBindingSource, "name", true));
            this.kryptonTextBoxName.Location = new System.Drawing.Point(421, 157);
            this.kryptonTextBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonTextBoxName.Name = "kryptonTextBoxName";
            this.kryptonTextBoxName.Size = new System.Drawing.Size(100, 22);
            this.kryptonTextBoxName.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonTextBoxName.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonTextBoxName.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonTextBoxName.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBoxName.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.kryptonTextBoxName.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBoxName.TabIndex = 164;
            this.kryptonTextBoxName.Text = "ABCA Brand";
            this.kryptonTextBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonLabelName
            // 
            this.kryptonLabelName.Location = new System.Drawing.Point(372, 156);
            this.kryptonLabelName.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabelName.Name = "kryptonLabelName";
            this.kryptonLabelName.Size = new System.Drawing.Size(48, 19);
            this.kryptonLabelName.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonLabelName.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelName.TabIndex = 163;
            this.kryptonLabelName.Values.Text = "Name:";
            // 
            // kryptonTextBoxID
            // 
            this.kryptonTextBoxID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partner_brandBindingSource, "partner_brand_ID", true));
            this.kryptonTextBoxID.Location = new System.Drawing.Point(206, 117);
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
            this.kryptonTextBoxID.TabIndex = 162;
            this.kryptonTextBoxID.Text = "00001";
            this.kryptonTextBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonLabelID
            // 
            this.kryptonLabelID.Location = new System.Drawing.Point(175, 118);
            this.kryptonLabelID.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabelID.Name = "kryptonLabelID";
            this.kryptonLabelID.Size = new System.Drawing.Size(29, 19);
            this.kryptonLabelID.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonLabelID.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelID.TabIndex = 161;
            this.kryptonLabelID.Values.Text = "ID:";
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
            // partner_brandTableAdapter
            // 
            this.partner_brandTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.item_categoryTableAdapter = null;
            this.tableAdapterManager.itemTableAdapter = null;
            this.tableAdapterManager.partner_brand_restaurantTableAdapter = null;
            this.tableAdapterManager.partner_brandTableAdapter = this.partner_brandTableAdapter;
            this.tableAdapterManager.supplier_contact_personTableAdapter = null;
            this.tableAdapterManager.supplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ITP4915_group3_project.category_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            ((System.ComponentModel.ISupportInitialize)(this.partner_brandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.category_dbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptionPanelContent;
        private Krypton.Toolkit.KryptonButton kryptonButtonConfirm;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBoxType;
        private Krypton.Toolkit.KryptonLabel kryptonLabelType;
        private Krypton.Toolkit.KryptonRichTextBox kryptonRichTextBoxRemarks;
        private Krypton.Toolkit.KryptonLabel kryptonLabelRemarks;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBoxName;
        private Krypton.Toolkit.KryptonLabel kryptonLabelName;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBoxID;
        private Krypton.Toolkit.KryptonLabel kryptonLabelID;
        private System.Windows.Forms.Label labelNew;
        private System.Windows.Forms.BindingSource partner_brandBindingSource;
        private category_dbDataSet category_dbDataSet;
        private category_dbDataSetTableAdapters.partner_brandTableAdapter partner_brandTableAdapter;
        private category_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}
