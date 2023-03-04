using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Modelos
{
    [Table(name: "Caixas")]
    public class Caixa
    {
        public int CaixaId { get; set; }
        public string DispositivoId { get; set; }
        public string Nome { get; set; }
        public int Numero { get; set; }
    }
}