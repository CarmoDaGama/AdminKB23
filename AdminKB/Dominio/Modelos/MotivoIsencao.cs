using System.ComponentModel.DataAnnotations.Schema;

namespace AdminKB.Dominio.Modelos
{
    [Table(name: "MotivoIsencoes")]
    public class MotivoIsencao
    {
        public int MotivoIsencaoId { get; set; }
        public string Nome { get; set; }
        public string Referencia { get; set; }
    }
}