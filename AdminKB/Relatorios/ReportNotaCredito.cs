using DevExpress.XtraReports.UI;
using AdminKB.Aplicacoes;
using Dominio.Enumerados;
using AdminKB.Relatorios.Cabecalhos;
using AdminKB.Relatorios.MotivoIsencao;
using Dominio.Utilitarios;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using Dominio.Modelos;

namespace AdminKB.Relatorios
{
    public partial class ReportNotaCredito : XtraReport
    {
        public ReportNotaCredito(int documentoId)
        {
            InitializeComponent();
            IniciarDados(documentoId);
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
            MudarMarcaDaAgua(DocumentoActual.Estado);
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
            lblTotalILiquido.Text = Util.MostrarValorNaMoedaActual(DocumentoActual.TotalIliquido);
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

        private void MostrarSubCabecalho()
        {
            //Dados do Cliente
            var cliente = new ClienteApp().BuscaPorId(DocumentoActual.ClienteId);
            lblNomeCliente.Text = "Nome: " + cliente.Name;
            labelNifCliente.Text = "NIF: " + cliente.Nif;
            lblTelCliente.Text = "Tel: " + cliente.Telephone;
            lblMoradaCliente.Text = "Morada: " + cliente.Location;

            //Dados do documento
            cellNomeDocumento.Text = (DocumentoActual.Tipo.Nome + " - " + DocumentoActual.Descricao).ToUpper();
            lblMascaraAGT.Text = DocumentoActual.Tipo.Sigla + "  " + DateTime.Now.Year + "/ " + DocumentoActual.NumeroOrdem;
            labelNumeroDoc.Text = DocumentoActual.NumeroOrdem.ToString();
            lblDataEmissao.Text = DocumentoActual.DataFacturacao.ToShortDateString();
            lblHora.Text = DocumentoActual.DataFacturacao.ToShortTimeString();
            //lblDataVencimento.Text = DocumentoActual.DataVencimento.ToShortDateString();
            lblMoeda.Text = Util.BuscaSiglaDaMoeda(Globais.MoedaActual);
            cellCambio.Text = Util.MostrarValorNaMoedaActual(Globais.CambioActual);
            var turno = new TurnoApp().RetornaTurnoPorId(DocumentoActual.TurnoId);
            lblFuncionario.Text = turno.Usuario.Nome.ToUpper();
            lblEmitido.Text = DocumentoActual.EstadoImpressao.ToString();
        }

        private void MostrarCabecalho()
        {
            var empresa = new EmpresaApp().BuscaTipoEntidadePadrao();
            subReportCabecalho.ReportSource = new ReportCabecalho(empresa);
        }
    }
}
