using DevExpress.XtraEditors;
using AdminKB.Dominio.Modelos;
using AdminKB.Dominio.Utilitarios;
using AdminKB.Aplicacoes;

namespace AdminKB.Formularios.Geral
{
    public partial class FormMudaPermssaAcesso : XtraForm
    {
        public FormMudaPermssaAcesso()
        {
            InitializeComponent();
        }

        private Usuario UsuarioAcessado { get;  set; }

        public ResultadoForm<Usuario> MostrarFormVerificacaoDeAcesso()
        {
            ShowDialog();
            return new ResultadoForm<Usuario>()
            {
                Resultado = DialogResult,
                Valor = UsuarioAcessado
            };
        }

        private void txtCodigoAcesso_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                var _usuarioApp = new UsuarioApp();
                if (_usuarioApp.CodigoAcessoJaExiste(txtCodigoAcesso.Text))
                {
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                    UsuarioAcessado = _usuarioApp.RetornaUsuarioPorCodigoAcesso(txtCodigoAcesso.Text);
                    Close();
                }else
                {
                    Mensagem.Alerta("Códio de acesso incorrecto!");
                    DialogResult = System.Windows.Forms.DialogResult.None;
                }
            }
        }

        private void btnFechar_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}