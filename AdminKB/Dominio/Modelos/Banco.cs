using System.ComponentModel.DataAnnotations.Schema;

namespace AdminKB.Dominio.Modelos
{
    [Table(name: "Bancos")]
    public class Banco
    {
        public int BancoId { get; set; }
        public string Nome { get; set; }
    }
}