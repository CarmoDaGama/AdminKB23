using AdminKB.Dominio.Enumerados;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminKB.Dominio.Modelos
{
    [Table(name: "TipoDocumentos")]
    public class TipoDocumento
    {
        public int TipoDocumentoId { get; set; }
        public string Nome { get; set; }
        public MovFinanceiro Financeiro { get; set; }
        public MovEstoque Estoque { get; set; }
        public string Sigla { get; set; }
        public Destino Destino { get; set; }
    }
}
