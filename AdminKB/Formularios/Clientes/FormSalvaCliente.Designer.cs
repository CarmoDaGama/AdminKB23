
namespace AdminKB.Formularios.Clientes
{
    partial class FormSalvaCliente
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSalvarForma = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNome = new DevExpress.XtraEditors.TextEdit();
            this.txtNif = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTel = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEndereco = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDebitoLimite = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNif.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndereco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDebitoLimite.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Blue;
            this.ribbon.CommandLayout = DevExpress.XtraBars.Ribbon.CommandLayout.Simplified;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnSalvarForma});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 2;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RibbonCaptionAlignment = DevExpress.XtraBars.Ribbon.RibbonCaptionAlignment.Left;
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.Size = new System.Drawing.Size(442, 68);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            this.ribbon.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.False;
            // 
            // btnSalvarForma
            // 
            this.btnSalvarForma.Caption = "Salvar";
            this.btnSalvarForma.Id = 1;
            this.btnSalvarForma.ImageOptions.SvgImage = global::AdminKB.Properties.Resources.Salvar_Blue;
            this.btnSalvarForma.Name = "btnSalvarForma";
            this.btnSalvarForma.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSalvarCliente_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSalvarForma);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 283);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(442, 24);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 175;
            this.label6.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Location = new System.Drawing.Point(88, 86);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Properties.Appearance.Options.UseFont = true;
            this.txtNome.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtNome.Properties.MaxLength = 26;
            this.txtNome.Size = new System.Drawing.Size(341, 22);
            this.txtNome.TabIndex = 176;
            // 
            // txtNif
            // 
            this.txtNif.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNif.Location = new System.Drawing.Point(88, 116);
            this.txtNif.Margin = new System.Windows.Forms.Padding(4);
            this.txtNif.Name = "txtNif";
            this.txtNif.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNif.Properties.Appearance.Options.UseFont = true;
            this.txtNif.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtNif.Properties.MaxLength = 26;
            this.txtNif.Size = new System.Drawing.Size(341, 22);
            this.txtNif.TabIndex = 176;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 175;
            this.label1.Text = "NIF";
            // 
            // txtTel
            // 
            this.txtTel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTel.Location = new System.Drawing.Point(88, 146);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4);
            this.txtTel.Name = "txtTel";
            this.txtTel.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Properties.Appearance.Options.UseFont = true;
            this.txtTel.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtTel.Properties.MaxLength = 26;
            this.txtTel.Size = new System.Drawing.Size(341, 22);
            this.txtTel.TabIndex = 176;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 16);
            this.label2.TabIndex = 175;
            this.label2.Text = "Tel";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(88, 176);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtEmail.Properties.MaxLength = 26;
            this.txtEmail.Size = new System.Drawing.Size(341, 22);
            this.txtEmail.TabIndex = 176;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 175;
            this.label3.Text = "E-mail";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEndereco.Location = new System.Drawing.Point(88, 206);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(4);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Properties.Appearance.Options.UseFont = true;
            this.txtEndereco.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtEndereco.Properties.MaxLength = 26;
            this.txtEndereco.Size = new System.Drawing.Size(341, 22);
            this.txtEndereco.TabIndex = 176;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 175;
            this.label4.Text = "Endereço";
            // 
            // txtDebitoLimite
            // 
            this.txtDebitoLimite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDebitoLimite.EditValue = "0";
            this.txtDebitoLimite.Location = new System.Drawing.Point(88, 236);
            this.txtDebitoLimite.Margin = new System.Windows.Forms.Padding(4);
            this.txtDebitoLimite.Name = "txtDebitoLimite";
            this.txtDebitoLimite.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtDebitoLimite.Properties.Appearance.Options.UseFont = true;
            this.txtDebitoLimite.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDebitoLimite.Properties.EditFormat.FormatString = "N2";
            this.txtDebitoLimite.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDebitoLimite.Properties.Mask.EditMask = "n2";
            this.txtDebitoLimite.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDebitoLimite.Properties.MaxLength = 9;
            this.txtDebitoLimite.Size = new System.Drawing.Size(341, 22);
            this.txtDebitoLimite.TabIndex = 179;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 239);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 175;
            this.label5.Text = "Limite";
            // 
            // FormSalvaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 307);
            this.Controls.Add(this.txtDebitoLimite);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtNif);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSalvaCliente";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Salvar Cliente";
            this.Load += new System.EventHandler(this.FormSalvaFormaPagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNif.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndereco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDebitoLimite.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txtNome;
        private DevExpress.XtraBars.BarButtonItem btnSalvarForma;
        private DevExpress.XtraEditors.TextEdit txtNif;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtTel;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtEndereco;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtDebitoLimite;
        private System.Windows.Forms.Label label5;
    }
}