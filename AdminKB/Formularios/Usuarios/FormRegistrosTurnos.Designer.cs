
namespace AdminKB.Formularios.Usuarios
{
    partial class FormRegistrosTurnos
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
            this.gradeTurnos = new DevExpress.XtraGrid.GridControl();
            this.gridTurnos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnTurnoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.DateEnd = new DevExpress.XtraEditors.DateEdit();
            this.DateInit = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAbrir = new DevExpress.XtraBars.BarButtonItem();
            this.btnConfirmar = new DevExpress.XtraBars.BarButtonItem();
            this.btnFecharTurno = new DevExpress.XtraBars.BarButtonItem();
            this.btnAbrirTurno = new DevExpress.XtraBars.BarButtonItem();
            this.btnImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.btnActualizar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.gradeTurnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTurnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateInit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateInit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // gradeTurnos
            // 
            this.gradeTurnos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradeTurnos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gradeTurnos.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeTurnos.Location = new System.Drawing.Point(0, 108);
            this.gradeTurnos.MainView = this.gridTurnos;
            this.gradeTurnos.Margin = new System.Windows.Forms.Padding(4);
            this.gradeTurnos.Name = "gradeTurnos";
            this.gradeTurnos.Size = new System.Drawing.Size(1073, 561);
            this.gradeTurnos.TabIndex = 36;
            this.gradeTurnos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridTurnos});
            this.gradeTurnos.DoubleClick += new System.EventHandler(this.gradeTurnos_DoubleClick);
            // 
            // gridTurnos
            // 
            this.gridTurnos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn4,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn14,
            this.columnTurnoId});
            this.gridTurnos.DetailHeight = 485;
            this.gridTurnos.FixedLineWidth = 3;
            this.gridTurnos.GridControl = this.gradeTurnos;
            this.gridTurnos.Name = "gridTurnos";
            this.gridTurnos.OptionsBehavior.Editable = false;
            this.gridTurnos.OptionsFind.AllowFindPanel = false;
            this.gridTurnos.OptionsFind.AllowMruItems = false;
            this.gridTurnos.OptionsFind.FindNullPrompt = "Pesquisar...";
            this.gridTurnos.OptionsFind.ShowClearButton = false;
            this.gridTurnos.OptionsFind.ShowFindButton = false;
            this.gridTurnos.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Estado";
            this.gridColumn2.FieldName = "StrEstado";
            this.gridColumn2.MinWidth = 27;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.OptionsColumn.FixedWidth = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 7;
            this.gridColumn2.Width = 119;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Abertura";
            this.gridColumn4.DisplayFormat.FormatString = "d";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn4.FieldName = "DataAbertura";
            this.gridColumn4.MinWidth = 27;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowFocus = false;
            this.gridColumn4.OptionsColumn.FixedWidth = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 152;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Inicial";
            this.gridColumn6.DisplayFormat.FormatString = "N2";
            this.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gridColumn6.FieldName = "SaldoInicial";
            this.gridColumn6.MinWidth = 27;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.AllowFocus = false;
            this.gridColumn6.OptionsColumn.FixedWidth = true;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            this.gridColumn6.Width = 87;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Informado";
            this.gridColumn7.DisplayFormat.FormatString = "N2";
            this.gridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gridColumn7.FieldName = "SaldoInformado";
            this.gridColumn7.MinWidth = 27;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.OptionsColumn.AllowFocus = false;
            this.gridColumn7.OptionsColumn.FixedWidth = true;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            this.gridColumn7.Width = 88;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Vendas";
            this.gridColumn8.DisplayFormat.FormatString = "N2";
            this.gridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gridColumn8.FieldName = "SaldoVendas";
            this.gridColumn8.MinWidth = 27;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.OptionsColumn.AllowFocus = false;
            this.gridColumn8.OptionsColumn.FixedWidth = true;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 2;
            this.gridColumn8.Width = 83;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Total No Caixa";
            this.gridColumn9.DisplayFormat.FormatString = "N2";
            this.gridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gridColumn9.FieldName = "SaldoTotalNoCaixa";
            this.gridColumn9.MinWidth = 27;
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.OptionsColumn.AllowFocus = false;
            this.gridColumn9.OptionsColumn.FixedWidth = true;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 4;
            this.gridColumn9.Width = 79;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Quebra";
            this.gridColumn10.DisplayFormat.FormatString = "N2";
            this.gridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gridColumn10.FieldName = "QuebraCaixa";
            this.gridColumn10.MinWidth = 27;
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.OptionsColumn.AllowFocus = false;
            this.gridColumn10.OptionsColumn.FixedWidth = true;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 5;
            this.gridColumn10.Width = 87;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Caixa";
            this.gridColumn11.FieldName = "Caixa.Nome";
            this.gridColumn11.MinWidth = 27;
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            this.gridColumn11.OptionsColumn.AllowFocus = false;
            this.gridColumn11.OptionsColumn.FixedWidth = true;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 6;
            this.gridColumn11.Width = 107;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Confirmado";
            this.gridColumn14.FieldName = "StrConfirmado";
            this.gridColumn14.MinWidth = 27;
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.OptionsColumn.AllowEdit = false;
            this.gridColumn14.OptionsColumn.AllowFocus = false;
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 8;
            this.gridColumn14.Width = 101;
            // 
            // columnTurnoId
            // 
            this.columnTurnoId.Caption = "Número";
            this.columnTurnoId.FieldName = "TurnoId";
            this.columnTurnoId.Name = "columnTurnoId";
            this.columnTurnoId.OptionsColumn.AllowEdit = false;
            this.columnTurnoId.OptionsColumn.AllowFocus = false;
            // 
            // panel1
            // 
            this.panel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Appearance.Options.UseBackColor = true;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.DateEnd);
            this.panel1.Controls.Add(this.DateInit);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 68);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1073, 40);
            this.panel1.TabIndex = 116;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 184;
            this.label7.Text = "Usuário";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(75, 8);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtUsuario.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Properties.Appearance.Options.UseBackColor = true;
            this.txtUsuario.Properties.Appearance.Options.UseFont = true;
            this.txtUsuario.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtUsuario.Properties.ContextImageOptions.SvgImage = global::AdminKB.Properties.Resources.Mais;
            this.txtUsuario.Properties.ContextImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.txtUsuario.Properties.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(443, 22);
            this.txtUsuario.TabIndex = 183;
            this.txtUsuario.Click += new System.EventHandler(this.txtUsuario_Click);
            // 
            // DateEnd
            // 
            this.DateEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateEnd.EditValue = new System.DateTime(2020, 1, 23, 0, 0, 0, 0);
            this.DateEnd.Location = new System.Drawing.Point(919, 8);
            this.DateEnd.Margin = new System.Windows.Forms.Padding(4);
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.Properties.Appearance.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateEnd.Properties.Appearance.Options.UseFont = true;
            this.DateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateEnd.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.DateEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.DateEnd.Properties.EditFormat.FormatString = "";
            this.DateEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DateEnd.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.DateEnd.Size = new System.Drawing.Size(149, 22);
            this.DateEnd.TabIndex = 147;
            // 
            // DateInit
            // 
            this.DateInit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateInit.EditValue = new System.DateTime(2020, 1, 23, 0, 0, 0, 0);
            this.DateInit.Location = new System.Drawing.Point(762, 8);
            this.DateInit.Margin = new System.Windows.Forms.Padding(4);
            this.DateInit.Name = "DateInit";
            this.DateInit.Properties.Appearance.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateInit.Properties.Appearance.Options.UseFont = true;
            this.DateInit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateInit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateInit.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.DateInit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.DateInit.Properties.EditFormat.FormatString = "";
            this.DateInit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DateInit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.DateInit.Size = new System.Drawing.Size(149, 22);
            this.DateInit.TabIndex = 146;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(184)))), ((int)(((byte)(254)))));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(704, 10);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 16);
            this.labelControl3.TabIndex = 145;
            this.labelControl3.Text = "Intervalo";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Blue;
            this.ribbonControl1.CommandLayout = DevExpress.XtraBars.Ribbon.CommandLayout.Simplified;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnAbrir,
            this.btnConfirmar,
            this.btnFecharTurno,
            this.btnAbrirTurno,
            this.btnImprimir,
            this.btnActualizar});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 440;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(1073, 68);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            this.ribbonControl1.Visible = false;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Caption = "Ver Turno";
            this.btnAbrir.Id = 1;
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Caption = "Confirmar";
            this.btnConfirmar.Id = 2;
            this.btnConfirmar.ImageOptions.SvgImage = global::AdminKB.Properties.Resources.Confirmar;
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // btnFecharTurno
            // 
            this.btnFecharTurno.Caption = "Fechar Turno";
            this.btnFecharTurno.Id = 3;
            this.btnFecharTurno.ImageOptions.SvgImage = global::AdminKB.Properties.Resources.Fechar;
            this.btnFecharTurno.Name = "btnFecharTurno";
            // 
            // btnAbrirTurno
            // 
            this.btnAbrirTurno.Caption = "Abrir Turno";
            this.btnAbrirTurno.Id = 4;
            this.btnAbrirTurno.Name = "btnAbrirTurno";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Caption = "Imprimir";
            this.btnImprimir.Id = 5;
            this.btnImprimir.ImageOptions.SvgImage = global::AdminKB.Properties.Resources.Imprimir;
            this.btnImprimir.Name = "btnImprimir";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Caption = "Actualizar";
            this.btnActualizar.Id = 7;
            this.btnActualizar.ImageOptions.SvgImage = global::AdminKB.Properties.Resources.Actualizar;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnActualizar_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAbrir);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnConfirmar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
            this.ribbonPageGroup2.ItemLinks.Add(this.btnActualizar);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // FormRegistrosTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 669);
            this.ControlBox = false;
            this.Controls.Add(this.gradeTurnos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRegistrosTurnos";
            this.Ribbon = this.ribbonControl1;
            this.Text = "TURNOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormRegistrosTurnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gradeTurnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTurnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateInit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateInit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gradeTurnos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridTurnos;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraEditors.PanelControl panel1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnAbrir;
        private DevExpress.XtraBars.BarButtonItem btnConfirmar;
        private DevExpress.XtraBars.BarButtonItem btnFecharTurno;
        private DevExpress.XtraBars.BarButtonItem btnAbrirTurno;
        private DevExpress.XtraBars.BarButtonItem btnImprimir;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraEditors.DateEdit DateEnd;
        private DevExpress.XtraEditors.DateEdit DateInit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraBars.BarButtonItem btnActualizar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraGrid.Columns.GridColumn columnTurnoId;
    }
}