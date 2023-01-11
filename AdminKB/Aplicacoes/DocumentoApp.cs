using Dominio.Enumerados;
using Dominio.Modelos;
using Dominio.Modelos.ModulosVer;
using Dominio.Utilitarios;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace AdminKB.Aplicacoes
{
    public class DocumentoApp : AppBase<Documento>
    {
        public DocumentoApp() : base(true)
        {

        }

        public Documento CriarDocumento(Documento documento)
        {
            Iniciar_Contexto(Ficheiro.LerConexaoNoFicheiro());
            documento.NumeroOrdem = RetornaUltimoNumerodocumento(documento.Tipo.Sigla) + 1;
            documento.Mascara = documento.Tipo.Sigla + "/" + documento.NumeroOrdem;
            documento.Descricao = string.IsNullOrEmpty(documento.Descricao)? 
                documento.Tipo.Nome + " Nº " + documento.NumeroOrdem: documento.Descricao;
            documento.DataUltimaActualizacao = DateTime.Now;
            Adicionar(documento);
            
            return RetornaDocumentoPorId(BuscaUltimaTipoEntidade().DocumentoId);
        }
        public new void Adicionar(Documento documento)
        {
            if (documento.DataUltimaActualizacao == new DateTime())
            {
                documento.DataUltimaActualizacao = DateTime.Now;
            }
            var tipo = documento.Tipo;
            documento.Tipo = null;
            documento.TipoDocumentoId = tipo.TipoDocumentoId;
            base.Adicionar(documento);
            documento.Tipo = tipo;
        }
        public Documento RetornaUltimoDocumentoAberto(int turnoId)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                return contexto.Set<Documento>()
                            .Include(dc => dc.Cliente)
                            .Include(dc => dc.Tipo)
                            .Include(dc => dc.Turno)
                            .Include(dc => dc.Turno.Usuario)
                            .Where(dc => dc.TurnoId == turnoId && dc.Estado == EstadoDocumento.Aberto)
                            .FirstOrDefault();
        }

        public List<Documento> RetornaClientesDevedores()
        {
            var devedores = new List<Documento>();

            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro())) { 
                var documentos = contexto.Set<Documento>()
                            .Include(dc => dc.Cliente)
                            .Include(dc => dc.Tipo)
                            .Include(dc => dc.Turno)
                            .Include(dc => dc.Turno.Usuario)
                            .ToList()
                            .Where(dc => dc.Tipo.Sigla == "FT" && !DocumentoPago(dc.DocumentoId) && dc.Estado == EstadoDocumento.Fechado)
                            .ToList();
                foreach (var item in documentos)
                {
                    var resultDevedor = devedores.Where(d => d.ClienteId == item.ClienteId).FirstOrDefault();
                    if (resultDevedor is null)
                    {
                        devedores.Add(item);
                    }
                    else
                    {
                        resultDevedor.Total += item.Total;
                        resultDevedor.TotalIliquido += item.TotalIliquido;
                    }

                }

                return devedores;
            }
        }

        public List<Documento> RetornaDocumentoNaoPagosPorClienteId(int clienteId)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro())) { 
                var documentos = contexto.Set<Documento>()
                            .Include(dc => dc.Cliente)
                            .Include(dc => dc.Tipo)
                            .Include(dc => dc.Turno)
                            .Include(dc => dc.Turno.Usuario)
                            .ToList()
                            .Where(dc => dc.Tipo.Sigla == "FT" && !DocumentoPago(dc.DocumentoId) &&
                                   dc.ClienteId == clienteId)
                            .ToList();
            //foreach (var doc in documentos)
            //{
            //    doc.Total = RetornaDocumentoPorId(doc.DocumentoId).Total;
            //    doc.TotalIliquido = RetornaDocumentoPorId(doc.DocumentoId).TotalIliquido;
            //}
                return documentos;
            }
        }
        private bool DocumentoPago(int documentoId)
        {
            var pagamento = new PagamentoApp().RetornaPagamentoPorDocumentoId(documentoId);

            return !(pagamento is null);
        }
        private int RetornaUltimoNumerodocumento(string sigla)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro())) { 
                var ultimoDocumento = contexto.Set<Documento>()
                                     .Where(dc => dc.Tipo.Sigla == sigla)
                                     .ToList()
                                     .LastOrDefault();

                return Util.ObjectoNulo(ultimoDocumento) ? 0 : ultimoDocumento.NumeroOrdem;
            }
        }

        public List<Documento> RetornaDocumentosPorTurnoId(int turnoId)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                return contexto.Set<Documento>()
                           .Include(dc => dc.Cliente)
                           .Include(dc => dc.Tipo)
                           .Include(dc => dc.Turno)
                           .Include(dc => dc.Turno.Usuario)
                           .Where(dc => dc.TurnoId == turnoId &&
                                        dc.Tipo.Financeiro != MovFinanceiro.Isento &&
                                        dc.Estado == EstadoDocumento.Fechado)
                           .ToList();
        }
        public List<OperacaoRecenteVer> RetornaOperacoesRecetesPorTurnoId(int turnoId)
        {
            var operacoes = RetornaDocumentosPorTurnoId(turnoId);

            var operacoesRecent = new List<OperacaoRecenteVer>();
            foreach (var item in operacoes)
            {
                var result = operacoesRecent.Where(op => op.Nome == item.Tipo.Nome).FirstOrDefault();
                if (result is null)
                {
                    operacoesRecent.Add(new OperacaoRecenteVer()
                    { 
                        Nome = item.Tipo.Nome.ToUpper(),
                        Descricao = item.Tipo.Nome.ToUpper() + "(" + item.Tipo.Financeiro.ToString().ToUpper() + ")",
                        StrTotal = Util.MostrarValorNaMoedaActual(item.Total),
                        Total = item.Total
                    });
                }
                else
                {
                    result.Total += item.Total;
                    result.StrTotal = Util.MostrarValorNaMoedaActual(result.Total);
                }
                
            }
            return operacoesRecent;
        }

        public Documento RetornaDocumentoPorId(int documentoId)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                return contexto.Set<Documento>()
                           .Include(dc => dc.Cliente)
                           .Include(dc => dc.Tipo)
                           .Include(dc => dc.Turno)
                           .Include(dc => dc.Turno.Usuario)
                           .Where(dc => dc.DocumentoId == documentoId)
                           .FirstOrDefault();
        }

        public Documento RetornaUltimoDocumentoAbertoPorSigla(string tipoSigla)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro())) { 
                if (Util.UsuarioForAdministrador())
                {
                    return contexto.Set<Documento>()
                                   .Include(dc => dc.Cliente)
                                   .Include(dc => dc.Tipo)
                                   .Include(dc => dc.Turno)
                                   .Include(dc => dc.Turno.Usuario)
                                   .Where(dc => dc.Tipo.Sigla == tipoSigla && dc.Estado == EstadoDocumento.Aberto)
                                   .FirstOrDefault();
                }
                else
                {
                    return contexto.Set<Documento>()
                                   .Include(dc => dc.Cliente)
                                   .Include(dc => dc.Tipo)
                                   .Include(dc => dc.Turno)
                                   .Include(dc => dc.Turno.Usuario)
                                   .Where(dc => dc.Tipo.Sigla == tipoSigla &&
                                          dc.Turno.UsuarioId == Globais.UsuarioIdActual &&
                                          dc.Estado == EstadoDocumento.Aberto)
                                   .FirstOrDefault();

                }
            }
        }

        public int RetornaProximoNumeroDocumentoPorSigla(string sigla)
        {
            return RetornaUltimoNumerodocumento(sigla) + 1;
        }

        public Documento RetornaNovoDocumento(string sigla, int clienteId, int turnoId, decimal totalInicial, string nomeCliente, string descricacao)
        {
            var numeroOrdem = RetornaProximoNumeroDocumentoPorSigla(sigla);
            var tipo = new TipoDocumentoApp().RetornaTipoDocumentoPorSigla(sigla);
            Adicionar(new Documento()
            {
                TipoDocumentoId = tipo.TipoDocumentoId,
                ClienteId = clienteId,
                DataFacturacao = DateTime.Now,
                Estado = EstadoDocumento.Aberto,
                EstadoImpressao = EstadoImpressao.NaoImprimido,
                NumeroOrdem = numeroOrdem,
                Total = totalInicial,
                Mascara = sigla + "/" + numeroOrdem,
                TurnoId = turnoId,
                Liquidado = false,
                Descricao = descricacao,
                NomeCliente = nomeCliente,
                DataVencimento = Util.RetornaDataVencime(10)
            });

            return RetornaDocumentoPorId(BuscaUltimaTipoEntidade().DocumentoId);
        }

        public List<Documento> RetornaDocumentosPorTipoId(int tipoDocumentoId, DateTime dateInit, DateTime dateEnd)
        {

            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                return contexto.Set<Documento>()
                           .Include(dc => dc.Cliente)
                           .Include(dc => dc.Tipo)
                           .Include(dc => dc.Turno)
                           .Include(dc => dc.Turno.Usuario)
                           .Where(dc => (dc.DataFacturacao >= dateInit && dc.DataFacturacao <= dateEnd) &&
                           dc.Tipo.TipoDocumentoId == tipoDocumentoId)
                           .ToList();
        }

        public List<Documento> RetornaDocumentosPorUsuarioId_TipoDocumentoIdAndIntervalo(int usuarioId, int tipoDocumentoId, DateTime dateInit, DateTime dateEnd)
        {

            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro())) {
                var list = contexto.Set<Documento>()
                           .Include(dc => dc.Cliente)
                           .Include(dc => dc.Tipo)
                           .Include(dc => dc.Turno)
                           .Include(dc => dc.Turno.Usuario)
                           .Where(dc => (dc.DataFacturacao >= dateInit && dc.DataFacturacao <= dateEnd) &&
                           dc.Turno.UsuarioId == usuarioId && dc.Tipo.TipoDocumentoId == tipoDocumentoId)
                           .ToList();
                return list;
            }
        }

        public List<Documento> RetornaDocumentoPorIntervaloDatas(DateTime dateInit, DateTime dateEnd)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                return contexto.Set<Documento>()
                               .Include(dc => dc.Cliente)
                               .Include(dc => dc.Tipo)
                               .Include(dc => dc.Turno)
                               .Include(dc => dc.Turno.Usuario)
                               .Where(dc => dc.DataFacturacao >= dateInit && dc.DataFacturacao <= dateEnd)
                               .ToList();
        }
        public List<Documento> RetornaDocumentoPorUsuarioIdAndIntervaloDatas(int usuarioId, DateTime dateInit, DateTime dateEnd)
        {

            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                return contexto.Set<Documento>()
                           .Include(dc => dc.Cliente)
                           .Include(dc => dc.Tipo)
                           .Include(dc => dc.Turno)
                           .Include(dc => dc.Turno.Usuario)
                           .Where(dc => (dc.DataFacturacao >= dateInit && dc.DataFacturacao <= dateEnd) &&
                           dc.Turno.UsuarioId == usuarioId)
                           .ToList();

        }
        public decimal RetornaSaldoDaEmpresa()
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro())) { 
                var allDocsFins = contexto.Set<Documento>()
                .Include(d => d.Cliente)
                .Include(d => d.Tipo)
                .Include(d => d.Turno)
                .Include(d => d.Turno.Usuario)
                .Where(d => d.Tipo.Financeiro != MovFinanceiro.Isento)
                .OrderByDescending(d => d.DataFacturacao)
                .ToList();
                var balanceDebit = allDocsFins.Where(d => d.Tipo.Financeiro == MovFinanceiro.Debito).Sum(d => d.Total);
                var balanceCredit = allDocsFins.Where(d => d.Tipo.Financeiro == MovFinanceiro.Credito).Sum(d => d.Total);

                return balanceCredit - balanceDebit;
            }
        }
        public new void Actualizar(Documento documento)
        {
            //documento.Cliente = null;
            if (documento.Estado == EstadoDocumento.Fechado)
            {
                var hashAnterior = RetornaHashAnteriorPorTipo(documento.Tipo.Sigla, documento.NumeroOrdem - 1);
                if ("FR-FT-RG-NC".Contains(documento.Tipo.Sigla) && (string.IsNullOrEmpty(documento.Hash) || documento.Hash == " "))
                {
                    var codigoAGT = documento.Tipo.Sigla + " " + (DateTime.Now.Year - 2021) + "/" + Util.RetornaStringDigitos(documento.NumeroOrdem, 2);
                    documento.Hash = SSL.GerarHash(
                                        SSL.RetornaDadosHash(
                                            documento.DataFacturacao, 
                                            codigoAGT,
                                            documento.Total, 
                                            hashAnterior                    
                                        )
                                    );
                }
                var count = string.IsNullOrEmpty(documento.Hash)? 0 : documento.Hash.Length;
            }
            documento.TipoDocumentoId = documento.Tipo.TipoDocumentoId;
            documento.Tipo = null;
            documento.DataUltimaActualizacao = DateTime.Now;
            base.Actualizar(documento);
            var recentDocumento = RetornaDocumentoPorId(documento.DocumentoId);
            documento.Tipo = recentDocumento.Tipo;
            documento.Turno = recentDocumento.Turno;
            documento.Cliente = recentDocumento.Cliente;
        }

        private string RetornaHashAnteriorPorTipo(string tipoSigla, int numeroOrdem)
        {
            if (numeroOrdem <= 0)
            {
                return string.Empty;
            }
            else
            {

                using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                {
                    var documentoAnterior = contexto.Set<Documento>()
                                           .Include(dc => dc.Tipo)
                                           .Where(dc => dc.Tipo.Sigla == tipoSigla && dc.NumeroOrdem == numeroOrdem)
                                           .FirstOrDefault();
                    if (documentoAnterior is null)
                    {
                        return string.Empty;
                    }
                    return documentoAnterior.Hash;
                }
            }
        }

        public void ActualizarTotaisDocumento(Documento documento, List<ProdutoMovimentacao> produtos)
        {
            if (!Util.ListaNula(produtos))
            {
                documento.Total = produtos.Sum(pf => pf.Total);
                documento.TotalIliquido = produtos.Sum(pf => pf.Total);
                documento.Retencao = produtos.Sum(pf => Util.CalcularValorRetencaoArtigo(pf));
                documento.DescontoTotal = produtos.Sum(pf => Util.CalcularValorDescontoArtigo(pf));
                documento.Imposto = produtos.Sum(pf => Util.CalcularValorImpostoArtigo(pf));
                string oldHash = documento.Hash;
                documento.Hash = string.Empty;
                Actualizar(documento);
            }
        }
        public bool DataUltimoDocumentoMaiorDataActual()
        {
            var documento = BuscaUltimaTipoEntidade();
            return !(documento is null) && documento.DataFacturacao > DateTime.Now;
        }
        public void TerminarDocumento(int documentoId)
        {
            var documento = RetornaDocumentoPorId(documentoId);
            documento.Estado = EstadoDocumento.Fechado;
            Actualizar(documento);
        }
    }
}
