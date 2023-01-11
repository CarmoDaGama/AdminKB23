
namespace AdminKB.Formularios.Geral
{
    partial class FormNumero { 
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
            this.pnlText = new System.Windows.Forms.Panel();
            this.txtValor = new DevExpress.XtraEditors.TextEdit();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pnlButtons3 = new System.Windows.Forms.Panel();
            this.btnDois = new DevExpress.XtraEditors.SimpleButton();
            this.btnTres = new DevExpress.XtraEditors.SimpleButton();
            this.btnUm = new DevExpress.XtraEditors.SimpleButton();
            this.pnlButtons2 = new System.Windows.Forms.Panel();
            this.btnCinco = new DevExpress.XtraEditors.SimpleButton();
            this.btnSeis = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuatro = new DevExpress.XtraEditors.SimpleButton();
            this.pnlButtons1 = new System.Windows.Forms.Panel();
            this.btnOito = new DevExpress.XtraEditors.SimpleButton();
            this.btnNove = new DevExpress.XtraEditors.SimpleButton();
            this.btnSete = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVirgula = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnZero = new DevExpress.XtraEditors.SimpleButton();
            this.pnlText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.pnlButtons3.SuspendLayout();
            this.pnlButtons2.SuspendLayout();
            this.pnlButtons1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlText
            // 
            this.pnlText.Controls.Add(this.txtValor);
            this.pnlText.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlText.Location = new System.Drawing.Point(0, 0);
            this.pnlText.Margin = new System.Windows.Forms.Padding(4);
            this.pnlText.Name = "pnlText";
            this.pnlText.Size = new System.Drawing.Size(343, 44);
            this.pnlText.TabIndex = 0;
            // 
            // txtValor
            // 
            this.txtValor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValor.Location = new System.Drawing.Point(0, 2);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.Name = "txtValor";
            this.txtValor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F);
            this.txtValor.Properties.Appearance.Options.UseFont = true;
            this.txtValor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtValor.Properties.EditFormat.FormatString = "N2";
            this.txtValor.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtValor.Properties.Mask.EditMask = "n2";
            this.txtValor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtValor.Properties.MaxLength = 9;
            this.txtValor.Size = new System.Drawing.Size(343, 40);
            this.txtValor.TabIndex = 0;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.panel1);
            this.pnlButtons.Controls.Add(this.pnlButtons3);
            this.pnlButtons.Controls.Add(this.pnlButtons2);
            this.pnlButtons.Controls.Add(this.pnlButtons1);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtons.Location = new System.Drawing.Point(0, 44);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(4);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(343, 184);
            this.pnlButtons.TabIndex = 1;
            // 
            // pnlButtons3
            // 
            this.pnlButtons3.Controls.Add(this.btnDois);
            this.pnlButtons3.Controls.Add(this.btnTres);
            this.pnlButtons3.Controls.Add(this.btnUm);
            this.pnlButtons3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtons3.Location = new System.Drawing.Point(0, 92);
            this.pnlButtons3.Margin = new System.Windows.Forms.Padding(4);
            this.pnlButtons3.Name = "pnlButtons3";
            this.pnlButtons3.Size = new System.Drawing.Size(343, 46);
            this.pnlButtons3.TabIndex = 2;
            // 
            // btnDois
            // 
            this.btnDois.Appearance.Font = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnDois.Appearance.Options.UseFont = true;
            this.btnDois.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDois.Location = new System.Drawing.Point(113, 0);
            this.btnDois.Margin = new System.Windows.Forms.Padding(4);
            this.btnDois.Name = "btnDois";
            this.btnDois.Size = new System.Drawing.Size(115, 46);
            this.btnDois.TabIndex = 5;
            this.btnDois.Text = "2";
            this.btnDois.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnTres
            // 
            this.btnTres.Appearance.Font = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnTres.Appearance.Options.UseFont = true;
            this.btnTres.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTres.Location = new System.Drawing.Point(228, 0);
            this.btnTres.Margin = new System.Windows.Forms.Padding(4);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(115, 46);
            this.btnTres.TabIndex = 4;
            this.btnTres.Text = "3";
            this.btnTres.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnUm
            // 
            this.btnUm.Appearance.Font = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnUm.Appearance.Options.UseFont = true;
            this.btnUm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUm.Location = new System.Drawing.Point(0, 0);
            this.btnUm.Margin = new System.Windows.Forms.Padding(4);
            this.btnUm.Name = "btnUm";
            this.btnUm.Size = new System.Drawing.Size(115, 46);
            this.btnUm.TabIndex = 3;
            this.btnUm.Text = "1";
            this.btnUm.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // pnlButtons2
            // 
            this.pnlButtons2.Controls.Add(this.btnCinco);
            this.pnlButtons2.Controls.Add(this.btnSeis);
            this.pnlButtons2.Controls.Add(this.btnQuatro);
            this.pnlButtons2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtons2.Location = new System.Drawing.Point(0, 46);
            this.pnlButtons2.Margin = new System.Windows.Forms.Padding(4);
            this.pnlButtons2.Name = "pnlButtons2";
            this.pnlButtons2.Size = new System.Drawing.Size(343, 46);
            this.pnlButtons2.TabIndex = 1;
            // 
            // btnCinco
            // 
            this.btnCinco.Appearance.Font = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnCinco.Appearance.Options.UseFont = true;
            this.btnCinco.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCinco.Location = new System.Drawing.Point(113, 0);
            this.btnCinco.Margin = new System.Windows.Forms.Padding(4);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(115, 46);
            this.btnCinco.TabIndex = 5;
            this.btnCinco.Text = "5";
            this.btnCinco.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.Appearance.Font = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnSeis.Appearance.Options.UseFont = true;
            this.btnSeis.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSeis.Location = new System.Drawing.Point(228, 0);
            this.btnSeis.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(115, 46);
            this.btnSeis.TabIndex = 4;
            this.btnSeis.Text = "6";
            this.btnSeis.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnQuatro
            // 
            this.btnQuatro.Appearance.Font = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnQuatro.Appearance.Options.UseFont = true;
            this.btnQuatro.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnQuatro.Location = new System.Drawing.Point(0, 0);
            this.btnQuatro.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuatro.Name = "btnQuatro";
            this.btnQuatro.Size = new System.Drawing.Size(115, 46);
            this.btnQuatro.TabIndex = 3;
            this.btnQuatro.Text = "4";
            this.btnQuatro.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // pnlButtons1
            // 
            this.pnlButtons1.Controls.Add(this.btnOito);
            this.pnlButtons1.Controls.Add(this.btnNove);
            this.pnlButtons1.Controls.Add(this.btnSete);
            this.pnlButtons1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtons1.Location = new System.Drawing.Point(0, 0);
            this.pnlButtons1.Margin = new System.Windows.Forms.Padding(4);
            this.pnlButtons1.Name = "pnlButtons1";
            this.pnlButtons1.Size = new System.Drawing.Size(343, 46);
            this.pnlButtons1.TabIndex = 0;
            // 
            // btnOito
            // 
            this.btnOito.Appearance.Font = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnOito.Appearance.Options.UseFont = true;
            this.btnOito.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOito.Location = new System.Drawing.Point(113, 0);
            this.btnOito.Margin = new System.Windows.Forms.Padding(4);
            this.btnOito.Name = "btnOito";
            this.btnOito.Size = new System.Drawing.Size(115, 46);
            this.btnOito.TabIndex = 2;
            this.btnOito.Text = "8";
            this.btnOito.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnNove
            // 
            this.btnNove.Appearance.Font = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnNove.Appearance.Options.UseFont = true;
            this.btnNove.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNove.Location = new System.Drawing.Point(228, 0);
            this.btnNove.Margin = new System.Windows.Forms.Padding(4);
            this.btnNove.Name = "btnNove";
            this.btnNove.Size = new System.Drawing.Size(115, 46);
            this.btnNove.TabIndex = 1;
            this.btnNove.Text = "9";
            this.btnNove.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnSete
            // 
            this.btnSete.Appearance.Font = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnSete.Appearance.Options.UseFont = true;
            this.btnSete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSete.Location = new System.Drawing.Point(0, 0);
            this.btnSete.Margin = new System.Windows.Forms.Padding(4);
            this.btnSete.Name = "btnSete";
            this.btnSete.Size = new System.Drawing.Size(115, 46);
            this.btnSete.TabIndex = 0;
            this.btnSete.Text = "7";
            this.btnSete.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnVirgula);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btnZero);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 138);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 46);
            this.panel1.TabIndex = 3;
            // 
            // btnVirgula
            // 
            this.btnVirgula.Appearance.Font = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnVirgula.Appearance.Options.UseFont = true;
            this.btnVirgula.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnVirgula.Location = new System.Drawing.Point(113, 0);
            this.btnVirgula.Margin = new System.Windows.Forms.Padding(4);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(115, 46);
            this.btnVirgula.TabIndex = 5;
            this.btnVirgula.Text = ",";
            this.btnVirgula.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnOK
            // 
            this.btnOK.Appearance.Font = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOK.Location = new System.Drawing.Point(228, 0);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(115, 46);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnZero
            // 
            this.btnZero.Appearance.Font = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnZero.Appearance.Options.UseFont = true;
            this.btnZero.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnZero.Location = new System.Drawing.Point(0, 0);
            this.btnZero.Margin = new System.Windows.Forms.Padding(4);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(115, 46);
            this.btnZero.TabIndex = 0;
            this.btnZero.Text = "1";
            this.btnZero.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // FormNumero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 228);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormNumero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Valor";
            this.Load += new System.EventHandler(this.FormNumero_Load);
            this.pnlText.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons3.ResumeLayout(false);
            this.pnlButtons2.ResumeLayout(false);
            this.pnlButtons1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlText;
        private System.Windows.Forms.Panel pnlButtons;
        private DevExpress.XtraEditors.TextEdit txtValor;
        private System.Windows.Forms.Panel pnlButtons3;
        private DevExpress.XtraEditors.SimpleButton btnDois;
        private DevExpress.XtraEditors.SimpleButton btnTres;
        private DevExpress.XtraEditors.SimpleButton btnUm;
        private System.Windows.Forms.Panel pnlButtons2;
        private DevExpress.XtraEditors.SimpleButton btnCinco;
        private DevExpress.XtraEditors.SimpleButton btnSeis;
        private DevExpress.XtraEditors.SimpleButton btnQuatro;
        private System.Windows.Forms.Panel pnlButtons1;
        private DevExpress.XtraEditors.SimpleButton btnOito;
        private DevExpress.XtraEditors.SimpleButton btnNove;
        private DevExpress.XtraEditors.SimpleButton btnSete;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnVirgula;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnZero;
    }
}