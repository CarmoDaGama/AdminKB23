using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using AdminKB.Aplicacoes;
using AdminKB.Formularios.Documentos;
using AdminKB.Formularios.Impressoes;
using Dominio.Modelos;
using AdminKB.Relatorios;
using Dominio.Utilitarios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Dominio.Enumerados;

namespace AdminKB.Formularios.Usuarios
{
    public partial class FormTurnoDoUsuario : XtraForm
    {
        private TurnoApp _TurnoApp;
        private DocumentoApp _DocumentoApp;
        private PagamentoApp _PagamentoApp;
        private ProdutoMovimentacaoApp _ProdutoMovApp;
        private FormaPagaApp _FormaPagaApp;

        private Turno TurnoActual { get; set; }
        private List<Documento> DocumentosNoTurno { get;  set; }
        private List<FormaPaga> PagamentosNoTurno { get; set; }
        private List<ProdutoMovimentacao> ProdutoMovitacoesNoTurno { get; set; }
        public bool EstadoTurno { get; private set; }

        public FormTurnoDoUsuario()
        {
            InitializeComponent();
            IniciarAplicacoes();
        }

        private void CarregarProcessos()
        {
            lblTotalImpostoPercentual.Text = lblTotalImpostoPercentual.Text.Replace("7", Globais.ImpostoPadrao.Percentagem.ToString());
            CarregarTurno();
            CarregarDocumentosNoTurno();
            CarregarPagamentos();
            CarregarProdutosMovidos();
            CarregarOperacoesRecentes();
            CarregarPermissoesAcesso();
            RenderizarForm();
        }

        private void CarregarPermissoesAcesso()
        {
            var _acessoApp = new AcessoApp();

            if (!_acessoApp.TemAcesso("INICIO#TURNO#" + pageDocumentos.Caption))
            {
                pageDocumentos.PageVisible = false;
            }

            if (!_acessoApp.TemAcesso("INICIO#TURNO#" + pageFinanca.Caption))
            {
                pageFinanca.PageVisible = false;
            }
            if (!_acessoApp.TemAcesso("INICIO#TURNO#" + pageProdutosFacturados.Caption))
            {
                pageProdutosFacturados.PageVisible = false;
            }

            if (!_acessoApp.TemAcesso("INICIO#TURNO#" + btnConfirmarTurno.Caption))
            {
                btnConfirmarTurno.Visibility = BarItemVisibility.Never;
            }
            if (!_acessoApp.TemAcesso("INICIO#TURNO#" + btnTurnOpen.Caption))
            {
                btnTurnOpen.Visibility = BarItemVisibility.Never;
            }
            if (!_acessoApp.TemAcesso("INICIO#TURNO#" + btnTurnClose.Caption))
            {
                btnTurnClose.Visibility = BarItemVisibility.Never;
            }
        }

        private void CarregarOperacoesRecentes()
        {
            if (ExisteTurno())
            {
                gradeOperacoesRecentes.DataSource = _DocumentoApp.RetornaOperacoesRecetesPorTurnoId(TurnoActual.TurnoId);
            }
        }

        private void RenderizarForm()
        {
            if (ExisteTurno())
            {
                if (TurnoActual.Estado)
                {
                    btnConfirmarTurno.Enabled = false;
                    btnTurnClose.Enabled = true;
                    btnTurnOpen.Enabled = false;
                }
                else
                {
                    if (TurnoActual.Confirmado)
                    {
                        btnConfirmarTurno.Enabled = false;
                        btnConfirmarTurno.Caption = "CONFIRMADO";
                        //btnConfirmarTurno.Visibility = BarItemVisibility.Always;
                    }
                    else
                    {
                        btnConfirmarTurno.Enabled = true;
                    }
                    btnTurnClose.Enabled = false;
                    btnTurnOpen.Enabled = false;
                }
            }
            else
            {
                btnConfirmarTurno.Enabled = false;
                btnTurnClose.Enabled = false;
                btnTurnOpen.Enabled = true;
            }
        }

        public bool MostrarTurno(int turnoId)
        {
            TurnoActual = _TurnoApp.RetornaTurnoPorId(turnoId);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            ShowDialog();
            return EstadoTurno;
        }

        private void CarregarProdutosMovidos()
        {
            if (!(TurnoActual is null))
            {
                ProdutoMovitacoesNoTurno = _ProdutoMovApp.RetornaProdutosMovPorTurnoId(TurnoActual.TurnoId);
                gradeProdutosVender.DataSource = null;
                gradeProdutosVender.DataSource = ProdutoMovitacoesNoTurno;
                CalcularTotaisDosProdutosMovidos();
            }
        }

        private void CalcularTotaisDosProdutosMovidos()
        {
            if (!Util.ListaNula(ProdutoMovitacoesNoTurno))
            {
                txtTotalProdutosVendidos.Text = Util.MostrarValorNaMoedaActual(RetornaTotalProdutosVendidos());
                txtRetencao.Text = Util.MostrarValorNaMoedaActual(RetornaTotalRetencao());
                txtQuantidadeProdutos.Text = RetornaQuantidadeProdutosVendidos().ToString();
                txtTotalImpostoPercentual.Text = Util.MostrarValorNaMoedaActual(RetornaImposto());
            }
        }

