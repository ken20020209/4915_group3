
namespace ITP4915_group3_project.Restaurant.request_order.create
{
    partial class complete_detail
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
            this.kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            this.dataGridViewDetail = new System.Windows.Forms.DataGridView();
            this.item_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kryptonTextBoxQtyOfItems = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelback = new Krypton.Toolkit.KryptonLabel();
            this.kryptonButton7 = new Krypton.Toolkit.KryptonButton();
            this.kryptonButtonCountinue = new Krypton.Toolkit.KryptonButton();
            this.kryptonBorderEdge3 = new Krypton.Toolkit.KryptonBorderEdge();
            this.kryptonBorderEdge4 = new Krypton.Toolkit.KryptonBorderEdge();
            this.kryptonButton10 = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton11 = new Krypton.Toolkit.KryptonButton();
            this.label3 = new System.Windows.Forms.Label();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.CaptionStyle = Krypton.Toolkit.LabelStyle.GroupBoxCaption;
            this.kryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlGroupBox;
            this.kryptonGroupBox1.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.ControlGroupBox;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(11, 96);
            this.kryptonGroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.dataGridViewDetail);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(658, 170);
            this.kryptonGroupBox1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonGroupBox1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonGroupBox1.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonGroupBox1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonGroupBox1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox1.StateCommon.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonGroupBox1.StateCommon.Border.Rounding = 12F;
            this.kryptonGroupBox1.StateCommon.Border.Width = 2;
            this.kryptonGroupBox1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonGroupBox1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox1.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonGroupBox1.StateCommon.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonGroupBox1.TabIndex = 227;
            this.kryptonGroupBox1.Values.Heading = "ITEM";
            // 
            // dataGridViewDetail
            // 
            this.dataGridViewDetail.AllowUserToAddRows = false;
            this.dataGridViewDetail.AllowUserToDeleteRows = false;
            this.dataGridViewDetail.AllowUserToOrderColumns = true;
            this.dataGridViewDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item_ID,
            this.qty,
            this.item_Name});
            this.dataGridViewDetail.Location = new System.Drawing.Point(121, -4);
            this.dataGridViewDetail.Name = "dataGridViewDetail";
            this.dataGridViewDetail.RowTemplate.Height = 24;
            this.dataGridViewDetail.Size = new System.Drawing.Size(382, 141);
            this.dataGridViewDetail.TabIndex = 230;
            // 
            // item_ID
            // 
            this.item_ID.HeaderText = "item_ID";
            this.item_ID.Name = "item_ID";
            this.item_ID.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.HeaderText = "qty";
            this.qty.Name = "qty";
            // 
            // item_Name
            // 
            this.item_Name.HeaderText = "item_Name";
            this.item_Name.Name = "item_Name";
            this.item_Name.ReadOnly = true;
            // 
            // kryptonTextBoxQtyOfItems
            // 
            this.kryptonTextBoxQtyOfItems.Location = new System.Drawing.Point(500, 326);
            this.kryptonTextBoxQtyOfItems.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonTextBoxQtyOfItems.Name = "kryptonTextBoxQtyOfItems";
            this.kryptonTextBoxQtyOfItems.ReadOnly = true;
            this.kryptonTextBoxQtyOfItems.Size = new System.Drawing.Size(100, 22);
            this.kryptonTextBoxQtyOfItems.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonTextBoxQtyOfItems.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonTextBoxQtyOfItems.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBoxQtyOfItems.StateCommon.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonTextBoxQtyOfItems.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.kryptonTextBoxQtyOfItems.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBoxQtyOfItems.TabIndex = 226;
            this.kryptonTextBoxQtyOfItems.Text = "0";
            this.kryptonTextBoxQtyOfItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.kryptonLabel4.Location = new System.Drawing.Point(455, 326);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(35, 19);
            this.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.StateCommon.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonLabel4.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonLabel4.TabIndex = 225;
            this.kryptonLabel4.Values.Text = "Qty:";
            // 
            // kryptonLabelback
            // 
            this.kryptonLabelback.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.kryptonLabelback.Location = new System.Drawing.Point(11, 53);
            this.kryptonLabelback.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabelback.Name = "kryptonLabelback";
            this.kryptonLabelback.Size = new System.Drawing.Size(50, 16);
            this.kryptonLabelback.StateCommon.ShortText.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.kryptonLabelback.StateCommon.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonLabelback.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonLabelback.TabIndex = 224;
            this.kryptonLabelback.Values.Text = "← Back";
            this.kryptonLabelback.Click += new System.EventHandler(this.kryptonLabelback_Click);
            // 
            // kryptonButton7
            // 
            this.kryptonButton7.CornerRoundingRadius = 50F;
            this.kryptonButton7.Location = new System.Drawing.Point(200, 12);
            this.kryptonButton7.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonButton7.Name = "kryptonButton7";
            this.kryptonButton7.Size = new System.Drawing.Size(43, 43);
            this.kryptonButton7.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton7.StateCommon.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonButton7.StateCommon.Border.Rounding = 50F;
            this.kryptonButton7.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.kryptonButton7.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.kryptonButton7.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonButton7.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonButton7.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonButton7.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton7.StateNormal.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonButton7.StateNormal.Border.Width = 2;
            this.kryptonButton7.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonButton7.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton7.StateNormal.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonButton7.StateNormal.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonButton7.TabIndex = 221;
            this.kryptonButton7.Values.Text = "1";
            // 
            // kryptonButtonCountinue
            // 
            this.kryptonButtonCountinue.CornerRoundingRadius = 25F;
            this.kryptonButtonCountinue.Location = new System.Drawing.Point(522, 19);
            this.kryptonButtonCountinue.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonButtonCountinue.Name = "kryptonButtonCountinue";
            this.kryptonButtonCountinue.Size = new System.Drawing.Size(97, 30);
            this.kryptonButtonCountinue.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonButtonCountinue.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonButtonCountinue.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonButtonCountinue.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonButtonCountinue.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonButtonCountinue.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButtonCountinue.StateCommon.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonButtonCountinue.StateCommon.Border.Rounding = 25F;
            this.kryptonButtonCountinue.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButtonCountinue.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButtonCountinue.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.kryptonButtonCountinue.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonButtonCountinue.StateCommon.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonButtonCountinue.TabIndex = 223;
            this.kryptonButtonCountinue.Values.Text = "Countinue";
            this.kryptonButtonCountinue.Click += new System.EventHandler(this.kryptonButtonCountinue_Click);
            // 
            // kryptonBorderEdge3
            // 
            this.kryptonBorderEdge3.Location = new System.Drawing.Point(346, 33);
            this.kryptonBorderEdge3.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonBorderEdge3.Name = "kryptonBorderEdge3";
            this.kryptonBorderEdge3.Size = new System.Drawing.Size(65, 4);
            this.kryptonBorderEdge3.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonBorderEdge3.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonBorderEdge3.StateCommon.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonBorderEdge3.StateCommon.Width = 4;
            this.kryptonBorderEdge3.Text = "kryptonBorderEdge3";
            // 
            // kryptonBorderEdge4
            // 
            this.kryptonBorderEdge4.Location = new System.Drawing.Point(239, 33);
            this.kryptonBorderEdge4.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonBorderEdge4.Name = "kryptonBorderEdge4";
            this.kryptonBorderEdge4.Size = new System.Drawing.Size(67, 4);
            this.kryptonBorderEdge4.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonBorderEdge4.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonBorderEdge4.StateCommon.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonBorderEdge4.StateCommon.Width = 4;
            this.kryptonBorderEdge4.Text = "kryptonBorderEdge4";
            // 
            // kryptonButton10
            // 
            this.kryptonButton10.CornerRoundingRadius = 50F;
            this.kryptonButton10.Location = new System.Drawing.Point(410, 12);
            this.kryptonButton10.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonButton10.Name = "kryptonButton10";
            this.kryptonButton10.Size = new System.Drawing.Size(43, 43);
            this.kryptonButton10.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton10.StateCommon.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonButton10.StateCommon.Border.Rounding = 50F;
            this.kryptonButton10.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.kryptonButton10.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.kryptonButton10.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonButton10.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonButton10.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonButton10.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton10.StateNormal.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonButton10.StateNormal.Border.Width = 2;
            this.kryptonButton10.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonButton10.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton10.StateNormal.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonButton10.StateNormal.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonButton10.TabIndex = 222;
            this.kryptonButton10.Values.Text = "3";
            // 
            // kryptonButton11
            // 
            this.kryptonButton11.CornerRoundingRadius = 50F;
            this.kryptonButton11.Location = new System.Drawing.Point(303, 12);
            this.kryptonButton11.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonButton11.Name = "kryptonButton11";
            this.kryptonButton11.Size = new System.Drawing.Size(43, 43);
            this.kryptonButton11.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton11.StateCommon.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonButton11.StateCommon.Border.Rounding = 50F;
            this.kryptonButton11.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonButton11.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonButton11.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonButton11.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonButton11.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonButton11.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton11.StateNormal.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonButton11.StateNormal.Border.Width = 2;
            this.kryptonButton11.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton11.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton11.StateNormal.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonButton11.StateNormal.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonButton11.TabIndex = 220;
            this.kryptonButton11.Values.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 22);
            this.label3.TabIndex = 219;
            this.label3.Text = "Complete Detail";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonButtonCountinue);
            this.kryptonPanel1.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPanel1.Controls.Add(this.label3);
            this.kryptonPanel1.Controls.Add(this.kryptonTextBoxQtyOfItems);
            this.kryptonPanel1.Controls.Add(this.kryptonButton11);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel1.Controls.Add(this.kryptonButton10);
            this.kryptonPanel1.Controls.Add(this.kryptonLabelback);
            this.kryptonPanel1.Controls.Add(this.kryptonBorderEdge4);
            this.kryptonPanel1.Controls.Add(this.kryptonButton7);
            this.kryptonPanel1.Controls.Add(this.kryptonBorderEdge3);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(800, 500);
            this.kryptonPanel1.TabIndex = 230;
            // 
            // complete_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "complete_detail";
            this.Size = new System.Drawing.Size(800, 500);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBoxQtyOfItems;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabelback;
        private Krypton.Toolkit.KryptonButton kryptonButton7;
        private Krypton.Toolkit.KryptonButton kryptonButtonCountinue;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge3;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge4;
        private Krypton.Toolkit.KryptonButton kryptonButton10;
        private Krypton.Toolkit.KryptonButton kryptonButton11;
        private System.Windows.Forms.Label label3;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.DataGridView dataGridViewDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_Name;
    }
}