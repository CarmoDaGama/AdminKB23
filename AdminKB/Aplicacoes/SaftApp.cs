using Dominio.Modelos;
using Dominio.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Dominio.Enumerados;

namespace AdminKB.Aplicacoes
{
    public class SaftApp : AppBase<Saft>
    {

        public SaftApp() : base(true)
        {

        }
        public AuditFile RetornaAuditFile(DateTime dataInicio, DateTime dataFim)
        {
            var auditFile = new AuditFile();
            auditFile.Header = RetornaCabecalho(dataInicio, dataFim);
            auditFile.MasterFiles = RetornaTabelasMestres(dataInicio, dataFim);
            auditFile.SourceDocuments = RetornaDocumentosComenrciais(dataInicio, dataFim);
            return auditFile;
        }

        private AuditFileSourceDocuments RetornaDocumentosComenrciais(DateTime dataInicio, DateTime dataFim)
        {
            var documentosComercias = new AuditFileSourceDocuments();
            documentosComercias.SalesInvoices = RetornaDocumentosComerciaisClientes(dataInicio, dataFim);
            //documentosComercias.MovementOfGoods = RetornaMovementOfGoods(dataInicio, dataFim);
            documentosComercias.Payments = RetornaPayments(dataInicio, dataFim);
            return documentosComercias;
        }

        private AuditFileSourceDocumentsPayments RetornaPayments(DateTime dataInicio, DateTime dataFim)
        {
            var payments = new AuditFileSourceDocumentsPayments();
            var recibos = RetornaRecibos(dataInicio, dataFim);
            payments.NumberOfEntries = recibos.Count.ToString();
            var totalCredit = recibos.Where(d => d.Tipo.Financeiro == MovFinanceiro.Credito).Sum(d => d.Total);
            payments.TotalCredit = string.Format("{0}", totalCredit).Replace(",",".");

            var totalDebit = recibos.Where(d => d.Tipo.Financeiro == MovFinanceiro.Debito).Sum(d => d.Total);
            payments.TotalDebit =string.Format("{0}", totalDebit).Replace(",",".");
            payments.Payment = RetornaPaymentsPayment(dataInicio, dataFim);
            return payments;
        }

        private AuditFileSourceDocumentsPaymentsPayment[] RetornaPaymentsPayment(DateTime dataInicio, DateTime dataFim)
        {
            var recibos = RetornaRecibos(dataInicio, dataFim);
            var pagamentos = new AuditFileSourceDocumentsPaymentsPayment[recibos.Count];
            for (int i = 0; i < recibos.Count; i++)
            {
                pagamentos[i] = new AuditFileSourceDocumentsPaymentsPayment();
                pagamentos[i].PaymentRefNo = recibos[i].Tipo.Sigla + " " + recibos[i].DataFacturacao.Year + "/" + recibos[i].NumeroOrdem;
                pagamentos[i].Period = recibos[i].DataFacturacao.Month.ToString();
                pagamentos[i].TransactionDate = recibos[i].DataFacturacao;
                pagamentos[i].PaymentType = recibos[i].Tipo.Sigla;
                pagamentos[i].DocumentStatus = RetornaPaymentsStatus(recibos[i]);
                pagamentos[i].PaymentMethod = RetornaPaymentsPaymentMethod(recibos[i]);
                pagamentos[i].Line = RetornaPaymentsPaymentLine(recibos[i]);
                pagamentos[i].DocumentTotals = RetornaPaymentsPaymentDocumentTotals(recibos[i]);
                pagamentos[i].WithholdingTax = RetornaPaymentsPaymentWithholdingTax(recibos[i]);
                pagamentos[i].SourceID = recibos[i].Turno.UsuarioId.ToString();
                pagamentos[i].CustomerID = recibos[i].ClienteId.ToString();
                pagamentos[i].SystemEntryDate = pagamentos[i].DocumentStatus.PaymentStatusDate;
            }
            return pagamentos;
        }

        private AuditFileSourceDocumentsPaymentsPaymentWithholdingTax[] RetornaPaymentsPaymentWithholdingTax(Documento documento)
        {
            var impostoDoc = new AuditFileSourceDocumentsPaymentsPaymentWithholdingTax[1];
            impostoDoc[0] = new AuditFileSourceDocumentsPaymentsPaymentWithholdingTax();

            impostoDoc[0].WithholdingTaxType = "IRT";
            impostoDoc[0].WithholdingTaxAmount = string.Format("{0}", documento.Imposto).Replace(",",".");
            return impostoDoc;
        }

