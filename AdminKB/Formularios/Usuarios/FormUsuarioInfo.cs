using AdminKB.Dominio.Utilitarios;
using System;

namespace AdminKB.Formularios.Usuarios
{
    public partial class FormUsuarioInfo : DevExpress.XtraEditors.XtraForm
    {
        public FormUsuarioInfo()
        {
            InitializeComponent();
        }

        private void FormUsuarioInfo_Load(object sender, EventArgs e)
        {
            txtNome.Text = Globais.UsuarioActual.Nome.ToUpper();
            txtPermissaAcesso.Text = Globais.UsuarioActual.Acesso.Nome.ToUpper();
            txtCodigoAcesso.Text = Criptografia.DecryptOfMD5(Globais.UsuarioActual.CodigoDeAcesso);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}