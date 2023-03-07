using System.ComponentModel.DataAnnotations.Schema;

namespace AdminKB.Dominio.Modelos
{
    [Table(name: "Clientes")]
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Nif { get; set; } = string.Empty;
        public string Morada { get; set; } = string.Empty;
        public decimal DebitoLimite { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;
        public byte[] Imagem { get; set; }
        public string Telefone { get; set; }= string.Empty;
    }
}