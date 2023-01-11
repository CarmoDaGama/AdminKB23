using Dominio.Enumerados;
using Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace AdminKB.Aplicacoes
{
    public class FormaPagaApp : AppBase<FormaPaga>
    {
        public FormaPagaApp():base(true)
        {

        }

        public FormaPaga RetornaFormaPagaPorDocumentoId(int documentoId)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                return contexto.Set<FormaPaga>()
                            .Include(fp => fp.FormaPagamento)
                            .Include(fp => fp.Pagamento)
                            .Include(fp => fp.Pagamento.Documento)
                            .Where(fp => fp.Pagamento.DocumentoId == documentoId)
                            .FirstOrDefault();
        }
        public List<FormaPaga> RetornaFormasPagaPorDocumentoId(int documentoId)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                return contexto.Set<FormaPaga>()
                            .Include(fp => fp.FormaPagamento)
                            .Include(fp => fp.Pagamento)
                            .Include(fp => fp.Pagamento.Documento)
                            .Where(fp => fp.Pagamento.DocumentoId == documentoId)
                            .ToList();
        }
        public List<FormaPaga> RetornaFormaPagamentosEfectuadasPorTurnoId(int turnoId)
        {
           var documentoApp = new DocumentoApp();
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro())) { 
                var fpaga = contexto.Set<FormaPaga>()
                           .Include(fp => fp.FormaPagamento)
                           .Include(fp => fp.Pagamento)
                           .Include(fp => fp.Pagamento.Documento)
                           .ToList();
                fpaga = fpaga.Where(fp => documentoApp.RetornaDocumentoPorId(fp.Pagamento.DocumetoReciboId).TurnoId == turnoId)
                .ToList();
                return fpaga;
            }
        }
        public List<FormaPaga> RetornaFormaPagamentosEfectuadasPorDocumentoId(int documentoId)
        {
            var documentoApp = new DocumentoApp();

            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
            {
                return contexto.Set<FormaPaga>()
                        .Include(fp => fp.FormaPagamento)
                        .Include(fp => fp.Pagamento)
                        .Include(fp => fp.Pagamento.Documento)
                        .ToList()
                        .Where(fp => fp.Pagamento.DocumetoReciboId == documentoId &&
                        fp.Pagamento.DocumetoReciboId == fp.Pagamento.DocumentoId)
                        .ToList();
            }
        }
    }
}
