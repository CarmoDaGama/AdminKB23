using AdminKB.Aplicacoes;
using AdminKB.Dominio.Modelos;
using AdminKB.Dominio.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using AdminKB.Dominio.Enumerados;

namespace AdminKB.Formularios.Produtos
{
    public partial class FormAcertoEstoque : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private TipoDocumentoApp _TipoApp;
        private ProdutoEstoqueApp _ProdutoEstoqueApp;
        private ProdutoMovimentacaoApp _ProdutoMovApp;
        private ProdutoComponenteApp _ProdutoCompApp;

        private string TipoSigla { get; set; }
        private bool Acertado { get; set; }
        private TipoDocumento TipoActual { get;  set; }
        private List<ProdutoEstoque> ProdutoEstoques { get; set; }

        public FormAcertoEstoque()
        {
            InitializeComponent();
            IniciarAplicacoes();
        } 
        public FormAcertoEstoque(string tipoSigla)
        {
            InitializeComponent();
            TipoSigla = tipoSigla;
            IniciarAplicacoes();
        }

        private void IniciarAplicacoes()
        {
            _TipoApp = new TipoDocumentoApp();
            _ProdutoEstoqueApp = new ProdutoEstoqueApp();
            _ProdutoMovApp = new ProdutoMovimentacaoApp();
            _ProdutoCompApp = new ProdutoComponenteApp();
        }


        public bool AcertarEstoque(string sigla)
        {
            TipoSigla = sigla;
            ShowDialog();
            return Acertado;
        }
        private void FormAcertoEstoque_Load(object sender, EventArgs e)
        {
            TipoActual = _TipoApp.RetornaTipoDocumentoPorSigla(TipoSigla);
            Text = TipoActual.Nome.ToUpper();
        }

        private void btnSelecionarProduto_Click(object sender, EventArgs e)
        {
            var produtoEstoqueSelecionado = new FormProdutos().RetornaProdutoEstoqueSelecionado();
            if (!(produtoEstoqueSelecionado is null))
            {
                Imagem.InserirImagem(picImage, produtoEstoqueSelecionado.Produto.Imagem);
                txtCodigoDeBarra.Text = produtoEstoqueSelecionado.Produto.CodigoDeBarra;
                txtDescricao.Text = produtoEstoqueSelecionado.Produto.Nome;
                txtEstoqueActual.Text = produtoEstoqueSelecionado.Estoque.Nome;
                dateExpiracao.EditValue = produtoEstoqueSelecionado.DataDeExpiracao;
                txtQuantidadeMin.Text = produtoEstoqueSelecionado.QuantidadeMinima.ToString("N2");
                txtQuantidadeActual.Text = produtoEstoqueSelecionado.Quantidade.ToString("N2");
                txtQuantidadeAdicionar.Text = "0";
            }
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            var novoProdutoEstoque = NovoProdutoEstoque(txtCodigoDeBarra.Text);
            if (PodeAdicionarListaDeAcerto(novoProdutoEstoque, Convert.ToDecimal(txtQuantidadeAdicionar.Text)))
            {
                ProdutoEstoques.Add(novoProdutoEstoque);
                GradeProdutos.DataSource = null;
                GradeProdutos.DataSource = ProdutoEstoques;
            }
        }

        private bool PodeAdicionarListaDeAcerto(ProdutoEstoque produtoEstoque, decimal quantidade)
        {
            if (string.IsNullOrEmpty(txtQuantidadeAdicionar.Text))
            {
                Mensagem.Alerta("Selecione um produto para o " + TipoActual.Nome.ToLower());
                return false;                    
            }
            if (TipoActual.Estoque == MovEstoque.Debita)
            {
                if (produtoEstoque.Quantidade - produtoEstoque.QuantidadeMinima < quantidade)
                {
                    Mensagem.Alerta("Produto com quantidade em estoque insuficiente para venda!");
                    return false;
                }
                if (ProdutoComponenteInsuficiente(produtoEstoque, quantidade))
                {
                    Mensagem.Alerta("Quantidade de produtos Componente no inventario é insuficiente!");
                    return false;
                }
            }
            if (TipoActual.Estoque == MovEstoque.Credita)
            {
                if (produtoEstoque.QuantidadeMaxima < quantidade)
                {
                    Mensagem.Alerta("Este quantidade de produto excede o limite de quantidade permitidade neste estoque!");
                    return false;
                }
            }
            return false;
        }

        private bool ProdutoComponenteInsuficiente(ProdutoEstoque produtoEstoque, decimal quantidadeAdicionar)
        {
            var produtoComps = _ProdutoCompApp.RetornaProdutosCompsPorProdutoId(produtoEstoque.ProdutoId);

            var resultWhere = produtoComps.Where(
                a => a.Quantidade * quantidadeAdicionar <= RetornaQuantidadeDisponivel(a.ProdutoComponenteId)).ToList();

            return produtoComps.Count != resultWhere.Count;
        }

        private decimal RetornaQuantidadeDisponivel(int produtoComponenteId)
        {
            var produtoEstoqueDisponivel = _ProdutoEstoqueApp.CarregarProdutosDisponivel(produtoComponenteId);
            return produtoEstoqueDisponivel.Quantidade - produtoEstoqueDisponivel.QuantidadeMinima;
        }
        private ProdutoEstoque NovoProdutoEstoque(string codigoDeBarra)
        {
            var produtoEstoqueParaAcerto = _ProdutoEstoqueApp.RetornaProdutoPorCodigoDeBarra(codigoDeBarra);
            return new ProdutoEstoque
            {
                DataDeExpiracao = produtoEstoqueParaAcerto.DataDeExpiracao,
                DataDeFabricacao = produtoEstoqueParaAcerto.DataDeFabricacao,
                Produto= produtoEstoqueParaAcerto.Produto, 
                DataDeRegistro = produtoEstoqueParaAcerto.DataDeRegistro, 
                Estado = produtoEstoqueParaAcerto.Estado,
                Estoque = produtoEstoqueParaAcerto.Estoque, 
                EstoqueId = produtoEstoqueParaAcerto.EstoqueId, 
                NumeroDeSerie = produtoEstoqueParaAcerto.NumeroDeSerie,
                ProdutoEstoqueId = produtoEstoqueParaAcerto.ProdutoEstoqueId, 
                ProdutoId = produtoEstoqueParaAcerto.ProdutoId, 
                Quantidade = Convert.ToDecimal(txtQuantidadeAdicionar.Text),
                QuantidadeMaxima = produtoEstoqueParaAcerto.QuantidadeMaxima,
                QuantidadeMinima = produtoEstoqueParaAcerto.QuantidadeMinima, 
                UmLote = produtoEstoqueParaAcerto.UmLote
            };
        }
    }
}