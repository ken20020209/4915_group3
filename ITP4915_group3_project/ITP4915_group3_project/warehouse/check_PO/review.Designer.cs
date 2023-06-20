
namespace ITP4915_group3_project.warehouse.check_PO
{
    partial class review
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
            this.kryptonPanelContent = new Krypton.Toolkit.KryptonPanel();
            this.purchase_order_allDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchase_order_allBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouse_dbDataSet = new ITP4915_group3_project.warehouse_dbDataSet();
            this.kryptonGroup1 = new Krypton.Toolkit.KryptonGroup();
            this.kryptonPanel6 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonCheckButton5 = new Krypton.Toolkit.KryptonCheckButton();
            this.kryptonCheckButton6 = new Krypton.Toolkit.KryptonCheckButton();
            this.kryptonButtonSearch = new Krypton.Toolkit.KryptonButton();
            this.kryptonTextBoxSearchKeyWord = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonPanel5 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonCheckButton1 = new Krypton.Toolkit.KryptonCheckButton();
            this.kryptonCheckButton2 = new Krypton.Toolkit.KryptonCheckButton();
            this.kryptonCheckButton3 = new Krypton.Toolkit.KryptonCheckButton();
            this.kryptonCheckButton7 = new Krypton.Toolkit.KryptonCheckButton();
            this.kryptonCheckButton4 = new Krypton.Toolkit.KryptonCheckButton();
            this.kryptonLabelResult = new Krypton.Toolkit.KryptonLabel();
            this.purchase_order_allTableAdapter = new ITP4915_group3_project.warehouse_dbDataSetTableAdapters.purchase_order_allTableAdapter();
            this.tableAdapterManager = new ITP4915_group3_project.warehouse_dbDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelContent)).BeginInit();
            this.kryptonPanelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_order_allDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_order_allBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse_dbDataSet)).BeginInit();
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
            // kryptonPanelContent
            // 
            this.kryptonPanelContent.Controls.Add(this.purchase_order_allDataGridView);
            this.kryptonPanelContent.Controls.Add(this.kryptonGroup1);
            this.kryptonPanelContent.Controls.Add(this.kryptonLabelResult);
            this.kryptonPanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanelContent.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanelContent.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanelContent.Name = "kryptonPanelContent";
            this.kryptonPanelContent.Size = new System.Drawing.Size(800, 516);
            this.kryptonPanelContent.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPanelContent.TabIndex = 10;
            
            // 
            // purchase_order_allDataGridView
            // 
            this.purchase_order_allDataGridView.AutoGenerateColumns = false;
            this.purchase_order_allDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchase_order_allDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.purchase_order_allDataGridView.DataSource = this.purchase_order_allBindingSource;
            this.purchase_order_allDataGridView.Location = new System.Drawing.Point(35, 232);
            this.purchase_order_allDataGridView.Name = "purchase_order_allDataGridView";
            this.purchase_order_allDataGridView.RowTemplate.Height = 24;
            this.purchase_order_allDataGridView.Size = new System.Drawing.Size(722, 158);
            this.purchase_order_allDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Purchase_order_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Purchase_order_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BR_relase_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "BR_relase_ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SR_relase_ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "SR_relase_ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SPO_relase_ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "SPO_relase_ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "purchasers_request_ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "purchasers_request_ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "delivery_note_ID";
            this.dataGridViewTextBoxColumn6.HeaderText = "delivery_note_ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn7.HeaderText = "description";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // purchase_order_allBindingSource
            // 
            this.purchase_order_allBindingSource.DataMember = "purchase_order_all";
            this.purchase_order_allBindingSource.DataSource = this.warehouse_dbDataSet;
            // 
            // warehouse_dbDataSet
            // 
            this.warehouse_dbDataSet.DataSetName = "warehouse_dbDataSet";
            this.warehouse_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.Location = new System.Drawing.Point(35, 23);
            this.kryptonGroup1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonGroup1.Name = "kryptonGroup1";
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonPanel6);
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonButtonSearch);
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonTextBoxSearchKeyWord);
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
            this.kryptonGroup1.TabIndex = 9;
            // 
            // kryptonPanel6
            // 
            this.kryptonPanel6.Controls.Add(this.kryptonCheckButton5);
            this.kryptonPanel6.Controls.Add(this.kryptonCheckButton6);
            this.kryptonPanel6.Location = new System.Drawing.Point(277, 8);
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
            this.kryptonTextBoxSearchKeyWord.Size = new System.Drawing.Size(210, 34);
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
            this.kryptonTextBoxSearchKeyWord.Text = "ID                                                🔍 ";
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
            this.kryptonCheckButton1.Values.Text = "BBA";
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
            this.kryptonCheckButton2.Values.Text = "PPO";
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
            this.kryptonCheckButton3.Values.Text = "SPO";
            // 
            // kryptonCheckButton7
            // 
            this.kryptonCheckButton7.CornerRoundingRadius = -1F;
            this.kryptonCheckButton7.Location = new System.Drawing.Point(411, 8);
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
            this.kryptonCheckButton4.Values.Text = "CPA";
            // 
            // kryptonLabelResult
            // 
            this.kryptonLabelResult.Location = new System.Drawing.Point(17, 161);
            this.kryptonLabelResult.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabelResult.Name = "kryptonLabelResult";
            this.kryptonLabelResult.Size = new System.Drawing.Size(113, 26);
            this.kryptonLabelResult.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.kryptonLabelResult.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonLabelResult.StateNormal.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonLabelResult.StateNormal.ShortText.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelResult.TabIndex = 8;
            this.kryptonLabelResult.Values.Text = "RESULT (0)";
            // 
            // purchase_order_allTableAdapter
            // 
            this.purchase_order_allTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.delivery_requestTableAdapter = null;
            this.tableAdapterManager.item_categoryTableAdapter = null;
            this.tableAdapterManager.itemTableAdapter = null;
            this.tableAdapterManager.purchase_order_allTableAdapter = this.purchase_order_allTableAdapter;
            this.tableAdapterManager.UpdateOrder = ITP4915_group3_project.warehouse_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            this.tableAdapterManager.warehouse_itemTableAdapter = null;
            this.tableAdapterManager.warehousedispatchinstructionTableAdapter = null;
            this.tableAdapterManager.warehouseTableAdapter = null;
            // 
            // review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanelContent);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "review";
            this.Size = new System.Drawing.Size(800, 516);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelContent)).EndInit();
            this.kryptonPanelContent.ResumeLayout(false);
            this.kryptonPanelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_order_allDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_order_allBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse_dbDataSet)).EndInit();
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

        private Krypton.Toolkit.KryptonPanel kryptonPanelContent;
        private Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel6;
        private Krypton.Toolkit.KryptonCheckButton kryptonCheckButton5;
        private Krypton.Toolkit.KryptonCheckButton kryptonCheckButton6;
        private Krypton.Toolkit.KryptonButton kryptonButtonSearch;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBoxSearchKeyWord;
        private Krypton.Toolkit.KryptonPanel kryptonPanel5;
        private Krypton.Toolkit.KryptonCheckButton kryptonCheckButton1;
        private Krypton.Toolkit.KryptonCheckButton kryptonCheckButton2;
        private Krypton.Toolkit.KryptonCheckButton kryptonCheckButton3;
        private Krypton.Toolkit.KryptonCheckButton kryptonCheckButton7;
        private Krypton.Toolkit.KryptonCheckButton kryptonCheckButton4;
        private Krypton.Toolkit.KryptonLabel kryptonLabelResult;
        private warehouse_dbDataSet warehouse_dbDataSet;
        private System.Windows.Forms.BindingSource purchase_order_allBindingSource;
        private warehouse_dbDataSetTableAdapters.purchase_order_allTableAdapter purchase_order_allTableAdapter;
        private warehouse_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView purchase_order_allDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}