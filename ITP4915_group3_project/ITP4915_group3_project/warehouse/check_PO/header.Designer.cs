
namespace ITP4915_group3_project.warehouse.check_PO
{
    partial class header
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
            this.kryptonPanel = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabelTitle = new Krypton.Toolkit.KryptonLabel();
            this.kryptonButtonReview = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.kryptonButtonReview);
            this.kryptonPanel.Controls.Add(this.kryptonLabelTitle);
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(636, 55);
            this.kryptonPanel.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonPanel.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonPanel.TabIndex = 0;
            // 
            // kryptonLabelTitle
            // 
            this.kryptonLabelTitle.Location = new System.Drawing.Point(4, 13);
            this.kryptonLabelTitle.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabelTitle.Name = "kryptonLabelTitle";
            this.kryptonLabelTitle.Size = new System.Drawing.Size(185, 35);
            this.kryptonLabelTitle.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabelTitle.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelTitle.TabIndex = 1;
            this.kryptonLabelTitle.Values.Text = "Purchase Order";
            // 
            // kryptonButtonReview
            // 
            this.kryptonButtonReview.CornerRoundingRadius = 12F;
            this.kryptonButtonReview.Location = new System.Drawing.Point(289, 15);
            this.kryptonButtonReview.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonButtonReview.Name = "kryptonButtonReview";
            this.kryptonButtonReview.Size = new System.Drawing.Size(91, 33);
            this.kryptonButtonReview.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonButtonReview.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonButtonReview.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonButtonReview.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButtonReview.StateCommon.Border.Rounding = 12F;
            this.kryptonButtonReview.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButtonReview.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButtonReview.TabIndex = 211;
            this.kryptonButtonReview.Values.Text = "Review";
            this.kryptonButtonReview.Click += new System.EventHandler(this.kryptonButtonReview_Click);
            // 
            // header
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel);
            this.Name = "header";
            this.Size = new System.Drawing.Size(636, 55);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel;
        private Krypton.Toolkit.KryptonLabel kryptonLabelTitle;
        private Krypton.Toolkit.KryptonButton kryptonButtonReview;
    }
}
