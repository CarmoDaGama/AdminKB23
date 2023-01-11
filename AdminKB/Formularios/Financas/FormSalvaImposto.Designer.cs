
namespace AdminKB.Formularios.Financas
{
    partial class FormSalvaImposto
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSalvar = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            this.btnVoltar = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnSalvarUsuario = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.btnClearFieds = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnQuantidadeMin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtImpostoId = new DevExpress.XtraEditors.TextEdit();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtAcesso = new DevExpress.XtraEditors.TextEdit();
            this.txtNomeImposto = new DevExpress.XtraEditors.TextEdit();
            this.txtSigla = new DevExpress.XtraEditors.TextEdit();
            this.lblSenhaSeguinte = new System.Windows.Forms.Label();
            this.txtPercentagem = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panelCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtImpostoId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAcesso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeImposto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSigla.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPercentagem.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Blue;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnSalvar,
            this.barButtonItem2,
            this.barButtonItem13,
            this.btnVoltar,
            this.barButtonItem1,
            this.btnSalvarUsuario,
            this.barButtonItem8,
            this.btnClearFieds});
            this.ribbon.Location = new System.Drawing.Point(0, 25);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4);
            this.ribbon.MaxItemId = 32;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 440;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.ShowOnMultiplePages;
            this.ribbon.Size = new System.Drawing.Size(524, 33);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Caption = "Salvar";
            this.btnSalvar.Id = 1;
            this.btnSalvar.Name = "btnSalvar";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Salvar e Fechar";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem13
            // 
            this.barButtonItem13.Caption = "Imprimir";
            this.barButtonItem13.Id = 16;
            this.barButtonItem13.Name = "barButtonItem13";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Caption = "Voltar";
            this.btnVoltar.Id = 17;
            this.btnVoltar.Name = "btnVoltar";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Editar";
            this.barButtonItem1.Id = 18;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnSalvarUsuario
            // 
            this.btnSalvarUsuario.Caption = "Salvar";
            this.btnSalvarUsuario.Id = 19;
            this.btnSalvarUsuario.Name = "btnSalvarUsuario";
            this.btnSalvarUsuario.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSalvarImposto_ItemClick);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Id = 23;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // btnClearFieds
            // 
            this.btnClearFieds.Caption = "Limpar";
            this.btnClearFieds.Id = 29;
            this.btnClearFieds.Name = "btnClearFieds";
            this.btnClearFieds.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Opções";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSalvarUsuario);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tarefas";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
            this.ribbonPageGroup2.ItemLinks.Add(this.btnClearFieds);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Voltar";
            this.barButtonItem5.Id = 3;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Codigo";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Armazem";
            this.gridColumn3.FieldName = "NomeArmazem";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 385;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "DEscr";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 1;
            this.gridColumn9.Width = 459;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "DEscr";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 1;
            this.gridColumn10.Width = 459;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Descriacao";
            this.gridColumn11.FieldName = "ProdutoNome";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 1;
            this.gridColumn11.Width = 459;
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "codArmazem";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 5;
            // 
            // gridColumn21
            // 
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 2;
            // 
            // columnQuantidadeMin
            // 
            this.columnQuantidadeMin.Caption = "Qtd Min";
            this.columnQuantidadeMin.FieldName = "QtdMin";
            this.columnQuantidadeMin.MinWidth = 27;
            this.columnQuantidadeMin.Name = "columnQuantidadeMin";
            this.columnQuantidadeMin.OptionsColumn.AllowEdit = false;
            this.columnQuantidadeMin.OptionsColumn.AllowFocus = false;
            this.columnQuantidadeMin.Visible = true;
            this.columnQuantidadeMin.VisibleIndex = 3;
            this.columnQuantidadeMin.Width = 118;
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.Black;
            this.panelCabecalho.Controls.Add(this.label1);
            this.panelCabecalho.Controls.Add(this.btnClose);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(524, 25);
            this.panelCabecalho.TabIndex = 107;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 19);
            this.label1.TabIndex = 105;
            this.label1.Text = "SALVA USUÁRIO";
            // 
            // btnClose
            // 
            this.btnClose.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnClose.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.btnClose.Appearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnClose.Appearance.Options.UseBackColor = true;
            this.btnClose.Appearance.Options.UseBorderColor = true;
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Location = new System.Drawing.Point(496, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 8, 8, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 25);
            this.btnClose.TabIndex = 104;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 102);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 204;
            this.label6.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 205;
            this.label2.Text = "Número";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 132);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 215;
            this.label7.Text = "Tipo";
            // 
            // txtImpostoId
            // 
            this.txtImpostoId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImpostoId.Location = new System.Drawing.Point(100, 69);
            this.txtImpostoId.Margin = new System.Windows.Forms.Padding(4);
            this.txtImpostoId.Name = "txtImpostoId";
            this.txtImpostoId.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtImpostoId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpostoId.Properties.Appearance.Options.UseBackColor = true;
            this.txtImpostoId.Properties.Appearance.Options.UseFont = true;
            this.txtImpostoId.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtImpostoId.Properties.ReadOnly = true;
            this.txtImpostoId.Size = new System.Drawing.Size(411, 22);
            this.txtImpostoId.TabIndex = 221;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(13, 162);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(36, 16);
            this.lblSenha.TabIndex = 207;
            this.lblSenha.Text = "Sigla";
            // 
            // txtAcesso
            // 
            this.txtAcesso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAcesso.Enabled = false;
            this.txtAcesso.Location = new System.Drawing.Point(100, 129);
            this.txtAcesso.Margin = new System.Windows.Forms.Padding(4);
            this.txtAcesso.Name = "txtAcesso";
            this.txtAcesso.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtAcesso.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcesso.Properties.Appearance.Options.UseBackColor = true;
            this.txtAcesso.Properties.Appearance.Options.UseFont = true;
            this.txtAcesso.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtAcesso.Properties.ContextImageOptions.SvgImage = global::AdminKB.Properties.Resources.Mais;
            this.txtAcesso.Properties.ContextImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.txtAcesso.Properties.ReadOnly = true;
            this.txtAcesso.Size = new System.Drawing.Size(411, 22);
            this.txtAcesso.TabIndex = 212;
            this.txtAcesso.Click += new System.EventHandler(this.txtAcesso_Click);
            // 
            // txtNomeImposto
            // 
            this.txtNomeImposto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeImposto.Enabled = false;
            this.txtNomeImposto.Location = new System.Drawing.Point(100, 99);
            this.txtNomeImposto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeImposto.Name = "txtNomeImposto";
            this.txtNomeImposto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeImposto.Properties.Appearance.Options.UseFont = true;
            this.txtNomeImposto.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtNomeImposto.Properties.MaxLength = 26;
            this.txtNomeImposto.Size = new System.Drawing.Size(411, 22);
            this.txtNomeImposto.TabIndex = 208;
            this.txtNomeImposto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenhaSeguinte_KeyPress);
            // 
            // txtSigla
            // 
            this.txtSigla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSigla.Enabled = false;
            this.txtSigla.Location = new System.Drawing.Point(100, 159);
            this.txtSigla.Margin = new System.Windows.Forms.Padding(4);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSigla.Properties.Appearance.Options.UseFont = true;
            this.txtSigla.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtSigla.Properties.MaxLength = 60;
            this.txtSigla.Properties.UseSystemPasswordChar = true;
            this.txtSigla.Size = new System.Drawing.Size(411, 22);
            this.txtSigla.TabIndex = 211;
            this.txtSigla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenhaSeguinte_KeyPress);
            // 
            // lblSenhaSeguinte
            // 
            this.lblSenhaSeguinte.AutoSize = true;
            this.lblSenhaSeguinte.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaSeguinte.Location = new System.Drawing.Point(13, 192);
            this.lblSenhaSeguinte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenhaSeguinte.Name = "lblSenhaSeguinte";
            this.lblSenhaSeguinte.Size = new System.Drawing.Size(83, 16);
            this.lblSenhaSeguinte.TabIndex = 207;
            this.lblSenhaSeguinte.Text = "Percentagem";
            // 
            // txtPercentagem
            // 
            this.txtPercentagem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPercentagem.EditValue = "0,00";
            this.txtPercentagem.Location = new System.Drawing.Point(100, 190);
            this.txtPercentagem.Margin = new System.Windows.Forms.Padding(4);
            this.txtPercentagem.Name = "txtPercentagem";
            this.txtPercentagem.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercentagem.Properties.Appearance.Options.UseFont = true;
            this.txtPercentagem.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtPercentagem.Properties.Mask.EditMask = "n2";
            this.txtPercentagem.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPercentagem.Properties.MaxLength = 18;
            this.txtPercentagem.Size = new System.Drawing.Size(411, 22);
            this.txtPercentagem.TabIndex = 223;
            // 
            // FormSalvaImposto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 225);
            this.ControlBox = false;
            this.Controls.Add(this.txtPercentagem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtImpostoId);
            this.Controls.Add(this.lblSenhaSeguinte);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtAcesso);
            this.Controls.Add(this.txtNomeImposto);
            this.Controls.Add(this.txtSigla);
            this.Controls.Add(this.ribbon);
            this.Controls.Add(this.panelCabecalho);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.ShowIcon = false;
            this.InactiveGlowColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSalvaImposto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SALVA USUÁRIO";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtImpostoId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAcesso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeImposto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSigla.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPercentagem.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        public DevExpress.XtraBars.BarButtonItem btnSalvar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
        private DevExpress.XtraBars.BarButtonItem btnVoltar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        public DevExpress.XtraBars.BarButtonItem btnSalvarUsuario;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraBars.BarButtonItem btnClearFieds;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraGrid.Columns.GridColumn columnQuantidadeMin;
        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txtImpostoId;
        private System.Windows.Forms.Label lblSenha;
        private DevExpress.XtraEditors.TextEdit txtAcesso;
        private DevExpress.XtraEditors.TextEdit txtNomeImposto;
        private DevExpress.XtraEditors.TextEdit txtSigla;
        private System.Windows.Forms.Label lblSenhaSeguinte;
        private DevExpress.XtraEditors.TextEdit txtPercentagem;
    }
}