        private decimal RetornaImposto()
        {
            return ProdutoMovitacoesNoTurno.Sum(pm => Util.CalcularValorImpostoArtigo(pm));
        }

        private decimal RetornaQuantidadeProdutosVendidos()
        {
            return ProdutoMovitacoesNoTurno.Sum(pm => pm.Quantidade);
        }

        private decimal RetornaTotalRetencao()
        {
            return ProdutoMovitacoesNoTurno.Sum(pm => Util.CalcularValorRetencaoArtigo(pm));
        }

        private decimal RetornaTotalProdutosVendidos()
        {
            return ProdutoMovitacoesNoTurno.Sum(pm => pm.Total);
        }

        private void CarregarPagamentos()
        {
            if (ExisteTurno())
            {
                PagamentosNoTurno = _FormaPagaApp.RetornaFormaPagamentosEfectuadasPorTurnoId(TurnoActual.TurnoId);
                gradePagamentos.DataSource = PagamentosNoTurno;
            }
        }

        private void CarregarDocumentosNoTurno()
        {
            if (ExisteTurno())
            {
                DocumentosNoTurno = _DocumentoApp.RetornaDocumentosPorTurnoId(TurnoActual.TurnoId);
                gradeDocumentos.DataSource = DocumentosNoTurno;
                if (!Util.ListaNula(DocumentosNoTurno))
                {
                    txtTotalCredito.Text = "TOTAL CREDITO: " + Util.MostrarValorNaMoedaActual(RetornaTotalDocumentoCredito());
                    txtTotalDebito.Text = "TOTAL DEBITO: " + Util.MostrarValorNaMoedaActual(RetornaTotalDocumentoDebito());
                }
            }
        }

        private decimal RetornaTotalDocumentoCredito()
        {
            return DocumentosNoTurno.Where(dc => dc.Tipo.Financeiro == MovFinanceiro.Credito && dc.Tipo.Sigla != "FT")
                                    .Sum(dc => dc.Total);
        }
        private decimal RetornaTotalDocumentoDebito()
        {
            return DocumentosNoTurno.Where(dc => dc.Tipo.Financeiro == MovFinanceiro.Debito && dc.Tipo.Sigla != "FT")
                                    .Sum(dc => dc.Total);
        }

        private void CalcAndShowBalances(DateTime dateInit, DateTime dateEnd)
        {
            if (!Util.ListaNula(DocumentosNoTurno))
            {
                var creditBalance = DocumentosNoTurno.Where(d => d.Tipo.Financeiro == MovFinanceiro.Credito && d.Estado == EstadoDocumento.Fechado).Sum(d => d.Total);
                var debitBalance = DocumentosNoTurno.Where(d => d.Tipo.Financeiro == MovFinanceiro.Debito && d.Estado == EstadoDocumento.Fechado).Sum(d => d.Total);
                var balance = creditBalance - debitBalance;
                txtCredito.Text = Util.MostrarValorNaMoedaActual(creditBalance);
                txtDebito.Text = Util.MostrarValorNaMoedaActual(debitBalance);
                txtSaldo.Text = Util.MostrarValorNaMoedaActual(balance);
                txtLucro.Text = Util.MostrarValorNaMoedaActual(GetProfitThisAllDocument());
            }
        }

        private decimal GetProfitThisAllDocument()
        {
            var profit = 0.0m;

            foreach (var document in DocumentosNoTurno)
            {
                if (document.Estado != EstadoDocumento.Fechado)
                {
                    continue;
                }
                if (document.Tipo.Financeiro == MovFinanceiro.Debito)
                {
                    var balance = document.Total;
                    if (document.Tipo.Estoque == MovEstoque.Debita)
                    {
                        balance = _ProdutoMovApp.RetornaLocroProdutosPorDocumentoId(document.DocumentoId);
                    }
                    profit -= balance;
                }
                else if (document.Tipo.Financeiro == MovFinanceiro.Credito)
                {
                    var balance = document.Total;
                    if (document.Tipo.Estoque == MovEstoque.Debita)
                    {
                        balance = _ProdutoMovApp.RetornaLocroProdutosPorDocumentoId(document.DocumentoId);
                    }
                    profit += balance;
                }
            }

            return profit;
        }

        private bool ExisteTurno()
        {
            return !(TurnoActual is null);
        }

