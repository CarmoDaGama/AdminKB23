using DevExpress.XtraBars;
using AdminKB.Aplicacoes;
using AdminKB.Formularios.Geral;
using AdminKB.Dominio.Modelos;
using AdminKB.Dominio.Modelos.ModulosVer;
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
    public partial class FormAdicionarProdutoComponente : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private ProdutoComposicaoVer ProdutoCompDesteForm { get; set; }
        public FormAdicionarProdutoComponente()
        {
            InitializeComponent();
            DialogResult = DialogResult.None;
            InicializaAplicacoes();
        }

        private void InicializaAplicacoes()
        {
            //_ProdutoComponenteApp = new ProdutoComponenteApp();
            ProdutoCompDesteForm = new ProdutoComposicaoVer();
        }
        public ProdutoComposicaoVer Adicionar()
        {
            
            ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                return ProdutoCompDesteForm;
            }
            return null;
        }
        public ProdutoComposicaoVer Actualizar(ProdutoComposicaoVer produtoComponente)
        {
            ProdutoCompDesteForm = produtoComponente;
            txtNomeProduto.Text = ProdutoCompDesteForm.ProdutoComponente.Nome;
            txtProdutoCompId.Text = ProdutoCompDesteForm.ProdutoComponente.ProdutoId.ToString();
            txtQuantidade.Text = ProdutoCompDesteForm.Quantidade.ToString();
            ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                return ProdutoCompDesteForm;
            }
            return null;
        }
        private void txtNomeProduto_Click(object sender, EventArgs e)
        {
            var mProdutoComp = new FormListagemTabela<Produto>().BuscaRegistroSelecionado();
            if (!Util.ObjectoNulo(mProdutoComp))
            {
                ProdutoCompDesteForm.ProdutoComponente = mProdutoComp;
                ProdutoCompDesteForm.ProdutoComponente.ProdutoId = ProdutoCompDesteForm.ProdutoComponente.ProdutoId;
                ProdutoCompDesteForm.ProdutoComponenteId = ProdutoCompDesteForm.ProdutoComponente.ProdutoId;
                txtProdutoCompId.Text = ProdutoCompDesteForm.ProdutoComponente.ProdutoId.ToString();
                txtNomeProduto.Text = ProdutoCompDesteForm.ProdutoComponente.Nome;
            }
        }

        private void btnAdicionar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (PodeAdicionar())
            {
                ProdutoCompDesteForm.Quantidade = Convert.ToDecimal(txtQuantidade.Text);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool PodeAdicionar()
        {
            if (string.IsNullOrEmpty(txtNomeProduto.Text))
            {
                Mensagem.Alerta("Selecione um produto para ser componente!");
                return false;
            }
            if (string.IsNullOrEmpty(txtQuantidade.Text))
            {
                Mensagem.Alerta("Insira a quantidade do produto componente!");
                return false;
            }

            if (Convert.ToDecimal(txtQuantidade.Text) <= 0)
            {
                Mensagem.Alerta("O produto componente tem que ser pelo menos um!");
                return false;
            }
            return true;
        }
    }
}