using System;

namespace AdminKB.Dominio.Modelos.ModulosVer
{
    public class ProdutoComposicaoVer
    {
        public int ProdutoComposicaoId { get; set; }

        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }

        public int ProdutoComponenteId { get; set; }
        public Produto ProdutoComponente { get; set; }

        public decimal Quantidade { get; set; }
        public DateTime DataDeRegistro { get; set; }
    }
}
