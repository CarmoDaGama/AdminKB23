
namespace AdminKB.Formularios.Documentos
{
    partial class FormMotivoAnularDocumento
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
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.cboMotivo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGravar = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMotivo.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Blue;
            this.ribbon.CommandLayout = DevExpress.XtraBars.Ribbon.CommandLayout.Simplified;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ribbon.MaxItemId = 2;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 440;
            this.ribbon.OptionsPageCategories.ShowCaptions = false;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.Size = new System.Drawing.Size(353, 36);
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
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
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // cboMotivo
            // 
            this.cboMotivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMotivo.EditValue = "Cliente insatisfeito";
            this.cboMotivo.Location = new System.Drawing.Point(13, 28);
            this.cboMotivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboMotivo.MenuManager = this.ribbon;
            this.cboMotivo.Name = "cboMotivo";
            this.cboMotivo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cboMotivo.Properties.Appearance.Options.UseFont = true;
            this.cboMotivo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboMotivo.Properties.Items.AddRange(new object[] {
            "Cliente insatisfeito",
            "Devolução antes da facturação",
            "Anormalia nos  Artigos/serviços",
            "Os produtos não corresponderam a espectativa do cliente",
            "Inserramento da loja emediato",
            "Emergencia de venda ",
            "inrregularidade no pocesso de venda"});
            this.cboMotivo.Properties.Padding = new System.Windows.Forms.Padding(4);
            this.cboMotivo.Size = new System.Drawing.Size(327, 30);
            this.cboMotivo.TabIndex = 4;
            this.cboMotivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMotivo_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnGravar);
            this.panel1.Controls.Add(this.cboMotivo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 104);
            this.panel1.TabIndex = 8;
            // 
            // btnGravar
            // 
            this.btnGravar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGravar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnGravar.ImageOptions.SvgImage = global::AdminKB.Properties.Resources.Salvar_Blue;
            this.btnGravar.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.btnGravar.Location = new System.Drawing.Point(122, 66);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(98, 34);
            this.btnGravar.TabIndex = 8;
            this.btnGravar.ToolTipTitle = "Imprimir";
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Motivo:";
            // 
            // FormMotivoAnularDocumento
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 140);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMotivoAnularDocumento";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Motivo Da Anulação";
            this.Load += new System.EventHandler(this.FormMotivoAnularDocumento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMotivo.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.ComboBoxEdit cboMotivo;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnGravar;
        private System.Windows.Forms.Label label1;
    }
}