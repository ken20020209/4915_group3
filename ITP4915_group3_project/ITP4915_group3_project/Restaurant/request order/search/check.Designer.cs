
namespace ITP4915_group3_project.Restaurant.request_order.search
{
    partial class check
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
            this.kryptonGroupContent = new Krypton.Toolkit.KryptonGroup();
            this.purchasers_requestDataGridView = new System.Windows.Forms.DataGridView();
            this.detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.kryptonGroup1 = new Krypton.Toolkit.KryptonGroup();
            this.kryptonPanel6 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonCheckButton5 = new Krypton.Toolkit.KryptonCheckButton();
            this.kryptonCheckButton6 = new Krypton.Toolkit.KryptonCheckButton();
            this.kryptonButtonSearch = new Krypton.Toolkit.KryptonButton();
            this.kryptonTextBoxSearchKeyWord = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonPanel4 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonCheckButton1 = new Krypton.Toolkit.KryptonCheckButton();
            this.kryptonCheckButton2 = new Krypton.Toolkit.KryptonCheckButton();
            this.kryptonCheckButton3 = new Krypton.Toolkit.KryptonCheckButton();
            this.kryptonCheckButton7 = new Krypton.Toolkit.KryptonCheckButton();
            this.kryptonCheckButton4 = new Krypton.Toolkit.KryptonCheckButton();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.purchasers_request_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasers_requestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurant_dbDataSet = new ITP4915_group3_project.restaurant_dbDataSet();
            this.purchasers_requestTableAdapter = new ITP4915_group3_project.restaurant_dbDataSetTableAdapters.purchasers_requestTableAdapter();
            this.tableAdapterManager = new ITP4915_group3_project.restaurant_dbDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupContent.Panel)).BeginInit();
            this.kryptonGroupContent.Panel.SuspendLayout();
            this.kryptonGroupContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchasers_requestDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).BeginInit();
            this.kryptonPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasers_requestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurant_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonGroupContent
            // 
            this.kryptonGroupContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonGroupContent.Location = new System.Drawing.Point(0, 0);
            this.kryptonGroupContent.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonGroupContent.Name = "kryptonGroupContent";
            // 
            // kryptonGroupContent.Panel
            // 
            this.kryptonGroupContent.Panel.AutoScroll = true;
            this.kryptonGroupContent.Panel.Controls.Add(this.purchasers_requestDataGridView);
            this.kryptonGroupContent.Panel.Controls.Add(this.kryptonGroup1);
            this.kryptonGroupContent.Panel.Controls.Add(this.pictureBox6);
            this.kryptonGroupContent.Panel.Controls.Add(this.kryptonLabel6);
            this.kryptonGroupContent.Size = new System.Drawing.Size(800, 500);
            this.kryptonGroupContent.TabIndex = 10;
            // 
            // purchasers_requestDataGridView
            // 
            this.purchasers_requestDataGridView.AutoGenerateColumns = false;
            this.purchasers_requestDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchasers_requestDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.purchasers_request_id,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn8,
            this.detail});
            this.purchasers_requestDataGridView.DataSource = this.purchasers_requestBindingSource;
            this.purchasers_requestDataGridView.Location = new System.Drawing.Point(122, 246);
            this.purchasers_requestDataGridView.Name = "purchasers_requestDataGridView";
            this.purchasers_requestDataGridView.RowTemplate.Height = 24;
            this.purchasers_requestDataGridView.Size = new System.Drawing.Size(568, 117);
            this.purchasers_requestDataGridView.TabIndex = 7;
            this.purchasers_requestDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.purchasers_requestDataGridView_CellContentClick);
            // 
            // detail
            // 
            this.detail.HeaderText = "detail";
            this.detail.Name = "detail";
            this.detail.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.detail.Text = "detail";
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.Location = new System.Drawing.Point(122, 38);
            this.kryptonGroup1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonGroup1.Name = "kryptonGroup1";
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonPanel6);
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonButtonSearch);
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonTextBoxSearchKeyWord);
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonPanel4);
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonCheckButton7);
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonCheckButton4);
            this.kryptonGroup1.Size = new System.Drawing.Size(554, 107);
            this.kryptonGroup1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonGroup1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonGroup1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroup1.StateCommon.Border.Rounding = 30F;
            this.kryptonGroup1.StateCommon.Border.Width = 2;
            this.kryptonGroup1.TabIndex = 5;
            // 
            // kryptonPanel6
            // 
            this.kryptonPanel6.Controls.Add(this.kryptonCheckButton5);
            this.kryptonPanel6.Controls.Add(this.kryptonCheckButton6);
            this.kryptonPanel6.Location = new System.Drawing.Point(290, 8);
            this.kryptonPanel6.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel6.Name = "kryptonPanel6";
            this.kryptonPanel6.Size = new System.Drawing.Size(153, 30);
            this.kryptonPanel6.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.kryptonPanel6.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.kryptonPanel6.TabIndex = 9;
            // 
            // kryptonCheckButton5
            // 
            this.kryptonCheckButton5.CornerRoundingRadius = 25F;
            this.kryptonCheckButton5.Location = new System.Drawing.Point(0, 0);
            this.kryptonCheckButton5.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonCheckButton5.Name = "kryptonCheckButton5";
            this.kryptonCheckButton5.Size = new System.Drawing.Size(83, 30);
            this.kryptonCheckButton5.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonCheckButton5.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonCheckButton5.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonCheckButton5.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonCheckButton5.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonCheckButton5.StateCommon.Border.Rounding = 25F;
            this.kryptonCheckButton5.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonCheckButton5.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckButton5.TabIndex = 7;
            this.kryptonCheckButton5.Values.Text = "Status1";
            // 
            // kryptonCheckButton6
            // 
            this.kryptonCheckButton6.CornerRoundingRadius = -1F;
            this.kryptonCheckButton6.Location = new System.Drawing.Point(69, 0);
            this.kryptonCheckButton6.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonCheckButton6.Name = "kryptonCheckButton6";
            this.kryptonCheckButton6.Size = new System.Drawing.Size(83, 30);
            this.kryptonCheckButton6.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.kryptonCheckButton6.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.kryptonCheckButton6.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.kryptonCheckButton6.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.kryptonCheckButton6.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonCheckButton6.StateNormal.Border.Rounding = 25F;
            this.kryptonCheckButton6.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonCheckButton6.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckButton6.TabIndex = 7;
            this.kryptonCheckButton6.Values.Text = "Status2";
            // 
            // kryptonButtonSearch
            // 
            this.kryptonButtonSearch.CornerRoundingRadius = 25F;
            this.kryptonButtonSearch.Location = new System.Drawing.Point(411, 52);
            this.kryptonButtonSearch.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonButtonSearch.Name = "kryptonButtonSearch";
            this.kryptonButtonSearch.Size = new System.Drawing.Size(97, 30);
            this.kryptonButtonSearch.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(138)))), ((int)(((byte)(82)))));
            this.kryptonButtonSearch.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(138)))), ((int)(((byte)(82)))));
            this.kryptonButtonSearch.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(138)))), ((int)(((byte)(82)))));
            this.kryptonButtonSearch.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(138)))), ((int)(((byte)(82)))));
            this.kryptonButtonSearch.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButtonSearch.StateCommon.Border.Rounding = 25F;
            this.kryptonButtonSearch.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButtonSearch.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButtonSearch.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.kryptonButtonSearch.TabIndex = 12;
            this.kryptonButtonSearch.Values.Text = "Search";
            this.kryptonButtonSearch.Click += new System.EventHandler(this.kryptonButtonSearch_Click);
            // 
            // kryptonTextBoxSearchKeyWord
            // 
            this.kryptonTextBoxSearchKeyWord.Location = new System.Drawing.Point(8, 8);
            this.kryptonTextBoxSearchKeyWord.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonTextBoxSearchKeyWord.Name = "kryptonTextBoxSearchKeyWord";
            this.kryptonTextBoxSearchKeyWord.Size = new System.Drawing.Size(244, 34);
            this.kryptonTextBoxSearchKeyWord.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.kryptonTextBoxSearchKeyWord.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonTextBoxSearchKeyWord.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonTextBoxSearchKeyWord.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBoxSearchKeyWord.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonTextBoxSearchKeyWord.StateCommon.Border.Rounding = 25F;
            this.kryptonTextBoxSearchKeyWord.StateCommon.Border.Width = 1;
            this.kryptonTextBoxSearchKeyWord.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.kryptonTextBoxSearchKeyWord.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBoxSearchKeyWord.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.kryptonTextBoxSearchKeyWord.TabIndex = 11;
            this.kryptonTextBoxSearchKeyWord.Text = "ID/name                                                 🔍 ";
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.kryptonCheckButton1);
            this.kryptonPanel4.Controls.Add(this.kryptonCheckButton2);
            this.kryptonPanel4.Controls.Add(this.kryptonCheckButton3);
            this.kryptonPanel4.Location = new System.Drawing.Point(8, 52);
            this.kryptonPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(261, 30);
            this.kryptonPanel4.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.kryptonPanel4.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.kryptonPanel4.TabIndex = 6;
            // 
            // kryptonCheckButton1
            // 
            this.kryptonCheckButton1.CornerRoundingRadius = 25F;
            this.kryptonCheckButton1.Location = new System.Drawing.Point(0, 0);
            this.kryptonCheckButton1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonCheckButton1.Name = "kryptonCheckButton1";
            this.kryptonCheckButton1.Size = new System.Drawing.Size(100, 30);
            this.kryptonCheckButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonCheckButton1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonCheckButton1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonCheckButton1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonCheckButton1.StateCommon.Border.Rounding = 25F;
            this.kryptonCheckButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonCheckButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckButton1.TabIndex = 6;
            this.kryptonCheckButton1.Values.Text = "Category1";
            // 
            // kryptonCheckButton2
            // 
            this.kryptonCheckButton2.CornerRoundingRadius = -1F;
            this.kryptonCheckButton2.Location = new System.Drawing.Point(86, 0);
            this.kryptonCheckButton2.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonCheckButton2.Name = "kryptonCheckButton2";
            this.kryptonCheckButton2.Size = new System.Drawing.Size(100, 30);
            this.kryptonCheckButton2.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.kryptonCheckButton2.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.kryptonCheckButton2.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.kryptonCheckButton2.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.kryptonCheckButton2.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonCheckButton2.StateNormal.Border.Rounding = 25F;
            this.kryptonCheckButton2.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonCheckButton2.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckButton2.TabIndex = 6;
            this.kryptonCheckButton2.Values.Text = "Category2";
            // 
            // kryptonCheckButton3
            // 
            this.kryptonCheckButton3.CornerRoundingRadius = -1F;
            this.kryptonCheckButton3.Location = new System.Drawing.Point(165, 0);
            this.kryptonCheckButton3.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonCheckButton3.Name = "kryptonCheckButton3";
            this.kryptonCheckButton3.Size = new System.Drawing.Size(100, 30);
            this.kryptonCheckButton3.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.kryptonCheckButton3.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.kryptonCheckButton3.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.kryptonCheckButton3.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.kryptonCheckButton3.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonCheckButton3.StateNormal.Border.Rounding = 25F;
            this.kryptonCheckButton3.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonCheckButton3.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.kryptonCheckButton3.TabIndex = 13;
            this.kryptonCheckButton3.Values.Text = "Category3";
            // 
            // kryptonCheckButton7
            // 
            this.kryptonCheckButton7.CornerRoundingRadius = -1F;
            this.kryptonCheckButton7.Location = new System.Drawing.Point(425, 8);
            this.kryptonCheckButton7.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonCheckButton7.Name = "kryptonCheckButton7";
            this.kryptonCheckButton7.Size = new System.Drawing.Size(83, 30);
            this.kryptonCheckButton7.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.kryptonCheckButton7.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.kryptonCheckButton7.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.kryptonCheckButton7.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.kryptonCheckButton7.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonCheckButton7.StateNormal.Border.Rounding = 25F;
            this.kryptonCheckButton7.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonCheckButton7.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckButton7.TabIndex = 7;
            this.kryptonCheckButton7.Values.Text = "Status3";
            // 
            // kryptonCheckButton4
            // 
            this.kryptonCheckButton4.CornerRoundingRadius = -1F;
            this.kryptonCheckButton4.Location = new System.Drawing.Point(255, 52);
            this.kryptonCheckButton4.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonCheckButton4.Name = "kryptonCheckButton4";
            this.kryptonCheckButton4.Size = new System.Drawing.Size(100, 30);
            this.kryptonCheckButton4.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.kryptonCheckButton4.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.kryptonCheckButton4.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.kryptonCheckButton4.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.kryptonCheckButton4.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonCheckButton4.StateNormal.Border.Rounding = 25F;
            this.kryptonCheckButton4.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonCheckButton4.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.kryptonCheckButton4.TabIndex = 7;
            this.kryptonCheckButton4.Values.Text = "Category4";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::ITP4915_group3_project.Properties.Resources.螢幕擷取畫面_2023_03_15_235818;
            this.pictureBox6.Location = new System.Drawing.Point(491, 413);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(290, 40);
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(53, 199);
            this.kryptonLabel6.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(113, 26);
            this.kryptonLabel6.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.kryptonLabel6.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonLabel6.StateNormal.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonLabel6.StateNormal.ShortText.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 2;
            this.kryptonLabel6.Values.Text = "RESULT (0)";
            // 
            // purchasers_request_id
            // 
            this.purchasers_request_id.DataPropertyName = "purchasers_request_id";
            this.purchasers_request_id.HeaderText = "purchasers_request_id";
            this.purchasers_request_id.Name = "purchasers_request_id";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "item_ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "item_ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "qty";
            this.dataGridViewTextBoxColumn5.HeaderText = "qty";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "create_date";
            this.dataGridViewTextBoxColumn8.HeaderText = "create_date";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // purchasers_requestBindingSource
            // 
            this.purchasers_requestBindingSource.DataMember = "purchasers_request";
            this.purchasers_requestBindingSource.DataSource = this.restaurant_dbDataSet;
            // 
            // restaurant_dbDataSet
            // 
            this.restaurant_dbDataSet.DataSetName = "restaurant_dbDataSet";
            this.restaurant_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchasers_requestTableAdapter
            // 
            this.purchasers_requestTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.purchasers_requestTableAdapter = this.purchasers_requestTableAdapter;
            this.tableAdapterManager.restaurant_stock_itemTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ITP4915_group3_project.restaurant_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonGroupContent);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "check";
            this.Size = new System.Drawing.Size(800, 500);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupContent.Panel)).EndInit();
            this.kryptonGroupContent.Panel.ResumeLayout(false);
            this.kryptonGroupContent.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupContent)).EndInit();
            this.kryptonGroupContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.purchasers_requestDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            this.kryptonGroup1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).EndInit();
            this.kryptonPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasers_requestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurant_dbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonGroup kryptonGroupContent;
        private Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel6;
        private Krypton.Toolkit.KryptonCheckButton kryptonCheckButton5;
        private Krypton.Toolkit.KryptonCheckButton kryptonCheckButton6;
        private Krypton.Toolkit.KryptonButton kryptonButtonSearch;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBoxSearchKeyWord;
        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private Krypton.Toolkit.KryptonCheckButton kryptonCheckButton1;
        private Krypton.Toolkit.KryptonCheckButton kryptonCheckButton2;
        private Krypton.Toolkit.KryptonCheckButton kryptonCheckButton3;
        private Krypton.Toolkit.KryptonCheckButton kryptonCheckButton7;
        private Krypton.Toolkit.KryptonCheckButton kryptonCheckButton4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private restaurant_dbDataSet restaurant_dbDataSet;
        private System.Windows.Forms.BindingSource purchasers_requestBindingSource;
        private restaurant_dbDataSetTableAdapters.purchasers_requestTableAdapter purchasers_requestTableAdapter;
        private restaurant_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView purchasers_requestDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasers_request_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewButtonColumn detail;
    }
}