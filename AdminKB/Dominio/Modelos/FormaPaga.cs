namespace AdminKB.Dominio.Modelos
{
    public class FormaPaga
    {
        public int FormaPagaId { get; set; }
        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        public int PagamentoId { get; set; }
        public Pagamento Pagamento { get; set; }
        public decimal Valor { get; set; }
    }
}
