using Dominio.Enumerados;

namespace Dominio.Modelos
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public int ImpostoId { get; set; }
        public Imposto Imposto { get; set; }
        public int MotivoIsencaoId { get; set; }
        public MotivoIsencao MotivoIsencao { get; set; }
        public decimal Preco { get; set; }
        public decimal Custo { get; set; }
        public byte[] Imagem { get; set; }
        public string CodigoDeBarra { get; set; }
        public decimal Retencao { get; set; }
        public bool ControleEstoque { get; set; }
        public bool Vender { get; set; }
        public EstadoEntidade Estado { get; set; }
        public TipoProduto Tipo { get; set; }
    }
}
