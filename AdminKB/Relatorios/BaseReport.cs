using DevExpress.XtraReports.UI;
using AdminKB.Aplicacoes;
using AdminKB.Relatorios.Cabecalhos;
using Dominio.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Modelos;
using Dominio.Enumerados;

namespace AdminKB.Relatorios
{
    public class BaseReport : XtraReport
    {
        protected DevExpress.XtraReports.UI.XRSubreport subReportCabecalho;
        protected DevExpress.XtraReports.UI.XRLabel cellCambio;
        protected DevExpress.XtraReports.UI.XRLabel lblMoeda;
        protected DevExpress.XtraReports.UI.XRLabel lblDataVencimento;
        protected DevExpress.XtraReports.UI.XRLabel lblFuncionario;
        protected DevExpress.XtraReports.UI.XRLabel lblDataEmissao;
        protected DevExpress.XtraReports.UI.XRLabel labelNumeroDoc;
        protected DevExpress.XtraReports.UI.XRLabel lblHora;
        protected DevExpress.XtraReports.UI.XRLabel lblDescricaoCertificacao;
        protected DevExpress.XtraReports.UI.XRPageInfo LbPagina;
        protected DevExpress.XtraReports.UI.XRLabel lbDataImprecaoRotolo;
        protected DevExpress.XtraReports.UI.XRLabel lbdataemissaoRodape;
        protected DevExpress.XtraReports.UI.XRLabel lblTotalPagar;
        protected DevExpress.XtraReports.UI.XRLabel lblTextPagamento;
        protected DevExpress.XtraReports.UI.XRLabel porExtenso;
        protected DevExpress.XtraReports.UI.XRLabel labelDescricaoBensServico;
        protected DevExpress.XtraReports.UI.XRLabel lblTotalLiquido;
        protected DevExpress.XtraReports.UI.XRLabel lblTextILiquido;
        protected DevExpress.XtraReports.UI.XRLabel lblTotalImposto;
        protected DevExpress.XtraReports.UI.XRLabel lblTotalDesconto;
        protected DevExpress.XtraReports.UI.XRLabel lblDescGeracao;
        protected DevExpress.XtraReports.UI.XRTableCell cellNomeDocumento;
        protected DevExpress.XtraReports.UI.XRLabel lblEmitido;
        protected DevExpress.XtraReports.UI.XRLabel labelNifCliente;
        protected DevExpress.XtraReports.UI.XRLabel lblMascaraAGT;
        protected DevExpress.XtraReports.UI.XRLabel lblNomeCliente;
        protected DevExpress.XtraReports.UI.XRSubreport subReportMotivos;
        protected DevExpress.XtraReports.UI.XRLabel lblTelCliente;
        protected DevExpress.XtraReports.UI.XRLabel lblMoradaCliente;
        protected DevExpress.XtraReports.UI.XRLabel labelCoordenadasBancariasTitulo;
        protected DevExpress.XtraReports.UI.XRLabel labelCoordenadasBancarias;
        protected DevExpress.DataAccess.ObjectBinding.ObjectDataSource objectDataSource1;

        public BaseReport(int documentoId)
        {
            IniciarDados(documentoId);
        }

        private Documento DocumentoActual { get; set; }

        protected void IniciarDados(int documentoId)
        {
            var _documentoApp = new DocumentoApp();
            DocumentoActual = _documentoApp.RetornaDocumentoPorId(documentoId);
            DocumentoActual.EstadoImpressao = Util.VerMudarEstadoImpresao(DocumentoActual.EstadoImpressao);
            _documentoApp.Actualizar(DocumentoActual);
            MostrarCabecalho();
            MostrarSubCabecalho();
            var produtosDoDocumento = new ProdutoMovimentacaoApp().RetornaProdutosMovPorDocumentoId(documentoId);
            objectDataSource1.DataSource = produtosDoDocumento;
            MostrarDisposicaoDoBensDeServico();
            MostrarCoordenadasBancarias();
            MostrarTotaisDoDocumento();
            MostrarDescricaoDaCertificao();
            MostrarPagamento();
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
            lblNomeCliente.Text = "Nome: " + DocumentoActual.Cliente.Nome;
            labelNifCliente.Text = "NIF: " + DocumentoActual.Cliente.Nif;
            lblTelCliente.Text = "Tel: " + DocumentoActual.Cliente.Telefone;
            lblMoradaCliente.Text = "Morada: " + DocumentoActual.Cliente.Morada;

            //Dados do documento
            cellNomeDocumento.Text = DocumentoActual.Tipo.Nome;
            lblMascaraAGT.Text = DocumentoActual.Tipo.Sigla + " " + DateTime.Now.Year + "/ " + DocumentoActual.NumeroOrdem;
            labelNumeroDoc.Text = DocumentoActual.NumeroOrdem.ToString();
            lblDataEmissao.Text = DocumentoActual.DataFacturacao.ToShortDateString();
            lblHora.Text = DocumentoActual.DataFacturacao.ToShortTimeString();
            lblDataVencimento.Text = DocumentoActual.DataVencimento.ToShortDateString();
            lblMoeda.Text = Util.BuscaSiglaDaMoeda(Globais.MoedaActual);
            cellCambio.Text = Util.MostrarValorNaMoedaActual(Globais.CambioActual);
            lblFuncionario.Text = DocumentoActual.Turno.Usuario.Nome.ToUpper();
        }

        private void MostrarCabecalho()
        {
            var empresa = new EmpresaApp().BuscaTipoEntidadePadrao();
            //subReportCabecalho.ReportSource = new ReportCabecalhoTicket(empresa);
        }
    }
}
