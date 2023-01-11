using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Tile;
using AdminKB.Aplicacoes;
using Dominio.Enumerados;
using AdminKB.Formularios.Financas;
using AdminKB.Formularios.Geral;
using AdminKB.Formularios.Impressoes;
using AdminKB.Formularios.Produtos;
using AdminKB.Formularios.Usuarios;
using Dominio.Modelos;
using AdminKB.Relatorios;
using Dominio.Utilitarios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AdminKB.Formularios.Documentos
{
    public partial class FormEditorDocumento : XtraForm
    {
        //private EstoqueApp _EstoqueApp;
        //private ProdutoEstoqueApp _ProdutoEstoqueApp;
        //private TipoDocumentoApp _TipoDocumentoApp;
        //private DocumentoApp _DocumentoApp;
        //private ProdutoMovimentacaoApp _ProdutoMovimentacaoApp;
        //private ProdutoComponenteApp _ProdutoCompApp;
        //private ClienteApp _ClienteApp;
        //private PagamentoApp _PagamentoApp;
        //private DocumentoAnuladoApp _DocAnuladoApp;

        //private List<ProdutoEstoque> ProdutosVenda { get; set; }
        //private List<Estoque> Estoques { get; set; }
        //private List<ProdutoMovimentacao> ProdutoMovimentacoes { get; set; } = new List<ProdutoMovimentacao>();
        //private Documento DocumentoActual { get; set; }
        //private TipoDocumento TipoActual { get; set; }
        //private Cliente ClienteActual { get; set; }
        //private string TipoSigla { get; set; } = "FR";
        //private bool Editado { get; set; }

        public FormEditorDocumento()
        {
            InitializeComponent();
            //RenderizarPainelProdutos();
            //InicializarAplicacoes();
            //ClienteActual = _ClienteApp.BuscaTipoEntidadePadrao();
            //navigationFrame1.SelectedPage = navigationPage_PostoVenda;
        }

        internal bool MostrarDocumento(int documentoId)
        {
            ShowDialog();
            return true;
        }

        internal bool CriarDocumento(string v)
        {
            ShowDialog();
            return true;
        }

        //public new DialogResult ShowDialog()
        //{
        //    if (!Globais.EstadoDoTurno)
        //    {
        //        if (Mensagem.Questao("Não pode efectuar esta operação sem abrir turno.\nPretende abrir turno?"))
        //        {
        //            if(new FormAbrirTurno().AbrirTurno())
        //            {
        //                Mensagem.Alerta("Turno aberto com sucesso!");
        //                return base.ShowDialog();
        //            }
        //            {
        //                Mensagem.Alerta("Não foi possível abrir turno!");
        //                return DialogResult.None;
        //            }
        //        }
        //        else
        //        {
        //            return DialogResult.None;
        //        }
        //    }
        //    else
        //    {
        //        return base.ShowDialog();
        //    }
        //}
        //public bool MostrarDocumento(int documentoId)
        //{
        //    DocumentoActual = _DocumentoApp.RetornaDocumentoPorId(documentoId);
        //    if (!NaoExisteDocumento())
        //    {
        //        ShowDialog();
        //        return Editado;
        //    }
        //    return Editado;
        //}
        //public bool CriarDocumento(string tipoSigla)
        //{
        //    TipoSigla = tipoSigla;
        //    ShowDialog();
        //    return Editado; ;
        //}
        //private void MostrarTipoDocumento()
        //{
        //    MostrarDocumento();
        //}
        //private void MostrarCliente()
        //{
        //    if (TipoActual.Destino == Destino.Isento)
        //    {
        //        RenderizarFormParaOutrosDocs();
        //    }
        //    else
        //    {
        //        if (!Util.ObjectoNulo(ClienteActual))
        //        {
        //            if (NaoExisteDocumento())
        //            {
        //                lblNomeCliente.Text = ClienteActual.Nome;
        //            }
        //            else
        //            {
        //                DocumentoActual.Cliente = ClienteActual;
        //                DocumentoActual.ClienteId = ClienteActual.ClienteId;
        //                DocumentoActual.NomeCliente = ClienteActual.Nome;
        //                lblNomeCliente.Text =  DocumentoActual.NomeCliente;

        //            }
        //            lblNIF.Text = ClienteActual.Nif;
        //            lblSaldoCliente.Text = Util.MostrarValorNaMoedaActual(0);
        //            lblDebitoLimiteCliente.Text = Util.MostrarValorNaMoedaActual(ClienteActual.DebitoLimite);
        //            lblClienteId.Text = ClienteActual.ClienteId.ToString();
        //            picCliente.SvgImage = ClienteActual.Imagem == null ? picCliente.SvgImage : Imagem.ByteToSvgImage(ClienteActual.Imagem);
        //        }
        //    }

        //}

        //private void RenderizarFormParaOutrosDocs()
        //{
        //    pnlTotais.Size = new Size(pnlTotais.Width + pnlCliente.Width, pnlTotais.Height);
        //    pnlTotais.Dock = DockStyle.Fill;
        //    //20; 74; 119
        //    pnlTotais.BackColor = Color.FromArgb(20, 74, 119);
        //    pnlTotais.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
        //    pnlCliente.Visible = false;
        //    pnlPagamentos.Visible = false;
        //    pnlDesconto.Visible = false;
        //    pnlImposto.Visible = false;
        //    pnlSubTotal.Visible = false;
        //    pnlLinhasProdutos.Visible = false;
        //    panelRodape.Size = new Size(panelRodape.Width, 30);
        //    panelRodape.Dock = DockStyle.Top;
        //    panelRodape.BorderStyle = BorderStyle.None;
        //    btnDocumento.Text = "ESTOCAGEM";
        //    btnDocumento.ImageOptions.SvgImage = Properties.Resources.Estocagem;
        //    txtCodigoBarra.ToolTip = "Insira aqui o código de barra de um produto para inserir na lista de estoque";
        //    btnDocumento.Enabled = false;
        //    btnTurno.Visible = false;
        //    lblTextValorDevido.Text = "TOTAL";
        //    lblTextValorDevido.ForeColor = Color.FromArgb(88, 188, 254);
        //}

        //private void CarregarProcessos()
        //{
        //    TipoActual = _TipoDocumentoApp.RetornaTipoDocumentoPorSigla(TipoSigla);
        //    accMenuEditorDocumento.OptionsMinimizing.State = AccordionControlState.Minimized;
        //    CarregarEstoques();
        //    CarregarDocumentoAberto();
        //    MostrarTipoDocumento();
        //    MostrarDocumento();
        //    ActualizarListaMovimentacao();
        //    MostrarTotais();
        //    MostrarCliente();
        //    MudarOpcoesEstadoDocumento();
        //}

        //private void CarregarDocumentoAberto()
        //{
        //    if (NaoExisteDocumento())
        //    {
        //        DocumentoActual = _DocumentoApp.RetornaUltimoDocumentoAbertoPorSigla(TipoSigla);
        //    }

        //    if (!NaoExisteDocumento())
        //    {
        //        TipoActual = null;
        //        TipoActual = DocumentoActual.Tipo;
        //        TipoSigla = TipoActual.Sigla;
        //        ClienteActual = DocumentoActual.Cliente;
        //        //ClienteActual.Nome = DocumentoActual.NomeCliente;
        //    }
        //}
        //private void MudarOpcoesEstadoDocumento()
        //{
        //    if (!NaoExisteDocumento())
        //        switch (DocumentoActual.Estado)
        //        {
        //            case EstadoDocumento.Aberto:
        //            {
        //                OpcaoDocumentoAberto();
        //                break;
        //            }
        //            case EstadoDocumento.Fechado:
        //            {
        //                OpcaoDocumentoFechado();
        //                break;
        //            }
        //            case EstadoDocumento.Anulado:
        //            {
        //                OpcaoDocumentoAnulado();
        //                break;
        //            }

        //        }
        //}
        //private void CarregarEstoques()
        //{
        //    var estoques = _EstoqueApp.BuscaTodosRegistros();
        //    Estoques = new List<Estoque>() { new Estoque() { EstoqueId = 0, Nome = "Todos" } };
        //    Estoques.AddRange(estoques);
        //    CboEstoqute.Properties.Items.Clear();
        //    foreach (var item in Estoques)
        //    {
        //        CboEstoqute.Properties.Items.Add(item.Nome);
        //    }
        //    if (CboEstoqute.Properties.Items.Count > 0)
        //    {
        //        CboEstoqute.SelectedIndex = 0;
        //    }
        //}

        //private void InicializarAplicacoes()
        //{
        //    _EstoqueApp = new EstoqueApp();
        //    _ProdutoEstoqueApp = new ProdutoEstoqueApp();
        //    _TipoDocumentoApp = new TipoDocumentoApp();
        //    _DocumentoApp = new DocumentoApp();
        //    _ProdutoMovimentacaoApp = new ProdutoMovimentacaoApp();
        //    _ProdutoCompApp = new ProdutoComponenteApp();
        //    _ClienteApp = new ClienteApp();
        //    _PagamentoApp = new PagamentoApp();
        //    _DocAnuladoApp = new DocumentoAnuladoApp();
        //}

        //private void CarregarProdutosaVenda()
        //{
        //    if (CboEstoqute.Properties.Items.Count == 0 || CboEstoqute.SelectedIndex <= 0)
        //    {
        //        ProdutosVenda = _ProdutoEstoqueApp.CarregarProdutosVenda();
        //    }
        //    else
        //    {
        //        ProdutosVenda = _ProdutoEstoqueApp.CarregarProdutosVendaPorEstoqueId(Estoques[CboEstoqute.SelectedIndex].EstoqueId);
        //    }
        //    GradeProdutos.DataSource = ProdutosVenda;
        //    GradeProdutosCartao.DataSource = ProdutosVenda;
        //}

        //private void btnFechar_Click(object sender, EventArgs e)
        //{
        //    Close();
        //}

        //private void btnArtigos_Click(object sender, EventArgs e)
        //{
        //    RenderizarPainelProdutos();
        //}

        //private void RenderizarPainelProdutos()
        //{
        //    if (panelArtigos.Width == 0)
        //    {
        //        panelArtigos.Size = new Size(Width / 2, panelArtigos.Height);
        //    }
        //    else
        //    {
        //        panelArtigos.Size = new Size(0, panelArtigos.Height);
        //    }
        //}

        //private void CarregarPermissoesAcesso()
        //{
        //    var op = "FACTURAÇÃO";
        //    if (TipoActual.Destino == Destino.Isento)
        //    {
        //        op = "ESTOQUE";
        //    }
        //    var _acessoApp = new AcessoApp();
        //    var nomeTipo = new TipoDocumentoApp().RetornaTipoDocumentoPorSigla(TipoSigla)
        //                                         .Nome
        //                                         .ToUpper()
        //                                         .Replace("ACERTO DE STOCK (ENTRADA)", "ENTRADA DE PRODUTO")
        //                                         .Replace("ACERTO DE STOCK (SAIDA)", "SAIDA DE PRODUTO");

        //    if (!_acessoApp.TemAcesso(op+ "#"+nomeTipo+"#" + btn_Impressão.Text))
        //    {
        //        btn_Impressão.Visible = false;
        //    }
        //    else
        //    {
        //        btn_Impressão.Visible = true;
        //    }
        //    if (!_acessoApp.TemAcesso(op+ "#" + nomeTipo + "#" + btn_Gravar.Text))
        //    {
        //        btn_Gravar.Visible = false;
        //    }
        //    else
        //    {
        //        btn_Gravar.Visible = true;

        //    }
        //    if (!_acessoApp.TemAcesso(op+ "#" + nomeTipo + "#" + btn_Cancelar.Text))
        //    {
        //        btn_Cancelar.Visible = false;
        //    }
        //    else
        //    {
        //        btn_Cancelar.Visible = true;
        //    }
        //    if (!_acessoApp.TemAcesso(op+ "#" + nomeTipo + "#" + btn_Cliente.Text))
        //    {
        //        btn_Cliente.Visible = false;
        //    }
        //    else
        //    {
        //        btn_Cliente.Visible = true;
        //    }
        //    if (!_acessoApp.TemAcesso(op+ "#" + nomeTipo + "#" + btn_Desconto.Text))
        //    {
        //        btn_Desconto.Visible = false;
        //    }
        //    else
        //    {
        //        btn_Desconto.Visible = true;
        //    }
        //    if (!_acessoApp.TemAcesso(op+ "#" + nomeTipo + "#" + btn_Eliminar.Text))
        //    {
        //        btn_Eliminar.Visible = false;
        //    }
        //    else
        //    {
        //        btn_Eliminar.Visible = true;
        //    }
        //    if (!_acessoApp.TemAcesso(op+ "#" + nomeTipo + "#" + btn_NovoProduto.Text))
        //    {
        //        btn_NovoProduto.Visible = false;
        //    }
        //    else
        //    {
        //        btn_NovoProduto.Visible = true;
        //    }
        //    if (!_acessoApp.TemAcesso(op+ "#" + nomeTipo + "#" + btn_Preco.Text))
        //    {
        //        btn_Preco.Visible = false;
        //    }
        //    else
        //    {
        //        btn_Preco.Visible = true;
        //    }
        //    if (!_acessoApp.TemAcesso(op+ "#" + nomeTipo + "#" + btn_Quantidade.Text))
        //    {
        //        btn_Quantidade.Visible = false;
        //    }
        //    else
        //    {
        //        btn_Quantidade.Visible = true;
        //    }
        //    if (!_acessoApp.TemAcesso(op+ "#" + nomeTipo + "#" + btnDevolverDocumento.Text))
        //    {
        //        btnDevolverDocumento.Visible = false;
        //    }
        //    else
        //    {
        //        btnDevolverDocumento.Visible = true;
        //    }
        //    if (!_acessoApp.TemAcesso(op+ "#" + nomeTipo + "#" + btnTurno.Text))
        //    {
        //        btnTurno.Visible = false;
        //    }
        //    else
        //    {
        //        btnTurno.Visible = true;
        //    }
        //}

        //private void CarregarPermissoesAcesso(int acessoId)
        //{
        //    var op = "FACTURAÇÃO";
        //    if (TipoActual.Destino == Destino.Isento)
        //    {
        //        op = "ESTOQUE";
        //    }
        //    var _acessoApp = new AcessoApp();
        //    var nomeTipo = new TipoDocumentoApp().RetornaTipoDocumentoPorSigla(TipoSigla)
        //                                         .Nome
        //                                         .ToUpper()
        //                                         .Replace("ACERTO DE STOCK (ENTRADA)", "ENTRADA DE PRODUTO")
        //                                         .Replace("ACERTO DE STOCK (SAIDA)", "SAIDA DE PRODUTO");

        //    if (!_acessoApp.TemAcesso(op + "#" + nomeTipo + "#" + btn_Impressão.Text, acessoId))
        //    {
        //        btn_Impressão.Visible = false;
        //    }
        //    else
        //    {
        //        btn_Impressão.Visible = true;
        //    }
        //    if (!_acessoApp.TemAcesso(op + "#" + nomeTipo + "#" + btn_Gravar.Text, acessoId))
        //    {
        //        btn_Gravar.Visible = false;
        //    }
        //    else
        //    {
        //        btn_Gravar.Visible = true;

        //    }
        //    if (!_acessoApp.TemAcesso(op + "#" + nomeTipo + "#" + btn_Cancelar.Text, acessoId))
        //    {
        //        btn_Cancelar.Visible = false;
        //    }
        //    else
        //    {
        //        btn_Cancelar.Visible = true;
        //    }
        //    if (!_acessoApp.TemAcesso(op + "#" + nomeTipo + "#" + btn_Cliente.Text, acessoId))
        //    {
        //        btn_Cliente.Visible = false;
        //    }
        //    else
        //    {
        //        btn_Cliente.Visible = true;
        //    }
        //    if (!_acessoApp.TemAcesso(op + "#" + nomeTipo + "#" + btn_Desconto.Text, acessoId))
        //    {
        //        btn_Desconto.Visible = false;
        //    }
        //    else
        //    {
        //        btn_Desconto.Visible = true;
        //    }
        //    if (!_acessoApp.TemAcesso(op + "#" + nomeTipo + "#" + btn_Eliminar.Text, acessoId))
        //    {
        //        btn_Eliminar.Visible = false;
        //    }
        //    else
        //    {
        //        btn_Eliminar.Visible = true;
        //    }
        //    if (!_acessoApp.TemAcesso(op + "#" + nomeTipo + "#" + btn_NovoProduto.Text, acessoId))
        //    {
        //        btn_NovoProduto.Visible = false;
        //    }
        //    else
        //    {
        //        btn_NovoProduto.Visible = true;
        //    }
        //    if (!_acessoApp.TemAcesso(op + "#" + nomeTipo + "#" + btn_Preco.Text, acessoId))
        //    {
        //        btn_Preco.Visible = false;
        //    }
        //    else
        //    {
        //        btn_Preco.Visible = true;
        //    }
        //    if (!_acessoApp.TemAcesso(op + "#" + nomeTipo + "#" + btn_Quantidade.Text, acessoId))
        //    {
        //        btn_Quantidade.Visible = false;
        //    }
        //    else
        //    {
        //        btn_Quantidade.Visible = true;
        //    }
        //    if (!_acessoApp.TemAcesso(op + "#" + nomeTipo + "#" + btnDevolverDocumento.Text, acessoId))
        //    {
        //        btnDevolverDocumento.Visible = false;
        //    }
        //    else
        //    {
        //        btnDevolverDocumento.Visible = true;
        //    }
        //    if (!_acessoApp.TemAcesso(op + "#" + nomeTipo + "#" + btnTurno.Text, acessoId))
        //    {
        //        btnTurno.Visible = false;
        //    }
        //    else
        //    {
        //        btnTurno.Visible = true;
        //    }
        //}
        //private void VerificarModificaoSenha()
        //{
        //    var _usaurioApp = new UsuarioApp();
        //    if (!_usaurioApp.SenhaModificada(Globais.UsuarioIdActual))
        //    {
        //        if (!Mensagem.Questao("É obrigatorio alterar a senha deste usuário.\nPretende alterar?"))
        //        {
        //            Close();
        //            return;
        //        }
        //        if (new FormSalvaUsuario().ActualizarUsuario(Globais.UsuarioIdActual))
        //        {
        //            Globais.UsuarioActual = _usaurioApp.RetornaUsuarioPorId(Globais.UsuarioIdActual);
        //            Globais.UsuarioActual.Modificado = true;
        //            _usaurioApp.Actualizar(Globais.UsuarioActual);
        //            if (Globais.EstadoDoTurno)
        //            {
        //                Globais.TurnoActual.Usuario = Globais.UsuarioActual;
        //            }
        //        }
        //        else
        //        {
        //            Mensagem.Alerta("Não foi possível alterar usuário!");
        //            VerificarModificaoSenha();
        //        }
        //    }
        //}
        private void FormEditorDocumento_Load(object sender, EventArgs e)
        {
        //    VerificarModificaoSenha();
        //    CarregarProcessos();
        //    CarregarPermissoesAcesso();
        //    if (!TipoDocumentoFor("FR") && !TipoDocumentoFor("FT"))
        //    {
        //        btnTurno.Visible = false;
        //    }
        //    MostrarTipoDocumento();
        //    MostrarCliente();
        //    CarregarProdutosaVenda();
        }

        //private void panelNavegador_Paint(object sender, PaintEventArgs e)
        //{

        //}

        //private void btnConveteVerProdutos_Click(object sender, EventArgs e)
        //{
        //    if (navigationProdutos.SelectedPageIndex == 0)
        //    {
        //        procurarProdutos.Properties.Client = GradeProdutos;
        //        navigationProdutos.SelectedPageIndex = 1;
        //    }
        //    else
        //    {
        //        procurarProdutos.Properties.Client = GradeProdutosCartao;
        //        navigationProdutos.SelectedPageIndex = 0;
        //    }
        //}

        //private void CboEstoqute_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    CarregarProdutosaVenda();
        //}

        private void tileProdutos_ItemClick(object sender, TileViewItemClickEventArgs e)
        {
        //    var produtoSelecionado = SelecionarProduto(e.Item.RowHandle);
        //    if (!Util.ObjectoNulo(produtoSelecionado))
        //    {
        //        AdicionarProdutoNaListaMovimentacao(produtoSelecionado, 1);
        //    }
        }

        //private ProdutoEstoque SelecionarProduto(int rowHandle)
        //{
        //    var produtoEstoqueId = 0;
        //    if (navigationProdutos.SelectedPageIndex == 0)
        //    {
        //        produtoEstoqueId = Convert.ToInt32(tileProdutos.GetRowCellValue(rowHandle, "ProdutoEstoqueId"));
        //    }
        //    else
        //    {
        //        produtoEstoqueId = Convert.ToInt32(gridProdutos.GetRowCellValue(rowHandle, "ProdutoEstoqueId"));
        //    }
        //    return ProdutosVenda.Where(p => p.ProdutoEstoqueId == produtoEstoqueId).FirstOrDefault();
        //}
        //private void AdicionarProdutoNaListaMovimentacao(ProdutoEstoque produtoEstoque,decimal quantidade)
        //{
        //    if (PodeAdicionarProduto(produtoEstoque, quantidade))
        //    {
        //        CriarDocumentoSeNaoExistir();
        //        if (NaoExisteProdutoMovimentacao(produtoEstoque.ProdutoEstoqueId) || Globais.PermitirLinhasDoMesmoArtigo)
        //        {
        //            var novoProdutoMovimentaco = _ProdutoMovimentacaoApp.CriarProdutoMovimentacao(
        //                DocumentoActual.DocumentoId,
        //                produtoEstoque.ProdutoEstoqueId,
        //                quantidade
        //            );
        //            ActualizarQuantidadeProduto(produtoEstoque, quantidade);
        //            ActualizarQuantidadeProdutoComponente(produtoEstoque.ProdutoId, quantidade);
        //            ActualizarListaMovimentacao();

        //        }
        //        else
        //        {
        //            ActualizarProdutoMovNaDb(
        //                produtoEstoque.ProdutoEstoqueId,
        //                quantidade
        //            );
        //        }
        //       ActualizarTotaisDoDocumento();
        //        MostrarTotalMovimentacao();
        //        MostrarDocumento();
        //        MostrarTotais();
        //    }
        //}

        //private void MostrarDocumento()
        //{
        //    if (!NaoExisteDocumento())
        //    {
        //        lblTipoDocumento.Text = DocumentoActual.Tipo.Nome + " Nº " + DocumentoActual.NumeroOrdem;
        //    }
        //    else
        //    {
        //        lblTipoDocumento.Text = TipoActual.Nome + " Nº ";
        //    }
        //}

        //private void MostrarTotalMovimentacao()
        //{
        //    lblValorDevido.Text = Util.MostrarValorNaMoedaActual(RetornaTotalMovimentacao());
        //}
        //private void MostrarTotais()
        //{
        //    lblQuantidadeLinhasProdutos.Text = RetornaQuantidadeLinhasProdutos().ToString();
        //    lblDiscontos.Text = Util.MostrarValorNaMoedaActual(RetornaTotalDisconto());
        //    lblSubtotal.Text = Util.MostrarValorNaMoedaActual(RetornaTotalIliquidoMovimentacao());
        //    lblImposto.Text = Util.MostrarValorNaMoedaActual(RetornaTotalImposto());
        //    MostrarTotalPagamento();
        //    MostrarTotalMovimentacao();
        //}

        //private void MostrarTotalPagamento()
        //{
        //    if (NaoExisteDocumento())
        //    {
        //        lblPagamentos.Text = Util.MostrarValorNaMoedaActual(0);
        //    }
        //    else
        //    {
        //        var totalPagamentos = _PagamentoApp.RetornaTotalPagamentosPorDocumentoId(DocumentoActual.DocumentoId);
        //        lblPagamentos.Text = Util.MostrarValorNaMoedaActual(totalPagamentos);
        //    }
        //}

        //private void ActualizarProdutoMovNaDb(int produtoEstoqueId, decimal quantidade)
        //{
        //    var produtoExistente = ProdutoMovimentacoes.Where(a => a.ProdutoEstoqueId == produtoEstoqueId).FirstOrDefault();
        //    var produtoEstoque = _ProdutoEstoqueApp.RetornaProdutoPorId(produtoEstoqueId);
        //    ActualizarQuantidadeProduto(produtoEstoque, quantidade);
        //    ActualizarQuantidadeProdutoComponente(produtoEstoque.ProdutoId, quantidade);
        //    produtoExistente.Quantidade += quantidade;
        //    produtoExistente.Imposto = Util.CalcularValorImpostoArtigo(produtoExistente);
        //    produtoExistente.Retencao = Util.CalcularValorRetencaoArtigo(produtoExistente);
        //    produtoExistente.Desconto = Util.CalcularValorDescontoArtigo(produtoExistente);
        //    produtoExistente.TotaIliquido = Util.CalcularTotaIliquidoProdutoMov(produtoExistente);
        //    produtoExistente.Total = Util.CalcularTotalProdutoMov(produtoExistente);
        //    _ProdutoMovimentacaoApp.Actualizar(produtoExistente);
        //    ActualizarListaMovimentacao();
        //}

        //private void ActualizarProdutoMovNaDb(decimal valorImposto, decimal valorRetencao, decimal quantidade, decimal desconto)
        //{
        //    if (gridViewVender.RowCount > 0)
        //    {
        //        var produtoExistente = ProdutoMovimentacoes[gridViewVender.GetSelectedRows()[0]];
        //        var produtoEstoque = _ProdutoEstoqueApp.RetornaProdutoPorId(produtoExistente.ProdutoEstoqueId);
        //        ActualizarQuantidadeProduto(produtoEstoque, quantidade);
        //        ActualizarQuantidadeProdutoComponente(produtoEstoque.ProdutoId, quantidade);
        //        produtoExistente.Quantidade += quantidade;
        //        produtoExistente.Total = Util.CalcularTotalProdutoMov(produtoExistente);
        //        produtoExistente.Imposto = valorImposto;
        //        produtoExistente.Retencao = valorRetencao;
        //        produtoExistente.Desconto = desconto;
        //        _ProdutoMovimentacaoApp.Actualizar(produtoExistente);
        //        ActualizarListaMovimentacao();
        //    }
        //}
        //private void ActualizarTotaisDoDocumento()
        //{
        //    DocumentoActual.Total = RetornaTotalMovimentacao();
        //    DocumentoActual.TotalIliquido = RetornaTotalIliquidoMovimentacao();
        //    DocumentoActual.Retencao = RetornaTotalRetencao();
        //    DocumentoActual.Imposto = RetornaTotalImposto();
        //    DocumentoActual.DescontoTotal = RetornaTotalDisconto();
        //    DocumentoActual.QtdLinhas = RetornaQuantidadeLinhasProdutos();
        //    _DocumentoApp.Actualizar(DocumentoActual);
        //}

        //private decimal RetornaTotalIliquidoMovimentacao()
        //{
        //    return ProdutoMovimentacoes.Sum(pm => pm.TotaIliquido);
        //}

        //private bool NaoExisteProdutoMovimentacao(int produtoEstoqueId)
        //{
        //    return ProdutoMovimentacoes.Where(pm => pm.ProdutoEstoqueId == produtoEstoqueId).FirstOrDefault() == null;
        //}

        //private void ActualizarQuantidadeProduto(ProdutoEstoque produtoEstoque, decimal quantidade)
        //{
        //    if (TipoActual.Estoque == MovEstoque.Debita)
        //    {
        //        produtoEstoque.Quantidade -= quantidade;
        //        _ProdutoEstoqueApp.Actualizar(produtoEstoque);
        //    }
        //}
        //private void ActualizarQuantidadeProdutoComponente(int produtoId, decimal qtd)
        //{
        //    if (TipoActual.Estoque == MovEstoque.Debita)
        //    {
        //        var produtoComps = _ProdutoCompApp.RetornaProdutosCompsPorProdutoId(produtoId);
        //        foreach (var comp in produtoComps)
        //        {
        //            var artigoInvNaComposicao = _ProdutoEstoqueApp.CarregarProdutosDisponivel(comp.ProdutoComponenteId);
        //            artigoInvNaComposicao.Quantidade -= qtd * comp.Quantidade;
        //            _ProdutoEstoqueApp.Actualizar(artigoInvNaComposicao);
        //        }
        //    }
        //}

        //private void ActualizarListaMovimentacao()
        //{
        //    if (!NaoExisteDocumento())
        //    {
        //        ProdutoMovimentacoes = null;
        //        ProdutoMovimentacoes = _ProdutoMovimentacaoApp.RetornaProdutosMovPorDocumentoId(DocumentoActual.DocumentoId);

        //        gradeProdutosVender.DataSource = null;
        //        gradeProdutosVender.DataSource = ProdutoMovimentacoes;
        //    }
        //}
        //private void CriarDocumentoSeNaoExistir()
        //{
        //    if (NaoExisteDocumento())
        //    {
        //        DocumentoActual = _DocumentoApp.CriarDocumento(new Documento()
        //        {
        //            ClienteId = ClienteActual.ClienteId,
        //            DataFacturacao = DateTime.Now,
        //            DataVencimento = Util.RetornaDataVencime(30),
        //            DescontoTotal = RetornaTotalDisconto(),
        //            Estado = EstadoDocumento.Aberto,
        //            EstadoImpressao = EstadoImpressao.NaoImprimido,
        //            Imposto = RetornaTotalImposto(),
        //            NomeCliente = ClienteActual.Nome,
        //            Retencao = RetornaTotalRetencao(),
        //            TipoDocumentoId = TipoActual.TipoDocumentoId,
        //            TurnoId = Globais.TurnoActual.TurnoId,
        //            Tipo = TipoActual
        //        });
        //        MostrarDocumento();
        //    }
        //}

        //private decimal RetornaTotalRetencao()
        //{
        //    return ProdutoMovimentacoes.Sum(pm => pm.Retencao * pm.Quantidade);
        //}

        //private decimal RetornaTotalImposto()
        //{
        //    return ProdutoMovimentacoes.Sum(pm => pm.Imposto * pm.Quantidade);
        //}

        //private decimal RetornaTotalDisconto()
        //{
        //    return ProdutoMovimentacoes.Sum(pm => pm.Desconto * pm.Quantidade);
        //}

        //private decimal RetornaDescontaGlobal()
        //{
        //    return NaoExisteDocumento() ? 0 : DocumentoActual.DescontoGlobal;
        //}

        //private bool NaoExisteDocumento()
        //{
        //    return Util.ObjectoNulo(DocumentoActual) || DocumentoActual.DocumentoId <= 0;
        //}

        //private bool PodeAdicionarProduto(ProdutoEstoque produtoEstoque, decimal quantidade)
        //{
        //    if (TipoActual.Sigla == "FT")
        //    {
        //        if (ConsumidorFinal())
        //        {
        //            Mensagem.Alerta("Selecione um Cliente que não seja " + ClienteActual.Nome);
        //            return false;

        //        }
        //        if (PassouDoLimiteDeCredito(produtoEstoque.Produto.Preco * quantidade))
        //        {
        //            Mensagem.Alerta("Passou do debito limite do Cliente " + ClienteActual.Nome);
        //            return false;
        //        } 
        //    }
        //    if (produtoEstoque.Produto.ControleEstoque)
        //    {
        //        if ( produtoEstoque.UmLote && (produtoEstoque.DataDeExpiracao - DateTime.Now).Days == 0)
        //        {
        //            Mensagem.Alerta("Este produto já passou do prazo de validade!");
        //            return false;
        //        }
        //        if (TipoActual.Estoque == MovEstoque.Debita)
        //        {
        //            if (produtoEstoque.Quantidade - produtoEstoque.QuantidadeMinima < quantidade)
        //            {
        //                Mensagem.Alerta("Produto com quantidade em estoque insuficiente para venda!");
        //                return false;
        //            }
        //            if(ProdutoComponenteInsuficiente(produtoEstoque, quantidade))
        //            {
        //                Mensagem.Alerta("Quantidade de artigos Componente no inventario é insuficiente!");
        //                return false;
        //            }
        //        }
        //        if (TipoActual.Estoque == MovEstoque.Credita)
        //        {
        //            if (produtoEstoque.QuantidadeMaxima < quantidade)
        //            {
        //                Mensagem.Alerta("Este quantidade de produto excede o limite de quantidade permitidade neste estoque!");
        //                return false;
        //            }
        //        }
        //        if (_DocumentoApp.DataUltimoDocumentoMaiorDataActual())
        //        {
        //            Mensagem.Alerta("A data do ultimo documento criado não \npode ser maior que a data actual!");
        //            return false;
        //        }
        //    }
        //    return true;
        //}
        //private bool ProdutoComponenteInsuficiente(ProdutoEstoque produtoEstoque, decimal quantidadeAdicionar)
        //{
        //    var produtoComps = _ProdutoCompApp.RetornaProdutosCompsPorProdutoId(produtoEstoque.ProdutoId);

        //    var resultWhere = produtoComps.Where(
        //        a => a.Quantidade * quantidadeAdicionar <= RetornaQuantidadeDisponivel(a.ProdutoComponenteId)).ToList();
        //    return produtoComps.Count != resultWhere.Count;
        //}

        //private decimal RetornaQuantidadeDisponivel(int produtoComponenteId)
        //{
        //    var produtoEstoqueDisponivel = _ProdutoEstoqueApp.CarregarProdutosDisponivel(produtoComponenteId);
        //    return produtoEstoqueDisponivel.Quantidade - produtoEstoqueDisponivel.QuantidadeMinima;
        //}

        //private bool PassouDoLimiteDeCredito(decimal precoProduto)
        //{
        //    if (ClienteActual.DebitoLimite > 0 && ClienteActual.DebitoLimite < RetornaTotalMovimentacao() + precoProduto)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        //private decimal RetornaTotalMovimentacao()
        //{
        //    return ProdutoMovimentacoes.Sum(pm => pm.Total);
        //}

        //private bool ConsumidorFinal()
        //{
        //    return ClienteActual.Nome == Globais.ClientePadrao;
        //}

        //private void gridProdutos_RowCellClick(object sender, RowCellClickEventArgs e)
        //{
        //    var produtoSelecionado = SelecionarProduto(e.RowHandle);
        //    if (!Util.ObjectoNulo(produtoSelecionado))
        //    {
        //        AdicionarProdutoNaListaMovimentacao(produtoSelecionado, 1);
        //    }
        //}

        private void txtCodigoBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
        //    if (e.KeyChar == '\r')
        //    {
        //        if (string.IsNullOrEmpty(txtCodigoBarra.Text))
        //        {
        //            Mensagem.Alerta("O campo código de barra está vazio!");
        //            return;
        //        }

        //        var produtoSelecionado = SelecionarProdutoPorCodigo(txtCodigoBarra.Text);
        //        if (!Util.ObjectoNulo(produtoSelecionado))
        //        {
        //            AdicionarProdutoNaListaMovimentacao(produtoSelecionado, 1);
        //        }
        //        else
        //        {
        //            Mensagem.Alerta("Não encontrou um produto com este código de barra!");
        //        }
        //    }
        }

        //private ProdutoEstoque SelecionarProdutoPorCodigo(string codigoDeBarra)
        //{
        //    return ProdutosVenda.Where(p => !(p.Produto is null) && p.Produto.CodigoDeBarra == codigoDeBarra).FirstOrDefault();
        //}
        //private bool ImprimirFactura()
        //{
        //    var imprimido = new FormImprimir().SetDescricao(TipoActual.Nome)
        //                      .PrintReport(new ReportFactura(DocumentoActual.DocumentoId), true);
        //    DocumentoActual = _DocumentoApp.RetornaDocumentoPorId(DocumentoActual.DocumentoId);
        //    if (imprimido)
        //    {
        //        DocumentoActual.EstadoImpressao = Util.VerMudarEstadoImpresao(DocumentoActual.EstadoImpressao);
        //        _DocumentoApp.Actualizar(DocumentoActual);
        //    }
        //    return true;
        //}

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
        //    if (PodeFinalizarVenda())
        //    {
        //        InicializarAplicacoes();
        //        SalvarDocumento(EstadoDocumento.Fechado);
        //    }
        }
        //private void SalvarDocumento(EstadoDocumento estado)
        //{
        //    ActualizarTotaisDoDocumento();
        //    GravarEntradaProduto();
        //    var fecharDocumento = false;
        //    if (TipoActual.Sigla == "FR")
        //    {
        //        fecharDocumento = PagarImprimirFacturaRecibo();
        //    }
        //    else
        //    {
        //        fecharDocumento = ImprimirFactura();
        //    }
        //    if (fecharDocumento)
        //    {
        //        MudarEstadoDoc(estado);
        //        TerminarMovimetacao();
        //        Editado = true;
        //    }
        //}
        //private bool PagarImprimirFacturaRecibo()
        //{
        //    if (PedirParaClientInserirNome())
        //    {
        //        if ( DocumentoPago() || new FormPagamento().Efectuar(DocumentoActual.DocumentoId))
        //        {
        //            var imprimido = new FormImprimir().SetDescricao(TipoActual.Nome)
        //                              .PrintReport(new ReportFactura(DocumentoActual.DocumentoId), true);
        //            DocumentoActual = _DocumentoApp.RetornaDocumentoPorId(DocumentoActual.DocumentoId);
        //            if (imprimido)
        //            {
        //                DocumentoActual.EstadoImpressao = Util.VerMudarEstadoImpresao(DocumentoActual.EstadoImpressao);
        //                _DocumentoApp.Actualizar(DocumentoActual);
        //            }
        //            return true;
        //        }
        //        else
        //        {
        //            Mensagem.Alerta("Não foi possível efectuar o pagamento");
        //        }
        //    }
        //    return false;
        //}

        //private bool DocumentoPago()
        //{
        //    return _PagamentoApp.RetornaTotalPagamentosPorDocumentoId(DocumentoActual.DocumentoId) > 0;
        //}

        //private bool PedirParaClientInserirNome()
        //{
        //    if (TipoDocumentoFor("FR"))
        //    {
        //        var nomeCliente = string.IsNullOrEmpty(DocumentoActual.NomeCliente) ? ClienteActual.Nome : DocumentoActual.NomeCliente;
        //        var resultClient = new FormDescricao().GetDescricao("Nome Do Cliente", nomeCliente);
        //        if (resultClient.Resultado == DialogResult.OK)
        //        {
        //            DocumentoActual.NomeCliente = resultClient.Valor;
        //            if (DocumentoActual.ClienteId != ClienteActual.ClienteId)
        //            {
        //                DocumentoActual.ClienteId = ClienteActual.ClienteId;
        //            };
        //            //_DocumentoApp.Actualizar(DocumentoActual);
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        //private void GravarEntradaProduto()
        //{
        //    if (TipoActual.Estoque == MovEstoque.Credita)
        //    {
        //        foreach (ProdutoMovimentacao produtoMov in ProdutoMovimentacoes)
        //        {
        //            var produtoEstoque = _ProdutoEstoqueApp.RetornaProdutoPorId(produtoMov.ProdutoEstoqueId);
        //            produtoEstoque.Quantidade += produtoMov.Quantidade;
        //            _ProdutoEstoqueApp.Actualizar(produtoEstoque);
        //        }
        //    }
        //}
        //private bool PodeFinalizarVenda()
        //{
        //    if (RetornaQuantidadeLinhasProdutos() <= 0)
        //    {
        //        Mensagem.Alerta("Adicione alguns produtos a lista de produtos de venda para finalizar a venda");
        //        return false;
        //    }
        //    if (TipoDocumentoFor("FT") && ClienteForConsumidorFinal())
        //    {
        //        Mensagem.Alerta("Selecione um cliente diferente de " + ClienteActual.Nome +
        //                    " para poder finalizar a venda");
        //        return false;
        //    }
        //    return true;
        //}

        //private bool ClienteForConsumidorFinal()
        //{
        //    return ClienteActual.Nome == Globais.ClientePadrao;
        //}

        //private bool TipoDocumentoFor(string sigla)
        //{
        //    return TipoActual.Sigla == sigla;
        //}

        //private int RetornaQuantidadeLinhasProdutos()
        //{
        //    return Util.ListaNula(ProdutoMovimentacoes) ? 0 : ProdutoMovimentacoes.Count;
        //}

        //private void btnLigarCliente_Click(object sender, EventArgs e)
        //{
        //    Mensagem.Alerta("Tel: " + ClienteActual.Telefone);
        //}

        //private void btnMensagemCliente_Click(object sender, EventArgs e)
        //{

        //    Mensagem.Alerta("E-mail: " + ClienteActual.Email);
        //}
        //private void CancelarDocumentoActual()
        //{
        //    var result = new FormMotivoAnularDocumento().GetMotivoAnulacaoDoc();
        //    if (result.Resultado ==  DialogResult.OK)
        //    {

        //        DevolverTodosProdutoMovs();
        //        _DocAnuladoApp.Adicionar(new DocumentoAnulado()
        //        {
        //            DocumentoId = DocumentoActual.DocumentoId,
        //            Data = DateTime.Now,
        //            Motivo = result.Valor
        //        });
        //        SalvarDocAnulado();
        //        Editado = true;
        //        Mensagem.Alerta("Doumento Anulado com sucesso");
        //    }
        //}
        //private void SalvarDocAnulado()
        //{
        //    TerminarMovimetacao();
        //    var documentoId = DocumentoActual.DocumentoId;
        //    MudarEstadoDoc(EstadoDocumento.Anulado);
        //    var imprimido = new FormImprimir().PrintReport(new ReportFactura(documentoId), true);
        //    if (imprimido)
        //    {
        //        DocumentoActual.EstadoImpressao = Util.VerMudarEstadoImpresao(DocumentoActual.EstadoImpressao);
        //        _DocumentoApp.Actualizar(DocumentoActual);
        //    }

        //}

        //private void MudarEstadoDoc(EstadoDocumento estado)
        //{
        //    DocumentoActual.Estado = estado;
        //    _DocumentoApp.Actualizar(DocumentoActual);
        //    DocumentoActual = null;
        //    MostrarDocumento();
        //}

        //private void OpcaoDocumentoAberto()
        //{
        //    //panelEditionArtigoMov.Visible = true;
        //    btnDevolverDocumento.Enabled = false;
        //    btn_Impressão.Enabled = false;
        //    btn_Cliente.Enabled = true;
        //    panelArtigos.Enabled = true;
        //    txtCodigoBarra.Enabled = true;
        //    //btnLotes.Visible = false;
        //    btn_Cancelar.Enabled = true;
        //    btn_Gravar.Enabled = true;
        //    //btnDeixarPendente.Visible = false;
        //    //btnCopiarLinhas.Visible = false;
        //}
        //private void OpcaoDocumentoFechado()
        //{
        //    btnDevolverDocumento.Enabled = true;
        //    btn_Impressão.Enabled = true;
        //    btn_Cliente.Enabled = false;
        //    panelArtigos.Enabled = false;
        //    txtCodigoBarra.Enabled = false;
        //    btn_Cancelar.Enabled = false;
        //    btn_Gravar.Enabled = false;
        //    btn_Cliente.Enabled = false;
        //    btn_Desconto.Enabled = false;
        //    btn_Eliminar.Enabled = false;
        //    btn_NovoProduto.Enabled = false;
        //    btn_Preco.Enabled = false;
        //    btn_Produtos.Enabled = false;
        //    btn_Quantidade.Enabled = false;
        //}
        //private void OpcaoDocumentoAnulado()
        //{
        //    //panelEditionArtigoMov.Visible = false;
        //    btnDevolverDocumento.Enabled = false;
        //    btn_Impressão.Enabled = true;
        //    btn_Cliente.Enabled = false;
        //    panelArtigos.Enabled = false;
        //    txtCodigoBarra.Enabled = false;
        //    //btnLotes.Visible = false;
        //    btn_Cancelar.Enabled = false;
        //    btn_Gravar.Enabled = false;
        //    btn_Cliente.Enabled = false;
        //    btn_Desconto.Enabled = false;
        //    btn_Eliminar.Enabled = false;
        //    btn_NovoProduto.Enabled = false;
        //    btn_Preco.Enabled = false;
        //    btn_Produtos.Enabled = false;
        //    btn_Quantidade.Enabled = false;
        //}

        //private void DevolverTodosProdutoMovs()
        //{
        //    foreach (var artigo in ProdutoMovimentacoes)
        //    {
        //        DevolverQtdProdutoMovParaEstoque(artigo);
        //    }
        //    //ArtigosMovimentar.Clear();
        //}
        //private void DevolverQtdProdutoMovParaEstoque(ProdutoMovimentacao produtoDevolver)
        //{

        //    var produtoEstoqueNoMov = _ProdutoEstoqueApp.RetornaProdutoPorId(produtoDevolver.ProdutoEstoqueId);
        //    ActualizarQuantidadeProduto(produtoEstoqueNoMov, -1 * produtoDevolver.Quantidade);
        //    ActualizarQuantidadeProdutoComponente(produtoEstoqueNoMov.ProdutoId, -1 * produtoDevolver.Quantidade);

        //}
        //private void TerminarMovimetacao()
        //{
        //    LimparGradeMovimentar();
        //    MostrarTotais();
        //    ClienteActual = _ClienteApp.BuscaTipoEntidadePadrao();
        //    MostrarCliente();
        //    MostrarDocumento();
        //}

        //private void LimparGradeMovimentar()
        //{
        //    ProdutoMovimentacoes.Clear();
        //    gradeProdutosVender.DataSource = null;
        //}

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
        //    if (PodeCancelarDocumento())
        //    {
        //        InicializarAplicacoes();
        //        CancelarDocumentoActual();
        //        Editado = true;
        //    }
        }

        //private bool PodeCancelarDocumento()
        //{
        //    if (NaoExisteDocumento())
        //    {
        //        Mensagem.Alerta("Não é possível anular um documento inexistente!");
        //        return false;
        //    }
        //    return true;
        //}

        //private void btn_Cliente_Click(object sender, EventArgs e)
        //{
        //    var novoClienteActual = new FormListagemTabela<Cliente>().BuscaRegistroSelecionado();
        //    if (!Util.ObjectoNulo(novoClienteActual))
        //    {
        //        ClienteActual = novoClienteActual;
        //        MostrarCliente();
        //    }
        //}

        private void btn_Desconto_Click(object sender, EventArgs e)
        {
        //    if (gridViewVender.RowCount > 0)
        //    {
        //        var produtoMovSelecionado = ProdutoMovimentacoes[gridViewVender.GetSelectedRows()[0]];
        //        var resultado = new FormNumero().RetornaValor(produtoMovSelecionado.DescontoPercentagem);

        //        if (resultado.Valor < 0)
        //        {
        //            resultado.Valor = 0;
        //        }
        //        else if (resultado.Valor > 100)
        //        {
        //            resultado.Valor = 100;
        //        }
        //        InicializarAplicacoes();
        //        produtoMovSelecionado.DescontoPercentagem = resultado.Valor;
        //        produtoMovSelecionado.Desconto = Util.CalcularValorDescontoArtigo(produtoMovSelecionado);
        //        produtoMovSelecionado.TotaIliquido = Util.CalcularTotaIliquidoProdutoMov(produtoMovSelecionado);
        //        produtoMovSelecionado.Total = Util.CalcularTotalProdutoMov(produtoMovSelecionado);
        //        _ProdutoMovimentacaoApp.Actualizar(produtoMovSelecionado);
        //        ActualizarListaMovimentacao();
        //        ActualizarTotaisDoDocumento();
        //        MostrarTotalMovimentacao();
        //        MostrarDocumento();
        //        MostrarTotais();
        //    }
        //    else
        //    {
        //        Mensagem.Alerta("Adicione produto a lista de Venda para poder alterar seu desconto");
        //    }
        }

        private void btn_Preco_Click(object sender, EventArgs e)
        {
        //    if (gridViewVender.RowCount > 0) 
        //    { 
        //        var produtoMovSelecionado = ProdutoMovimentacoes[gridViewVender.GetSelectedRows()[0]];
        //        var resultado = new FormNumero().RetornaValor(produtoMovSelecionado.Preco);
        //        if (PodeMudarPreco(produtoMovSelecionado, resultado.Valor))
        //        {
        //            InicializarAplicacoes();
        //            produtoMovSelecionado.Preco = resultado.Valor;
        //            produtoMovSelecionado.Total = Util.CalcularTotalProdutoMov(produtoMovSelecionado);
        //            produtoMovSelecionado.Imposto = Util.CalcularValorImpostoArtigo(produtoMovSelecionado);
        //            _ProdutoMovimentacaoApp.Actualizar(produtoMovSelecionado);
        //            ActualizarListaMovimentacao();
        //            ActualizarTotaisDoDocumento();
        //            MostrarTotalMovimentacao();
        //            MostrarDocumento();
        //            MostrarTotais();
        //        }
        //    }
        //    else
        //    {
        //        Mensagem.Alerta("Adicione produto a lista de Venda para poder alterar seu preço");
        //    }
        }

        //private bool PodeMudarPreco(ProdutoMovimentacao produtoMov, decimal preco)
        //{
        //    if (TipoActual.Sigla == "FT")
        //    {
        //        if (ConsumidorFinal())
        //        {
        //            Mensagem.Alerta("Selecione um Cliente que não seja " + ClienteActual.Nome);
        //            return false;

        //        }
        //        if (PassouDoLimiteDeCredito(produtoMov.Quantidade * preco))
        //        {
        //            Mensagem.Alerta("Passou do debito limite do Cliente " + ClienteActual.Nome);
        //            return false;
        //        }
        //    }

        //    return true;
        //}

        private void btn_Quantidade_Click(object sender, EventArgs e)
        {
        //    if(gridViewVender.RowCount > 0)
        //    { 
        //        var produtoMovSelecionado = ProdutoMovimentacoes[gridViewVender.GetSelectedRows()[0]];
        //        var resultado = new FormNumero().RetornaValor(produtoMovSelecionado.Quantidade);
        //        produtoMovSelecionado.ProdutoEstoque.Quantidade += produtoMovSelecionado.Quantidade;
        //        if (PodeMudarQuantidade(produtoMovSelecionado.ProdutoEstoque, resultado.Valor))
        //        {
        //            InicializarAplicacoes();
        //            if (TipoActual.Estoque == MovEstoque.Debita)
        //            {
        //                produtoMovSelecionado.ProdutoEstoque.Quantidade -= resultado.Valor;
        //                ActualizarQuantidadeProdutoComponente(produtoMovSelecionado.ProdutoEstoque.ProdutoId, -1*produtoMovSelecionado.Quantidade);
        //                ActualizarQuantidadeProdutoComponente(produtoMovSelecionado.ProdutoEstoque.ProdutoId, resultado.Valor);
        //            }
        //            else
        //            {
        //                produtoMovSelecionado.ProdutoEstoque.Quantidade -= produtoMovSelecionado.Quantidade;
        //            }
        //            produtoMovSelecionado.Quantidade = resultado.Valor;
        //            produtoMovSelecionado.Total = Util.CalcularTotalProdutoMov(produtoMovSelecionado);
        //            _ProdutoMovimentacaoApp.Actualizar(produtoMovSelecionado);
        //            ActualizarListaMovimentacao();
        //            ActualizarTotaisDoDocumento();
        //            MostrarTotalMovimentacao();
        //            MostrarDocumento();
        //            MostrarTotais();
        //        }
        //    }
        //    else
        //    {
        //        Mensagem.Alerta("Adicione produto a lista de Venda para poder alterar seu desconto");
        //    }
        }

        //private bool PodeMudarQuantidade(ProdutoEstoque produtoEstoque, decimal quantidade)
        //{
        //    if (produtoEstoque.Produto.ControleEstoque)
        //    {
        //        //    if((produtoEstoque.DataDeExpiracao - DateTime.Now).Days == 0)
        //        //    {
        //        //        Mensagem.Alerta("Este produto já passou do prazo de validade!");
        //        //        return false;
        //        //    }
        //        if (TipoActual.Estoque == MovEstoque.Debita)
        //        {
        //            if (produtoEstoque.Quantidade - produtoEstoque.QuantidadeMinima < quantidade)
        //            {
        //                Mensagem.Alerta("Produto com quantidade em estoque insuficiente para venda!");
        //                return false;
        //            }
        //            if (ProdutoComponenteInsuficiente(produtoEstoque, quantidade))
        //            {
        //                Mensagem.Alerta("Quantidade de produtos Componente no inventario é insuficiente!");
        //                return false;
        //            }
        //        }
        //        if (TipoActual.Estoque == MovEstoque.Credita)
        //        {
        //            if (produtoEstoque.QuantidadeMaxima < quantidade)
        //            {
        //                Mensagem.Alerta("Este quantidade de produto excede o limite de quantidade permitidade neste estoque!");
        //                return false;
        //            }
        //        }
        //    }
        //    return true;
        //}

        private void btn_NovoProduto_Click(object sender, EventArgs e)
        {
        //    if (new FormSalvaProduto().AdicionarProduto())
        //    {
        //        InicializarAplicacoes();
        //        CarregarProdutosaVenda();
        //    }
        }

        private void btn_Impressão_Click(object sender, EventArgs e)
        {
        //    if (!NaoExisteDocumento())
        //    {
        //        ImprimirFactura();
        //    }
        //    else
        //    {
        //        Mensagem.Alerta("Não é possível imprimir um documento inexistente!");
        //    }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
        //    if (PodeEliminarProduto())
        //    {
        //        InicializarAplicacoes();
        //        DeleteArtigoInListMov(gridViewVender.GetSelectedRows()[0]);
        //    }
        }

        //private bool PodeEliminarProduto()
        //{
        //    if (Util.ListaNula(ProdutoMovimentacoes))
        //    {
        //        Mensagem.Alerta("Não é possível eliminar produto!");
        //        return false;
        //    }
        //    return true;
        //}

        //private void DeleteArtigoInListMov(int produtoMovIndex)
        //{
        //    if (Mensagem.TemCerteza())
        //    {
        //        var produtoRemover = ProdutoMovimentacoes[produtoMovIndex];
        //        DeleteArtigoInListMov(produtoRemover);

        //        ActualizarListaMovimentacao();
        //        ActualizarTotaisDoDocumento();
        //        MostrarTotais();
        //    }

        //}
        //private void DeleteArtigoInListMov(ProdutoMovimentacao produtoRemover)
        //{
        //    DevolverQtdProdutoMovParaEstoque(produtoRemover);
        //    _ProdutoMovimentacaoApp.Remover(_ProdutoMovimentacaoApp.RetornaProdutoMovimentaoPorId(produtoRemover.ProdutoMovimentacaoId));
        //}

        private void btnDevolverDocumento_Click(object sender, EventArgs e)
        {
        //    if (!NaoExisteDocumento())
        //    {
        //        InicializarAplicacoes();
        //        if (DocumentoActual.Tipo.Financeiro ==  MovFinanceiro.Credito)
        //        {
        //            DevolverArtigos();
        //        }
        //        else
        //        {
        //            CancelarDocumentoActual();
        //        }
        //    }
        //    else
        //    {
        //        Mensagem.Alerta("Não existe um documento!");
        //    }
        }
        //private void DevolverArtigos()
        //{
        //    if (new FormDevolverDocumento().DevolverArtigoDoc(DocumentoActual.DocumentoId))
        //    {
        //        var documentoId = DocumentoActual.DocumentoId;
        //        DocumentoActual = null;
        //        DocumentoActual = _DocumentoApp.RetornaDocumentoPorId(documentoId);
        //        MudarOpcoesEstadoDocumento();
        //        ActualizarListaMovimentacao();
        //        ActualizarTotaisDoDocumento();
        //        MostrarTotais();
        //        MostrarDocumento();
        //        Editado = true;
        //    }
        //}

        //private void btnTurno_Click(object sender, EventArgs e)
        //{
        //    navigationFrame1.SelectedPage = navigationPage_Turno;
        //    if (navigationPage_Turno.Controls.Count == 0)
        //    {
        //        Util.ShowFormInPanel(navigationPage_Turno.Controls, new FormTurnoDoUsuario());
        //    }
        //}

        //private void btnVenda_Click(object sender, EventArgs e)
        //{
        //    if (Globais.EstadoDoTurno)
        //    {
        //        navigationFrame1.SelectedPage = navigationPage_PostoVenda;
        //    }
        //    else
        //    {
        //        if (Mensagem.Questao("Não pode efectuar esta operação sem abrir turno.\nPretende abrir turno?"))
        //        {
        //            if (new FormAbrirTurno().AbrirTurno())
        //            {
        //                Mensagem.Alerta("Turno aberto com sucesso!");
        //                navigationFrame1.SelectedPage = navigationPage_PostoVenda;
        //            }
        //            else
        //            {
        //                if(Mensagem.Questao("Não foi possível abrir turno.\nPretende sair da tela de facturação?"))
        //                {
        //                    Close();
        //                }
        //            }
        //        }
        //        else
        //        {
        //            Close();
        //        }
        //    }
        //}

        //private void btnMudarAcesso_Click(object sender, EventArgs e)
        //{
        //    if (btnMudarAcesso.Text == "PERMITIR ACESSOS")
        //    {
        //        var resultado = new FormMudaPermssaAcesso().MostrarFormVerificacaoDeAcesso();
        //        if (resultado.Resultado == DialogResult.OK)
        //        {
        //            var usuarioTmp = new UsuarioApp().RetornaUsuarioPorId(resultado.Valor.UsuarioId);
        //            CarregarPermissoesAcesso(usuarioTmp.AcessoId);
        //            btnMudarAcesso.Text = "FECHAR ACESSOS";
        //            btnMudarAcesso.ImageOptions.SvgImage = Properties.Resources.Padlock_Azul;
        //        }
        //    }
        //    else
        //    {
        //        CarregarPermissoesAcesso();
        //        btnMudarAcesso.Text = "PERMITIR ACESSOS";
        //        btnMudarAcesso.ImageOptions.SvgImage = Properties.Resources.Locked;
        //    }
        //}

        private void btnCliente_Click(object sender, EventArgs e)
        {

        }
    }
}