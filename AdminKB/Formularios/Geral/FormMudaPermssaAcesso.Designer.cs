
namespace AdminKB.Formularios.Geral
{
    partial class FormMudaPermssaAcesso
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
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.txtCodigoAcesso = new DevExpress.XtraEditors.TextEdit();
            this.btnFechar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoAcesso.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(64, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "CÓDIGO DE ACESSO";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "PERMISSÃO DE ACESSO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::AdminKB.Properties.Resources.Padlock;
            this.pictureEdit1.Location = new System.Drawing.Point(97, 35);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(100, 96);
            this.pictureEdit1.TabIndex = 18;
            // 
            // txtCodigoAcesso
            // 
            this.txtCodigoAcesso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigoAcesso.Location = new System.Drawing.Point(10, 198);
            this.txtCodigoAcesso.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoAcesso.Name = "txtCodigoAcesso";
            this.txtCodigoAcesso.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.txtCodigoAcesso.Properties.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.txtCodigoAcesso.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtCodigoAcesso.Properties.Appearance.Options.UseBackColor = true;
            this.txtCodigoAcesso.Properties.Appearance.Options.UseForeColor = true;
            this.txtCodigoAcesso.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCodigoAcesso.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtCodigoAcesso.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.txtCodigoAcesso.Properties.ContextImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.txtCodigoAcesso.Properties.UseSystemPasswordChar = true;
            this.txtCodigoAcesso.Size = new System.Drawing.Size(281, 24);
            this.txtCodigoAcesso.TabIndex = 8;
            this.txtCodigoAcesso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoAcesso_KeyPress);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.btnFechar.ImageOptions.SvgImage = global::AdminKB.Properties.Resources.Close;
            this.btnFechar.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnFechar.Location = new System.Drawing.Point(273, 0);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnFechar.Size = new System.Drawing.Size(24, 25);
            this.btnFechar.TabIndex = 19;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FormMudaPermssaAcesso
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 271);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodigoAcesso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMudaPermssaAcesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMudaPermssaAcesso";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoAcesso.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtCodigoAcesso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton btnFechar;
    }
}