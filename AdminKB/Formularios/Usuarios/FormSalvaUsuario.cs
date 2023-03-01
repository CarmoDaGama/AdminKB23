using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using AdminKB.Aplicacoes;
using Dominio.Enumerados;
using AdminKB.Formularios.Geral;
using Dominio.Modelos;
using Dominio.Utilitarios;
using System;

namespace AdminKB.Formularios.Usuarios
{
    public partial class FormSalvaUsuario : XtraForm
    {
        private UsuarioApp _UsuarioApp;

        private bool Salvo { get; set; } = false;
        private Usuario UsuarioSalvar { get;  set; }
        private Access AcessoPadrao { get;  set; }
        private OperacoesDeFormulario Operacao { get; set; }

        public FormSalvaUsuario()
        {
            InitializeComponent();
            IniciarAplicacoes();
        }

        private void IniciarAplicacoes()
        {
            _UsuarioApp = new UsuarioApp();
        }

        public bool ActualizarUsuario(int usuarioIdSelecionada)
        {
            Operacao = OperacoesDeFormulario.ACTUALIZAR;
            UsuarioSalvar = _UsuarioApp.RetornaUsuarioPorId(usuarioIdSelecionada);
            PopularUsuarioNosControles();
            if (UsuarioSalvar.Nome == Globais.NomePrimeiroAdmin)
            {
                txtNomeUsuario.ReadOnly = true;
            }
            ShowDialog();
            return Salvo;
        }

        private void PopularUsuarioNosControles()
        {
            if (!(UsuarioSalvar is null))
            {
                txtNomeUsuario.Text = UsuarioSalvar.Nome;
                txtAcesso.Text = UsuarioSalvar.Acesso.Nome;
                txtSenha.Text = Criptografia.DecryptOfMD5(UsuarioSalvar.PalavraPasse);
                txtCodigoDeAcesso.Text = Criptografia.DecryptOfMD5(UsuarioSalvar.CodigoDeAcesso);
            }
        }
        private void PopularControlesNoUsuario()
        {
            if ((UsuarioSalvar is null))
            {
                UsuarioSalvar = new Usuario();
            }
            UsuarioSalvar.Nome = txtNomeUsuario.Text;
            if (UsuarioSalvar.Acesso is null)
            {
                UsuarioSalvar.Acesso = AcessoPadrao;
                UsuarioSalvar.AcessoId = AcessoPadrao.AcessoId;
            }
            //UsuarioSalvar.Acesso.Nome = txtAcesso.Text;
            if (Operacao == OperacoesDeFormulario.ADICIONAR)
            {
                UsuarioSalvar.PalavraPasse = Criptografia.EncryptInMD5(txtSenha.Text);
                //UsuarioSalvar.Modificado = false;
            }
            else
            {
                UsuarioSalvar.PalavraPasse = Criptografia.EncryptInMD5(txtSenhaSeguinte.Text);
                //UsuarioSalvar.Modificado = true;
            }
        }

        public bool AdicionarUsuario()
        {
            Operacao = OperacoesDeFormulario.ADICIONAR;
            AcessoPadrao = new AcessoApp().BuscaTipoEntidadePadrao();
            txtAcesso.Text = AcessoPadrao.Nome;
            lblSenha.Text = "Senha";
            lblSenhaSeguinte.Text = "Confirmar";
            ShowDialog();
            return Salvo;
        }

        private void btnSalvarUsuario_ItemClick(object sender, ItemClickEventArgs e)
        {
            SalvarUsuario();
        }

        private void SalvarUsuario()
        {
            if (PodeSalvarUsuario())
            {
                IniciarAplicacoes();
                PopularControlesNoUsuario();
                UsuarioSalvar.Acesso = null;
                if (Operacao == OperacoesDeFormulario.ADICIONAR)
                {
                    _UsuarioApp.Adicionar(UsuarioSalvar);
                }
                else
                {
                    _UsuarioApp.Actualizar(UsuarioSalvar);
                }
                Salvo = true;
                Close();
            }
        }

        private bool PodeSalvarUsuario()
        {
            if (string.IsNullOrEmpty(txtAcesso.Text))
            {
                Mensagem.Alerta("Selecione uma permissão de acesso!");
                return false;
            }
            if (string.IsNullOrEmpty(txtNomeUsuario.Text))
            {
                Mensagem.Alerta("Preencha o campo nome!");
                return false;
            }
            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                Mensagem.Alerta("Preencha a sua senha!");
                return false;
            }
            
            if (Operacao == OperacoesDeFormulario.ACTUALIZAR)
            {
                if (!_UsuarioApp.VerificarPasse(txtSenha.Text))
                {
                    Mensagem.Alerta("senha Actual está errada!");
                    return false;
                }
                if (txtSenhaSeguinte.Text.Length < 6)
                {
                    Mensagem.Alerta("O número de caracter da senha\n têm de ser maior ou igual a seis!");
                    return false;
                }
            }
            else
            {
                if (_UsuarioApp.NomeUsuarioJaExiste(txtNomeUsuario.Text))
                {
                    Mensagem.Alerta("Já existe um usuário com este nome!");
                    return false;
                }
                if (txtNomeUsuario.Text == Globais.NomePrimeiroAdmin)
                {
                    Mensagem.Alerta("Este nome não é permitido!");
                    return false;
                }
                if (txtSenha.Text != txtSenhaSeguinte.Text)
                {
                    Mensagem.Alerta("A senha nova é diferente da senha de confirmação!");
                    return false;
                }
                if (txtSenha.Text.Length < 6)
                {
                    Mensagem.Alerta("O número de caracter da senha\n têm de ser maior ou igual a seis!");
                    return false;
                }
            }
            
            return true;
        }

        private void txtAcesso_Click(object sender, EventArgs e)
        {
            var acesso = new FormListagemTabela<Access>().BuscaRegistroSelecionado();
            if (!(acesso is null))
            {
                if (UsuarioSalvar is null)
                {
                    UsuarioSalvar = new Usuario();
                }
                UsuarioSalvar.Acesso = acesso;
                UsuarioSalvar.AcessoId = acesso.AcessoId;
                txtAcesso.Text = acesso.Nome;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSenhaSeguinte_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                SalvarUsuario();
            }
        }
    }
}