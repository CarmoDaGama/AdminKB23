using DevExpress.XtraReports.UI;
using AdminKB.Aplicacoes;
using Dominio.Enumerados;
using Dominio.Modelos;
using AdminKB.Relatorios.Cabecalhos;
using Dominio.Utilitarios;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace AdminKB.Relatorios
{
    public partial class ReportRecibo : XtraReport
    {
        private Documento DocumentoActual { get; set; }
        public ReportRecibo(int documentoId)
        {
            InitializeComponent();
            IniciarDados(documentoId);
        }
        private void IniciarDados(int documentoId)
        {
            var _documentoApp = new DocumentoApp();
            DocumentoActual = _documentoApp.RetornaDocumentoPorId(documentoId);
            DocumentoActual.EstadoImpressao = Util.VerMudarEstadoImpresao(DocumentoActual.EstadoImpressao);
            DocumentoActual.Estado = EstadoDocumento.Fechado;
            _documentoApp.Actualizar(DocumentoActual);
            MostrarCabecalho();
            MostrarSubCabecalho();
            var pagamentosDoDocumento = new PagamentoApp().RetornaPagamentosDiferentesPorDocumentoId(documentoId);
            objectDataSource1.DataSource = pagamentosDoDocumento;
            //subReportMotivos.ReportSource = new ReportMotivoIsencao(produtosDoDocumento);
            //MostrarDisposicaoDoBensDeServico();
            //MostrarCoordenadasBancarias();
            MostrarTotaisDoDocumento();
            MostrarDescricaoDaCertificao();
            //MostrarPagamento();
            MudarMarcaDaAgua(DocumentoActual.Estado);
            lbDataImprecaoRotolo.Text = "DATA IMPRESSÃO: " + DateTime.Now.ToShortDateString();
        }
        private void MostrarSubCabecalho()
        {
            //Dados do Cliente
            var documentoActual = new DocumentoApp().RetornaDocumentoPorId(DocumentoActual.DocumentoId);
            lblNomeCliente.Text = "Nome: " + documentoActual.Cliente.Name;
            labelNifCliente.Text = "NIF: " + documentoActual.Cliente.Nif;
            lblTelCliente.Text = "Tel: " + documentoActual.Cliente.Telephone;
            lblMoradaCliente.Text = "Morada: " + documentoActual.Cliente.Location;

            //Dados do documento
            cellNomeDocumento.Text = documentoActual.Tipo.Nome;
            lblMascaraAGT.Text = documentoActual.Tipo.Sigla + " " + DateTime.Now.Year + "/ " + documentoActual.NumeroOrdem;
            labelNumeroDoc.Text = documentoActual.NumeroOrdem.ToString();
            lblDataEmissao.Text = documentoActual.DataFacturacao.ToShortDateString();
            lblHora.Text = documentoActual.DataFacturacao.ToShortTimeString();
            //lblDataVencimento.Text = DocumentoActual.DataVencimento.ToShortDateString();
            //lblMoeda.Text = Util.BuscaSiglaDaMoeda(Globais.MoedaActual);
            //cellCambio.Text = Util.MostrarValorNaMoedaActual(Globais.CambioActual);
            lblFuncionario.Text = documentoActual.Turno.Usuario.Nome.ToUpper();
            lblEmitido.Text = documentoActual.EstadoImpressao.ToString();
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
        private void MostrarCabecalho()
        {
            var empresa = new EmpresaApp().BuscaTipoEntidadePadrao();
            subReportCabecalho.ReportSource = new ReportCabecalho(empresa);
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
    }
}
