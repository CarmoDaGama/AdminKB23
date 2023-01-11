
namespace AdminKB.Formularios.Financas
{
    partial class FormFormasPagamentos
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
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnNovo = new DevExpress.XtraBars.BarButtonItem();
            this.btnEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.searchProcuraProdutos = new DevExpress.XtraEditors.SearchControl();
            this.GradeFormas = new DevExpress.XtraGrid.GridControl();
            this.gridFormas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnFormaPagamentoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemButtonEliminar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.itemPictureEliminar = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchProcuraProdutos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GradeFormas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFormas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemButtonEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPictureEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 752);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(816, 24);
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
            this.btnEliminar});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.Size = new System.Drawing.Size(816, 68);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.btnEliminar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.searchProcuraProdutos);
            this.panelControl1.Location = new System.Drawing.Point(14, 79);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(789, 42);
            this.panelControl1.TabIndex = 25;
            // 
            // searchProcuraProdutos
            // 
            this.searchProcuraProdutos.Client = this.GradeFormas;
            this.searchProcuraProdutos.Location = new System.Drawing.Point(23, 8);
            this.searchProcuraProdutos.MenuManager = this.ribbon;
            this.searchProcuraProdutos.Name = "searchProcuraProdutos";
            this.searchProcuraProdutos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchProcuraProdutos.Properties.Client = this.GradeFormas;
            this.searchProcuraProdutos.Size = new System.Drawing.Size(369, 24);
            this.searchProcuraProdutos.TabIndex = 0;
            // 
            // GradeFormas
            // 
            this.GradeFormas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GradeFormas.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.GradeFormas.Location = new System.Drawing.Point(14, 120);
            this.GradeFormas.MainView = this.gridFormas;
            this.GradeFormas.Margin = new System.Windows.Forms.Padding(4);
            this.GradeFormas.Name = "GradeFormas";
            this.GradeFormas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ItemButtonEliminar,
            this.itemPictureEliminar});
            this.GradeFormas.Size = new System.Drawing.Size(789, 625);
            this.GradeFormas.TabIndex = 24;
            this.GradeFormas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridFormas});
            // 
            // gridFormas
            // 
            this.gridFormas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn12,
            this.gridColumn1,
            this.gridColumn5,
            this.gridColumn6,
            this.columnFormaPagamentoId});
            this.gridFormas.DetailHeight = 485;
            this.gridFormas.FixedLineWidth = 3;
            this.gridFormas.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridFormas.GridControl = this.GradeFormas;
            this.gridFormas.Name = "gridFormas";
            this.gridFormas.OptionsFind.FindNullPrompt = "Pesquisar...";
            this.gridFormas.OptionsFind.ShowClearButton = false;
            this.gridFormas.OptionsFind.ShowFindButton = false;
            this.gridFormas.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Banco";
            this.gridColumn3.FieldName = "Banco";
            this.gridColumn3.MinWidth = 27;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 111;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Descriçaõ";
            this.gridColumn12.FieldName = "Descricao";
            this.gridColumn12.MinWidth = 27;
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.AllowEdit = false;
            this.gridColumn12.OptionsColumn.AllowFocus = false;
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 0;
            this.gridColumn12.Width = 269;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn1.Caption = "Número";
            this.gridColumn1.FieldName = "FormaPagamentoId";
            this.gridColumn1.MinWidth = 27;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.Width = 63;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn5.Caption = "IBAN";
            this.gridColumn5.FieldName = "IBAN";
            this.gridColumn5.MinWidth = 27;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.AllowFocus = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 277;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Número Conta";
            this.gridColumn6.FieldName = "Numero";
            this.gridColumn6.MinWidth = 27;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.AllowFocus = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            this.gridColumn6.Width = 107;
            // 
            // columnFormaPagamentoId
            // 
            this.columnFormaPagamentoId.AppearanceCell.Options.UseTextOptions = true;
            this.columnFormaPagamentoId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.columnFormaPagamentoId.AppearanceHeader.Options.UseTextOptions = true;
            this.columnFormaPagamentoId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.columnFormaPagamentoId.Caption = "Data de Expiração";
            this.columnFormaPagamentoId.FieldName = "FormaPagamentoId";
            this.columnFormaPagamentoId.Name = "columnFormaPagamentoId";
            this.columnFormaPagamentoId.OptionsColumn.AllowEdit = false;
            this.columnFormaPagamentoId.OptionsColumn.AllowFocus = false;
            this.columnFormaPagamentoId.Width = 159;
            // 
            // ItemButtonEliminar
            // 
            this.ItemButtonEliminar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.ItemButtonEliminar.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.ItemButtonEliminar.ContextImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.ItemButtonEliminar.Name = "ItemButtonEliminar";
            // 
            // itemPictureEliminar
            // 
            this.itemPictureEliminar.Name = "itemPictureEliminar";
            this.itemPictureEliminar.ReadOnly = true;
            this.itemPictureEliminar.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // FormFormasPagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 776);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.GradeFormas);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFormasPagamentos";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "FORMAS DE PAGAMENTOS";
            this.Load += new System.EventHandler(this.FormFormasPagamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchProcuraProdutos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GradeFormas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFormas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemButtonEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPictureEliminar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SearchControl searchProcuraProdutos;
        private DevExpress.XtraGrid.GridControl GradeFormas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridFormas;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit itemPictureEliminar;
        private DevExpress.XtraGrid.Columns.GridColumn columnFormaPagamentoId;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ItemButtonEliminar;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem btnNovo;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnEliminar;
    }
}