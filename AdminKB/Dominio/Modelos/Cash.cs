using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Modelos
{
    [Table(name: "Cashs")]
    public class Cash
    {
        public int CashId { get; set; }
        public string DeviceId { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
    }
}