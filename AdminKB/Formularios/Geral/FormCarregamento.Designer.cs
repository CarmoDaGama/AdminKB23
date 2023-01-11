
namespace AdminKB.Formularios.Geral
{
    partial class FormCarregamento
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.btnNomeEmpresa = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // progressPanel1
            // 
            this.progressPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(184)))), ((int)(((byte)(254)))));
            this.progressPanel1.Appearance.Options.UseBackColor = true;
            this.progressPanel1.Appearance.Options.UseForeColor = true;
            this.progressPanel1.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(202)))), ((int)(((byte)(224)))));
            this.progressPanel1.AppearanceCaption.Options.UseForeColor = true;
            this.progressPanel1.AppearanceCaption.Options.UseTextOptions = true;
            this.progressPanel1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.progressPanel1.AppearanceDescription.ForeColor = System.Drawing.Color.LightGray;
            this.progressPanel1.AppearanceDescription.Options.UseForeColor = true;
            this.progressPanel1.AppearanceDescription.Options.UseTextOptions = true;
            this.progressPanel1.AppearanceDescription.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.progressPanel1.Caption = "Aguarde por favor";
            this.progressPanel1.Description = "Carregando...";
            this.progressPanel1.FrameCount = 28000;
            this.progressPanel1.FrameInterval = 650;
            this.progressPanel1.LineAnimationElementType = DevExpress.Utils.Animation.LineAnimationElementType.Triangle;
            this.progressPanel1.Location = new System.Drawing.Point(7, 79);
            this.progressPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.progressPanel1.Name = "progressPanel1";
            this.progressPanel1.Size = new System.Drawing.Size(317, 91);
            this.progressPanel1.TabIndex = 54;
            this.progressPanel1.Text = "progressPanel1";
            this.progressPanel1.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Line;
            // 
            // btnNomeEmpresa
            // 
            this.btnNomeEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNomeEmpresa.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btnNomeEmpresa.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(184)))), ((int)(((byte)(254)))));
            this.btnNomeEmpresa.Appearance.Options.UseFont = true;
            this.btnNomeEmpresa.Appearance.Options.UseForeColor = true;
            this.btnNomeEmpresa.Location = new System.Drawing.Point(207, 221);
            this.btnNomeEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.btnNomeEmpresa.Name = "btnNomeEmpresa";
            this.btnNomeEmpresa.Size = new System.Drawing.Size(118, 13);
            this.btnNomeEmpresa.TabIndex = 56;
            this.btnNomeEmpresa.Text = "KISOFT |  KIVEMBASOFT";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::AdminKB.Properties.Resources.PUBLICIDADE___MARKETING;
            this.pictureEdit1.Location = new System.Drawing.Point(172, 215);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(28, 24);
            this.pictureEdit1.TabIndex = 57;
            // 
            // FormCarregamento
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 245);
            this.ControlBox = false;
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.btnNomeEmpresa);
            this.Controls.Add(this.progressPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCarregamento";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel1;
        private DevExpress.XtraEditors.LabelControl btnNomeEmpresa;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}