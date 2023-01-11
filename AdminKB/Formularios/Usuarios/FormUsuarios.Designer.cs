
namespace AdminKB.Formularios.Usuarios
{
    partial class FormUsuarios
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
            this.btnNovo = new DevExpress.XtraBars.BarButtonItem();
            this.btnSelecionar = new DevExpress.XtraBars.BarButtonItem();
            this.btnEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.searchProcuraProdutos = new DevExpress.XtraEditors.SearchControl();
            this.GradeUsuarios = new DevExpress.XtraGrid.GridControl();
            this.gridUsuarios = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itemPictureEliminar = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.columnDataFrabricacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnDataExpiracao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemButtonEliminar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.panelCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchProcuraProdutos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GradeUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPictureEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemButtonEliminar)).BeginInit();
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
            this.btnNovo,
            this.btnSelecionar,
            this.btnEliminar});
            this.ribbon.Location = new System.Drawing.Point(0, 25);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.Size = new System.Drawing.Size(1009, 33);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // btnNovo
            // 
            this.btnNovo.Caption = "Novo";
            this.btnNovo.Id = 1;
            this.btnNovo.ImageOptions.SvgImage = global::AdminKB.Properties.Resources.Novo_Produto;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNovo_ItemClick);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Caption = "Selecionar";
            this.btnSelecionar.Id = 2;
            this.btnSelecionar.ImageOptions.SvgImage = global::AdminKB.Properties.Resources.Cursor_Seleciona;
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnSelecionar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSelecionar_ItemClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Caption = "Eliminar";
            this.btnEliminar.Id = 3;
            this.btnEliminar.ImageOptions.SvgImage = global::AdminKB.Properties.Resources.Remover_Linha;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEliminar_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNovo);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSelecionar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnEliminar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 761);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1009, 24);
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.Black;
            this.panelCabecalho.Controls.Add(this.label1);
            this.panelCabecalho.Controls.Add(this.btnClose);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(1009, 25);
            this.panelCabecalho.TabIndex = 2;
            this.panelCabecalho.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 105;
            this.label1.Text = "USUÁRIOS";
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
            this.btnClose.Location = new System.Drawing.Point(981, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 25);
            this.btnClose.TabIndex = 104;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.searchProcuraProdutos);
            this.panelControl1.Location = new System.Drawing.Point(13, 71);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(983, 42);
            this.panelControl1.TabIndex = 25;
            // 
            // searchProcuraProdutos
            // 
            this.searchProcuraProdutos.Client = this.GradeUsuarios;
            this.searchProcuraProdutos.Location = new System.Drawing.Point(23, 8);
            this.searchProcuraProdutos.MenuManager = this.ribbon;
            this.searchProcuraProdutos.Name = "searchProcuraProdutos";
            this.searchProcuraProdutos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchProcuraProdutos.Properties.Client = this.GradeUsuarios;
            this.searchProcuraProdutos.Size = new System.Drawing.Size(369, 24);
            this.searchProcuraProdutos.TabIndex = 0;
            // 
            // GradeUsuarios
            // 
            this.GradeUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GradeUsuarios.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.GradeUsuarios.Location = new System.Drawing.Point(13, 112);
            this.GradeUsuarios.MainView = this.gridUsuarios;
            this.GradeUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.GradeUsuarios.Name = "GradeUsuarios";
            this.GradeUsuarios.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ItemButtonEliminar,
            this.itemPictureEliminar});
            this.GradeUsuarios.Size = new System.Drawing.Size(983, 642);
            this.GradeUsuarios.TabIndex = 24;
            this.GradeUsuarios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridUsuarios});
            // 
            // gridUsuarios
            // 
            this.gridUsuarios.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn12,
            this.gridColumn1,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.columnDataFrabricacao,
            this.columnDataExpiracao});
            this.gridUsuarios.DetailHeight = 485;
            this.gridUsuarios.FixedLineWidth = 3;
            this.gridUsuarios.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridUsuarios.GridControl = this.GradeUsuarios;
            this.gridUsuarios.Name = "gridUsuarios";
            this.gridUsuarios.OptionsFind.FindNullPrompt = "Pesquisar...";
            this.gridUsuarios.OptionsFind.ShowClearButton = false;
            this.gridUsuarios.OptionsFind.ShowFindButton = false;
            this.gridUsuarios.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Nome";
            this.gridColumn12.FieldName = "Nome";
            this.gridColumn12.MinWidth = 27;
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.AllowEdit = false;
            this.gridColumn12.OptionsColumn.AllowFocus = false;
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 1;
            this.gridColumn12.Width = 294;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn1.Caption = "Número";
            this.gridColumn1.FieldName = "UsuarioId";
            this.gridColumn1.MinWidth = 27;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 63;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Acesso";
            this.gridColumn6.FieldName = "Acesso.Nome";
            this.gridColumn6.MinWidth = 27;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.AllowFocus = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            this.gridColumn6.Width = 85;
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
            // FormUsuarios
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 785);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.GradeUsuarios);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Controls.Add(this.panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUsuarios";
            this.Text = "FormUsuarios";
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchProcuraProdutos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GradeUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPictureEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemButtonEliminar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private System.Windows.Forms.Panel panelCabecalho;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SearchControl searchProcuraProdutos;
        private DevExpress.XtraGrid.GridControl GradeUsuarios;
        private DevExpress.XtraGrid.Views.Grid.GridView gridUsuarios;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit itemPictureEliminar;
        private DevExpress.XtraGrid.Columns.GridColumn columnDataFrabricacao;
        private DevExpress.XtraGrid.Columns.GridColumn columnDataExpiracao;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ItemButtonEliminar;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarButtonItem btnNovo;
        private DevExpress.XtraBars.BarButtonItem btnSelecionar;
        private DevExpress.XtraBars.BarButtonItem btnEliminar;
    }
}