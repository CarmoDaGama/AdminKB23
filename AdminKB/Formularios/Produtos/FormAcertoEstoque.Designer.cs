
namespace AdminKB.Formularios.Produtos
{
    partial class FormAcertoEstoque
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
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.GradeProdutos = new DevExpress.XtraGrid.GridControl();
            this.gridProdutos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itemPictureEliminar = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.columnDataFrabricacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnDataExpiracao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemButtonEliminar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.dateExpiracao = new DevExpress.XtraEditors.DateEdit();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.txtCodigoDeBarra = new DevExpress.XtraEditors.TextEdit();
            this.txtEstoqueActual = new DevExpress.XtraEditors.TextEdit();
            this.txtDescricao = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantidadeAdicionar = new DevExpress.XtraEditors.TextEdit();
            this.txtQuantidadeActual = new DevExpress.XtraEditors.TextEdit();
            this.txtQuantidadeMin = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.picImage = new DevExpress.XtraEditors.PictureEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnSelecionarProduto = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEstoque = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GradeProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPictureEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemButtonEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateExpiracao.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateExpiracao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoDeBarra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstoqueActual.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidadeAdicionar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidadeActual.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidadeMin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstoque.Properties)).BeginInit();
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
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.Size = new System.Drawing.Size(1045, 68);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            this.ribbon.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.False;
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
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 639);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1045, 24);
            // 
            // GradeProdutos
            // 
            this.GradeProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GradeProdutos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.GradeProdutos.Location = new System.Drawing.Point(405, 116);
            this.GradeProdutos.MainView = this.gridProdutos;
            this.GradeProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.GradeProdutos.Name = "GradeProdutos";
            this.GradeProdutos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ItemButtonEliminar,
            this.itemPictureEliminar});
            this.GradeProdutos.Size = new System.Drawing.Size(624, 507);
            this.GradeProdutos.TabIndex = 14;
            this.GradeProdutos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridProdutos});
            // 
            // gridProdutos
            // 
            this.gridProdutos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn12,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.columnDataFrabricacao,
            this.columnDataExpiracao});
            this.gridProdutos.DetailHeight = 485;
            this.gridProdutos.FixedLineWidth = 3;
            this.gridProdutos.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridProdutos.GridControl = this.GradeProdutos;
            this.gridProdutos.Name = "gridProdutos";
            this.gridProdutos.OptionsFind.FindNullPrompt = "Pesquisar...";
            this.gridProdutos.OptionsFind.ShowClearButton = false;
            this.gridProdutos.OptionsFind.ShowFindButton = false;
            this.gridProdutos.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Estoque";
            this.gridColumn3.FieldName = "Estoque.Nome";
            this.gridColumn3.MinWidth = 27;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 112;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Nome";
            this.gridColumn12.FieldName = "Produto.Nome";
            this.gridColumn12.MinWidth = 27;
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.AllowEdit = false;
            this.gridColumn12.OptionsColumn.AllowFocus = false;
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 0;
            this.gridColumn12.Width = 294;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn4.Caption = "Preço";
            this.gridColumn4.DisplayFormat.FormatString = "N2";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gridColumn4.FieldName = "Produto.Preco";
            this.gridColumn4.MinWidth = 27;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowFocus = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 59;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn5.Caption = "Quantidade";
            this.gridColumn5.DisplayFormat.FormatString = "N2";
            this.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gridColumn5.FieldName = "Quantidade";
            this.gridColumn5.MinWidth = 27;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.AllowFocus = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 82;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn7.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn7.Caption = "Stk Min";
            this.gridColumn7.FieldName = "EstoqueMin";
            this.gridColumn7.MinWidth = 27;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.OptionsColumn.AllowFocus = false;
            this.gridColumn7.Width = 96;
            // 
            // gridColumn8
            // 
            this.gridColumn8.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn8.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn8.Caption = "Stk Max";
            this.gridColumn8.FieldName = "EstoqueMax";
            this.gridColumn8.MinWidth = 27;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.OptionsColumn.AllowFocus = false;
            this.gridColumn8.Width = 107;
            // 
            // gridColumn9
            // 
            this.gridColumn9.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn9.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn9.Caption = "Controlar";
            this.gridColumn9.FieldName = "Controla";
            this.gridColumn9.MinWidth = 27;
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.OptionsColumn.AllowFocus = false;
            this.gridColumn9.Width = 96;
            // 
            // gridColumn10
            // 
            this.gridColumn10.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn10.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn10.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn10.Caption = "Vender";
            this.gridColumn10.FieldName = "Vender";
            this.gridColumn10.MinWidth = 27;
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.OptionsColumn.AllowFocus = false;
            this.gridColumn10.Width = 64;
            // 
            // gridColumn11
            // 
            this.gridColumn11.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn11.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn11.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn11.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn11.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn11.Caption = "Item";
            this.gridColumn11.ColumnEdit = this.itemPictureEliminar;
            this.gridColumn11.MinWidth = 27;
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            this.gridColumn11.OptionsColumn.ReadOnly = true;
            this.gridColumn11.Width = 87;
            // 
            // itemPictureEliminar
            // 
            this.itemPictureEliminar.Name = "itemPictureEliminar";
            this.itemPictureEliminar.ReadOnly = true;
            this.itemPictureEliminar.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // columnDataFrabricacao
            // 
            this.columnDataFrabricacao.AppearanceCell.Options.UseTextOptions = true;
            this.columnDataFrabricacao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.columnDataFrabricacao.AppearanceHeader.Options.UseTextOptions = true;
            this.columnDataFrabricacao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.columnDataFrabricacao.Caption = "Data de Fabricação";
            this.columnDataFrabricacao.FieldName = "DataDeFabricacao";
            this.columnDataFrabricacao.Name = "columnDataFrabricacao";
            this.columnDataFrabricacao.OptionsColumn.AllowEdit = false;
            this.columnDataFrabricacao.OptionsColumn.AllowFocus = false;
            this.columnDataFrabricacao.Width = 135;
            // 
            // columnDataExpiracao
            // 
            this.columnDataExpiracao.AppearanceCell.Options.UseTextOptions = true;
            this.columnDataExpiracao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.columnDataExpiracao.AppearanceHeader.Options.UseTextOptions = true;
            this.columnDataExpiracao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.columnDataExpiracao.Caption = "Data de Expiração";
            this.columnDataExpiracao.FieldName = "DataDeExpiracao";
            this.columnDataExpiracao.Name = "columnDataExpiracao";
            this.columnDataExpiracao.OptionsColumn.AllowEdit = false;
            this.columnDataExpiracao.OptionsColumn.AllowFocus = false;
            this.columnDataExpiracao.Width = 159;
            // 
            // ItemButtonEliminar
            // 
            this.ItemButtonEliminar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.ItemButtonEliminar.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.ItemButtonEliminar.ContextImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.ItemButtonEliminar.Name = "ItemButtonEliminar";
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.picImage);
            this.panelControl1.Location = new System.Drawing.Point(15, 74);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(383, 549);
            this.panelControl1.TabIndex = 24;
            // 
            // panelControl3
            // 
            this.panelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelControl3.Controls.Add(this.dateExpiracao);
            this.panelControl3.Controls.Add(this.btnAdicionarProduto);
            this.panelControl3.Controls.Add(this.txtCodigoDeBarra);
            this.panelControl3.Controls.Add(this.txtEstoqueActual);
            this.panelControl3.Controls.Add(this.txtDescricao);
            this.panelControl3.Controls.Add(this.label6);
            this.panelControl3.Controls.Add(this.label5);
            this.panelControl3.Controls.Add(this.label4);
            this.panelControl3.Controls.Add(this.label3);
            this.panelControl3.Controls.Add(this.label2);
            this.panelControl3.Controls.Add(this.txtQuantidadeAdicionar);
            this.panelControl3.Controls.Add(this.txtQuantidadeActual);
            this.panelControl3.Controls.Add(this.txtQuantidadeMin);
            this.panelControl3.Controls.Add(this.label1);
            this.panelControl3.Controls.Add(this.label7);
            this.panelControl3.Location = new System.Drawing.Point(5, 281);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(373, 255);
            this.panelControl3.TabIndex = 195;
            // 
            // dateExpiracao
            // 
            this.dateExpiracao.EditValue = null;
            this.dateExpiracao.Enabled = false;
            this.dateExpiracao.Location = new System.Drawing.Point(110, 99);
            this.dateExpiracao.Name = "dateExpiracao";
            this.dateExpiracao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateExpiracao.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateExpiracao.Size = new System.Drawing.Size(257, 24);
            this.dateExpiracao.TabIndex = 208;
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.btnAdicionarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarProduto.Font = new System.Drawing.Font("Tahoma", 12.75F);
            this.btnAdicionarProduto.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarProduto.Location = new System.Drawing.Point(125, 222);
            this.btnAdicionarProduto.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(110, 27);
            this.btnAdicionarProduto.TabIndex = 193;
            this.btnAdicionarProduto.Text = "Adicionar";
            this.btnAdicionarProduto.UseVisualStyleBackColor = false;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // txtCodigoDeBarra
            // 
            this.txtCodigoDeBarra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoDeBarra.Enabled = false;
            this.txtCodigoDeBarra.Location = new System.Drawing.Point(110, 8);
            this.txtCodigoDeBarra.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoDeBarra.Name = "txtCodigoDeBarra";
            this.txtCodigoDeBarra.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoDeBarra.Properties.Appearance.Options.UseFont = true;
            this.txtCodigoDeBarra.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtCodigoDeBarra.Properties.MaxLength = 60;
            this.txtCodigoDeBarra.Size = new System.Drawing.Size(257, 22);
            this.txtCodigoDeBarra.TabIndex = 205;
            // 
            // txtEstoqueActual
            // 
            this.txtEstoqueActual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEstoqueActual.Enabled = false;
            this.txtEstoqueActual.Location = new System.Drawing.Point(110, 68);
            this.txtEstoqueActual.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstoqueActual.Name = "txtEstoqueActual";
            this.txtEstoqueActual.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstoqueActual.Properties.Appearance.Options.UseFont = true;
            this.txtEstoqueActual.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtEstoqueActual.Properties.MaxLength = 60;
            this.txtEstoqueActual.Size = new System.Drawing.Size(257, 22);
            this.txtEstoqueActual.TabIndex = 206;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(110, 38);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Properties.Appearance.Options.UseFont = true;
            this.txtDescricao.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtDescricao.Properties.MaxLength = 60;
            this.txtDescricao.Size = new System.Drawing.Size(257, 22);
            this.txtDescricao.TabIndex = 207;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1, 193);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 195;
            this.label6.Text = "Qtd Adicionar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 196;
            this.label5.Text = "Qtd Actual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 197;
            this.label4.Text = "Qtd Maníma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 198;
            this.label3.Text = "Expiração";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 199;
            this.label2.Text = "Estoque Actual";
            // 
            // txtQuantidadeAdicionar
            // 
            this.txtQuantidadeAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantidadeAdicionar.EditValue = "0";
            this.txtQuantidadeAdicionar.Location = new System.Drawing.Point(110, 190);
            this.txtQuantidadeAdicionar.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantidadeAdicionar.Name = "txtQuantidadeAdicionar";
            this.txtQuantidadeAdicionar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadeAdicionar.Properties.Appearance.Options.UseFont = true;
            this.txtQuantidadeAdicionar.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtQuantidadeAdicionar.Properties.Mask.EditMask = "n0";
            this.txtQuantidadeAdicionar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtQuantidadeAdicionar.Properties.MaxLength = 18;
            this.txtQuantidadeAdicionar.Size = new System.Drawing.Size(257, 22);
            this.txtQuantidadeAdicionar.TabIndex = 202;
            // 
            // txtQuantidadeActual
            // 
            this.txtQuantidadeActual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantidadeActual.EditValue = "0";
            this.txtQuantidadeActual.Enabled = false;
            this.txtQuantidadeActual.Location = new System.Drawing.Point(110, 161);
            this.txtQuantidadeActual.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantidadeActual.Name = "txtQuantidadeActual";
            this.txtQuantidadeActual.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadeActual.Properties.Appearance.Options.UseFont = true;
            this.txtQuantidadeActual.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtQuantidadeActual.Properties.Mask.EditMask = "n0";
            this.txtQuantidadeActual.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtQuantidadeActual.Properties.MaxLength = 18;
            this.txtQuantidadeActual.Size = new System.Drawing.Size(257, 22);
            this.txtQuantidadeActual.TabIndex = 203;
            // 
            // txtQuantidadeMin
            // 
            this.txtQuantidadeMin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantidadeMin.EditValue = "0";
            this.txtQuantidadeMin.Enabled = false;
            this.txtQuantidadeMin.Location = new System.Drawing.Point(110, 131);
            this.txtQuantidadeMin.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantidadeMin.Name = "txtQuantidadeMin";
            this.txtQuantidadeMin.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadeMin.Properties.Appearance.Options.UseFont = true;
            this.txtQuantidadeMin.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtQuantidadeMin.Properties.Mask.EditMask = "n0";
            this.txtQuantidadeMin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtQuantidadeMin.Properties.MaxLength = 18;
            this.txtQuantidadeMin.Size = new System.Drawing.Size(257, 22);
            this.txtQuantidadeMin.TabIndex = 204;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 200;
            this.label1.Text = "Descrição";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 201;
            this.label7.Text = "Código De Barra";
            // 
            // picImage
            // 
            this.picImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picImage.EditValue = global::AdminKB.Properties.Resources.ProductFull;
            this.picImage.Location = new System.Drawing.Point(5, 6);
            this.picImage.Margin = new System.Windows.Forms.Padding(4);
            this.picImage.Name = "picImage";
            this.picImage.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picImage.Properties.ShowEditMenuItem = DevExpress.Utils.DefaultBoolean.False;
            this.picImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.picImage.Size = new System.Drawing.Size(373, 276);
            this.picImage.TabIndex = 191;
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.label8);
            this.panelControl2.Controls.Add(this.txtEstoque);
            this.panelControl2.Controls.Add(this.btnRemover);
            this.panelControl2.Controls.Add(this.btnSelecionarProduto);
            this.panelControl2.Location = new System.Drawing.Point(405, 74);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(624, 35);
            this.panelControl2.TabIndex = 193;
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Tahoma", 10.75F);
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Location = new System.Drawing.Point(124, 5);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(110, 26);
            this.btnRemover.TabIndex = 193;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnSelecionarProduto_Click);
            // 
            // btnSelecionarProduto
            // 
            this.btnSelecionarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.btnSelecionarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarProduto.Font = new System.Drawing.Font("Tahoma", 10.75F);
            this.btnSelecionarProduto.ForeColor = System.Drawing.Color.White;
            this.btnSelecionarProduto.Location = new System.Drawing.Point(6, 5);
            this.btnSelecionarProduto.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelecionarProduto.Name = "btnSelecionarProduto";
            this.btnSelecionarProduto.Size = new System.Drawing.Size(110, 26);
            this.btnSelecionarProduto.TabIndex = 193;
            this.btnSelecionarProduto.Text = "Selecionar";
            this.btnSelecionarProduto.UseVisualStyleBackColor = false;
            this.btnSelecionarProduto.Click += new System.EventHandler(this.btnSelecionarProduto_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(291, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 195;
            this.label8.Text = "Estoque:";
            // 
            // txtEstoque
            // 
            this.txtEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEstoque.Location = new System.Drawing.Point(362, 7);
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
            this.txtEstoque.Size = new System.Drawing.Size(256, 22);
            this.txtEstoque.TabIndex = 194;
            // 
            // FormAcertoEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 663);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.GradeProdutos);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAcertoEstoque";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "ACERTO DE ESTOQUE";
            this.Load += new System.EventHandler(this.FormAcertoEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GradeProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPictureEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemButtonEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateExpiracao.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateExpiracao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoDeBarra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstoqueActual.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidadeAdicionar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidadeActual.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidadeMin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstoque.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraGrid.GridControl GradeProdutos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridProdutos;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit itemPictureEliminar;
        private DevExpress.XtraGrid.Columns.GridColumn columnDataFrabricacao;
        private DevExpress.XtraGrid.Columns.GridColumn columnDataExpiracao;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ItemButtonEliminar;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PictureEdit picImage;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Button btnAdicionarProduto;
        private System.Windows.Forms.Button btnSelecionarProduto;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.DateEdit dateExpiracao;
        private DevExpress.XtraEditors.TextEdit txtCodigoDeBarra;
        private DevExpress.XtraEditors.TextEdit txtEstoqueActual;
        private DevExpress.XtraEditors.TextEdit txtDescricao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtQuantidadeAdicionar;
        private DevExpress.XtraEditors.TextEdit txtQuantidadeActual;
        private DevExpress.XtraEditors.TextEdit txtQuantidadeMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit txtEstoque;
    }
}