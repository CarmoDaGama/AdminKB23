
namespace AdminKB.Formularios.Usuarios
{
    partial class FormAbrirTurno
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
            this.btnAbrir = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.btnFecharTurno = new DevExpress.XtraBars.BarButtonItem();
            this.btnAbrirTurno = new DevExpress.XtraBars.BarButtonItem();
            this.btnImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSaldoInicial = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldoInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
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
            this.btnAbrir,
            this.btnClose,
            this.btnFecharTurno,
            this.btnAbrirTurno,
            this.btnImprimir});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 440;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(341, 68);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Caption = "Abrir";
            this.btnAbrir.Id = 1;
            this.btnAbrir.ImageOptions.SvgImage = global::AdminKB.Properties.Resources.Open_Turno;
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAbrir_ItemClick);
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Fechar";
            this.btnClose.Id = 2;
            this.btnClose.Name = "btnClose";
            this.btnClose.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // btnFecharTurno
            // 
            this.btnFecharTurno.Caption = "Fechar Turno";
            this.btnFecharTurno.Id = 3;
            this.btnFecharTurno.Name = "btnFecharTurno";
            // 
            // btnAbrirTurno
            // 
            this.btnAbrirTurno.Caption = "Abrir Turno";
            this.btnAbrirTurno.Id = 4;
            this.btnAbrirTurno.Name = "btnAbrirTurno";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Caption = "Imprimir";
            this.btnImprimir.Id = 5;
            this.btnImprimir.Name = "btnImprimir";
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
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAbrir);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnClose);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label1.Location = new System.Drawing.Point(16, 199);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Saldo Inicial:";
            // 
            // txtSaldoInicial
            // 
            this.txtSaldoInicial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSaldoInicial.EditValue = "0,00";
            this.txtSaldoInicial.Location = new System.Drawing.Point(16, 227);
            this.txtSaldoInicial.Margin = new System.Windows.Forms.Padding(4);
            this.txtSaldoInicial.Name = "txtSaldoInicial";
            this.txtSaldoInicial.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoInicial.Properties.Appearance.Options.UseFont = true;
            this.txtSaldoInicial.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSaldoInicial.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtSaldoInicial.Properties.Mask.BeepOnError = true;
            this.txtSaldoInicial.Properties.Mask.EditMask = "n2";
            this.txtSaldoInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSaldoInicial.Size = new System.Drawing.Size(315, 24);
            this.txtSaldoInicial.TabIndex = 160;
            this.txtSaldoInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaldoInicial_KeyPress);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::AdminKB.Properties.Resources.abrir_turno;
            this.pictureEdit1.Location = new System.Drawing.Point(110, 75);
            this.pictureEdit1.MenuManager = this.ribbonControl1;
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(100, 96);
            this.pictureEdit1.TabIndex = 164;
            // 
            // FormAbrirTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 277);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.txtSaldoInicial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAbrirTurno";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abrir Turno";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldoInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnAbrir;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.BarButtonItem btnFecharTurno;
        private DevExpress.XtraBars.BarButtonItem btnAbrirTurno;
        private DevExpress.XtraBars.BarButtonItem btnImprimir;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtSaldoInicial;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}