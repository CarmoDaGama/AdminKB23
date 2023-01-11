
using System;

namespace AdminKB.Formularios.Impressoes
{
    partial class FormImprimir
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnImprimir = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnVisualizar = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.cboMoeda = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboImpressora = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboFormato = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMoeda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboImpressora.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFormato.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Papel ";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnImprimir.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnImprimir.ImageOptions.SvgImage = global::AdminKB.Properties.Resources.Imprimir;
            this.btnImprimir.ImageOptions.SvgImageSize = new System.Drawing.Size(22, 22);
            this.btnImprimir.Location = new System.Drawing.Point(235, 151);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(56, 53);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.ToolTipTitle = "Imprimir";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnCancelar.ImageOptions.SvgImage = global::AdminKB.Properties.Resources.Cancel;
            this.btnCancelar.ImageOptions.SvgImageSize = new System.Drawing.Size(22, 22);
            this.btnCancelar.Location = new System.Drawing.Point(299, 151);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(56, 53);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.ToolTipTitle = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnVisualizar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnVisualizar.ImageOptions.SvgImage = global::AdminKB.Properties.Resources.Documento;
            this.btnVisualizar.ImageOptions.SvgImageSize = new System.Drawing.Size(22, 22);
            this.btnVisualizar.Location = new System.Drawing.Point(171, 151);
            this.btnVisualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(56, 53);
            this.btnVisualizar.TabIndex = 4;
            this.btnVisualizar.ToolTipTitle = "Visualizar";
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Impressora:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Moeda:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricao.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.lblDescricao.Location = new System.Drawing.Point(12, 7);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(212, 18);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "Documento: Factura Recibo";
            // 
            // cboMoeda
            // 
            this.cboMoeda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMoeda.EditValue = "Kwanza";
            this.cboMoeda.Location = new System.Drawing.Point(98, 117);
            this.cboMoeda.Margin = new System.Windows.Forms.Padding(4);
            this.cboMoeda.Name = "cboMoeda";
            this.cboMoeda.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMoeda.Properties.Appearance.Options.UseFont = true;
            this.cboMoeda.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboMoeda.Properties.Items.AddRange(new object[] {
            "Kwanza",
            "Dolar"});
            this.cboMoeda.Properties.Padding = new System.Windows.Forms.Padding(2);
            this.cboMoeda.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboMoeda.Size = new System.Drawing.Size(405, 26);
            this.cboMoeda.TabIndex = 0;
            this.cboMoeda.SelectedIndexChanged += new System.EventHandler(this.cboMoeda_SelectedIndexChanged);
            // 
            // cboImpressora
            // 
            this.cboImpressora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboImpressora.EditValue = "Impressora Padrão";
            this.cboImpressora.Location = new System.Drawing.Point(98, 77);
            this.cboImpressora.Margin = new System.Windows.Forms.Padding(4);
            this.cboImpressora.Name = "cboImpressora";
            this.cboImpressora.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboImpressora.Properties.Appearance.Options.UseFont = true;
            this.cboImpressora.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboImpressora.Properties.Items.AddRange(new object[] {
            "Papel A4",
            "Ticket"});
            this.cboImpressora.Properties.Padding = new System.Windows.Forms.Padding(2);
            this.cboImpressora.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboImpressora.Size = new System.Drawing.Size(405, 26);
            this.cboImpressora.TabIndex = 0;
            // 
            // cboFormato
            // 
            this.cboFormato.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFormato.EditValue = "Papel A4";
            this.cboFormato.Location = new System.Drawing.Point(98, 36);
            this.cboFormato.Margin = new System.Windows.Forms.Padding(4);
            this.cboFormato.Name = "cboFormato";
            this.cboFormato.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFormato.Properties.Appearance.Options.UseFont = true;
            this.cboFormato.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboFormato.Properties.Items.AddRange(new object[] {
            "Papel A4"});
            this.cboFormato.Properties.Padding = new System.Windows.Forms.Padding(2);
            this.cboFormato.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboFormato.Size = new System.Drawing.Size(405, 26);
            this.cboFormato.TabIndex = 0;
            // 
            // FormImprimir
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 217);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboMoeda);
            this.Controls.Add(this.cboImpressora);
            this.Controls.Add(this.cboFormato);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormImprimir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imprimir ";
            this.Load += new System.EventHandler(this.FormPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cboMoeda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboImpressora.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFormato.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void cboMoeda_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }



        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cboFormato;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnImprimir;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnVisualizar;
        private DevExpress.XtraEditors.ComboBoxEdit cboImpressora;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ComboBoxEdit cboMoeda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDescricao;
    }
}