using DevExpress.XtraBars;
using AdminKB.Aplicacoes;
using AdminKB.Formularios.Impressoes;
using Dominio.Modelos;
using AdminKB.Relatorios;
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
using Dominio.Enumerados;
using DevExpress.XtraGrid.Views.Grid;

namespace AdminKB.Formularios.Documentos
{
    public partial class FormDevolverDocumento : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        private bool Devolvido { get; set; }
        private Documento DocumentoActual { get; set; }
        private List<ProdutoMovimentacao> ProdutosDevolver { get; set; }
        private List<ProdutoMovimentacao> ProdutosFicar { get; set; } = new List<ProdutoMovimentacao>();
        private int IndexArtigoMov { get; set; }
        private Documento NotaCredito { get; set; }
        private bool EstadoDocumentoAnuldo { get; set; }
        private DocumentoAnulado DocAnulado { get; set; }

        private DocumentoApp _documentoApp;
        private ProdutoMovimentacaoApp _ProdutoMovApp;
        private ProdutoComponenteApp _ProdutoCompApp;
        private ProdutoEstoqueApp _ProdutoEstoqueApp;
        private DocumentoAnuladoApp _docAnuladoApp;
        private TipoDocumentoApp _TipoDocumentoApp;

        public FormDevolverDocumento()
        {
            InitializeComponent();
            InitApps();
        }

        private void InitApps()
        {
            _documentoApp = new DocumentoApp();
            _ProdutoMovApp = new ProdutoMovimentacaoApp();
            _ProdutoCompApp = new ProdutoComponenteApp();
            _ProdutoEstoqueApp = new ProdutoEstoqueApp();
            _docAnuladoApp = new DocumentoAnuladoApp();
            _TipoDocumentoApp = new TipoDocumentoApp();
        }

        public bool DevolverArtigoDoc(int documentoId)
        {
            DocumentoActual = _documentoApp.RetornaDocumentoPorId(documentoId);
            ShowDialog();
            return Devolvido;
        }
        private void CarregarArtigos()
        {
            ProdutosDevolver = _ProdutoMovApp.RetornaProdutosMovPorDocumentoId(DocumentoActual.DocumentoId);
            gradeArtigoMovimentar.DataSource = null;
            gradeArtigoMovimentar.DataSource = ProdutosDevolver;
        }

        private int GetArtigoMovId(int rowHandle)
        {
            var artigoMovId = Convert.ToInt16(gridArtigosMovimentar.GetRowCellValue(rowHandle, "ProdutoMovimentacaoId"));
            return artigoMovId;
        }

