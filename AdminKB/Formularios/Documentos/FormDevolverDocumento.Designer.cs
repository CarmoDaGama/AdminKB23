
namespace AdminKB.Formularios.Documentos
{
    partial class FormDevolverDocumento
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnGravarDevolucao = new DevExpress.XtraBars.BarButtonItem();
            this.btnRemover = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gradeArtigoMovimentar = new DevExpress.XtraGrid.GridControl();
            this.gridArtigosMovimentar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView8 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelInfoDocument = new System.Windows.Forms.Panel();
            this.labelTotal = new System.Windows.Forms.Label();
            this.lblOperacao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeArtigoMovimentar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridArtigosMovimentar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).BeginInit();
            this.panelInfoDocument.SuspendLayout();
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
            this.btnGravarDevolucao,
            this.btnRemover});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4);
            this.ribbon.MaxItemId = 3;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 440;
            this.ribbon.OptionsPageCategories.ShowCaptions = false;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.PopupShowMode = DevExpress.XtraBars.PopupShowMode.Classic;
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.ShowQatLocationSelector = false;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(837, 68);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // btnGravarDevolucao
            // 
            this.btnGravarDevolucao.Caption = "Devolver";
            this.btnGravarDevolucao.Id = 1;
            this.btnGravarDevolucao.ImageOptions.SvgImage = global::AdminKB.Properties.Resources.Devolver_Documento;
            this.btnGravarDevolucao.Name = "btnGravarDevolucao";
            this.btnGravarDevolucao.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnGravarDevolucao.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGravarDevolucao_ItemClick);
            // 
            // btnRemover
            // 
            this.btnRemover.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnRemover.Caption = "Remover";
            this.btnRemover.Id = 2;
            this.btnRemover.ImageOptions.SvgImage = global::AdminKB.Properties.Resources.Remover_Linha;
            this.btnRemover.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.btnRemover.ItemAppearance.Normal.Options.UseFont = true;
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnRemover.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRemover_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.btnGravarDevolucao);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.btnRemover);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 675);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(837, 24);
            // 
            // gradeArtigoMovimentar
            // 
            this.gradeArtigoMovimentar.Cursor = System.Windows.Forms.Cursors.Default;
            this.gradeArtigoMovimentar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradeArtigoMovimentar.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            gridLevelNode1.RelationName = "Level1";
            this.gradeArtigoMovimentar.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gradeArtigoMovimentar.Location = new System.Drawing.Point(0, 134);
            this.gradeArtigoMovimentar.MainView = this.gridArtigosMovimentar;
            this.gradeArtigoMovimentar.Margin = new System.Windows.Forms.Padding(4);
            this.gradeArtigoMovimentar.Name = "gradeArtigoMovimentar";
            this.gradeArtigoMovimentar.Size = new System.Drawing.Size(837, 541);
            this.gradeArtigoMovimentar.TabIndex = 159;
            this.gradeArtigoMovimentar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridArtigosMovimentar,
            this.gridView8});
            // 
            // gridArtigosMovimentar
            // 
            this.gridArtigosMovimentar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn10,
            this.gridColumn1,
            this.gridColumn19});
            this.gridArtigosMovimentar.DetailHeight = 485;
            this.gridArtigosMovimentar.FixedLineWidth = 3;
            this.gridArtigosMovimentar.GridControl = this.gradeArtigoMovimentar;
            this.gridArtigosMovimentar.Name = "gridArtigosMovimentar";
            this.gridArtigosMovimentar.OptionsSelection.MultiSelect = true;
            this.gridArtigosMovimentar.OptionsView.ShowGroupPanel = false;
            this.gridArtigosMovimentar.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridArtigosMovimentar_RowCellClick);
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn2.Caption = "Descrição";
            this.gridColumn2.FieldName = "ProdutoEstoque.Produto.Nome";
            this.gridColumn2.MinWidth = 27;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 308;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn4.Caption = "Preço";
            this.gridColumn4.DisplayFormat.FormatString = "N2";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn4.FieldName = "Preco";
            this.gridColumn4.MinWidth = 27;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowFocus = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 95;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn5.Caption = "Quantidade";
            this.gridColumn5.DisplayFormat.FormatString = "N2";
            this.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn5.FieldName = "Quantidade";
            this.gridColumn5.MinWidth = 27;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.AllowFocus = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 123;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn6.Caption = "Familia";
            this.gridColumn6.FieldName = "Familia";
            this.gridColumn6.MinWidth = 27;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Width = 59;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn7.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn7.Caption = "Total";
            this.gridColumn7.DisplayFormat.FormatString = "N2";
            this.gridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn7.FieldName = "Total";
            this.gridColumn7.MinWidth = 27;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.OptionsColumn.AllowFocus = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            this.gridColumn7.Width = 123;
            // 
            // gridColumn10
            // 
            this.gridColumn10.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn10.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn10.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn10.Caption = "Taxa";
            this.gridColumn10.DisplayFormat.FormatString = "N3";
            this.gridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn10.FieldName = "Imposto";
            this.gridColumn10.MinWidth = 27;
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.OptionsColumn.AllowFocus = false;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 4;
            this.gridColumn10.Width = 69;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn1.Caption = "Desc";
            this.gridColumn1.DisplayFormat.FormatString = "N2";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn1.FieldName = "Desconto";
            this.gridColumn1.MinWidth = 27;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 94;
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "Código";
            this.gridColumn19.FieldName = "ProdutoMovimentacaoId";
            this.gridColumn19.MinWidth = 27;
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.Width = 100;
            // 
            // gridView8
            // 
            this.gridView8.DetailHeight = 485;
            this.gridView8.FixedLineWidth = 3;
            this.gridView8.GridControl = this.gradeArtigoMovimentar;
            this.gridView8.Name = "gridView8";
            // 
            // panelInfoDocument
            // 
            this.panelInfoDocument.Controls.Add(this.labelTotal);
            this.panelInfoDocument.Controls.Add(this.lblOperacao);
            this.panelInfoDocument.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfoDocument.Location = new System.Drawing.Point(0, 68);
            this.panelInfoDocument.Margin = new System.Windows.Forms.Padding(4);
            this.panelInfoDocument.Name = "panelInfoDocument";
            this.panelInfoDocument.Size = new System.Drawing.Size(837, 66);
            this.panelInfoDocument.TabIndex = 162;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelTotal.Font = new System.Drawing.Font("Consolas", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.labelTotal.Location = new System.Drawing.Point(697, 0);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(140, 31);
            this.labelTotal.TabIndex = 16;
            this.labelTotal.Text = "00,00 AKZ";
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOperacao.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.lblOperacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.lblOperacao.Location = new System.Drawing.Point(0, 0);
            this.lblOperacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(135, 19);
            this.lblOperacao.TabIndex = 15;
            this.lblOperacao.Text = "FACTURA RECIBO";
            this.lblOperacao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormDevolverDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 699);
            this.Controls.Add(this.gradeArtigoMovimentar);
            this.Controls.Add(this.panelInfoDocument);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDevolverDocumento";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "DEVOLVER ARTIGOS";
            this.Load += new System.EventHandler(this.FormDevolverArtigoMov_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeArtigoMovimentar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridArtigosMovimentar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).EndInit();
            this.panelInfoDocument.ResumeLayout(false);
            this.panelInfoDocument.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnGravarDevolucao;
        private DevExpress.XtraBars.BarButtonItem btnRemover;
        private DevExpress.XtraGrid.GridControl gradeArtigoMovimentar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridArtigosMovimentar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView8;
        private System.Windows.Forms.Panel panelInfoDocument;
        private System.Windows.Forms.Label lblOperacao;
        private System.Windows.Forms.Label labelTotal;
    }
}