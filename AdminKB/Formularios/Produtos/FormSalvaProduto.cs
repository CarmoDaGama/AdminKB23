using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using AdminKB.Aplicacoes;
using Dominio.Enumerados;
using AdminKB.Formularios.Geral;
using Dominio.Modelos;
using Dominio.Modelos.ModulosVer;
using Dominio.Utilitarios;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace AdminKB.Formularios.Produtos
{
    public partial class FormSalvaProduto : XtraForm
    {
        private MotivoIsencaoApp _MotivoIsencaoApp;
        private ImpostoApp _ImpostoApp;
        private Produto ProdutoDesteForm { get; set; }
        public OperacoesDeFormulario Operacao { get; set; }
        private CategoriaApp _CategoriaApp;
        private ProdutoApp _ProdutoApp;
        private ProdutoEstoqueApp _ProdutoEstoqueApp;
        private ProdutoComponenteApp _ProdutoCompApp;

        private string ImpostoIsento { get { return "Isento"; } }

        private MotivoIsencao MotivoIsencaoNula { get;  set; }
        private bool Salvo { get; set; }
        private List<ProdutoEstoque> ListaProdutoEstoque { get; set; }
        public int IndiceProdutoEstoque { get; private set; }
        public List<ProdutoComposicaoVer> ListaProdutoComponentes { get; private set; }
        public int IndiceProdutoComponente { get; private set; }

        public FormSalvaProduto()
        {
            InitializeComponent();
            InicializarAplicacaoes();
            CarregarProcessos();
            PopularProdutoNosCampos();
            cboPermitirVenda.SelectedIndex =  0;
            cboControleEstoque.SelectedIndex = 0;
        }

        private void CarregarProcessos()
        {
            CarregarDadosPadrao();
        }

        private void CarregarDadosPadrao()
        {
            ProdutoDesteForm = new Produto();
            MotivoIsencaoNula = _MotivoIsencaoApp.BuscaTipoEntidadePadrao();
            ProdutoDesteForm.Categoria = _CategoriaApp.BuscaTipoEntidadePadrao();
            ProdutoDesteForm.CategoriaId = ProdutoDesteForm.Categoria.CategoryId;
            ProdutoDesteForm.Imposto = _ImpostoApp.BuscaTipoEntidadePadrao();
            ProdutoDesteForm.ImpostoId = ProdutoDesteForm.Imposto.ImpostoId;
            ProdutoDesteForm.MotivoIsencao = MotivoIsencaoNula;
            ProdutoDesteForm.MotivoIsencaoId = MotivoIsencaoNula.MotivoIsencaoId;
        }
        public bool ActualizarProduto(int produtoId)
        {
            ProdutoDesteForm = _ProdutoApp.BuscaProdutoPorId(produtoId);
            Operacao = OperacoesDeFormulario.ACTUALIZAR;
            PopularProdutoNosCampos();
            CarregarProdutoNoEstoque();
            CarregarProdutoComponentes();
            ShowDialog();
            return Salvo;
        }

        private void CarregarProdutoComponentes()
        {
            ListaProdutoComponentes = _ProdutoCompApp.CarregarProdutosCompVerPorId(ProdutoDesteForm.ProdutoId);
            gradeComposicao.DataSource = ListaProdutoComponentes;
        }

        private void CarregarProdutoNoEstoque()
        {
            ListaProdutoEstoque = _ProdutoEstoqueApp.CarregarProdutosPorId(ProdutoDesteForm.ProdutoId);
            gradeEstoque.DataSource = ListaProdutoEstoque;
        }

        public bool AdicionarProduto()
        {
            ShowDialog();
            return Salvo;
        }
        private void PopularProdutoNosCampos()
        {
            if (!Util.ObjectoNulo(ProdutoDesteForm))
            {
                txtProdutoId.Text = ProdutoDesteForm.ProdutoId.ToString();
                txtCodigoDeBarra.Text = ProdutoDesteForm.CodigoDeBarra;
                txtDescricao.Text = ProdutoDesteForm.Nome;
                txtCategoria.Text = ProdutoDesteForm.Categoria.Name;
                txtImposto.Text = ProdutoDesteForm.Imposto.Nome;
                txtMotivoIsencao.Text = ProdutoDesteForm.MotivoIsencao.Nome;
                txtCusto.Text = ProdutoDesteForm.Custo.ToString("N2");
                txtPrice.Text = ProdutoDesteForm.Preco.ToString("N2");
                cboPermitirVenda.SelectedIndex = ProdutoDesteForm.Vender ? 0 : 1;
                cboControleEstoque.SelectedIndex = ProdutoDesteForm.ControleEstoque ? 0 : 1;
                cboTipo.SelectedIndex = (int)ProdutoDesteForm.Tipo;
                Imagem.InserirImagem(picImage, ProdutoDesteForm.Imagem);
            }
        }
        private void PopularCamposNoProduto()
        {
            ProdutoDesteForm.CodigoDeBarra = txtCodigoDeBarra.Text.Trim();
            ProdutoDesteForm.Nome = txtDescricao.Text.Trim();
            ProdutoDesteForm.Categoria.Name = txtCategoria.Text;
            ProdutoDesteForm.Imposto.Nome = txtImposto.Text;
            ProdutoDesteForm.MotivoIsencao.Nome = txtMotivoIsencao.Text;
            ProdutoDesteForm.Custo = Convert.ToDecimal(txtCusto.Text); 
            ProdutoDesteForm.Preco = Convert.ToDecimal(txtPrice.Text);
            ProdutoDesteForm.Vender = cboPermitirVenda.SelectedIndex == 0;
            ProdutoDesteForm.ControleEstoque  = cboControleEstoque.SelectedIndex == 0;
            ProdutoDesteForm.Tipo = (TipoProduto)cboTipo.SelectedIndex;
            if (!Util.ObjectoNulo(picImage.Image))
            {
                var imagemRedimensionada = Imagem.RedimensionarImagem(picImage.Image, 200, 200);
                ProdutoDesteForm.Imagem = Imagem.ImageToByte(imagemRedimensionada);
            }
            else
            {
                ProdutoDesteForm.Imagem = Imagem.ImageToByte(picImage.SvgImage);
            }
        }

        private void InicializarAplicacaoes()
        {
            _MotivoIsencaoApp = new MotivoIsencaoApp();
            _ImpostoApp = new ImpostoApp();
            _CategoriaApp = new CategoriaApp();
            _ProdutoApp = new ProdutoApp();
            _ProdutoEstoqueApp = new ProdutoEstoqueApp();
            _ProdutoCompApp = new ProdutoComponenteApp();
        }

        private void btnFormClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void FormSalvaProduto_Load(object sender, EventArgs e)
        {
            cboTipo.SelectedIndex = 0;
            MudarVisiblidadeDaPaginaEstoque();
        }

        private void txtCategoria_Click(object sender, EventArgs e)
        {
            var mCategoria = new FormListagemTabela<Category>().BuscaRegistroSelecionado();
            ProdutoDesteForm.Categoria = mCategoria == null? ProdutoDesteForm.Categoria : mCategoria;
            if (!Util.ObjectoNulo(ProdutoDesteForm.Categoria))
            {
                ProdutoDesteForm.CategoriaId = ProdutoDesteForm.Categoria.CategoryId;
                txtCategoria.Text = ProdutoDesteForm.Categoria.Name;
            }
        }

        private void btnSaveArticle_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (PodeSalvarProduto())
            {
                PopularCamposNoProduto();
                //AnularEntidadesComponentes();
                if (Operacao == OperacoesDeFormulario.ADICIONAR)
                {
                    ProdutoDesteForm.ProdutoId = _ProdutoApp.Adicionar(ProdutoDesteForm);
                    if (!ProdutoDesteForm.ControleEstoque)
                    {
                        var estoque = new EstoqueApp().BuscaTipoEntidadePadrao();

                        ListaProdutoEstoque = new List<ProdutoEstoque>{new ProdutoEstoque()
                        {
                            ProdutoId = ProdutoDesteForm.ProdutoId,
                            DataDeExpiracao = Util.RetornaDataVencime(30),
                            Produto = ProdutoDesteForm,
                            DataDeFabricacao = Util.RetornaDataVencime(-30),
                            DataDeRegistro = DateTime.Now,
                            EstoqueId = estoque.EstoqueId,
                            UmLote = false
                        }};
                    }
                }
                else if(Operacao == OperacoesDeFormulario.ACTUALIZAR)
                {
                    _ProdutoApp.Actualizar(ProdutoDesteForm);
                }
                
                _ProdutoEstoqueApp.GravarProdutosEstoque(ProdutoDesteForm, ListaProdutoEstoque);
                _ProdutoCompApp.GravarProdutosComp(ProdutoDesteForm, ListaProdutoComponentes);

                Mensagem.Alerta("Produto Salvo com sucesso!");
                InicializarAplicacaoes();
                Operacao = OperacoesDeFormulario.ACTUALIZAR;
                txtProdutoId.Text = ProdutoDesteForm.ProdutoId.ToString();
                IniciarEntidadesComponentes();
                Salvo = true;
            }
        }

        private void AnularEntidadesComponentes()
        {
            ProdutoDesteForm.Categoria = new Category();
            ProdutoDesteForm.Imposto = new Imposto();
            ProdutoDesteForm.MotivoIsencao = new MotivoIsencao();
            foreach (var item in ListaProdutoEstoque)
            {
                item.Estoque = new Estoque();
            }
        }
        private void IniciarEntidadesComponentes()
        {
            ProdutoDesteForm.Categoria = new Category();
            ProdutoDesteForm.Imposto = new Imposto();
            ProdutoDesteForm.MotivoIsencao = new MotivoIsencao();
            foreach (var item in ListaProdutoEstoque)
            {
                item.Estoque = new Estoque();
            }
        }

        private bool PodeSalvarProduto()
        {
            if (txtCusto.Text.Contains("."))
            {
                txtCusto.Text = txtCusto.Text.Replace(".", ",");
            }
            if (txtPrice.Text.Contains("."))
            {
                txtPrice.Text = txtPrice.Text.Replace(".", ",");
            }
            if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                Mensagem.Alerta("Insira a descrição do produto!");
                return false;
            }
            if (Operacao == OperacoesDeFormulario.ADICIONAR && CodigoDeBarraExistente(txtCodigoDeBarra.Text))
            {
                Mensagem.Alerta("Está inserindo um produto com codigo de barra já existente!");
                return false;
            }
            if (cboPermitirVenda.SelectedIndex < 0)
            {
                Mensagem.Alerta("Escolha uma opção no campo Vender!");
                return false;
            }
            if (cboControleEstoque.SelectedIndex < 0)
            {
                Mensagem.Alerta("Escolha uma opção no campo Estoque!");
                return false;
            }
            if (cboControleEstoque.SelectedIndex < 0)
            {
                Mensagem.Alerta("Escolha uma opção no campo Estoque!");
                return false;
            }
            if (string.IsNullOrEmpty(txtCategoria.Text))
            {
                Mensagem.Alerta("Escolha uma categoria!");
                return false;
            }
            if (string.IsNullOrEmpty(txtImposto.Text))
            {
                Mensagem.Alerta("Escolha um tipo de imposto para o novo produto!");
                return false;
            }
            if (txtMotivoIsencao.Enabled && string.IsNullOrEmpty(txtMotivoIsencao.Text))
            {
                Mensagem.Alerta("Escolha um motivo de isenção!");
                return false;
            }
            if (string.IsNullOrEmpty(txtCusto.Text))
            {
                Mensagem.Alerta("Insira Custo do produto!");
                return false;
            }
            if (cboPermitirVenda.SelectedIndex == 0)
            {
                if (string.IsNullOrEmpty(txtPrice.Text))
                {
                    Mensagem.Alerta("Insira Preço do produto!");
                    return false;
                }
                if (Convert.ToDecimal(txtPrice.Text) <= Convert.ToDecimal(txtCusto.Text))
                {
                    Mensagem.Alerta("O preço do produto inserido não pode ser maior ou igual ao custo!");
                    return false;
                }
            }
            if (cboControleEstoque.SelectedIndex == 0)
            {
                if (gridEstoque.RowCount <= 0)
                {
                    Mensagem.Alerta("Adicione este novo produto a pelo menos um estoque!");
                    return false;
                }
            }
            return true;
        }

        private bool CodigoDeBarraExistente(string codigoDeBarra)
        {
            return _ProdutoApp.CodigoDeBarraExistente(codigoDeBarra);
        }

        private void txtImposto_Click(object sender, EventArgs e)
        {
            var mImposto = new FormListagemTabela<Imposto>().BuscaRegistroSelecionado();
            ProdutoDesteForm.Imposto = mImposto == null? ProdutoDesteForm.Imposto : mImposto;
            if (!Util.ObjectoNulo(ProdutoDesteForm.Imposto))
            {
                txtImposto.Text = ProdutoDesteForm.Imposto.Nome;
                ProdutoDesteForm.ImpostoId = ProdutoDesteForm.Imposto.ImpostoId; 
                if (ProdutoDesteForm.Imposto.Nome == ImpostoIsento)
                {
                    var motivoIsencao = new MotivoIsencaoApp().BuscaPorReferencia("M02");
                    ProdutoDesteForm.MotivoIsencao = motivoIsencao;
                    ProdutoDesteForm.MotivoIsencaoId = motivoIsencao.MotivoIsencaoId;
                    txtMotivoIsencao.Text = motivoIsencao.Nome;
                    txtMotivoIsencao.Enabled = true;
                }
                else
                {
                    txtMotivoIsencao.Enabled = false;
                    txtMotivoIsencao.Text = MotivoIsencaoNula.Nome;
                }
            }
        }

        private void txtMotivoIsencao_Click(object sender, EventArgs e)
        {
            var mMotivoIsencao = new FormListagemTabela<MotivoIsencao>().BuscaRegistroSelecionado();
            ProdutoDesteForm.MotivoIsencao = mMotivoIsencao == null? ProdutoDesteForm.MotivoIsencao : mMotivoIsencao;
            if (!Util.ObjectoNulo(ProdutoDesteForm.MotivoIsencao))
            {
                if (MotivoIsencaoNula.Nome == ProdutoDesteForm.MotivoIsencao.Nome)
                {
                    Mensagem.Alerta("Este motivo não é aceite para o imposto isento!");
                }
                else
                {
                    ProdutoDesteForm.MotivoIsencaoId = ProdutoDesteForm.MotivoIsencao.MotivoIsencaoId;
                    txtMotivoIsencao.Text = ProdutoDesteForm.MotivoIsencao.Nome;
                }
            }
        }

        private void btnClearFieds_ItemClick(object sender, ItemClickEventArgs e)
        {
            ProdutoDesteForm = new Produto();
            CarregarDadosPadrao();
            PopularProdutoNosCampos();
            cboControleEstoque.SelectedIndex = 0;
            cboPermitirVenda.SelectedIndex = 0;
            Operacao = OperacoesDeFormulario.ADICIONAR;
            if (!Util.ListaNula(ListaProdutoEstoque))
            {
                ListaProdutoEstoque.Clear();
            }
            if (!Util.ListaNula(ListaProdutoComponentes))
            {
                ListaProdutoComponentes.Clear();
            }
            gradeEstoque.DataSource = null;
            gradeComposicao.DataSource = null;
        }

        private void btnAdicionarEstoque_Click(object sender, EventArgs e)
        {
            var novoProdutoEstoque = new FormRetornaNovoProdutoEstoque().BuscaNovoProdutoEstoque();
            if (!Util.ObjectoNulo(novoProdutoEstoque))
            {
                if (ProdutoEstoqueExistente(novoProdutoEstoque.EstoqueId))
                {
                    Mensagem.Alerta("O produto já foi adicionado neste estoque!");
                    return;
                }
                if (Util.ListaNula(ListaProdutoEstoque))
                {
                    ListaProdutoEstoque = new List<ProdutoEstoque>() { novoProdutoEstoque };
                }
                else
                {
                    ListaProdutoEstoque.Add(novoProdutoEstoque);
                }
                gradeEstoque.DataSource = null;
                gradeEstoque.DataSource = ListaProdutoEstoque;
            }
        }

        private bool ProdutoEstoqueExistente(int estoqueId)
        {
            return !Util.ListaNula(ListaProdutoEstoque) && ListaProdutoEstoque.Where(p => p.EstoqueId == estoqueId).FirstOrDefault() != null;
        }

        private void gridEstoque_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            IndiceProdutoEstoque = e.RowHandle;
        }

        private void gradeEstoque_DoubleClick(object sender, EventArgs e)
        {
            var mProdutoEstoque = new FormRetornaNovoProdutoEstoque().ActualizarProdutoEstoque(ListaProdutoEstoque[IndiceProdutoEstoque]);
            if (!Util.ObjectoNulo(mProdutoEstoque))
            {
                ListaProdutoEstoque[IndiceProdutoEstoque] = null;
                ListaProdutoEstoque[IndiceProdutoEstoque] = mProdutoEstoque;
            }

        }

        private void btnAdicionarComposto_Click(object sender, EventArgs e)
        {
            var novoProdutoComp = new FormAdicionarProdutoComponente().Adicionar();
            if (!Util.ObjectoNulo(novoProdutoComp))
            {
                if (PodeAdicionarComponente(novoProdutoComp))
                {
                    if (Util.ListaNula(ListaProdutoComponentes))
                    {
                        ListaProdutoComponentes = new List<ProdutoComposicaoVer>() { novoProdutoComp };
                    }
                    else
                    {

                        if (ProdutoCompExistente(novoProdutoComp.ProdutoComponenteId))
                        {
                            var result = ListaProdutoComponentes.Where(p => p.ProdutoComponenteId == novoProdutoComp.ProdutoComponenteId)
                                                                .FirstOrDefault();
                            result.Quantidade += novoProdutoComp.Quantidade;
                        }
                        else
                        {
                            ListaProdutoComponentes.Add(novoProdutoComp);
                        }
                    }
                    gradeComposicao.DataSource = null;
                    gradeComposicao.DataSource = ListaProdutoComponentes;

                }
            }
        }

        private bool PodeAdicionarComponente(ProdutoComposicaoVer produtoComp)
        {
            if (produtoComp.ProdutoComponenteId == ProdutoDesteForm.ProdutoId)
            {
                Mensagem.Alerta("Não podes adicionar o produto a sua composição|");
                return false;
            }
            return true;
        }

        private bool ProdutoCompExistente(int produtoId)
        {
            return !Util.ListaNula(ListaProdutoComponentes) && ListaProdutoComponentes.Where(p => p.ProdutoComponenteId == produtoId).FirstOrDefault() != null;
        }

        private void GridComposicao_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            IndiceProdutoComponente = e.RowHandle;
        }

        private void gradeComposicao_DoubleClick(object sender, EventArgs e)
        {
            var mProdutoComp = new FormAdicionarProdutoComponente().Actualizar(ListaProdutoComponentes[IndiceProdutoComponente]);
            if (!Util.ObjectoNulo(mProdutoComp))
            {
                ListaProdutoComponentes[IndiceProdutoComponente] = null;
                ListaProdutoComponentes[IndiceProdutoComponente] = mProdutoComp;
            }
        }

        private void btnRemoverProdutoEstoque_Click(object sender, EventArgs e)
        {
            if (Mensagem.TemCerteza())
            {
                var numeroDeSerie = gridEstoque.GetRowCellValue(IndiceProdutoEstoque, "NumeroDeSerie").ToString();
                _ProdutoEstoqueApp.RemoverPorNumeroDeSerie(numeroDeSerie);
                ListaProdutoEstoque.RemoveAt(IndiceProdutoComponente);
                gradeEstoque.DataSource = null;
                gradeEstoque.DataSource = ListaProdutoEstoque;
            }
        }

        private void btnRemoverProdutoComponente_Click(object sender, EventArgs e)
        {
            if (Mensagem.TemCerteza())
            {
                var produtoComposicaoId = Convert.ToInt32(gridComposicao.GetRowCellValue(IndiceProdutoComponente, "ProdutoComposicaoId"));
                var produtoComposicao = ListaProdutoComponentes.Where(p => p.ProdutoComposicaoId == produtoComposicaoId).FirstOrDefault();
                if (produtoComposicao.ProdutoComposicaoId > 0)
                {
                    _ProdutoCompApp.RemoverVer(produtoComposicao);
                }
                ListaProdutoComponentes.RemoveAt(IndiceProdutoComponente);
                gradeEstoque.DataSource = null;
                gradeEstoque.DataSource = ListaProdutoEstoque;
            }
        }

        private void picImage_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboControleEstoque_SelectedIndexChanged(object sender, EventArgs e)
        {
            MudarVisiblidadeDaPaginaEstoque();
        }

        private void MudarVisiblidadeDaPaginaEstoque()
        {
            if (cboControleEstoque.SelectedIndex == 0)
            {
                pageEstoque.PageVisible = true;
            }
            else
            {
                pageEstoque.PageVisible = false;
            }
        }
    }
}