
namespace ITP4915_group3_project.category.produce.search
{
    partial class check
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
            this.kryptonPanel4 = new Krypton.Toolkit.KryptonPanel();
            this.itemKryptonDataGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.category_dbDataSet = new ITP4915_group3_project.category_dbDataSet();
            this.kryptonGroup1 = new Krypton.Toolkit.KryptonGroup();
            this.kryptonPanel6 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonCheckButton5 = new Krypton.Toolkit.KryptonCheckButton();
            this.kryptonCheckButton6 = new Krypton.Toolkit.KryptonCheckButton();
            this.kryptonButton10 = new Krypton.Toolkit.KryptonButton();
            this.kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonPanel5 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonCheckButton1 = new Krypton.Toolkit.KryptonCheckButton();
            this.kryptonCheckButton2 = new Krypton.Toolkit.KryptonCheckButton();
            this.kryptonCheckButton3 = new Krypton.Toolkit.KryptonCheckButton();
            this.kryptonCheckButton7 = new Krypton.Toolkit.KryptonCheckButton();
            this.kryptonCheckButton4 = new Krypton.Toolkit.KryptonCheckButton();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.itemTableAdapter = new ITP4915_group3_project.category_dbDataSetTableAdapters.itemTableAdapter();
            this.tableAdapterManager = new ITP4915_group3_project.category_dbDataSetTableAdapters.TableAdapterManager();
            this.Column1 = new Krypton.Toolkit.KryptonDataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemKryptonDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.category_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).BeginInit();
            this.kryptonPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).BeginInit();
            this.kryptonPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.itemKryptonDataGridView);
            this.kryptonPanel4.Controls.Add(this.kryptonGroup1);
            this.kryptonPanel4.Controls.Add(this.kryptonLabel6);
            this.kryptonPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel4.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(800, 537);
            this.kryptonPanel4.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPanel4.TabIndex = 52;
            // 
            // itemKryptonDataGridView
            // 
            this.itemKryptonDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.itemKryptonDataGridView.DataSource = this.itemBindingSource;
            this.itemKryptonDataGridView.Location = new System.Drawing.Point(99, 241);
            this.itemKryptonDataGridView.Name = "itemKryptonDataGridView";
            this.itemKryptonDataGridView.RowTemplate.Height = 24;
            this.itemKryptonDataGridView.Size = new System.Drawing.Size(642, 220);
            this.itemKryptonDataGridView.TabIndex = 59;
            this.itemKryptonDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemKryptonDataGridView_CellContentClick);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "item";
            this.itemBindingSource.DataSource = this.category_dbDataSet;
            // 
            // category_dbDataSet
            // 
            this.category_dbDataSet.DataSetName = "category_dbDataSet";
            this.category_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.Location = new System.Drawing.Point(42, 19);
            this.kryptonGroup1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonGroup1.Name = "kryptonGroup1";
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonPanel6);
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonButton10);
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonTextBox1);
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonPanel5);
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
            this.kryptonGroup1.TabIndex = 59;
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
            // kryptonButton10
            // 
            this.kryptonButton10.CornerRoundingRadius = 25F;
            this.kryptonButton10.Location = new System.Drawing.Point(411, 52);
            this.kryptonButton10.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonButton10.Name = "kryptonButton10";
            this.kryptonButton10.Size = new System.Drawing.Size(97, 30);
            this.kryptonButton10.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(138)))), ((int)(((byte)(82)))));
            this.kryptonButton10.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(138)))), ((int)(((byte)(82)))));
            this.kryptonButton10.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(138)))), ((int)(((byte)(82)))));
            this.kryptonButton10.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(138)))), ((int)(((byte)(82)))));
            this.kryptonButton10.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton10.StateCommon.Border.Rounding = 25F;
            this.kryptonButton10.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton10.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton10.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.kryptonButton10.TabIndex = 12;
            this.kryptonButton10.Values.Text = "Search";
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(8, 8);
            this.kryptonTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(244, 34);
            this.kryptonTextBox1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.kryptonTextBox1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonTextBox1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonTextBox1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox1.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonTextBox1.StateCommon.Border.Rounding = 25F;
            this.kryptonTextBox1.StateCommon.Border.Width = 1;
            this.kryptonTextBox1.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.kryptonTextBox1.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox1.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.kryptonTextBox1.TabIndex = 11;
            this.kryptonTextBox1.Text = "ID/name                                                 🔍 ";
            // 
            // kryptonPanel5
            // 
            this.kryptonPanel5.Controls.Add(this.kryptonCheckButton1);
            this.kryptonPanel5.Controls.Add(this.kryptonCheckButton2);
            this.kryptonPanel5.Controls.Add(this.kryptonCheckButton3);
            this.kryptonPanel5.Location = new System.Drawing.Point(8, 52);
            this.kryptonPanel5.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel5.Name = "kryptonPanel5";
            this.kryptonPanel5.Size = new System.Drawing.Size(261, 30);
            this.kryptonPanel5.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.kryptonPanel5.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.kryptonPanel5.TabIndex = 6;
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
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(26, 147);
            this.kryptonLabel6.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(113, 26);
            this.kryptonLabel6.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.kryptonLabel6.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonLabel6.StateNormal.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonLabel6.StateNormal.ShortText.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 58;
            this.kryptonLabel6.Values.Text = "RESULT (0)";
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.item_categoryTableAdapter = null;
            this.tableAdapterManager.itemTableAdapter = this.itemTableAdapter;
            this.tableAdapterManager.partner_brand_restaurantTableAdapter = null;
            this.tableAdapterManager.partner_brandTableAdapter = null;
            this.tableAdapterManager.supplier_contact_personTableAdapter = null;
            this.tableAdapterManager.supplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ITP4915_group3_project.category_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "detail";
            this.Column1.Name = "Column1";
            this.Column1.Text = "detail";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "item_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "item_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "item_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "item_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn3.HeaderText = "price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "size";
            this.dataGridViewTextBoxColumn4.HeaderText = "size";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "category_ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "category_ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "partner_brand_ID";
            this.dataGridViewTextBoxColumn6.HeaderText = "partner_brand_ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel4);
            this.Name = "check";
            this.Size = new System.Drawing.Size(800, 537);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            this.kryptonPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemKryptonDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.category_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            this.kryptonGroup1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).EndInit();
            this.kryptonPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).EndInit();
            this.kryptonPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel6;
        private Krypton.Toolkit.KryptonCheckButton kryptonCheckButton5;
        private Krypton.Toolkit.KryptonCheckButton kryptonCheckButton6;
        private Krypton.Toolkit.KryptonButton kryptonButton10;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel5;
        private Krypton.Toolkit.KryptonCheckButton kryptonCheckButton1;
        private Krypton.Toolkit.KryptonCheckButton kryptonCheckButton2;
        private Krypton.Toolkit.KryptonCheckButton kryptonCheckButton3;
        private Krypton.Toolkit.KryptonCheckButton kryptonCheckButton7;
        private Krypton.Toolkit.KryptonCheckButton kryptonCheckButton4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private category_dbDataSet category_dbDataSet;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private category_dbDataSetTableAdapters.itemTableAdapter itemTableAdapter;
        private category_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Krypton.Toolkit.KryptonDataGridView itemKryptonDataGridView;
        private Krypton.Toolkit.KryptonDataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}