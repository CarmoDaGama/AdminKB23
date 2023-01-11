using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Modelos
{
    [Table(name: "Impostos")]
    public class Imposto
    {
        public int ImpostoId { get; set; }
        public int TipoImpostoId { get; set; }
        public TipoImposto TipoImposto { get; set; }
        public string Sigla { get; set; }
        public string Nome { get; set; }
        public decimal Percentagem { get; set; }
        public DateTime DataVigencia { get; set; }
    }
}