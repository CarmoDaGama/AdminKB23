using AdminKB.Dominio.Modelos;
using System.Data.Entity;
using System.Linq;

namespace AdminKB.Aplicacoes
{
    public class DocumentoAnuladoApp : AppBase<DocumentoAnulado>
    {
        public DocumentoAnuladoApp() : base(true)
        {

        }
        public new DocumentoAnulado Adicionar(DocumentoAnulado documentoAnulado)
        {
            base.Adicionar(documentoAnulado);
            return RetornaDocumentoAnuladoId(BuscaUltimaTipoEntidade().DocumentoAnuladoId);
        }
        public DocumentoAnulado RetornaDocumentoAnuladoPorDocumentoId(int documentoId)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                return contexto.Set<DocumentoAnulado>()
                           .Include(da => da.Documento)
                           .Where(da => da.DocumentoId == documentoId)
                           .FirstOrDefault();
        }
        public DocumentoAnulado RetornaDocumentoAnuladoPorNotaCreditoId(int notaCreditoId)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                return contexto.Set<DocumentoAnulado>()
                           .Include(da => da.Documento)
                           .Where(da => da.NotaCreditoId == notaCreditoId)
                           .FirstOrDefault();
        }
        public DocumentoAnulado RetornaDocumentoAnuladoId(int documentoAnuladoId)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                return contexto.Set<DocumentoAnulado>()
                           .Include(da => da.Documento)
                           .Where(da => da.DocumentoAnuladoId == documentoAnuladoId)
                           .FirstOrDefault();
        }
    }
}
