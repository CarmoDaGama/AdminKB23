using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Modelos
{
    [Table(name:"Safts")]
    public class Saft
    {
        public int SaftId { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Caminha { get; set; }
    }
}