        private void CarregarTurno()
        {
            if (!ExisteTurno())
            {
                TurnoActual = _TurnoApp.RetornaTurnoActual();
            }
            if (ExisteTurno())
            {
                txtNomeUser.Text = "OPERADOR: " + TurnoActual.Usuario.Nome;
                txtCaixa.Text = "NOME DO CAIXA: " + TurnoActual.Caixa.Nome;
                txtCaixaQuebra.Text ="QUEBRA DE CAIXA: " +  Util.MostrarValorNaMoedaActual(TurnoActual.QuebraCaixa);
                txtDataAbertura.Text = "DATA DE ABERTURA: " + TurnoActual.DataAbertura.ToShortDateString();
                txtDataConfirm.Text = "DATA DE CONFIRMAÇÃO: " + TurnoActual.DataConfirmacao.ToShortDateString();
                txtDataFecho.Text = RetornaDataFecho();
                txtEstadoTurno.Text = "ESTADO: " + (TurnoActual.Estado ? "ABERTO" : "FECHADO");
                txtSaldoInformado.Text = "SALDO INFORMADO : " + Util.MostrarValorNaMoedaActual(TurnoActual.SaldoInformado);
                txtSaldoInicial.Text = "SALDO INICIAL: " + Util.MostrarValorNaMoedaActual(TurnoActual.SaldoInicial);
                txtSaldoTotal.Text = "SALDO TOTAL NO CAIXA: " + Util.MostrarValorNaMoedaActual(TurnoActual.SaldoTotalNoCaixa + TurnoActual.SaldoInicial);
                txtSupervisor.Text = "GERENTE: " + TurnoActual.SuperVisor;
                txtTotalDeVendas.Text = "TOTAL DE VENDAS: " + Util.MostrarValorNaMoedaActual(TurnoActual.SaldoVendas);
                txtDataConfirm.Text = RetornaDataConfirmacao();
                txtEstadoConfirm.Text = "ESTADO DE CONFIRMAÇÃO: " + (TurnoActual.Confirmado? "CONFIRMADO" : "NÃO CONFIRMADO");
            }
        }

        private string RetornaDataFecho()
        {
            if (!TurnoActual.Estado)
            {
                return "DATA DO FECHO: " + TurnoActual.DataFecho.ToShortDateString();
            }
            else
            {
                return "DATA DO FECHO: ";
            }
        }
        private string RetornaDataConfirmacao()
        {
            if (!TurnoActual.Estado)
            {
                return "DATA DO CONFIRMAÇÃO: " + TurnoActual.DataFecho.ToShortDateString();
            }
            else
            {
                return "DATA DO CONFIRMAÇÃO: ";
            }
        }
        private void IniciarAplicacoes()
        {
            _TurnoApp = new TurnoApp();
            _DocumentoApp = new DocumentoApp();
            _PagamentoApp = new PagamentoApp();
            _ProdutoMovApp = new ProdutoMovimentacaoApp();
            _FormaPagaApp = new FormaPagaApp();
        }

        private void btnTurnClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(new FormFecharTurno().TerminarTurno(TurnoActual.TurnoId))
            {
                Mensagem.Alerta("Turno Fechado com sucesso!");
                IniciarAplicacoes();
                TurnoActual = _TurnoApp.RetornaTurnoPorId(TurnoActual.TurnoId);
                CarregarProcessos();
                EstadoTurno = true;
            }
        }

        private void BtnTurnOpen_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(new FormAbrirTurno().AbrirTurno()){
                Mensagem.Alerta("Turno aberto com sucesso!");
                IniciarAplicacoes();
                CarregarProcessos();
                Globais.TurnoActual = null;
                Globais.TurnoActual = TurnoActual;
                EstadoTurno = true;
            }
        }

        private void gradeDocumentos_DoubleClick(object sender, EventArgs e)
        {
            if (gridDocumentos.RowCount > 0)
            {
                var indiceLinha = gridDocumentos.GetSelectedRows()[0];
                var documentoId = Convert.ToInt32(gridDocumentos.GetRowCellValue(indiceLinha, "DocumentoId"));
                var documento = _DocumentoApp.RetornaDocumentoPorId(documentoId);
                if ("FT-FR-ASE-ASS".Contains(documento.Tipo.Sigla))
                {
                    new FormEditorDocumento().MostrarDocumento(documentoId);
                }
                else if(documento.Tipo.Sigla == "NC")
                {
                    var imprimido = new FormImprimir().SetDescricao(documento.Tipo.Nome).PrintReport(new ReportNotaCredito(documentoId), false);
                    if (imprimido)
                    {
                        documento = _DocumentoApp.RetornaDocumentoPorId(documento.DocumentoId);
                        documento.EstadoImpressao = Util.VerMudarEstadoImpresao(documento.EstadoImpressao);
                        _DocumentoApp.Actualizar(documento);
                    }
                }
            }
        }

        private void btnActualizar_ItemClick(object sender, ItemClickEventArgs e)
        {
            IniciarAplicacoes();
            CarregarProcessos();
        }

        private void FormTurnoDoUsuario_Load(object sender, EventArgs e)
        {
            CarregarProcessos();
        }

        private void btnConfirmarTurno_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (new FormConfirmaTurno().ConfirmarTurno(TurnoActual.TurnoId))
            {
                Mensagem.Alerta("Turno confirmado com sucesso!");
                IniciarAplicacoes();
                TurnoActual = _TurnoApp.RetornaTurnoPorId(TurnoActual.TurnoId);
                CarregarProcessos();
                EstadoTurno = true;
            }
        }
    }
}