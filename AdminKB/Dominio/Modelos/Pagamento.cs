using AdminKB.Dominio.Enumerados;
using System;

namespace AdminKB.Dominio.Modelos
{
    public class Pagamento
    {
        public int PagamentoId { get; set; }
        public int DocumentoId { get; set; }
        public int DocumetoReciboId { get; set; }
        public Documento Documento { get; set; }
        public int ImpostoId { get; set; }
        public Imposto Imposto { get; set; }
        public string Descricao { get; set; }
        public DateTime DataHora { get; set; }
        public MovFinanceiro MovFin { get; set; }
        public int NumeroOrdem { get; set; }
        public decimal Total { get; set; }
        public decimal Troco { get; set; }

    }
}
