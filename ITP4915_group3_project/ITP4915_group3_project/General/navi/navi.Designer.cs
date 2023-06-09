
namespace ITP4915_group3_project.General.navi
{
    partial class navi
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
            this.kryptonButtonRestaurant = new Krypton.Toolkit.KryptonButton();
            this.kryptonButtonWarehosue = new Krypton.Toolkit.KryptonButton();
            this.kryptonButtonPurchase = new Krypton.Toolkit.KryptonButton();
            this.kryptonButtonDelivery = new Krypton.Toolkit.KryptonButton();
            this.kryptonButtonCategory = new Krypton.Toolkit.KryptonButton();
            this.kryptonButtonAccounting = new Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // kryptonButtonRestaurant
            // 
            this.kryptonButtonRestaurant.CornerRoundingRadius = -1F;
            this.kryptonButtonRestaurant.Location = new System.Drawing.Point(89, 50);
            this.kryptonButtonRestaurant.Name = "kryptonButtonRestaurant";
            this.kryptonButtonRestaurant.Size = new System.Drawing.Size(90, 25);
            this.kryptonButtonRestaurant.TabIndex = 0;
            this.kryptonButtonRestaurant.Values.Text = "Restaurant";
            this.kryptonButtonRestaurant.Click += new System.EventHandler(this.kryptonButtonRestaurant_Click);
            // 
            // kryptonButtonWarehosue
            // 
            this.kryptonButtonWarehosue.CornerRoundingRadius = -1F;
            this.kryptonButtonWarehosue.Location = new System.Drawing.Point(89, 100);
            this.kryptonButtonWarehosue.Name = "kryptonButtonWarehosue";
            this.kryptonButtonWarehosue.Size = new System.Drawing.Size(90, 25);
            this.kryptonButtonWarehosue.TabIndex = 1;
            this.kryptonButtonWarehosue.Values.Text = "Warehosue";
            // 
            // kryptonButtonPurchase
            // 
            this.kryptonButtonPurchase.CornerRoundingRadius = -1F;
            this.kryptonButtonPurchase.Location = new System.Drawing.Point(89, 149);
            this.kryptonButtonPurchase.Name = "kryptonButtonPurchase";
            this.kryptonButtonPurchase.Size = new System.Drawing.Size(90, 25);
            this.kryptonButtonPurchase.TabIndex = 2;
            this.kryptonButtonPurchase.Values.Text = "Purchase";
            // 
            // kryptonButtonDelivery
            // 
            this.kryptonButtonDelivery.CornerRoundingRadius = -1F;
            this.kryptonButtonDelivery.Location = new System.Drawing.Point(89, 212);
            this.kryptonButtonDelivery.Name = "kryptonButtonDelivery";
            this.kryptonButtonDelivery.Size = new System.Drawing.Size(90, 25);
            this.kryptonButtonDelivery.TabIndex = 3;
            this.kryptonButtonDelivery.Values.Text = "Delivery";
            // 
            // kryptonButtonCategory
            // 
            this.kryptonButtonCategory.CornerRoundingRadius = -1F;
            this.kryptonButtonCategory.Location = new System.Drawing.Point(89, 272);
            this.kryptonButtonCategory.Name = "kryptonButtonCategory";
            this.kryptonButtonCategory.Size = new System.Drawing.Size(90, 25);
            this.kryptonButtonCategory.TabIndex = 4;
            this.kryptonButtonCategory.Values.Text = "Category";
            // 
            // kryptonButtonAccounting
            // 
            this.kryptonButtonAccounting.CornerRoundingRadius = -1F;
            this.kryptonButtonAccounting.Location = new System.Drawing.Point(89, 336);
            this.kryptonButtonAccounting.Name = "kryptonButtonAccounting";
            this.kryptonButtonAccounting.Size = new System.Drawing.Size(90, 25);
            this.kryptonButtonAccounting.TabIndex = 5;
            this.kryptonButtonAccounting.Values.Text = "Accounting";
            // 
            // navi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kryptonButtonAccounting);
            this.Controls.Add(this.kryptonButtonCategory);
            this.Controls.Add(this.kryptonButtonDelivery);
            this.Controls.Add(this.kryptonButtonPurchase);
            this.Controls.Add(this.kryptonButtonWarehosue);
            this.Controls.Add(this.kryptonButtonRestaurant);
            this.Name = "navi";
            this.Text = "navi";
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonButton kryptonButtonRestaurant;
        private Krypton.Toolkit.KryptonButton kryptonButtonWarehosue;
        private Krypton.Toolkit.KryptonButton kryptonButtonPurchase;
        private Krypton.Toolkit.KryptonButton kryptonButtonDelivery;
        private Krypton.Toolkit.KryptonButton kryptonButtonCategory;
        private Krypton.Toolkit.KryptonButton kryptonButtonAccounting;
    }
}