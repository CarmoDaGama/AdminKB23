
namespace AdminKB.Formularios.Financas
{
    partial class FormPagamento
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
            this.gridPagamentos = new DevExpress.XtraGrid.GridControl();
            this.gridViewPagamentos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescricao = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEntidadeId = new DevExpress.XtraEditors.TextEdit();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeEntidade = new DevExpress.XtraEditors.TextEdit();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.cboMoedas = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtDesconto = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorEntrego = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConcluir = new DevExpress.XtraEditors.SimpleButton();
            this.txtTroco = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridPagamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPagamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEntidadeId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeEntidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMoedas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesconto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorEntrego.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTroco.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridPagamentos
            // 
            this.gridPagamentos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridPagamentos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridPagamentos.Location = new System.Drawing.Point(13, 124);
            this.gridPagamentos.MainView = this.gridViewPagamentos;
            this.gridPagamentos.Margin = new System.Windows.Forms.Padding(4);
            this.gridPagamentos.Name = "gridPagamentos";
            this.gridPagamentos.Size = new System.Drawing.Size(555, 279);
            this.gridPagamentos.TabIndex = 6;
            this.gridPagamentos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPagamentos});
            // 
            // gridViewPagamentos
            // 
            this.gridViewPagamentos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridViewPagamentos.DetailHeight = 485;
            this.gridViewPagamentos.FixedLineWidth = 3;
            this.gridViewPagamentos.GridControl = this.gridPagamentos;
            this.gridViewPagamentos.Name = "gridViewPagamentos";
            this.gridViewPagamentos.OptionsBehavior.Editable = false;
            this.gridViewPagamentos.OptionsView.ShowGroupPanel = false;
            this.gridViewPagamentos.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewPagamentos_RowCellClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Nº";
            this.gridColumn1.FieldName = "FormaPagamentoId";
            this.gridColumn1.MinWidth = 27;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 52;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Forma";
            this.gridColumn2.FieldName = "Descricao";
            this.gridColumn2.MinWidth = 27;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 359;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Valor";
            this.gridColumn3.DisplayFormat.FormatString = "N3";
            this.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn3.FieldName = "Valor";
            this.gridColumn3.MinWidth = 27;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 119;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.txtTotal);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.txtDescricao);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.txtEntidadeId);
            this.panelControl1.Controls.Add(this.lblTitulo);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.txtNomeEntidade);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(582, 116);
            this.panelControl1.TabIndex = 5;
            // 
            // txtTotal
            // 
            this.txtTotal.EditValue = "0,00 AKZ";
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(70, 58);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Appearance.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Properties.Appearance.Options.UseFont = true;
            this.txtTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTotal.Properties.Mask.EditMask = "n2";
            this.txtTotal.Size = new System.Drawing.Size(502, 24);
            this.txtTotal.TabIndex = 104;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 14);
            this.label4.TabIndex = 126;
            this.label4.Text = "Ordem";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(70, 88);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtDescricao.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Properties.Appearance.Options.UseBackColor = true;
            this.txtDescricao.Properties.Appearance.Options.UseFont = true;
            this.txtDescricao.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtDescricao.Size = new System.Drawing.Size(502, 20);
            this.txtDescricao.TabIndex = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 14);
            this.label3.TabIndex = 124;
            this.label3.Text = "Total";
            // 
            // txtEntidadeId
            // 
            this.txtEntidadeId.Enabled = false;
            this.txtEntidadeId.Location = new System.Drawing.Point(70, 33);
            this.txtEntidadeId.Margin = new System.Windows.Forms.Padding(4);
            this.txtEntidadeId.Name = "txtEntidadeId";
            this.txtEntidadeId.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtEntidadeId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntidadeId.Properties.Appearance.Options.UseBackColor = true;
            this.txtEntidadeId.Properties.Appearance.Options.UseFont = true;
            this.txtEntidadeId.Size = new System.Drawing.Size(96, 20);
            this.txtEntidadeId.TabIndex = 99;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblTitulo.Location = new System.Drawing.Point(230, 5);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(118, 23);
            this.lblTitulo.TabIndex = 97;
            this.lblTitulo.Text = "PAGAMENTO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 14);
            this.label1.TabIndex = 97;
            this.label1.Text = "Entidade";
            // 
            // txtNomeEntidade
            // 
            this.txtNomeEntidade.Enabled = false;
            this.txtNomeEntidade.Location = new System.Drawing.Point(174, 33);
            this.txtNomeEntidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeEntidade.Name = "txtNomeEntidade";
            this.txtNomeEntidade.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtNomeEntidade.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeEntidade.Properties.Appearance.Options.UseBackColor = true;
            this.txtNomeEntidade.Properties.Appearance.Options.UseFont = true;
            this.txtNomeEntidade.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtNomeEntidade.Size = new System.Drawing.Size(398, 20);
            this.txtNomeEntidade.TabIndex = 92;
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.Appearance.Options.UseForeColor = true;
            this.btnClose.Location = new System.Drawing.Point(358, 100);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 44);
            this.btnClose.TabIndex = 102;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cboMoedas
            // 
            this.cboMoedas.EditValue = "AKZ";
            this.cboMoedas.Enabled = false;
            this.cboMoedas.Location = new System.Drawing.Point(69, 115);
            this.cboMoedas.Margin = new System.Windows.Forms.Padding(4);
            this.cboMoedas.Name = "cboMoedas";
            this.cboMoedas.Properties.Appearance.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMoedas.Properties.Appearance.Options.UseFont = true;
            this.cboMoedas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboMoedas.Properties.Items.AddRange(new object[] {
            "AKZ",
            "USD"});
            this.cboMoedas.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboMoedas.Size = new System.Drawing.Size(151, 22);
            this.cboMoedas.TabIndex = 8;
            this.cboMoedas.Visible = false;
            // 
            // txtDesconto
            // 
            this.txtDesconto.EditValue = "0,00 %";
            this.txtDesconto.Enabled = false;
            this.txtDesconto.Location = new System.Drawing.Point(488, 46);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Properties.Appearance.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesconto.Properties.Appearance.Options.UseFont = true;
            this.txtDesconto.Properties.Appearance.Options.UseTextOptions = true;
            this.txtDesconto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtDesconto.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtDesconto.Properties.Mask.EditMask = "n2";
            this.txtDesconto.Size = new System.Drawing.Size(77, 24);
            this.txtDesconto.TabIndex = 104;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 104;
            this.label2.Text = "Moeda";
            this.label2.Visible = false;
            // 
            // txtValorEntrego
            // 
            this.txtValorEntrego.EditValue = "0,00 AKZ";
            this.txtValorEntrego.Enabled = false;
            this.txtValorEntrego.Location = new System.Drawing.Point(123, 17);
            this.txtValorEntrego.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorEntrego.Name = "txtValorEntrego";
            this.txtValorEntrego.Properties.Appearance.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorEntrego.Properties.Appearance.Options.UseFont = true;
            this.txtValorEntrego.Properties.Appearance.Options.UseTextOptions = true;
            this.txtValorEntrego.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtValorEntrego.Properties.Mask.EditMask = "n2";
            this.txtValorEntrego.Size = new System.Drawing.Size(442, 24);
            this.txtValorEntrego.TabIndex = 104;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 14);
            this.label5.TabIndex = 104;
            this.label5.Text = "Valor Entregue";
            // 
            // btnConcluir
            // 
            this.btnConcluir.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.btnConcluir.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluir.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnConcluir.Appearance.Options.UseBackColor = true;
            this.btnConcluir.Appearance.Options.UseFont = true;
            this.btnConcluir.Appearance.Options.UseForeColor = true;
            this.btnConcluir.Enabled = false;
            this.btnConcluir.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnConcluir.Location = new System.Drawing.Point(422, 101);
            this.btnConcluir.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnConcluir.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnConcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(143, 43);
            this.btnConcluir.TabIndex = 123;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // txtTroco
            // 
            this.txtTroco.EditValue = "0,00 AKZ";
            this.txtTroco.Enabled = false;
            this.txtTroco.Location = new System.Drawing.Point(123, 46);
            this.txtTroco.Margin = new System.Windows.Forms.Padding(4);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.Properties.Appearance.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTroco.Properties.Appearance.Options.UseFont = true;
            this.txtTroco.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTroco.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTroco.Size = new System.Drawing.Size(357, 24);
            this.txtTroco.TabIndex = 104;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 56);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 14);
            this.label6.TabIndex = 104;
            this.label6.Text = "Troco/ Desconto";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtValorEntrego);
            this.groupBox1.Controls.Add(this.cboMoedas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnConcluir);
            this.groupBox1.Controls.Add(this.txtDesconto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTroco);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(3, 412);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(576, 154);
            this.groupBox1.TabIndex = 125;
            this.groupBox1.TabStop = false;
            // 
            // FormPagamento
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 568);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridPagamentos);
            this.Controls.Add(this.panelControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receber Pagamentos";
            this.Load += new System.EventHandler(this.FormPagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPagamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPagamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEntidadeId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeEntidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMoedas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesconto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorEntrego.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTroco.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

            }

            #endregion

            private DevExpress.XtraGrid.GridControl gridPagamentos;
            private DevExpress.XtraGrid.Views.Grid.GridView gridViewPagamentos;
            private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
            private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
            private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
            private DevExpress.XtraEditors.PanelControl panelControl1;
            private DevExpress.XtraEditors.SimpleButton btnClose;
            private DevExpress.XtraEditors.TextEdit txtEntidadeId;
            private System.Windows.Forms.Label label1;
            private DevExpress.XtraEditors.TextEdit txtNomeEntidade;
            private DevExpress.XtraEditors.ComboBoxEdit cboMoedas;
            private DevExpress.XtraEditors.TextEdit txtDesconto;
            private System.Windows.Forms.Label label2;
            private DevExpress.XtraEditors.TextEdit txtValorEntrego;
            private System.Windows.Forms.Label label5;
            private DevExpress.XtraEditors.SimpleButton btnConcluir;
            private System.Windows.Forms.Label label3;
            private DevExpress.XtraEditors.TextEdit txtTroco;
            private System.Windows.Forms.Label label6;
            private DevExpress.XtraEditors.TextEdit txtDescricao;
            private System.Windows.Forms.GroupBox groupBox1;
            private System.Windows.Forms.Label label4;
            private DevExpress.XtraEditors.TextEdit txtTotal;
        private System.Windows.Forms.Label lblTitulo;
    }
    }
