
namespace ITP4915_group3_project.humanResources.user.create
{
    partial class create
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label first_nameLabel;
            System.Windows.Forms.Label last_nameLabel;
            System.Windows.Forms.Label role_idLabel;
            System.Windows.Forms.Label user_nameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label e_mailLabel;
            System.Windows.Forms.Label role_nameLabel;
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonButtonSubmit = new Krypton.Toolkit.KryptonButton();
            this.role_nameComboBox = new System.Windows.Forms.ComboBox();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.humanResources_dbDataSet = new ITP4915_group3_project.humanResources_dbDataSet();
            this.first_nameKryptonTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.last_nameKryptonTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.role_idKryptonTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.user_nameKryptonTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.passwordKryptonTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.genderKryptonComboBox = new Krypton.Toolkit.KryptonComboBox();
            this.phoneKryptonTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.e_mailKryptonTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_CPA_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_Item_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTableAdapter = new ITP4915_group3_project.humanResources_dbDataSetTableAdapters.userTableAdapter();
            this.tableAdapterManager = new ITP4915_group3_project.humanResources_dbDataSetTableAdapters.TableAdapterManager();
            this.roleTableAdapter = new ITP4915_group3_project.humanResources_dbDataSetTableAdapters.roleTableAdapter();
            first_nameLabel = new System.Windows.Forms.Label();
            last_nameLabel = new System.Windows.Forms.Label();
            role_idLabel = new System.Windows.Forms.Label();
            user_nameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            e_mailLabel = new System.Windows.Forms.Label();
            role_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.humanResources_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderKryptonComboBox)).BeginInit();
            this.SuspendLayout();
            // 
            // first_nameLabel
            // 
            first_nameLabel.AutoSize = true;
            first_nameLabel.Location = new System.Drawing.Point(69, 71);
            first_nameLabel.Name = "first_nameLabel";
            first_nameLabel.Size = new System.Drawing.Size(54, 12);
            first_nameLabel.TabIndex = 0;
            first_nameLabel.Text = "first name:";
            // 
            // last_nameLabel
            // 
            last_nameLabel.AutoSize = true;
            last_nameLabel.Location = new System.Drawing.Point(69, 99);
            last_nameLabel.Name = "last_nameLabel";
            last_nameLabel.Size = new System.Drawing.Size(51, 12);
            last_nameLabel.TabIndex = 2;
            last_nameLabel.Text = "last name:";
            // 
            // role_idLabel
            // 
            role_idLabel.AutoSize = true;
            role_idLabel.Location = new System.Drawing.Point(288, 100);
            role_idLabel.Name = "role_idLabel";
            role_idLabel.Size = new System.Drawing.Size(38, 12);
            role_idLabel.TabIndex = 4;
            role_idLabel.Text = "role id:";
            // 
            // user_nameLabel
            // 
            user_nameLabel.AutoSize = true;
            user_nameLabel.Location = new System.Drawing.Point(69, 127);
            user_nameLabel.Name = "user_nameLabel";
            user_nameLabel.Size = new System.Drawing.Size(55, 12);
            user_nameLabel.TabIndex = 6;
            user_nameLabel.Text = "user name:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(69, 155);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(51, 12);
            passwordLabel.TabIndex = 8;
            passwordLabel.Text = "password:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(288, 146);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(40, 12);
            genderLabel.TabIndex = 10;
            genderLabel.Text = "gender:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(69, 210);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(37, 12);
            phoneLabel.TabIndex = 12;
            phoneLabel.Text = "phone:";
            // 
            // e_mailLabel
            // 
            e_mailLabel.AutoSize = true;
            e_mailLabel.Location = new System.Drawing.Point(69, 238);
            e_mailLabel.Name = "e_mailLabel";
            e_mailLabel.Size = new System.Drawing.Size(37, 12);
            e_mailLabel.TabIndex = 14;
            e_mailLabel.Text = "e-mail:";
            // 
            // role_nameLabel
            // 
            role_nameLabel.AutoSize = true;
            role_nameLabel.Location = new System.Drawing.Point(289, 77);
            role_nameLabel.Name = "role_nameLabel";
            role_nameLabel.Size = new System.Drawing.Size(54, 12);
            role_nameLabel.TabIndex = 16;
            role_nameLabel.Text = "role name:";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonButtonSubmit);
            this.kryptonPanel1.Controls.Add(role_nameLabel);
            this.kryptonPanel1.Controls.Add(this.role_nameComboBox);
            this.kryptonPanel1.Controls.Add(first_nameLabel);
            this.kryptonPanel1.Controls.Add(this.first_nameKryptonTextBox);
            this.kryptonPanel1.Controls.Add(last_nameLabel);
            this.kryptonPanel1.Controls.Add(this.last_nameKryptonTextBox);
            this.kryptonPanel1.Controls.Add(role_idLabel);
            this.kryptonPanel1.Controls.Add(this.role_idKryptonTextBox);
            this.kryptonPanel1.Controls.Add(user_nameLabel);
            this.kryptonPanel1.Controls.Add(this.user_nameKryptonTextBox);
            this.kryptonPanel1.Controls.Add(passwordLabel);
            this.kryptonPanel1.Controls.Add(this.passwordKryptonTextBox);
            this.kryptonPanel1.Controls.Add(genderLabel);
            this.kryptonPanel1.Controls.Add(this.genderKryptonComboBox);
            this.kryptonPanel1.Controls.Add(phoneLabel);
            this.kryptonPanel1.Controls.Add(this.phoneKryptonTextBox);
            this.kryptonPanel1.Controls.Add(e_mailLabel);
            this.kryptonPanel1.Controls.Add(this.e_mailKryptonTextBox);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(866, 449);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonButtonSubmit
            // 
            this.kryptonButtonSubmit.CornerRoundingRadius = -1F;
            this.kryptonButtonSubmit.Location = new System.Drawing.Point(512, 328);
            this.kryptonButtonSubmit.Name = "kryptonButtonSubmit";
            this.kryptonButtonSubmit.Size = new System.Drawing.Size(118, 25);
            this.kryptonButtonSubmit.TabIndex = 25;
            this.kryptonButtonSubmit.Values.Text = "Submit";
            this.kryptonButtonSubmit.Click += new System.EventHandler(this.kryptonButtonSubmit_Click);
            // 
            // role_nameComboBox
            // 
            this.role_nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roleBindingSource, "role_name", true));
            this.role_nameComboBox.DataSource = this.roleBindingSource;
            this.role_nameComboBox.DisplayMember = "role_name";
            this.role_nameComboBox.FormattingEnabled = true;
            this.role_nameComboBox.Location = new System.Drawing.Point(349, 74);
            this.role_nameComboBox.Name = "role_nameComboBox";
            this.role_nameComboBox.Size = new System.Drawing.Size(121, 20);
            this.role_nameComboBox.TabIndex = 17;
            this.role_nameComboBox.ValueMember = "role_id";
            this.role_nameComboBox.SelectedIndexChanged += new System.EventHandler(this.role_nameComboBox_SelectedIndexChanged);
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataMember = "role";
            this.roleBindingSource.DataSource = this.humanResources_dbDataSet;
            // 
            // humanResources_dbDataSet
            // 
            this.humanResources_dbDataSet.DataSetName = "humanResources_dbDataSet";
            this.humanResources_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // first_nameKryptonTextBox
            // 
            this.first_nameKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "first_name", true));
            this.first_nameKryptonTextBox.Location = new System.Drawing.Point(130, 71);
            this.first_nameKryptonTextBox.Name = "first_nameKryptonTextBox";
            this.first_nameKryptonTextBox.Size = new System.Drawing.Size(121, 23);
            this.first_nameKryptonTextBox.TabIndex = 1;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.humanResources_dbDataSet;
            // 
            // last_nameKryptonTextBox
            // 
            this.last_nameKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "last_name", true));
            this.last_nameKryptonTextBox.Location = new System.Drawing.Point(130, 98);
            this.last_nameKryptonTextBox.Name = "last_nameKryptonTextBox";
            this.last_nameKryptonTextBox.Size = new System.Drawing.Size(121, 23);
            this.last_nameKryptonTextBox.TabIndex = 3;
            // 
            // role_idKryptonTextBox
            // 
            this.role_idKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "role_id", true));
            this.role_idKryptonTextBox.Location = new System.Drawing.Point(349, 100);
            this.role_idKryptonTextBox.Name = "role_idKryptonTextBox";
            this.role_idKryptonTextBox.ReadOnly = true;
            this.role_idKryptonTextBox.Size = new System.Drawing.Size(121, 23);
            this.role_idKryptonTextBox.TabIndex = 5;
            // 
            // user_nameKryptonTextBox
            // 
            this.user_nameKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "user_name", true));
            this.user_nameKryptonTextBox.Location = new System.Drawing.Point(130, 127);
            this.user_nameKryptonTextBox.Name = "user_nameKryptonTextBox";
            this.user_nameKryptonTextBox.Size = new System.Drawing.Size(121, 23);
            this.user_nameKryptonTextBox.TabIndex = 7;
            // 
            // passwordKryptonTextBox
            // 
            this.passwordKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "password", true));
            this.passwordKryptonTextBox.Location = new System.Drawing.Point(130, 155);
            this.passwordKryptonTextBox.Name = "passwordKryptonTextBox";
            this.passwordKryptonTextBox.Size = new System.Drawing.Size(121, 23);
            this.passwordKryptonTextBox.TabIndex = 9;
            // 
            // genderKryptonComboBox
            // 
            this.genderKryptonComboBox.CornerRoundingRadius = -1F;
            this.genderKryptonComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "gender", true));
            this.genderKryptonComboBox.DropDownWidth = 121;
            this.genderKryptonComboBox.IntegralHeight = false;
            this.genderKryptonComboBox.Items.AddRange(new object[] {
            "M",
            "F"});
            this.genderKryptonComboBox.Location = new System.Drawing.Point(349, 146);
            this.genderKryptonComboBox.Name = "genderKryptonComboBox";
            this.genderKryptonComboBox.Size = new System.Drawing.Size(121, 21);
            this.genderKryptonComboBox.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.genderKryptonComboBox.TabIndex = 11;
            // 
            // phoneKryptonTextBox
            // 
            this.phoneKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "phone", true));
            this.phoneKryptonTextBox.Location = new System.Drawing.Point(130, 210);
            this.phoneKryptonTextBox.Name = "phoneKryptonTextBox";
            this.phoneKryptonTextBox.Size = new System.Drawing.Size(121, 23);
            this.phoneKryptonTextBox.TabIndex = 13;
            // 
            // e_mailKryptonTextBox
            // 
            this.e_mailKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "e-mail", true));
            this.e_mailKryptonTextBox.Location = new System.Drawing.Point(130, 238);
            this.e_mailKryptonTextBox.Name = "e_mailKryptonTextBox";
            this.e_mailKryptonTextBox.Size = new System.Drawing.Size(121, 23);
            this.e_mailKryptonTextBox.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CPA_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CPA_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "create_date";
            this.dataGridViewTextBoxColumn8.HeaderText = "create_date";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "effective_date";
            this.dataGridViewTextBoxColumn9.HeaderText = "effective_date";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "supplier_ID";
            this.dataGridViewTextBoxColumn11.HeaderText = "supplier_ID";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "buyer_ID";
            this.dataGridViewTextBoxColumn12.HeaderText = "buyer_ID";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "terms";
            this.dataGridViewTextBoxColumn13.HeaderText = "terms";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "condition";
            this.dataGridViewTextBoxColumn14.HeaderText = "condition";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "item_ID";
            this.dataGridViewTextBoxColumn15.HeaderText = "item_ID";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Visible = false;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "item_name";
            this.dataGridViewTextBoxColumn16.HeaderText = "item_name";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "size";
            this.dataGridViewTextBoxColumn17.HeaderText = "size";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn_CPA_ID
            // 
            this.dataGridViewTextBoxColumn_CPA_ID.DataPropertyName = "CPA_ID";
            this.dataGridViewTextBoxColumn_CPA_ID.HeaderText = "CPA_ID";
            this.dataGridViewTextBoxColumn_CPA_ID.Name = "dataGridViewTextBoxColumn_CPA_ID";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "create_date";
            this.dataGridViewTextBoxColumn2.HeaderText = "create_date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "effective_date";
            this.dataGridViewTextBoxColumn3.HeaderText = "effective_date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "supplier_ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "supplier_ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "buyer_ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "buyer_ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "terms";
            this.dataGridViewTextBoxColumn6.HeaderText = "terms";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "condition";
            this.dataGridViewTextBoxColumn7.HeaderText = "condition";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn_Item_ID
            // 
            this.dataGridViewTextBoxColumn_Item_ID.DataPropertyName = "item_ID";
            this.dataGridViewTextBoxColumn_Item_ID.HeaderText = "item_ID";
            this.dataGridViewTextBoxColumn_Item_ID.Name = "dataGridViewTextBoxColumn_Item_ID";
            this.dataGridViewTextBoxColumn_Item_ID.Visible = false;
            // 
            // dataGridViewTextBoxColumn_item_name
            // 
            this.dataGridViewTextBoxColumn_item_name.DataPropertyName = "item_name";
            this.dataGridViewTextBoxColumn_item_name.HeaderText = "item_name";
            this.dataGridViewTextBoxColumn_item_name.Name = "dataGridViewTextBoxColumn_item_name";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "size";
            this.dataGridViewTextBoxColumn10.HeaderText = "size";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.roleTableAdapter = this.roleTableAdapter;
            this.tableAdapterManager.UpdateOrder = ITP4915_group3_project.humanResources_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = this.userTableAdapter;
            // 
            // roleTableAdapter
            // 
            this.roleTableAdapter.ClearBeforeFill = true;
            // 
            // create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "create";
            this.Size = new System.Drawing.Size(866, 449);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.humanResources_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderKryptonComboBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn_CPA_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn_Item_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn_item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private humanResources_dbDataSet humanResources_dbDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private humanResources_dbDataSetTableAdapters.userTableAdapter userTableAdapter;
        private humanResources_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox role_nameComboBox;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private Krypton.Toolkit.KryptonTextBox first_nameKryptonTextBox;
        private Krypton.Toolkit.KryptonTextBox last_nameKryptonTextBox;
        private Krypton.Toolkit.KryptonTextBox role_idKryptonTextBox;
        private Krypton.Toolkit.KryptonTextBox user_nameKryptonTextBox;
        private Krypton.Toolkit.KryptonTextBox passwordKryptonTextBox;
        private Krypton.Toolkit.KryptonComboBox genderKryptonComboBox;
        private Krypton.Toolkit.KryptonTextBox phoneKryptonTextBox;
        private Krypton.Toolkit.KryptonTextBox e_mailKryptonTextBox;
        private humanResources_dbDataSetTableAdapters.roleTableAdapter roleTableAdapter;
        private Krypton.Toolkit.KryptonButton kryptonButtonSubmit;
    }
}
