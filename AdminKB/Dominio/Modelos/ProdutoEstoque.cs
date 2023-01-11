using DevExpress.Utils.Svg;
using Dominio.Enumerados;
using Dominio.Utilitarios;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace Dominio.Modelos
{
    [Table(name: "ProdutoEstoques")]
    public class ProdutoEstoque
    {
        public int ProdutoEstoqueId { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public int EstoqueId { get; set; }
        public Estoque Estoque { get; set; }
        public string NumeroDeSerie { get; set; } = string.Empty;
        public decimal QuantidadeMaxima { get; set; }
        public decimal QuantidadeMinima { get; set; }
        public DateTime DataDeFabricacao { get; set; }
        public DateTime DataDeExpiracao { get; set; }
        public DateTime DataDeRegistro { get; set; }
        public decimal Quantidade { get; set; }
        public bool UmLote { get; set; }
        public EstadoEntidade Estado { get; set; }
        public object ProdutoImagem { 
            get {
                object img = Imagem.ByteToImage(Produto.Imagem);
                if (Util.ObjectoNulo(img))
                {
                    img = Imagem.ByteToSvgImage(Produto.Imagem);
                }
                return Util.ObjectoNulo(img) ? Globais.ProductFull : img;
            }
        }
    }
}
