using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Modelos
{
    [Table(name: "DocumentoAnulados")]
    public class DocumentoAnulado
    {
        public int DocumentoAnuladoId { get; set; }
        public int NotaCreditoId { get; set; }
        public int DocumentoId { get; set; }
        public Documento Documento { get; set; }
        public string Motivo { get; set; }
        public DateTime Data { get; set; }
    }
}
