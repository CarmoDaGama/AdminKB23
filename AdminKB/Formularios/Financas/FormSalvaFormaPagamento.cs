using DevExpress.XtraBars;
using AdminKB.Aplicacoes;
using Dominio.Enumerados;
using Dominio.Modelos;
using Dominio.Utilitarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminKB.Formularios.Financas
{
    public partial class FormSalvaFormaPagamento : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private FormaPagamentoApp _FormasPagamentoApp;
        private OperacoesDeFormulario Operacao { get; set; }
        private FormaPagamento FormaSalvar { get; set; }
        private bool Salvo { get; set; }

        public FormSalvaFormaPagamento()
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
            FormaSalvar = _FormasPagamentoApp.BuscaPorId(formaPagamentoId);
            ShowDialog();
            return Salvo;
        }
        private void IniciarAplicacoes()
        {
            _FormasPagamentoApp = new FormaPagamentoApp();
        }

        private void btnSalvarForma_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (PodeSalvarForma())
            {
                PopularControlesNosForma();
                if (Operacao == OperacoesDeFormulario.ADICIONAR)
                {
                    _FormasPagamentoApp.Adicionar(FormaSalvar);
                }
                else
                {
                    _FormasPagamentoApp.Actualizar(FormaSalvar);
                }
                Salvo = true;
                Close();
            }
        }

        private bool PodeSalvarForma()
        {
            if (string.IsNullOrEmpty(txtBanco.Text))
            {
                Mensagem.Alerta("Preencha o campo Banco!");
                return false;
            }
            if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                Mensagem.Alerta("Preencha o campo Descrição!");
                return false;
            }
            if (string.IsNullOrEmpty(txtIBAN.Text))
            {
                Mensagem.Alerta("Preencha o campo IBAN!");
                return false;
            }
            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                Mensagem.Alerta("Preencha o campo Número!");
                return false;
            }
            return true;
        }

        private void FormSalvaFormaPagamento_Load(object sender, EventArgs e)
        {
            PopularFormaNosControles();
        }

        private void PopularFormaNosControles()
        {
            if (!(FormaSalvar is null))
            {
                txtDescricao.Text = FormaSalvar.Descricao;
                txtBanco.Text = FormaSalvar.Banco;
                txtIBAN.Text = FormaSalvar.IBAN;
                txtNumero.Text = FormaSalvar.Numero;
            }
        }
        private void PopularControlesNosForma()
        {
            if ((FormaSalvar is null))
            {
                FormaSalvar = new FormaPagamento();
            }
            FormaSalvar.Descricao = txtDescricao.Text;
            FormaSalvar.Banco = txtBanco.Text;
            FormaSalvar.IBAN = txtIBAN.Text;
            FormaSalvar.Numero = txtNumero.Text;
            
        }
    }
}