
namespace ITP4915_group3_project.Purchase.set_rule
{
    partial class header
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
            this.kryptonLabelTitle = new Krypton.Toolkit.KryptonLabel();
            this.kryptonPanelHeader = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelHeader)).BeginInit();
            this.kryptonPanelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonLabelTitle
            // 
            this.kryptonLabelTitle.Location = new System.Drawing.Point(4, 13);
            this.kryptonLabelTitle.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabelTitle.Name = "kryptonLabelTitle";
            this.kryptonLabelTitle.Size = new System.Drawing.Size(93, 35);
            this.kryptonLabelTitle.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabelTitle.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelTitle.TabIndex = 0;
            this.kryptonLabelTitle.Values.Text = "Setting";
            // 
            // kryptonPanelHeader
            // 
            this.kryptonPanelHeader.Controls.Add(this.kryptonLabelTitle);
            this.kryptonPanelHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonPanelHeader.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanelHeader.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanelHeader.Name = "kryptonPanelHeader";
            this.kryptonPanelHeader.Size = new System.Drawing.Size(636, 55);
            this.kryptonPanelHeader.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonPanelHeader.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonPanelHeader.TabIndex = 50;
            // 
            // header
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanelHeader);
            this.Name = "header";
            this.Size = new System.Drawing.Size(636, 55);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelHeader)).EndInit();
            this.kryptonPanelHeader.ResumeLayout(false);
            this.kryptonPanelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel kryptonLabelTitle;
        private Krypton.Toolkit.KryptonPanel kryptonPanelHeader;
    }
}
