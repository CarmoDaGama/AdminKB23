using DevExpress.XtraReports.UI;
using AdminKB.Aplicacoes;
using AdminKB.Dominio.Enumerados;
using AdminKB.Relatorios.Cabecalhos;
using AdminKB.Relatorios.MotivoIsencao;
using AdminKB.Dominio.Utilitarios;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using AdminKB.Dominio.Modelos;

namespace AdminKB.Relatorios
{
    public partial class ReportFacturaTicket : XtraReport
    {
        public ReportFacturaTicket(int documentoId)
        {
            InitializeComponent();
            IniciarDados(documentoId);
        }

        private Documento DocumentoActual { get; set; }

        private void IniciarDados(int documentoId)
        {
            var _documentoApp = new DocumentoApp();
            DocumentoActual = _documentoApp.RetornaDocumentoPorId(documentoId);
            DocumentoActual.EstadoImpressao = Util.VerMudarEstadoImpresao(DocumentoActual.EstadoImpressao);
            DocumentoActual.Estado = EstadoDocumento.Fechado;
            _documentoApp.Actualizar(DocumentoActual);
            MostrarCabecalho();
            MostrarSubCabecalho();
            var produtosDoDocumento = new ProdutoMovimentacaoApp().RetornaProdutosMovPorDocumentoId(documentoId);
            objectDataSource1.DataSource = produtosDoDocumento;
            subReportMotivos.ReportSource = new ReportMotivoIsencao(produtosDoDocumento);
            MostrarDisposicaoDoBensDeServico();
            MostrarCoordenadasBancarias();
            MostrarTotaisDoDocumento();
            MostrarDescricaoDaCertificao();
            MostrarPagamento();
            CarregarFormaDePagamentos();
            MudarMarcaDaAgua(DocumentoActual.Estado);
        }
        private void CarregarFormaDePagamentos()
        {
            if (DocumentoActual.Tipo.Sigla == "FR")
            {
                lblTotalMulticaixa.Visible = true;
                lblTotalNumeraio.Visible = true;
                var pagamentosNoTurno = new FormaPagaApp().RetornaFormaPagamentosEfectuadasPorDocumentoId(DocumentoActual.DocumentoId);

                lblTotalNumeraio.Text = Util.MostrarValorNaMoedaActual(pagamentosNoTurno
                    .Where(p => p.FormaPagamento.Descricao == Globais.MetodoPagamentoPadrao).Sum(p => p.Valor));

                lblTotalMulticaixa.Text = Util.MostrarValorNaMoedaActual(pagamentosNoTurno
                    .Where(p => p.FormaPagamento.Descricao != Globais.MetodoPagamentoPadrao).Sum(p => p.Valor));
            }
            else
            {
                GroupFooterFormaPagamento.Visible = false;
            }
        }
        public ReportFacturaTicket Ticket()
        {
            return new ReportFacturaTicket(DocumentoActual.DocumentoId);
        }
        private void MostrarPagamento()
        {
            if (DocumentoActual.Tipo.Sigla == "FR")
            {
                lblTextPagamento.Text = "Total Pago";
            }
        }

        private void MostrarDescricaoDaCertificao()
        {
            lblDescricaoCertificacao.Text = SSL.RetornaCaracteresHashDoDoc(DocumentoActual.Hash) +
                                            "-Processado por progama certificado nº " +
                                            Globais.NumeroDoCertificadoNaAGT +
                                            "/AGT/" + Globais.AnoDaCertificao + " KSoft";
        }

        private void MostrarTotaisDoDocumento()
        {
            lblTextILiquido.Text = Util.MostrarValorNaMoedaActual(DocumentoActual.TotalIliquido);
            lblTotalDesconto.Text = Util.MostrarValorNaMoedaActual(DocumentoActual.DescontoTotal);
            lblTotalImposto.Text = Util.MostrarValorNaMoedaActual(DocumentoActual.Imposto);
            lblTotalPagar.Text = Util.MostrarValorNaMoedaActual(DocumentoActual.Total);
            lblTotalPorExtenso.Text = Util.EscreverExtenso(DocumentoActual.Total);
        }

        private void MostrarCoordenadasBancarias()
        {
            //TODO Coordenadas bancarias...
        }

        private void MostrarDisposicaoDoBensDeServico()
        {
            if (DocumentoActual.Tipo.Estoque == MovEstoque.Debita && DocumentoActual.Tipo.Destino != Destino.Isento)
            {
                labelDescricaoBensServico.Visible = true;
            }
        }
        private void MudarMarcaDaAgua(EstadoDocumento estado)
        {
            switch (estado)
            {
                case EstadoDocumento.Aberto:
                    Watermark.Text = string.Empty;
                    break;
                case EstadoDocumento.Fechado:
                    Watermark.Text = string.Empty;
                    break;
                case EstadoDocumento.Anulado:
                    Watermark.Text = "ANULADO";
                    break;
                default:
                    Watermark.Text = string.Empty;
                    break;
            }
        }
        private void MostrarSubCabecalho()
        {
            //Dados do Cliente
            var documentoActual = new DocumentoApp().RetornaDocumentoPorId(DocumentoActual.DocumentoId);
            lblNomeCliente.Text = documentoActual.Cliente.Nome;
            labelNifCliente.Text = "NIF: " + documentoActual.Cliente.Nif;
            //lblTelCliente.Text = "Tel: " + DocumentoActual.Cliente.Telefone;
            //lblMoradaCliente.Text = "Morada: " + DocumentoActual.Cliente.Morada;

            //Dados do documento
            cellNomeDocumento.Text = documentoActual.Tipo.Nome + " " + documentoActual.Tipo.Sigla + " " + DateTime.Now.Year + "/ " + documentoActual.NumeroOrdem;
            //labelNumeroDoc.Text = DocumentoActual.NumeroOrdem.ToString();
            lblDataEmissao.Text = documentoActual.DataFacturacao.ToShortDateString();
            //lblHora.Text = DocumentoActual.DataFacturacao.ToShortTimeString();
            lblDataVencimento.Text = documentoActual.DataVencimento.ToShortDateString();
            //lblMoeda.Text = Util.BuscaSiglaDaMoeda(Globais.MoedaActual);
            //cellCambio.Text = Util.MostrarValorNaMoedaActual(Globais.CambioActual);
            lblFuncionario.Text = documentoActual.Turno.Usuario.Nome.ToUpper();
            //lblEmitido.Text = DocumentoActual.EstadoImpressao.ToString();
        }

        private void MostrarCabecalho()
        {
            var empresa = new EmpresaApp().BuscaTipoEntidadePadrao();
            subReportCabecalho.ReportSource = new ReportCabecalhoTicket(empresa);
        }
    }
}