        private void DeleteArtigoInListMov(int artigoMovIndex)
        {
            if (Mensagem.TemCerteza())
            {
                //var artigoRemover = ArtigosMovimentar[artigoMovIndex];
                //DeleteArtigoInListMov(artigoRemover);

                //UpdateTotalDoc();
                //RefreshListaMovimentar();
            }

        }
        private void DeleteArtigoInListMov(ProdutoMovimentacao produtoMovRemover)
        {

            var produtoEstoqueNoMov = _ProdutoEstoqueApp.RetornaProdutoPorId(produtoMovRemover.ProdutoEstoqueId);
            updateQtdArtigo(produtoEstoqueNoMov, -1 * produtoMovRemover.Quantidade);
            UpdateQtdArtigoComps(produtoEstoqueNoMov, -1 * produtoMovRemover.Quantidade);
            _ProdutoMovApp.Remover(produtoMovRemover);
        }
        private void DevolverArtigoInListMov(ProdutoMovimentacao produtoMovDevolver)
        {

            var artigoInvNoMov = _ProdutoEstoqueApp.RetornaProdutoPorId(produtoMovDevolver.ProdutoEstoqueId);
            updateQtdArtigo(artigoInvNoMov, -1 * produtoMovDevolver.Quantidade);
            UpdateQtdArtigoComps(artigoInvNoMov, -1 * produtoMovDevolver.Quantidade);

        }
        private void UpdateQtdArtigoComps(ProdutoEstoque produtoEstoque, decimal qtd)
        {
            var artigoComps = _ProdutoCompApp.RetornaProdutosCompsPorProdutoId(produtoEstoque.ProdutoId);
            foreach (var comp in artigoComps)
            {
                var artigoInvNaComposicao = _ProdutoEstoqueApp.RetornaProdutoPorId(comp.ProdutoComponenteId);
                artigoInvNaComposicao.Quantidade -= qtd * comp.Quantidade;
                _ProdutoEstoqueApp.Actualizar(artigoInvNaComposicao);
            }
        }
        private void updateQtdArtigo(ProdutoEstoque produtoEstoque, decimal qtd)
        {
            if (DocumentoActual.Tipo.Financeiro == MovFinanceiro.Debito)
            {
                produtoEstoque.Quantidade -= qtd;
            }
            else if (DocumentoActual.Tipo.Estoque ==  MovEstoque.Credita)
            {
                produtoEstoque.Quantidade += qtd;
            }
            _ProdutoEstoqueApp.Actualizar(produtoEstoque);
        }
        private bool AnularDocumento()
        {
            var result = new FormMotivoAnularDocumento().GetMotivoAnulacaoDoc();
            if (result.Resultado ==  DialogResult.OK)
            {
               DocAnulado = _docAnuladoApp.Adicionar(new DocumentoAnulado()
                {
                    DocumentoId = DocumentoActual.DocumentoId,
                    Data = DateTime.Now,
                    Motivo = result.Valor
                });
                DocumentoActual.Estado = EstadoDocumento.Anulado;
                _documentoApp.Actualizar(DocumentoActual);
                return true;
            }
            return false;
        }
        private void GravarDevolucao()
        {
            if (Util.ListaNula(ProdutosFicar))
            {
                EstadoDocumentoAnuldo = AnularDocumento();
            }
            else
            {
                EstadoDocumentoAnuldo = true;
            }
            if (EstadoDocumentoAnuldo)
            {
                if (CriarNovaNotaDeCreditoParaArtigosDevolver())
                {
                    gradeArtigoMovimentar.DataSource = null;
                    Devolvido = true;
                    NotaCredito.Estado = EstadoDocumento.Fechado;
                    _documentoApp.Actualizar(NotaCredito);
                    EfectuarPagamentoNotaCredito();
                    NotaCreditoVincularDocAnulado();
                    ActualizarDocumentoActualSeFicarProduto();
                    if (new FormImprimir().SetDescricao("Nota De Crédito")
                                          .PrintReport(new ReportNotaCredito(NotaCredito.DocumentoId), false))
                    {
                        NotaCredito = _documentoApp.RetornaDocumentoPorId(NotaCredito.DocumentoId);
                        NotaCredito.EstadoImpressao = Util.VerMudarEstadoImpresao(NotaCredito.EstadoImpressao);
                        _documentoApp.Actualizar(NotaCredito);
                    }

                }
                Close();
            }
        }

        private void ActualizarDocumentoActualSeFicarProduto()
        {
            if (!Util.ListaNula(ProdutosFicar))
            {
                _documentoApp.ActualizarTotaisDocumento(DocumentoActual, ProdutosFicar);
            }
        }

        private void NotaCreditoVincularDocAnulado()
        {
            if (!(DocAnulado is null))
            {
                DocAnulado.NotaCreditoId = NotaCredito.DocumentoId;
                _docAnuladoApp.Actualizar(DocAnulado); 
            }
            else
            {

            }
        }

        private void EfectuarPagamentoNotaCredito()
        {
            if (!(NotaCredito is null) && NotaCredito.DocumentoId > 0)
            {
                var _pagamentoApp = new PagamentoApp();
                var pagamento = _pagamentoApp.GravarPagamento(
                    NotaCredito.DocumentoId,
                    NotaCredito.DocumentoId,
                    NotaCredito.Total,
                    0,
                    RetornaDescricaoNotaCredito()
                );
                _pagamentoApp.GravarFormaPagamentoUsada(pagamento.PagamentoId, pagamento.Total);
            }
        }

