using DevExpress.XtraReports.UI;
using AdminKB.Aplicacoes;
using Dominio.Enumerados;
using AdminKB.Relatorios.Cabecalhos;
using AdminKB.Relatorios.MotivoIsencao;
using Dominio.Utilitarios;
using System;
using System.Linq;
using Dominio.Modelos;

namespace AdminKB.Relatorios
{
    public partial class ReportFactura : XtraReport
    {
        public ReportFactura(int documentoId)
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
        private Documento DocumentoActual { get;  set; }

        private void IniciarDados(int documentoId)
        {
            var _documentoApp = new DocumentoApp();
            DocumentoActual = _documentoApp.RetornaDocumentoPorId(documentoId);
            //_documentoApp.FecharDocumento(DocumentoActual.DocumentoId);
            DocumentoActual.Estado = EstadoDocumento.Fechado;
            DocumentoActual.EstadoImpressao = Util.VerMudarEstadoImpresao(DocumentoActual.EstadoImpressao);
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
            lblTotalILiquido.Text = Util.MostrarValorNaMoedaActual(DocumentoActual.TotalIliquido);
            lblTotalDesconto.Text = Util.MostrarValorNaMoedaActual(DocumentoActual.DescontoTotal);
            lblTotalImposto.Text = Util.MostrarValorNaMoedaActual(DocumentoActual.Imposto);
            lblTotalPagar.Text = Util.MostrarValorNaMoedaActual(DocumentoActual.Total);
            lblTotalPorExtenso.Text = Util.EscreverExtenso(DocumentoActual.Total);
        }

        private void MostrarCoordenadasBancarias()
        {
            switch (DocumentoActual.Tipo.Sigla)
            {
                case "FT":
                    lblCoordenadasBancarias.Visible = true;
                    lblCoordenadasBancariasTitulo.Visible = true;
                    lblTotalMulticaixa.Visible = false;
                    lblTotalNumeraio.Visible = false;
                    lblCoordenadasBancarias.Text = RetornaCoordenada();
                    break;

                case "FR":
                    {
                        //var contaBancariaPradrao = new ContaBancariaApp().RetornContaBancariaPadrao();
                        //if (!(contaBancariaPradrao is null))
                        //{
                        //    lblCoordenadasBancarias.Visible = true;
                        //    lblCoordenadasBancariasTitulo.Visible = true;
                        //    lblCoordenadasBancarias.Text = contaBancariaPradrao.Banco.Nome +
                        //                                   ": " + contaBancariaPradrao.Numero +
                        //                                   "\n" + contaBancariaPradrao.Iban;

                        //}
                    }
                    break;

                default:
                    {
                        subReportMotivos.Visible = false;
                        GroupFooterFormaPagamento.Visible = false;
                        lblTextImposto.Visible = false;
                        lblTotalImposto.Visible = false;
                        lblTextDesconto.Visible = false;
                        lblTotalDesconto.Visible = false;
                        lblTextILiquido.Visible = false;
                        lblTotalILiquido.Visible = false;
                        lblTextForma.Visible = false;
                        lblTotalNumeraio.Visible = false;
                        lblNaoServeDeFactura.Visible = true;
                        labelNifCliente.Visible = false;
                        lblMoradaCliente.Visible = false;
                        lblNomeCliente.Visible = false;
                        lblTelCliente.Visible = false;
                    }
                    break;
            }
           

        }

        private string RetornaCoordenada()
        {
            var formaPaga = new FormaPagamentoApp().BuscaUltimaTipoEntidade();
            if (formaPaga is null)
            {
                return string.Empty;
            }
            return formaPaga.Banco +
                ": " + formaPaga.Numero +
                "\n" + formaPaga.IBAN;
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
            var documentoActual = new DocumentoApp().RetornaDocumentoPorId(DocumentoActual.DocumentoId);
            lblNomeCliente.Text = "Nome: " + documentoActual.NomeCliente;
            labelNifCliente.Text = "NIF: " + documentoActual.Cliente.Nif;
            lblTelCliente.Text = "Tel: " + documentoActual.Cliente.Telefone;
            lblMoradaCliente.Text = "Morada: " + documentoActual.Cliente.Morada;

            //Dados do documento
            cellNomeDocumento.Text = documentoActual.Tipo.Nome;
            lblMascaraAGT.Text = documentoActual.Tipo.Sigla + " " + DateTime.Now.Year + "/ " + DocumentoActual.NumeroOrdem;
            labelNumeroDoc.Text = documentoActual.NumeroOrdem.ToString();
            lblDataEmissao.Text = documentoActual.DataFacturacao.ToShortDateString();
            lblHora.Text = documentoActual.DataFacturacao.ToShortTimeString();
            lblDataVencimento.Text = documentoActual.DataVencimento.ToShortDateString();
            lblMoeda.Text = Util.BuscaSiglaDaMoeda(Globais.MoedaActual);
            cellCambio.Text = Util.MostrarValorNaMoedaActual(Globais.CambioActual);
            lblFuncionario.Text = documentoActual.Turno.Usuario.Nome.ToUpper();
            lblEmitido.Text = documentoActual.EstadoImpressao.ToString();
        }

        private void MostrarCabecalho()
        {
            var empresa = new EmpresaApp().BuscaTipoEntidadePadrao();
            subReportCabecalho.ReportSource = new ReportCabecalho(empresa);
        }

        private void ReportFactura_DesignerLoaded(object sender, DevExpress.XtraReports.UserDesigner.DesignerLoadedEventArgs e)
        {

        }
    }
}