        private AuditFileSourceDocumentsPaymentsPaymentDocumentTotals RetornaPaymentsPaymentDocumentTotals(Documento documento)
        {
            var pagamentoTotais = new AuditFileSourceDocumentsPaymentsPaymentDocumentTotals();
            pagamentoTotais.TaxPayable = string.Format("{0}", documento.Imposto).Replace(",",".");
            pagamentoTotais.NetTotal = string.Format("{0}", documento.TotalIliquido).Replace(",",".");
            pagamentoTotais.GrossTotal = string.Format("{0}", documento.Total).Replace(",",".");
            return pagamentoTotais;
        }

        private AuditFileSourceDocumentsPaymentsPaymentLine[] RetornaPaymentsPaymentLine(Documento documento)
        {
            var docPagos = new PagamentoApp().RetornaPagamentosDiferentesPorDocumentoId(documento.DocumentoId);
            var lineDocs = new AuditFileSourceDocumentsPaymentsPaymentLine[docPagos.Count];
            for (int i = 0; i < docPagos.Count; i++)
            {
                lineDocs[i] = new AuditFileSourceDocumentsPaymentsPaymentLine();
                lineDocs[i].LineNumber = docPagos[i].NumeroOrdem.ToString();
                lineDocs[i].SourceDocumentID = RetornaPaymentsPaymentLineSourceDocumentID(docPagos[i]);
                lineDocs[i].CreditAmount = docPagos[i].MovFin == MovFinanceiro.Credito ? 
                    string.Format("{0}", docPagos[i].Total).Replace(",",".") : "0.00";
            }

            return lineDocs;
        }

        private AuditFileSourceDocumentsPaymentsPaymentLineSourceDocumentID RetornaPaymentsPaymentLineSourceDocumentID(Pagamento pagamento)
        {
            var referencias = new AuditFileSourceDocumentsPaymentsPaymentLineSourceDocumentID();
            referencias.InvoiceDate = pagamento.DataHora;
            referencias.OriginatingON = pagamento.Documento.Tipo.Sigla +
                " " + pagamento.Documento.DataFacturacao.Year + "/" + pagamento.Documento.NumeroOrdem;
            referencias.InvoiceDate = pagamento.Documento.DataFacturacao;
            referencias.Description = pagamento.Descricao;
            //referencias.DebitAmount = pagamento.MovFin == MovFinanceiro.Debito ? pagamento.Total : 0;
            //referencias.CreditAmount = pagamento.MovFin == MovFinanceiro.Credito ? pagamento.Total : 0;
            return referencias;
        }

        private AuditFileSourceDocumentsPaymentsPaymentPaymentMethod[] RetornaPaymentsPaymentMethod(Documento documento)
        {
            var formasPagamento = new FormaPagaApp().RetornaFormasPagaPorDocumentoId(documento.DocumentoId);
            var forma = new AuditFileSourceDocumentsPaymentsPaymentPaymentMethod[formasPagamento.Count];
            for (int i = 0; i < forma.Count(); i++)
            {
                forma[i] = new AuditFileSourceDocumentsPaymentsPaymentPaymentMethod();
                if (!(formasPagamento[i] is null) && formasPagamento[i].FormaPagamento.Descricao != Globais.MetodoPagamentoPadrao)
                {
                    forma[i].PaymentMechanism = "TB";
                }
                else
                {
                    forma[i].PaymentMechanism = "NU";
                }
                forma[i].PaymentAmount = string.Format("{0}", formasPagamento[i].Pagamento.Total).Replace(",",".");
                forma[i].PaymentDate = formasPagamento[i].Pagamento.DataHora;

            }
            return forma;
        }

        private AuditFileSourceDocumentsPaymentsPaymentDocumentStatus RetornaPaymentsStatus(Documento documento)
        {
            var status = new AuditFileSourceDocumentsPaymentsPaymentDocumentStatus();
            if (documento.Estado == EstadoDocumento.Anulado || documento.Estado == EstadoDocumento.Cancelado)
            {
                status.PaymentStatus = "A";

            }
            else
            {
                status.PaymentStatus = "N";
            }
            status.PaymentStatusDate = new DateTime( 
                documento.DataFacturacao.Year,
                documento.DataFacturacao.Month,
                documento.DataFacturacao.Day,
                documento.DataFacturacao.Hour,
                documento.DataFacturacao.Minute,
                documento.DataFacturacao.Second
            ).ToString("yyyy-MM-ddThh:mm:ss");
            status.SourcePayment = "P";
            status.SourceID = documento.Turno.UsuarioId.ToString();
            return status;
        }