        private bool CriarNovaNotaDeCreditoParaArtigosDevolver()
        {
            if (Util.ListaNula(ProdutosDevolver))
            {
                Mensagem.Alerta("Nenhum produto Foi Devolvido!");
                return false;
            }
            else
            {
                NotaCredito = GetNewNotaCredito();
                foreach (var produtoDevolver in ProdutosDevolver)
                {
                    if (Util.ListaNula(ProdutosFicar))
                    {
                        _ProdutoMovApp.Adicionar(new ProdutoMovimentacao()
                        {
                            ProdutoEstoqueId = produtoDevolver.ProdutoEstoqueId,
                            Desconto = produtoDevolver.Desconto,
                            DocumentoId = NotaCredito.DocumentoId,
                            Imposto = produtoDevolver.Imposto,
                            Preco = produtoDevolver.Preco,
                            Quantidade = produtoDevolver.Quantidade,
                            Retencao = produtoDevolver.Retencao,
                            Total = produtoDevolver.Total
                        });
                    }
                    else
                    {
                        /***/
                        produtoDevolver.DocumentoId = NotaCredito.DocumentoId;
                        _ProdutoMovApp.Actualizar(produtoDevolver);
                    }

                    NotaCredito.Imposto += produtoDevolver.Imposto;
                    NotaCredito.DescontoTotal += produtoDevolver.Desconto;
                    NotaCredito.Retencao += produtoDevolver.Retencao;
                    NotaCredito.TotalIliquido += produtoDevolver.TotaIliquido;
                    NotaCredito.Total += produtoDevolver.Total;
                    DevolverArtigoInListMov(produtoDevolver);
                }
                NotaCredito.QtdLinhas = ProdutosDevolver.Count();
                
                return true;
            }
        }

        private Documento GetNewNotaCredito()
        {
            var _pagamentoApp = new PagamentoApp();
            var valorSaldo = GetTotalArtigosDevolver();
            var valorSaldoIliquido = GetTotalIliquidoArtigosDevolver();
            var valorTotalImposto = GetTotalImpostoArtigosDevolver();
            var numeroOrdem = _documentoApp.RetornaProximoNumeroDocumentoPorSigla("NC");
            var mascara = "NC/" + numeroOrdem;
            var tipoNC = _TipoDocumentoApp.RetornaTipoDocumentoPorSigla("NC");
            var notaCredito = _documentoApp.CriarDocumento(new Documento()
            {
                TipoDocumentoId = tipoNC.TipoDocumentoId,
                Tipo = tipoNC,
                ClienteId = DocumentoActual.ClienteId,
                //Cliente = DocumentoActual.Cliente,
                Turno = Globais.TurnoActual,
                DataFacturacao = DateTime.Now,
                DataVencimento = Util.RetornaDataVencime(30),
                Descricao = RetornaDescricaoNotaCredito(),
                NumeroOrdem = numeroOrdem,
                Mascara = mascara,
                NomeCliente = DocumentoActual.NomeCliente,
                TurnoId = Globais.TurnoActual.TurnoId,
                QtdLinhas = ProdutosDevolver.Count()
            });
            var NumeroOrdemPagamento = _pagamentoApp.RetornaProximoNumeroOrdem();
            _pagamentoApp.Adicionar(new Pagamento
            {
                DocumentoId = notaCredito.DocumentoId,
                DocumetoReciboId = notaCredito.DocumentoId,
                DataHora = DateTime.Now,
                Descricao = "LIQUIDAÇÃO DA " + notaCredito.Tipo.Nome + " " + DateTime.Now.Year + "/" + NumeroOrdemPagamento,
                ImpostoId = Globais.ImpostoPadrao.ImpostoId,
                MovFin = notaCredito.Tipo.Financeiro,
                NumeroOrdem = NumeroOrdemPagamento,
                Total = notaCredito.Total,
                Troco = 00
            });
            return notaCredito;
        }

        private decimal RetornaTotalRetencaoProdutoDevolver()
        {
            var totalRetenao = ProdutosDevolver.Sum(p => p.Preco * (p.Retencao / 100));
            return totalRetenao;
        }

        private decimal GetTotalImpostoArtigosDevolver()
        {
            var totalImposto = ProdutosDevolver.Sum(p => (p.Preco * (p.Imposto / 100)) * p.Quantidade);

            return totalImposto;
        }

        private decimal GetTotalIliquidoArtigosDevolver()
        {
            var totalIliquido = ProdutosDevolver.Sum(p => p.Preco * p.Quantidade);

            return totalIliquido;
        }

        private string RetornaDescricaoNotaCredito()
    {
        if (Util.ListaNula(ProdutosFicar))
        {
            return "ANULAÇÃO REFERENTE À " +
                                DocumentoActual.Tipo.Sigla + " " +
                                DateTime.Now.Year + "/" +
                                DocumentoActual.NumeroOrdem;
        }
        else
        {
            return "RECTIFICAÇÃO REFERENTE À " +
                                DocumentoActual.Tipo.Sigla + " " +
                                DateTime.Now.Year + "/" +
                                DocumentoActual.NumeroOrdem;
        }
    }

