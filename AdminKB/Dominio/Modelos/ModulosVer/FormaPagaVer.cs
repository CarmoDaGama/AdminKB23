namespace AdminKB.Dominio.Modelos.ModulosVer
{
    public class FormaPagaVer
    {
        public int FormaPagamentoId { get; set; }
        public string Descricao { get; set; }
        public int ContaBancariaId { get; set; }
        public ContaBancaria ContaBancaria { get; set; }
        public decimal Valor { get; set; }
    }
}
