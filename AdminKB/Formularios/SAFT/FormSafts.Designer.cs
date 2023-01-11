
namespace AdminKB.Formularios.SAFT
{
    partial class FormSafts
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
            this.searchProcuraSaft = new DevExpress.XtraEditors.SearchControl();
            this.GradeSafts = new DevExpress.XtraGrid.GridControl();
            this.gridSafts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemButtonEliminar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.itemPictureEliminar = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.panelCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchProcuraSaft.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GradeSafts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSafts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemButtonEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPictureEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
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
            // 
            // btnEliminar
            // 
            this.btnEliminar.Caption = "Eliminar";
            this.btnEliminar.Id = 3;
            this.btnEliminar.ImageOptions.SvgImage = global::AdminKB.Properties.Resources.Remover_Linha;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
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
            this.label1.Size = new System.Drawing.Size(172, 19);
            this.label1.TabIndex = 105;
            this.label1.Text = "REGISTROS DE SAFTS";
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
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.searchProcuraSaft);
            this.panelControl1.Location = new System.Drawing.Point(13, 71);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(983, 42);
            this.panelControl1.TabIndex = 25;
            // 
            // searchProcuraSaft
            // 
            this.searchProcuraSaft.Client = this.GradeSafts;
            this.searchProcuraSaft.Location = new System.Drawing.Point(23, 8);
            this.searchProcuraSaft.MenuManager = this.ribbon;
            this.searchProcuraSaft.Name = "searchProcuraSaft";
            this.searchProcuraSaft.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchProcuraSaft.Properties.Client = this.GradeSafts;
            this.searchProcuraSaft.Size = new System.Drawing.Size(369, 24);
            this.searchProcuraSaft.TabIndex = 0;
            // 
            // GradeSafts
            // 
            this.GradeSafts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GradeSafts.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.GradeSafts.Location = new System.Drawing.Point(13, 112);
            this.GradeSafts.MainView = this.gridSafts;
            this.GradeSafts.Margin = new System.Windows.Forms.Padding(4);
            this.GradeSafts.Name = "GradeSafts";
            this.GradeSafts.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ItemButtonEliminar,
            this.itemPictureEliminar});
            this.GradeSafts.Size = new System.Drawing.Size(983, 610);
            this.GradeSafts.TabIndex = 24;
            this.GradeSafts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridSafts});
            this.GradeSafts.DoubleClick += new System.EventHandler(this.GradeSafts_DoubleClick);
            // 
            // gridSafts
            // 
            this.gridSafts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn12,
            this.gridColumn1,
            this.gridColumn6,
            this.gridColumn7});
            this.gridSafts.DetailHeight = 485;
            this.gridSafts.FixedLineWidth = 3;
            this.gridSafts.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridSafts.GridControl = this.GradeSafts;
            this.gridSafts.Name = "gridSafts";
            this.gridSafts.OptionsFind.FindNullPrompt = "Pesquisar...";
            this.gridSafts.OptionsFind.ShowClearButton = false;
            this.gridSafts.OptionsFind.ShowFindButton = false;
            this.gridSafts.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Inicio";
            this.gridColumn12.FieldName = "DataInicio";
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
            this.gridColumn1.FieldName = "SaftId";
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
            this.gridColumn6.Caption = "Termino";
            this.gridColumn6.FieldName = "DataFim";
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
            this.gridColumn7.Caption = "Data Registro";
            this.gridColumn7.FieldName = "DataCadastro";
            this.gridColumn7.MinWidth = 27;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.OptionsColumn.AllowFocus = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            this.gridColumn7.Width = 96;
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
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.label6);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(0, 731);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1009, 30);
            this.panelControl3.TabIndex = 107;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(390, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 16);
            this.label6.TabIndex = 99;
            this.label6.Text = "Duplo clique para abrir ficheiro Saft";
            // 
            // FormSafts
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 785);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.GradeSafts);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Controls.Add(this.panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSafts";
            this.Text = "FormUsuarios";
            this.Load += new System.EventHandler(this.FormSafts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchProcuraSaft.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GradeSafts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSafts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemButtonEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPictureEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
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
        private DevExpress.XtraEditors.SearchControl searchProcuraSaft;
        private DevExpress.XtraGrid.GridControl GradeSafts;
        private DevExpress.XtraGrid.Views.Grid.GridView gridSafts;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit itemPictureEliminar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ItemButtonEliminar;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarButtonItem btnNovo;
        private DevExpress.XtraBars.BarButtonItem btnSelecionar;
        private DevExpress.XtraBars.BarButtonItem btnEliminar;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.Label label6;
    }
}