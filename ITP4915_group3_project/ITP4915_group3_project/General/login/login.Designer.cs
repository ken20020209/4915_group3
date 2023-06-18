
namespace ITP4915_group3_project.General.login
{
    partial class Login
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonPanelIcon = new Krypton.Toolkit.KryptonPanel();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.kryptonLabelSystemName = new Krypton.Toolkit.KryptonLabel();
            this.kryptonButtonSignIn = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabelForgotPassword = new Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBoxPassword = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBoxUserName = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonBorderEdgeLogin = new Krypton.Toolkit.KryptonBorderEdge();
            this.kryptonLabelLogin = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelUserID = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelPassword = new Krypton.Toolkit.KryptonLabel();
            this.kryptonButtonWhitOutPassword = new Krypton.Toolkit.KryptonButton();
            this.userTableAdapter = new ITP4915_group3_project.restaurant_dbDataSetTableAdapters.userTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelIcon)).BeginInit();
            this.kryptonPanelIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 12F;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // kryptonPanelIcon
            // 
            this.kryptonPanelIcon.Controls.Add(this.pictureBoxIcon);
            this.kryptonPanelIcon.Controls.Add(this.kryptonLabelSystemName);
            this.kryptonPanelIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonPanelIcon.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanelIcon.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanelIcon.Name = "kryptonPanelIcon";
            this.kryptonPanelIcon.Size = new System.Drawing.Size(348, 365);
            this.kryptonPanelIcon.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonPanelIcon.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonPanelIcon.TabIndex = 5;
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.pictureBoxIcon.Image = global::ITP4915_group3_project.Properties.Resources.icons8_order_64;
            this.pictureBoxIcon.Location = new System.Drawing.Point(18, 138);
            this.pictureBoxIcon.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(99, 91);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 6;
            this.pictureBoxIcon.TabStop = false;
            // 
            // kryptonLabelSystemName
            // 
            this.kryptonLabelSystemName.Location = new System.Drawing.Point(136, 121);
            this.kryptonLabelSystemName.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabelSystemName.Name = "kryptonLabelSystemName";
            this.kryptonLabelSystemName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.kryptonLabelSystemName.Size = new System.Drawing.Size(186, 117);
            this.kryptonLabelSystemName.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabelSystemName.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonLabelSystemName.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelSystemName.TabIndex = 5;
            this.kryptonLabelSystemName.TabStop = false;
            this.kryptonLabelSystemName.Values.Text = "centralized\r\nProcurement\r\nSystem";
            // 
            // kryptonButtonSignIn
            // 
            this.kryptonButtonSignIn.AutoSize = true;
            this.kryptonButtonSignIn.CornerRoundingRadius = 20F;
            this.kryptonButtonSignIn.Location = new System.Drawing.Point(568, 270);
            this.kryptonButtonSignIn.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonButtonSignIn.Name = "kryptonButtonSignIn";
            this.kryptonButtonSignIn.Size = new System.Drawing.Size(89, 35);
            this.kryptonButtonSignIn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonButtonSignIn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonButtonSignIn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonButtonSignIn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonButtonSignIn.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButtonSignIn.StateCommon.Border.Rounding = 20F;
            this.kryptonButtonSignIn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButtonSignIn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButtonSignIn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButtonSignIn.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonButtonSignIn.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonButtonSignIn.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButtonSignIn.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButtonSignIn.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.kryptonButtonSignIn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonButtonSignIn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonButtonSignIn.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButtonSignIn.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonButtonSignIn.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonButtonSignIn.TabIndex = 13;
            this.kryptonButtonSignIn.Values.Text = "sign in";
            this.kryptonButtonSignIn.Click += new System.EventHandler(this.kryptonButtonSignIn_Click);
            // 
            // kryptonLabelForgotPassword
            // 
            this.kryptonLabelForgotPassword.Location = new System.Drawing.Point(402, 270);
            this.kryptonLabelForgotPassword.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabelForgotPassword.Name = "kryptonLabelForgotPassword";
            this.kryptonLabelForgotPassword.Size = new System.Drawing.Size(99, 19);
            this.kryptonLabelForgotPassword.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelForgotPassword.TabIndex = 12;
            this.kryptonLabelForgotPassword.Values.Text = "forget password";
            this.kryptonLabelForgotPassword.Click += new System.EventHandler(this.kryptonLabelForgotPassword_Click);
            // 
            // kryptonTextBoxPassword
            // 
            this.kryptonTextBoxPassword.Location = new System.Drawing.Point(402, 206);
            this.kryptonTextBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonTextBoxPassword.MaxLength = 30;
            this.kryptonTextBoxPassword.Name = "kryptonTextBoxPassword";
            this.kryptonTextBoxPassword.PasswordChar = '●';
            this.kryptonTextBoxPassword.Size = new System.Drawing.Size(255, 47);
            this.kryptonTextBoxPassword.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonTextBoxPassword.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonTextBoxPassword.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonTextBoxPassword.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBoxPassword.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonTextBoxPassword.StateCommon.Border.Rounding = 25F;
            this.kryptonTextBoxPassword.StateCommon.Border.Width = 1;
            this.kryptonTextBoxPassword.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.kryptonTextBoxPassword.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBoxPassword.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.kryptonTextBoxPassword.StateDisabled.Content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBoxPassword.TabIndex = 11;
            this.kryptonTextBoxPassword.Text = "password";
            this.kryptonTextBoxPassword.UseSystemPasswordChar = true;
            // 
            // kryptonTextBoxUserName
            // 
            this.kryptonTextBoxUserName.CueHint.CueHintText = "user name";
            this.kryptonTextBoxUserName.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.kryptonTextBoxUserName.Location = new System.Drawing.Point(402, 126);
            this.kryptonTextBoxUserName.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonTextBoxUserName.MaxLength = 30;
            this.kryptonTextBoxUserName.Name = "kryptonTextBoxUserName";
            this.kryptonTextBoxUserName.Size = new System.Drawing.Size(255, 47);
            this.kryptonTextBoxUserName.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonTextBoxUserName.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonTextBoxUserName.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonTextBoxUserName.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBoxUserName.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonTextBoxUserName.StateCommon.Border.Rounding = 25F;
            this.kryptonTextBoxUserName.StateCommon.Border.Width = 1;
            this.kryptonTextBoxUserName.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.kryptonTextBoxUserName.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBoxUserName.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.kryptonTextBoxUserName.TabIndex = 10;
            // 
            // kryptonBorderEdgeLogin
            // 
            this.kryptonBorderEdgeLogin.Location = new System.Drawing.Point(500, 82);
            this.kryptonBorderEdgeLogin.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonBorderEdgeLogin.Name = "kryptonBorderEdgeLogin";
            this.kryptonBorderEdgeLogin.Size = new System.Drawing.Size(58, 2);
            this.kryptonBorderEdgeLogin.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonBorderEdgeLogin.StateCommon.Width = 2;
            this.kryptonBorderEdgeLogin.Text = "kryptonBorderEdge1";
            // 
            // kryptonLabelLogin
            // 
            this.kryptonLabelLogin.Location = new System.Drawing.Point(501, 59);
            this.kryptonLabelLogin.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabelLogin.Name = "kryptonLabelLogin";
            this.kryptonLabelLogin.Size = new System.Drawing.Size(59, 26);
            this.kryptonLabelLogin.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonLabelLogin.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelLogin.TabIndex = 14;
            this.kryptonLabelLogin.Values.Text = "Login";
            // 
            // kryptonLabelUserID
            // 
            this.kryptonLabelUserID.Location = new System.Drawing.Point(402, 105);
            this.kryptonLabelUserID.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabelUserID.Name = "kryptonLabelUserID";
            this.kryptonLabelUserID.Size = new System.Drawing.Size(74, 19);
            this.kryptonLabelUserID.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonLabelUserID.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelUserID.TabIndex = 16;
            this.kryptonLabelUserID.Values.Text = "user Name:";
            // 
            // kryptonLabelPassword
            // 
            this.kryptonLabelPassword.Location = new System.Drawing.Point(402, 184);
            this.kryptonLabelPassword.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabelPassword.Name = "kryptonLabelPassword";
            this.kryptonLabelPassword.Size = new System.Drawing.Size(67, 19);
            this.kryptonLabelPassword.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.kryptonLabelPassword.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelPassword.TabIndex = 17;
            this.kryptonLabelPassword.Values.Text = "password:";
            // 
            // kryptonButtonWhitOutPassword
            // 
            this.kryptonButtonWhitOutPassword.AutoSize = true;
            this.kryptonButtonWhitOutPassword.CornerRoundingRadius = 20F;
            this.kryptonButtonWhitOutPassword.Location = new System.Drawing.Point(501, 319);
            this.kryptonButtonWhitOutPassword.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonButtonWhitOutPassword.Name = "kryptonButtonWhitOutPassword";
            this.kryptonButtonWhitOutPassword.Size = new System.Drawing.Size(177, 35);
            this.kryptonButtonWhitOutPassword.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonButtonWhitOutPassword.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonButtonWhitOutPassword.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonButtonWhitOutPassword.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonButtonWhitOutPassword.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButtonWhitOutPassword.StateCommon.Border.Rounding = 20F;
            this.kryptonButtonWhitOutPassword.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButtonWhitOutPassword.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButtonWhitOutPassword.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButtonWhitOutPassword.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonButtonWhitOutPassword.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonButtonWhitOutPassword.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButtonWhitOutPassword.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButtonWhitOutPassword.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.kryptonButtonWhitOutPassword.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonButtonWhitOutPassword.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonButtonWhitOutPassword.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButtonWhitOutPassword.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonButtonWhitOutPassword.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(151)))), ((int)(((byte)(115)))));
            this.kryptonButtonWhitOutPassword.TabIndex = 19;
            this.kryptonButtonWhitOutPassword.Values.Text = "sign in WhitOutPassword";
            this.kryptonButtonWhitOutPassword.Click += new System.EventHandler(this.kryptonButtonWhitOutPassword_Click);
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(697, 365);
            this.Controls.Add(this.kryptonButtonWhitOutPassword);
            this.Controls.Add(this.kryptonLabelPassword);
            this.Controls.Add(this.kryptonLabelUserID);
            this.Controls.Add(this.kryptonBorderEdgeLogin);
            this.Controls.Add(this.kryptonLabelLogin);
            this.Controls.Add(this.kryptonButtonSignIn);
            this.Controls.Add(this.kryptonLabelForgotPassword);
            this.Controls.Add(this.kryptonTextBoxPassword);
            this.Controls.Add(this.kryptonTextBoxUserName);
            this.Controls.Add(this.kryptonPanelIcon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelIcon)).EndInit();
            this.kryptonPanelIcon.ResumeLayout(false);
            this.kryptonPanelIcon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Krypton.Toolkit.KryptonPanel kryptonPanelIcon;
        private Krypton.Toolkit.KryptonLabel kryptonLabelSystemName;
        private Krypton.Toolkit.KryptonButton kryptonButtonSignIn;
        private Krypton.Toolkit.KryptonLabel kryptonLabelForgotPassword;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBoxPassword;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBoxUserName;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdgeLogin;
        private Krypton.Toolkit.KryptonLabel kryptonLabelLogin;
        private Krypton.Toolkit.KryptonLabel kryptonLabelUserID;
        private Krypton.Toolkit.KryptonLabel kryptonLabelPassword;
        private restaurant_dbDataSetTableAdapters.userTableAdapter userTableAdapter;
        private Krypton.Toolkit.KryptonButton kryptonButtonWhitOutPassword;
    }
}

