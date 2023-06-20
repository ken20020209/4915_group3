
namespace ITP4915_group3_project.warehouse.delivery_note
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
            this.kryptonPanelHeader = new Krypton.Toolkit.KryptonPanel();
            this.kryptonBtnReview = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabelTitle = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelHeader)).BeginInit();
            this.kryptonPanelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanelHeader
            // 
            this.kryptonPanelHeader.Controls.Add(this.kryptonBtnReview);
            this.kryptonPanelHeader.Controls.Add(this.kryptonLabelTitle);
            this.kryptonPanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanelHeader.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanelHeader.Name = "kryptonPanelHeader";
            this.kryptonPanelHeader.Size = new System.Drawing.Size(636, 55);
            this.kryptonPanelHeader.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonPanelHeader.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonPanelHeader.TabIndex = 2;
            // 
            // kryptonBtnReview
            // 
            this.kryptonBtnReview.CornerRoundingRadius = 12F;
            this.kryptonBtnReview.Location = new System.Drawing.Point(297, 13);
            this.kryptonBtnReview.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonBtnReview.Name = "kryptonBtnReview";
            this.kryptonBtnReview.Size = new System.Drawing.Size(91, 33);
            this.kryptonBtnReview.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonBtnReview.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonBtnReview.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonBtnReview.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonBtnReview.StateCommon.Border.Rounding = 12F;
            this.kryptonBtnReview.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonBtnReview.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonBtnReview.TabIndex = 211;
            this.kryptonBtnReview.Values.Text = "Review";
            // 
            // kryptonLabelTitle
            // 
            this.kryptonLabelTitle.Location = new System.Drawing.Point(4, 13);
            this.kryptonLabelTitle.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabelTitle.Name = "kryptonLabelTitle";
            this.kryptonLabelTitle.Size = new System.Drawing.Size(172, 35);
            this.kryptonLabelTitle.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabelTitle.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelTitle.TabIndex = 1;
            this.kryptonLabelTitle.Values.Text = "Delivery Note";
            // 
            // header
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanelHeader);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "header";
            this.Size = new System.Drawing.Size(636, 55);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelHeader)).EndInit();
            this.kryptonPanelHeader.ResumeLayout(false);
            this.kryptonPanelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanelHeader;
        private Krypton.Toolkit.KryptonButton kryptonBtnReview;
        private Krypton.Toolkit.KryptonLabel kryptonLabelTitle;
    }
}
