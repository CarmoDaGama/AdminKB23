
namespace AdminKB.Formularios.Usuarios
{
    partial class FormConfirmaTurno
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnConfirmarTurno = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.btnFecharTurno = new DevExpress.XtraBars.BarButtonItem();
            this.btnAbrirTurno = new DevExpress.XtraBars.BarButtonItem();
            this.btnImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.btnVoltar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeCaixa = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuebraDoCaixa = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSaldoNoCaixa = new DevExpress.XtraEditors.TextEdit();
            this.txtSupervisor = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeCaixa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuebraDoCaixa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldoNoCaixa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupervisor.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Blue;
            this.ribbonControl1.CommandLayout = DevExpress.XtraBars.Ribbon.CommandLayout.Simplified;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnConfirmarTurno,
            this.btnClose,
            this.btnFecharTurno,
            this.btnAbrirTurno,
            this.btnImprimir,
            this.btnVoltar});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 440;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(537, 68);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // btnConfirmarTurno
            // 
            this.btnConfirmarTurno.Caption = "Confirmar Turno";
            this.btnConfirmarTurno.Id = 1;
            this.btnConfirmarTurno.ImageOptions.SvgImage = global::AdminKB.Properties.Resources.Confirmar;
            this.btnConfirmarTurno.Name = "btnConfirmarTurno";
            this.btnConfirmarTurno.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnConfirmarTurno_ItemClick);
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Fechar";
            this.btnClose.Id = 2;
            this.btnClose.Name = "btnClose";
            // 
            // btnFecharTurno
            // 
            this.btnFecharTurno.Caption = "Fechar Turno";
            this.btnFecharTurno.Id = 3;
            this.btnFecharTurno.Name = "btnFecharTurno";
            // 
            // btnAbrirTurno
            // 
            this.btnAbrirTurno.Id = 7;
            this.btnAbrirTurno.Name = "btnAbrirTurno";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Caption = "Imprimir";
            this.btnImprimir.Id = 5;
            this.btnImprimir.Name = "btnImprimir";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Caption = "Voltar";
            this.btnVoltar.Id = 6;
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
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
            this.ribbonPageGroup1.ItemLinks.Add(this.btnConfirmarTurno);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnVoltar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label1.Location = new System.Drawing.Point(21, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome do Caixa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label2.Location = new System.Drawing.Point(23, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuário:";
            // 
            // txtNomeCaixa
            // 
            this.txtNomeCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeCaixa.EditValue = "";
            this.txtNomeCaixa.Location = new System.Drawing.Point(23, 95);
            this.txtNomeCaixa.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeCaixa.Name = "txtNomeCaixa";
            this.txtNomeCaixa.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCaixa.Properties.Appearance.Options.UseFont = true;
            this.txtNomeCaixa.Properties.ReadOnly = true;
            this.txtNomeCaixa.Size = new System.Drawing.Size(501, 22);
            this.txtNomeCaixa.TabIndex = 161;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label4.Location = new System.Drawing.Point(21, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 14);
            this.label4.TabIndex = 164;
            this.label4.Text = "Supervisor";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuario.EditValue = "";
            this.txtUsuario.Location = new System.Drawing.Point(23, 143);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Properties.Appearance.Options.UseFont = true;
            this.txtUsuario.Properties.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(501, 22);
            this.txtUsuario.TabIndex = 161;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label3.Location = new System.Drawing.Point(21, 271);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 14);
            this.label3.TabIndex = 164;
            this.label3.Text = "Quebra do Caixa:";
            // 
            // txtQuebraDoCaixa
            // 
            this.txtQuebraDoCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuebraDoCaixa.EditValue = "0,00";
            this.txtQuebraDoCaixa.Enabled = false;
            this.txtQuebraDoCaixa.Location = new System.Drawing.Point(24, 289);
            this.txtQuebraDoCaixa.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuebraDoCaixa.Name = "txtQuebraDoCaixa";
            this.txtQuebraDoCaixa.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuebraDoCaixa.Properties.Appearance.Options.UseFont = true;
            this.txtQuebraDoCaixa.Properties.Appearance.Options.UseTextOptions = true;
            this.txtQuebraDoCaixa.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtQuebraDoCaixa.Properties.Mask.EditMask = "n2";
            this.txtQuebraDoCaixa.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtQuebraDoCaixa.Properties.ReadOnly = true;
            this.txtQuebraDoCaixa.Size = new System.Drawing.Size(501, 22);
            this.txtQuebraDoCaixa.TabIndex = 165;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label5.Location = new System.Drawing.Point(20, 223);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 14);
            this.label5.TabIndex = 164;
            this.label5.Text = "Saldo do Caixa:";
            // 
            // txtSaldoNoCaixa
            // 
            this.txtSaldoNoCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSaldoNoCaixa.EditValue = "0,00";
            this.txtSaldoNoCaixa.Enabled = false;
            this.txtSaldoNoCaixa.Location = new System.Drawing.Point(23, 241);
            this.txtSaldoNoCaixa.Margin = new System.Windows.Forms.Padding(4);
            this.txtSaldoNoCaixa.Name = "txtSaldoNoCaixa";
            this.txtSaldoNoCaixa.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoNoCaixa.Properties.Appearance.Options.UseFont = true;
            this.txtSaldoNoCaixa.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSaldoNoCaixa.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtSaldoNoCaixa.Properties.Mask.EditMask = "n2";
            this.txtSaldoNoCaixa.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSaldoNoCaixa.Properties.ReadOnly = true;
            this.txtSaldoNoCaixa.Size = new System.Drawing.Size(501, 22);
            this.txtSaldoNoCaixa.TabIndex = 165;
            // 
            // txtSupervisor
            // 
            this.txtSupervisor.Location = new System.Drawing.Point(23, 191);
            this.txtSupervisor.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupervisor.Name = "txtSupervisor";
            this.txtSupervisor.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtSupervisor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupervisor.Properties.Appearance.Options.UseBackColor = true;
            this.txtSupervisor.Properties.Appearance.Options.UseFont = true;
            this.txtSupervisor.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtSupervisor.Properties.ContextImageOptions.SvgImage = global::AdminKB.Properties.Resources.Mais;
            this.txtSupervisor.Properties.ContextImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.txtSupervisor.Properties.ReadOnly = true;
            this.txtSupervisor.Size = new System.Drawing.Size(501, 22);
            this.txtSupervisor.TabIndex = 184;
            this.txtSupervisor.Click += new System.EventHandler(this.txtUsuario_Click);
            // 
            // FormConfirmaTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 332);
            this.Controls.Add(this.txtSupervisor);
            this.Controls.Add(this.txtSaldoNoCaixa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQuebraDoCaixa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtNomeCaixa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormConfirmaTurno";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONFIRMAR TURNO";
            this.Load += new System.EventHandler(this.FormConfirmaTurno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeCaixa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuebraDoCaixa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldoNoCaixa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupervisor.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnConfirmarTurno;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.BarButtonItem btnFecharTurno;
        private DevExpress.XtraBars.BarButtonItem btnAbrirTurno;
        private DevExpress.XtraBars.BarButtonItem btnImprimir;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraBars.BarButtonItem btnVoltar;
        private DevExpress.XtraEditors.TextEdit txtNomeCaixa;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtQuebraDoCaixa;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtSaldoNoCaixa;
        private DevExpress.XtraEditors.TextEdit txtSupervisor;
    }
}