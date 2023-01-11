
namespace AdminKB.Formularios.Produtos
{
    partial class FormRetornaNovoProdutoEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRetornaNovoProdutoEstoque));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAdicionar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.panelCorpo = new System.Windows.Forms.Panel();
            this.checkAgruparLote = new DevExpress.XtraEditors.CheckEdit();
            this.dateExpiracao = new DevExpress.XtraEditors.DateEdit();
            this.dateFabricacao = new DevExpress.XtraEditors.DateEdit();
            this.txtQuantidadeMin = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantidadeMax = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEstoque = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumeroSerie = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.panelCorpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkAgruparLote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateExpiracao.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateExpiracao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFabricacao.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFabricacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidadeMin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidadeMax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstoque.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroSerie.Properties)).BeginInit();
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
            this.btnAdicionar});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 2;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.ShowQatLocationSelector = false;
            this.ribbon.Size = new System.Drawing.Size(520, 68);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Caption = "Adicionar";
            this.btnAdicionar.Id = 1;
            this.btnAdicionar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdicionar.ImageOptions.SvgImage")));
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdicionar_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAdicionar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 312);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(520, 24);
            // 
            // panelCorpo
            // 
            this.panelCorpo.Controls.Add(this.checkAgruparLote);
            this.panelCorpo.Controls.Add(this.dateExpiracao);
            this.panelCorpo.Controls.Add(this.dateFabricacao);
            this.panelCorpo.Controls.Add(this.txtQuantidadeMin);
            this.panelCorpo.Controls.Add(this.label4);
            this.panelCorpo.Controls.Add(this.txtQuantidadeMax);
            this.panelCorpo.Controls.Add(this.label2);
            this.panelCorpo.Controls.Add(this.label1);
            this.panelCorpo.Controls.Add(this.label10);
            this.panelCorpo.Controls.Add(this.label7);
            this.panelCorpo.Controls.Add(this.txtEstoque);
            this.panelCorpo.Controls.Add(this.label3);
            this.panelCorpo.Controls.Add(this.txtNumeroSerie);
            this.panelCorpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCorpo.Location = new System.Drawing.Point(0, 68);
            this.panelCorpo.Name = "panelCorpo";
            this.panelCorpo.Size = new System.Drawing.Size(520, 244);
            this.panelCorpo.TabIndex = 2;
            // 
            // checkAgruparLote
            // 
            this.checkAgruparLote.Location = new System.Drawing.Point(14, 135);
            this.checkAgruparLote.MenuManager = this.ribbon;
            this.checkAgruparLote.Name = "checkAgruparLote";
            this.checkAgruparLote.Properties.Appearance.Options.UseTextOptions = true;
            this.checkAgruparLote.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.checkAgruparLote.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.checkAgruparLote.Properties.Caption = "Com Validade";
            this.checkAgruparLote.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.SvgToggle1;
            this.checkAgruparLote.Size = new System.Drawing.Size(253, 22);
            this.checkAgruparLote.TabIndex = 192;
            this.checkAgruparLote.CheckedChanged += new System.EventHandler(this.checkAgruparLote_CheckedChanged);
            // 
            // dateExpiracao
            // 
            this.dateExpiracao.EditValue = null;
            this.dateExpiracao.Location = new System.Drawing.Point(125, 193);
            this.dateExpiracao.Name = "dateExpiracao";
            this.dateExpiracao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateExpiracao.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateExpiracao.Size = new System.Drawing.Size(382, 24);
            this.dateExpiracao.TabIndex = 191;
            // 
            // dateFabricacao
            // 
            this.dateFabricacao.EditValue = null;
            this.dateFabricacao.Location = new System.Drawing.Point(125, 163);
            this.dateFabricacao.MenuManager = this.ribbon;
            this.dateFabricacao.Name = "dateFabricacao";
            this.dateFabricacao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFabricacao.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFabricacao.Size = new System.Drawing.Size(382, 24);
            this.dateFabricacao.TabIndex = 191;
            // 
            // txtQuantidadeMin
            // 
            this.txtQuantidadeMin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantidadeMin.EditValue = "0";
            this.txtQuantidadeMin.Location = new System.Drawing.Point(125, 106);
            this.txtQuantidadeMin.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantidadeMin.Name = "txtQuantidadeMin";
            this.txtQuantidadeMin.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadeMin.Properties.Appearance.Options.UseFont = true;
            this.txtQuantidadeMin.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtQuantidadeMin.Properties.Mask.EditMask = "n0";
            this.txtQuantidadeMin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtQuantidadeMin.Properties.MaxLength = 18;
            this.txtQuantidadeMin.Size = new System.Drawing.Size(382, 22);
            this.txtQuantidadeMin.TabIndex = 189;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 190;
            this.label4.Text = "Data Expiração";
            // 
            // txtQuantidadeMax
            // 
            this.txtQuantidadeMax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantidadeMax.EditValue = "0";
            this.txtQuantidadeMax.Location = new System.Drawing.Point(125, 76);
            this.txtQuantidadeMax.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantidadeMax.Name = "txtQuantidadeMax";
            this.txtQuantidadeMax.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadeMax.Properties.Appearance.Options.UseFont = true;
            this.txtQuantidadeMax.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtQuantidadeMax.Properties.Mask.EditMask = "n0";
            this.txtQuantidadeMax.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtQuantidadeMax.Properties.MaxLength = 18;
            this.txtQuantidadeMax.Size = new System.Drawing.Size(382, 22);
            this.txtQuantidadeMax.TabIndex = 189;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 190;
            this.label2.Text = "Data Frabricação";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 190;
            this.label1.Text = "Quantidade Min";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 79);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 16);
            this.label10.TabIndex = 190;
            this.label10.Text = "Quantidade Max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 49);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 184;
            this.label7.Text = "Estoque";
            // 
            // txtEstoque
            // 
            this.txtEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEstoque.Location = new System.Drawing.Point(125, 46);
            this.txtEstoque.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtEstoque.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstoque.Properties.Appearance.Options.UseBackColor = true;
            this.txtEstoque.Properties.Appearance.Options.UseFont = true;
            this.txtEstoque.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtEstoque.Properties.ContextImageOptions.SvgImage = global::AdminKB.Properties.Resources.Mais;
            this.txtEstoque.Properties.ContextImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.txtEstoque.Properties.ReadOnly = true;
            this.txtEstoque.Size = new System.Drawing.Size(382, 22);
            this.txtEstoque.TabIndex = 183;
            this.txtEstoque.Click += new System.EventHandler(this.txtEstoque_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 177;
            this.label3.Text = "Numero De Serie";
            this.label3.Visible = false;
            // 
            // txtNumeroSerie
            // 
            this.txtNumeroSerie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumeroSerie.Location = new System.Drawing.Point(125, 16);
            this.txtNumeroSerie.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroSerie.Name = "txtNumeroSerie";
            this.txtNumeroSerie.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroSerie.Properties.Appearance.Options.UseFont = true;
            this.txtNumeroSerie.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtNumeroSerie.Properties.MaxLength = 60;
            this.txtNumeroSerie.Size = new System.Drawing.Size(382, 22);
            this.txtNumeroSerie.TabIndex = 178;
            this.txtNumeroSerie.Visible = false;
            // 
            // FormRetornaNovoProdutoEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 336);
            this.Controls.Add(this.panelCorpo);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.ShowIcon = false;
            this.Name = "FormRetornaNovoProdutoEstoque";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "ADICIONAR PRODUTO EM ESTOQUE";
            this.Load += new System.EventHandler(this.FormRetornaNovoProdutoEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.panelCorpo.ResumeLayout(false);
            this.panelCorpo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkAgruparLote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateExpiracao.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateExpiracao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFabricacao.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFabricacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidadeMin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidadeMax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstoque.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroSerie.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private System.Windows.Forms.Panel panelCorpo;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtNumeroSerie;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txtEstoque;
        private DevExpress.XtraEditors.TextEdit txtQuantidadeMax;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.TextEdit txtQuantidadeMin;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit dateExpiracao;
        private DevExpress.XtraEditors.DateEdit dateFabricacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.CheckEdit checkAgruparLote;
        private DevExpress.XtraBars.BarButtonItem btnAdicionar;
    }
}