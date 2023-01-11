using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Modelos
{
    [Table(name: "ProdutoMovimentacoes")]
    public class ProdutoMovimentacao
    {
        public int ProdutoMovimentacaoId { get; set; }
        public int DocumentoId { get; set; }
        public Documento Documento { get; set; }
        public int ProdutoEstoqueId { get; set; }
        public ProdutoEstoque ProdutoEstoque { get; set; }
        public decimal Preco { get; set; }
        public decimal Retencao { get; set; }
        public decimal Quantidade { get; set; }
        public decimal Total { get; set; }
        public decimal Imposto { get; set; }
        public decimal Desconto { get; set; }
        public decimal TotaIliquido { get; set; }
        public decimal DescontoPercentagem { get; set; }
    }
}
