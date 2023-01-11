
namespace AdminKB.Formularios.Usuarios
{
    partial class FormFecharTurno
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnFechar = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.btnFecharTurno = new DevExpress.XtraBars.BarButtonItem();
            this.btnAbrirTurno = new DevExpress.XtraBars.BarButtonItem();
            this.btnImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.btnVoltar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSaldoQuebra = new DevExpress.XtraEditors.TextEdit();
            this.txtSaldoImformado = new DevExpress.XtraEditors.TextEdit();
            this.richTextBox1 = new DevExpress.XtraEditors.MemoEdit();
            this.txtSaldoTotalCaixa = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldoQuebra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldoImformado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.richTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldoTotalCaixa.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Blue;
            this.ribbonControl1.CommandLayout = DevExpress.XtraBars.Ribbon.CommandLayout.Simplified;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnFechar,
            this.btnClose,
            this.btnFecharTurno,
            this.btnAbrirTurno,
            this.btnImprimir,
            this.btnVoltar});
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
            this.ribbonControl1.Size = new System.Drawing.Size(537, 68);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // btnFechar
            // 
            this.btnFechar.Caption = "Fechar Caixa";
            this.btnFechar.Id = 1;
            this.btnFechar.ImageOptions.SvgImage = global::AdminKB.Properties.Resources.fechar_Turno;
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFechar_ItemClick);
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Fechar";
            this.btnClose.Id = 2;
            this.btnClose.Name = "btnClose";
            // 
            // btnFecharTurno
            // 
            this.btnFecharTurno.Caption = "Fechar Turno";
            this.btnFecharTurno.Id = 3;
            this.btnFecharTurno.Name = "btnFecharTurno";
            // 
            // btnAbrirTurno
            // 
            this.btnAbrirTurno.Id = 7;
            this.btnAbrirTurno.Name = "btnAbrirTurno";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Caption = "Imprimir";
            this.btnImprimir.Id = 5;
            this.btnImprimir.Name = "btnImprimir";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Caption = "Voltar";
            this.btnVoltar.Id = 6;
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
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
            this.ribbonPageGroup1.ItemLinks.Add(this.btnFechar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnVoltar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label1.Location = new System.Drawing.Point(16, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Informe o Saldo que Possui:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label2.Location = new System.Drawing.Point(16, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quebra De Caixa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label3.Location = new System.Drawing.Point(15, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descrição:";
            // 
            // txtSaldoQuebra
            // 
            this.txtSaldoQuebra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSaldoQuebra.EditValue = "0,00";
            this.txtSaldoQuebra.Enabled = false;
            this.txtSaldoQuebra.Location = new System.Drawing.Point(16, 209);
            this.txtSaldoQuebra.Margin = new System.Windows.Forms.Padding(4);
            this.txtSaldoQuebra.Name = "txtSaldoQuebra";
            this.txtSaldoQuebra.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoQuebra.Properties.Appearance.Options.UseFont = true;
            this.txtSaldoQuebra.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSaldoQuebra.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtSaldoQuebra.Properties.Mask.EditMask = "n2";
            this.txtSaldoQuebra.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSaldoQuebra.Size = new System.Drawing.Size(501, 22);
            this.txtSaldoQuebra.TabIndex = 161;
            // 
            // txtSaldoImformado
            // 
            this.txtSaldoImformado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSaldoImformado.EditValue = "0,00";
            this.txtSaldoImformado.Location = new System.Drawing.Point(16, 152);
            this.txtSaldoImformado.Margin = new System.Windows.Forms.Padding(4);
            this.txtSaldoImformado.Name = "txtSaldoImformado";
            this.txtSaldoImformado.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoImformado.Properties.Appearance.Options.UseFont = true;
            this.txtSaldoImformado.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSaldoImformado.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtSaldoImformado.Properties.Mask.EditMask = "n2";
            this.txtSaldoImformado.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSaldoImformado.Size = new System.Drawing.Size(501, 22);
            this.txtSaldoImformado.TabIndex = 161;
            this.txtSaldoImformado.TextChanged += new System.EventHandler(this.txtSaldoCurrent_TextChanged);
            this.txtSaldoImformado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaldoImformado_KeyPress);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.EditValue = "";
            this.richTextBox1.Location = new System.Drawing.Point(15, 263);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Properties.Appearance.Options.UseFont = true;
            this.richTextBox1.Size = new System.Drawing.Size(501, 148);
            this.richTextBox1.TabIndex = 163;
            this.richTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaldoImformado_KeyPress);
            // 
            // txtSaldoTotalCaixa
            // 
            this.txtSaldoTotalCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSaldoTotalCaixa.EditValue = "0,00";
            this.txtSaldoTotalCaixa.Enabled = false;
            this.txtSaldoTotalCaixa.Location = new System.Drawing.Point(15, 97);
            this.txtSaldoTotalCaixa.Margin = new System.Windows.Forms.Padding(4);
            this.txtSaldoTotalCaixa.Name = "txtSaldoTotalCaixa";
            this.txtSaldoTotalCaixa.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoTotalCaixa.Properties.Appearance.Options.UseFont = true;
            this.txtSaldoTotalCaixa.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSaldoTotalCaixa.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtSaldoTotalCaixa.Properties.Mask.EditMask = "n2";
            this.txtSaldoTotalCaixa.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSaldoTotalCaixa.Size = new System.Drawing.Size(501, 22);
            this.txtSaldoTotalCaixa.TabIndex = 165;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label4.Location = new System.Drawing.Point(15, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 14);
            this.label4.TabIndex = 164;
            this.label4.Text = "Saldo do Caixa:";
            // 
            // FormFecharTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 428);
            this.Controls.Add(this.txtSaldoTotalCaixa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSaldoImformado);
            this.Controls.Add(this.txtSaldoQuebra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormFecharTurno";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fechar Turno";
            this.Load += new System.EventHandler(this.FormFecharTurno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldoQuebra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldoImformado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.richTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldoTotalCaixa.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnFechar;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.BarButtonItem btnFecharTurno;
        private DevExpress.XtraBars.BarButtonItem btnAbrirTurno;
        private DevExpress.XtraBars.BarButtonItem btnImprimir;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraBars.BarButtonItem btnVoltar;
        private DevExpress.XtraEditors.TextEdit txtSaldoQuebra;
        private DevExpress.XtraEditors.TextEdit txtSaldoImformado;
        private DevExpress.XtraEditors.MemoEdit richTextBox1;
        private DevExpress.XtraEditors.TextEdit txtSaldoTotalCaixa;
        private System.Windows.Forms.Label label4;
    }
}