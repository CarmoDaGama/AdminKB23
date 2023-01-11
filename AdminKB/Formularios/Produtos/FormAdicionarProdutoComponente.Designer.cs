
namespace AdminKB.Formularios.Produtos
{
    partial class FormAdicionarProdutoComponente
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
            this.btnAdicionar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.panelCorpo = new System.Windows.Forms.Panel();
            this.txtQuantidade = new DevExpress.XtraEditors.TextEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomeProduto = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProdutoCompId = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.panelCorpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdutoCompId.Properties)).BeginInit();
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
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 201);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(520, 24);
            // 
            // panelCorpo
            // 
            this.panelCorpo.Controls.Add(this.txtQuantidade);
            this.panelCorpo.Controls.Add(this.label10);
            this.panelCorpo.Controls.Add(this.label7);
            this.panelCorpo.Controls.Add(this.txtNomeProduto);
            this.panelCorpo.Controls.Add(this.label3);
            this.panelCorpo.Controls.Add(this.txtProdutoCompId);
            this.panelCorpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCorpo.Location = new System.Drawing.Point(0, 68);
            this.panelCorpo.Name = "panelCorpo";
            this.panelCorpo.Size = new System.Drawing.Size(520, 133);
            this.panelCorpo.TabIndex = 2;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantidade.EditValue = "0";
            this.txtQuantidade.Location = new System.Drawing.Point(125, 76);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Properties.Appearance.Options.UseFont = true;
            this.txtQuantidade.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtQuantidade.Properties.Mask.EditMask = "n0";
            this.txtQuantidade.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtQuantidade.Properties.MaxLength = 18;
            this.txtQuantidade.Size = new System.Drawing.Size(382, 22);
            this.txtQuantidade.TabIndex = 189;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 79);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 16);
            this.label10.TabIndex = 190;
            this.label10.Text = "Quantidade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 49);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 184;
            this.label7.Text = "Produto";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeProduto.Location = new System.Drawing.Point(125, 46);
            this.txtNomeProduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtNomeProduto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProduto.Properties.Appearance.Options.UseBackColor = true;
            this.txtNomeProduto.Properties.Appearance.Options.UseFont = true;
            this.txtNomeProduto.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtNomeProduto.Properties.ContextImageOptions.SvgImage = global::AdminKB.Properties.Resources.Mais;
            this.txtNomeProduto.Properties.ContextImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.txtNomeProduto.Properties.ReadOnly = true;
            this.txtNomeProduto.Size = new System.Drawing.Size(382, 22);
            this.txtNomeProduto.TabIndex = 183;
            this.txtNomeProduto.Click += new System.EventHandler(this.txtNomeProduto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 177;
            this.label3.Text = "Número";
            // 
            // txtProdutoCompId
            // 
            this.txtProdutoCompId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProdutoCompId.Enabled = false;
            this.txtProdutoCompId.Location = new System.Drawing.Point(125, 16);
            this.txtProdutoCompId.Margin = new System.Windows.Forms.Padding(4);
            this.txtProdutoCompId.Name = "txtProdutoCompId";
            this.txtProdutoCompId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdutoCompId.Properties.Appearance.Options.UseFont = true;
            this.txtProdutoCompId.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtProdutoCompId.Properties.MaxLength = 60;
            this.txtProdutoCompId.Size = new System.Drawing.Size(382, 22);
            this.txtProdutoCompId.TabIndex = 178;
            // 
            // FormAdicionarProdutoComponente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 225);
            this.Controls.Add(this.panelCorpo);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.ShowIcon = false;
            this.Name = "FormAdicionarProdutoComponente";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "ADICIONAR PRODUTO COMPONENTE";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.panelCorpo.ResumeLayout(false);
            this.panelCorpo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdutoCompId.Properties)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit txtProdutoCompId;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txtNomeProduto;
        private DevExpress.XtraEditors.TextEdit txtQuantidade;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraBars.BarButtonItem btnAdicionar;
    }
}