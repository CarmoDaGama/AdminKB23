using DevExpress.XtraBars;
using AdminKB.Aplicacoes;
using AdminKB.Dominio.Enumerados;
using AdminKB.Formularios.Geral;
using AdminKB.Dominio.Modelos;
using AdminKB.Dominio.Utilitarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminKB.Formularios.Produtos
{
    public partial class FormRetornaNovoProdutoEstoque : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public bool Adicionado { get; set; }
        public OperacoesDeFormulario Operacao { get; set; }
        public FormRetornaNovoProdutoEstoque()
        {
            InitializeComponent();
            InicializaApp();
        }

        private void InicializaApp()
        {
            NovoProdutoEstoque = new ProdutoEstoque();
            NovoProdutoEstoque.Estoque = new EstoqueApp().BuscaTipoEntidadePadrao();
            NovoProdutoEstoque.EstoqueId = NovoProdutoEstoque.Estoque.EstoqueId;
            txtEstoque.Text = NovoProdutoEstoque.Estoque.Nome;
        }

        private ProdutoEstoque NovoProdutoEstoque { get;  set; }

        public ProdutoEstoque BuscaNovoProdutoEstoque()
        {
            ShowDialog();
            return Adicionado? NovoProdutoEstoque : null;
        }
        public ProdutoEstoque ActualizarProdutoEstoque(ProdutoEstoque produtoEstoque)
        {
            Operacao = OperacoesDeFormulario.ACTUALIZAR;
            NovoProdutoEstoque = produtoEstoque;
            txtNumeroSerie.Text = NovoProdutoEstoque.NumeroDeSerie;
            txtEstoque.Text = NovoProdutoEstoque.Estoque.Nome;
            txtQuantidadeMax.Text = NovoProdutoEstoque.QuantidadeMaxima.ToString();
            txtQuantidadeMin.Text = NovoProdutoEstoque.QuantidadeMinima.ToString();
            dateFabricacao.EditValue = NovoProdutoEstoque.DataDeFabricacao;
            dateExpiracao.EditValue = NovoProdutoEstoque.DataDeExpiracao;
            ShowDialog();
            return Adicionado? NovoProdutoEstoque : null;
        }
        private void btnAdicionar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (PodeAdicionar())
            {
                //NovoProdutoEstoque.NumeroDeSerie = txtNumeroSerie.Text;
                NovoProdutoEstoque.DataDeExpiracao = Convert.ToDateTime(dateExpiracao.EditValue);
                NovoProdutoEstoque.DataDeFabricacao = Convert.ToDateTime(dateFabricacao.EditValue);
                NovoProdutoEstoque.QuantidadeMaxima = Convert.ToDecimal(txtQuantidadeMax.Text);
                NovoProdutoEstoque.QuantidadeMinima = Convert.ToDecimal(txtQuantidadeMin.Text);
                NovoProdutoEstoque.UmLote = checkAgruparLote.Checked;
                Adicionado = true;
                Close();
            }
        }

        private bool PodeAdicionar()
        {
            //if (string.IsNullOrEmpty(txtNumeroSerie.Text))
            //{
            //    Mensagem.Alerta("Insira um número de serire para este grupo de produto!");
            //    return false;
            //}
            if (string.IsNullOrEmpty(txtEstoque.Text))
            {
                Mensagem.Alerta("Selecion um estoque para este grupo de produto!");
                return false;
            }
            if (string.IsNullOrEmpty(txtQuantidadeMax.Text))
            {
                Mensagem.Alerta("Insira um quantidade maxima para este grupo de produto!");
                return false;
            }
            if (string.IsNullOrEmpty(txtQuantidadeMin.Text))
            {
                Mensagem.Alerta("Insira um quantidade minima para este grupo de produto!");
                return false;
            }
            if (Convert.ToDecimal(txtQuantidadeMax.Text) <= Convert.ToDecimal(txtQuantidadeMin.Text))
            {
                Mensagem.Alerta("Insira um quantidade minima tem que\n ser menor que a quantidade maxima!");
                return false;
            }
            if (checkAgruparLote.CheckState == CheckState.Checked)
            {
                var dataF = Convert.ToDateTime(dateFabricacao.EditValue);
                var dataExp = Convert.ToDateTime(dateExpiracao.EditValue);
                if ((dataExp - dataF).Days < Globais.DiferencaDeDisEntreDatasValidade)
                {
                    string strDia = " dia!";
                    if (Globais.DiferencaDeDisEntreDatasValidade > 1)
                    {
                        strDia = " dias!";
                    }
                    Mensagem.Alerta("O a diferênça entre a data de fabricação" +
                        "\n deve ser maior ou igual a " + Globais.DiferencaDeDisEntreDatasValidade + strDia);
                    return false;
                }
            }
            //if (_ProdutoEstoqueApp.ExisteLoteDeste(txtNumeroSerie.Text))
            //{
            //    Mensagem.Alerta("Já existe um grupo de produto com este Número de serie!");
            //    return false;
            //}
            return true;
        }

        private void FormRetornaNovoProdutoEstoque_Load(object sender, EventArgs e)
        {
            dateFabricacao.EditValue = DateTime.Now;
            dateExpiracao.EditValue = DateTime.Now.AddDays(30);
            MudarValidade();
        }

        private void txtEstoque_Click(object sender, EventArgs e)
        {

            NovoProdutoEstoque.Estoque = new FormListagemTabela<Estoque>().BuscaRegistroSelecionado();
            if (!Util.ObjectoNulo(NovoProdutoEstoque.Estoque))
            {
                NovoProdutoEstoque.EstoqueId = NovoProdutoEstoque.Estoque.EstoqueId;
                txtEstoque.Text = NovoProdutoEstoque.Estoque.Nome;
            }
        }

        private void checkAgruparLote_CheckedChanged(object sender, EventArgs e)
        {
            MudarValidade();
        }

        private void MudarValidade()
        {
            if (checkAgruparLote.CheckState == CheckState.Checked)
            {
                dateExpiracao.Enabled = true;
                dateFabricacao.Enabled = true;
            }
            else
            {
                dateExpiracao.Enabled = false;
                dateFabricacao.Enabled = false;
            }
        }
    }
}