        private decimal GetTotalArtigosDevolver()
        {
            if (Util.ListaNula(ProdutosDevolver))
            {
                return 0.0m;
            }

            return ProdutosDevolver.Sum(a => a.Total);
        }

        private void CriarNovoDocumentoParaArtigosFicar()
        {
            if (!Util.ListaNula(ProdutosFicar))
            {
                var novoDocumento = _documentoApp.RetornaNovoDocumento(
                    DocumentoActual.Tipo.Sigla,
                    DocumentoActual.ClienteId,
                    DocumentoActual.TurnoId,
                    GetTotalArtigosFicar(),
                    DocumentoActual.NomeCliente,
                    "RECTIFICAÇÃO REFERENTE À " +
                                DocumentoActual.Tipo.Sigla + " " +
                                DateTime.Now.Year + "/" +
                                DocumentoActual.NumeroOrdem
                );
                foreach (var produtoFicar in ProdutosFicar)
                {
                    _ProdutoMovApp.Adicionar(new ProdutoMovimentacao()
                    {
                        ProdutoEstoqueId = produtoFicar.ProdutoEstoqueId,
                        Desconto = produtoFicar.Desconto,
                        DocumentoId = novoDocumento.DocumentoId,
                        Imposto = produtoFicar.Imposto,
                        Preco = produtoFicar.Preco,
                        Quantidade = produtoFicar.Quantidade,
                        Retencao = produtoFicar.Retencao,
                        Total = produtoFicar.Total
                    });
                }
            novoDocumento.Estado = EstadoDocumento.Fechado;
                _documentoApp.Actualizar(novoDocumento);
            }
        }

        private decimal GetTotalArtigosFicar()
        {
            if (Util.ListaNula(ProdutosFicar))
            {
                return 0.0m;
            }

            return ProdutosFicar.Sum(a => a.Total);
        }

        private void FormDevolverArtigoMov_Load(object sender, EventArgs e)
        {
            CarregarArtigos();
            ShowInfoDocumento();
        }

        private void ShowInfoDocumento()
        {
            lblOperacao.Text = DocumentoActual.Tipo.Nome + " Nº " + DocumentoActual.NumeroOrdem;
            labelTotal.Text = Util.MostrarValorNaMoedaActual(GetTotalArtigoMovs());
        }

        private decimal GetTotalArtigoMovs()
        {
            if (Util.ListaNula(ProdutosDevolver))
            {
                return 0.0m;
            }
            return ProdutosDevolver.Sum(a => a.Total);
        }

        private void btnRemover_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (gridArtigosMovimentar.RowCount > 0)
            {
                var indexs = gridArtigosMovimentar.GetSelectedRows();
                var Ids = GetArtigoMovIds(indexs);
                foreach (int produtoMovimentacaoId in Ids)
                {
                    ProdutosDevolver.RemoveAll(a => a.ProdutoMovimentacaoId == produtoMovimentacaoId);
                    ProdutosFicar.Add(_ProdutoMovApp.RetornaProdutoMovimentaoPorId(produtoMovimentacaoId));
                }
                gradeArtigoMovimentar.DataSource = null;
                gradeArtigoMovimentar.DataSource = ProdutosDevolver;
                ShowInfoDocumento();
            }
            else
            {
                Mensagem.Alerta("Adiciione um produto a lista de venda.");
            }
        }

        private int[] GetArtigoMovIds(int[] indexs)
        {
            var ids = new int[indexs.Length];
            for (int i = 0; i < indexs.Length; i++)
            {
                ids[i] = GetArtigoMovId(indexs[i]);
            }

            return ids;
        }

        private void btnGravarDevolucao_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (PodeGravarDevolucao())
            {
                GravarDevolucao();
            }
        }

        private bool PodeGravarDevolucao()
        {
            if (_documentoApp.DataUltimoDocumentoMaiorDataActual())
            {
                Mensagem.Alerta("A data do ultimo documento criado não \npode ser maior que a data actual!");
                return false;
            }
            return true;
        }

        private void gridArtigosMovimentar_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            IndexArtigoMov = e.RowHandle;
        }
    }
}