        private List<Documento> RetornaRecibos(DateTime dataInicio, DateTime dataFim)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                return contexto.Set<Documento>()
                             .Include(d => d.Turno)
                             .Include(d => d.Tipo)
                             .Include(d => d.Cliente)
                             .Where(d => d.DataFacturacao >= dataInicio && d.DataFacturacao <= dataFim &&
                                    "RG".Contains(d.Tipo.Sigla) &&
                                    d.Estado != EstadoDocumento.Aberto &&
                                    d.Estado != EstadoDocumento.Apagado)
                             .ToList();
        }

        private AuditFileSourceDocumentsMovementOfGoods RetornaMovementOfGoods(DateTime dataInicio, DateTime dataFim)
        {
            var docsMovMercadorias = new AuditFileSourceDocumentsMovementOfGoods();
            docsMovMercadorias.NumberOfMovementLines = RetornaDocumentosMovMercadorios(dataInicio, dataFim).Count.ToString();
            docsMovMercadorias.TotalQuantityIssued = SomaControlodeEstoque(dataInicio, dataFim).ToString();

            return docsMovMercadorias;
        }
        private decimal SomaControlodeEstoque(DateTime dataInicio, DateTime dataFim)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro())) { 
                var produtosMov = contexto.Set<ProdutoMovimentacao>()
                .Include(p => p.Documento)
                .Include(p => p.Documento.Tipo)
                .Where(p => p.Documento.DataFacturacao >= dataInicio &&
                p.Documento.DataFacturacao <= dataFim &&
               "ASE-ASS".Contains(p.Documento.Tipo.Sigla))
                .ToList();
                if (produtosMov is null)
                {
                    return 0;
                }
                else
                {
                    return produtosMov.Sum(p => p.Quantidade);
                }
            }
        }
        private List<Documento> RetornaDocumentosMovMercadorios(DateTime dataInicio, DateTime dataFim)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
            return contexto.Set<Documento>()
                           .Include(d => d.Turno)
                           .Include(d => d.Tipo)
                           .Include(d => d.Cliente)
                           .Where(d => d.DataFacturacao >= dataInicio && d.DataFacturacao <= dataFim &&
                                  "ASE-ASS".Contains(d.Tipo.Sigla) &&
                                  d.Estado != EstadoDocumento.Aberto &&
                                  d.Estado != EstadoDocumento.Apagado)
                           .ToList();
        }
        private AuditFileSourceDocumentsSalesInvoices RetornaDocumentosComerciaisClientes(DateTime dataInicio, DateTime dataFim)
        {
            var documentosComericiaisClientes = new AuditFileSourceDocumentsSalesInvoices();
            documentosComericiaisClientes.NumberOfEntries = RetornaQtdDocumentos(dataInicio, dataFim).ToString();

            var totalDebitoComerciais = RetornaTotalDebitoComerciais(dataInicio, dataFim, MovFinanceiro.Debito);
            documentosComericiaisClientes.TotalDebit = string.Format("{0}", totalDebitoComerciais).Replace(",",".");

            var totalCreditoComerciais = RetornaTotalCreditoComerciais(dataInicio, dataFim);
            documentosComericiaisClientes.TotalCredit = string.Format("{0}", totalCreditoComerciais).Replace(",",".");

            documentosComericiaisClientes.Invoice = RetornaInvoices(dataInicio, dataFim);

            return documentosComericiaisClientes;
        }
        private AuditFileSourceDocumentsSalesInvoicesInvoice[] RetornaInvoices(DateTime dataInicio, DateTime dataFim)
        {
            var documentos = RetornaDocumentos(dataInicio, dataFim);
            var documentosInvoice = new AuditFileSourceDocumentsSalesInvoicesInvoice[documentos.Count];
            for (int i = 0; i < documentos.Count; i++)
            {
                documentosInvoice[i] = new AuditFileSourceDocumentsSalesInvoicesInvoice();

                documentosInvoice[i].InvoiceNo = documentos[i].Tipo.Sigla + " " +
                                                 (DateTime.Now.Year - 2021) + "/" +
                                                 Util.RetornaStringDigitos(documentos[i].NumeroOrdem, 2);

                documentosInvoice[i].DocumentStatus = RetornaDocumentStatus(documentos[i]);
                documentosInvoice[i].Hash = documentos[i].Hash.Trim();
                documentosInvoice[i].HashControl = SSL.VersaoChavePrivada;
                documentosInvoice[i].Period = documentos[i].DataFacturacao.Month.ToString();
                documentosInvoice[i].InvoiceDate = documentos[i].DataFacturacao.ToString("yyyy-MM-dd");
                documentosInvoice[i].InvoiceType = documentos[i].Tipo.Sigla;
                documentosInvoice[i].SpecialRegimes = RetornaSpecialRegimes(documentos[i]);
                documentosInvoice[i].SourceID = documentos[i].Turno.UsuarioId.ToString();
                documentosInvoice[i].SystemEntryDate = documentosInvoice[i].DocumentStatus.InvoiceStatusDate;
                documentosInvoice[i].CustomerID = documentos[i].ClienteId.ToString();
                documentosInvoice[i].Line = RetornaLines(documentos[i]);
                documentosInvoice[i].DocumentTotals = RetornaDocumentTotals(documentos[i]);
                documentosInvoice[i].WithholdingTax = RetornaWithholdingTax(documentos[i]);
            }
            return documentosInvoice;
        }

        private AuditFileSourceDocumentsSalesInvoicesInvoiceWithholdingTax RetornaWithholdingTax(Documento documento)
        {
            var retencao = new AuditFileSourceDocumentsSalesInvoicesInvoiceWithholdingTax();
            retencao.WithholdingTaxAmount = string.Format("{0}", documento.Retencao).Replace(",",".");
            return retencao;
        }

        private AuditFileSourceDocumentsSalesInvoicesInvoiceDocumentTotals RetornaDocumentTotals(Documento documento)
        {
            var totals = new AuditFileSourceDocumentsSalesInvoicesInvoiceDocumentTotals();
            totals.TaxPayable = string.Format("{0}", documento.Imposto).Replace(",", ".");
            totals.NetTotal = string.Format("{0}", documento.TotalIliquido).Replace(",",".");
            totals.GrossTotal = string.Format("{0}", documento.Total).Replace(",",".");
            totals.Payment = RetornaTotalsPayment(documento.DocumentoId);
            return totals;
        }

        private AuditFileSourceDocumentsSalesInvoicesInvoiceDocumentTotalsPayment RetornaTotalsPayment(int documentoId)
        {
            var pagamento = new PagamentoApp().RetornaPagamentoPorDocumentoId(documentoId);
            if (pagamento is null)
            {
                return null;
            }
            else
            {
                var forma = new FormaPagaApp().RetornaFormaPagaPorDocumentoId(pagamento.DocumetoReciboId);
                if (forma is null)
                {
                    return null;
                }
                else
                {
                    var formaDescricao = forma.FormaPagamento.Descricao;
                    return new AuditFileSourceDocumentsSalesInvoicesInvoiceDocumentTotalsPayment()
                    {
                        PaymentAmount = string.Format("{0}", pagamento.Total).Replace(",","."),
                        PaymentDate = pagamento.DataHora,
                        PaymentMechanism = formaDescricao == Globais.MetodoPagamentoPadrao ? "NU" : "TB"
                    };
                }
            }
        }

        private AuditFileSourceDocumentsSalesInvoicesInvoiceLine[] RetornaLines(Documento documento)
        {
            var produtos = new ProdutoMovimentacaoApp().RetornaProdutosMovPorDocumentoId(documento.DocumentoId);
            var lines = new AuditFileSourceDocumentsSalesInvoicesInvoiceLine[produtos.Count];
            for (int i = 0; i < produtos.Count; i++)
            {
                lines[i] = new AuditFileSourceDocumentsSalesInvoicesInvoiceLine();
                lines[i].ProductCode = produtos[i].ProdutoEstoque.Produto.ProdutoId.ToString();
                lines[i].LineNumber = produtos[i].ProdutoMovimentacaoId.ToString();
                if (produtos[i].Documento.Tipo.Financeiro == MovFinanceiro.Credito)
                {
                    lines[i].CreditAmount = string.Format("{0}", produtos[i].TotaIliquido).Replace(",",".");
                    lines[i].CreditAmountSpecified = true;

                }
                else
                {
                    lines[i].DebitAmount = string.Format("{0}", produtos[i].TotaIliquido).Replace(",",".");
                    lines[i].DebitAmountSpecified = true;
                }
                //lines[i].DebitAmount = Util.CalcularValorDescontoArtigo(produtos[i]) * produtos[i].Quantidade;
                lines[i].Description = produtos[i].ProdutoEstoque.Produto.Nome;
                lines[i].ProductDescription = produtos[i].ProdutoEstoque.Produto.Nome;
                lines[i].Quantity = string.Format("{0}", produtos[i].Quantidade).Replace(",",".");
                lines[i].UnitOfMeasure = "Un";
                lines[i].UnitPrice = string.Format("{0}", produtos[i].Preco).Replace(",",".");
                lines[i].TaxPointDate = RetornaDataDeEnvio(produtos[i].ProdutoEstoque.ProdutoId);
                lines[i].References = RetornaReferences(produtos[i]);
                lines[i].Tax = RetornaLineTax(produtos[i]);
                lines[i].TaxExemptionReason = produtos[i].ProdutoEstoque.Produto.MotivoIsencao.Nome;
                lines[i].SettlementAmount = string.Format("{0}", produtos[i].Desconto).Replace(",",".");
                lines[i].TaxExemptionCode = produtos[i].ProdutoEstoque.Produto.MotivoIsencao.Referencia;
            }

            return lines;
        }

        private AuditFileSourceDocumentsSalesInvoicesInvoiceLineTax RetornaLineTax(ProdutoMovimentacao produtoMovimentacao)
        {
            var tax = new AuditFileSourceDocumentsSalesInvoicesInvoiceLineTax();
            tax.TaxType = produtoMovimentacao.ProdutoEstoque.Produto.Imposto.TipoImposto.Sigla;
            tax.TaxCountryRegion = "AO";
            tax.TaxCode = produtoMovimentacao.ProdutoEstoque.Produto.Imposto.Sigla;
            tax.TaxPercentage = string.Format("{0}", produtoMovimentacao.ProdutoEstoque.Produto.Imposto.Percentagem).Replace(",",".");
            //tax.TaxAmount =string.Format("{0}", (produtoMovimentacao.Preco * (produtoMovimentacao.ProdutoEstoque.Produto.Imposto.Percentagem / 100))).Replace(",",".");
            return tax;
        }

        private AuditFileSourceDocumentsSalesInvoicesInvoiceLineReferences RetornaReferences(ProdutoMovimentacao produtoMovimentacao)
        {
            var documento = new DocumentoApp().RetornaDocumentoPorId(produtoMovimentacao.DocumentoId);
            var docMotivo = new DocumentoAnuladoApp().RetornaDocumentoAnuladoPorNotaCreditoId(produtoMovimentacao.DocumentoId);
            if (docMotivo is null)
            {
                if (produtoMovimentacao.Documento.Tipo.Sigla == "NC")
                {
                    return new AuditFileSourceDocumentsSalesInvoicesInvoiceLineReferences()
                    {
                        Reference = documento.Tipo.Sigla + " " +
                                documento.DataFacturacao.Year + "/" +
                                documento.NumeroOrdem,
                        Reason = "Retificação"
                    };
                }
                return null;
            }
            else
            {
                return new AuditFileSourceDocumentsSalesInvoicesInvoiceLineReferences()
                {
                    Reference = documento.Tipo.Sigla + " " +
                                documento.DataFacturacao.Year + "/" +
                                documento.NumeroOrdem,
                    Reason = "ANULAÇÃO"
                };
            }
            
        }

        private DateTime RetornaDataDeEnvio(int produtoId)
        {

            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro())) { 
                var produtoMov = contexto.Set<ProdutoMovimentacao>()
                                .Include(p => p.Documento)
                                .Include(p => p.Documento.Tipo)
                                .Include(p => p.ProdutoEstoque)
                                .Include(p => p.ProdutoEstoque.Produto)
                                .Where(p => p.Documento.Tipo.Sigla == "ASE" &&
                                            p.ProdutoEstoque.ProdutoId == produtoId &&
                                            p.Documento.Estado == EstadoDocumento.Anulado &&
                                            p.Documento.Estado == EstadoDocumento.Cancelado)
                                .ToList()
                                .OrderBy(p => p.Documento.DataFacturacao)
                                .FirstOrDefault();

                return produtoMov is null? DateTime.Now : produtoMov.Documento.DataFacturacao;
            }
        }

        private AuditFileSourceDocumentsSalesInvoicesInvoiceSpecialRegimes RetornaSpecialRegimes(Documento documento)
        {
            return new AuditFileSourceDocumentsSalesInvoicesInvoiceSpecialRegimes()
            {
                CashVATSchemeIndicator = "0",
                SelfBillingIndicator = "0",
                ThirdPartiesBillingIndicator = "0"
            };
        }

        private AuditFileSourceDocumentsSalesInvoicesInvoiceDocumentStatus RetornaDocumentStatus(Documento documento)
        {
            var docStatus = new AuditFileSourceDocumentsSalesInvoicesInvoiceDocumentStatus();
            docStatus.InvoiceStatus = RetornaEstadoDoc(documento.Estado);
            docStatus.InvoiceStatusDate = new DateTime(
                    documento.DataFacturacao.Year,
                    documento.DataFacturacao.Month,
                    documento.DataFacturacao.Day,
                    documento.DataFacturacao.Hour,
                    documento.DataFacturacao.Minute,
                    documento.DataFacturacao.Second
                ).ToString("yyyy-MM-ddThh:mm:ss");
            docStatus.SourceID = documento.Turno.UsuarioId.ToString();
            docStatus.SourceBilling = "P";
            return docStatus;
        }

        private string RetornaEstadoDoc(EstadoDocumento estado)
        {
            switch (estado)
            {
                case EstadoDocumento.Aberto:
                    return "N";
                case EstadoDocumento.Fechado:
                    return "N";
                case EstadoDocumento.Cancelado:
                    return "A";
                case EstadoDocumento.Anulado:
                    return "A";
                case EstadoDocumento.Apagado:
                    return "A";
                default:
                    return "N";
            }
        }

        private int RetornaQtdDocumentos(DateTime dataInicio, DateTime dataFim)
        {
            return RetornaDocumentos(dataInicio, dataFim).Count;
        }


        private decimal RetornaTotalCreditoComerciais(DateTime dataInicio, DateTime dataFim)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro())) { 
                var documentosComerciais = contexto.Set<Documento>()
                                         .Where(d => "FT-FR".Contains(d.Tipo.Sigla.ToUpper()) &&
                                         d.DataFacturacao >= dataInicio &&
                                         d.DataFacturacao <= dataFim &&
                                         d.Estado != EstadoDocumento.Aberto  &&
                                         d.Estado != EstadoDocumento.Apagado
                                         /**/&& d.Estado != EstadoDocumento.Anulado )
                                        
                                         .ToList();

                return documentosComerciais.Sum(d => d.TotalIliquido);
            }
        }

        private decimal RetornaTotalDebitoComerciais(DateTime dataInicio, DateTime dataFim, MovFinanceiro financeiro)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro())) { 
                var documentosComerciais = contexto.Set<Documento>()
                                         .Where(d => "NC".Contains(d.Tipo.Sigla.ToUpper()) && 
                                         d.DataFacturacao >= dataInicio &&
                                         d.DataFacturacao <= dataFim && 
                                         d.Estado != EstadoDocumento.Aberto &&
                                         d.Estado != EstadoDocumento.Apagado
                                         /**/&& d.Estado != EstadoDocumento.Anulado)
                                         .ToList();

                //if (Util.ListaNula(documentosComerciais))
                //{
                //    return 0;
                //}
                //else
                //{
                //    var totalDebito = 0.0m;
                //    foreach (var documento in documentosComerciais)
                //    {
                //        totalDebito += RetornaTotalDescontoNasLinhasProdutos(documento.DocumentoId) + documento.Desconto;
                //    }
                //    return totalDebito;
                //}
                return documentosComerciais.Sum(d => d.TotalIliquido);
            }
        }

        private decimal RetornaTotalDescontoNasLinhasProdutos(int documentoId)
        {
            var produtosMov = new ProdutoMovimentacaoApp().RetornaProdutosMovPorDocumentoId(documentoId);
            if (Util.ListaNula(produtosMov))
            {
                return 0;
            }
            else
            {
                var totalDescont = produtosMov.Sum(p => (p.Preco * (p.Desconto / 100)) * p.Quantidade);

                return totalDescont;

            }
        }

        private List<Documento> RetornaDocumentos(DateTime dataInicio, DateTime dataFim)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
            return contexto.Set<Documento>()
                           .Include(d => d.Turno)
                           .Include(d => d.Turno.Usuario)
                           .Include(d => d.Turno.Usuario.Acesso)
                           .Include(d => d.Tipo)
                           .Include(d => d.Cliente)
                           .Where(d => d.DataFacturacao >= dataInicio && 
                                       d.DataFacturacao <= dataFim &&
                                       "FT-FR-NC".Contains(d.Tipo.Sigla) &&
                                       d.Estado != EstadoDocumento.Aberto &&
                                       //d.Estado != EstadoDocumento.Anulado &&
                                       d.Estado != EstadoDocumento.Apagado)
                           .ToList();
        }

        private AuditFileMasterFiles RetornaTabelasMestres(DateTime dataInicio, DateTime dataFim)
        {
            var tabelasMestres = new AuditFileMasterFiles();
            //tabelasMestres.GenarelLedger = RetornaGeneralLedger(dataInicio, dataFim);
            tabelasMestres.Customer = RetornaCostumer(dataInicio, dataFim);
            tabelasMestres.Product = RetornaProducts(dataInicio, dataFim);
            tabelasMestres.TaxTable = RetornaTaxTable(dataInicio, dataFim);
            return tabelasMestres;
        }

        private object RetornaGeneralLedger(DateTime dataInicio, DateTime dataFim)
        {
            //var formasPagamentos = RetornaFormaPagamentos();
            //var generalLadger = new AuditFileMasterFilesGeneralLedger[formasPagamentos.Count];
            //for (int i = 0; i < formasPagamentos.Count; i++)
            //{
            //    generalLadger[i] = new AuditFileMasterFilesGeneralLedger();
            //    generalLadger[i].AccountID = formasPagamentos[i].Numero;
            //    generalLadger[i].AccountDescription = formasPagamentos[i].Descricao;
            //    generalLadger[i].OpeningCreditBalance = RetornaFinInicial(
            //        formasPagamentos[i].FormaPagamentoId, 
            //        MovFinanceiro.Credito, dataInicio
            //    );
            //    generalLadger[i].OpeningDebitBalance = RetornaFinInicial(
            //        formasPagamentos[i].FormaPagamentoId, 
            //        MovFinanceiro.Debito, dataInicio
            //    );
            //    generalLadger[i].ClosingCreditBalance = RetornaFinInicial(
            //        formasPagamentos[i].FormaPagamentoId,
            //        MovFinanceiro.Credito, dataFim
            //    );
            //    generalLadger[i].ClosingDebitBalance = RetornaFinInicial(
            //        formasPagamentos[i].FormaPagamentoId,
            //        MovFinanceiro.Debito, dataFim
            //    );
            //    generalLadger[i].GroupingCategory = formasPagamentos[i].TipoConta;
            //    generalLadger[i].GroupingCode = formasPagamentos[i].TipoConta + " " + formasPagamentos[i].FormaPagamentoId;

            //}

            return new { };
        }

        private decimal RetornaFinInicial(int formaPagamentoId, MovFinanceiro mov, DateTime dataFinal)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
            return contexto.Set<FormaPaga>()
                           .Include(f =>f.FormaPagamento)
                           .Where(f => f.FormaPagamentoId == formaPagamentoId &&
                                       f.Pagamento.MovFin == mov &&
                                       f.Pagamento.DataHora <= dataFinal)
                           .ToList()
                           .Sum(f => f.Valor);
        }

        private List<FormaPagamento> RetornaFormaPagamentos()
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
            return contexto.Set<FormaPagamento>()
                           .Where(f => f.Descricao != Globais.MetodoPagamentoPadrao)
                           .ToList();
        }

        private AuditFileMasterFilesTaxTableEntry[] RetornaTaxTable(DateTime dataInicio, DateTime dataFim)
        {
            var produtos = RetornaProdutos(dataInicio, dataFim);
            var taxTable = new AuditFileMasterFilesTaxTableEntry[produtos.Count];
            for (int i = 0; i < produtos.Count; i++)
            {
                taxTable[i] = new AuditFileMasterFilesTaxTableEntry();
                taxTable[i].TaxType = produtos[i].Imposto.TipoImposto.Sigla;
                taxTable[i].TaxCountryRegion = "AO";
                taxTable[i].TaxCode = produtos[i].Imposto.Sigla;
                taxTable[i].Description = produtos[i].Imposto.Nome;
                taxTable[i].TaxPercentage = string.Format("{0}", produtos[i].Imposto.Percentagem).Replace(",",".");
                //taxTable[i].TaxAmount = (produtos[i].Imposto.Percentagem/100) * produtos[i].Preco;
            }


            return taxTable;
        }

        private AuditFileMasterFilesProduct[] RetornaProducts(DateTime dataInicio, DateTime dataFim)
        {
            var produtos = RetornaProdutos(dataInicio, dataFim); 
            var products = new AuditFileMasterFilesProduct[produtos.Count];
            for (int i = 0; i < produtos.Count; i++)
            {
                products[i] = new AuditFileMasterFilesProduct();
                products[i].ProductType = produtos[i].Tipo.ToString().Substring(0, 1);
                products[i].ProductCode = produtos[i].ProdutoId.ToString();
                products[i].ProductDescription = produtos[i].Nome;
                products[i].ProductNumberCode = produtos[i].CodigoDeBarra;
            }
            return products;
        }

        private List<Produto> RetornaProdutos(DateTime dataInicio, DateTime dataFim)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro())) { 
                var list = contexto.Set<Produto>()
                                .Include(p => p.Imposto)
                                .Include(p => p.Imposto.TipoImposto)
                                .Include(p => p.MotivoIsencao)
                               .ToList();

                var newlist = new List<Produto>();

                if (!Util.ListaNula(list))
                {
                    foreach (var item in list)
                    {
                        if (ProdutoMovimentadoNesteIntervalo(item.ProdutoId, dataInicio, dataFim))
                        {
                            newlist.Add(item);
                        }
                    }
                }
                return newlist;
            }
        }

        private bool ProdutoMovimentadoNesteIntervalo(int produtoId, DateTime dataInicio, DateTime dataFim)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro())) {
                var produtoMovs = contexto.Set<ProdutoMovimentacao>()
                                          .Where(p => p.ProdutoEstoque.ProdutoId == produtoId &&
                                          p.Documento.DataFacturacao >= dataInicio && p.Documento.DataFacturacao <= dataFim)
                                          .ToList();

                return !Util.ListaNula(produtoMovs);
            }
                      
        }

        private AuditFileMasterFilesCustomer[] RetornaCostumer(DateTime dataInicio, DateTime dataFim)
        {
            var clientes = RetornaclientesNasFacturas(dataInicio, dataFim);
             var custumer = new AuditFileMasterFilesCustomer[clientes.Count];
            for (int i = 0; i < clientes.Count; i++)
            {
                custumer[i] = new AuditFileMasterFilesCustomer();
                custumer[i].CustomerID = clientes[i].ClienteId.ToString();
                custumer[i].AccountID = "Desconhecido";
                custumer[i].CustomerTaxID =  (clientes[i].Nif == "999999999")? clientes[i].Nome : clientes[i].Nif;
                custumer[i].CompanyName = clientes[i].Nome;
                custumer[i].BillingAddress = new AuditFileMasterFilesCustomerBillingAddress();
                custumer[i].BillingAddress.AddressDetail = string.IsNullOrEmpty(clientes[i].Endereco)? "Não Definido" : clientes[i].Endereco;
                custumer[i].BillingAddress.City = "Luanda";
                custumer[i].BillingAddress.Country = "AO";
                custumer[i].SelfBillingIndicator = "0";

            }
            return custumer;
        }

        private List<Cliente> RetornaclientesNasFacturas(DateTime dataInicio, DateTime dataFim)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro())) { 
                var listcliente = contexto.Set<Cliente>()
                               .ToList();
                var clientes = new List<Cliente>();
                foreach (var item in listcliente)
                {
                    var totalGasto = RetornaTotalGastoDoCliente(item.ClienteId);
                    if (totalGasto > 0)
                    {
                        clientes.Add(item);
                    }

                }
                return clientes;
            }

        }

        private decimal RetornaTotalGastoDoCliente(int clienteId)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
            {
                var total = contexto.Set<Documento>()
                    .Include(d=>d.Tipo)
                    .Where(d => "FR-FT".Contains(d.Tipo.Sigla) && d.ClienteId == clienteId)
                    .Sum(d => d.Total);
                return total;
            }
 

        }

            private AuditFileHeader RetornaCabecalho(DateTime dataInicio, DateTime dataFim)
        {
            var header = new AuditFileHeader();
            header.AuditFileVersion = "2.0";
            var empresa = new EmpresaApp().BuscaTipoEntidadePadrao();
            header.CompanyID = empresa.Nif;
            header.CompanyName = empresa.Nome;
            header.TaxAccountingBasis = "F";
            header.CompanyAddress = new AuditFileHeaderCompanyAddress();
            header.CompanyAddress.AddressDetail = empresa.Endereco;
            header.CompanyAddress.City = empresa.Endereco;
            header.CompanyAddress.Country = "AO";
            header.StartDate = dataInicio;
            header.EndDate = dataFim;
            header.FiscalYear = dataInicio.Year.ToString();
            header.CurrencyCode = Globais.MoedaActual ==  TipoMoeda.Kwanza? "AOA" : "USD";
            header.DateCreated = DateTime.Now;
            header.TaxEntity = "Global";
            header.ProductCompanyTaxID = Globais.NIFDaKivembaSoft;
            header.SoftwareValidationNumber = Globais.NumeroDoCertificadoNaAGT;
            header.ProductID = Globais.NomeSoftware + "/" + Globais.NomeProdutoSoftware;
            header.ProductVersion = Globais.VersaoSistema;
            header.Telephone = Globais.TelefoneProdutoSoftware;
            header.Email = Globais.EmailProdutoSoftware;
            header.TaxRegistrationNumber = empresa.Nif;
            return header;
        }
    }
}
