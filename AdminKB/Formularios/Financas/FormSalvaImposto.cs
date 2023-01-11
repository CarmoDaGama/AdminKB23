using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Dominio.Enumerados;
using Dominio.Modelos;
using Dominio.Utilitarios;
using AdminKB.Aplicacoes;
using AdminKB.Formularios.Geral;
using System;

namespace AdminKB.Formularios.Financas
{
    public partial class FormSalvaImposto : XtraForm
    {
        private ImpostoApp _ImpostoApp;

        private bool Salvo { get; set; } = false;
        private Imposto ImpostoSalvar { get; set; }
        private TipoImposto TipoPadrao { get; set; }
        private OperacoesDeFormulario Operacao { get; set; }

        public FormSalvaImposto()
        {
            InitializeComponent();
            IniciarAplicacoes();
        }

        private void IniciarAplicacoes()
        {
            _ImpostoApp = new ImpostoApp();
        }

        public bool ActualizarImposto(int impostoIdSelecionada)
        {
            Operacao = OperacoesDeFormulario.ACTUALIZAR;
            ImpostoSalvar = _ImpostoApp.RetornaImpostoPorId(impostoIdSelecionada);
            PopularImpostoNosControles();
            ShowDialog();
            return Salvo;
        }

        private void PopularImpostoNosControles()
        {
            if (!(ImpostoSalvar is null))
            {
                txtNomeImposto.Text = ImpostoSalvar.Nome;
                txtAcesso.Text = ImpostoSalvar.TipoImposto.Descricao;
                txtSigla.Text = ImpostoSalvar.Sigla;
                txtImpostoId.Text = ImpostoSalvar.ImpostoId.ToString();
                txtPercentagem.Text = ImpostoSalvar.Percentagem.ToString();
            }
        }
        private void PopularControlesNoImposto()
        {
            if ((ImpostoSalvar is null))
            {
                ImpostoSalvar = new Imposto();
            }
            ImpostoSalvar.Nome = txtNomeImposto.Text;
            if (ImpostoSalvar.TipoImposto is null)
            {
                ImpostoSalvar.TipoImposto = TipoPadrao;
                ImpostoSalvar.TipoImpostoId = TipoPadrao.TipoImpostoId;
            }
            ImpostoSalvar.Sigla = txtSigla.Text;
            ImpostoSalvar.Percentagem = RetornaPercentagem();
            //ImpostoSalvar.Acesso.Nome = txtAcesso.Text;
            //if (Operacao == OperacoesDeFormulario.ADICIONAR)
            //{
            //    ImpostoSalvar.PalavraPasse = Criptografia.EncryptInMD5(txtSigla.Text);
            //    ImpostoSalvar.Modificado = false;
            //}
            //else
            //{
            //    ImpostoSalvar.PalavraPasse = Criptografia.EncryptInMD5(txtPercentagem.Text);
            //    ImpostoSalvar.Modificado = true;
            //}
        }

        private decimal RetornaPercentagem()
        {
            var percentagem = Convert.ToDecimal(txtPercentagem.Text);
            if (percentagem > 100)
            {
                return 100;
            }
            if (percentagem < 0)
            {
                return 0;
            }
            return percentagem;
        }

        public bool AdicionarImposto()
        {
            Operacao = OperacoesDeFormulario.ADICIONAR;
            TipoPadrao = new TipoImpostoApp().BuscaTipoEntidadePadrao();
            txtAcesso.Text = TipoPadrao.Descricao;
            lblSenha.Text = "Senha";
            lblSenhaSeguinte.Text = "Confirmar";
            ShowDialog();
            return Salvo;
        }

        private void btnSalvarImposto_ItemClick(object sender, ItemClickEventArgs e)
        {
            SalvarImposto();
        }

        private void SalvarImposto()
        {
            if (PodeSalvarImposto())
            {
                IniciarAplicacoes();
                PopularControlesNoImposto();
                ImpostoSalvar.TipoImposto = null;
                if (Operacao == OperacoesDeFormulario.ADICIONAR)
                {
                    _ImpostoApp.Adicionar(ImpostoSalvar);
                }
                else
                {
                    _ImpostoApp.Actualizar(ImpostoSalvar);
                }
                Salvo = true;
                Close();
            }
        }

        private bool PodeSalvarImposto()
        {
            if (string.IsNullOrEmpty(txtAcesso.Text))
            {
                Mensagem.Alerta("Selecione uma permissão de acesso!");
                return false;
            }
            if (string.IsNullOrEmpty(txtNomeImposto.Text))
            {
                Mensagem.Alerta("Preencha o campo nome!");
                return false;
            }
            if (string.IsNullOrEmpty(txtSigla.Text))
            {
                Mensagem.Alerta("Preencha a sua senha!");
                return false;
            }

            return true;
        }

        private void txtAcesso_Click(object sender, EventArgs e)
        {
            var tipo = new FormListagemTabela<TipoImposto>().BuscaRegistroSelecionado();
            if (!(tipo is null))
            {
                if (ImpostoSalvar is null)
                {
                    ImpostoSalvar = new Imposto();
                }
                ImpostoSalvar.TipoImposto = tipo;
                ImpostoSalvar.TipoImpostoId = tipo.TipoImpostoId;
                txtAcesso.Text = tipo.Descricao;
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
                SalvarImposto();
            }
        }
    }
}