
namespace AdminKB.Formularios.Usuarios
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.pageLogin = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBoxViewPass = new System.Windows.Forms.CheckBox();
            this.btnDefinicoes = new DevExpress.XtraEditors.SimpleButton();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.labelInfo = new System.Windows.Forms.Label();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.label15 = new System.Windows.Forms.Label();
            this.btnSignin = new DevExpress.XtraEditors.SimpleButton();
            this.pageServidor = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPwd = new DevExpress.XtraEditors.TextEdit();
            this.txtUser = new DevExpress.XtraEditors.TextEdit();
            this.CboTipoBD = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPortaBd = new DevExpress.XtraEditors.TextEdit();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtServidor = new DevExpress.XtraEditors.TextEdit();
            this.btnTestarConexao = new DevExpress.XtraEditors.SimpleButton();
            this.btnActualizardb = new DevExpress.XtraEditors.SimpleButton();
            this.btnGoLogin = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            this.navigationFrame.SuspendLayout();
            this.pageLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            this.pageServidor.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CboTipoBD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPortaBd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServidor.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationFrame
            // 
            this.navigationFrame.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.navigationFrame.Appearance.Options.UseBackColor = true;
            this.navigationFrame.Controls.Add(this.pageLogin);
            this.navigationFrame.Controls.Add(this.pageServidor);
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Location = new System.Drawing.Point(0, 0);
            this.navigationFrame.Margin = new System.Windows.Forms.Padding(4);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.pageLogin,
            this.pageServidor});
            this.navigationFrame.SelectedPage = this.pageLogin;
            this.navigationFrame.Size = new System.Drawing.Size(560, 505);
            this.navigationFrame.TabIndex = 17;
            this.navigationFrame.Text = "navigationFrame2";
            this.navigationFrame.TransitionType = DevExpress.Utils.Animation.Transitions.Zoom;
            // 
            // pageLogin
            // 
            this.pageLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pageLogin.Caption = "pageLogin";
            this.pageLogin.Controls.Add(this.pictureBox1);
            this.pageLogin.Controls.Add(this.checkBoxViewPass);
            this.pageLogin.Controls.Add(this.btnDefinicoes);
            this.pageLogin.Controls.Add(this.txtUserName);
            this.pageLogin.Controls.Add(this.labelInfo);
            this.pageLogin.Controls.Add(this.btnClose);
            this.pageLogin.Controls.Add(this.txtPassword);
            this.pageLogin.Controls.Add(this.label15);
            this.pageLogin.Controls.Add(this.btnSignin);
            this.pageLogin.Margin = new System.Windows.Forms.Padding(4);
            this.pageLogin.Name = "pageLogin";
            this.pageLogin.Size = new System.Drawing.Size(560, 505);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::AdminKB.Properties.Resources.PUBLICIDADE___MARKETING;
            this.pictureBox1.Location = new System.Drawing.Point(193, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // checkBoxViewPass
            // 
            this.checkBoxViewPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxViewPass.AutoSize = true;
            this.checkBoxViewPass.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxViewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkBoxViewPass.Location = new System.Drawing.Point(99, 345);
            this.checkBoxViewPass.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxViewPass.Name = "checkBoxViewPass";
            this.checkBoxViewPass.Size = new System.Drawing.Size(94, 22);
            this.checkBoxViewPass.TabIndex = 38;
            this.checkBoxViewPass.Text = "Ver Senha";
            this.checkBoxViewPass.UseVisualStyleBackColor = false;
            this.checkBoxViewPass.CheckedChanged += new System.EventHandler(this.checkPalavraPasse_CheckedChanged);
            // 
            // btnDefinicoes
            // 
            this.btnDefinicoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDefinicoes.Appearance.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefinicoes.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.btnDefinicoes.Appearance.Options.UseFont = true;
            this.btnDefinicoes.Appearance.Options.UseForeColor = true;
            this.btnDefinicoes.ImageOptions.SvgImage = global::AdminKB.Properties.Resources.Configuracoes;
            this.btnDefinicoes.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnDefinicoes.Location = new System.Drawing.Point(476, 449);
            this.btnDefinicoes.Margin = new System.Windows.Forms.Padding(4);
            this.btnDefinicoes.Name = "btnDefinicoes";
            this.btnDefinicoes.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnDefinicoes.Size = new System.Drawing.Size(28, 43);
            this.btnDefinicoes.TabIndex = 37;
            this.btnDefinicoes.Click += new System.EventHandler(this.btnConfiguracaoBD_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUserName.EditValue = "";
            this.txtUserName.Location = new System.Drawing.Point(99, 240);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtUserName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Properties.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.txtUserName.Properties.Appearance.Options.UseBackColor = true;
            this.txtUserName.Properties.Appearance.Options.UseFont = true;
            this.txtUserName.Properties.Appearance.Options.UseForeColor = true;
            this.txtUserName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.txtUserName.Properties.ContextImageOptions.SvgImage = global::AdminKB.Properties.Resources.Usuario;
            this.txtUserName.Properties.ContextImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.txtUserName.Properties.Padding = new System.Windows.Forms.Padding(1);
            this.txtUserName.Size = new System.Drawing.Size(368, 26);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // labelInfo
            // 
            this.labelInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelInfo.AutoSize = true;
            this.labelInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(193)))), ((int)(((byte)(201)))));
            this.labelInfo.Location = new System.Drawing.Point(172, 211);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(0, 14);
            this.labelInfo.TabIndex = 36;
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Appearance.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.Appearance.Options.UseForeColor = true;
            this.btnClose.ImageOptions.SvgImage = global::AdminKB.Properties.Resources.Fechar;
            this.btnClose.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnClose.Location = new System.Drawing.Point(522, 449);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnClose.Size = new System.Drawing.Size(28, 43);
            this.btnClose.TabIndex = 34;
            this.btnClose.Click += new System.EventHandler(this.BtnFecharAplicacao_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.EditValue = "";
            this.txtPassword.Location = new System.Drawing.Point(99, 294);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Properties.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.txtPassword.Properties.Appearance.Options.UseBackColor = true;
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.Appearance.Options.UseForeColor = true;
            this.txtPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.txtPassword.Properties.ContextImageOptions.SvgImage = global::AdminKB.Properties.Resources.Locked;
            this.txtPassword.Properties.ContextImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.txtPassword.Properties.NullText = "eeee";
            this.txtPassword.Properties.UseSystemPasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(368, 24);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(193)))), ((int)(((byte)(201)))));
            this.label15.Location = new System.Drawing.Point(13, 479);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Copyright 2021 - AdminKB";
            // 
            // btnSignin
            // 
            this.btnSignin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSignin.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSignin.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignin.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSignin.Appearance.Options.UseBackColor = true;
            this.btnSignin.Appearance.Options.UseFont = true;
            this.btnSignin.Appearance.Options.UseForeColor = true;
            this.btnSignin.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.btnSignin.AppearanceDisabled.Options.UseForeColor = true;
            this.btnSignin.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.btnSignin.AppearanceHovered.Options.UseForeColor = true;
            this.btnSignin.AppearancePressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.btnSignin.AppearancePressed.Options.UseForeColor = true;
            this.btnSignin.Location = new System.Drawing.Point(343, 373);
            this.btnSignin.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(124, 36);
            this.btnSignin.TabIndex = 2;
            this.btnSignin.Text = "Logar";
            this.btnSignin.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // pageServidor
            // 
            this.pageServidor.Caption = "pageServidor";
            this.pageServidor.Controls.Add(this.panel2);
            this.pageServidor.Controls.Add(this.btnTestarConexao);
            this.pageServidor.Controls.Add(this.btnActualizardb);
            this.pageServidor.Controls.Add(this.btnGoLogin);
            this.pageServidor.Controls.Add(this.label6);
            this.pageServidor.Controls.Add(this.label7);
            this.pageServidor.Margin = new System.Windows.Forms.Padding(4);
            this.pageServidor.Name = "pageServidor";
            this.pageServidor.Size = new System.Drawing.Size(560, 505);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtPwd);
            this.panel2.Controls.Add(this.txtUser);
            this.panel2.Controls.Add(this.CboTipoBD);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtPortaBd);
            this.panel2.Controls.Add(this.comboBoxEdit1);
            this.panel2.Controls.Add(this.txtServidor);
            this.panel2.Location = new System.Drawing.Point(23, 94);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(522, 296);
            this.panel2.TabIndex = 44;
            // 
            // txtPwd
            // 
            this.txtPwd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPwd.EditValue = "";
            this.txtPwd.Location = new System.Drawing.Point(19, 169);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(4);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(193)))), ((int)(((byte)(201)))));
            this.txtPwd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPwd.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtPwd.Properties.Appearance.Options.UseBackColor = true;
            this.txtPwd.Properties.Appearance.Options.UseFont = true;
            this.txtPwd.Properties.Appearance.Options.UseForeColor = true;
            this.txtPwd.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.txtPwd.Properties.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(482, 24);
            this.txtPwd.TabIndex = 3;
            // 
            // txtUser
            // 
            this.txtUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUser.EditValue = "root";
            this.txtUser.Location = new System.Drawing.Point(19, 130);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(193)))), ((int)(((byte)(201)))));
            this.txtUser.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtUser.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtUser.Properties.Appearance.Options.UseBackColor = true;
            this.txtUser.Properties.Appearance.Options.UseFont = true;
            this.txtUser.Properties.Appearance.Options.UseForeColor = true;
            this.txtUser.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.txtUser.Size = new System.Drawing.Size(482, 24);
            this.txtUser.TabIndex = 2;
            // 
            // CboTipoBD
            // 
            this.CboTipoBD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CboTipoBD.EditValue = "MYSQL SERVER";
            this.CboTipoBD.Enabled = false;
            this.CboTipoBD.Location = new System.Drawing.Point(17, 48);
            this.CboTipoBD.Margin = new System.Windows.Forms.Padding(4);
            this.CboTipoBD.Name = "CboTipoBD";
            this.CboTipoBD.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(193)))), ((int)(((byte)(201)))));
            this.CboTipoBD.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.CboTipoBD.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CboTipoBD.Properties.Appearance.Options.UseBackColor = true;
            this.CboTipoBD.Properties.Appearance.Options.UseFont = true;
            this.CboTipoBD.Properties.Appearance.Options.UseForeColor = true;
            this.CboTipoBD.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.CboTipoBD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CboTipoBD.Properties.Items.AddRange(new object[] {
            "MYSQL SERVER",
            "SQL SERVER",
            "ORACLE SERVER"});
            this.CboTipoBD.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.CboTipoBD.Size = new System.Drawing.Size(482, 24);
            this.CboTipoBD.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(193)))), ((int)(((byte)(201)))));
            this.label5.Location = new System.Drawing.Point(17, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 35;
            this.label5.Text = "Servidor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(193)))), ((int)(((byte)(201)))));
            this.label8.Location = new System.Drawing.Point(17, 219);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 18);
            this.label8.TabIndex = 38;
            this.label8.Text = "Porta:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(193)))), ((int)(((byte)(201)))));
            this.label12.Location = new System.Drawing.Point(264, 219);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 18);
            this.label12.TabIndex = 42;
            this.label12.Text = "Idioma:";
            this.label12.Visible = false;
            // 
            // txtPortaBd
            // 
            this.txtPortaBd.EditValue = "3306";
            this.txtPortaBd.Location = new System.Drawing.Point(17, 249);
            this.txtPortaBd.Margin = new System.Windows.Forms.Padding(4);
            this.txtPortaBd.Name = "txtPortaBd";
            this.txtPortaBd.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(193)))), ((int)(((byte)(201)))));
            this.txtPortaBd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPortaBd.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtPortaBd.Properties.Appearance.Options.UseBackColor = true;
            this.txtPortaBd.Properties.Appearance.Options.UseFont = true;
            this.txtPortaBd.Properties.Appearance.Options.UseForeColor = true;
            this.txtPortaBd.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.txtPortaBd.Size = new System.Drawing.Size(243, 24);
            this.txtPortaBd.TabIndex = 4;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEdit1.Enabled = false;
            this.comboBoxEdit1.Location = new System.Drawing.Point(268, 249);
            this.comboBoxEdit1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(193)))), ((int)(((byte)(201)))));
            this.comboBoxEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.comboBoxEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.comboBoxEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.comboBoxEdit1.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.comboBoxEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(232, 24);
            this.comboBoxEdit1.TabIndex = 5;
            this.comboBoxEdit1.Visible = false;
            // 
            // txtServidor
            // 
            this.txtServidor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServidor.EditValue = "LOCALHOST";
            this.txtServidor.Location = new System.Drawing.Point(17, 90);
            this.txtServidor.Margin = new System.Windows.Forms.Padding(4);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(193)))), ((int)(((byte)(201)))));
            this.txtServidor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtServidor.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtServidor.Properties.Appearance.Options.UseBackColor = true;
            this.txtServidor.Properties.Appearance.Options.UseFont = true;
            this.txtServidor.Properties.Appearance.Options.UseForeColor = true;
            this.txtServidor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.txtServidor.Size = new System.Drawing.Size(482, 24);
            this.txtServidor.TabIndex = 1;
            // 
            // btnTestarConexao
            // 
            this.btnTestarConexao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTestarConexao.Appearance.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestarConexao.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.btnTestarConexao.Appearance.Options.UseFont = true;
            this.btnTestarConexao.Appearance.Options.UseForeColor = true;
            this.btnTestarConexao.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTestarConexao.ImageOptions.SvgImage")));
            this.btnTestarConexao.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnTestarConexao.Location = new System.Drawing.Point(436, 449);
            this.btnTestarConexao.Margin = new System.Windows.Forms.Padding(4);
            this.btnTestarConexao.Name = "btnTestarConexao";
            this.btnTestarConexao.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnTestarConexao.Size = new System.Drawing.Size(28, 43);
            this.btnTestarConexao.TabIndex = 0;
            this.btnTestarConexao.Click += new System.EventHandler(this.btnActualizarConexao_Click);
            // 
            // btnActualizardb
            // 
            this.btnActualizardb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizardb.Appearance.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizardb.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.btnActualizardb.Appearance.Options.UseFont = true;
            this.btnActualizardb.Appearance.Options.UseForeColor = true;
            this.btnActualizardb.ImageOptions.SvgImage = global::AdminKB.Properties.Resources.Actualizar;
            this.btnActualizardb.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnActualizardb.Location = new System.Drawing.Point(481, 449);
            this.btnActualizardb.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizardb.Name = "btnActualizardb";
            this.btnActualizardb.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnActualizardb.Size = new System.Drawing.Size(28, 43);
            this.btnActualizardb.TabIndex = 1;
            this.btnActualizardb.Click += new System.EventHandler(this.btnActualizarConexao_Click);
            // 
            // btnGoLogin
            // 
            this.btnGoLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGoLogin.Appearance.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoLogin.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.btnGoLogin.Appearance.Options.UseFont = true;
            this.btnGoLogin.Appearance.Options.UseForeColor = true;
            this.btnGoLogin.ImageOptions.SvgImage = global::AdminKB.Properties.Resources.Usuario;
            this.btnGoLogin.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnGoLogin.Location = new System.Drawing.Point(517, 449);
            this.btnGoLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnGoLogin.Name = "btnGoLogin";
            this.btnGoLogin.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnGoLogin.Size = new System.Drawing.Size(28, 43);
            this.btnGoLogin.TabIndex = 2;
            this.btnGoLogin.Click += new System.EventHandler(this.btnVoltarLoginGonfig_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(193)))), ((int)(((byte)(201)))));
            this.label6.Location = new System.Drawing.Point(18, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 29);
            this.label6.TabIndex = 34;
            this.label6.Text = "Servidor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(193)))), ((int)(((byte)(201)))));
            this.label7.Location = new System.Drawing.Point(22, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 16);
            this.label7.TabIndex = 33;
            this.label7.Text = "Configuração de acesso a dados.";
            // 
            // FormLogin
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 505);
            this.Controls.Add(this.navigationFrame);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            this.navigationFrame.ResumeLayout(false);
            this.pageLogin.ResumeLayout(false);
            this.pageLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            this.pageServidor.ResumeLayout(false);
            this.pageServidor.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CboTipoBD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPortaBd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServidor.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.XtraBars.Navigation.NavigationPage pageLogin;
        private DevExpress.XtraBars.Navigation.NavigationPage pageServidor;
        private DevExpress.XtraEditors.SimpleButton btnSignin;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txtPortaBd;
        private DevExpress.XtraEditors.TextEdit txtServidor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelInfo;
        private DevExpress.XtraEditors.ComboBoxEdit CboTipoBD;
        private System.Windows.Forms.CheckBox checkBoxViewPass;
        private DevExpress.XtraEditors.SimpleButton btnDefinicoes;
        private DevExpress.XtraEditors.SimpleButton btnGoLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.TextEdit txtPwd;
        private DevExpress.XtraEditors.TextEdit txtUser;
        private DevExpress.XtraEditors.SimpleButton btnActualizardb;
        private DevExpress.XtraEditors.SimpleButton btnTestarConexao;
    }
}