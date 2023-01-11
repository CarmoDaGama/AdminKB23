
namespace AdminKB.Formularios.Geral
{
    partial class FormListagemTabela<Tabela>
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
        {            this.gridEntity = new DevExpress.XtraGrid.GridControl();
            this.gridViewEntity = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.columnEntityId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnGravar = new DevExpress.XtraBars.BarButtonItem();
            this.buttonSelecionar = new DevExpress.XtraBars.BarButtonItem();
            this.btnCloser = new DevExpress.XtraBars.BarButtonItem();
            this.btnEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnNovo = new DevExpress.XtraBars.BarButtonItem();
            this.btnImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panelSave = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescricao = new DevExpress.XtraEditors.TextEdit();
            this.panelList = new System.Windows.Forms.Panel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.searchProcuraProdutos = new DevExpress.XtraEditors.SearchControl();
            this.labelInfo = new DevExpress.XtraEditors.LabelControl();
            this.btnFechar = new DevExpress.XtraBars.BarButtonItem();
            this.gridColumnCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDescricao = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.panelSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).BeginInit();
            this.panelList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchProcuraProdutos.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridEntity
            // 
            this.gridEntity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridEntity.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridEntity.Location = new System.Drawing.Point(20, 59);
            this.gridEntity.MainView = this.gridViewEntity;
            this.gridEntity.Margin = new System.Windows.Forms.Padding(4);
            this.gridEntity.Name = "gridEntity";
            this.gridEntity.Size = new System.Drawing.Size(481, 372);
            this.gridEntity.TabIndex = 123;
            this.gridEntity.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEntity});
            // 
            // gridViewEntity
            // 
            this.gridViewEntity.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.columnEntityId,
            this.columnName});
            this.gridViewEntity.DetailHeight = 485;
            this.gridViewEntity.FixedLineWidth = 3;
            this.gridViewEntity.GridControl = this.gridEntity;
            this.gridViewEntity.Name = "gridViewEntity";
            this.gridViewEntity.OptionsFind.FindNullPrompt = "Pesquisar...";
            this.gridViewEntity.OptionsFind.ShowClearButton = false;
            this.gridViewEntity.OptionsFind.ShowFindButton = false;
            this.gridViewEntity.OptionsView.ShowGroupPanel = false;
            this.gridViewEntity.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridViewEntity.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            this.gridViewEntity.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // columnEntityId
            // 
            this.columnEntityId.Caption = "Id";
            this.columnEntityId.MinWidth = 27;
            this.columnEntityId.Name = "columnEntityId";
            this.columnEntityId.OptionsColumn.AllowEdit = false;
            this.columnEntityId.OptionsColumn.FixedWidth = true;
            this.columnEntityId.OptionsColumn.ReadOnly = true;
            this.columnEntityId.Visible = true;
            this.columnEntityId.VisibleIndex = 0;
            this.columnEntityId.Width = 132;
            // 
            // columnName
            // 
            this.columnName.Caption = "Nome";
            this.columnName.FieldName = "Nome";
            this.columnName.MinWidth = 27;
            this.columnName.Name = "columnName";
            this.columnName.OptionsColumn.AllowEdit = false;
            this.columnName.OptionsColumn.ReadOnly = true;
            this.columnName.Visible = true;
            this.columnName.VisibleIndex = 1;
            this.columnName.Width = 503;
            // 
            // ribbon
            // 
            this.ribbon.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Blue;
            this.ribbon.CommandLayout = DevExpress.XtraBars.Ribbon.CommandLayout.Simplified;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnGravar,
            this.buttonSelecionar,
            this.btnCloser,
            this.btnEliminar});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4);
            this.ribbon.MaxItemId = 26;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 440;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.Size = new System.Drawing.Size(517, 68);
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // btnGravar
            // 
            this.btnGravar.Caption = "Salvar";
            this.btnGravar.Enabled = false;
            this.btnGravar.Id = 1;
            this.btnGravar.ImageOptions.SvgImage = global::AdminKB.Properties.Resources.Save;
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnGravar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGravar_ItemClick);
            // 
            // buttonSelecionar
            // 
            this.buttonSelecionar.Caption = "Selecionar";
            this.buttonSelecionar.Id = 20;
            this.buttonSelecionar.ImageOptions.SvgImage = global::AdminKB.Properties.Resources.Cursor_Seleciona;
            this.buttonSelecionar.Name = "buttonSelecionar";
            this.buttonSelecionar.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.buttonSelecionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.buttonSelecionar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonSelecionar_ItemClick);
            // 
            // btnCloser
            // 
            this.btnCloser.Caption = "Fechar";
            this.btnCloser.Id = 21;
            this.btnCloser.ImageOptions.SvgImage = global::AdminKB.Properties.Resources.Close;
            this.btnCloser.Name = "btnCloser";
            this.btnCloser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCloser_ItemClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Caption = "Eliminar";
            this.btnEliminar.Id = 21;
            this.btnEliminar.ImageOptions.SvgImage = global::AdminKB.Properties.Resources.Remover_Linha;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEliminar_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.buttonSelecionar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNovo);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnGravar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnImprimir);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCloser);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnEliminar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tarefas";
            // 
            // btnNovo
            // 
            this.btnNovo.Caption = "Novo";
            this.btnNovo.Id = 10;
            this.btnNovo.ImageOptions.SvgImage = global::AdminKB.Properties.Resources.Plus;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnNovo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNovo_ItemClick);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Caption = "Imprimir";
            this.btnImprimir.Id = 16;
            this.btnImprimir.ImageOptions.SvgImage = global::AdminKB.Properties.Resources.Imprimir;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnImprimir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnImprimir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem13_ItemClick);
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // panelSave
            // 
            this.panelSave.BackColor = System.Drawing.Color.Transparent;
            this.panelSave.Controls.Add(this.label4);
            this.panelSave.Controls.Add(this.txtDescricao);
            this.panelSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSave.Location = new System.Drawing.Point(0, 68);
            this.panelSave.Margin = new System.Windows.Forms.Padding(4);
            this.panelSave.Name = "panelSave";
            this.panelSave.Size = new System.Drawing.Size(517, 46);
            this.panelSave.TabIndex = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 123;
            this.label4.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(115, 10);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Properties.Appearance.Options.UseFont = true;
            this.txtDescricao.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtDescricao.Properties.MaxLength = 100;
            this.txtDescricao.Size = new System.Drawing.Size(386, 22);
            this.txtDescricao.TabIndex = 122;
            // 
            // panelList
            // 
            this.panelList.Controls.Add(this.panelControl1);
            this.panelList.Controls.Add(this.labelInfo);
            this.panelList.Controls.Add(this.gridEntity);
            this.panelList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelList.Location = new System.Drawing.Point(0, 114);
            this.panelList.Margin = new System.Windows.Forms.Padding(4);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(517, 480);
            this.panelList.TabIndex = 126;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.searchProcuraProdutos);
            this.panelControl1.Location = new System.Drawing.Point(20, 20);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(481, 40);
            this.panelControl1.TabIndex = 125;
            // 
            // searchProcuraProdutos
            // 
            this.searchProcuraProdutos.Client = this.gridEntity;
            this.searchProcuraProdutos.Location = new System.Drawing.Point(23, 8);
            this.searchProcuraProdutos.MenuManager = this.ribbon;
            this.searchProcuraProdutos.Name = "searchProcuraProdutos";
            this.searchProcuraProdutos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchProcuraProdutos.Properties.Client = this.gridEntity;
            this.searchProcuraProdutos.Size = new System.Drawing.Size(299, 24);
            this.searchProcuraProdutos.TabIndex = 0;
            // 
            // labelInfo
            // 
            this.labelInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelInfo.Location = new System.Drawing.Point(185, 450);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(4);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(178, 18);
            this.labelInfo.TabIndex = 124;
            this.labelInfo.Text = "Duplo clique para selecionar";
            this.labelInfo.Visible = false;
            // 
            // btnFechar
            // 
            this.btnFechar.Caption = "Fechar";
            this.btnFechar.Id = 3;
            this.btnFechar.Name = "btnFechar";
            // 
            // gridColumnCodigo
            // 
            this.gridColumnCodigo.Caption = "Código";
            this.gridColumnCodigo.FieldName = "Codigo";
            this.gridColumnCodigo.Name = "gridColumnCodigo";
            this.gridColumnCodigo.OptionsColumn.AllowEdit = false;
            this.gridColumnCodigo.OptionsColumn.FixedWidth = true;
            this.gridColumnCodigo.Visible = true;
            this.gridColumnCodigo.VisibleIndex = 0;
            // 
            // gridColumnDescricao
            // 
            this.gridColumnDescricao.Caption = "Descrição";
            this.gridColumnDescricao.FieldName = "Descricao";
            this.gridColumnDescricao.Name = "gridColumnDescricao";
            this.gridColumnDescricao.OptionsColumn.AllowEdit = false;
            this.gridColumnDescricao.Visible = true;
            this.gridColumnDescricao.VisibleIndex = 1;
            this.gridColumnDescricao.Width = 322;
            // 
            // FormListagemTabela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 594);
            this.ControlBox = false;
            this.Controls.Add(this.panelList);
            this.Controls.Add(this.panelSave);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormListagemTabela";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Inteligente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInteligente_FormClosing);
            this.Load += new System.EventHandler(this.frmInteligente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.panelSave.ResumeLayout(false);
            this.panelSave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).EndInit();
            this.panelList.ResumeLayout(false);
            this.panelList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchProcuraProdutos.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridEntity;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEntity;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem btnGravar;
        private DevExpress.XtraBars.BarButtonItem btnNovo;
        private DevExpress.XtraBars.BarButtonItem btnImprimir;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem buttonSelecionar;
        private System.Windows.Forms.Panel panelSave;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtDescricao;
        private System.Windows.Forms.Panel panelList;
        internal DevExpress.XtraBars.BarButtonItem btnFechar;
        internal DevExpress.XtraBars.BarButtonItem btnCloser;
        internal DevExpress.XtraBars.BarButtonItem btnEliminar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraEditors.LabelControl labelInfo;
        private DevExpress.XtraGrid.Columns.GridColumn columnEntityId;
        private DevExpress.XtraGrid.Columns.GridColumn columnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDescricao;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SearchControl searchProcuraProdutos;
    }
}