using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Modelos
{
    [Table(name:"Categories")]
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
    }
}