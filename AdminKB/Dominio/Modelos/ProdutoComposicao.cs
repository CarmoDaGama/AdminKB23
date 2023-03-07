using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminKB.Dominio.Modelos
{
    [Table(name:"ProdutoComposicoes")]
    public class ProdutoComposicao
    {
        public int ProdutoComposicaoId { get; set; }

        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }

        public int ProdutoComponenteId { get; set; }
        public decimal Quantidade { get; set; }
        public DateTime DataDeRegistro { get; set; }
    }
}
