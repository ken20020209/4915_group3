
namespace ITP4915_group3_project.humanResources.user.search
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
            this.kryptonPanelContent = new Krypton.Toolkit.KryptonPanel();
            this.userKryptonDataGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.humanResources_dbDataSet = new ITP4915_group3_project.humanResources_dbDataSet();
            this.kryptonTextBoxSearchBar = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabelResult = new Krypton.Toolkit.KryptonLabel();
            this.userTableAdapter = new ITP4915_group3_project.humanResources_dbDataSetTableAdapters.userTableAdapter();
            this.tableAdapterManager = new ITP4915_group3_project.humanResources_dbDataSetTableAdapters.TableAdapterManager();
            this.detail = new Krypton.Toolkit.KryptonDataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelContent)).BeginInit();
            this.kryptonPanelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userKryptonDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.humanResources_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanelContent
            // 
            this.kryptonPanelContent.AutoScroll = true;
            this.kryptonPanelContent.AutoSize = true;
            this.kryptonPanelContent.Controls.Add(this.userKryptonDataGridView);
            this.kryptonPanelContent.Controls.Add(this.kryptonTextBoxSearchBar);
            this.kryptonPanelContent.Controls.Add(this.kryptonLabelResult);
            this.kryptonPanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanelContent.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanelContent.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanelContent.Name = "kryptonPanelContent";
            this.kryptonPanelContent.Size = new System.Drawing.Size(800, 538);
            this.kryptonPanelContent.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPanelContent.TabIndex = 9;
            // 
            // userKryptonDataGridView
            // 
            this.userKryptonDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detail,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.userKryptonDataGridView.DataSource = this.userBindingSource;
            this.userKryptonDataGridView.Location = new System.Drawing.Point(36, 201);
            this.userKryptonDataGridView.Name = "userKryptonDataGridView";
            this.userKryptonDataGridView.RowTemplate.Height = 24;
            this.userKryptonDataGridView.Size = new System.Drawing.Size(720, 227);
            this.userKryptonDataGridView.TabIndex = 9;
            this.userKryptonDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userKryptonDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "user_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "user_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "first_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "first_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "last_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "last_name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "role_id";
            this.dataGridViewTextBoxColumn4.HeaderText = "role_id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "user_name";
            this.dataGridViewTextBoxColumn5.HeaderText = "user_name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn6.HeaderText = "password";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "gender";
            this.dataGridViewTextBoxColumn7.HeaderText = "gender";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "phone";
            this.dataGridViewTextBoxColumn8.HeaderText = "phone";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "e-mail";
            this.dataGridViewTextBoxColumn9.HeaderText = "e-mail";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // userBindingSource
            // 
            this.userBindingSource.AllowNew = false;
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.humanResources_dbDataSet;
            // 
            // humanResources_dbDataSet
            // 
            this.humanResources_dbDataSet.DataSetName = "humanResources_dbDataSet";
            this.humanResources_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kryptonTextBoxSearchBar
            // 
            this.kryptonTextBoxSearchBar.CueHint.CueHintText = "ID or name";
            this.kryptonTextBoxSearchBar.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.kryptonTextBoxSearchBar.Location = new System.Drawing.Point(465, 139);
            this.kryptonTextBoxSearchBar.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonTextBoxSearchBar.Name = "kryptonTextBoxSearchBar";
            this.kryptonTextBoxSearchBar.Size = new System.Drawing.Size(210, 34);
            this.kryptonTextBoxSearchBar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.kryptonTextBoxSearchBar.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonTextBoxSearchBar.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonTextBoxSearchBar.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBoxSearchBar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonTextBoxSearchBar.StateCommon.Border.Rounding = 25F;
            this.kryptonTextBoxSearchBar.StateCommon.Border.Width = 1;
            this.kryptonTextBoxSearchBar.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.kryptonTextBoxSearchBar.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBoxSearchBar.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.kryptonTextBoxSearchBar.TabIndex = 11;
            this.kryptonTextBoxSearchBar.TextChanged += new System.EventHandler(this.kryptonTextBoxSearchBar_TextChanged);
            // 
            // kryptonLabelResult
            // 
            this.kryptonLabelResult.Location = new System.Drawing.Point(100, 139);
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
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.roleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ITP4915_group3_project.humanResources_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = this.userTableAdapter;
            // 
            // detail
            // 
            this.detail.HeaderText = "detail";
            this.detail.Name = "detail";
            this.detail.Text = "detail";
            this.detail.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "user_id";
            this.dataGridViewTextBoxColumn10.HeaderText = "user_id";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "first_name";
            this.dataGridViewTextBoxColumn11.HeaderText = "first_name";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "last_name";
            this.dataGridViewTextBoxColumn12.HeaderText = "last_name";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "role_id";
            this.dataGridViewTextBoxColumn13.HeaderText = "role_id";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "user_name";
            this.dataGridViewTextBoxColumn14.HeaderText = "user_name";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn15.HeaderText = "password";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Visible = false;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "gender";
            this.dataGridViewTextBoxColumn16.HeaderText = "gender";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Visible = false;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "phone";
            this.dataGridViewTextBoxColumn17.HeaderText = "phone";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "e-mail";
            this.dataGridViewTextBoxColumn18.HeaderText = "e-mail";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Visible = false;
            // 
            // check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.Controls.Add(this.kryptonPanelContent);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "check";
            this.Size = new System.Drawing.Size(800, 538);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelContent)).EndInit();
            this.kryptonPanelContent.ResumeLayout(false);
            this.kryptonPanelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userKryptonDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.humanResources_dbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanelContent;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBoxSearchBar;
        private Krypton.Toolkit.KryptonLabel kryptonLabelResult;
        private humanResources_dbDataSet humanResources_dbDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private humanResources_dbDataSetTableAdapters.userTableAdapter userTableAdapter;
        private humanResources_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Krypton.Toolkit.KryptonDataGridView userKryptonDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private Krypton.Toolkit.KryptonDataGridViewButtonColumn detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
    }
}