using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Modelos
{
    [Table(name: "Clients")]
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Nif { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public decimal LimitDebit { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public byte[] Image { get; set; }
        public string Telephone { get; set; }= string.Empty;
    }
}