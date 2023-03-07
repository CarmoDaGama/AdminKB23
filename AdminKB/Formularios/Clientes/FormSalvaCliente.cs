using DevExpress.XtraBars;
using AdminKB.Dominio.Enumerados;
using AdminKB.Dominio.Modelos;
using AdminKB.Dominio.Utilitarios;
using AdminKB.Aplicacoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminKB.Formularios.Clientes
{
    public partial class FormSalvaCliente : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private ClienteApp _ClienteApp;
        private OperacoesDeFormulario Operacao { get; set; }
        private Cliente ClienteSalvar { get; set; }
        private bool Salvo { get; set; }

        public FormSalvaCliente()
        {
            InitializeComponent();
            IniciarAplicacoes();
        }
        public bool Adicionar()
        {
            Operacao = OperacoesDeFormulario.ADICIONAR;
            ShowDialog();
            return Salvo;
        }
        public bool Actualizar(int formaPagamentoId)
        {
            Operacao = OperacoesDeFormulario.ACTUALIZAR;
            ClienteSalvar = _ClienteApp.BuscaPorId(formaPagamentoId);
            ShowDialog();
            return Salvo;
        }
        private void IniciarAplicacoes()
        {
            _ClienteApp = new ClienteApp();
        }

        private void btnSalvarCliente_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (PodeSalvarCliente())
            {
                PopularControlesNosCliente();
                if (Operacao == OperacoesDeFormulario.ADICIONAR)
                {
                    _ClienteApp.Adicionar(ClienteSalvar);
                }
                else
                {
                    _ClienteApp.Actualizar(ClienteSalvar);
                }
                Salvo = true;
                Close();
            }
        }

        private bool PodeSalvarCliente()
        {
            if (string.IsNullOrEmpty(txtNif.Text))
            {
                Mensagem.Alerta("Preencha o campo Nif!");
                return false;
            }
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                Mensagem.Alerta("Preencha o campo Nome!");
                return false;
            }
            if (string.IsNullOrEmpty(txtTel.Text))
            {
                Mensagem.Alerta("Preencha o campo Tel!");
                return false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                Mensagem.Alerta("Preencha o campo E-mail!");
                return false;
            }
            if (string.IsNullOrEmpty(txtDebitoLimite.Text))
            {
                Mensagem.Alerta("Preencha o campo limite!");
                return false;
            }
            return true;
        }

        private void FormSalvaFormaPagamento_Load(object sender, EventArgs e)
        {
            PopularClienteNosControles();
        }

        private void PopularClienteNosControles()
        {
            if (!(ClienteSalvar is null))
            {
                txtNome.Text = ClienteSalvar.Nome;
                txtNif.Text = ClienteSalvar.Nif;
                txtTel.Text = ClienteSalvar.Telefone;
                txtEmail.Text = ClienteSalvar.Email;
                txtEndereco.Text = ClienteSalvar.Endereco;
                txtDebitoLimite.Text = ClienteSalvar.DebitoLimite.ToString("N2");
            }
        }
        private void PopularControlesNosCliente()
        {
            if ((ClienteSalvar is null))
            {
                ClienteSalvar = new Cliente();
            }
            ClienteSalvar.Nome = txtNome.Text;
            ClienteSalvar.Nif = txtNif.Text;
            ClienteSalvar.Telefone = txtTel.Text;
            ClienteSalvar.Email = txtEmail.Text;
            ClienteSalvar.Endereco = txtEndereco.Text;
            ClienteSalvar.DebitoLimite = Convert.ToDecimal(txtDebitoLimite.Text);

        }
    }
}