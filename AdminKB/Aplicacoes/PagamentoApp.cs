using Dominio.Enumerados;
using Dominio.Modelos;
using Dominio.Utilitarios;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace AdminKB.Aplicacoes
{
    public class PagamentoApp : AppBase<Pagamento>
    {
        public PagamentoApp() : base(true)
        {

        }
        public List<Pagamento> RetornaPagamentosPorDocumentoId(int documentoId)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                return contexto.Set<Pagamento>()
                           .Include(p => p.Documento)
                           .Include(p => p.Documento.Tipo)
                           .Include(p => p.Documento.Turno)
                           .Include(p => p.Documento.Cliente)
                           .Include(p => p.Imposto.TipoImposto)
                           .Where(p => p.DocumentoId == documentoId)
                           .ToList();
        }
        public List<Pagamento> RetornaPagamentosDiferentesPorDocumentoId(int documentoId)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                return contexto.Set<Pagamento>()
                           .Include(p => p.Documento)
                           .Include(p => p.Documento.Tipo)
                           .Include(p => p.Documento.Turno)
                           .Include(p => p.Documento.Cliente)
                           .Include(p => p.Imposto.TipoImposto)
                           .Where(p => p.DocumetoReciboId == documentoId &&
                                  p.DocumetoReciboId != p.DocumentoId)
                           .ToList();
        }
        public Pagamento RetornaPagamentosIguaisPorDocumentoId(int documentoId)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                return contexto.Set<Pagamento>()
                           .Include(p => p.Documento)
                           .Include(p => p.Documento.Tipo)
                           .Include(p => p.Documento.Turno)
                           .Include(p => p.Documento.Cliente)
                           .Include(p => p.Imposto.TipoImposto)
                           .Where(p => p.DocumetoReciboId == documentoId &&
                                  p.DocumetoReciboId == p.DocumentoId)
                           .FirstOrDefault();
        }
        public Pagamento RetornaPagamentoPorDocumentoId(int documentoId)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                return contexto.Set<Pagamento>()
                           .Include(p => p.Documento)
                           .Include(p => p.Documento.Tipo)
                           .Include(p => p.Documento.Turno)
                           .Include(p => p.Documento.Cliente)
                           .Include(p => p.Imposto.TipoImposto)
                           .Where(p => p.DocumentoId == documentoId)
                           .FirstOrDefault();
        }


        public List<Pagamento> RetornaPagamentosPorTurnoId(int turnoId)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                return contexto.Set<Pagamento>()
                           .Include(p => p.Documento)
                           .Include(p => p.Documento.Tipo)
                           .Include(p => p.Documento.Turno)
                           .Include(p => p.Documento.Cliente)
                           .Include(p => p.Imposto.TipoImposto)
                           .ToList()
                           .Where(p => p.Documento.TurnoId == turnoId &&
                           p.Documento.Estado == EstadoDocumento.Fechado && 
                           new DocumentoApp().RetornaDocumentoPorId(p.DocumetoReciboId).Estado == EstadoDocumento.Fechado)
                           .ToList();
        }

        public Pagamento RetornaPagamentoPorPagmentoId(int pagamentoId)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                return contexto.Set<Pagamento>()
                           .Include(p => p.Documento)
                           .Include(p => p.Documento.Tipo)
                           .Include(p => p.Documento.Turno)
                           .Include(p => p.Documento.Cliente)
                           .Include(p => p.Imposto.TipoImposto)
                           .Where(p => p.PagamentoId == pagamentoId)
                           .FirstOrDefault();
        }
        public decimal RetornaTotalPagamentosPorDocumentoId(int documentoId)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                return contexto.Set<Pagamento>()
                           .Include(p => p.Documento)
                           .Include(p => p.Documento.Tipo)
                           .Include(p => p.Documento.Turno)
                           .Include(p => p.Documento.Cliente)
                           .Include(p => p.Imposto.TipoImposto)
                           .Where(p => p.DocumentoId == documentoId)
                           .ToList()
                           .Sum(p => p.Total);
        }

        public int RetornaProximoNumeroOrdem()
        {
            var ultimoPamento = BuscaUltimaTipoEntidade();
            if (ultimoPamento is null)
            {
                return 1;
            }
            else
            {
                return ultimoPamento.NumeroOrdem + 1;
            }
        }
        public new Pagamento Adicionar(Pagamento pagamento)
        {
            base.Adicionar(pagamento);
            return RetornaPagamentoPorPagmentoId(pagamento.PagamentoId);
        }


        public Pagamento GravarPagamento(int documentoReciboId, int documentoId, decimal total, decimal troco, string descricao)
        {
            var NumeroOrdemPagamento = RetornaProximoNumeroOrdem();
            descricao = descricao.ToUpper();
            var _documentoApp = new DocumentoApp();
            var _documento = _documentoApp.RetornaDocumentoPorId(documentoId);
            var documentoRecibo = _documentoApp.RetornaDocumentoPorId(documentoReciboId);
            if (documentoId != documentoReciboId)
            {
                descricao = "LIQUIDAÇÃO DA " + _documento.Tipo.Nome + " " + _documento.Tipo.Sigla + "/" + _documento.NumeroOrdem;
            }

            var pagamento = Adicionar(new Pagamento
            {
                DocumentoId = documentoId,
                DocumetoReciboId = documentoReciboId,
                DataHora = DateTime.Now,
                Descricao = descricao.ToUpper(),
                ImpostoId = Globais.ImpostoPadrao.ImpostoId,
                MovFin = documentoRecibo.Tipo.Financeiro,
                NumeroOrdem = NumeroOrdemPagamento,
                Total = total,
                Troco = troco
            });
            _documento.Liquidado = true;
            _documentoApp.Actualizar(_documento);
            return RetornaPagamentoPorPagmentoId(BuscaUltimaTipoEntidade().PagamentoId);
        }

        public void GravarFormaPagamentoUsada(int pagamentoId, decimal valor)
        {
            var formaPay = new FormaPagamentoApp().RetornaFormasPagaVer().FirstOrDefault();
            new FormaPagaApp().Adicionar(new FormaPaga
            {
                FormaPagamentoId = formaPay.FormaPagamentoId,
                PagamentoId = pagamentoId,
                Valor = valor
            });
        }
    }
}
